using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trin_VstcoreActionsPaneExcelCS
{
    partial class ActionsControl : UserControl
    {
        //---------------------------------------------------------------------
        //<Snippet2>
        public ActionsControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(ActionsControl_Load);
        }
        //</Snippet2>


        //---------------------------------------------------------------------
        //<Snippet1>
        private void ActionsControl_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = Globals.Sheet1.suppliersBindingSource;
            this.comboBox1.DisplayMember = "CompanyName";
        }
        //</Snippet1>
    }
}
