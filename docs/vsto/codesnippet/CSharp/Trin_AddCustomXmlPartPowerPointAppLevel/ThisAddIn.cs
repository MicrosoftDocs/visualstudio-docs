using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace Trin_AddCustomXmlPartPowerPointAppLevel
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.AfterPresentationOpen += 
                new Microsoft.Office.Interop.PowerPoint.EApplication_AfterPresentationOpenEventHandler(
                    Application_AfterPresentationOpen);
        }

        void Application_AfterPresentationOpen(Microsoft.Office.Interop.PowerPoint.Presentation Pres)
        {
            AddCustomXmlPartToPresentation(Pres);
        }

        //<Snippet1>
        private void AddCustomXmlPartToPresentation(PowerPoint.Presentation presentation)
        {
            string xmlString =
                "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
                "<employees xmlns=\"http://schemas.microsoft.com/vsto/samples\">" +
                    "<employee>" +
                        "<name>Karina Leal</name>" +
                        "<hireDate>1999-04-01</hireDate>" +
                        "<title>Manager</title>" +
                    "</employee>" +
                "</employees>";

            Office.CustomXMLPart employeeXMLPart = 
                presentation.CustomXMLParts.Add(xmlString, missing);
        }
        //</Snippet1>

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
