using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejAndOlej.Helpers.Controls
{
    class TabPageHelepr
    {
        private static Point _imageLocation = new Point(18, 5);

        private static Image _closeImage = new Bitmap(RejAndOlej.Properties.Resources.close_Icon_16);

        public Image CloseImage
        {
            get { return _closeImage; }
        }

        public static void createTabCloseButton(TabControl tabControl, System.Windows.Forms.DrawItemEventArgs e)
        {
            Rectangle rect = tabControl.GetTabRect(e.Index);
            rect.Offset(2, 0);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = tabControl.Font;
            string title = tabControl.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(rect.X, rect.Y));

            if (tabControl.SelectedIndex >= 0)
            {
                e.Graphics.DrawImage(_closeImage, new Point(rect.X + (tabControl.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
            }
        }

        public static void SelectOpenTab(TabControl control, object tag)
        {
            foreach(TabPage page in control.TabPages)
            {
                if (page.Tag == tag)
                    control.SelectTab(page);
            }
        }
    }

}
