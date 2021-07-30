using RejAndOlej.Helpers.Database;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Forms.Tables;
using RejAndOlej.Models;
using RejAndOlej.Views.TableViews.OilChecks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RejAndOlej.Views.TableViews;

namespace RejAndOlej.UserControls.Flota
{
    public partial class uc_RegistrationChecks : BaseUserControl
    {
        public uc_RegistrationChecks() : base ("FleetVechicleId")
        {
            InitializeComponent();
            RegisterEvents();
            initDataGridView();
        }

        private void RegisterEvents()
        {
            dataGridViewRegistrationChecksList.DoubleClick += (s, e) => SetEditMode();
            toolStripButtonEdit.Click += (s, e) => SetEditMode();

            dataGridViewRegistrationChecksList.RowStateChanged += (s, e) => initManipulationControls((int)DBTableActions.Edit);
            dataGridViewRegistrationChecksList.CellStateChanged += (s, e) => initManipulationControls((int)DBTableActions.Edit);
        }

        private void initDataGridView()
        {
            ICollection<RegistrationCheck> registrationChecks = context.RegistrationChecks.ToList();
            var mainview = GeneralRegistrationChecksView.GetGeneralRegistrationChecksList(registrationChecks);
            dataGridViewRegistrationChecksList.DataSource = mainview;
        }

        private void SetEditMode()
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Edit;
            initManipulationControls(DBAction);
        }

        private void initManipulationControls(int? mode)
        {
            switch (mode)
            {
                case (int)DBTableActions.Edit:
                    groupBoxDataManipulation.Enabled = true;
                    RegistrationCheck rowToEdit = GridViewHelper.GetObjectFromDataGridViewRow<RegistrationCheck>(dataGridViewRegistrationChecksList, SelectionColumn);
                    textBoxActualMileage.Text = Convert.ToString(rowToEdit.MileageOnRegCheck);
                    dateTimeRegistrationCheck.Value = Convert.ToDateTime(rowToEdit.DateOfRegCheck);
                    break;

                case (int)DBTableActions.Insert:
                    groupBoxDataManipulation.Enabled = true;
                    textBoxActualMileage.Text = string.Empty;
                    dateTimeRegistrationCheck.Value = DateTime.Now;
                    break;
            }    
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            DBAction = (int)DBTableActions.Insert;
            initManipulationControls(DBAction);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                if (DBAction == (int)DBTableActions.Edit)
                {
                    RegistrationCheck checkToEdit = GridViewHelper.GetObjectFromDataGridViewRow<RegistrationCheck>
                                            (dataGridViewRegistrationChecksList, SelectionColumn);
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            checkToEdit.DateOfRegCheck = dateTimeRegistrationCheck.Value;
                            checkToEdit.MileageOnRegCheck = Convert.ToInt64(textBoxActualMileage.Text); 
                            tempContext.SaveChanges();
                        }
                        initDataGridView();
                    }
                    else
                        MessageBox.Show("Nie wszyskie pola są wypełnione!", "brak danych");
                    groupBoxDataManipulation.Enabled = false;
                }
                else if (DBAction == (int)DBTableActions.Insert)
                {
                    RegistrationCheck checkToInsert = new RegistrationCheck();
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            checkToInsert.RegCheckId = tempContext.OilChecks.OrderBy(bf => bf.OilCheckId).Last().OilCheckId + 1;
                            checkToInsert.DateOfRegCheck = dateTimeRegistrationCheck.Value;
                            checkToInsert.MileageOnRegCheck = Convert.ToInt64(textBoxActualMileage.Text);
                            tempContext.RegistrationChecks.Add(checkToInsert);
                            tempContext.SaveChanges();
                        }
                        initDataGridView();
                    }
                    groupBoxDataManipulation.Enabled = false;
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            using (RejAndOlejContext tempContext = new RejAndOlejContext())
            {
                if (dataGridViewRegistrationChecksList.SelectedCells.Count > 0 || dataGridViewRegistrationChecksList.SelectedRows.Count > 0)
                {
                    RegistrationCheck rowToDelete = GridViewHelper.GetObjectFromDataGridViewRow<RegistrationCheck>(dataGridViewRegistrationChecksList, SelectionColumn);
                    tempContext.RegistrationChecks.Remove(rowToDelete);
                    tempContext.SaveChanges();
                    initDataGridView();
                }
                else
                    MessageBox.Show("Proszę wybrać pojazd do usunięcia", "Brak Danych do usunięcia");
            }
        }

        private void toolStripMenuItemFlaota_Click(object sender, EventArgs e)
        {
            using (frm_FleetVehciclesList frm_FleetVehciclesList = new frm_FleetVehciclesList())
            {
                if (frm_FleetVehciclesList.ShowDialog() == DialogResult.OK)
                {
                    BusFleet vehicle = frm_FleetVehciclesList.GetFocusedRow();
                    if (vehicle != null)
                    {
                        ICollection<RegistrationCheck> regChecks = vehicle.RegistrationChecks;
                        var mainview = GeneralRegistrationChecksView.GetGeneralRegistrationChecksList(regChecks);
                        dataGridViewRegistrationChecksList.DataSource = mainview;
                    }
                }
            }
        }
    }
}
