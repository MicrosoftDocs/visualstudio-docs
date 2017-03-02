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
        private void AddCheckBoxControlAtSelection()
        {
            //<Snippet800>
            this.Paragraphs[1].Range.InsertParagraphBefore();
            this.Paragraphs[1].Range.Select();
            Microsoft.Office.Tools.Word.ContentControl checkBoxControl1 = 
                this.Controls.AddContentControl("checkBoxControl1", Word.WdContentControlType.wdContentControlCheckBox);
            
            checkBoxControl1.Checked = true;

            //</Snippet800>
        }
    }
}

