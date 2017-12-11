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
        //<Snippet100>
        private Microsoft.Office.Tools.Word.ComboBoxContentControl comboBoxControl1;

        private void AddComboBoxControlAtSelection()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            this.Paragraphs[1].Range.Select();

            comboBoxControl1 = this.Controls.AddComboBoxContentControl("comboBoxControl1");
            comboBoxControl1.DropDownListEntries.Add("Red", "Red", 0);
            comboBoxControl1.DropDownListEntries.Add("Green", "Green", 1);
            comboBoxControl1.DropDownListEntries.Add("Blue", "Blue", 2);
            comboBoxControl1.PlaceholderText = "Choose a color, or enter your own";
        }
        //</Snippet100>

        // ComboBoxContentControl constructor #2: create a ComboBoxContentControl at a specified range.
        //<Snippet101>
        private Microsoft.Office.Tools.Word.ComboBoxContentControl comboBoxControl2;

        private void AddComboBoxControlAtRange()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();

            comboBoxControl2 = this.Controls.AddComboBoxContentControl(this.Paragraphs[1].Range,
                "comboBoxControl2");
            comboBoxControl2.DropDownListEntries.Add("Red", "Red", 0);
            comboBoxControl2.DropDownListEntries.Add("Green", "Green", 1);
            comboBoxControl2.DropDownListEntries.Add("Blue", "Blue", 2);
            comboBoxControl2.PlaceholderText = "Choose a color, or enter your own";
        }
        //</Snippet101>

        // ComboBoxContentControl constructor #3: create a ComboBoxContentControl for every
        // native combobox control in the document.
        //<Snippet102>
        private System.Collections.Generic.List
            <Microsoft.Office.Tools.Word.ComboBoxContentControl> comboBoxControls;

        private void CreateComboBoxControlsFromNativeControls()
        {
            if (this.ContentControls.Count <= 0)
                return;

            comboBoxControls = new System.Collections.Generic.List
                <Microsoft.Office.Tools.Word.ComboBoxContentControl>();
            int count = 0;

            foreach (Word.ContentControl nativeControl in this.ContentControls)
            {
                if (nativeControl.Type == Word.WdContentControlType.wdContentControlComboBox)
                {
                    count++;
                    Microsoft.Office.Tools.Word.ComboBoxContentControl tempControl =
                        this.Controls.AddComboBoxContentControl(nativeControl,
                        "VSTOComboBoxContentControl" + count.ToString());
                    comboBoxControls.Add(tempControl);
                }
            }
        }
        //</Snippet102>

        // ComboBoxContentControl constructor #3: create a ComboBoxContentControl for every
        // native combobox control added to the document.
        //<Snippet103>
        void ThisDocument_ComboBoxContentControlAfterAdd(Word.ContentControl NewContentControl, bool InUndoRedo)
        {
            if (NewContentControl.Type == Word.WdContentControlType.wdContentControlComboBox)
            {
                this.Controls.AddComboBoxContentControl(NewContentControl,
                    "ComboBoxControl" + NewContentControl.ID);
            }
        }
        //</Snippet103>
    }
}
