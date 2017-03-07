using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreProgrammingExcelCS
{
    public partial class Sheet1
    {
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            Test1();
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }


        //<Snippet1>
        private void button1_Click(object sender, EventArgs e)
        {
            Globals.Sheet1.namedRange1.Value2 = this.textBox1.Text;
        }
        //</Snippet1>


        private void Test1()
        {
            //<Snippet2>
            Microsoft.Office.Tools.Excel.NamedRange NamedRange1 = 
                this.Controls.AddNamedRange(this.Range["A1"], "NamedRange1");
            //</Snippet2>
        
            //<Snippet3>
            double width = (double)NamedRange1.ColumnWidth;
            //</Snippet3>

            //<Snippet4>
            MessageBox.Show("Column width: " + width.ToString());
            //</Snippet4>
        }

        private void TestDynamic()
        {
           
            Excel.Range castRange = (Excel.Range)Globals.Sheet1.Cells[1, 1];
       

            //<Snippet10>
            Excel.Range dynamicRange = Globals.Sheet1.Cells[1, 1];
            //</Snippet10>
        }


        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(Sheet1_Startup);
            this.Shutdown+=new System.EventHandler(Sheet1_Shutdown);

            this.button1.Click += new EventHandler(button1_Click);

        }
    }
}
