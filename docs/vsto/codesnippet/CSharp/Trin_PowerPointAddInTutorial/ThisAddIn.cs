using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace Trin_PowerPointAddInTutorial
{
    public partial class ThisAddIn
    {
        
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //<Snippet2>
            this.Application.PresentationNewSlide += 
                new PowerPoint.EApplication_PresentationNewSlideEventHandler(
                Application_PresentationNewSlide);
            //</Snippet2>
        }

        //<Snippet1>
        void Application_PresentationNewSlide(PowerPoint.Slide Sld)
        {
            PowerPoint.Shape textBox = Sld.Shapes.AddTextbox(
                Office.MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 500, 50);
            textBox.TextFrame.TextRange.InsertAfter("This text was added by using code.");
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
