using RejAndOlej.Forms.CreationForms;
using RejAndOlej.Forms.SearchingTables;
using RejAndOlej.Helpers;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Models;
using RejAndOlej.Views.TableViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RejAndOlej.Enums;
using RejAndOlej.Service;
using RejAndOlej.DATABASE;

namespace RejAndOlej.UserControls.Flota
{
    public partial class uc_OilChecks : BaseUserControl
    {
        public uc_OilChecks()
        {
            InitializeComponent();

            context = new RejAndOlejContext();

            manipulationControls = groupBoxDataManipulation.Controls;
            labelLeftToNextCheck.Text = "Nie wybrano żadnego pojazdu";

            RegisterEvents();
        }

        private void RegisterEvents()
        {
            dataGridViewOilChecksList.RowStateChanged += (s, e) => initManipulationControls();
            dataGridViewOilChecksList.CellStateChanged += (s, e) => initManipulationControls();

            dataGridViewOilChecksList.DoubleClick += (s, e) => { FormHelpers.EnableManipulationControls(EnModels.ModelActions.Edit, manipulationControls); DBAction = EnModels.ModelActions.Edit; };
        }

        private void initDataGridView()
        {
            if (selectedVehicle != null)
            {
                ICollection<OilCheck> oilCheckList = selectedVehicle.OilChecks;
                displayList = OilChecksMainTableView.GetOilChecksView(oilCheckList);
                dataGridViewOilChecksList.DataSource = displayList;

                if (oilCheckList.Count != 0)
                {
                    var lastCheck = oilCheckList.Last();

                    long? fromLastCheck = Convert.ToInt64(tbMileage.Text) - lastCheck.MileageOnOilCheck;
                    if (fromLastCheck < lastCheck.FleetVechicle.Bus.DefaultKmToOilInspection)
                    {
                        labelLeftToNextCheck.ForeColor = Color.Green;
                        labelLeftToNextCheck.Text = "Do następnego przeglądu: " + Convert.ToString(lastCheck.FleetVechicle.Bus.DefaultKmToOilInspection - fromLastCheck) + " km";
                    }
                    else
                    {
                        labelLeftToNextCheck.ForeColor = Color.Red;
                        labelLeftToNextCheck.Text = "Przegląd spóżniony! Przegląd przeterminowany na " + Convert.ToString(fromLastCheck - lastCheck.FleetVechicle.Bus.DefaultKmToOilInspection);
                    }
                }
                else
                {
                    labelLeftToNextCheck.ForeColor = Color.Red;
                    labelLeftToNextCheck.Text = "Pojazd jezcze nie ma wprowadzonych przeglądów olejowych!";
                }
            }
            else
            {
                labelLeftToNextCheck.Text = "Nie wybrano żadnego pojazdu";
            }
        }

        private void initManipulationControls()
        {
            var check = GridViewHelpers.GetObjectFromDataGridViewRow<OilCheck>(dataGridViewOilChecksList, "");
            
            if (check != null)
            {
                textBoxMileageOnCheck.Text = check.MileageOnOilCheck.ToString();
                dateTimeOilCheck.Value = (DateTime)check.DateOfOilCheck;
            }
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            frm_SearchVehicles frm_Search = new frm_SearchVehicles();
            if (frm_Search.ShowDialog() == DialogResult.OK)
            {
                selectedVehicle = frm_Search.SelectedVehicle;

                if (selectedVehicle != null)
                {
                    tbModelName.Text = selectedVehicle.Bus.BusMaker.Name + " " + selectedVehicle.Bus.ModelName;
                    tbRegistrationNumber.Text = selectedVehicle.RegistrationNumber;
                    tbMileage.Text = selectedVehicle.Mileage.ToString();
                }
                initDataGridView();
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            frm_AddCheck frmAddCheck = null;

            if (selectedVehicle != null )
                 frmAddCheck = new frm_AddCheck(selectedVehicle);
            else
            {
                MessageBox.Show("Wybierz pojazd, dla którego chcesz wpisać nowy przegląd", "Pojazd nie jest wybrany");
                return;
            }

            if (frmAddCheck.ShowDialog() == DialogResult.OK)
            {
                if (frmAddCheck.CheckType == EnChecks.CheckTypes.Oil)
                {
                    OilCheck newOilCheck = frmAddCheck.NewOilCheck;

                    using (RejAndOlejContext tempContext = new RejAndOlejContext())
                    {
                        tempContext.OilChecks.Add(newOilCheck);
                        
                        if (frmAddCheck.SetMileageAsActual)
                            selectedVehicle.Mileage = newOilCheck.MileageOnOilCheck;

                        tempContext.SaveChanges();
                    }

                }
            }
            
            DBAction = EnModels.ModelActions.Insert;
            initDataGridView();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            FormHelpers.EnableManipulationControls(EnModels.ModelActions.Edit, manipulationControls);
            DBAction = EnModels.ModelActions.Edit;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                OilCheck check = GridViewHelpers.GetObjectFromDataGridViewRow<OilCheck>(dataGridViewOilChecksList, "");
                switch (DBAction)
                {
                    case EnModels.ModelActions.Insert:
                        break;

                    case EnModels.ModelActions.Edit:
                        if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                        {
                            using (RejAndOlejContext tempContext = new RejAndOlejContext())
                            {
                                tempContext.Update(check);
                                check.MileageOnOilCheck = Convert.ToInt64(textBoxMileageOnCheck.Text);
                                check.DateOfOilCheck = dateTimeOilCheck.Value;
                                tempContext.SaveChanges();
                            }
                        }
                        initDataGridView();
                        break;
                }
            }
        }

        private void cbSetActualMileageAsMileageOnCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
                textBoxMileageOnCheck.Text = tbMileage.Text;
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            if (displayList != null && displayList.Count != 0)
            {
                ListPrinter printer = new ListPrinter(displayList);

                printer.Print();
            }
            else
                MessageBox.Show("Brak danych do wydruku!");
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            using (RejAndOlejContext tempContext = new RejAndOlejContext())
            {
                if (dataGridViewOilChecksList.SelectedRows.Count > 0 || dataGridViewOilChecksList.SelectedCells.Count > 0)
                {
                    var rowToDelete = GridViewHelpers.GetObjectFromDataGridViewRow<OilCheck>(dataGridViewOilChecksList, "");

                    tempContext.Remove(rowToDelete);
                    tempContext.SaveChanges();
                }
                else
                    MessageBox.Show("Proszę wybrać przegląd do usunięcia", "Brak Danych do usunięcia");
            }

            initDataGridView();
        }
    }
}
