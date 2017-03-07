using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;

namespace Trin_ContentControlReference
{
    public partial class ThisDocument
    {

        // PlainTextContentControl constructor #1: create a PlainTextContentControl at the current selection.
        //<Snippet600>
        private Microsoft.Office.Tools.Word.PlainTextContentControl textControl1;

        private void AddTextControlAtSelection()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            this.Paragraphs[1].Range.Select();

            textControl1 = this.Controls.AddPlainTextContentControl("textControl1");
            textControl1.PlaceholderText = "Enter your first name";
        }
        //</Snippet600>

        // PlainTextContentControl constructor #2: create a PlainTextContentControl at a specified range.
        //<Snippet601>
        private Microsoft.Office.Tools.Word.PlainTextContentControl textControl2;

        private void AddTextControlAtRange()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();

            textControl2 = this.Controls.AddPlainTextContentControl(this.Paragraphs[1].Range,
                "textControl2");
            textControl2.PlaceholderText = "Enter your first name";
        }
        //</Snippet601>

        // PlainTextContentControl constructor #3: create a PlainTextContentControl for every
        // native plain text control in the document.
        //<Snippet602>
        private System.Collections.Generic.List<Microsoft.Office.Tools.Word.PlainTextContentControl> plainTextControls;

        private void CreateTextControlsFromNativeControls()
        {
            if (this.ContentControls.Count <= 0)
                return;

            plainTextControls = new System.Collections.Generic.List
                <Microsoft.Office.Tools.Word.PlainTextContentControl>();
            int count = 0;

            foreach (Word.ContentControl nativeControl in this.ContentControls)
            {
                if (nativeControl.Type == Word.WdContentControlType.wdContentControlText)
                {
                    count++;
                    Microsoft.Office.Tools.Word.PlainTextContentControl tempControl =
                        this.Controls.AddPlainTextContentControl(nativeControl,
                        "VSTOPlainTextContentControl" + count.ToString());
                    plainTextControls.Add(tempControl);
                }
            }
        }
        //</Snippet602>

        // PlainTextContentControl constructor #3: create a PlainTextContentControl for every
        // native plain text control that is added to the document at run time.
        //<Snippet603>
        void ThisDocument_PlainTextContentControlAfterAdd(Word.ContentControl NewContentControl, bool InUndoRedo)
        {
            if (NewContentControl.Type == Word.WdContentControlType.wdContentControlText)
            {
                this.Controls.AddPlainTextContentControl(NewContentControl,
                    "PlainTextControl" + NewContentControl.ID);
            }
        }
        //</Snippet603>

    }
}
