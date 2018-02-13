using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;

namespace Trin_ContentControlHowToProtect
{
    public partial class ThisDocument
    {
        //<Snippet1>
        private Microsoft.Office.Tools.Word.GroupContentControl groupControl1;

        private void ProtectFirstParagraph()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            Word.Range range1 = this.Paragraphs[1].Range;

            range1.Text = "You cannot edit or change the formatting of text " +
                "in this sentence, because this sentence is in a GroupContentControl.";
            range1.Select();
            groupControl1 = this.Controls.AddGroupContentControl("groupControl1");
        }
        //</Snippet1>

        //<Snippet2>
        private Microsoft.Office.Tools.Word.RichTextContentControl deletableControl;
        private Microsoft.Office.Tools.Word.RichTextContentControl editableControl;

        private void AddProtectedContentControls()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            Word.Range range1 = this.Paragraphs[1].Range;

            deletableControl = this.Controls.AddRichTextContentControl(range1,
                "deletableControl");
            deletableControl.PlaceholderText = "You can delete this control, " +
                "but you cannot edit it";
            deletableControl.LockContents = true;

            range1.InsertParagraphAfter();
            Word.Range range2 = this.Paragraphs[2].Range;

            editableControl = this.Controls.AddRichTextContentControl(range2,
                "editableControl");
            editableControl.PlaceholderText = "You can edit this control, " +
                "but you cannot delete it";
            editableControl.LockContentControl = true;
        }
        //</Snippet2>


        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            try
            {
                //ProtectFirstParagraph();
                //AddProtectedContentControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
