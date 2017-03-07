using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace Trin_VstcoreOutlookSecurity
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //UntrustedCode();
            //TrustedCode();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        // <Snippet1>
        private void UntrustedCode()
        {
            Microsoft.Office.Interop.Outlook.Application application =
                new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem1 =
                application.CreateItem(
                Microsoft.Office.Interop.Outlook.OlItemType.olMailItem) as
                Microsoft.Office.Interop.Outlook.MailItem;
            mailItem1.To = "someone@example.com";
            MessageBox.Show(mailItem1.To);
        }
        // </Snippet1>

        // <Snippet2>
        private void TrustedCode()
        {
            Microsoft.Office.Interop.Outlook.MailItem mailItem1 =
                this.Application.CreateItem(
                Microsoft.Office.Interop.Outlook.OlItemType.olMailItem) as
                Microsoft.Office.Interop.Outlook.MailItem;
            mailItem1.To = "someone@example.com";
            MessageBox.Show(mailItem1.To);
        }
        // </Snippet2>

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
