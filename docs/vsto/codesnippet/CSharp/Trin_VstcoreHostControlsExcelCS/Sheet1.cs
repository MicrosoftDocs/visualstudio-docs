using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreHostControlsExcelCS
{
    public partial class Sheet1
    {
        //---------------------------------------------------------------------
        //<Snippet24>
        private void namedRange1_BeforeDoubleClick(
            Microsoft.Office.Interop.Excel.Range Target, ref bool Cancel)
        {
            this.namedRange2.Value2 = "The BeforeDoubleClick event occurred.";
            this.namedRange2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            this.namedRange2.Font.Italic = true;
        }
        //</Snippet24>


        //---------------------------------------------------------------------
        //<Snippet26>
        private void namedRange1_Change(Microsoft.Office.Interop.Excel.Range Target)
        {
            this.namedRange2.Value2 = "The Change event occurred.";
            this.namedRange2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
            this.namedRange2.Font.Italic = false;
        }
        //</Snippet26>


        //---------------------------------------------------------------------
        //<Snippet27>
        private void namedRange1_SelectionChange(Microsoft.Office.Interop.Excel.Range Target)
        {
            this.namedRange2.Value2 = "The SelectionChange event occurred.";
            this.namedRange2.AddComment("SelectionChange always occurs before BeforeDoubleClick.");
            this.namedRange2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
        }
        //</Snippet27>


        //---------------------------------------------------------------------
        private void StartUp()
        {
            //<Snippet25>
            this.namedRange1.BeforeDoubleClick += new Microsoft.Office.Interop.Excel.
                DocEvents_BeforeDoubleClickEventHandler(namedRange1_BeforeDoubleClick);   

            this.namedRange1.Change += new Microsoft.Office.Interop.Excel.
                DocEvents_ChangeEventHandler(namedRange1_Change);

            this.namedRange1.SelectionChange +=new Microsoft.Office.Interop.Excel.
                DocEvents_SelectionChangeEventHandler(namedRange1_SelectionChange);
            //</Snippet25>
        }
        

        //---------------------------------------------------------------------
        Microsoft.Office.Tools.Excel.ListObject list1 = null;
        

        //---------------------------------------------------------------------
        //<Snippet8>
        private int id = 0;
        private System.Data.DataTable employeeTable;
        //</Snippet8>


        //---------------------------------------------------------------------
        private void Test2()
        {
            //<Snippet6>
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(this.Range["A1", "B3"], "list1");
            //</Snippet6>


            //<Snippet7>
            list1.Resize(this.Range["A1", "C5"]);
            //</Snippet7>


            //<Snippet4>
            Microsoft.Office.Tools.Excel.NamedRange NamedRange1 =
                this.Controls.AddNamedRange(this.Range["A1"], "NamedRange1");
            //</Snippet4>


            //<Snippet5>
            NamedRange1.RefersTo = "=Sheet1!$A$1:$B$1";
            //</Snippet5>


            //<Snippet3>
            Microsoft.Office.Tools.Excel.NamedRange textInCell;
            textInCell = this.Controls.AddNamedRange(this.get_Range("A1"), "cellText");

            textInCell.Value2 = "Hello world!";
            //</Snippet3>


            //<Snippet2>
            Microsoft.Office.Tools.Excel.ListObject employeeData;
            employeeData = this.Controls.AddListObject(this.get_Range("$A$1:$D$4"), "employees");
            //</Snippet2>
        }


        //---------------------------------------------------------------------
        private void Test1()
        {
            //<Snippet28>
            this.Range["A1"].Value2 = "Monday";
            this.Range["A2"].Value2 = "Tuesday";

            Microsoft.Office.Tools.Excel.NamedRange dayRange = 
                this.Controls.AddNamedRange(this.Range["A1", "A7"], "dayRange");
            this.Range["A1", "A2"].AutoFill(dayRange.InnerObject, Excel.XlAutoFillType.xlFillDays);
            //</Snippet28>

        
            //<Snippet1>
            Microsoft.Office.Tools.Excel.Chart employeeData;
            employeeData = this.Controls.AddChart(25, 110, 200, 150, "employees");
            employeeData.ChartType = Excel.XlChartType.xl3DPie;

            // Gets the cells that define the data to be charted.
            Excel.Range chartRange = this.get_Range("A5", "D8");
            employeeData.SetSourceData(chartRange, missing);
            //</Snippet1>
        }
        

        //---------------------------------------------------------------------
        
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            
             //<Snippet9>
            employeeTable = new System.Data.DataTable("Employees");

            System.Data.DataColumn column = employeeTable.Columns.Add
                ("Id", typeof(int));
            column.AllowDBNull = false;

            employeeTable.Columns.Add("FirstName", typeof(string));
            employeeTable.Columns.Add("LastName", typeof(string));
            employeeTable.Columns.Add("Age", typeof(int));

            employeeTable.Rows.Add(id, "Nancy", "Anderson", "56");
            employeeTable.Rows.Add(id, "Robert", "Brown", "44");
            id++;

            list1.SetDataBinding(employeeTable, "", "FirstName", "LastName", "Age");

            //<Snippet11>
            list1.BeforeAddDataBoundRow +=new Microsoft.Office.Tools.Excel.
                BeforeAddDataBoundRowEventHandler(list1_BeforeAddDataBoundRow);
            //</Snippet11>
            //</Snippet9>
        }
        


        //---------------------------------------------------------------------
        //<Snippet10>
        private void list1_BeforeAddDataBoundRow(object sender,
            Microsoft.Office.Tools.Excel.BeforeAddDataBoundRowEventArgs e)
        {
            System.Data.DataRow row = ((System.Data.DataRowView)e.Item).Row;

            if (row["Age"] != null && row["Age"] != Convert.DBNull)
            {
                int ageEntered = (int)row["Age"];

                if (ageEntered < 21 || ageEntered > 65)
                {
                    System.Windows.Forms.MessageBox.Show
                        ("Age must be between 21 and 65. The row cannot be added.");
                    e.Cancel = true;
                    return;
                }
                row["ID"] = id;
                id++;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You must enter an age.");
                e.Cancel = true;
            }
        }
        //</Snippet10>


        //---------------------------------------------------------------------
        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(Sheet1_Startup);
            this.Shutdown+=new System.EventHandler(Sheet1_Shutdown);
        }
    }
}
