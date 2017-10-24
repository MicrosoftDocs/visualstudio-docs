using System;
using System.Windows.Forms;

namespace Trin_VstcoreActionsPaneWordCS
{
    partial class HelloControl : UserControl
    {
        //---------------------------------------------------------------------
        //<Snippet13>
        public HelloControl()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(this.button1_Click);
        }
        //</Snippet13>


        //---------------------------------------------------------------------
        //<Snippet12>
        private void button1_Click(object sender, System.EventArgs e)
        {
            Globals.ThisDocument.Paragraphs[1].Range.Text = "Hello World!";
        }
        //</Snippet12>
    }
}
