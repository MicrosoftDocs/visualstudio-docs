using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;
using OutlookTools = Microsoft.Office.Tools.Outlook;

namespace Trin_Outlook_FR_Import
{
    public partial class TaskFormRegion
    {
        #region Form Region Factory

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.Task.TaskFormRegion")]
        [Microsoft.Office.Tools.Outlook.FormRegionName("Trin_Outlook_FR_Import.TaskFormRegion")]
        public partial class TaskFormRegionFactory
        {
            private void InitializeManifest()
            {
                ResourceManager resources = new ResourceManager(typeof(TaskFormRegion));
                this.Manifest.FormRegionType = OutlookTools.FormRegionType.ReplaceAll;
                this.Manifest.Title = resources.GetString("Title");
                this.Manifest.FormRegionName = resources.GetString("FormRegionName");
                this.Manifest.Description = resources.GetString("Description");
                this.Manifest.ShowInspectorCompose = true;
                this.Manifest.ShowInspectorRead = true;
                this.Manifest.ShowReadingPane = true;

            }

            // Occurs before the form region is initialized.
            // To prevent the form region from appearing, set e.Cancel to true.
            // Use e.OutlookItem to get a reference to the current Outlook item.
            private void TaskFormRegionFactory_FormRegionInitializing(object sender, OutlookTools.FormRegionInitializingEventArgs e)
            {
            }
        }

        #endregion

        // Occurs before the form region is displayed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        //<Snippet5>
        private void TaskFormRegion_FormRegionShowing
            (object sender, EventArgs e)
        {
            populateComboBox();
            RefreshTaskListBox();
            this.addDependentTask.Click += new
            Microsoft.Office.Interop.Outlook.
                OlkCommandButtonEvents_ClickEventHandler(AddDependentTask_Click);

        }
        //</Snippet5>
        //<Snippet1>
        private void populateComboBox()
        {
            Outlook.Application Application = new Outlook.Application();
            Outlook.NameSpace outlookNameSpace = Application.GetNamespace("MAPI");
            Outlook.MAPIFolder taskFolder = outlookNameSpace.GetDefaultFolder(
                Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderTasks);
            Outlook.Items taskItems = taskFolder.Items;
            foreach (Outlook.TaskItem task in taskItems)
            {
                if (task.Subject != null)
                {
                    comboBox1.AddItem(task.Subject, System.Type.Missing);
                }
            }
            comboBox1.Text = comboBox1.GetItem(0);
        }
        //</Snippet1>
        //<Snippet2>
        void AddDependentTask_Click()
        {
            Outlook.TaskItem tempTaskItem = FindTaskBySubjectName(comboBox1.Text);
            if (tempTaskItem != null)
            {
                this.listBox1.AddItem(tempTaskItem.PercentComplete.ToString()
    + "% Complete -- " + tempTaskItem.Subject, System.Type.Missing);
                this.olkTextBox3.Text = this.olkTextBox3.Text + "|" + 
                    tempTaskItem.Subject;
            }
        }
        //</Snippet2>
        //<Snippet3>
        private Outlook.TaskItem FindTaskBySubjectName(string subjectName)
        {
            Outlook.Application Application = new Outlook.Application();
            Outlook.NameSpace outlookNameSpace = Application.GetNamespace("MAPI");
            Outlook.MAPIFolder tasksFolder =
                outlookNameSpace.GetDefaultFolder(
            Microsoft.Office.Interop.Outlook.
                OlDefaultFolders.olFolderTasks);
            Outlook.Items taskItems = tasksFolder.Items;
            foreach (Outlook.TaskItem taskItem in taskItems)
            {
                if (taskItem.Subject == subjectName)
                {
                    return taskItem;
                }
            }
            return null;
        }
        //</Snippet3>
        //<Snippet4>
        void RefreshTaskListBox()
        {
            listBox1.Clear();
            Outlook.TaskItem tempTaskItem;
            String[] tempArray = olkTextBox3.Text.Split(new Char[] { '|' });

            foreach (string tempString in tempArray)
            {
                tempTaskItem = FindTaskBySubjectName(tempString);
                if (tempTaskItem != null)
                {
                    this.listBox1.AddItem(tempTaskItem.PercentComplete.ToString()
                        + "% Complete -- " + tempTaskItem.Subject, 
                            System.Type.Missing);
                }
            }
        }
        //</Snippet4>

        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void TaskFormRegion_FormRegionClosed(object sender, 
            System.EventArgs e)
        {
        }
    }
}
