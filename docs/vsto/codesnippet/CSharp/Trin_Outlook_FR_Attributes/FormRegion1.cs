using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Trin_Outlook_FR_Attributes
{
    partial class FormRegion1
    {
        #region Form Region Factory
        //<Snippet1>
        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass
            (Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)]
        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass
            ("IPM.Task.Contoso")]
        [Microsoft.Office.Tools.Outlook.FormRegionName
            ("Trin_Outlook_FR_Attributes.FormRegion1")]
        public partial class FormRegion1Factory
        {
            // Occurs before the form region is initialized.
            // To prevent the form region from appearing, set e.Cancel to true.
            // Use e.OutlookItem to get a reference to the current Outlook item.
            private void FormRegion1Factory_FormRegionInitializing(object sender, 
                Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
            }
        }
        //</Snippet1>
        #endregion

        // Occurs before the form region is displayed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        //<Snippet2>
        private void FormRegion1_FormRegionShowing
            (object sender, System.EventArgs e)
        {
            if (this.OutlookItem is Outlook.MailItem)
            {
                if (this.OutlookFormRegion.FormRegionMode == 
                    Outlook.OlFormRegionMode.olFormRegionRead)
                {
                    Outlook.MailItem mailItem = 
                    (Outlook.MailItem)this.OutlookItem;
                    label1.Text = "This form region contains information " +
                    "about " + mailItem.Subject;
                }
             }

        }
        //</Snippet2>

        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void FormRegion1_FormRegionClosed(object sender, System.EventArgs e)
        {
        }
    }
}
