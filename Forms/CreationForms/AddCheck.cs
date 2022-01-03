using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RejAndOlej.DATABASE;
using RejAndOlej.Enums;
using RejAndOlej.Models;

namespace RejAndOlej.Forms.CreationForms
{
    public partial class frm_AddCheck : Form
    {
        public frm_AddCheck(BusFleet bus)
        {
            _bus = bus;
            InitializeComponent();
        }

        public EnChecks.CheckTypes CheckType
        {
            get => _checkType;
            set => _checkType = value;
        }

        public OilCheck NewOilCheck
        {
            get => newOilCheck;
            set => newOilCheck = value;
        }

        public RegistrationCheck NewRegistrationCheck
        {
            get => newRegistrationChaeck;
            set => newRegistrationChaeck = value;
        }

        public bool SetMileageAsActual
        {
            get => checkBoxSetMileageOnCheckAsVehicleMileage.Checked;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            int lastCheckID;
            if (comboBoxCheckType.SelectedIndex == 0)
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    if (context.OilChecks.Count() == 0)
                        lastCheckID = 0;
                    else
                        lastCheckID = context.OilChecks.OrderBy(oc => oc.OilCheckId).Last().OilCheckId;
                }

                newOilCheck = new OilCheck()
                {
                    DateOfOilCheck = dateTimeOnCheck.Value,
                    MileageOnOilCheck = Convert.ToInt64(textBoxMileage.Text),
                    FleetVechicleId = _bus.FleetVehicleId,
                    OilCheckId = lastCheckID + 1
                };

                CheckType = EnChecks.CheckTypes.Oil;
                DialogResult = DialogResult.OK;
            }
            else if (comboBoxCheckType.SelectedIndex == 1)
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    if (context.RegistrationChecks.Count() == 0)
                        lastCheckID = 0;
                    else
                        lastCheckID = context.RegistrationChecks.OrderBy(rc => rc.RegCheckId).Last().RegCheckId;
                }

                newRegistrationChaeck = new RegistrationCheck()
                {
                    DateOfRegCheck = dateTimeOnCheck.Value,
                    MileageOnRegCheck = Convert.ToInt64(textBoxMileage.Text),
                    FleetVehicleId = _bus.FleetVehicleId,
                    RegCheckId = lastCheckID + 1
                };

                CheckType = EnChecks.CheckTypes.Registration;
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
