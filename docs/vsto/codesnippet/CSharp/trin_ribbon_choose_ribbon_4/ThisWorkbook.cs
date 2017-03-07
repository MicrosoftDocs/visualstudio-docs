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

namespace Trin_Ribbon_Choose_Ribbon_4
{
    public partial class ThisWorkbook
    {
        bool myCondition = true;
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }
        //<Snippet1>
        protected override Microsoft.Office.Core.IRibbonExtensibility
    CreateRibbonExtensibilityObject()
        {
            if (myCondition == true)
            {
                return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                    new Microsoft.Office.Tools.Ribbon.IRibbonExtension[] { new Ribbon1() });
            }
            else
            {
                return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                    new Microsoft.Office.Tools.Ribbon.IRibbonExtension[] { new Ribbon2() });
            }
        }
        //</Snippet1>

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
