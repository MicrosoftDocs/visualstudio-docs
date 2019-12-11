using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsentDialog
{
    public partial class Form1 : Form
    {
        //<snippet6>
        public Form1()
        {
            InitializeComponent();
            ProceedButton.Enabled = false;
        }
        //</snippet6>

        //<snippet3>
        public bool accepted = false;
        //</snippet3>

        //<snippet1>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ProceedButton.Enabled = !ProceedButton.Enabled;
        }
        //</snippet1>

        //<snippet2>
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (ProceedButton.Enabled)
            {
                accepted = true;
                this.Close();
            }
        }
        //</snippet2>

        //<snippet4>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //</snippet4>



    }
}
