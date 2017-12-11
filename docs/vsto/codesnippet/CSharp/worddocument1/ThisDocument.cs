using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace WordDocument1
{
    public partial class ThisDocument
    {
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            this.Paragraphs[1].Range.Text = "The blue doll is very blue in the face. Which makes me BLuE too. But not red!";
            Test();
        }

        void Test()
        {
            //<Snippet1>
            Word.Range documentRange = this.Application.ActiveDocument.Content;
            documentRange.Find.ClearFormatting();
            documentRange.Find.Execute(FindText: "blue", ReplaceWith: "red", Replace: Word.WdReplace.wdReplaceAll);            
            //</Snippet1>

            //<Snippet2>
            documentRange.Find.ClearFormatting();
            documentRange.Find.Execute("blue", ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, "red", Word.WdReplace.wdReplaceAll, ref missing, ref missing,
                ref missing, ref missing);
            //</Snippet2>

#if DoCompileError
            //<Snippet3>
            Globals.ThisDocument.CheckSpelling(ignoreUppercase: true);
            //</Snippet3>
#endif

            //<Snippet4>
            object ignoreUppercase = true;
            Globals.ThisDocument.CheckSpelling(
                ref missing, ref ignoreUppercase, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            //</Snippet4>

            //<Snippet5>
            Globals.ThisDocument.InnerObject.CheckSpelling(IgnoreUppercase: true);
            //</Snippet5>
        }

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
