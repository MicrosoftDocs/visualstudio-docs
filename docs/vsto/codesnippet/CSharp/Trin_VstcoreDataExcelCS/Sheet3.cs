using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreDataExcelCS
{
    public partial class Sheet3
    {
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(Sheet3_Startup);
        }

        private void Sheet3_Startup(object sender, System.EventArgs e)
        {
            // TODO: Delete this line of code to remove the default AutoFill for 'northwindDataSet.Employees'.
            //if (this.NeedsFill("northwindDataSet"))
            //{
            //    this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            //}


            //<Snippet8>
            this.button1.Text = "Save";
            //</Snippet8>


            //<Snippet9>
            this.button1.Click += new EventHandler(button1_Click);
            //</Snippet9>
        }


        //---------------------------------------------------------------------
        //<Snippet10>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.Update(this.northwindDataSet.Employees);
            }
            catch (System.Data.DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //</Snippet10>
    }
}
