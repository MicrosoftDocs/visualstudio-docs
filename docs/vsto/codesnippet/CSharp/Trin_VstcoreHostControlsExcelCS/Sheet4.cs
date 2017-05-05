using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreHostControlsExcelCS
{
    public partial class Sheet4
    {
        Microsoft.Office.Tools.Excel.ListObject list1 = null;        
        //---------------------------------------------------------------------
        //<Snippet20>
        System.Data.DataTable table = new System.Data.DataTable("Employees");
        //</Snippet20>


        //---------------------------------------------------------------------
        
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            //<Snippet21>
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Title", typeof(string));

            table.Rows.Add("Nancy", "Anderson", "Sales Representative");
            table.Rows.Add("Robert", "Brown", "Sales Representative");
            //</Snippet21>

            //<Snippet22>
       
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.SetDataBinding(table, null, "LastName", "FirstName");
            //</Snippet22>

            //<Snippet23>
            list1.Disconnect();
            //</Snippet23>
        }
        


        //---------------------------------------------------------------------
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(Sheet1_Startup);
        }
    }
}
