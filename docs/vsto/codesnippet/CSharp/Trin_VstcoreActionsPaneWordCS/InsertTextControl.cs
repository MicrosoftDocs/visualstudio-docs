using System;
using System.Windows.Forms;

namespace Trin_VstcoreActionsPaneWordCS
{
    partial class InsertTextControl : UserControl
    {
        //---------------------------------------------------------------------
        //<Snippet9>
        public InsertTextControl()
        {
            InitializeComponent();
            this.addText.Click += new EventHandler(addText_Click);
        }
        //</Snippet9>
        

        //---------------------------------------------------------------------
        //<Snippet8>
        private void addText_Click(object sender, System.EventArgs e)
        {
            if (this.getName.Text != String.Empty) 
            {
                Globals.ThisDocument.showName.Text = this.getName.Text;
            }

            if (this.getAddress.Text != String.Empty)
            {
                Globals.ThisDocument.showAddress.Text = this.getAddress.Text;
            }

            this.getName.Text = String.Empty;
            this.getAddress.Text = String.Empty;
        }
        //</Snippet8>
    }
}
