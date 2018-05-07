using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreCreatingExcelCS
{
    public partial class Sheet1
    {
        //---------------------------------------------------------------------
        //<Snippet12>
        static object SetPropertyInternational(object target, string name, params object[] args)
        {
            return target.GetType().InvokeMember(name,
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Public,
                null, target, args, new
                System.Globalization.CultureInfo(1033));
        }
        //</Snippet12>


        //---------------------------------------------------------------------
        //<Snippet15>
        static object GetPropertyInternational(object target, string name, params object[] args)
        {
            return target.GetType().InvokeMember(name,
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.GetProperty |
                System.Reflection.BindingFlags.Public,
                null, target, args, new 
                System.Globalization.CultureInfo(1033));
        }
        //</Snippet15>


        //---------------------------------------------------------------------
        void Test2()
        {
            //<Snippet13>
            Microsoft.Office.Tools.Excel.NamedRange NamedRange1 =
                this.Controls.AddNamedRange(this.Range["A5", missing], "NamedRange1");
            //</Snippet13>


            //<Snippet14>
            SetPropertyInternational(NamedRange1.InnerObject, "Formula", "=SUM(12, 34)");
            //</Snippet14>


            //<Snippet16>
            string formula = (string)
                GetPropertyInternational(NamedRange1.InnerObject, "Formula");

            MessageBox.Show(formula);
            //</Snippet16>
        }


        //---------------------------------------------------------------------
        private void Test()
        {
            //<Snippet6>    
            this.Range["A1"].Value2 = "05/12/04";
            //</Snippet6>    
        }
        
        
        //---------------------------------------------------------------------
        //<Snippet7>
        private void ConvertDate_Click(object sender, EventArgs e)
        {
            try
            {
                double dbl = (double)(this.Range["A5"].Value2);
                System.DateTime dt = System.DateTime.FromOADate(dbl);
                this.Range["A7"].Value2 = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //</Snippet7>


        private void Sheet1_Startup(object sender, System.EventArgs e)
        {

            //<Snippet11>
            System.Threading.Thread.CurrentThread.CurrentUICulture = 
                new System.Globalization.CultureInfo("de");
            //</Snippet11>


            //THIS SNIPPET USED BY MORE THAN ONE TOPIC
            //----------------------------------------
            //<Snippet10>
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(
                    Application.LanguageSettings.get_LanguageID(
                        Office.MsoAppLanguageID.msoLanguageIDUI));
            //</Snippet10>


            //<Snippet8>
            Microsoft.Office.Tools.Excel.NamedRange namedRange1 =
                this.Controls.AddNamedRange(this.Range["A1"], "namedRange1");
            //</Snippet8>

            //<Snippet9>
            namedRange1.Value2 = Properties.Resources.ListCreateUnscheduledOrder;
            //</Snippet9>
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
            this.Startup+=new System.EventHandler(Sheet1_Startup);
            this.Shutdown+=new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion

    }
}
