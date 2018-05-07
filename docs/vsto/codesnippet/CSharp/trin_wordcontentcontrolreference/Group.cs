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
        // GroupContentControl constructor #1: create a GroupContentControl at the current selection.
        //<Snippet400>
        private Microsoft.Office.Tools.Word.GroupContentControl groupControl1;

        private void AddGroupControlAtSelection()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            Word.Range range1 = this.Paragraphs[1].Range;
            range1.Text = "You cannot edit or change the formatting of text " +
                "in this paragraph, because this paragraph is in a GroupContentControl.";
            range1.Select();

            groupControl1 = this.Controls.AddGroupContentControl("groupControl1");
        }
        //</Snippet400>

        // GroupContentControl constructor #2: create a GroupContentControl at a specified range.
        //<Snippet401>
        private Microsoft.Office.Tools.Word.GroupContentControl groupControl2;

        private void AddGroupControlAtRange()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            Word.Range range1 = this.Paragraphs[1].Range;
            range1.Text = "You cannot edit or change the formatting of text " +
                "in this paragraph, because this paragraph is in a GroupContentControl.";
            range1.Select();

            groupControl2 = this.Controls.AddGroupContentControl(range1, "groupControl2");
        }
        //</Snippet401>

        // GroupContentControl constructor #3: create GroupContentControl objects for every
        // native group control in the document.
        //<Snippet402>
        private System.Collections.Generic.List
            <Microsoft.Office.Tools.Word.GroupContentControl> groupControls;

        private void CreateGroupControlsFromNativeControls()
        {
            if (this.ContentControls.Count <= 0)
                return;

            groupControls = new System.Collections.Generic.List
                <Microsoft.Office.Tools.Word.GroupContentControl>();
            int count = 0;

            foreach (Word.ContentControl nativeControl in this.ContentControls)
            {
                if (nativeControl.Type == Word.WdContentControlType.wdContentControlGroup)
                {
                    count++;
                    Microsoft.Office.Tools.Word.GroupContentControl tempControl =
                        this.Controls.AddGroupContentControl(nativeControl,
                        "VSTOGroupControl" + count.ToString());
                    groupControls.Add(tempControl);
                }
            }
        }
        //</Snippet402>

        // GroupContentControl constructor #3: create GroupContentControl objects for every
        // native group controls added to the document.
        //<Snippet403>
        void ThisDocument_GroupContentControlAfterAdd(Word.ContentControl NewContentControl, bool InUndoRedo)
        {
            if (NewContentControl.Type == Word.WdContentControlType.wdContentControlGroup)
            {
                this.Controls.AddGroupContentControl(NewContentControl,
                    "GroupControl" + NewContentControl.ID);
            }
        }
        //</Snippet403>

    }
}
