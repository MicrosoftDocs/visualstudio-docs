using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace WordDocument1
{
    public partial class ThisDocument
    {
        //<Snippet1>
        [CachedAttribute]
        public string CachedString = "This string is cached in the document.";

        //<Snippet2>
        private Word.WdProtectionType protectionTypeValue;

        protected override void UnprotectDocument()
        {
            if (this.ProtectionType != Word.WdProtectionType.wdNoProtection)
            {
                protectionTypeValue = this.ProtectionType;
                this.Unprotect(ref securelyStoredPassword);
            }
        }
        //</Snippet2>

        //<Snippet3>
        protected override void ProtectDocument()
        {
            this.Protect(protectionTypeValue, ref missing,
                ref securelyStoredPassword, ref missing, ref missing);
        }
        //</Snippet3>
        //</Snippet1>


        // Everything below here is "infrastructure" code to test out the 
        // snippets.
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            textBox1.Text = CachedString;
        }

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
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.Shutdown += new System.EventHandler(this.ThisDocument_Shutdown);
            this.Startup += new System.EventHandler(this.ThisDocument_Startup);

        }

        #endregion

        private object securelyStoredPassword = GetPassword();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Protect(Word.WdProtectionType.wdAllowOnlyReading, ref missing,
                    ref securelyStoredPassword, ref missing, ref missing);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.CachedString = textBox1.Text;
        }

        private static string GetPassword()
        {
            return "secure";
        }
    }
}
