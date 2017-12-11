using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;

namespace Trin_VstcoreHostControlsWord
{
    public partial class ThisDocument
    {
        //---------------------------------------------------------------------
        //<Snippet4>
        private Office.CommandBar commandBar;
        private Office.CommandBarButton boldText;
        private Office.CommandBarButton italicText;
        private Microsoft.Office.Tools.Word.Bookmark selectedBookmark;

        const int WordTrue = -1;
        const int WordFalse = 0;
        //</Snippet4>


        //---------------------------------------------------------------------
        //<Snippet6>
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            AddPopUp();
        }
        //</Snippet6>


        //---------------------------------------------------------------------
        private void StartUp()
        {
            //<Snippet7>
            this.bookmark1.BeforeRightClick +=
                new Microsoft.Office.Tools.Word.ClickEventHandler(ShowPopupMenu);

            this.bookmark2.BeforeRightClick +=
                new Microsoft.Office.Tools.Word.ClickEventHandler(ShowPopupMenu);
            //</Snippet7>
        }


        //---------------------------------------------------------------------
        //<Snippet5>
        private void AddPopUp()
        {
            commandBar = Application.CommandBars.Add("FormatText",
                Office.MsoBarPosition.msoBarPopup, missing, true);

            // Add a button and set the style, caption, icon and tag.
            boldText = (Office.CommandBarButton)commandBar.Controls.Add(
                1);

            boldText.Style = Office.MsoButtonStyle.msoButtonCaption;
            boldText.Caption = "Bold";
            boldText.FaceId = 113;
            boldText.Tag = "0";

            // Add a button and set the style, caption, icon and tag.
            italicText = (Office.CommandBarButton)commandBar.Controls.Add(
                1);

            italicText.Style = Office.MsoButtonStyle.msoButtonCaption;
            italicText.Caption = "Italic";
            italicText.FaceId = 114;
            italicText.Tag = "1";

            // Handle the click events with the ButtonClick procedure.
            boldText.Click +=
                new Microsoft.Office.Core._CommandBarButtonEvents_ClickEventHandler(ButtonClick);

            italicText.Click +=
                new Microsoft.Office.Core._CommandBarButtonEvents_ClickEventHandler(ButtonClick);

            ((Microsoft.Office.Interop.Word.Template)this.AttachedTemplate).Saved = true;
        }
        //</Snippet5>


        //---------------------------------------------------------------------
        //<Snippet8>
        private void ShowPopupMenu(object sender,
            Microsoft.Office.Tools.Word.ClickEventArgs e)
        {
            int startPosition = 0;

            // If bookmarks overlap, get bookmark closest to cursor.
            for (int i = 1; i <= e.Selection.Bookmarks.Count; i++)
            {
                if (e.Selection.Bookmarks[i].Start > startPosition)
                {
                    startPosition = e.Selection.Bookmarks[i].Start;
                }
            }

            // If closest bookmark is the sender, show the popup.
            if (((Microsoft.Office.Tools.Word.Bookmark)sender).Start == startPosition)
            {
                selectedBookmark = (Microsoft.Office.Tools.Word.Bookmark)sender;
                commandBar.ShowPopup();
                e.Cancel = true;
            }
        }
        //</Snippet8>


        //---------------------------------------------------------------------
        //<Snippet9>
        private void ButtonClick(Microsoft.Office.Core.CommandBarButton Ctrl,
            ref bool CancelDefault)
        {
            if (Ctrl.Caption == "Bold")
            {
                if (selectedBookmark.Bold == WordTrue)
                {
                    selectedBookmark.Bold = WordFalse;
                }
                else
                {
                    selectedBookmark.Bold = WordTrue;
                }
            }
            else if (Ctrl.Caption == "Italic")
            {
                if (selectedBookmark.Italic == WordTrue)
                {
                    selectedBookmark.Italic = WordFalse;
                }
                else
                {
                    selectedBookmark.Italic = WordTrue;
                }
            }
        }
        //</Snippet9>


        //---------------------------------------------------------------------
        private void Test1()
        {
            //<Snippet10>
            foreach (object targetControl in this.Controls)
            {
                Microsoft.Office.Tools.Word.Bookmark bookMark =
                    targetControl as Microsoft.Office.Tools.Word.Bookmark;

                if (bookMark != null)
                {
                    // Do some work with the bookmark here.
                }
            }
            //</Snippet10>


            //<Snippet2>
            this.SampleBookmark.Start = this.SampleBookmark.Start - 5;
            //</Snippet2>


            //<Snippet3>
            this.SampleBookmark.End = this.SampleBookmark.End + 5;
            //</Snippet3>


            //<Snippet1>
            Microsoft.Office.Tools.Word.Bookmark firstParagraph;
            firstParagraph = this.Controls.AddBookmark(this.Paragraphs[1].Range,
                "FirstParagraph");
            //</Snippet1>
        }


        //---------------------------------------------------------------------
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisDocument_Startup);
        }
    }
}
