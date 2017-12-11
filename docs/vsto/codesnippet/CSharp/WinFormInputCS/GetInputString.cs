using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormInputCS
{
    public partial class GetInputString : Form
    {
        public GetInputString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //<Snippet3>
            Globals.ThisWorkbook.WriteStringToCell(this.textBox1.Text);
            this.Dispose();
            //</Snippet3>
        }
    }
}