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

        // PictureContentControl constructor #1: create a PictureContentControl at the current selection.
        // Note: This code snippet assumes that MyDocuments\picture.bmp exists.
        //<Snippet500>
        private Microsoft.Office.Tools.Word.PictureContentControl pictureControl1;
        private System.Drawing.Bitmap bitmap1;

        private void AddPictureControlAtSelection()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            this.Paragraphs[1].Range.Select();

            pictureControl1 = this.Controls.AddPictureContentControl("pictureControl1");

            string imagePath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + "\\picture.bmp";
            bitmap1 = new System.Drawing.Bitmap(imagePath, true);
            pictureControl1.Image = bitmap1;
        }
        //</Snippet500>

        // PictureContentControl constructor #2: create a PictureContentControl at a specified range.
        //<Snippet501>
        private Microsoft.Office.Tools.Word.PictureContentControl pictureControl2;
        private System.Drawing.Bitmap bitmap2;

        private void AddPictureControlAtRange()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            pictureControl2 = this.Controls.AddPictureContentControl(
                this.Paragraphs[1].Range, "pictureControl2");

            string imagePath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + "\\picture.bmp";
            bitmap2 = new System.Drawing.Bitmap(imagePath, true);
            pictureControl2.Image = bitmap2;
        }
        //</Snippet501>

        // PictureContentControl constructor #3: create a PictureContentControl for every
        // native picture control in the document.
        //<Snippet502>
        private System.Collections.Generic.List
           <Microsoft.Office.Tools.Word.PictureContentControl> pictureControls;

        private void CreatePictureControlFromNativeControl()
        {
            if (this.ContentControls.Count <= 0)
                return;

            pictureControls = new System.Collections.Generic.List
                <Microsoft.Office.Tools.Word.PictureContentControl>();
            int count = 0;

            foreach (Word.ContentControl nativeControl in this.ContentControls)
            {
                if (nativeControl.Type == Word.WdContentControlType.wdContentControlPicture)
                {
                    count++;
                    Microsoft.Office.Tools.Word.PictureContentControl tempControl =
                        this.Controls.AddPictureContentControl(nativeControl,
                        "VSTOPictureContentControl" + count.ToString());
                    pictureControls.Add(tempControl);
                }
            }
        }
        //</Snippet502>

        // PictureContentControl constructor #3: create a PictureContentControl for every
        // native picture control added to the document at run time.
        //<Snippet503>
        void ThisDocument_PictureContentControlAfterAdd(Word.ContentControl NewContentControl, bool InUndoRedo)
        {
            if (NewContentControl.Type == Word.WdContentControlType.wdContentControlPicture)
            {
                this.Controls.AddPictureContentControl(NewContentControl,
                    "PictureControl" + NewContentControl.ID);
            }
        }
        //</Snippet503>
    }
}
