using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Visio = Microsoft.Office.Interop.Visio;
using Office = Microsoft.Office.Core;

namespace Trin_VstcoreVisioAutomationAddIn_O12
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            saveDocument();
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

        #region createDocument
        private void createDocument()
        {
            // Create a blank document that is not based on a template
            //<Snippet1>
            this.Application.Documents.Add("");
            //</Snippet1>

            // Create a document based on a drawing
            {
                //<Snippet2>
                string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyDrawing.vsd";
                this.Application.Documents.Add(docPath);
                //</Snippet2>
            }

            // Create a document based on a stencil
            {
                //<Snippet3>
                string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyStencil.vss";
                this.Application.Documents.Add(docPath);
                //</Snippet3>
            }

            // Create a document based on a template
            {
                //<Snippet4>
                string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyTemplate.vst";
                this.Application.Documents.Add(docPath);
                //</Snippet4>
            }
        }

        #endregion // createDocument

        #region openDocument
        private void openDocument()
        {
            // Open a document based on a drawing
            {
                //<Snippet5>
                string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyDrawing.vsd";
                this.Application.Documents.Open(docPath);
                //</Snippet5>
            }

            // Open a document based on a drawing as read-only, open, and docked
            {
                //<Snippet6>
                string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyDrawing.vsd";
                this.Application.Documents.OpenEx(docPath,
                    ((short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenDocked +
                     (short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenRO));
                //</Snippet6>
            }
        }

        #endregion // openDocument

        #region closeDocument
        private void closeDocument()
        {
            this.Application.Documents.Open(@"d:\test\myDrawing.vsd");
            // set a visio document to the currently active document and then close
            //<Snippet7>
            this.Application.ActiveDocument.Close();
            //</Snippet7>
        }

        #endregion // closeDocument

        #region printDocument
        private void printDocument()
        {
            this.Application.Documents.Open(@"d:\test\flowchart.vsd");
            // set a visio document to the currently active document and then print the entire doc
            //<Snippet8>
            this.Application.ActiveDocument.Print();
            //</Snippet8>

            // set a visio document to the currently active document and then print only the first page
            //<Snippet9>
            int pageIndex = 1;
            Visio.Pages visioDocPages = this.Application.ActiveDocument.Pages;
            if (pageIndex <= visioDocPages.Count)
                visioDocPages[pageIndex].Print();
            //</Snippet9>
        }
        #endregion // printDocument

        #region saveDocument
        private void saveDocument()
        {
            // Open a document based on a drawing
            this.Application.Documents.Open(@"d:\docs\test\myDrawing.vsd");

            //<Snippet10>
            string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyDrawing.vsd";
            this.Application.ActiveDocument.SaveAs(docPath);
            //</Snippet10>

            //<Snippet11>
            this.Application.ActiveDocument.Save();
            //</Snippet11>

            //<Snippet12>
            string newDocPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyOtherDrawing.vsd";
            this.Application.ActiveDocument.SaveAsEx(newDocPath,
                ((short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visSaveAsRO +
                 (short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visSaveAsListInMRU));
            //</Snippet12>
        }

        #endregion // saveDocument

        #region addShapes
        private void addShapes()
        {
            this.Application.Documents.Add("");

            Visio.Page visioPage = this.Application.ActivePage;

            Visio.Document visioStencil = this.Application.Documents.Open(@"Basic Shapes.vss");

            Visio.Master visioRectMaster = visioStencil.Masters.get_ItemU(@"Rectangle");
            Visio.Shape visioRectShape = visioPage.Drop(visioRectMaster, 4.25, 5.5);
            visioRectShape.Text = @"Rectangle text.";

            Visio.Master visioStarMaster = visioStencil.Masters.get_ItemU(@"5-Point Star");
            Visio.Shape visioStarShape = visioPage.Drop(visioStarMaster, 2.0, 5.5);
            visioStarShape.Text = @"Star text.";

            Visio.Master visioHexagonMaster = visioStencil.Masters.get_ItemU(@"Hexagon");
            Visio.Shape visioHexagonShape = visioPage.Drop(visioHexagonMaster, 7.0, 5.5);
            visioHexagonShape.Text = @"Hexagon text.";
        }

        private void addShapes2()
        {
            //this.Application.Documents.Add(@"Basic Diagram.vst");
            //<Snippet13>
            this.Application.Documents.Add("");

            Visio.Documents visioDocs = this.Application.Documents;
            Visio.Document visioStencil = visioDocs.OpenEx("Basic Shapes.vss",
                (short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenDocked);

            Visio.Page visioPage = this.Application.ActivePage;

            Visio.Master visioRectMaster = visioStencil.Masters.get_ItemU(@"Rectangle");
            Visio.Shape visioRectShape = visioPage.Drop(visioRectMaster, 4.25, 5.5);
            visioRectShape.Text = @"Rectangle text.";

            Visio.Master visioStarMaster = visioStencil.Masters.get_ItemU(@"5-Point Star 7");
            Visio.Shape visioStarShape = visioPage.Drop(visioStarMaster, 2.0, 5.5);
            visioStarShape.Text = @"Star text.";

            Visio.Master visioHexagonMaster = visioStencil.Masters.get_ItemU(@"Hexagon");
            Visio.Shape visioHexagonShape = visioPage.Drop(visioHexagonMaster, 7.0, 5.5);
            visioHexagonShape.Text = @"Hexagon text.";
            //</Snippet13>
        }
        #endregion

        #region copyShapes
        private void copyShapesNormal()
        {
            //<Snippet14>
            this.Application.Documents.Add("");
            Visio.Page copyPage;
            Visio.Page pastePage;
            Visio.Shape rectangle = null;
            Visio.Shape oval = null;

            Visio.Pages visioPages = this.Application.ActiveDocument.Pages;

            visioPages.Add();

            try
            {
                copyPage = visioPages[1];
                rectangle = copyPage.DrawRectangle(1.1, 2.2, 4.5, 6.7);
                oval = copyPage.DrawOval(1, 8.75, 3.5, 6.25);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                pastePage = visioPages[2];
                rectangle.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNormal);
                pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNormal);
                oval.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNormal);
                pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNormal);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //</Snippet14>
        }

        private void copyShapesNoTranslate()
        {
            //<Snippet15>
            this.Application.Documents.Add("");
            Visio.Page copyPage;
            Visio.Page pastePage;
            Visio.Shape rectangle = null;
            Visio.Shape oval = null;

            Visio.Pages visioPages = this.Application.ActiveDocument.Pages;

            visioPages.Add();

            try
            {
                copyPage = visioPages[1];
                rectangle = copyPage.DrawRectangle(1.1, 2.2, 4.5, 6.7);
                oval = copyPage.DrawOval(1, 8.75, 3.5, 6.25);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                pastePage = visioPages[2];
                rectangle.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate);
                pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate);
                oval.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate);
                pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //</Snippet15>
        }
        #endregion  //copyShapes


    }
}
