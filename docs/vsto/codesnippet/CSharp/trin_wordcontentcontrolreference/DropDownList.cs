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

        // DropDownListContentControl constructor #1: create a DropDownListContentControl 
        // at the current selection.
        //<Snippet300>
        private Microsoft.Office.Tools.Word.DropDownListContentControl dropDownListControl1;

        private void AddDropDownListControlAtSelection()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            this.Paragraphs[1].Range.Select();

            dropDownListControl1 = this.Controls.AddDropDownListContentControl("dropDownListControl1");
            dropDownListControl1.DropDownListEntries.Add("Monday", "Monday", 0);
            dropDownListControl1.DropDownListEntries.Add("Tuesday", "Tuesday", 1);
            dropDownListControl1.DropDownListEntries.Add("Wednesday", "Wednesday", 2);
            dropDownListControl1.PlaceholderText = "Choose a day";
        }
        //</Snippet300>

        // DropDownListContentControl constructor #2: create a DropDownListContentControl at a specified range.
        //<Snippet301>
        private Microsoft.Office.Tools.Word.DropDownListContentControl dropDownListControl2;

        private void AddDropDownListControlAtRange()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();

            dropDownListControl2 = this.Controls.AddDropDownListContentControl(this.Paragraphs[1].Range,
                "dropDownListControl2");
            dropDownListControl2.DropDownListEntries.Add("Monday", "Monday", 0);
            dropDownListControl2.DropDownListEntries.Add("Tuesday", "Tuesday", 1);
            dropDownListControl2.DropDownListEntries.Add("Wednesday", "Wednesday", 2);
            dropDownListControl2.PlaceholderText = "Choose a day";
        }
        //</Snippet301>

        // DropDownListContentControl constructor #3: create a DropDownListContentControl for every
        // native drop down list control in the document.
        //<Snippet302>
        private System.Collections.Generic.List
            <Microsoft.Office.Tools.Word.DropDownListContentControl> dropDownControls;

        private void CreateDropDownListControlsFromNativeControls()
        {
            if (this.ContentControls.Count <= 0)
                return;

            dropDownControls = new System.Collections.Generic.List
                <Microsoft.Office.Tools.Word.DropDownListContentControl>();
            int count = 0;

            foreach (Word.ContentControl nativeControl in this.ContentControls)
            {
                if (nativeControl.Type == Word.WdContentControlType.wdContentControlDropdownList)
                {
                    count++;
                    Microsoft.Office.Tools.Word.DropDownListContentControl tempControl =
                        this.Controls.AddDropDownListContentControl(nativeControl,
                        "VSTODropDownListContentControl" + count.ToString());
                    dropDownControls.Add(tempControl);
                }
            }
        }
        //</Snippet302>


        // DropDownListContentControl constructor #3: create a DropDownListContentControl for every
        // native drop down list control added to the document.
        //<Snippet303>
        void ThisDocument_DropDownListContentControlAfterAdd(Word.ContentControl NewContentControl, bool InUndoRedo)
        {
            if (NewContentControl.Type == Word.WdContentControlType.wdContentControlDropdownList)
            {
                this.Controls.AddDropDownListContentControl(NewContentControl,
                    "DropDownListControl" + NewContentControl.ID);
            }
        }
        //</Snippet303>
    }
}
