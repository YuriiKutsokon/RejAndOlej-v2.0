using RejAndOlej.Forms.SearchingTables;
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
    public partial class uc_OilChecks : UserControl
    {
        public uc_OilChecks()
        {
            InitializeComponent();

            context = new RejAndOlejContext();
        }

        private void RegisterEvents()
        {

        }

        private void initDataGridView()
        {
            ICollection<OilCheck> oilCheckList = context.OilChecks.ToList();
            var mainView = OilChecksMainTableView.GetOilChecksView(oilCheckList);
            dataGridViewOilChecksList.DataSource = mainView;
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
            }
        }


    }
}
