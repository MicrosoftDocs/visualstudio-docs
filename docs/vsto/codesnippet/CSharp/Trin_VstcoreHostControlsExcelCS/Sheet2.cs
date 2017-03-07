using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreHostControlsExcelCS
{
    public partial class Sheet2
    {
        //---------------------------------------------------------------------
        Microsoft.Office.Tools.Excel.ListObject list1 = null;
        

        //---------------------------------------------------------------------
        //<Snippet12>
        private int id = 0;
        private System.Data.DataTable employeeTable;
        //</Snippet12>


        //---------------------------------------------------------------------
         private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            //<Snippet13>
            employeeTable = new System.Data.DataTable("Employees");

            System.Data.DataColumn column = 
                employeeTable.Columns.Add("Id", typeof(int));
            column.AllowDBNull = false;

            employeeTable.Columns.Add("FirstName", typeof(string));
            employeeTable.Columns.Add("LastName", typeof(string));
            employeeTable.Columns.Add("Age", typeof(int));

            employeeTable.Rows.Add(id, "Nancy", "Anderson", "56");
            employeeTable.Rows.Add(id, "Robert", "Brown", "44");
            id++;

            list1.SetDataBinding(employeeTable, "", "FirstName", "LastName", "Age");

            //<Snippet15>
            list1.ErrorAddDataBoundRow += new Microsoft.Office.Tools.Excel.
                ErrorAddDataBoundRowEventHandler(list1_ErrorAddDataBoundRow);
            //</Snippet15>
            //</Snippet13>
        }
        


        //---------------------------------------------------------------------
        //<Snippet14>
        private void list1_ErrorAddDataBoundRow(object sender,
            Microsoft.Office.Tools.Excel.ErrorAddDataBoundRowEventArgs e)
        {
            System.Data.DataRow row = ((System.Data.DataRowView)e.Item).Row;

            if (e.InnerException is NoNullAllowedException)
            {
                row["Id"]= id;
                id++;
                e.Retry = true;
            }
        }
        //</Snippet14>
        //---------------------------------------------------------------------
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(Sheet1_Startup);
        }
    }
}
