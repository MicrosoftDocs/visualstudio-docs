using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//<Snippet1>
using Office = Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
//</Snippet1>

namespace Trin_TaskPaneMonthCalendar
{
    public partial class MyUserControl : UserControl
    {
        //<Snippet2>
        private PowerPoint.Shape textbox;
        //</Snippet2>

        public MyUserControl()
        {
            InitializeComponent();
        }

        //<Snippet3>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                if (textbox != null)
                {
                    textbox.Delete();
                }

                PowerPoint.Slide slide =
                    Globals.ThisAddIn.Application.ActivePresentation.Slides[1];
                textbox = slide.Shapes.AddTextbox(
                    Office.MsoTextOrientation.msoTextOrientationHorizontal,
                    50, 100, 600, 50);
                textbox.TextFrame.TextRange.Text = e.Start.ToLongDateString();
                textbox.TextFrame.TextRange.Font.Size = 48;
                textbox.TextFrame.TextRange.Font.Color.RGB =
                     Color.DarkViolet.ToArgb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //</Snippet3>
    }
}
