using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;

namespace Trin_TaskPaneBasic
{
    public partial class ThisAddIn
    {
        //<Snippet1>
        private MyUserControl myUserControl1;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        //</Snippet1>

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //<Snippet2>
            myUserControl1 = new MyUserControl();
            myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "My Task Pane");
            myCustomTaskPane.Visible = true;
            //</Snippet2>
        }

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
