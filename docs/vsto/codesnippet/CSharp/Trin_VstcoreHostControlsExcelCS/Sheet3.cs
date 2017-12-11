using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreHostControlsExcelCS
{
    public partial class Sheet3
    {
        //---------------------------------------------------------------------
        Microsoft.Office.Tools.Excel.ListObject list1 = null;
        

        //---------------------------------------------------------------------
        //<Snippet16>
        System.Data.DataTable table = new System.Data.DataTable("Employees");
        //</Snippet16>


        //---------------------------------------------------------------------
        
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            
            //<Snippet17>
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Title", typeof(string));

            table.Rows.Add(1, "Nancy", "Anderson", "Sales Representative");
            table.Rows.Add(2, "Robert", "Brown", "Sales Representative");
            //</Snippet17>

            //<Snippet18>
            this.list1.AutoSetDataBoundColumnHeaders = true;
            this.list1.SetDataBinding(table, "", "Title", "LastName", "FirstName");
            //</Snippet18>
   
           //<Snippet19>
            this.list1.SetDataBinding(table, "", "Title", "", "LastName", "FirstName");
           //</Snippet19>
        }
           


        //---------------------------------------------------------------------
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(Sheet1_Startup);
        }
    }
}
