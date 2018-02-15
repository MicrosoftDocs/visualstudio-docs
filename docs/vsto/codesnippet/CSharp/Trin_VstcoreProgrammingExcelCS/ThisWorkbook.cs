using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreProgrammingExcelCS
{
    public partial class ThisWorkbook
    {
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            //<Snippet5>
            ReportPicker reportPicker = new ReportPicker();
            reportPicker.ShowDialog();
            //</Snippet5>
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }


        //<Snippet6>
        void TestProperties()
        {
            Microsoft.Office.Core.DocumentProperties properties;
            properties = (Office.DocumentProperties)this.CustomDocumentProperties;

            if (ReadDocumentProperty("Project Name") != null)
            {
                properties["Project Name"].Delete();
            }

            properties.Add("Project Name", false,
                Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString,
                "White Papers");
        }

        private string ReadDocumentProperty(string propertyName)
        {
            Office.DocumentProperties properties;
            properties = (Office.DocumentProperties)this.CustomDocumentProperties;

            foreach (Office.DocumentProperty prop in properties)
            {
                if (prop.Name == propertyName)
                {
                    return prop.Value.ToString();
                }
            }
            return null;
        }
        //</Snippet6>


        //---------------------------------------------------------------------
        void TestPropertyRevision()
        {
            //<Snippet7>
            Microsoft.Office.Core.DocumentProperties properties;

            properties = (Microsoft.Office.Core.DocumentProperties)
                Globals.ThisWorkbook.BuiltinDocumentProperties; 

            Microsoft.Office.Core.DocumentProperty prop;
            prop = properties["Revision Number"]; 
            //</Snippet7>

            
            //<Snippet8>
            if (prop.Value == null)
            {
                prop.Value = 1;
            }
            else
            {
                int revision;
                if (int.TryParse((string)prop.Value, out revision))
                {
                    prop.Value = revision + 1;
                    MessageBox.Show("Revision Number = " + revision);
                }
                else
                {
                    MessageBox.Show("Revision Number = invalid value");
                }
            }
            //</Snippet8>
        }
        
        
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown+=new System.EventHandler(ThisWorkbook_Shutdown);
        }
    }
}
