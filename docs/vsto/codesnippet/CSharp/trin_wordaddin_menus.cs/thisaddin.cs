using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace CS
{
    public partial class ThisAddIn
    {
        //<Snippet3>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.DocumentOpen +=
    new Word.ApplicationEvents4_DocumentOpenEventHandler(WorkWithDocument);

            ((Word.ApplicationEvents4_Event)this.Application).NewDocument +=
                new Word.ApplicationEvents4_NewDocumentEventHandler(WorkWithDocument);  
        }
        
        private void WorkWithDocument(Microsoft.Office.Interop.Word.Document Doc)
        {
            try
            {
                Word.Range rng = Doc.Range(0, 0);
                rng.Text = "New Text";
                rng.Select();
            }
            catch (Exception ex)
            {
                // Handle exception if for some reason the document is not available.
            }
        }
        //</Snippet3>


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }
        //<Snippet1>
        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
              return new Ribbon1();
        }
        //</Snippet1>



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
