using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Trin_BindableComponent
{
    public partial class Sheet1
    {
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            SetBindingContext();
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        // Snippet1 - BindableComponent class overview
        // Snippet2 - DataBindings property
        // Snippet3 - BindingContext property

        // <Snippet1>
        // <Snippet2>
        private Microsoft.Office.Tools.Excel.NamedRange namedRange1;
        private Microsoft.Office.Tools.Excel.Controls.Button button1;
        private string[] customerNames = 
            { "Reggie", "Sally", "Henry", "Christine" };
        private DataSet ds;

        private void SetBindingContext()
        {
            namedRange1 = this.Controls.AddNamedRange(
                this.Range["A1"], "namedRange1");

            // Create a button that scrolls through the data 
            // displayed in the NamedRange.
            button1 = this.Controls.AddButton(50, 20, 100, 20,
                "button1");
            button1.Text = "Display next item";
            button1.Click += new EventHandler(button1_Click);

            // Create a data table with one column.
            ds = new DataSet();
            DataTable table = ds.Tables.Add("Customers");
            DataColumn column1 = new DataColumn("Names", typeof(string));
            table.Columns.Add(column1);

            // Add the names to the table.
            DataRow row;
            for (int i = 0; i < customerNames.Length; i++)
            {
                row = table.NewRow();
                row["Names"] = customerNames[i];
                table.Rows.Add(row);
            }

            // Create a new Binding that links the Value2 property
            // of the NamedRange and the Names column.
            //<Snippet4>
            Binding binding1 = new Binding("Value2", ds, "Customers.Names", true);
            namedRange1.DataBindings.Add(binding1);
            //</Snippet4>
        }
        // </Snippet2>

        // <Snippet3>
        // Displays the next data item in the NamedRange.
        void button1_Click(object sender, EventArgs e)
        {
            if (namedRange1.BindingContext != null)
            {
                BindingManagerBase bindingManager1 =
                    namedRange1.BindingContext[ds, "Customers"];

                // Display the next item.
                if (bindingManager1.Position < bindingManager1.Count - 1)
                {
                    bindingManager1.Position++;
                }

                // Display the first item.
                else
                {
                    bindingManager1.Position = 0;
                }
            }
        }
        // </Snippet3>
        // </Snippet1>

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
            this.Shutdown += new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion

    }
}
