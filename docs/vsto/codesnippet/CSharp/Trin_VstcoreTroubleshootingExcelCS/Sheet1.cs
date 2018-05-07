using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreTroubleshootingExcelCS
{
    public partial class Sheet1
    {
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
        }

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
