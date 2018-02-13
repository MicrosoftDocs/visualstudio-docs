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

namespace Trin_Ribbon_ObjectModel_DOTNET4
{
    public partial class ThisWorkbook
    {
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }
        //<Snippet2>
        protected override Microsoft.Office.Core.IRibbonExtensibility
            CreateRibbonExtensibilityObject()
        {
            bool myCondition = false;
            if (myCondition == true)
            {
                Ribbon1 tempRibbon = new Ribbon1();
                tempRibbon.tab1.ControlId.ControlIdType =
                    Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
                tempRibbon.tab1.ControlId.OfficeId = "TabHome";
                return Globals.Factory.GetRibbonFactory().CreateRibbonManager( 
                    new Microsoft.Office.Tools.Ribbon.IRibbonExtension[]
                     { tempRibbon });
            }
            else
            {
                Ribbon2 tempRibbon = new Ribbon2();
                tempRibbon.tab1.ControlId.ControlIdType =
                    Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
                tempRibbon.tab1.ControlId.OfficeId = "TabInsert";
                return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                                    new Microsoft.Office.Tools.Ribbon.IRibbonExtension[] { tempRibbon });
            }
        }
        //</Snippet2>

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown += new System.EventHandler(ThisWorkbook_Shutdown);
        }

        #endregion

    }
}
