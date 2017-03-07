using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Trin_Outlook_FR_Access_O12
{
    public partial class Ribbon1 : RibbonBase
    {
        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {
         //   RibbonManager.Ribbons
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.Access_All_Form_Regions();
        }
    }
}
