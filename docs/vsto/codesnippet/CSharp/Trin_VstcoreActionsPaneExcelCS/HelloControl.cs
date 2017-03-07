#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

#endregion

namespace Trin_VstcoreActionsPaneExcelCS
{
    partial class HelloControl : UserControl
    {
        //---------------------------------------------------------------------
        //<Snippet6>
        public HelloControl()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }
        //</Snippet6>


        //---------------------------------------------------------------------
        //<Snippet5>
        private void button1_Click(object sender, System.EventArgs e)
        {
            Globals.Sheet1.Range["A1"].Value2 = "Hello World!";
        }
        //</Snippet5>
    }
}
