//<Snippet1>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
//<Snippet2>
using Microsoft.Office.Tools;
//</Snippet2>

namespace OutlookMailItemTaskPane
{
    //<Snippet3>
    public class InspectorWrapper
    {
        private Outlook.Inspector inspector;
        private CustomTaskPane taskPane;
        //</Snippet3>

        //<Snippet4>
        public InspectorWrapper(Outlook.Inspector Inspector)
        {
            inspector = Inspector;
            ((Outlook.InspectorEvents_Event)inspector).Close +=
                new Outlook.InspectorEvents_CloseEventHandler(InspectorWrapper_Close);
            
            taskPane = Globals.ThisAddIn.CustomTaskPanes.Add(
                new TaskPaneControl(), "My task pane", inspector);
            taskPane.VisibleChanged += new EventHandler(TaskPane_VisibleChanged);
        }
        //</Snippet4>

        //<Snippet5>
        void TaskPane_VisibleChanged(object sender, EventArgs e)
        {
            Globals.Ribbons[inspector].ManageTaskPaneRibbon.toggleButton1.Checked = 
                taskPane.Visible;
        }
        //</Snippet5>

        //<Snippet6>
        void InspectorWrapper_Close()
        {
            if (taskPane != null)
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(taskPane);
            }

            taskPane = null;
            Globals.ThisAddIn.InspectorWrappers.Remove(inspector);
            ((Outlook.InspectorEvents_Event)inspector).Close -=
                new Outlook.InspectorEvents_CloseEventHandler(InspectorWrapper_Close);
            inspector = null;
        }
        //</Snippet6>

        //<Snippet7>
        public CustomTaskPane CustomTaskPane
        {
            get
            {
                return taskPane;
            }
        }
    }
    //</Snippet7>

    public partial class ThisAddIn
    {
        //<Snippet8>
        private Dictionary<Outlook.Inspector, InspectorWrapper> inspectorWrappersValue =
            new Dictionary<Outlook.Inspector, InspectorWrapper>();
        private Outlook.Inspectors inspectors;
        //</Snippet8>

        //<Snippet9>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            inspectors = this.Application.Inspectors;
            inspectors.NewInspector +=
                new Outlook.InspectorsEvents_NewInspectorEventHandler(
                Inspectors_NewInspector);

            foreach (Outlook.Inspector inspector in inspectors)
            {
                Inspectors_NewInspector(inspector);
            }
        }
        //</Snippet9>

        //<Snippet10>
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            inspectors.NewInspector -=
                new Outlook.InspectorsEvents_NewInspectorEventHandler(
                Inspectors_NewInspector);
            inspectors = null;
            inspectorWrappersValue = null;
        }
        //</Snippet10>

        //<Snippet11>
        void Inspectors_NewInspector(Outlook.Inspector Inspector)
        {
            if (Inspector.CurrentItem is Outlook.MailItem)
            {
                inspectorWrappersValue.Add(Inspector, new InspectorWrapper(Inspector));
            }
        }
        //</Snippet11>

        //<Snippet12>
        public Dictionary<Outlook.Inspector, InspectorWrapper> InspectorWrappers
        {
            get
            {
                return inspectorWrappersValue;
            }
        }
        //</Snippet12>

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
//</Snippet1>