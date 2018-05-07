//using System;
//using System.Data;
//using System.Drawing;
//using Microsoft.VisualStudio.Tools.Applications.Runtime;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;

namespace Trin_VstcoreWordAutomationCS
{
    public partial class ThisDocument
    {
        //---------------------------------------------------------------------
        //<Snippet121>
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }
        //</Snippet121>

        private void TestDynamicFileOpenDialog()
        {
            //<Snippet122>
            dynamic dialog = Application.Dialogs[Word.WdWordDialog.wdDialogFileOpen];
            dialog.Name = "Testing";
            dialog.Show();
            MessageBox.Show(dialog.Name);
            //</Snippet122>
        }

        private void PageSetupDialogHiddenNET4() 
        {
            //<Snippet123>
            dynamic dialog = Application.Dialogs[Word.WdWordDialog.wdDialogFilePageSetup];
            dialog.PageWidth = "3.3\"";
            dialog.PageHeight = "6\"";
            dialog.TopMargin = "0.71\"";
            dialog.BottomMargin = "0.81\"";
            dialog.LeftMargin = "0.66\"";
            dialog.RightMargin = "0.66\"";
            dialog.HeaderDistance = "0.28\"";
            dialog.Orientation = "0";
            dialog.DifferentFirstPage = "0";
            dialog.FirstPage = "0";
            dialog.OtherPages = "0";

            // Apply these settings only to the current selection with this line of code:
            dialog.ApplyPropsTo = "3";

            // Apply the settings.
            dialog.Execute(); 
            //</Snippet123>
        }


        //---------------------------------------------------------------------
        //<Snippet22>
        private void RangeSelect() 
        { 
            //<Snippet23>
            Word.Range rng; 
            //</Snippet23>

            //<Snippet24>
            if (this.Sentences.Count >= 2) 
            {
                object startLocation = this.Sentences[2].Start; 
                object endLocation = this.Sentences[2].End; 

                // Supply a Start and End value for the Range. 
                rng = this.Range(ref startLocation, ref endLocation); 

                // Select the Range.
                rng.Select();
            }
            //</Snippet24>
            else 
            {
                return; 
            }
        } 
        //</Snippet22>


        //---------------------------------------------------------------------
        //<Snippet26>
        private void ReplaceParagraphText() 
        { 
            //<Snippet27>
            Word.Range firstRange = this.Paragraphs[1].Range; 
            Word.Range secondRange = this.Paragraphs[2].Range; 

            string firstString = firstRange.Text; 
            string secondString = secondRange.Text; 
            //</Snippet27>

            //<Snippet28>
            firstRange.Text = secondString; 
            secondRange.Text = firstString; 
            //</Snippet28>

            //<Snippet29>
            firstRange.Select(); 
            MessageBox.Show(firstRange.Text); 
            secondRange.Select(); 
            MessageBox.Show(secondRange.Text); 
            //</Snippet29>

            //<Snippet30>
            object charUnit = Word.WdUnits.wdCharacter;
            object move = -1;  // move left 1

            firstRange.MoveEnd(ref charUnit, ref move);
            //</Snippet30>

            //<Snippet31>
            firstRange.Text = "New content for paragraph 1.";
            //</Snippet31>
            //<Snippet32>
            secondRange.Text = "New content for paragraph 2.";
            //</Snippet32>

            //<Snippet33>
            firstRange.Select(); 
            MessageBox.Show(firstRange.Text); 
            secondRange.Select(); 
            MessageBox.Show(secondRange.Text); 
            //</Snippet33>

            //<Snippet34>
            move = 1;  // move right 1
            firstRange.MoveEnd(ref charUnit, ref move); 
            //</Snippet34>

            //<Snippet35>
            secondRange.Delete(ref missing, ref missing); 
            //</Snippet35>

            //<Snippet36>
            firstRange.Text = firstString; 
            //</Snippet36>

            //<Snippet37>
            firstRange.InsertAfter(secondString); 
            firstRange.Select(); 
            //</Snippet37>
        }
        //</Snippet26>


