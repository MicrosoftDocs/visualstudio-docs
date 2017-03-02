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

        // RichTextContentControl constructor #1: create a RichTextContentControl at the current selection.
        //<Snippet700>
        private Microsoft.Office.Tools.Word.RichTextContentControl richTextControl1;

        private void AddRichTextControlAtSelection()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            this.Paragraphs[1].Range.Select();

            richTextControl1 = this.Controls.AddRichTextContentControl("richTextControl1");
            richTextControl1.PlaceholderText = "Enter your first name";
        }
        //</Snippet700>

        // RichTextContentControl constructor #2: create a RichTextContentControl at a specified range.
        //<Snippet701>
        private Microsoft.Office.Tools.Word.RichTextContentControl richTextControl2;

        private void AddRichTextControlAtRange()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();

            richTextControl2 = this.Controls.AddRichTextContentControl(this.Paragraphs[1].Range,
                "richTextControl2");
            richTextControl2.PlaceholderText = "Enter your first name";
        }
        //</Snippet701>

        // RichTextContentControl constructor #3: create a RichTextContentControl for every
        // native rich text control in the document.
        //<Snippet702>
        private System.Collections.Generic.List
            <Microsoft.Office.Tools.Word.RichTextContentControl> richTextControls;

        private void CreateRichTextControlsFromNativeControls()
        {
            if (this.ContentControls.Count <= 0)
                return;

            richTextControls = new System.Collections.Generic.List
                <Microsoft.Office.Tools.Word.RichTextContentControl>();
            int count = 0;

            foreach (Word.ContentControl nativeControl in this.ContentControls)
            {
                if (nativeControl.Type ==
                    Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlRichText)
                {
                    count++;
                    Microsoft.Office.Tools.Word.RichTextContentControl tempControl =
                        this.Controls.AddRichTextContentControl(nativeControl,
                        "VSTORichTextControl" + count.ToString());
                    richTextControls.Add(tempControl);
                }
            }
        }
        //</Snippet702>


        // RichTextContentControl constructor #3: create a RichTextContentControl for every
        // native rich text control added to the document.
        //<Snippet703>
        void ThisDocument_RichTextContentControlAfterAdd(Word.ContentControl NewContentControl, bool InUndoRedo)
        {
            if (NewContentControl.Type == Word.WdContentControlType.wdContentControlRichText)
            {
                this.Controls.AddRichTextContentControl(NewContentControl,
                    "RichTextControl" + NewContentControl.ID);
            }
        }
        //</Snippet703>
    }
}
