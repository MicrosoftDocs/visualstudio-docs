using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Trin_ExcelWorkbookDynamicControls4
{
    public partial class ThisWorkbook
    {
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

        //<snippet1>
        void ThisWorkbook_SheetActivate2(object Sh)
        {
            Microsoft.Office.Tools.Excel.Worksheet vstoWorksheet = null;
            Microsoft.Office.Interop.Excel.Worksheet interopWorksheet =
                Sh as Microsoft.Office.Interop.Excel.Worksheet;

            if (interopWorksheet != null && Globals.Factory.HasVstoObject(interopWorksheet))
            {
                vstoWorksheet = Globals.Factory.GetVstoObject(interopWorksheet);
            }

            if (vstoWorksheet != null)
            {
                // Do something with the VSTO worksheet here.
            }
        }
        //</snippet1>

        private void CreateVstoListObjectForNativeListObject()
        {
            //<Snippet2>
            Microsoft.Office.Tools.Excel.ListObject vstoListObject = null;

            if (Globals.Sheet1.ListObjects.Count > 0)
            {
                Excel.ListObject nativeListObject = Globals.Sheet1.ListObjects[1];
                vstoListObject = Globals.Sheet1.Controls.AddListObject(nativeListObject);
            }
            //</Snippet2>
        }

        private void CreateNamedRange()
        {
            //<Snippet3>
            Excel.Range range1 = Globals.Sheet1.Range["A1", "D5"];
            Microsoft.Office.Tools.Excel.NamedRange namedRange1 =
                Globals.Sheet1.Controls.AddNamedRange(range1, "ChartSource");
            //</Snippet3>

            //<Snippet4>
            Globals.Sheet1.Controls.Remove("ChartSource");
            //</Snippet4>
        }

        //<Snippet5>
        void ThisWorkbook_SheetActivate1(object Sh)
        {
            Microsoft.Office.Tools.Excel.Worksheet vstoWorksheet = null;

            if (Type.ReferenceEquals(Globals.Sheet1.InnerObject, Sh))
                vstoWorksheet = Globals.Sheet1.Base;
            else if (Type.ReferenceEquals(Globals.Sheet2.InnerObject, Sh))
                vstoWorksheet = Globals.Sheet2.Base;
            else if (Type.ReferenceEquals(Globals.Sheet3.InnerObject, Sh))
                vstoWorksheet = Globals.Sheet3.Base;

            if (vstoWorksheet != null)
            {
                // Do something with the VSTO worksheet here.
            }
        }
        //</Snippet5>

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
