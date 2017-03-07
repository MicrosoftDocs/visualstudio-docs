using System;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreCreatingExcelCS
{
    public partial class ThisWorkbook
    {
        //---------------------------------------------------------------------
        //<Snippet3>
        // Add this method to your class.
        private void ThisWorkbook_New()
        {
            // Your code goes here.
        }
        //</Snippet3>


        //---------------------------------------------------------------------
        public class AnObject
        {
            public static void aMethod(){}
        }

        private void Test()
        {
            //<Snippet5>
            System.Threading.Thread t = new System.Threading.Thread(AnObject.aMethod);

            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            //</Snippet5>
        }


        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
        }

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

            //<Snippet4>
            // Add the New event handler to the Startup method.
            this.New += new Microsoft.Office.Tools.Excel.WorkbookEvents_NewEventHandler(ThisWorkbook_New);
            //</Snippet4>

        }

        #endregion

    }
}
