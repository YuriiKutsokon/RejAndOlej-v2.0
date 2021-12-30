using RejAndOlej.Helpers.Controls;
using RejAndOlej.Helpers.Database;
using RejAndOlej.Models;
using RejAndOlej.Service;
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
    public partial class uc_BusModels : UserControl
    {
        public uc_BusModels()
        {
            InitializeComponent();
            initDataGrid();
            initComboBox();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            dataGridViewModelsList.RowStateChanged += (s, e) => initManipulationControls();

            dataGridViewModelsList.CellStateChanged += (s, e) => initManipulationControls();
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
            displayList = BusModelsMainTableView.GetBusModelsView(buses);
            dataGridViewModelsList.DataSource = displayList;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Insert;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Edit;
        }

        private void dataGridViewModelsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Edit;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                if (DBAction == (int)DBTableActions.Edit)
                {
                    Bus rowToEdit = GridViewHelpers.GetObjectFromDataGridViewRow<Bus>(dataGridViewModelsList, "ModelName");
                    if (!(String.IsNullOrEmpty(textBoxName.Text) && String.IsNullOrEmpty(textBoxDaysToCheck.Text) &&
                        String.IsNullOrEmpty(textBoxKmToOilCheck.Text) && String.IsNullOrEmpty(comboBoxBusMaker.Text)))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            tempContext.Update(rowToEdit);
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
                    if (!(String.IsNullOrEmpty(textBoxName.Text) && String.IsNullOrEmpty(textBoxDaysToCheck.Text) &&
                        String.IsNullOrEmpty(textBoxKmToOilCheck.Text) && String.IsNullOrEmpty(comboBoxBusMaker.Text)))
                    {
                        Bus rowToInsert = new Bus();
                        int newBusId = context.Buses.OrderBy(bus => bus.BusId).Last().BusId + 1;
                        int busMakerId = context.BusMakers.Where(bm => bm.Name == comboBoxBusMaker.Text).FirstOrDefault().BusMakerId;

                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            rowToInsert.BusId = newBusId;
                            rowToInsert.ModelName = textBoxName.Text;
                            rowToInsert.DefaultDaysToRegistrationReview = Convert.ToInt32(textBoxDaysToCheck.Text);
                            rowToInsert.DefaultKmToOilInspection = Convert.ToInt64(textBoxKmToOilCheck.Text);
                            rowToInsert.BusMakerId = busMakerId;
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

        private void initManipulationControls()
        {
            Bus bus = GridViewHelpers.GetObjectFromDataGridViewRow<Bus>(dataGridViewModelsList,"ModelName");

            if (bus != null && bus.BusId != 0)
            {
                textBoxName.Text = bus.ModelName;
                textBoxDaysToCheck.Text = Convert.ToString(bus.DefaultDaysToRegistrationReview);
                textBoxKmToOilCheck.Text = Convert.ToString(bus.DefaultKmToOilInspection);
                comboBoxBusMaker.Text = bus.BusMaker.Name;
            }
        }

        private void SetEditMode()
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Edit;
            initManipulationControls();
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
    }
}
