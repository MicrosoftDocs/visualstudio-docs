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
    public partial class Sheet1
    {
        //<Snippet6>
        private Microsoft.Office.Tools.Excel.ListObject vstoListObject;
        private const int DISP_E_BADINDEX = unchecked((int)0x8002000B);

        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            Excel.ListObject nativeListObject = null;

            try
            {
                nativeListObject = this.ListObjects.get_Item("MyListObject");
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                // "MyListObject" does not exist.
                if (ex.ErrorCode != DISP_E_BADINDEX)
                    throw;
            }

            if (nativeListObject != null)
            {
                vstoListObject = this.Controls.AddListObject(nativeListObject);
            }
        }
        //</Snippet6>

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
            this.Shutdown += new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion

    }
}
