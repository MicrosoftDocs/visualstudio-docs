using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace CS.VisualWebPart1
{
    //<Snippet5>
    [ToolboxItemAttribute(false)]
    public class VisualWebPart1 : WebPart
    {
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/CS/VisualWebPart1/VisualWebPart1UserControl.ascx";

        public VisualWebPart1()
        {
        }

        protected override void CreateChildControls()
        {
            Control control = this.Page.LoadControl(_ascxPath);
            Controls.Add(control);
            base.CreateChildControls();
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            base.RenderContents(writer);
        }
        
    }
    //</Snippet5>
}
