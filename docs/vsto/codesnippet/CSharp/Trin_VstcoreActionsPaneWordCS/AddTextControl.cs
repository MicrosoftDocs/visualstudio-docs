using System;
using System.Windows.Forms;

namespace Trin_VstcoreActionsPaneWordCS
{
    partial class AddTextControl : UserControl
    {
        //---------------------------------------------------------------------
        //<Snippet26>
        public AddTextControl()
        {
            InitializeComponent();
            this.insertText.Click += new System.EventHandler(this.insertText_Click);
        }
        //</Snippet26>


        //---------------------------------------------------------------------
        //<Snippet25>
        private void insertText_Click(object sender, System.EventArgs e)
        {
            Globals.ThisDocument.InsertMemoFromNode.Text = this.fromBox.Text;
            Globals.ThisDocument.InsertMemoToNode.Text = this.toBox.Text;
            Globals.ThisDocument.InsertMemoSubjectNode.Text = this.subjectBox.Text;

            // Clear the text boxes.
            this.fromBox.Text = "";
            this.toBox.Text = "";
            this.subjectBox.Text = "";
        }
        //</Snippet25>
    }
}
