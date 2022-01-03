using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RejAndOlej.Enums;

namespace RejAndOlej.UserControls
{
    public partial class BaseUserControl : UserControl
    {
        public BaseUserControl()
        {

        }
        public BaseUserControl(string selectionColumn)
        {
            SelectionColumn = selectionColumn;
            InitializeComponent();
        }

        protected EnModels.ModelActions? DBAction;
        protected string SelectionColumn
        {
            set;
            get;
        }

        protected bool HasEmptyControl(ControlCollection controls)
        {
            bool result = true;

            foreach (Control ctrl in controls)
            {
                if (!String.IsNullOrEmpty(ctrl.Text))
                    result = false;
                else
                {
                    result = true;
                    break;
                }
            }

            return result;
        }


    }
}