        //---------------------------------------------------------------------
        //<Snippet56>
        private void SelectionInsertText() 
        { 
            //<Snippet57>
            Word.Selection currentSelection = Application.Selection; 
            //</Snippet57>

            // Store the user's current Overtype selection
            bool userOvertype = Application.Options.Overtype;

            // Make sure Overtype is turned off.
            //<Snippet58>
            if (Application.Options.Overtype) 
            { 
                Application.Options.Overtype = false; 
            } 
            //</Snippet58>

            //<Snippet59>
            // Test to see if selection is an insertion point.
            if (currentSelection.Type == Word.WdSelectionType.wdSelectionIP) 
            { 
                currentSelection.TypeText("Inserting at insertion point. ");
                currentSelection.TypeParagraph(); 
            } 
            //</Snippet59>
            //<Snippet60>
            else 
                if (currentSelection.Type == Word.WdSelectionType.wdSelectionNormal)
                { 
                    // Move to start of selection.
                    if (Application.Options.ReplaceSelection)
                    { 
                        object direction = Word.WdCollapseDirection.wdCollapseStart;
                        currentSelection.Collapse(ref direction);
                    }
                    currentSelection.TypeText("Inserting before a text block. ");
                    currentSelection.TypeParagraph();
                }
            //</Snippet60>
                //<Snippet61>
                else
                {
                    // Do nothing.
                }
                //</Snippet61>

            // Restore the user's Overtype selection
            Application.Options.Overtype = userOvertype;
        }
        //</Snippet56>


        //---------------------------------------------------------------------
        //<Snippet62>
        private void RangeFormat() 
        { 
            // Set the Range to the first paragraph. 
            Word.Range rng = this.Paragraphs[1].Range;

            // Change the formatting. To change the font size for a right-to-left language, 
            // such as Arabic or Hebrew, use the Font.SizeBi property instead of Font.Size.
            rng.Font.Size = 14; 
            rng.Font.Name = "Arial"; 
            rng.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            rng.Select(); 
            MessageBox.Show("Formatted Range"); 

            // Undo the three previous actions. 
            object numTimes3 = 3; 
            this.Undo(ref numTimes3); 

            rng.Select(); 
            MessageBox.Show("Undo 3 actions"); 

            // Apply the Normal Indent style. 
            object indentStyle = "Normal Indent"; 
            rng.set_Style(ref indentStyle); 

            rng.Select(); 
            MessageBox.Show("Normal Indent style applied"); 

            // Undo a single action. 
            object numTimes1 = 1; 
            this.Undo(ref numTimes1); 

            rng.Select(); 
            MessageBox.Show("Undo 1 action"); 
        }
        //</Snippet62>


        //---------------------------------------------------------------------
        //<Snippet63>
        static void BookMarkReplace(
            ref Microsoft.Office.Tools.Word.Bookmark bookmark, 
            string newText)
        {
        //</Snippet63>
        //<Snippet64>
            bookmark.Text = newText;
        }
        //</Snippet64>


        //---------------------------------------------------------------------
        //<Snippet65>
        internal void BookMarkReplaceNative(
            Word.Bookmark bookmark, 
            string newText)
        {
        //</Snippet65>
        //<Snippet66>
            object rng = bookmark.Range;
            string bookmarkName = bookmark.Name;
        
            bookmark.Range.Text = newText;

            this.Bookmarks.Add(bookmarkName, ref rng); 
        }
        //</Snippet66>


        //---------------------------------------------------------------------
        //<Snippet67>
        private void SelectionFind() 
        { 
            //<Snippet68>
            object findText = "find me";
            //</Snippet68>

            //<Snippet69>
            Application.Selection.Find.ClearFormatting();
            //</Snippet69>

            //<Snippet70>
            if (Application.Selection.Find.Execute(ref findText,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, 
                ref missing, ref missing)) 
            { 
                MessageBox.Show("Text found.");
            } 
            else
            { 
                MessageBox.Show("The text could not be located.");
            } 
            //</Snippet70>
        }
        //</Snippet67>


        //---------------------------------------------------------------------
        //<Snippet71>
        private void RangeFind() 
        { 
            object findText = "find me";

            //<Snippet72>
            Word.Range rng = this.Paragraphs[2].Range; 
            //</Snippet72>

            //<Snippet73>
            rng.Find.ClearFormatting();

            if (rng.Find.Execute(ref findText,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, 
                ref missing, ref missing)) 
            { 
            //</Snippet73>
            //<Snippet74>
                MessageBox.Show("Text found.");
            } 
            else 
            { 
                MessageBox.Show("Text not found.");
            } 

            rng.Select(); 
            //</Snippet74>
        }
        //</Snippet71>


