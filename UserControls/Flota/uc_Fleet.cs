using RejAndOlej.DATABASE;
using RejAndOlej.Enums;
using RejAndOlej.Helpers;
using RejAndOlej.Helpers.Controls;
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


namespace RejAndOlej.UserControls.Flota
{
    public partial class uc_Fleet : BaseUserControl
    {
        public uc_Fleet() : base("RegistrationNumber")
        {
            InitializeComponent();
            initDataGridView();
            initComboBox();
            RegisterEvents();
        }

        protected void RegisterEvents()
        {
            dataGridViewModelsList.RowStateChanged  += (s, e) => initManipulationControls(EnModels.ModelActions.Edit);
            dataGridViewModelsList.CellStateChanged += (s, e) => initManipulationControls(EnModels.ModelActions.Edit);

            toolStripButtonEdit.Click += (s, e) => SetEditMode();
            dataGridViewModelsList.DoubleClick += (s, e) => SetEditMode();
        }

        protected void initManipulationControls(EnModels.ModelActions? mode)
        {
            BusFleet vehicle = GridViewHelpers.GetObjectFromDataGridViewRow<BusFleet>
                                                                        (dataGridViewModelsList, SelectionColumn);

            switch (mode)
            {
                case EnModels.ModelActions.Edit:
                    if (vehicle != null && vehicle.FleetVehicleId != 0)
                    {
                        textBoxRegNum.Text = vehicle.RegistrationNumber;
                        textBoxracNumber.Text = vehicle.RaceNumber;
                        textBoxMileage.Text = Convert.ToString(vehicle.Mileage);
                        comboBoxBusMaker.Text = vehicle.Bus.BusMaker.Name;
                        comboBoxBusMakerModels.Text = vehicle.Bus.ModelName;
                    }
                break;
                case EnModels.ModelActions.Insert:
                    if (vehicle != null && vehicle.FleetVehicleId != 0)
                    {
                        textBoxRegNum.Text = string.Empty;
                        textBoxracNumber.Text = string.Empty;
                        textBoxMileage.Text = string.Empty;
                        comboBoxBusMaker.Text = string.Empty;
                        comboBoxBusMakerModels.Text = string.Empty;
                        dateTimeEnterToFleet.Value = DateTime.Now;
                    }
                break;
                default:

                break;
            }
        }

        protected void initDataGridView()
        {
            ICollection<BusFleet> fleetVechicles = context.BusFleets.ToList();
            displayList = TableViewHelpers.GetView<FleetMainTableView>(fleetVechicles);
            dataGridViewModelsList.DataSource = displayList;
        }

        private void initComboBox()
        {
            comboBoxBusMaker.Items.Clear();
            ICollection<BusMaker> busMakersList = context.BusMakers.ToList();
            foreach (BusMaker bm in busMakersList)
            {
                comboBoxBusMaker.Items.Add(bm.Name);
            }

        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = EnModels.ModelActions.Insert;
            initManipulationControls(DBAction);
        }

        private void comboBoxBusMaker_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBusMakerModels.Items.Clear();
            if (!String.IsNullOrEmpty(comboBoxBusMaker.Text))
            {
                ICollection<Bus> busModelsOfBusMaker = context.BusMakers.Where(bm => bm.BusMakerId == comboBoxBusMaker.SelectedIndex)
                    .FirstOrDefault().Buses;

                foreach (Bus bm in busModelsOfBusMaker)
                {
                    comboBoxBusMakerModels.Items.Add(bm.ModelName);
                }
            }
        }

        private void SetEditMode()
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = EnModels.ModelActions.Edit;
            initManipulationControls(DBAction);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                if (DBAction == EnModels.ModelActions.Edit)
                {
                    BusFleet vehicleToEdit = GridViewHelpers.GetObjectFromDataGridViewRow<BusFleet>
                                            (dataGridViewModelsList, SelectionColumn);
                    if(!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            tempContext.Update(vehicleToEdit);
                            vehicleToEdit.RegistrationNumber = textBoxRegNum.Text;
                            vehicleToEdit.RaceNumber = textBoxracNumber.Text;
                            vehicleToEdit.Mileage = Convert.ToInt64(textBoxMileage.Text);
                            vehicleToEdit.DateOfEnterToFleet = Convert.ToDateTime(dateTimeEnterToFleet.Value);
                            vehicleToEdit.BusId = context.Buses.Where(bus => bus.ModelName == comboBoxBusMakerModels.Text).FirstOrDefault().BusId;
                            tempContext.SaveChanges();
                        }
                        initDataGridView();
                    }
                    else
                        MessageBox.Show("Nie wszyskie pola są wypełnione!", "brak danych");
                }
                else if(DBAction == EnModels.ModelActions.Insert)
                {
                    BusFleet vehicleToInsert = new BusFleet();
                    int newFleetVehicleId = context.BusFleets.OrderBy(bf => bf.FleetVehicleId).Last().FleetVehicleId + 1;
                    int busId = context.Buses.Where(bus => bus.ModelName == comboBoxBusMakerModels.Text).FirstOrDefault().BusId;
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            vehicleToInsert.FleetVehicleId = newFleetVehicleId;
                            vehicleToInsert.RegistrationNumber = textBoxRegNum.Text;
                            vehicleToInsert.RaceNumber = textBoxracNumber.Text;
                            vehicleToInsert.Mileage = Convert.ToInt64(textBoxMileage.Text);
                            vehicleToInsert.DateOfEnterToFleet = Convert.ToDateTime(dateTimeEnterToFleet.Value);
                            vehicleToInsert.BusId = busId;
                            tempContext.BusFleets.Add(vehicleToInsert);
                            tempContext.SaveChanges();
                        }
                        initDataGridView();
                    }
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            using (RejAndOlejContext tempContext = new RejAndOlejContext())
            {
                if (dataGridViewModelsList.SelectedCells.Count > 0 || dataGridViewModelsList.SelectedRows.Count > 0)
                {
                    BusFleet rowToDelete = GridViewHelpers.GetObjectFromDataGridViewRow<BusFleet>(dataGridViewModelsList, SelectionColumn);
                    tempContext.BusFleets.Remove(rowToDelete);
                    tempContext.SaveChanges();
                    initDataGridView();
                }
                else
                    MessageBox.Show("Proszę wybrać pojazd do usunięcia", "Brak Danych do usunięcia");
            }

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
