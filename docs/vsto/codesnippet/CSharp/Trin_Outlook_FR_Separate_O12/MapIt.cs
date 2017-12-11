using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Trin_Outlook_FR_Separate_O12
{
    partial class MapIt
    {
        #region Form Region Factory

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Contact)]
        [Microsoft.Office.Tools.Outlook.FormRegionName("Trin_Outlook_FR_Separate_O12.MapIt")]
        public partial class MapItFactory
        {
            // Occurs before the form region is initialized.
            // To prevent the form region from appearing, set e.Cancel to true.
            // Use e.OutlookItem to get a reference to the current Outlook item.
            //<Snippet1>
            private void MapItFactory_FormRegionInitializing(object sender,
                Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
                Outlook.ContactItem myItem = (Outlook.ContactItem)e.OutlookItem;

                if (myItem != null)
                {
                    if ((myItem.BusinessAddress != null &&
                            myItem.BusinessAddress.Trim().Length > 0) ||
                        (myItem.HomeAddress != null && 
                            myItem.HomeAddress.Trim().Length > 0) ||
                        (myItem.OtherAddress != null && 
                            myItem.OtherAddress.Trim().Length > 0))
                    {
                        return;
                    }
                }

                e.Cancel = true;
            }
            //</Snippet1>
        }

        #endregion

        // Occurs before the form region is displayed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        //<Snippet2>
        private void MapIt_FormRegionShowing(object sender, EventArgs e)
        {
            string tempLoc = "";
            string defaultAddress = "";
            string scratchPadAddress = "";

            Outlook.ContactItem myItem = (Outlook.ContactItem)this.OutlookItem;

            if (myItem != null)
            {
                if (myItem.HomeAddress != null && 
                        myItem.HomeAddress.Trim().Length > 0)
                {
                    tempLoc = myItem.HomeAddressStreet.Trim() + " " + 
                        myItem.HomeAddressCity + " " + myItem.HomeAddressState + 
                            " " + myItem.HomeAddressPostalCode;
                    if (myItem.HomeAddress == myItem.MailingAddress)
                    {
                        defaultAddress = tempLoc + "_Home";
                    }
                    else
                    {
                        scratchPadAddress += "adr." + tempLoc + "_Home~";
                    }
                }
                if (myItem.BusinessAddress != null && 
                        myItem.BusinessAddress.Trim().Length > 0)
                {
                    tempLoc = myItem.BusinessAddressStreet.Trim() + 
                        " " + myItem.BusinessAddressCity + " " + 
                            myItem.BusinessAddressState + " " + 
                                myItem.BusinessAddressPostalCode;
                    if (myItem.BusinessAddress == myItem.MailingAddress)
                    {
                        defaultAddress = tempLoc + "_Business";
                    }
                    else
                    {
                        scratchPadAddress += "adr." + tempLoc + "_Business~";
                    }
                }
                if (myItem.OtherAddress != null && myItem.OtherAddress.Trim().Length > 0)
                {
                    tempLoc = myItem.OtherAddressStreet.Trim() + " " + 
                        myItem.OtherAddressCity + " " + myItem.OtherAddressState + 
                            " " + myItem.OtherAddressPostalCode;
                    if (myItem.OtherAddress == myItem.MailingAddress)
                    {
                        defaultAddress = tempLoc + "_Other";
                    }
                    else
                    {
                        scratchPadAddress += "adr." + tempLoc + "_Other~";
                    }
                }
            }

            webBrowser1.Navigate("http://local.live.com/default.aspx?style=r&where1=" 
                + defaultAddress + "&sp=" + scratchPadAddress);

        }
        //</Snippet2>

        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void MapIt_FormRegionClosed(object sender, System.EventArgs e)
        {
        }
    }
}
