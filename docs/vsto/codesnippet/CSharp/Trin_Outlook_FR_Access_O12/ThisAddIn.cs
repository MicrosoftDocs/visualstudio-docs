using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace Trin_Outlook_FR_Access_O12
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }
        //<Snippet1>
        internal void Access_All_Form_Regions()
        {
            foreach (Microsoft.Office.Tools.Outlook.IFormRegion formRegion 
                in Globals.FormRegions)
            {
                if (formRegion is FormRegion1)
                {
                    FormRegion1 formRegion1 = (FormRegion1)formRegion;
                    formRegion1.textBox1.Text = "Hello World";
                }
            }

        }
        //</Snippet1>
        //<Snippet2>
        private void Access_Form_Regions_ByInspector()
        {
            WindowFormRegionCollection formRegions = 
                Globals.FormRegions
                    [Globals.ThisAddIn.Application.ActiveInspector()];
            formRegions.FormRegion1.textBox1.Text = "Hello World";
        }
        //</Snippet2>
        //<Snippet3>
        private void Access_Form_Regions_ByExplorer()
        {
            WindowFormRegionCollection formRegions =
                Globals.FormRegions
                    [Globals.ThisAddIn.Application.ActiveExplorer()];
            formRegions.FormRegion1.textBox1.Text = "Hello World";
        }
        //</Snippet3>
        //<Snippet4>
        private void Access_All_Ribbons_Globals()
        {
            Globals.Ribbons.Ribbon1.comboBox1.Text = "Hello World";
        }
        //</Snippet4>
        //<Snippet5>
        private void Access_Ribbons_By_Inspector()
        {
            ThisRibbonCollection ribbonCollection = 
                Globals.Ribbons
                    [Globals.ThisAddIn.Application.ActiveInspector()];
            ribbonCollection.Ribbon1.comboBox1.Text = "Hello World";
        }
        //</Snippet5>
        //<Snippet6>
        private void Access_Ribbons_By_Explorer()
        {
            ThisRibbonCollection ribbonCollection =
                Globals.Ribbons
                    [Globals.ThisAddIn.Application.ActiveExplorer()];
            ribbonCollection.Ribbon1.comboBox1.Text = "Hello World";
        }
        //</Snippet6>
       

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
