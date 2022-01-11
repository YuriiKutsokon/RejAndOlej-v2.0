using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejAndOlej.Helpers.Controls
{
    class ControlsHelpers
    {
        public static void EnableControls(Control.ControlCollection controls, bool mode)
        {
            foreach(Control ctrl in controls)
            {
                TextBox textBox = ctrl as TextBox;
                DataGridView dgv = ctrl as DataGridView;

                if (textBox != null)
                    textBox.ReadOnly = !mode;
                else if (dgv != null)
                    dgv.ReadOnly = !mode;
                else
                    ctrl.Enabled = mode;
            }
        }

        public static void ClearControls(Control.ControlCollection controls)
        {
            foreach(Control ctrl in controls)
            {
                TextBox textbox = ctrl as TextBox;
                if(textbox != null)
                    textbox.Text = string.Empty;

                DateTimePicker dateTimePicker = ctrl as DateTimePicker;
                if (dateTimePicker != null)
                    dateTimePicker.Value = DateTime.Now;
            }
        }
    }
}
