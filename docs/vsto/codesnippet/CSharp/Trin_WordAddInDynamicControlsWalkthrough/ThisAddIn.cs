using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Tools.Word.Extensions;

namespace Trin_WordAddInDynamicControlsWalkthrough
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //<Snippet5>
            this.Application.DocumentBeforeSave += 
                new Word.ApplicationEvents4_DocumentBeforeSaveEventHandler(
                Application_DocumentBeforeSave);
            //</Snippet5>
        }

        //<Snippet1>
        private Microsoft.Office.Tools.Word.Controls.Button button = null;
        private RichTextContentControl richTextControl = null;
        //</Snippet1>

        //<Snippet2>
        internal void ToggleButtonOnDocument()
        {
            Document vstoDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            string name = "MyButton";

            if (Globals.Ribbons.MyRibbon.addButtonCheckBox.Checked)
            {
                Word.Selection selection = this.Application.Selection;
                if (selection != null && selection.Range != null)
                {
                    button = vstoDocument.Controls.AddButton(
                        selection.Range, 100, 30, name);
                }
            }
            else
            {
                vstoDocument.Controls.Remove(name);
            }
        }
        //</Snippet2>

        //<Snippet3>
        internal void ToggleRichTextControlOnDocument()
        {

            Document vstoDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            string name = "MyRichTextBoxControl";

            if (Globals.Ribbons.MyRibbon.addRichTextCheckBox.Checked)
            {
                Word.Selection selection = this.Application.Selection;
                if (selection != null && selection.Range != null)
                {
                    richTextControl = vstoDocument.Controls.AddRichTextContentControl(
                        selection.Range, name);
                }
            }
            else
            {
                vstoDocument.Controls.Remove(name);
            }
        }
        //</Snippet3>

        //<Snippet4>
        private void Application_DocumentBeforeSave(Word.Document Doc, 
            ref bool SaveAsUI, ref bool Cancel)
        {
            bool isExtended = Globals.Factory.HasVstoObject(Doc);


            if (isExtended)
            {

                Microsoft.Office.Tools.Word.Document vstoDocument = Globals.Factory.GetVstoObject(Doc);

                if (vstoDocument.Controls.Contains(button))
                {
                    vstoDocument.Controls.Remove(button);
                    Globals.Ribbons.MyRibbon.addButtonCheckBox.Checked = false;
                }
            }
        }
        //</Snippet4>

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
