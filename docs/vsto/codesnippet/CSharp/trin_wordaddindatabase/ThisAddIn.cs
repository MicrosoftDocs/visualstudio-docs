using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Tools.Word.Extensions;

namespace Trin_WordAddInDatabase_O12
{
    public partial class ThisAddIn
    {
        // <Snippet1>
        private AdventureWorksLTDataSet adventureWorksDataSet;
        private AdventureWorksLTDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Microsoft.Office.Tools.Word.RichTextContentControl customerContentControl;
        private Microsoft.Office.Tools.Word.Controls.Button button1;
        private Microsoft.Office.Tools.Word.Controls.Button button2;
        // </Snippet1>


        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // <Snippet2>
            this.adventureWorksDataSet = new AdventureWorksLTDataSet();
            this.customerTableAdapter = new AdventureWorksLTDataSetTableAdapters.CustomerTableAdapter();
            this.customerTableAdapter.Fill(this.adventureWorksDataSet.Customer);
            this.customerBindingSource = new System.Windows.Forms.BindingSource();
            // </Snippet2>

            // <Snippet3>
            Word.Document currentDocument = this.Application.ActiveDocument;

            Document extendedDocument = Globals.Factory.GetVstoObject(currentDocument);

            // </Snippet3>
            
            // <Snippet4>
            extendedDocument.Paragraphs[1].Range.InsertParagraphBefore();
            extendedDocument.Paragraphs[1].Range.InsertParagraphBefore();
            extendedDocument.Paragraphs[1].Range.Text = 
                "The companies listed in the AdventureWorksLT database:   \n";
            extendedDocument.Paragraphs[2].Range.Text = "  "; 

            Word.Range range1 = extendedDocument.Paragraphs[2].Range.Characters.First;
            Word.Range range2 = extendedDocument.Paragraphs[2].Range.Characters.Last;
            Word.Range range3 = extendedDocument.Paragraphs[1].Range.Characters.Last;
            // </Snippet4>

            // <Snippet5>
            this.button1 = extendedDocument.Controls.AddButton(range1, 60, 15, "1");
            this.button1.Text = "Previous";
            this.button2 = extendedDocument.Controls.AddButton(range2, 60, 15, "2");
            this.button2.Text = "Next";

            this.customerContentControl = extendedDocument.Controls.AddRichTextContentControl(
                range3, "richTextContentControl1");
            // </Snippet5>

            // <Snippet6>
            this.customerBindingSource.DataSource = this.adventureWorksDataSet.Customer;
            this.customerContentControl.DataBindings.Add("Text", this.customerBindingSource, 
                "CompanyName", true, this.customerContentControl.DataBindings.DefaultDataSourceUpdateMode);
            
            this.button1.Click += new EventHandler(button1_Click);
            this.button2.Click += new EventHandler(button2_Click);
            // </Snippet6>
         
        }

        // <Snippet7>
        void button1_Click(object sender, EventArgs e)
        {
            this.customerBindingSource.MovePrevious();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.customerBindingSource.MoveNext();
        }
        // </Snippet7>
        

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
