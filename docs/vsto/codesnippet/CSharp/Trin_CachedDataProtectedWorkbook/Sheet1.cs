using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Trin_CachedDataProtectedWorkbook
{
    public partial class Sheet1
    {


        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Shutdown += new System.EventHandler(this.Sheet1_Shutdown);
            this.Startup += new System.EventHandler(this.Sheet1_Startup);

        }

        #endregion

        

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.ThisWorkbook.Protect(Globals.ThisWorkbook.securelyStoredPassword, 
                true, true);
            //this.Protect(Globals.ThisWorkbook.securelyStoredPassword, true, true,
            //    true, false, true, true, false, true, false, true, false,
            //    true, false, true, false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Globals.ThisWorkbook.CachedString = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Globals.ThisWorkbook.CachedString);
        }
    }
}
