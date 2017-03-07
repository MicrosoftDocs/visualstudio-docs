using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace WinFormInputCS
{
    public partial class ThisWorkbook
    {
        //<Snippet1>
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            this.Open += new 
                Microsoft.Office.Interop.Excel.WorkbookEvents_OpenEventHandler(ThisWorkbook_Open);
        }

        private void ThisWorkbook_Open()
        {
            GetInputString inputForm = new GetInputString();
            inputForm.ShowDialog();
        }
        //</Snippet1>


        //<Snippet2>
        public void WriteStringToCell(string formData)
        {
            Globals.Sheet1.formInput.Value2 = formData;
        }
        //</Snippet2>


        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown+=new System.EventHandler(ThisWorkbook_Shutdown);
        }

        #endregion

    }
}
