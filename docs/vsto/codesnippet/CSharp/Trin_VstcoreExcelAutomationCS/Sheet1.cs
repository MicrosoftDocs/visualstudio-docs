using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreExcelAutomationCS
{
    public partial class Sheet1
    {
        //---------------------------------------------------------------------
        //<Snippet83>
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }
        //</Snippet83>


        //---------------------------------------------------------------------
        //<Snippet21>
        private void ListSheets()
        {
            int index = 0;

            Microsoft.Office.Tools.Excel.NamedRange NamedRange1 =
                Globals.Sheet1.Controls.AddNamedRange(
                Globals.Sheet1.Range["A1"], "NamedRange1");

            foreach (Excel.Worksheet displayWorksheet in Globals.ThisWorkbook.Worksheets)
            {
                NamedRange1.Offset[index, 0].Value2 = displayWorksheet.Name;
                index++;
            }
        }
        //</Snippet21>


        //---------------------------------------------------------------------
        //<Snippet31>
        private void ShowOrHideComments(bool show)
        {
            for (int i = 1; i <= this.Comments.Count; i++)
            {
                this.Comments[i].Visible = show;
            }
        }
        //</Snippet31>


        //---------------------------------------------------------------------
        //<Snippet36>
        // Keep track of the previously bolded row.
        //<Snippet37>
        static int previousRow = 0;
        //</Snippet37>

        private void BoldCurrentRow(Excel.Worksheet ws)
        {
            // Work with the current active cell.
            //<Snippet38>
            Excel.Range currentCell = this.Application.ActiveCell;
            //</Snippet38>

            // Bold the current row.
            //<Snippet39>
            currentCell.EntireRow.Font.Bold = true; 
            //</Snippet39>

            // If a pass has been done previously, make the old row not bold.
            // Make sure previousRow is not 0 (otherwise this is your first pass through).
            //<Snippet40>
            if (previousRow != 0)
            //</Snippet40>
            
                // Make sure the current row is not the same as the previous row.
                //<Snippet41>
                if (currentCell.Row != previousRow)
                //</Snippet41>
                {
                    //<Snippet42>
                    Excel.Range rng = (Excel.Range)ws.Rows[previousRow];
                    rng.EntireRow.Font.Bold = false;
                    //</Snippet42>
                }

            // Store the new row number for the next pass.
            //<Snippet43>
            previousRow = currentCell.Row;
            //</Snippet43>
        }
        //</Snippet36>


        //---------------------------------------------------------------------
        //<Snippet49>
        private void AutoFill()
        {
            Excel.Range rng = this.Application.get_Range("B1");
            rng.AutoFill(this.Application.get_Range("B1","B5"), 
                Excel.XlAutoFillType.xlFillWeekdays); 

            rng = this.Application.get_Range("C1"); 
            rng.AutoFill(this.Application.get_Range("C1","C5"),
                Excel.XlAutoFillType.xlFillMonths);

            rng = this.Application.get_Range("D1","D2");
            rng.AutoFill(this.Application.get_Range("D1","D5"),
                Excel.XlAutoFillType.xlFillSeries); 
        }
        //</Snippet49>


        //---------------------------------------------------------------------
        //<Snippet57>
        private void DemoFind() 
        {
            //<Snippet58>
            Excel.Range currentFind = null; 
            Excel.Range firstFind = null; 
            //</Snippet58>

            Excel.Range Fruits = Application.get_Range("A1", "B3");
            // You should specify all these parameters every time you call this method,
            // since they can be overridden in the user interface. 
            //<Snippet59>
            currentFind = Fruits.Find("apples", missing,
                Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart, 
                Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
                missing, missing); 
            //</Snippet59>
    
            //<Snippet60>
            while(currentFind != null) 
            //</Snippet60>
            { 
                // Keep track of the first range you find. 
                //<Snippet61>
                if (firstFind == null)
                {
                    firstFind = currentFind; 
                }
                //</Snippet61>
    
                // If you didn't move to a new range, you are done.
                //<Snippet62>
                else if (currentFind.get_Address(Excel.XlReferenceStyle.xlA1)
                      == firstFind.get_Address(Excel.XlReferenceStyle.xlA1))
                {
                    break;
                }
                //</Snippet62>

                //<Snippet63>
                currentFind.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                currentFind.Font.Bold = true; 
                //</Snippet63>

                //<Snippet64>
                currentFind = Fruits.FindNext(currentFind); 
                //</Snippet64>
            }
        }
        //</Snippet57>


        //---------------------------------------------------------------------
        void Test5()
        {
            //<Snippet72>
            Microsoft.Office.Tools.Excel.NamedRange nr;
            nr = this.Controls.AddNamedRange(this.Range["A1"], "Files");

            for(int i=1; i<=this.Application.RecentFiles.Count; i++)
            {
                nr.Offset[i - 1, 0].Value2 = this.Application.RecentFiles.get_Item(i).Name;
            }
            //</Snippet72>


            //<Snippet68>
            this.message.Value2 = "Hello world";
            //</Snippet68>

            //<Snippet69>
            Excel.Range rng = Globals.Sheet1.Range["A1"];
            rng.Value2 = "Hello world";
            //</Snippet69>
        }


        //---------------------------------------------------------------------
        void Test4()
        {
            //<Snippet55>
            this.rangeStyles.Style = "Normal";
            //</Snippet55>

            //<Snippet56>
            Excel.Range rng = this.Application.get_Range("A1");
            rng.Style = "Normal";
            //</Snippet56>
        }
        

        //---------------------------------------------------------------------
        void Test3()
        {
            //<Snippet45>
            Globals.Sheet1.CheckSpelling();
            //</Snippet45>


            //<Snippet32>
            this.data2001.Group();
            //</Snippet32>
        
            //<Snippet33>
            this.Application.get_Range("data2001");
                
            this.Application.get_Range("data2002")
                .Group();

            this.Application.get_Range("dataAll")
                .Group();
            //</Snippet33>

            //<Snippet34>
            this.data2001.Ungroup();
            this.data2002.Ungroup();
            this.dataAll.Ungroup();
            //</Snippet34>

            //<Snippet35>
            this.Application.get_Range("data2001").Ungroup();
            this.Application.get_Range("data2002").Ungroup();
            this.Application.get_Range("dataAll").Ungroup();
            //</Snippet35>


            //<Snippet48>
            Microsoft.Office.Tools.Excel.NamedRange nr =
                this.Controls.AddNamedRange(this.Range["A1"], "NamedRange1");

            nr.Value2 = "Hello World";
            //</Snippet48>


            //<Snippet82>
            Globals.Sheet1.PrintPreview();
            //</Snippet82>


            //<Snippet81>
            this.Application.Workbooks.OpenXML(@"C:\Test.xml");
            //</Snippet81>


            //<Snippet80>
            this.Application.Workbooks.OpenText(@"C:\Test.txt",
                missing, 3,
                Excel.XlTextParsingType.xlDelimited,
                Excel.XlTextQualifier.xlTextQualifierNone,
                missing, missing, missing, true, missing, missing, missing, 
                missing, missing, missing, missing, missing, missing);
            //</Snippet80>


            //<Snippet79>
            this.fruitList.Range.Sort(
                this.fruitList.ListColumns[1].Range, Excel.XlSortOrder.xlAscending,
                this.fruitList.ListColumns[2].Range, missing, Excel.XlSortOrder.xlAscending,
                missing, Excel.XlSortOrder.xlAscending, 
                Excel.XlYesNoGuess.xlYes, missing, missing, 
                Excel.XlSortOrientation.xlSortColumns,
                Excel.XlSortMethod.xlPinYin, 
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal);
            //</Snippet79>


            //<Snippet78>
            this.Fruits.Sort(
                this.Fruits.Columns[1, missing], Excel.XlSortOrder.xlAscending,
                this.Fruits.Columns[2, missing], missing, Excel.XlSortOrder.xlAscending,
                missing, Excel.XlSortOrder.xlAscending,
                Excel.XlYesNoGuess.xlNo, missing, missing, 
                Excel.XlSortOrientation.xlSortColumns,
                Excel.XlSortMethod.xlPinYin,
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal); 
            //</Snippet78>


            //<Snippet77>
            this.Application.Calculate();
            //</Snippet77>


            //<Snippet75>
            Microsoft.Office.Tools.Excel.NamedRange NamedRange1 =
                this.Controls.AddNamedRange(this.get_Range("A1"), "NamedRange1");
            //</Snippet75>


            //<Snippet76>
            NamedRange1.Calculate();
            //</Snippet76>


            //<Snippet74>
            Globals.ThisWorkbook.SendMail("someone@example.com", "July Sales Figures");
            //</Snippet74>


            //<Snippet73>
            Microsoft.Office.Core.FileDialog fd = 
                this.Application.get_FileDialog(Microsoft.Office.Core.MsoFileDialogType.msoFileDialogOpen);

            fd.AllowMultiSelect = true; 
            fd.Filters.Clear(); 
            fd.Filters.Add("Excel Files", "*.xlsx;*.xlw"); 
            fd.Filters.Add("All Files", "*.*"); 

            if (fd.Show() != 0)
            {
                fd.Execute();
            }
            //</Snippet73>


            //<Snippet70>
            System.Security.Principal.WindowsIdentity user;
            user = System.Security.Principal.WindowsIdentity.GetCurrent();
            //</Snippet70>


            //<Snippet71>
            Microsoft.Office.Tools.Excel.NamedRange userID;
            userID = this.Controls.AddNamedRange(this.Range["A1"], "userID");

            userID.Value2 = user.Name;
            //</Snippet71>


            //<Snippet67>
            Excel.Range rng2 = this.Application.get_Range("A1");
            rng2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            //</Snippet67>


            //<Snippet65>
            Microsoft.Office.Tools.Excel.NamedRange rng =
                this.Controls.AddNamedRange(this.Range["A1"], "NamedRange1");
            //</Snippet65>


            //<Snippet66>
            rng.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            //</Snippet66>


            //<Snippet54>
            Microsoft.Office.Tools.Excel.NamedRange rangeStyles =
                this.Controls.AddNamedRange(this.Range["A1"], "rangeStyles");

            rangeStyles.Value2 = "'Style Test";
            rangeStyles.Style = "NewStyle";
            rangeStyles.Columns.AutoFit();
            //</Snippet54>


            //<Snippet53>
            Excel.Style style = Globals.ThisWorkbook.Styles.Add("NewStyle");
            
            style.Font.Name = "Verdana";
            style.Font.Size = 12;
            style.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            style.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            //</Snippet53>
        }
        

        //---------------------------------------------------------------------
        void Test2()
        {
            //<Snippet50>
            Microsoft.Office.Tools.Excel.NamedRange NamedRange1 =
                this.Controls.AddNamedRange(this.get_Range("A1"), "NamedRange1");
            //</Snippet50>


            //<Snippet51>
            DateTime dt = DateTime.Now;
            NamedRange1.Value2 = dt;
            //</Snippet51>


            //<Snippet52>
            object value = NamedRange1.Value2;

            if (value != null)
            {
                if (value is double)
                {
                    dt = DateTime.FromOADate((double)value);
                }
                else
                {
                    DateTime.TryParse((string)value, out dt);
                }
            }
            MessageBox.Show(dt.ToString());
            //</Snippet52>
        }


        //---------------------------------------------------------------------
        void Test()
        {
            string getPasswordFromUser = "password";


            //<Snippet47>
            Excel.Range rng = this.Application.get_Range("A1");

            rng.Value2 = "Range value";
            //</Snippet47>


            //<Snippet46>
            Microsoft.Office.Tools.Excel.NamedRange NamedRange1 =
                this.Controls.AddNamedRange(this.get_Range("A1"), "NamedRange1");

            NamedRange1.Value2 = "Range value";
            //</Snippet46>


            //<Snippet44>
            this.Application.ActiveWorkbook.Sheets.FillAcrossSheets(
                this.Application.get_Range("rangeData"), 
                Excel.XlFillWith.xlFillWithAll);
            //</Snippet44>


            //<Snippet30>
            this.dateComment.AddComment("Comment added " + DateTime.Now.ToString());
            //</Snippet30>


            //<Snippet29>
            if (this.dateComment.Comment != null)
            {
                this.dateComment.Comment.Delete();
            }
            //</Snippet29>


            //<Snippet28>
            Globals.Sheet1.Unprotect(getPasswordFromUser);
            //</Snippet28>


            //<Snippet27>
            Globals.Sheet1.Protect(getPasswordFromUser, true);
            //</Snippet27>


            //<Snippet26>
            ((Excel.Worksheet) Globals.ThisWorkbook.Sheets[1])
                .Visible = Excel.XlSheetVisibility.xlSheetHidden;
            //</Snippet26>


            //<Snippet25>
            Globals.Sheet1.Visible = Excel.XlSheetVisibility.xlSheetHidden;
            //</Snippet25>


            //<Snippet24>
            int totalSheets = this.Application.ActiveWorkbook.Sheets.Count;
            Globals.Sheet1.Move(Globals.ThisWorkbook.Sheets[totalSheets]);
            //</Snippet24>


            //<Snippet23>
            Globals.Sheet1.PrintPreview();
            //</Snippet23>


            //<Snippet22>
            Globals.Sheet1.PrintOut(1, 1, 2, true);
            //</Snippet22>


            //<Snippet20>
            ((Excel.Worksheet)this.Application.ActiveWorkbook.Sheets[1]).Select();
            //</Snippet20>


            //<Snippet19>
            Globals.Sheet1.Select();
            //</Snippet19>


            //<Snippet18>
            ((Excel.Worksheet)this.Application.ActiveWorkbook.Sheets[4]).Delete();
            //</Snippet18>


            //<Snippet17>
            Globals.Sheet1.Delete();
            //</Snippet17>


            //<Snippet16>
            Globals.Sheet1.Copy(Globals.ThisWorkbook.Sheets[3]);
            //</Snippet16>


            //<Snippet15>
            Excel.Worksheet newWorksheet;
            newWorksheet = (Excel.Worksheet)Globals.ThisWorkbook.Worksheets.Add();
            //</Snippet15>


            //<Snippet14>
            this.Application.DefaultFilePath = @"C:\temp";
            //</Snippet14>
            this.Application.DefaultFilePath = this.defaultSavePath.Value2.ToString();

            //<Snippet13>
            System.Windows.Forms.MessageBox.Show(this.Application.DefaultFilePath);
            //</Snippet13>
            this.defaultSavePath.Value2 = this.Application.DefaultFilePath;

            //<Snippet9>
            Excel.Workbook wb = this.Application.Workbooks[1];

            // Before Book1 is saved:
            wb = this.Application.Workbooks["Book1"];

            // After Book1 is saved:
            wb = this.Application.Workbooks["Book1.xlsx"];
            //</Snippet9>


            //<Snippet8>
            Globals.ThisWorkbook.Activate();
            //</Snippet8>


            //<Snippet7>
            ((Microsoft.Office.Interop.Excel._Workbook)
                this.Application.Workbooks[1]).Activate();
            //</Snippet7>


            //<Snippet3>
            Globals.ThisWorkbook.Close(false);
            //</Snippet3>


            //<Snippet2>
            this.Application.Workbooks.Open(@"C:\Test\YourWorkbook.xlsx");
            //</Snippet2>
                

            //<Snippet1>
            Excel.Workbook newWorkbook = this.Application.Workbooks.Add();
            //</Snippet1>
        }




        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(Sheet1_Startup);
            this.Shutdown+=new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion
    }
}
