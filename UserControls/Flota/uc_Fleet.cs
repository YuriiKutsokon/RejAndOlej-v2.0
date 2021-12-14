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
            dataGridViewModelsList.RowStateChanged  += (s, e) => initManipulationControls(DBTableActions.Edit);
            dataGridViewModelsList.CellStateChanged += (s, e) => initManipulationControls(DBTableActions.Edit);

            toolStripButtonEdit.Click += (s, e) => SetEditMode();
            dataGridViewModelsList.DoubleClick += (s, e) => SetEditMode();
        }

        protected void initManipulationControls(DBTableActions? mode)
        {
            BusFleet vehicle = GridViewHelpers.GetObjectFromDataGridViewRow<BusFleet>
                                                                        (dataGridViewModelsList, SelectionColumn);

            switch (mode)
            {
                case DBTableActions.Edit:
                    if (vehicle != null && vehicle.FleetVehicleId != 0)
                    {
                        textBoxRegNum.Text = vehicle.RegistrationNumber;
                        textBoxracNumber.Text = vehicle.RaceNumber;
                        textBoxMileage.Text = Convert.ToString(vehicle.Mileage);
                        comboBoxBusMaker.Text = vehicle.Bus.BusMaker.Name;
                        comboBoxBusMakerModels.Text = vehicle.Bus.ModelName;
                    }
                break;
                case DBTableActions.Insert:
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
            var mainView = FleetMainTableView.GetFleetView(fleetVechicles);
            dataGridViewModelsList.DataSource = mainView;
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
            DBAction = DBTableActions.Insert;
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
            DBAction = DBTableActions.Edit;
            initManipulationControls(DBAction);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                if (DBAction == DBTableActions.Edit)
                {
                    BusFleet vehicleToEdit = GridViewHelpers.GetObjectFromDataGridViewRow<BusFleet>
                                            (dataGridViewModelsList, SelectionColumn);
                    if(!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
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
                else if(DBAction == DBTableActions.Insert)
                {
                    BusFleet vehicleToInsert = new BusFleet();
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            vehicleToInsert.FleetVehicleId = tempContext.BusFleets.OrderBy(bf => bf.FleetVehicleId).Last().FleetVehicleId + 1;
                            vehicleToInsert.RegistrationNumber = textBoxRegNum.Text;
                            vehicleToInsert.RaceNumber = textBoxracNumber.Text;
                            vehicleToInsert.Mileage = Convert.ToInt64(textBoxMileage.Text);
                            vehicleToInsert.DateOfEnterToFleet = Convert.ToDateTime(dateTimeEnterToFleet.Value);
                            vehicleToInsert.BusId = context.Buses.Where(bus => bus.ModelName == comboBoxBusMakerModels.Text).FirstOrDefault().BusId;
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
    }
}
