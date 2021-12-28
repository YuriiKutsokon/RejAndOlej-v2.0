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
using RejAndOlej.Forms.CreationForms;
using RejAndOlej.Forms.SearchingTables;
using RejAndOlej.Helpers;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Helpers.Database;
using RejAndOlej.Models;
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

            dataGridViewRegistrationChecksList.DoubleClick += (s, e) => { FormHelpers.EnableManipulationControls(DBTableActions.Edit, manipulationControls); DBAction = DBTableActions.Edit; };
        }

        private void initDataGridView()
        {
            if (selectedVehicle != null)
            {
                ICollection<RegistrationCheck> checkslist = selectedVehicle.RegistrationChecks;
                var mainView = RegistrationChecksMainTableView.GetRegistrationChecksListView(checkslist);
                dataGridViewRegistrationChecksList.DataSource = mainView;

                if (checkslist.Count != 0)
                {
                    var lastCheck = checkslist.Last();

                    int? fromLastCheck = (DateTime.Now.Date - lastCheck.DateOfRegCheck.Value.Date).Days;
                    if (fromLastCheck < lastCheck.FleetVehicle.Bus.DefaultDaysToRegistrationReview)
                    {
                        labelLeftToNextCheck.ForeColor = Color.Green;
                        labelLeftToNextCheck.Text = "Do następnego przeglądu: " + Convert.ToString(lastCheck.FleetVehicle.Bus.DefaultDaysToRegistrationReview - fromLastCheck) + " dni";
                    }
                    else
                    {
                        labelLeftToNextCheck.ForeColor = Color.Red;
                        labelLeftToNextCheck.Text = "Przegląd spóżniony! Przegląd przeterminowany na " + Convert.ToString(fromLastCheck - lastCheck.FleetVehicle.Bus.DefaultDaysToRegistrationReview) + " dni";
                    }
                }
                else
                {
                    labelLeftToNextCheck.ForeColor = Color.Red;
                    labelLeftToNextCheck.Text = "Pojazd jezcze nie ma wprowadzonych przeglądów rejestracyjnych!";
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

            DBAction = DBTableActions.Insert;
            initDataGridView();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            FormHelpers.EnableManipulationControls(DBTableActions.Edit, manipulationControls);
            DBAction = DBTableActions.Edit;
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
                        case DBTableActions.Insert:
                            break;

                        case DBTableActions.Edit:
                            if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                            {
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
    }
}
