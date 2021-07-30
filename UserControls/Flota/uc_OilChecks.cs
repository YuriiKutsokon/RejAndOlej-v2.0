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

namespace RejAndOlej.UserControls.Flota
{
    public partial class uc_OilChecks : BaseUserControl
    {
        public uc_OilChecks() : base ("FleetVechicleId")
        {
            InitializeComponent();
            RegisterEvents();
            initDataGridView();
        }

        private void RegisterEvents()
        {
            dataGridViewOilChecksList.DoubleClick += (s, e) => SetEditMode();
            toolStripButtonEdit.Click += (s, e) => SetEditMode();

            dataGridViewOilChecksList.RowStateChanged += (s, e) => initManipulationControls((int)DBTableActions.Edit);
            dataGridViewOilChecksList.CellStateChanged += (s, e) => initManipulationControls((int)DBTableActions.Edit);
        }

        private void initDataGridView()
        {
            ICollection<OilCheck> oilChecks = context.OilChecks.ToList();
            var mainview = GeneralOilChecksView.GetGeneralOilChecksList(oilChecks);
            dataGridViewOilChecksList.DataSource = mainview;
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
                    OilCheck rowToEdit = GridViewHelper.GetObjectFromDataGridViewRow<OilCheck>(dataGridViewOilChecksList, SelectionColumn);
                    textBoxActualMileage.Text = Convert.ToString(rowToEdit.MileageOnOilCheck);
                    dateTimeOilCheck.Value = Convert.ToDateTime(rowToEdit.DateOfOilCheck);
                    break;

                case (int)DBTableActions.Insert:
                    groupBoxDataManipulation.Enabled = true;
                    textBoxActualMileage.Text = string.Empty;
                    dateTimeOilCheck.Value = DateTime.Now;
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
                    OilCheck checkToEdit = GridViewHelper.GetObjectFromDataGridViewRow<OilCheck>
                                            (dataGridViewOilChecksList, SelectionColumn);
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            checkToEdit.DateOfOilCheck = dateTimeOilCheck.Value;
                            checkToEdit.MileageOnOilCheck = Convert.ToInt64(textBoxActualMileage.Text); 
                            tempContext.SaveChanges();
                        }
                        initDataGridView();
                        groupBoxDataManipulation.Enabled = false;
                    }
                    else
                        MessageBox.Show("Nie wszyskie pola są wypełnione!", "brak danych");
                }
                else if (DBAction == (int)DBTableActions.Insert)
                {
                    OilCheck checkToInsert = new OilCheck();
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            checkToInsert.OilCheckId = tempContext.OilChecks.OrderBy(bf => bf.OilCheckId).Last().OilCheckId + 1;
                            checkToInsert.DateOfOilCheck = dateTimeOilCheck.Value;
                            checkToInsert.MileageOnOilCheck = Convert.ToInt64(textBoxActualMileage.Text);
                            tempContext.OilChecks.Add(checkToInsert);
                            tempContext.SaveChanges();
                        }
                        initDataGridView();
                        groupBoxDataManipulation.Enabled = false;
                    }
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            using (RejAndOlejContext tempContext = new RejAndOlejContext())
            {
                if (dataGridViewOilChecksList.SelectedCells.Count > 0 || dataGridViewOilChecksList.SelectedRows.Count > 0)
                {
                    OilCheck rowToDelete = GridViewHelper.GetObjectFromDataGridViewRow<OilCheck>(dataGridViewOilChecksList, SelectionColumn);
                    tempContext.OilChecks.Remove(rowToDelete);
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
                        ICollection<OilCheck> oilChecks = vehicle.OilChecks;
                        var mainview = GeneralOilChecksView.GetGeneralOilChecksList(oilChecks);
                        dataGridViewOilChecksList.DataSource = mainview;
                    }
                }
            }
        }
    }
}
