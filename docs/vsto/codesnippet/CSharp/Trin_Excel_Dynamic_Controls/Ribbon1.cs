using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
//<Snippet1>
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Excel.Extensions;
//</Snippet1>

namespace Trin_Excel_Dynamic_Controls
{
    public partial class Ribbon1 : RibbonBase
    {
        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }
        //<Snippet2>
        private void Button_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);

            
            string buttonName = "MyButton";

            if (((RibbonCheckBox)sender).Checked)
            {
                Excel.Range selection = Globals.ThisAddIn.Application.Selection as Excel.Range;
                if (selection != null)
                {
                    Microsoft.Office.Tools.Excel.Controls.Button button =
                        new Microsoft.Office.Tools.Excel.Controls.Button();
                    worksheet.Controls.AddControl(button, selection, buttonName);
                }
            }
            else
            {
                worksheet.Controls.Remove(buttonName);
            }
        }
        //</Snippet2>

       //<Snippet3>
        private void NamedRange_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);


            string Name = "MyNamedRange";

            if (((RibbonCheckBox)sender).Checked)
            {
                Excel.Range selection = Globals.ThisAddIn.Application.Selection as Excel.Range;
                if (selection != null)
                {
                    worksheet.Controls.AddNamedRange(selection, Name);
                }
            }
            else
            {
                worksheet.Controls.Remove(Name);
            }
        }
        //</Snippet3>

        //<Snippet4>
        private void ListObject_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);


            string listObjectName = "MyListObject";

            if (((RibbonCheckBox)sender).Checked)
            {
                Excel.Range selection = Globals.ThisAddIn.Application.Selection as Excel.Range;
                if (selection != null)
                {
                    worksheet.Controls.AddListObject(selection, listObjectName);
                }
            }
            else
            {
                worksheet.Controls.Remove(listObjectName);
            }
        }
        //</Snippet4>
    }
}