        //---------------------------------------------------------------------
        //<Snippet75>
        private void SearchReplace()
        {
            Word.Find findObject = Application.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = "find me";
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = "Found";

            object replaceAll = Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);
        }
        //</Snippet75>


        //---------------------------------------------------------------------
        //<Snippet78>
        private void FindLoop() 
        { 
            int intFound = 0; 
            //<Snippet79>
            Word.Range rng = this.Content; 
            //</Snippet79>

            //<Snippet80>
            rng.Find.ClearFormatting(); 
            rng.Find.Forward = true; 
            rng.Find.Text = "find me"; 

            rng.Find.Execute(
                ref missing, ref missing, ref missing, ref missing, ref missing, 
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

            while (rng.Find.Found) 
            { 
                intFound++;
                rng.Find.Execute(
                    ref missing, ref missing, ref missing, ref missing, ref missing, 
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing);
            } 
            //</Snippet80>

            //<Snippet81>
            MessageBox.Show("Strings found: " + intFound.ToString()); 
            //</Snippet81>
        }
        //</Snippet78>


        //---------------------------------------------------------------------
        //<Snippet82>
        internal void ReplaceRestoreSelection() 
        { 
            //<Snippet83>
            Word.Range start = Application.Selection.Range; 
            Word.Range searchArea = Application.ActiveDocument.Range(ref missing, ref missing); 
            //</Snippet83>

            //<Snippet84>
            searchArea.Find.ClearFormatting(); 
            searchArea.Find.Text = "find me"; 

            searchArea.Find.Replacement.ClearFormatting(); 
            searchArea.Find.Replacement.Text = "Found"; 

            object replaceAll = Word.WdReplace.wdReplaceAll; 

            searchArea.Find.Execute(
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //</Snippet84>

            //<Snippet85>
            start.Select(); 
            //</Snippet85>
        }
        //</Snippet82>


        //---------------------------------------------------------------------
        //<Snippet89>
        private void CreateDocumentPropertyTable() 
        { 
            //<Snippet90>
            object start = 0, end = 0; 
            Word.Range rng = this.Range(ref start, ref end); 
            //</Snippet90>

            // Insert a title for the table and paragraph marks. 
            //<Snippet91>
            rng.InsertBefore("Document Statistics"); 
            rng.Font.Name = "Verdana"; 
            rng.Font.Size = 16; 
            rng.InsertParagraphAfter(); 
            rng.InsertParagraphAfter(); 
            rng.SetRange(rng.End, rng.End); 
            //</Snippet91>

            // Add the table.
            //<Snippet92>
            rng.Tables.Add(this.Paragraphs[2].Range, 3, 2, ref missing, ref missing);
            //</Snippet92>

            // Format the table and apply a style. 
            //<Snippet93>
            Word.Table tbl = this.Tables[1];
            tbl.Range.Font.Size = 12; 
            tbl.Columns.DistributeWidth(); 

            object styleName = "Table Professional";
            tbl.set_Style(ref styleName); 
            //</Snippet93>

            // Insert document properties into cells. 
            //<Snippet94>
            tbl.Cell(1, 1).Range.Text = "Document Property";
            tbl.Cell(1, 2).Range.Text = "Value";

            tbl.Cell(2, 1).Range.Text = "Subject";
            tbl.Cell(2, 2).Range.Text = ((Office.DocumentProperties)(this.BuiltInDocumentProperties))
                [Word.WdBuiltInProperty.wdPropertySubject].Value.ToString();

            tbl.Cell(3, 1).Range.Text = "Author";
            tbl.Cell(3, 2).Range.Text = ((Office.DocumentProperties)(this.BuiltInDocumentProperties))
                [Word.WdBuiltInProperty.wdPropertyAuthor].Value.ToString();
            //</Snippet94>
        }
        //</Snippet89>


        //---------------------------------------------------------------------
 
        private void PageSetupDialogHidden() 
        { 
            Word.Dialog dialog = Application.Dialogs[Word.WdWordDialog.wdDialogFilePageSetup];

            InvokeHelper(dialog, "PageWidth", "3.3\"");
            InvokeHelper(dialog, "PageHeight", "6\"");
            InvokeHelper(dialog, "TopMargin", "0.71\"");
            InvokeHelper(dialog, "BottomMargin", "0.81\"");
            InvokeHelper(dialog, "LeftMargin", "0.66\"");
            InvokeHelper(dialog, "RightMargin", "0.66\"");
            InvokeHelper(dialog, "HeaderDistance", "0.28\"");
            InvokeHelper(dialog, "Orientation", "0");
            InvokeHelper(dialog, "DifferentFirstPage", "0");
            InvokeHelper(dialog, "FirstPage", "0");
            InvokeHelper(dialog, "OtherPages", "0");

            // Apply these settings only to the current selection with this line of code:
            InvokeHelper(dialog, "ApplyPropsTo", "3"); 

            // Apply the settings.
            dialog.Execute(); 
        }

        private static void InvokeHelper(Word.Dialog dialog, string member, string value)
        {
            System.Type dialogType = typeof(Word.Dialog);

            // Set the appropriate property of the dialog box.
            dialogType.InvokeMember(member,
                System.Reflection.BindingFlags.SetProperty |
                    System.Reflection.BindingFlags.Public |
                    System.Reflection.BindingFlags.Instance,
                null, dialog, new object[] { value },
                System.Globalization.CultureInfo.InvariantCulture);
        }



        //---------------------------------------------------------------------
        //<Snippet105>
        static void HideText(Word.Range rng)
        {
            rng.Font.Hidden = 1;  // 1 = True
        }
        //</Snippet105>

        //<Snippet106>
        static void UnhideText(Word.Range rng)
        {
            rng.Font.Hidden = 0;  // 0 = False
        }
        //</Snippet106>


        //---------------------------------------------------------------------
        private void Test15()
        {
            //<Snippet14>
            Application.PrintPreview = true; 
            //</Snippet14>


            //<Snippet12>
            object copies = "1"; 
            object pages = "1"; 
            object range = Word.WdPrintOutRange.wdPrintCurrentPage; 
            object items = Word.WdPrintOutItem.wdPrintDocumentContent; 
            object pageType = Word.WdPrintOutPages.wdPrintAllPages; 
            object oTrue = true; 
            object oFalse = false; 

            this.PrintOut(
                ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue, 
                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
            //</Snippet12>


            //<Snippet10>
            object fileName = @"C:\Test\NewDocument.docx"; 

            this.SaveAs(ref fileName,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);
            //</Snippet10>


            //<Snippet120>
            this.Paragraphs[1].Range.Select();
            //</Snippet120>


            //<Snippet119>
            this.DeleteAllComments();
            //</Snippet119>


            //<Snippet118>
            object text = "Add a comment to the first paragraph.";
            this.Comments.Add(this.Paragraphs[1].Range, ref text);
            //</Snippet118>


            //<Snippet116>
            foreach (Word.Section section in this.Sections)
            {
                Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            }
            //</Snippet116>
        }


        //---------------------------------------------------------------------
        private void Test14()
        {
            //<Snippet114>
            foreach (Word.Section wordSection in this.Sections)
            {
                Word.Range footerRange = wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;
                footerRange.Font.Size = 20;
                footerRange.Text = "Confidential";
            }
            //</Snippet114>


            //<Snippet113>
            string result = "Spelled incorrectly.";

            object startLocation = this.Content.Start;
            object endLocation = this.Content.End;
            bool spellCheck = this.Application.CheckSpelling(
                this.Range(ref startLocation, ref endLocation).Text);

            if (spellCheck == true)
            {
                result = "Spelled correctly.";
            }

            MessageBox.Show(result);
            //</Snippet113>


            //<Snippet111>
            object noReset = false;
            object password = System.String.Empty;
            object useIRM = false;
            object enforceStyleLock = false;

            this.Protect(Word.WdProtectionType.wdAllowOnlyReading, 
                ref noReset, ref password, ref useIRM, ref enforceStyleLock);
            //</Snippet111>

            //<Snippet112>
            this.bookmark1.Range.Editors.Add(Word.WdEditorType.wdEditorEveryone);
            //</Snippet112>


            //<Snippet109>
            float leftPosition = (float)this.Application.Selection.Information[
                Word.WdInformation.wdHorizontalPositionRelativeToPage];

            float topPosition = (float)this.Application.Selection.Information[
                Word.WdInformation.wdVerticalPositionRelativeToPage];
            //</Snippet109>


            //<Snippet110>
            this.Shapes.AddTextEffect(Office.MsoPresetTextEffect.msoTextEffect29, "SampleText",
                "Arial Black", 24, Office.MsoTriState.msoFalse, Office.MsoTriState.msoFalse,
                leftPosition, topPosition);
            //</Snippet110>


            //<Snippet108>
            this.Application.Selection.InlineShapes.AddPicture(@"C:\SamplePicture.jpg");
            //</Snippet108>


            //<Snippet107>
            HideText(bookmark1.Range);

            object oTrue = true;
            object oFalse = false;
            object range = Word.WdPrintOutRange.wdPrintAllDocument;
            object items = Word.WdPrintOutItem.wdPrintDocumentContent;
            object copies = "1";
            object pages = "";
            object pageType = Word.WdPrintOutPages.wdPrintAllPages;

            this.PrintOut(
                ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);

            UnhideText(bookmark1.Range);
            //</Snippet107>


            
            Word.Dialog dialog = Application.Dialogs[Word.WdWordDialog.wdDialogFileOpen];
            System.Type dialogType = typeof(Word.Dialog);

            // Set the Name property of the dialog box.
            dialogType.InvokeMember("Name", 
                System.Reflection.BindingFlags.SetProperty | 
                    System.Reflection.BindingFlags.Public | 
                    System.Reflection.BindingFlags.Instance,
                null, dialog, new object[] { "Testing" },
                System.Globalization.CultureInfo.InvariantCulture);

            // Display the dialog box.
            dialog.Show(ref missing); 

            // Show the Name property.
            MessageBox.Show(dialogType.InvokeMember("Name",
                System.Reflection.BindingFlags.GetProperty |
                    System.Reflection.BindingFlags.Public |
                    System.Reflection.BindingFlags.Instance,
                null, dialog, null,
                System.Globalization.CultureInfo.InvariantCulture).ToString());
       
        }


        //---------------------------------------------------------------------
        private void Test13()
        {
            //<Snippet100>
            Word.Dialog dlg = Application.Dialogs[Word.WdWordDialog.wdDialogFileOpen];
            dlg.Show();
            //</Snippet100>


            //<Snippet99>
            MessageBox.Show("Characters: " + this.Characters.Count.ToString());
            //</Snippet99>


            //<Snippet98>
            Word.Range rng = this.Content; 
            rng.Select(); 
            //</Snippet98>


            //<Snippet97>
            Word.Cell cell = this.Tables[1].Cell(1, 1);

            cell.Range.Text = "Name"; 
            cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            //</Snippet97>


            //<Snippet96>
            this.Tables[1].Columns.Add(this.Tables[1].Columns[1]); 
            this.Tables[1].Columns.DistributeWidth();
            //</Snippet96>


            //<Snippet95>
            this.Tables[1].Rows.Add(this.Tables[1].Rows[1]);
            //</Snippet95>


            //<Snippet88>
            this.Tables[1].Range.Font.Size = 8;
            this.Tables[1].set_Style("Table Grid 8");
            //</Snippet88>


            //<Snippet87>
            Word.Table newTable = this.Tables[1];
            //</Snippet87>


            //<Snippet86>
            object start = 0;
            object end = 0;
            Word.Range tableLocation = this.Range(ref start, ref end);
            this.Tables.Add(tableLocation, 3, 4);
            //</Snippet86>


            //<Snippet77>
            Application.Selection.Find.ClearFormatting(); 
            Application.Selection.Find.Execute("find me", Forward:true, Wrap:Word.WdFindWrap.wdFindContinue);
             //</Snippet77>
        }
        

        //---------------------------------------------------------------------
        private void Test12()
        {
            //<Snippet53>
            object start = 0; 
            object end = 12; 

            Word.Range rng = this.Range(ref start, ref end); 
            //</Snippet53>

            //<Snippet54>
            rng.Text = "New Text"; 
            //</Snippet54>

            //<Snippet55>
            rng.Select();
            //</Snippet55>
        }


        //---------------------------------------------------------------------
        private void Test11()
        {
            //<Snippet51>
            object start = 0; 
            object end = 0; 

            Word.Range rng = this.Range(ref start, ref end); 
            rng.Text = "New Text"; 
            //</Snippet51>

            //<Snippet52>
            rng.Select();
            //</Snippet52>
        }
        

        //---------------------------------------------------------------------
        private void Test10()
        {
            //<Snippet45>
            //<Snippet46>
            Word.Range rng = this.Paragraphs[1].Range; 
            //</Snippet46>

            //<Snippet47>
            rng.Collapse(Word.WdCollapseDirection.wdCollapseStart); 
            //</Snippet47>

            //<Snippet48>
            rng.Text = " New Text ";
            //</Snippet48>
            //<Snippet49>
            rng.Select();
            //</Snippet49>
            //</Snippet45>


            //<Snippet50>
            rng.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
            //</Snippet50>
        }


        //---------------------------------------------------------------------
        private void Test9()
        {
            //<Snippet42>
            //<Snippet43>
            object start = 0; 
            object end = 7; 
            Word.Range rng = this.Range(ref start,ref end); 
            //</Snippet43>

            // Reset the existing Range. 
            //<Snippet44>
            rng.SetRange(this.Sentences[2].Start, this.Sentences[5].End); 
            //</Snippet44>
            rng.Select();
            //</Snippet42>
        }


        //---------------------------------------------------------------------
        private void Test8()
        {
            //<Snippet38>
            // Define a range of 7 characters.
            //<Snippet39>
            object start = 0;
            object end = 7;
            Word.Range rng = this.Range(ref start, ref end);
            //</Snippet39>

            // Move the start position 7 characters.
            //<Snippet40>
            rng.MoveStart(Word.WdUnits.wdCharacter, 7);
            //</Snippet40>

            // Move the end position 7 characters.
            //<Snippet41>
            rng.MoveEnd(Word.WdUnits.wdCharacter, 7);
            //</Snippet41>
            //</Snippet38>
        }


        //---------------------------------------------------------------------
        private void Test7()
        {
            //<Snippet25>
            Word.Range rng = this.Sentences[2];

            string startPosition = rng.Start.ToString();
            string endPosition = rng.End.ToString();

            MessageBox.Show("Start: " + startPosition + " End: " + endPosition, "Range Information");
            //</Snippet25>


            //<Snippet21>
            Word.Range s2 = this.Sentences[2]; 
            s2.Select();
            //</Snippet21>


            //<Snippet20>
            this.Content.Select();
            //</Snippet20>


            //<Snippet19>
            object start = this.Content.Start;
            object end = this.Content.End;

            this.Range(ref start, ref end).Select();
            //</Snippet19>
        }


        //---------------------------------------------------------------------
        private void Test6()
        {
            //<Snippet18>
            object start = 0; 
            object end = 7; 
            Word.Range rng = this.Range(ref start, ref end); 

            rng.Select();
            //</Snippet18>


            //<Snippet17>
            string documentName2 = Globals.ThisDocument.Name;
            //</Snippet17>


            //<Snippet16>
            string documentName = Application.ActiveDocument.Name;
            //</Snippet16>


            //<Snippet15>
            Word.Document doc = Application.Documents["SampleDoc.docx"]; 
            //</Snippet15>
        }
        

        //---------------------------------------------------------------------
        private void Test5()
        {
            //<Snippet13>
            this.PrintPreview();
            //</Snippet13>


            //<Snippet11>
            object copies = "1";
            object pages = "";
            object range = Word.WdPrintOutRange.wdPrintAllDocument;
            object items = Word.WdPrintOutItem.wdPrintDocumentContent;
            object pageType = Word.WdPrintOutPages.wdPrintAllPages;
            object oTrue = true;
            object oFalse = false;

            this.PrintOut(ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue, 
                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
            //</Snippet11>
            
            //<Snippet9>
            this.Application.Documents[@"C:\Test\NewDocument.docx"].Save();
            //</Snippet9>
        }


        //---------------------------------------------------------------------
        private void Test4()
        {
            //<Snippet8>
            this.Application.ActiveDocument.Save();
            //</Snippet8>


            //<Snippet7>
            this.Save();
            //</Snippet7>


            //<Snippet6>
            this.Application.Documents.Open(@"C:\Test\NewDocument.docx", ReadOnly:true);
            //</Snippet6>
        }


        //---------------------------------------------------------------------
        private void Test3()
        {
            //<Snippet5>
            this.Application.Documents.Open(@"C:\Test\NewDocument.docx");
            //</Snippet5>
        }
        

        //---------------------------------------------------------------------
        private void Test2()
        {
            //<Snippet4>
            Word._Document doc = Application.Documents["NewDocument.docx"] as Word._Document;
            doc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
            //</Snippet4>
        }
        

        //---------------------------------------------------------------------
        private void Test()
        {
            //<Snippet3>
            object doNotSaveChanges = Word.WdSaveOptions.wdDoNotSaveChanges; 
            this.Close(ref doNotSaveChanges, ref missing, ref missing);
            //</Snippet3>


            //<Snippet2>
            this.Application.Documents.Add(@"C:\Test\SampleTemplate.dotx");
            //</Snippet2>


            //<Snippet1>
            this.Application.Documents.Add();
           //</Snippet1>
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
