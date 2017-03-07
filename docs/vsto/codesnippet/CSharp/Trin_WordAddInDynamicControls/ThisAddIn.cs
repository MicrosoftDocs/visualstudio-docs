using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Tools.Word.Extensions;

namespace Trin_WordAddInDynamicControls
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //<Snippet6>
            this.Application.DocumentOpen +=
                new Word.ApplicationEvents4_DocumentOpenEventHandler(Application_DocumentOpen);
            //</Snippet6>
            this.Application.DocumentOpen +=
                new Word.ApplicationEvents4_DocumentOpenEventHandler(Application_DocumentOpen2);
            this.Application.DocumentOpen +=
                new Word.ApplicationEvents4_DocumentOpenEventHandler(
                    Application_DocumentOpen_ClearActiveXWrappers);
            this.Application.DocumentBeforeClose +=
                new Word.ApplicationEvents4_DocumentBeforeCloseEventHandler(Application_DocumentBeforeClose);

            //AddRichTextControlAtSelection();
            //AddRichTextControlAtRange();
            //AddBookmarkAtRange();
            //AddWindowsFormsControl();
            //CreateDocumentHostItem();

            //Word.Document document1 = this.Application.ActiveDocument;
            //AddSmartTagToDocument(document1);

            //CreateDocument1();
            //CreateDocument2();
            //AddProtectedContentControls();
            //ProtectFirstParagraph();
            //ResizeBookmark();
        }

        //<Snippet1>
        private Microsoft.Office.Tools.Word.RichTextContentControl richTextControl1;

        private void AddRichTextControlAtSelection()
        {
            Word.Document currentDocument = this.Application.ActiveDocument;
            currentDocument.Paragraphs[1].Range.InsertParagraphBefore();
            currentDocument.Paragraphs[1].Range.Select();

            Document extendedDocument = Globals.Factory.GetVstoObject(currentDocument);

            richTextControl1 = extendedDocument.Controls.AddRichTextContentControl("richTextControl1");
            richTextControl1.PlaceholderText = "Enter your first name";
        }
        //</Snippet1>

        //<Snippet2>
        private Microsoft.Office.Tools.Word.RichTextContentControl richTextControl2;

        private void AddRichTextControlAtRange()
        {
            Word.Document currentDocument = this.Application.ActiveDocument;
            currentDocument.Paragraphs[1].Range.InsertParagraphBefore();

            Document extendedDocument = Globals.Factory.GetVstoObject(currentDocument);

            richTextControl2 = extendedDocument.Controls.AddRichTextContentControl(
                currentDocument.Paragraphs[1].Range, "richTextControl2");
            richTextControl2.PlaceholderText = "Enter your first name";
        }
        //</Snippet2>

        //<Snippet3>
        private System.Collections.Generic.List
            <Microsoft.Office.Tools.Word.RichTextContentControl> richTextControls;

        private void Application_DocumentOpen(Microsoft.Office.Interop.Word.Document Doc)
        {
            if (Doc.ContentControls.Count > 0)
            {
                Document extendedDocument = Globals.Factory.GetVstoObject(Doc);

                richTextControls = new System.Collections.Generic.List
                    <Microsoft.Office.Tools.Word.RichTextContentControl>();
                int count = 0;

                foreach (Word.ContentControl nativeControl in Doc.ContentControls)
                {
                    if (nativeControl.Type ==
                        Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlRichText)
                    {
                        count++;
                        Microsoft.Office.Tools.Word.RichTextContentControl tempControl =
                            extendedDocument.Controls.AddRichTextContentControl(nativeControl,
                            "VSTORichTextControl" + count.ToString());
                        richTextControls.Add(tempControl);
                    }
                }
            }
        }
        //</Snippet3>

        private void AddBookmarkAtRange()
        {
            //<Snippet4>
            Document extendedDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            Bookmark firstParagraph = extendedDocument.Controls.AddBookmark(
                extendedDocument.Paragraphs[1].Range, "FirstParagraph");
            //</Snippet4>
        }

        private void Application_DocumentOpen2(Microsoft.Office.Interop.Word.Document Doc)
        {
            //<Snippet5>
            if (this.Application.ActiveDocument.Bookmarks.Count > 0)
            {
                object index = 1;
                Word.Bookmark firstBookmark = this.Application.ActiveDocument.Bookmarks.get_Item(ref index);


                 Document extendedDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);

                Bookmark vstoBookmark = extendedDocument.Controls.AddBookmark(
                        firstBookmark, "VSTOBookmark");
            }
            //</Snippet5>
        }

        private void AddWindowsFormsControl()
        {
            //<Snippet7>
            Microsoft.Office.Tools.Word.Controls.Button salesButton;

            Document extendedDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            extendedDocument.Paragraphs[1].Range.InsertParagraphBefore();
            salesButton = extendedDocument.Controls.AddButton(
                extendedDocument.Paragraphs[1].Range, 75, 18, "salesButton");
            salesButton.Text = "Calculate Sales";
            //</Snippet7>
        }

         private void CreateDocumentHostItem()
        {
            //<Snippet8>
            if (Globals.ThisAddIn.Application.Documents.Count > 0)
            {
                Microsoft.Office.Interop.Word.Document nativeDocument =
                    Globals.ThisAddIn.Application.ActiveDocument;
                Microsoft.Office.Tools.Word.Document vstoDocument =
                    Globals.Factory.GetVstoObject(nativeDocument);
            }
            //</Snippet8>
        }

        //<Snippet9>
        private Microsoft.Office.Tools.Word.Action displayAddress;

        private void AddSmartTagToDocument(Word.Document document)
        {
            Microsoft.Office.Tools.Word.SmartTag smartTagDemo =
    
                Globals.Factory.CreateSmartTag(
                    "www.microsoft.com/Demo#DemoSmartTag",
                    "Demonstration Smart Tag");

            // Specify the terms to recognize.
            smartTagDemo.Terms.Add("term");
            smartTagDemo.Terms.Add("recognize");

              displayAddress = Globals.Factory.CreateAction("To be replaced");

            // Add the action to the smart tag.
            smartTagDemo.Actions = new Microsoft.Office.Tools.Word.Action[] { 
                displayAddress };

              Microsoft.Office.Tools.Word.Document vstoDocument =
                Globals.Factory.GetVstoObject(document);
            // Add the smart tag to the document
            vstoDocument.VstoSmartTags.Add(smartTagDemo);

            displayAddress.BeforeCaptionShow += new
                Microsoft.Office.Tools.Word.BeforeCaptionShowEventHandler(
                displayAddress_BeforeCaptionShow);

            displayAddress.Click += new
                Microsoft.Office.Tools.Word.ActionClickEventHandler(
                displayAddress_Click);
        }


        void displayAddress_BeforeCaptionShow(object sender,
            Microsoft.Office.Tools.Word.ActionEventArgs e)
        {
            Microsoft.Office.Tools.Word.Action clickedAction =
                sender as Microsoft.Office.Tools.Word.Action;

            if (clickedAction != null)
            {
                clickedAction.Caption = "Display the location of " +
                    e.Text;
            }
        }

        void displayAddress_Click(object sender,
            Microsoft.Office.Tools.Word.ActionEventArgs e)
        {
            int termStart = e.Range.Start;
            int termEnd = e.Range.End;
            System.Windows.Forms.MessageBox.Show("The recognized text '" + e.Text +
                "' begins at position " + termStart.ToString() +
                " and ends at position " + termEnd.ToString());
        }
        //</Snippet9>

        //<Snippet10>
        void Application_DocumentBeforeClose(Word.Document Doc, ref bool Cancel)
        {

            bool isExtended = Globals.Factory.HasVstoObject(Doc);

            if (isExtended)
            {
                Microsoft.Office.Tools.Word.Document vstoDocument = Globals.Factory.GetVstoObject(Doc);

                
                System.Collections.ArrayList controlsToRemove = 
                    new System.Collections.ArrayList();
                
                // Get all of the Windows Forms controls.
                foreach (object control in vstoDocument.Controls)
                {
                    if (control is System.Windows.Forms.Control)
                    {
                        controlsToRemove.Add(control);
                    }
                }

                // Remove all of the Windows Forms controls from the document.
                foreach (object control in controlsToRemove)
                {
                    vstoDocument.Controls.Remove(control);
                }
            }
        }
        //</Snippet10>

        //<Snippet11>
        private void Application_DocumentOpen_ClearActiveXWrappers(Word.Document Doc)
        {
            Microsoft.Office.Tools.Word.Document vstoDocument = Globals.Factory.GetVstoObject(Doc);

        }
        //</Snippet11>

        //<Snippet12>
        private Word.Document document1 = null;

        private void CreateDocument1()
        {
            document1 = this.Application.Documents.Add(ref missing,
                ref missing, ref missing, ref missing);
            this.Application.DocumentBeforeSave += 
                new Word.ApplicationEvents4_DocumentBeforeSaveEventHandler(
                Application_DocumentBeforeSave);
        }

        private void Application_DocumentBeforeSave(Word.Document Doc, 
            ref bool SaveAsUI, ref bool Cancel)
        {
            if (Type.ReferenceEquals(Doc, document1)) 
            {
                Cancel = true;
            }
        }
        //</Snippet12>

        //<Snippet13>
        private Word.Document document2 = null;
        private Microsoft.Office.Tools.Word.Document vstoDocument = null;

        private void CreateDocument2()
        {
            document2 = this.Application.Documents.Add(ref missing,
                ref missing, ref missing, ref missing);
            vstoDocument = Globals.Factory.GetVstoObject(document2);
            vstoDocument.BeforeSave += new SaveEventHandler(vstoDocument_BeforeSave);
        }

        private void vstoDocument_BeforeSave(object sender, SaveEventArgs e)
        {
            e.Cancel = true;
        }
        //</Snippet13>

        //<Snippet14>
        private Microsoft.Office.Tools.Word.RichTextContentControl deletableControl;
        private Microsoft.Office.Tools.Word.RichTextContentControl editableControl;

        private void AddProtectedContentControls()
        {
            Microsoft.Office.Tools.Word.Document vstoDocument = 
                Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            vstoDocument.Paragraphs[1].Range.InsertParagraphBefore();
            Word.Range range1 = vstoDocument.Paragraphs[1].Range;

            deletableControl = vstoDocument.Controls.AddRichTextContentControl(range1,
                "deletableControl");
            deletableControl.PlaceholderText = "You can delete this control, " +
                "but you cannot edit it";
            deletableControl.LockContents = true;

            range1.InsertParagraphAfter();
            Word.Range range2 = vstoDocument.Paragraphs[2].Range;

            editableControl = vstoDocument.Controls.AddRichTextContentControl(range2,
                "editableControl");
            editableControl.PlaceholderText = "You can edit this control, " +
                "but you cannot delete it.";
            editableControl.LockContentControl = true;
        }
        //</Snippet14>

        //<Snippet15>
        private Microsoft.Office.Tools.Word.GroupContentControl groupControl1;

        private void ProtectFirstParagraph()
        {
            Microsoft.Office.Tools.Word.Document vstoDocument =
                Globals.Factory.GetVstoObject(this.Application.ActiveDocument);

 
            vstoDocument.Paragraphs[1].Range.InsertParagraphBefore();

            Word.Range range1 = vstoDocument.Paragraphs[1].Range;
            range1.Text = "You cannot edit or change the formatting of text " +
                "in this sentence, because this sentence is in a GroupContentControl.";
            range1.Select();

            groupControl1 = vstoDocument.Controls.AddGroupContentControl("groupControl1");
        }
        //</Snippet15>

        private void ResizeBookmark()
        {
            //<Snippet16>
            Microsoft.Office.Tools.Word.Document vstoDocument =
                Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            vstoDocument.ActiveWindow.View.ShowBookmarks = true;
            vstoDocument.Paragraphs[1].Range.InsertParagraphBefore();

            Word.Range firstParagraph = vstoDocument.Paragraphs[1].Range;
            firstParagraph.Text = "123456789abcdefghijklmnopqrstuvwxyz";

            Microsoft.Office.Tools.Word.Bookmark sampleBookmark =
                vstoDocument.Controls.AddBookmark(firstParagraph, "bookmark1");
            sampleBookmark.Start = sampleBookmark.Start + 5;
            sampleBookmark.End = sampleBookmark.End - 5;
            //</Snippet16>
        }
        


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
