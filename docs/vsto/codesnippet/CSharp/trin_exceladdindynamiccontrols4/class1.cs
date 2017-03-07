using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trin_ExcelAddInDynamicControls4
{
    class Class1
    {
        private void OtherMethod()
        {
            Microsoft.Office.Interop.Excel.Worksheet nativeWorksheet =
                Globals.ThisAddIn.Application.ActiveSheet;
            if (nativeWorksheet != null)
            {
                Microsoft.Office.Tools.Excel.Worksheet vstoSheet =
                    Globals.Factory.GetVstoObject(nativeWorksheet);
            }
        }
            
    }
}
