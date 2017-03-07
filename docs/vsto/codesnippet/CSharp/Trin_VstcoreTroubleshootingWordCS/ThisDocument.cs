using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
//<Snippet2>
using Word = Microsoft.Office.Interop.Word;
//</Snippet2>
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreTroubleshootingWordCS
{
    public partial class ThisDocument
    {
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(ThisDocument_Startup);
            this.Shutdown+=new System.EventHandler(ThisDocument_Shutdown);
        }

        class Document{}


        //---------------------------------------------------------------------
        void Test2()
        {
            //<Snippet4>
            Document doc;  // Class is ambiguous
            //</Snippet4>

            doc = new Document();
        }


        //---------------------------------------------------------------------
        void Test1()
        {
            //<Snippet3>
            Word.Document doc;
            //</Snippet3>

            doc = new Microsoft.Office.Interop.Word.Document();
        }
        

        //---------------------------------------------------------------------
        //<Snippet1>
        SampleForm form1;

        private void OpenForm()
        {
            form1 = new SampleForm();
            form1.Show();  // Show form modelessly.
        }

        private void ForceShutdown()
        {
            // Completely close the form if it is still running.
            // Note that hiding the form might not work by itself.

            if (form1 != null)
            {
                form1.Close();
                form1.Dispose();
                form1 = null;
            }
            object saveChanges = Word.WdSaveOptions.wdSaveChanges; 
            this.Close(ref saveChanges, ref missing, ref missing);
        }
        //</Snippet1>
    }
}
