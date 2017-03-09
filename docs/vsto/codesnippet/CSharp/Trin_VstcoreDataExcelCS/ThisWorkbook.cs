using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreDataExcelCS
{
    public partial class ThisWorkbook
    {
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(ThisWorkbook_Startup);
        }

        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
        }
    }
}
