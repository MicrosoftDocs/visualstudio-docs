using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Word=Microsoft.Office.Interop.Word;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreDataWordCS
{
    public partial class ThisDocument
    {
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(ThisDocument_Startup);
        }

        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            CheckSchema();
        }

        //---------------------------------------------------------------------
        //<Snippet1>
        // Ensure that the schema is in the library and registered with the document.
        private bool CheckSchema()
        {
            const string namespaceUri = "http://schemas.contoso.com/projects";
            bool namespaceFound = false;
            bool namespaceRegistered = false;

            foreach (Word.XMLNamespace n in Application.XMLNamespaces)
            {
                if (n.URI == namespaceUri)
                {
                    namespaceFound = true;
                }
            }

            if (!namespaceFound)
            {
                MessageBox.Show("XML Schema is not in library.");
                return false;
            }

            foreach (Word.XMLSchemaReference r in this.XMLSchemaReferences) 
            {
                if (r.NamespaceURI == namespaceUri)
                {
                    namespaceRegistered = true;
                }
            }

            if (!namespaceRegistered)
            {
                MessageBox.Show("XML Schema is not registered for this document.");
                return false;
            }
            
            return true;
        }
        //</Snippet1>
    }
}
