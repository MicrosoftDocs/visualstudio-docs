using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreTroubleshootingExcelCS
{
    public partial class ThisWorkbook
    {
        //<Snippet1>
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            ((Excel.AppEvents_Event)this.Application).NewWorkbook += 
                new Excel.AppEvents_NewWorkbookEventHandler(ThisWorkbook_NewWorkbook);
        }

        void ThisWorkbook_NewWorkbook(Excel.Workbook Wb)
        {
            // Perform some work here.
        }
        //</Snippet1>

        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(ThisWorkbook_Startup);
        }
    }
}
