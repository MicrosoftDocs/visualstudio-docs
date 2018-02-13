using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace FirstDocumentCustomization
{
    public partial class ThisDocument
    {
        //<Snippet1>
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            this.Paragraphs[1].Range.InsertParagraphAfter();
            this.Paragraphs[2].Range.Text = "This text was added by using code.";
        }
        //</Snippet1>

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisDocument_Startup);
            this.Shutdown += new System.EventHandler(ThisDocument_Shutdown);
        }

        #endregion
    }
}
