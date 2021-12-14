using RejAndOlej.Forms.SearchingTables;
using RejAndOlej.Helpers;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Helpers.Database;
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

namespace RejAndOlej.UserControls.Flota
{
    public partial class uc_OilChecks : BaseUserControl
    {
        public uc_OilChecks()
        {
            InitializeComponent();

            context = new RejAndOlejContext();

            manipulationControls = groupBoxDataManipulation.Controls;
        }

        private void RegisterEvents()
        {

        }

        private void initDataGridView()
        {
            if (selectedVehicle != null)
            {
                ICollection<OilCheck> oilCheckList = selectedVehicle.OilChecks;
                var mainView = OilChecksMainTableView.GetOilChecksView(oilCheckList);
                dataGridViewOilChecksList.DataSource = mainView;
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
            FormHelpers.EnableManipulationControls(DBTableActions.Insert, manipulationControls);
            DBAction = DBTableActions.Insert;
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
                    OilCheck check = GridViewHelpers.GetObjectFromDataGridViewRow<OilCheck>(dataGridViewOilChecksList, "");
                    switch (DBAction)
                    {
                        case DBTableActions.Insert:
                            break;

                        case DBTableActions.Edit:
                            if(!HasEmptyControl(groupBoxDataManipulation.Controls))
                            {
                                check.MileageOnOilCheck = Convert.ToInt64(textBoxPreviousMileage.Text);
                                check.DateOfOilCheck = dateTimeOilCheck.Value;
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
                textBoxPreviousMileage.Text = textBoxActualMileage.Text;
        }
    }
}
