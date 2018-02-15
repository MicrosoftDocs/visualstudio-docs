using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Excel.Extensions;

namespace Trin_VstcoreExcelAutomationAddIn_O12
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }
        private void CloseWorkbook()
        {
            //<Snippet1>
            this.Application.ActiveWorkbook.Close(false, missing, missing);
            //</Snippet1>
        }

        private void CloseWorkbookByName()
        {
            //<Snippet2>
            object fileName = "NewWorkbook.xlsx";
            Excel.Workbook workbook = this.Application.Workbooks.get_Item(fileName);
            workbook.Close(false);
            //</Snippet2>
        }
        private void SaveWorkbook()
        {
            //<Snippet3>
            this.Application.ActiveWorkbook.Save();
            //</Snippet3>
        }

        private void SaveWorkbookAs()
        {
            //<Snippet4>
            this.Application.ActiveWorkbook.SaveAs(@"C:\Test\Book1.xml", 
                Excel.XlSaveAsAccessMode.xlNoChange);
            //</Snippet4>
        }
        private void SaveWorkbookAsCopy()
        {
            //<Snippet5>
            this.Application.ActiveWorkbook.SaveCopyAs(@"C\Book1.xlsx");
            //</Snippet5>
        }
        private void ProtectWorkbook()
        {
            object getPasswordFromUser = "hello";
            //<Snippet6>
            this.Application.ActiveWorkbook.Protect(getPasswordFromUser);
            //</Snippet6>
        }
        private void UnProtectWorkbook()
        {
            object getPasswordFromUser = "hello";
            //<Snippet7>
            this.Application.ActiveWorkbook.Unprotect(getPasswordFromUser);
            //</Snippet7>
        }
        //<Snippet8>
        private void SetPassword()
        {
            string password = this.Application.InputBox("Enter the new password:").ToString();

            string confirmPassword = this.Application.InputBox("Confirm the password:").ToString();

            if (password != confirmPassword)
            {
                System.Windows.Forms.MessageBox.Show
                    ("The passwords you typed do not match.");
                this.Application.ActiveWorkbook.Password = "";
            }
            else
            {
                this.Application.ActiveWorkbook.Password = password;
            }
        }
        //</Snippet8>        

        private void ListRecentlyUsedWorkbooks()
        {
            //<Snippet9>
            Excel.Range rng = this.Application.get_Range("A1");
            for(int i=1; i<=this.Application.RecentFiles.Count; i++)
             {
                rng.get_Offset(i - 1,0).Value2 = this.Application.RecentFiles.get_Item(i).Name;
              }
            //</Snippet9>
         }        
        private void SendMail()
        {
            //<Snippet10>
            this.Application.ActiveWorkbook.SendMail("someone@example.com", "July Sales Figures");
            //</Snippet10>
        }
        private void AddWorksheet()
        {
            //<Snippet11>
            Excel.Worksheet newWorksheet;
            newWorksheet = (Excel.Worksheet)this.Application.Worksheets.Add();
            //</Snippet11>
        }
        private void CopyWorksheet()
        {
            //<Snippet12>
            Excel.Worksheet worksheet1 = ((Excel.Worksheet)Application.ActiveWorkbook.Worksheets[1]);
            Excel.Worksheet worksheet3 = ((Excel.Worksheet)Application.ActiveWorkbook.Worksheets[3]);
            worksheet1.Copy(worksheet3);
            //</Snippet12>
        }
        //<Snippet13>
        private void ListSheets()
        {
            int index = 0;

            Excel.Range rng = this.Application.get_Range("A1");

            foreach (Excel.Worksheet displayWorksheet in this.Application.Worksheets)
            {
                rng.get_Offset(index, 0).Value2 = displayWorksheet.Name;
                index++;
            }
        }
        //</Snippet13>
        private void PrintMethods()
        {
            //<Snippet14>
            ((Excel.Worksheet)Application.ActiveSheet).PrintOut
                (1, 1, 2, true);
            //</Snippet14>
            //<Snippet15>
            ((Excel.Worksheet)Application.ActiveSheet).PrintPreview();
            //</Snippet15>
        }
        private void MoveWorksheeets()
        {
            //<Snippet16>
            int totalSheets = this.Application.ActiveWorkbook.Sheets.Count;
            ((Excel.Worksheet)Application.ActiveSheet).Move(
                this.Application.Worksheets[totalSheets]);
            //</Snippet16>
        }
        private void ProtectWorksheets()
        {
            object getPasswordFromUser = "hello";
            //<Snippet17>
            ((Excel.Worksheet)Application.ActiveSheet).Protect(getPasswordFromUser, true);
            //</Snippet17>
        }
        private void UnProtectWorksheets()
        {
            object getPasswordFromUser = "hello";
            //<Snippet18>
            ((Excel.Worksheet)Application.ActiveSheet).Unprotect(getPasswordFromUser);
            //</Snippet18>
        }
        private void DeleteComment()
        {
            //<Snippet19>
            Excel.Range dateComment = this.Application.get_Range("A1");
            if (dateComment.Comment != null)
            {
                dateComment.Comment.Delete();
            }
            //</Snippet19>
        }
        private void AddComment()
        {
            //<Snippet20>
            Excel.Range dateComment = this.Application.get_Range("A1");
            dateComment.AddComment("Comment added " + DateTime.Now.ToString());
            //</Snippet20>
        }
        
        //<Snippet21>
        private void ShowOrHideComments(bool show)
        {
            Excel.Worksheet worksheet = (Excel.Worksheet)Application.ActiveSheet;
            for (int i = 1; i <= worksheet.Comments.Count; i++)
            {
                worksheet.Comments[i].Visible = show;
            }
        }
        //</Snippet21>
        private void CheckSpelling()
        {
            //<Snippet22>
            ((Excel.Worksheet)Application.ActiveSheet).CheckSpelling();
            //</Snippet22>
        }
        
        private void SortNamedRange()
        {
            //<Snippet23>
            Excel.Range Fruits = Application.get_Range("A1", "B3");
                Fruits.Sort(
                Fruits.Columns[1], Excel.XlSortOrder.xlAscending,
                Fruits.Columns[2], missing, Excel.XlSortOrder.xlAscending,
                missing, Excel.XlSortOrder.xlAscending,
                Excel.XlYesNoGuess.xlNo, missing, missing,
                Excel.XlSortOrientation.xlSortColumns,
                Excel.XlSortMethod.xlPinYin,
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal); 
            //</Snippet23>
        }
        private void SortListObject()
        {
            //<Snippet24> 
            Excel.ListObject fruitList = 
                 ((Excel.Worksheet)Application.ActiveSheet).
                     ListObjects.Add(Microsoft.Office.Interop.Excel.XlListObjectSourceType.xlSrcRange,
                     Application.get_Range("A1", "B3"), 
                     missing, Microsoft.Office.Interop.Excel.XlYesNoGuess.xlNo); 
                fruitList.Range.Sort(
                    fruitList.ListColumns[1].Range, Excel.XlSortOrder.xlAscending,
                    fruitList.ListColumns[2].Range, missing, Excel.XlSortOrder.xlAscending,
                    missing, Excel.XlSortOrder.xlAscending,
                    Excel.XlYesNoGuess.xlYes, missing, missing,
                    Excel.XlSortOrientation.xlSortColumns,
                    Excel.XlSortMethod.xlPinYin,
                    Excel.XlSortDataOption.xlSortNormal,
                    Excel.XlSortDataOption.xlSortNormal,
                    Excel.XlSortDataOption.xlSortNormal);
            //</Snippet24>
        }
        private void StoreAndRetrieveDateInRange()
        {
            //<Snippet25>
            Excel.Range rng = this.Application.get_Range("A1");
            //</Snippet25>

            //<Snippet26>
            DateTime dt = DateTime.Now;
            rng.Value2 = dt;
            //</Snippet26>

            //<Snippet27>
            object value = rng.Value2;

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
            System.Windows.Forms.MessageBox.Show(dt.ToString());
            //</Snippet27>
        }
        private void ApplyStylesToRanges()
        {
            //<Snippet28>
            Excel.Style style = this.Application.ActiveWorkbook.Styles.Add("NewStyle");

            style.Font.Name = "Verdana";
            style.Font.Size = 12;
            style.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            style.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            //</Snippet28>
            //<Snippet29>
            Excel.Range rangeStyles = this.Application.get_Range("A1");

            rangeStyles.Value2 = "'Style Test";
            rangeStyles.Style = "NewStyle";
            rangeStyles.Columns.AutoFit();
            //</Snippet29>
        }
        private void RunExcelCalculations()
        {
            //<Snippet30>
            Excel.Range rng = this.Application.get_Range("A1");
            //</Snippet30>
            //<Snippet31>
            rng.Calculate();
            //</Snippet31>
        }

        private void SendValuesToWorksheetCells()
        {
            //<Snippet32>
            Excel.Range rng = this.Application.get_Range("A1");
            rng.Value2 = "Hello World";
            //</Snippet32>
        }
        private void DisplayCurrentUsersLogonIDInCell()
        {
            //<Snippet33>
            System.Security.Principal.WindowsIdentity user;
            user = System.Security.Principal.WindowsIdentity.GetCurrent();
            //</Snippet33>

            //<Snippet34>
            Excel.Range userID = this.Application.get_Range("A1");

            userID.Value2 = user.Name;
            //</Snippet34>
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
