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

namespace Trin_VstcoreProgrammingControlsExcelCS
{
    public partial class ThisWorkbook
    {
        //<Snippet1>
        // Declare the menu variable at the class level.
        private Office.CommandBarButton menuCommand;
        private string menuTag = "A unique tag";

        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            CheckIfMenuBarExists();
            AddMenuBar();
        }

        // If the menu already exists, remove it.
        private void CheckIfMenuBarExists()
        {
            try
            {
                Office.CommandBarPopup foundMenu = (Office.CommandBarPopup)
                    this.Application.CommandBars.ActiveMenuBar.FindControl(
                    Office.MsoControlType.msoControlPopup, menuTag, true, true);

                if (foundMenu != null)
                {
                    foundMenu.Delete(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Create the menu, if it does not exist.
        private void AddMenuBar()
        {
            try
            {
                Office.CommandBarPopup cmdBarControl = null;
                Office.CommandBar menubar = (Office.CommandBar)Application.CommandBars.ActiveMenuBar;
                int controlCount = menubar.Controls.Count;
                string menuCaption = "&New Menu";

                // Add the menu.
                cmdBarControl = (Office.CommandBarPopup)menubar.Controls.Add(
                    Office.MsoControlType.msoControlPopup, controlCount, true);

                if (cmdBarControl != null)
                {
                    cmdBarControl.Caption = menuCaption;
                    cmdBarControl.Tag = menuTag;

                    // Add the menu command.
                    menuCommand = (Office.CommandBarButton)cmdBarControl.Controls.Add(
                        Office.MsoControlType.msoControlButton, true);

                    menuCommand.Caption = "&New Menu Command";
                    menuCommand.Tag = "NewMenuCommand";
                    menuCommand.FaceId = 65;

                    menuCommand.Click += new Microsoft.Office.Core._CommandBarButtonEvents_ClickEventHandler(
                        menuCommand_Click);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Add text to cell A1 when the menu is clicked.
        private void menuCommand_Click(Microsoft.Office.Core.CommandBarButton Ctrl, ref bool CancelDefault)
        {
            Globals.Sheet1.Range["A1"].Value2 = "The menu command was clicked.";
        }
        //</Snippet1>

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

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
