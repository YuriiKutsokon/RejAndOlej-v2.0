using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RejAndOlej.DATABASE;
using RejAndOlej.Enums;
using RejAndOlej.Forms.CreationForms;
using RejAndOlej.Forms.SearchingTables;
using RejAndOlej.Helpers;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Models;
using RejAndOlej.Service;
using RejAndOlej.Views.TableViews;

namespace RejAndOlej.UserControls.Flota
{
    public partial class uc_RegistrationChecks : BaseUserControl
    {
        public uc_RegistrationChecks()
        {
            InitializeComponent();

            manipulationControls = groupBoxDataManipulation.Controls;
            labelLeftToNextCheck.Text = "Nie wybrano żadnego pojazdu";

            context = new RejAndOlejContext();

            RegisterEvents();
        }

        private void RegisterEvents()
        {
            dataGridViewRegistrationChecksList.RowStateChanged += (s, e) => initManipulationControls();
            dataGridViewRegistrationChecksList.CellStateChanged += (s, e) => initManipulationControls();

            dataGridViewRegistrationChecksList.DoubleClick += (s, e) => { FormHelpers.EnableManipulationControls(EnModels.ModelActions.Edit, manipulationControls); DBAction = EnModels.ModelActions.Edit; };
        }

        private void initDataGridView()
        {
            if (selectedVehicle != null)
            {
                ICollection<RegistrationCheck> checkslist = selectedVehicle.RegistrationChecks;
                displayList = TableViewHelpers.GetView<RegistrationChecksMainTableView>(checkslist);
                dataGridViewRegistrationChecksList.DataSource = displayList;

                if (checkslist.Count != 0)
                {
                    var lastCheck = checkslist.Last();

                    int? fromLastCheck = (DateTime.Now.Date - lastCheck.DateOfRegCheck.Value.Date).Days;
                    if (fromLastCheck < lastCheck.FleetVehicle.Bus.DefaultDaysToRegistrationReview && (lastCheck.FleetVehicle.Bus.DefaultDaysToRegistrationReview - fromLastCheck) < 10)
                    {
                        labelLeftToNextCheck.ForeColor = Color.Orange;
                        labelLeftToNextCheck.Text = "Do następnego przeglądu: " + Convert.ToString(lastCheck.FleetVehicle.Bus.DefaultDaysToRegistrationReview - fromLastCheck) + " dni";
                        lastCheck.FleetVehicle.RegCheckStatus = EnChecks.CheckStatuses.Nearby;
                        ContextHelpers.SaveModelObject(lastCheck);
                    }
                    else if (fromLastCheck < lastCheck.FleetVehicle.Bus.DefaultDaysToRegistrationReview)
                    {
                        labelLeftToNextCheck.ForeColor = Color.Green;
                        labelLeftToNextCheck.Text = "Do następnego przeglądu: " + Convert.ToString(lastCheck.FleetVehicle.Bus.DefaultDaysToRegistrationReview - fromLastCheck) + " dni";
                        lastCheck.FleetVehicle.RegCheckStatus = EnChecks.CheckStatuses.Valid;
                        ContextHelpers.SaveModelObject(lastCheck);
                    }
                    else
                    {
                        labelLeftToNextCheck.ForeColor = Color.Red;
                        labelLeftToNextCheck.Text = "Przegląd spóżniony! Przegląd przeterminowany na " + Convert.ToString(fromLastCheck - lastCheck.FleetVehicle.Bus.DefaultDaysToRegistrationReview) + " dni";
                        lastCheck.FleetVehicle.RegCheckStatus = EnChecks.CheckStatuses.NotValid;
                        ContextHelpers.SaveModelObject(lastCheck);
                    }
                }
                else
                {
                    labelLeftToNextCheck.ForeColor = Color.Red;
                    labelLeftToNextCheck.Text = "Pojazd jezcze nie ma wprowadzonych przeglądów rejestracyjnych!";
                    selectedVehicle.RegCheckStatus = EnChecks.CheckStatuses.HasNoCheck;
                    ContextHelpers.SaveModelObject(selectedVehicle);
                }
            }
            else
            {
                labelLeftToNextCheck.Text = "Nie wybrano żadnego pojazdu";
            }

        }

        private void initManipulationControls()
        {
            var check = GridViewHelpers.GetObjectFromDataGridViewRow<RegistrationCheck>(dataGridViewRegistrationChecksList, "");

            if (check != null)
            {
                tbMileageOnCheck.Text = check.MileageOnRegCheck.ToString();
                dateTimeOilCheck.Value = (DateTime)check.DateOfRegCheck;
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

            if (selectedVehicle != null)
                frmAddCheck = new frm_AddCheck(selectedVehicle);
            else
            {
                MessageBox.Show("Wybierz pojazd, dla którego chcesz wpisać nowy przegląd", "Pojazd nie jest wybrany");
                return;
            }

            if (frmAddCheck.ShowDialog() == DialogResult.OK)
            {
                if (frmAddCheck.CheckType == EnChecks.CheckTypes.Registration)
                {
                    RegistrationCheck newRegCheck = frmAddCheck.NewRegistrationCheck;

                    using (RejAndOlejContext tempContext = new RejAndOlejContext())
                    {
                        tempContext.RegistrationChecks.Add(newRegCheck);

                        if (frmAddCheck.SetMileageAsActual)
                            selectedVehicle.Mileage = newRegCheck.MileageOnRegCheck;

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
                using (RejAndOlejContext tempContext = new RejAndOlejContext())
                {
                    RegistrationCheck check = GridViewHelpers.GetObjectFromDataGridViewRow<RegistrationCheck>(dataGridViewRegistrationChecksList, "");
                    switch (DBAction)
                    {
                        case EnModels.ModelActions.Insert:
                            break;

                        case EnModels.ModelActions.Edit:
                            if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                            {
                                tempContext.Update(check);
                                check.MileageOnRegCheck = Convert.ToInt64(tbMileageOnCheck.Text);
                                check.DateOfRegCheck = dateTimeOilCheck.Value;
                                tempContext.SaveChanges();
                            }
                            initDataGridView();
                            break;
                    }

                }
            }
        }

        private void cbSetActualMileageAsMileageOnCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
                tbMileageOnCheck.Text = tbMileage.Text;
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
                if (dataGridViewRegistrationChecksList.SelectedRows.Count > 0 || dataGridViewRegistrationChecksList.SelectedCells.Count > 0)
                {
                    var rowToDelete = GridViewHelpers.GetObjectFromDataGridViewRow<OilCheck>(dataGridViewRegistrationChecksList, "");

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
