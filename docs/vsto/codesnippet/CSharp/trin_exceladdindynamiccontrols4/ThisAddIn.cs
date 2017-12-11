using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace Trin_ExcelAddInDynamicControls4
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //<snippet1>
            Microsoft.Office.Interop.Excel.Worksheet nativeWorksheet =
                Globals.ThisAddIn.Application.ActiveSheet;
            if (nativeWorksheet != null)
            {
                Microsoft.Office.Tools.Excel.Worksheet vstoSheet = 
                    Globals.Factory.GetVstoObject(nativeWorksheet);
            }
            //</snippet1>

            //<snippet2>
            Microsoft.Office.Interop.Excel.Workbook nativeWorkbook = 
                Globals.ThisAddIn.Application.ActiveWorkbook;
            if (nativeWorkbook != null)
            {
                Microsoft.Office.Tools.Excel.Workbook vstoWorkbook = 
                    Globals.Factory.GetVstoObject(nativeWorkbook);
            }
            //</snippet2>

            //<snippet3>
            Microsoft.Office.Interop.Excel.Worksheet sheet =
                Globals.ThisAddIn.Application.ActiveSheet;
            if (sheet.ListObjects.Count > 0)
            {
                Excel.ListObject listObject = 
                    sheet.ListObjects[1];
                Microsoft.Office.Tools.Excel.ListObject vstoListObject =
                    Globals.Factory.GetVstoObject(listObject);
            }
            //</snippet3>

        }
        //<Snippet4>
        private Microsoft.Office.Tools.Excel.Action displayAddress;

        private void AddSmartTagToWorkbook(Excel.Workbook workbook)
        {
            Microsoft.Office.Tools.Excel.SmartTag smartTagDemo =
                // Create a smart tag for .NET Framework 3.5 projects.
                // new Microsoft.Office.Tools.Excel.SmartTag(
                //    "www.microsoft.com/Demo#DemoSmartTag",
                //    "Demonstration Smart Tag");
                // Create a smart tag for .NET Framework 4 projects.
                Globals.Factory.CreateSmartTag(
                    "www.microsoft.com/Demo#DemoSmartTag",
                    "Demonstration Smart Tag");

            // Specify a term and an expression to recognize.
            smartTagDemo.Terms.Add("sale");
            smartTagDemo.Expressions.Add(
                new System.Text.RegularExpressions.Regex(
                @"[I|i]ssue\s\d{5,6}"));

            // Create the action for .NET Framework 3.5 projects.
            // displayAddress = new Microsoft.Office.Tools.Excel.Action(
            //    "To be replaced");
            // Create the action for .NET Framework 4 projects.
            displayAddress = Globals.Factory.CreateAction("To be replaced");

            // Add the action to the smart tag.
            smartTagDemo.Actions = new
                Microsoft.Office.Tools.Excel.Action[] { displayAddress };

            // Get the host item for the workbook in .NET Framework 3.5 projects.
            // Microsoft.Office.Tools.Excel.Workbook vstoWorkbook =
            //    workbook.GetVstoObject();
            // Get the host item for the workbook in .NET Framework 4 projects.
            Microsoft.Office.Tools.Excel.Workbook vstoWorkbook =
                Globals.Factory.GetVstoObject(workbook);

            // Add the smart tag to the active workbook.
            vstoWorkbook.VstoSmartTags.Add(smartTagDemo);

            displayAddress.BeforeCaptionShow += new
                Microsoft.Office.Tools.Excel.BeforeCaptionShowEventHandler(
                DisplayAddress_BeforeCaptionShow);

            displayAddress.Click += new
                Microsoft.Office.Tools.Excel.ActionClickEventHandler(
                DisplayAddress_Click);
        }

        void DisplayAddress_BeforeCaptionShow(object sender,
            Microsoft.Office.Tools.Excel.ActionEventArgs e)
        {
            Microsoft.Office.Tools.Excel.Action clickedAction =
                sender as Microsoft.Office.Tools.Excel.Action;

            if (clickedAction != null)
            {
                clickedAction.Caption = "Display the address of " +
                    e.Text;
            }
        }

        void DisplayAddress_Click(object sender,
            Microsoft.Office.Tools.Excel.ActionEventArgs e)
        {
            string smartTagAddress = e.Range.get_Address(Excel.XlReferenceStyle.xlA1);
            System.Windows.Forms.MessageBox.Show("The recognized text '" + e.Text +
                "' is at range " + smartTagAddress);
        }
        //</Snippet4>

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
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
