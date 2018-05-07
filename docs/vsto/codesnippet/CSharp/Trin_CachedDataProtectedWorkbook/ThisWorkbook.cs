using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Trin_CachedDataProtectedWorkbook
{
    public partial class ThisWorkbook
    {
        //<Snippet1>
        [CachedAttribute]
        public string CachedString = "This string is cached in the workbook.";

        //<Snippet2>
        private bool protectStructureValue;
        private bool protectWindowsValue;

        protected override void UnprotectDocument()
        {
            protectStructureValue = this.ProtectStructure;
            protectWindowsValue = this.ProtectWindows;

            this.Unprotect(securelyStoredPassword);
        }
        //</Snippet2>

        //<Snippet3>
        protected override void ProtectDocument()
        {
            this.Protect(securelyStoredPassword, protectStructureValue,
                protectWindowsValue);
        }
        //</Snippet3>
        //</Snippet1>


        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            Globals.Sheet1.textBox1.Text = this.CachedString;
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

        // Some helper stuff that doesn't factor into the actual code snippets.
        internal object securelyStoredPassword = GetPassword();

        private static string GetPassword()
        {
            return "secure";
        }


        //private void UnprotectWorkbook()
        //{
        //    protectStructureValue = this.ProtectStructure;
        //    protectWindowsValue = this.ProtectWindows;

        //    this.Unprotect(securelyStoredPassword);
        //}

        // Unused code. I thought this issue also affected worksheets, but in my testing on a 
        // password protected worksheet, the cached data changes are still saved, event without 
        // overriding ProtectDocument and UnprotectDocument. Saving this code down here just
        // in case.
        //// These fields store the current protection settings.
        //private Excel.Protection protectionValue;
        //private bool drawingObjectsValue;
        //private bool contentsValue;
        //private bool scenariosValue;
        //private bool userInterfaceOnlyValue;

        //protected override void UnprotectDocument()
        //{
        //    // Save the current protection settings.
        //    protectionValue = Globals.Sheet1.Protection;
        //    drawingObjectsValue = Globals.Sheet1.ProtectDrawingObjects;
        //    contentsValue = Globals.Sheet1.ProtectContents;
        //    scenariosValue = Globals.Sheet1.ProtectScenarios;
        //    userInterfaceOnlyValue = Globals.Sheet1.ProtectionMode;

        //    Globals.Sheet1.Unprotect(securelyStoredPassword);
        //}

        //protected override void ProtectDocument()
        //{
        //    Globals.Sheet1.Protect(securelyStoredPassword, drawingObjectsValue,
        //        contentsValue, scenariosValue, userInterfaceOnlyValue,
        //        protectionValue.AllowFormattingCells, 
        //        protectionValue.AllowFormattingColumns, 
        //        protectionValue.AllowFormattingRows,
        //        protectionValue.AllowInsertingColumns, 
        //        protectionValue.AllowInsertingRows,
        //        protectionValue.AllowInsertingHyperlinks, 
        //        protectionValue.AllowDeletingColumns,
        //        protectionValue.AllowDeletingRows, 
        //        protectionValue.AllowSorting,
        //        protectionValue.AllowFiltering, 
        //        protectionValue.AllowUsingPivotTables);
        //}

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown += new System.EventHandler(ThisWorkbook_Shutdown);
        }

        #endregion

    }
}
