using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Word=Microsoft.Office.Interop.Word;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreProgrammingWordCS
{
    public partial class ThisDocument
    {
        void TestProperties()
        {
            //<Snippet1>
            Microsoft.Office.Core.DocumentProperties properties;

            properties = (Microsoft.Office.Core.DocumentProperties)
                Globals.ThisDocument.BuiltInDocumentProperties; 
            //</Snippet1>

            //<Snippet2>
            // Set the Subject property. 
            properties["Subject"].Value = "Whitepaper"; 
            //</Snippet2>
        }



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
    }
}
