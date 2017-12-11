using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Tools.Word.Extensions;

namespace Trin_WordAddIn_BindingDataToContentControl_O12
{
    public partial class ThisAddIn
    {
        //<Snippet2>
        private ContentService.getContentRequest request;
        private ContentService.ContentServicePortTypeClient proxy;
        private ContentService.requestedDocument[] document;
        private ContentService.getContentResponse response;
        private ContentService.appId appId;
        private Microsoft.Office.Tools.Word.RichTextContentControl richTextContentControl;
        private System.ComponentModel.Container components;
        private System.Windows.Forms.BindingSource primaryDocumentsBindingSource;
        //</Snippet2>

        //<Snippet3>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            AddRichTextControlAtRange();
            InitializeServiceObjects();
            this.richTextContentControl.Entering += richTextContentControl_Entering;
        }
        //</Snippet3>

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        //<Snippet4>
        private void AddRichTextControlAtRange()
        {
            Word.Document currentDocument = this.Application.ActiveDocument;
            currentDocument.Paragraphs[1].Range.InsertParagraphBefore();

            Document extendedDocument = Globals.Factory.GetVstoObject(currentDocument);

            richTextContentControl = extendedDocument.Controls.AddRichTextContentControl(
                currentDocument.Paragraphs[1].Range, "richTextContentControl");
            richTextContentControl.PlaceholderText =
                "Click here to download MSDN Library information about content controls.";
        }
        //</Snippet4>

        //<Snippet6>
        private void InitializeServiceObjects()
        {
            request = new ContentService.getContentRequest();
            proxy = new ContentService.ContentServicePortTypeClient();
            document = new ContentService.requestedDocument[1];
            response = new ContentService.getContentResponse();
            appId = new ContentService.appId();
            components = new System.ComponentModel.Container();
            primaryDocumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
        }
        //</Snippet6>

        //<Snippet5>
        void richTextContentControl_Entering(object sender, ContentControlEnteringEventArgs e)
        {
            document[0] = new ContentService.requestedDocument();
            document[0].type = ContentService.documentTypes.primary;
            document[0].selector = "Mtps.Xhtml";

            request.contentIdentifier = "ed59e522-dd6e-4c82-8d49-f5dbcfcc950d";
            request.locale = "en-us";
            request.version = "VS.90";
            request.requestedDocuments = document;

            response = proxy.GetContent(appId, request);
            primaryDocumentsBindingSource.DataSource =
                response.primaryDocuments[0].Any.InnerText;
            richTextContentControl.DataBindings.Add("Text",
                primaryDocumentsBindingSource.DataSource, "", true,
                System.Windows.Forms.DataSourceUpdateMode.OnValidation);
        }
        //</Snippet5>

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
