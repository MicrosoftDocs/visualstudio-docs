using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Excel.Extensions;

namespace Trin_Excel_Dynamic_Controls
{
    public partial class ThisAddIn
    {
        //<Snippet5>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.WorkbookBeforeSave += 
                new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler
                    (Application_WorkbookBeforeSave);
        }
        //</Snippet5>

        //<Snippet6>
        void Application_WorkbookBeforeSave(Microsoft.Office.Interop.Excel.Workbook workbook, 
            bool SaveAsUI, ref bool Cancel)
        {
            Excel.Worksheet worksheet =
                workbook.Worksheets[1] as Excel.Worksheet;
            
            if (Globals.Factory.HasVstoObject(worksheet) && 
                Globals.Factory.GetVstoObject(worksheet).Controls.Count > 0)
            {
                Worksheet vstoWorksheet = Globals.Factory.GetVstoObject(worksheet);
            
           
                
                while (vstoWorksheet.Controls.Count > 0)
                {
                    object vstoControl = vstoWorksheet.Controls[0];
                    vstoWorksheet.Controls.Remove(vstoControl);
                }
 
            }
        }
        //</Snippet6>

        void Application_WorkbookOpen(Microsoft.Office.Interop.Excel.Workbook Wb)
        {
            throw new NotImplementedException();
        }


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {

        }

        //<Snippet7>
        private void AddNamedRange()
        {
            Microsoft.Office.Tools.Excel.NamedRange textInCell;

            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);


            Excel.Range cell = worksheet.Range["A1"]; 
            textInCell = worksheet.Controls.AddNamedRange(cell, "MyNamedRange");
            textInCell.Value2 = "Hello World";
         }
        //</Snippet7>

        //<Snippet8>
        private void AddListObject()
        {
            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);

            Microsoft.Office.Tools.Excel.ListObject list1;
            Excel.Range cell = worksheet.Range["$A$1:$D$4"];
            list1 = worksheet.Controls.AddListObject(cell, "list1");
        }
        //</Snippet8>

        //<Snippet9>
        private void AddChart()
        {
            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet);


            Excel.Range cells = worksheet.Range["A5", "D8"];
            Chart chart = worksheet.Controls.AddChart(cells, "employees");
            chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xl3DPie;
            chart.SetSourceData(cells);
        }       
        //</Snippet9>
        
       public void AddNamedRange2()
        {
            //<Snippet10>

            Worksheet worksheet = Globals.Factory.GetVstoObject(Application.ActiveSheet);


            Microsoft.Office.Tools.Excel.NamedRange namedRange1 = worksheet.Controls.AddNamedRange(
                worksheet.Range["A1"], "MyNamedRange");
            //</Snippet10>
            //<Snippet11>
            namedRange1.RefersTo = "=Sheet1!$A$1:$B$1";
            //</Snippet11>
            
        }
        public void AddListObject2()
        {
            //<Snippet12>
            
            Worksheet worksheet = Globals.Factory.GetVstoObject(Application.ActiveSheet);

            Microsoft.Office.Tools.Excel.ListObject list1;    
            list1 = worksheet.Controls.AddListObject(worksheet.Range["$A$1:$B$3"], "MyListObject");
            //</Snippet12>
            //<Snippet13>
            list1.Resize(worksheet.Range["A1", "C5"]);
            //</Snippet13>
        }

#region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
