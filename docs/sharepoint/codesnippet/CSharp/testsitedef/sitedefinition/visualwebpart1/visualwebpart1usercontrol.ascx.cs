using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace TestSiteDef.SiteDefinition.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
        }

        //<Snippet1>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {            
            lblName.Text = tbName.Text;
        }
        //</Snippet1>

    }
}
