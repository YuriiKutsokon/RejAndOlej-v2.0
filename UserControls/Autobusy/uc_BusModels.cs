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

namespace RejAndOlej.UserControls.Autobusy
{
    public partial class uc_BusModels : BaseUserControl
    {
        public uc_BusModels() : base("ModelName")
        {
            InitializeComponent();
            initDataGrid();
            initComboBox();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            dataGridViewModelsList.RowStateChanged += (s, e) => initManipulationControls((int)DBTableActions.Edit);
            dataGridViewModelsList.CellStateChanged += (s, e) => initManipulationControls((int)DBTableActions.Edit);

            toolStripButtonEdit.Click += (s, e) => SetEditMode();
            dataGridViewModelsList.DoubleClick += (s, e) => SetEditMode();
        }

        private void initComboBox()
        {
            List<BusMaker> busMakers = context.BusMakers.ToList();
            foreach (BusMaker bm in busMakers)
            {
                comboBoxBusMaker.Items.Add(bm.Name);
            }
        }

        private void initDataGrid()
        {
            List<Bus> buses = context.Buses.ToList();
            var mainView = BusModelsMainTableView.GetBusModelsView(buses);
            dataGridViewModelsList.DataSource = mainView;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Insert;
            initManipulationControls(DBAction);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                if (DBAction == (int)DBTableActions.Edit)
                {
                    Bus rowToEdit = GridViewHelper.GetObjectFromDataGridViewRow<Bus>(dataGridViewModelsList, SelectionColumn);
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            rowToEdit.ModelName = textBoxName.Text;
                            rowToEdit.DefaultDaysToRegistrationReview = Convert.ToInt32(textBoxDaysToCheck.Text);
                            rowToEdit.DefaultKmToOilInspection = Convert.ToInt64(textBoxKmToOilCheck.Text);
                            rowToEdit.BusMakerId = context.BusMakers.Where(bm => bm.Name == comboBoxBusMaker.Text).FirstOrDefault().BusMakerId;
                            tempContext.SaveChanges();
                        }
                        initDataGrid();
                    }
                    else
                        MessageBox.Show("Brak danych do wprowadzenia", "brak danych");
                }
                else if (DBAction == (int)DBTableActions.Insert)
                {
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        Bus rowToInsert = new Bus();

                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            rowToInsert.BusId = tempContext.Buses.OrderBy(bus => bus.BusId).Last().BusId + 1;
                            rowToInsert.ModelName = textBoxName.Text;
                            rowToInsert.DefaultDaysToRegistrationReview = Convert.ToInt32(textBoxDaysToCheck.Text);
                            rowToInsert.DefaultKmToOilInspection = Convert.ToInt64(textBoxKmToOilCheck.Text);
                            rowToInsert.BusMakerId = tempContext.BusMakers.Where(bm => bm.Name == comboBoxBusMaker.Text).FirstOrDefault().BusMakerId;
                            tempContext.Buses.Add(rowToInsert);
                            tempContext.SaveChanges();
                        }

                        initDataGrid();
                    }
                    else
                        MessageBox.Show("Brak danych do wprowadzenia", "brak danych");
                }
            }
        }

        private void initManipulationControls(int? mode)
        {
            Bus bus = GridViewHelper.GetObjectFromDataGridViewRow<Bus>(dataGridViewModelsList,SelectionColumn);
            switch (mode)
            {
                case (int)DBTableActions.Edit:
                    if (bus != null && bus.BusId != 0)
                    {
                        textBoxName.Text = bus.ModelName;
                        textBoxDaysToCheck.Text = Convert.ToString(bus.DefaultDaysToRegistrationReview);
                        textBoxKmToOilCheck.Text = Convert.ToString(bus.DefaultKmToOilInspection);
                        comboBoxBusMaker.Text = bus.BusMaker.Name;
                    }
                    break;
                case (int)DBTableActions.Insert:

                        textBoxName.Text = string.Empty;
                        textBoxDaysToCheck.Text = string.Empty;
                        textBoxKmToOilCheck.Text = string.Empty;
                        comboBoxBusMaker.Text = string.Empty;

                    break;
                default:

                    break;
            }

        }

        private void SetEditMode()
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Edit;
            initManipulationControls(DBAction);
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            using (RejAndOlejContext tempContext = new RejAndOlejContext())
            {
                if (dataGridViewModelsList.SelectedCells.Count > 0 || dataGridViewModelsList.SelectedRows.Count > 0)
                {
                    Bus rowToDelete = GridViewHelper.GetObjectFromDataGridViewRow<Bus>(dataGridViewModelsList, SelectionColumn);
                    tempContext.Buses.Remove(rowToDelete);
                    tempContext.SaveChanges();
                    initDataGrid();
                }
                else
                    MessageBox.Show("Proszę wybrać pojazd do usunięcia", "Brak Danych do usunięcia");
            }
        }
    }
}
