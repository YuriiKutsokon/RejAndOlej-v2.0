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
        public static void EnableControls(Control.ControlCollection controls, bool enabled)
        {
            foreach(Control ctrl in controls)
                ctrl.Enabled = true;
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
