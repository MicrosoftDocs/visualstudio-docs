using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace Trin_Outlook_RL_AttachFiles
{
    public partial class ThisAddIn
    {
        // <Snippet1>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            AddAttachment();
        }

        private void AddAttachment()
        {
            Outlook.MailItem mail =
                this.Application.CreateItem
                (Outlook.OlItemType.olMailItem)
                as Outlook.MailItem;

            mail.Subject = "An attachment for you!";

            OpenFileDialog attachment = new OpenFileDialog();

            attachment.Title = "Select a file to send";
            attachment.ShowDialog();

            if (attachment.FileName.Length > 0)
            {
                mail.Attachments.Add(
                    attachment.FileName,
                    Outlook.OlAttachmentType.olByValue,
                    1,
                    attachment.FileName);
                mail.Recipients.Add("Armando Pinto ");
                ((Outlook._MailItem)mail).Send();
            }
        }
        // </Snippet1>

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

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
