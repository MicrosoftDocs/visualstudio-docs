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

        // DatePickerContentControl constructor #1: create a DatePickerContentControl at the current selection.
        //<Snippet200>
        private Microsoft.Office.Tools.Word.DatePickerContentControl datePickerControl1;

        private void AddDatePickerControlAtSelection()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            this.Paragraphs[1].Range.Select();

            datePickerControl1 = this.Controls.AddDatePickerContentControl("datePickerControl1");
            datePickerControl1.DateDisplayFormat = "MMMM d, yyyy";
            datePickerControl1.PlaceholderText = "Choose a date";
        }
        //</Snippet200>

        // DatePickerContentControl constructor #2: create a DatePickerContentControl at a specified range.
        //<Snippet201>
        private Microsoft.Office.Tools.Word.DatePickerContentControl datePickerControl2;

        private void AddDatePickerControlAtRange()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();

            datePickerControl2 = this.Controls.AddDatePickerContentControl(this.Paragraphs[1].Range,
                 "datePickerControl2");
            datePickerControl2.DateDisplayFormat = "MMMM d, yyyy";
            datePickerControl2.PlaceholderText = "Choose a date";
        }
        //</Snippet201>

        // DatePickerContentControl constructor #3: create a DatePickerContentControl for every
        // native date control in the document.
        //<Snippet202>
        private System.Collections.Generic.List
            <Microsoft.Office.Tools.Word.DatePickerContentControl> datePickerControls;

        private void CreateDatePickerControlsFromNativeControls()
        {
            datePickerControls = new System.Collections.Generic.List
                <Microsoft.Office.Tools.Word.DatePickerContentControl>();
            int count = 0;

            foreach (Word.ContentControl nativeControl in this.ContentControls)
            {
                if (nativeControl.Type == Word.WdContentControlType.wdContentControlDate)
                {
                    count++;
                    Microsoft.Office.Tools.Word.DatePickerContentControl tempControl =
                        this.Controls.AddDatePickerContentControl(nativeControl,
                        "VSTODatePickerContentControl" + count.ToString());
                    datePickerControls.Add(tempControl);
                }
            }
        }
        //</Snippet202>

        // DatePickerContentControl constructor #3: create a DatePickerContentControl for every
        // native date control added to the document.
        //<Snippet203>
        void ThisDocument_DatePickerContentControlAfterAdd(Word.ContentControl NewContentControl, bool InUndoRedo)
        {
            if (NewContentControl.Type == Word.WdContentControlType.wdContentControlDate)
            {
                this.Controls.AddDatePickerContentControl(NewContentControl,
                    "DatePickerControl" + NewContentControl.ID);
            }
        }
        //</Snippet203>

    }
}
