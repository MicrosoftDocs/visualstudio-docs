using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Trin_SimpleExtensibilityInterface
{
    //<Snippet1>
    public class TaskPaneHelper : Office.ICustomTaskPaneConsumer
    {
        internal Office.CustomTaskPane taskPane;

        public void CTPFactoryAvailable(Office.ICTPFactory CTPFactoryInst)
        {
            if (CTPFactoryInst != null)
            {
                // Create a new task pane.
                taskPane = CTPFactoryInst.CreateCTP(
                    "Microsoft.Samples.Vsto.CS.TaskPaneUI",
                    "Contoso");
                taskPane.Visible = true;
            }
        }
    }

    [System.Runtime.InteropServices.ComVisible(true)]
    [System.Runtime.InteropServices.ProgId("Microsoft.Samples.Vsto.CS.TaskPaneUI")]
    [System.Runtime.InteropServices.Guid("FFA0920E-F7A5-453d-8AB2-249F4C25B4B2")]
    public class TaskPaneUI : UserControl
    {
    }
    //</Snippet1>

  //  [AddIn("Trin_SimpleICustomTaskPaneConsumer", Version = "1.0", Publisher = "", Description = "")]
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        //<Snippet2>
        internal TaskPaneHelper taskPaneHelper1;

        protected override object RequestService(Guid serviceGuid)
        {
            if (serviceGuid == typeof(Office.ICustomTaskPaneConsumer).GUID)
            {
                if (taskPaneHelper1 == null)
                {
                    taskPaneHelper1 = new TaskPaneHelper();
                }
                return taskPaneHelper1;
            }

            return base.RequestService(serviceGuid);
        }
        //</Snippet2>

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
