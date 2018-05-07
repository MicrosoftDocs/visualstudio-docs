using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace EmployeeControls
{
    public partial class ThisDocument
    {
        //<Snippet1>
        [CachedAttribute()]
        public string employeeXMLPartID = string.Empty;
        private Office.CustomXMLPart employeeXMLPart;
        private const string prefix = "xmlns:ns='http://schemas.microsoft.com/vsto/samples'";
        //</Snippet1>

        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            //<Snippet2>
            string xmlData = GetXmlFromResource();

            if (xmlData != null)
            {
                AddCustomXmlPart(xmlData);
                BindControlsToCustomXmlPart();
            }
            //</Snippet2>

            this.plainTextContentControl1.Validated += new EventHandler(plainTextContentControl1_Validated);
            this.plainTextContentControl1.Validating += new System.ComponentModel.CancelEventHandler(plainTextContentControl1_Validating);
            this.plainTextContentControl1.ContentUpdating += plainTextContentControl1_ContentUpdating;
            this.plainTextContentControl1.StoreUpdating += plainTextContentControl1_StoreUpdating;
        }

        //<Snippet3>
        private string GetXmlFromResource()
        {
            System.Reflection.Assembly asm =
                System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream stream1 = asm.GetManifestResourceStream(
                "EmployeeControls.employees.xml");

            using (System.IO.StreamReader resourceReader =
                    new System.IO.StreamReader(stream1))
            {
                if (resourceReader != null)
                {
                    return resourceReader.ReadToEnd();
                }
            }

            return null;
        }
        //</Snippet3>

        //<Snippet4>
        private void AddCustomXmlPart(string xmlData)
        {
            if (xmlData != null)
            {
                employeeXMLPart = this.CustomXMLParts.SelectByID(employeeXMLPartID);
                if (employeeXMLPart == null)
                {
                    employeeXMLPart = this.CustomXMLParts.Add(xmlData);
                    employeeXMLPart.NamespaceManager.AddNamespace("ns", 
                        @"http://schemas.microsoft.com/vsto/samples");
                    employeeXMLPartID = employeeXMLPart.Id;
                }
            }
        }
        //</Snippet4>

        //<Snippet5>
        private void BindControlsToCustomXmlPart()
        {
            string xPathName = "ns:employees/ns:employee/ns:name";
            this.plainTextContentControl1.XMLMapping.SetMapping(xPathName,
                prefix, employeeXMLPart);

            string xPathDate = "ns:employees/ns:employee/ns:hireDate";
            this.datePickerContentControl1.DateDisplayFormat = "MMMM d, yyyy";
            this.datePickerContentControl1.XMLMapping.SetMapping(xPathDate,
                prefix, employeeXMLPart);

            string xPathTitle = "ns:employees/ns:employee/ns:title";
            this.dropDownListContentControl1.XMLMapping.SetMapping(xPathTitle,
                prefix, employeeXMLPart);
        }
        //</Snippet5>

        //<Snippet6>
        void plainTextContentControl1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Microsoft.Office.Tools.Word.PlainTextContentControl control =
                sender as Microsoft.Office.Tools.Word.PlainTextContentControl;

            if (control != null)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\d");
                if (regex.IsMatch(control.Text))
                {
                    MessageBox.Show("Invalid name. Names cannot contain integers.");
                    e.Cancel = true;
                }
            }
        }

        void plainTextContentControl1_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("The name is valid.");
        }
        //</Snippet6>

        //<Snippet7>
        void plainTextContentControl1_StoreUpdating(object sender, 
            Microsoft.Office.Tools.Word.ContentControlStoreUpdatingEventArgs e)
        {
            MessageBox.Show("The control was changed to the following value: \n\n" +
                e.Content + "\n\nThis value is about to be written to the node that is bound to this control.");
        }

        void plainTextContentControl1_ContentUpdating(object sender, 
            Microsoft.Office.Tools.Word.ContentControlContentUpdatingEventArgs e)
        {
            MessageBox.Show("The node that is bound to this control was changed to the following value: \n\n" +
                e.Content + "\n\nThis value is about to be written to this control.");
        }
        //</Snippet7>

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Shutdown += new System.EventHandler(this.ThisDocument_Shutdown);
            this.Startup += new System.EventHandler(this.ThisDocument_Startup);

        }

        #endregion
    }
}
