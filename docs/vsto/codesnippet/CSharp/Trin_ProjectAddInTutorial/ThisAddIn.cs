using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using MSProject = Microsoft.Office.Interop.MSProject;
using Office = Microsoft.Office.Core;

namespace Trin_ProjectAddInTutorial
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //<Snippet2>
            this.Application.NewProject += new Microsoft.Office.Interop.MSProject._EProjectApp2_NewProjectEventHandler(Application_NewProject);
            //</Snippet2>
        }

        //<Snippet1>
        void Application_NewProject(Microsoft.Office.Interop.MSProject.Project pj)
        {
            MSProject.Task newTask = pj.Tasks.Add
                ("This text was added by using code", missing);
            newTask.Start = DateTime.Now;
            newTask.Duration = "3";
            newTask.ResourceNames = "Rob Caron, Kelly Krout";
        }
        //</Snippet1>

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
