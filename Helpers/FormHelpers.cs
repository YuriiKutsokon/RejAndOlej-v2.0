using RejAndOlej.Enums;
using RejAndOlej.Helpers.Controls;
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
        public static void EnableManipulationControls(EnModels.ModelActions? action, Control.ControlCollection controls)
        {
            switch (action)
            {
                case EnModels.ModelActions.Insert:
                    ControlsHelpers.EnableControls(controls, true);
                    ControlsHelpers.ClearControls(controls);
                    break;

                case EnModels.ModelActions.Edit:
                    ControlsHelpers.EnableControls(controls, true);
                    break;
            }

        }
    }
}
