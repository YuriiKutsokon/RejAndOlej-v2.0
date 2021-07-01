using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Views.TableViews;

namespace RejAndOlej.Forms.Tables
{
    public partial class FleetVehciclesList : Form
    {
        public FleetVehciclesList()
        {
            InitializeComponent();
            InitDataGridView();
        }

        private void FleetVehciclesList_Load(object sender, EventArgs e)
        {

        }

        public BusFleet GetFocusedRow()
        {
            BusFleet rowToExport = new BusFleet();

            return rowToExport;
        }

        private void InitDataGridView()
        {
            ICollection<BusFleet> fleetVechicles = context.BusFleets.ToList();
            var mainView = FleetMainTableView.GetFleetView(fleetVechicles);
            dataGridViewFleetList.DataSource = mainView;
        }
    }
}
