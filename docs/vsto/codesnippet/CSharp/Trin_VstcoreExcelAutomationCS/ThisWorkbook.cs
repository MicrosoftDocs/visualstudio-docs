using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreExcelAutomationCS
{
    public partial class ThisWorkbook
    {
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }


        //---------------------------------------------------------------------
        //<Snippet12>
        private void SetPassword() 
        {
            string password = this.Application.InputBox("Enter the new password:",
                missing, missing, missing, missing, missing, missing, missing).ToString();

            string confirmPassword = this.Application.InputBox("Confirm the password:", 
                missing, missing, missing, missing, missing, missing, missing).ToString(); 

            if (password != confirmPassword)
            {
                MessageBox.Show("The passwords you typed do not match.");
                Globals.ThisWorkbook.Password = "";
            }
            else
            {
                Globals.ThisWorkbook.Password = password;
            } 
        }
        //</Snippet12>


        //---------------------------------------------------------------------
        void Test()
        {
            string getPasswordFromUser = "password";

            //<Snippet11>
            this.Unprotect(getPasswordFromUser);
            //</Snippet11>


            //<Snippet10>
            this.Protect(getPasswordFromUser, missing, missing);
            //</Snippet10>


            //<Snippet6>
            this.SaveCopyAs(@"C:\Book1.xlsx");
            //</Snippet6>


            //<Snippet5>
            this.SaveAs(@"C:\Book1.xml", missing,
                missing, missing, missing, missing, Excel.XlSaveAsAccessMode.xlNoChange,
                missing, missing, missing, missing, missing);
            //</Snippet5>

            //<Snippet4>
            this.Save();
            //</Snippet4>
            
            
            foreach (Excel.Workbook wkb in this.Application.Workbooks) 
            {
                wkb.Save();
            }
            
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
