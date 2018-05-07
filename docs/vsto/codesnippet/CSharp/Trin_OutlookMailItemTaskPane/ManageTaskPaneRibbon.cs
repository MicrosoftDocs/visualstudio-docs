//<Snippet13>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
//<Snippet14>
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools;
//</Snippet14>

namespace OutlookMailItemTaskPane
{
    public partial class ManageTaskPaneRibbon : RibbonBase
    {
        public ManageTaskPaneRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        private void ManageTaskPaneRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        //<Snippet15>
        private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Inspector inspector = (Outlook.Inspector)e.Control.Context;
            InspectorWrapper inspectorWrapper = Globals.ThisAddIn.InspectorWrappers[inspector];
            CustomTaskPane taskPane = inspectorWrapper.CustomTaskPane;
            if (taskPane != null)
            {
                taskPane.Visible = ((RibbonToggleButton)sender).Checked;
            }
        }
        //</Snippet15>
    }
}
//</Snippet13>
