using System;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

//<Snippet1>
using System.Data;
//</Snippet1>

namespace SpExt_WebPart
{
    [Guid("fe9aa7b3-67e3-46c5-b157-172a90fcafaa")]
    public class WebPart1 : WebPart
    {
        //<Snippet2>
        private DataGrid grid;
        private static string verbText = "Show Managers Only";
        private Label errorMessage = new Label();
        protected string xmlFilePath;
        //</Snippet2>

        public WebPart1()
        {
        }

        //<Snippet3>
        [Personalizable(PersonalizationScope.Shared), WebBrowsable(true),
        WebDisplayName("Path to Employee Data File"),
        WebDescription("Location of the XML file that contains employee data")]
        public string DataFilePath
        {
            get
            {
                return xmlFilePath;
            }
            set
            {
                xmlFilePath = value;
            }
        }
        //</Snippet3>

        //<Snippet4>
        protected override void CreateChildControls()
        {
            // Define the grid control that displays employee data in the Web Part.
            grid = new DataGrid();
            grid.Width = Unit.Percentage(100);
            grid.GridLines = GridLines.Horizontal;
            grid.HeaderStyle.CssClass = "ms-vh2";
            grid.CellPadding = 2;
            grid.BorderWidth = Unit.Pixel(5);
            grid.HeaderStyle.Font.Bold = true;
            grid.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;

            // Populate the grid control with data in the employee data file.
            try
            {
                DataSet dataset = new DataSet();
                dataset.ReadXml(xmlFilePath, XmlReadMode.InferSchema);
                grid.DataSource = dataset;
                grid.DataBind();
            }
            catch (Exception x)
            {
                errorMessage.Text += x.Message;
            }

            // Add control to the controls collection of the Web Part.
            Controls.Add(grid);
            Controls.Add(errorMessage);
            base.CreateChildControls();
        }
        //</Snippet4>

        protected override void Render(HtmlTextWriter writer)
        {

            base.Render(writer);
        }

        //<Snippet5>
        public override WebPartVerbCollection Verbs
        {
            get
            {
                WebPartVerb customVerb = new WebPartVerb("Manager_Filter_Verb",
                    new WebPartEventHandler(CustomVerbEventHandler));

                customVerb.Text = verbText;
                customVerb.Description = "Shows only employees that are managers";

                WebPartVerb[] newVerbs = new WebPartVerb[] { customVerb };

                return new WebPartVerbCollection(base.Verbs, newVerbs);
            }
        }

        protected void CustomVerbEventHandler(object sender, WebPartEventArgs args)
        {
            int titleColumn = 2;

            foreach (DataGridItem item in grid.Items)
            {
                if (item.Cells[titleColumn].Text != "Manager")
                {
                    if (item.Visible == true)
                    {
                        item.Visible = false;
                    }
                    else
                    {
                        item.Visible = true;
                    }
                }

            }
            if (verbText == "Show Managers Only")
            {
                verbText = "Show All Employees";
            }
            else
            {
                verbText = "Show Managers Only";
            }
        }
        //</Snippet5>
    }
}
