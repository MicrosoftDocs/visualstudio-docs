using System;
using System.Windows.Forms;

namespace Trin_VstcoreActionsPaneWordCS
{
    partial class ShowPropertiesControl : UserControl
    {
        //---------------------------------------------------------------------
        //<Snippet28>
        public ShowPropertiesControl()
        {
            InitializeComponent();
            this.tableProperties.Click += new System.EventHandler(this.tableProperties_Click);
        }
        //</Snippet28>


        //---------------------------------------------------------------------
        //<Snippet27>
        private void tableProperties_Click(object sender, System.EventArgs e)
        {
            object timeout = 0;

            Globals.ThisDocument.Application.Dialogs[
                Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableProperties]
                    .Show(ref timeout);
        }
        //</Snippet27>
    }
}
