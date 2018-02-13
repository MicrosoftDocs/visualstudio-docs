using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Trin_WordAddInDynamicControlsWalkthrough
{
    public partial class MyRibbon : RibbonBase
    {
        public MyRibbon() : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        private void MyRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        //<Snippet6>
        private void addButtonCheckBox_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ToggleButtonOnDocument();
        }

        private void addRichTextCheckBox_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ToggleRichTextControlOnDocument();
        }
        //</Snippet6>
    }
}
