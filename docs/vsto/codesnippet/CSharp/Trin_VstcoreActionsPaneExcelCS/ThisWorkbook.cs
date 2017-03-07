using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreActionsPaneExcelCS
{
    public partial class ThisWorkbook
    {

        //---------------------------------------------------------------------
        //<Snippet7>
        private HelloControl hello = new HelloControl();
        //</Snippet7>


        //---------------------------------------------------------------------
        //<Snippet3>
        ActionsControl actions = new ActionsControl();
        //</Snippet3>


        //---------------------------------------------------------------------
        void Test()
        {
            //<Snippet9>
            this.Application.CommandBars["Task Pane"].Visible = false;
            //</Snippet9>

            //<Snippet10>
            this.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromTop;
            //</Snippet10>

            //<Snippet11>
            this.Application.DisplayDocumentActionTaskPane = false;
            //</Snippet11>
        }


        //---------------------------------------------------------------------
        void StartUp()
        {
            //<Snippet8>
            this.ActionsPane.Controls.Add(hello);
            //</Snippet8>
        }


        //---------------------------------------------------------------------
        //<Snippet4>
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            this.ActionsPane.Controls.Add(actions);
        }
        //</Snippet4>


        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown+=new System.EventHandler(ThisWorkbook_Shutdown);
        }
    }
}
