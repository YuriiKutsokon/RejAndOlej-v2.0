using RejAndOlej.Helpers.Controls;
using RejAndOlej.Helpers.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejAndOlej.Helpers
{
    class FormHelpers
    {
        public static void EnableManipulationControls(DBTableActions action, Control.ControlCollection controls)
        {
            switch (action)
            {
                case DBTableActions.Insert:
                    ControlsHelpers.EnableControls(controls, true);
                    ControlsHelpers.ClearControls(controls);
                    break;

                case DBTableActions.Edit:
                    ControlsHelpers.EnableControls(controls, true);
                    break;
            }

        }
    }
}
