using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Trin_VstcoreProgrammingControlsExcelCS
{
    public partial class Sheet1
    {
        Microsoft.Office.Interop.Excel.Chart dataChart = new Microsoft.Office.Interop.Excel.Chart();

        //---------------------------------------------------------------------
        //<Snippet19>
        private void ChartOptions1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataChart.ChartType = this.ChartOptions1.Selection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //</Snippet19>


        //---------------------------------------------------------------------
        //<Snippet7>
        private void applyBoldFont_Click(object sender, EventArgs e)
        {
            this.textFont.Font.Bold = this.applyBoldFont.Checked;
        }
        //</Snippet7>


        //---------------------------------------------------------------------
        //<Snippet8>
        private void applyItalicFont_Click(object sender, EventArgs e)
        {
            this.textFont.Font.Italic = this.applyItalicFont.Checked;
        }
        //</Snippet8>


        //---------------------------------------------------------------------
        //<Snippet9>
        private void applyUnderlineFont_Click(object sender, EventArgs e)
        {
            if (this.applyUnderlineFont.Checked == true)
            {
                this.textFont.Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle;
            }
            else
            {
                this.textFont.Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleNone;
            }
        }
        //</Snippet9>


        //---------------------------------------------------------------------
        //<Snippet11>
        private void insertText_Click(object sender, EventArgs e)
        {
            this.displayText.Text += "Hello World! ";
        }
        //</Snippet11>


        //---------------------------------------------------------------------
        void Test2()
        {
            //<Snippet5>
            Microsoft.Office.Tools.Excel.Controls.Button control1 =
                this.Controls.AddButton(this.Range["A1"], "control1");
            //</Snippet5>


            //<Snippet6>
            control1.Placement = Microsoft.Office.Interop.Excel.XlPlacement.xlFreeFloating;
            //</Snippet6>
        }


        //---------------------------------------------------------------------
        void Test1()
        {
            Excel.Range range1 = null;

            //<Snippet2>
            UserControl1 customControl = new UserControl1();

            Microsoft.Office.Tools.Excel.ControlSite dynamicControl =
                this.Controls.AddControl(customControl, range1, "dynamic");
            //</Snippet2>

            //<Snippet3>
            // Property is set in relation to the document.
            dynamicControl.Top = 100;

            // Property is set in relation to the container control.
            customControl.Top = 100;
            //</Snippet3>
        }


        //---------------------------------------------------------------------
        //<Snippet4>
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            Microsoft.Office.Tools.Excel.Controls.Button salesButton;
            salesButton = this.Controls.AddButton(this.get_Range("C5"), "salesButton");
            salesButton.Text = "Calculate Total Sales";
        }
        //</Snippet4>


        //---------------------------------------------------------------------
        void StartUp()
        {
            //<Snippet20>
            this.ChartOptions1.SelectionChanged += new EventHandler(ChartOptions1_SelectionChanged);
            //</Snippet20>


            //<Snippet12>
            this.insertText.Click += new EventHandler(insertText_Click);
            //</Snippet12>


            //<Snippet10>
            this.applyBoldFont.Click += new EventHandler(applyBoldFont_Click);
            this.applyItalicFont.Click += new EventHandler(applyItalicFont_Click);
            this.applyUnderlineFont.Click += new EventHandler(applyUnderlineFont_Click);
            //</Snippet10>
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
            this.Shutdown += new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion

    }
}
