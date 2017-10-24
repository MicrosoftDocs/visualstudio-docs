using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trin_VstcoreActionsPaneWordCS
{
    partial class ActionsControl : UserControl
    {
        //---------------------------------------------------------------------
        //<Snippet1>
        private void ActionsControl_Load(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
        }
        //</Snippet1>


        //---------------------------------------------------------------------
        //<Snippet2>
        static void SetHeadings(Microsoft.Office.Interop.Word.Cell tblCell, string text)
        {
            tblCell.Range.Text = text;
            tblCell.Range.Font.Bold = 1;
            tblCell.Range.ParagraphFormat.Alignment = 
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
        }
        //</Snippet2>


        //---------------------------------------------------------------------
        //<Snippet3>
        private void AddData(System.Data.DataRow row, string companyName)
        {
            object missing = System.Type.Missing;

            // Create a table if it doesn't already exist.
            if (Globals.ThisDocument.Tables.Count == 0)
            {
                try
                {
                    // Create a table.
                    Microsoft.Office.Interop.Word.Table tbl = Globals.ThisDocument.Tables.Add
                        (Globals.ThisDocument.Application.Selection.Range, 1, 4, ref missing, ref missing);

                    // Insert headings.
                    SetHeadings(tbl.Cell(1, 1), "Company Name");
                    SetHeadings(tbl.Cell(1, 2), "Product Name");
                    SetHeadings(tbl.Cell(1, 3), "Quantity");
                    SetHeadings(tbl.Cell(1, 4), "Unit Price");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem creating Products table: " + ex.Message, 
                        "Actions Pane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Add data from data row to the table.
            Microsoft.Office.Interop.Word.Selection selection = Globals.ThisDocument.Application.Selection;

            if (selection.Tables.Count > 0)
            {
                Microsoft.Office.Interop.Word.Row newRow = Globals.ThisDocument.Tables[1].Rows.Add(ref missing);

                newRow.Range.Font.Bold = 0;

                newRow.Range.ParagraphFormat.Alignment = 
                    Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                newRow.Cells[4].Range.ParagraphFormat.Alignment =
                    Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;

                newRow.Cells[1].Range.Text = companyName;
                newRow.Cells[2].Range.Text = row["ProductName"].ToString();
                newRow.Cells[3].Range.Text = row["QuantityPerUnit"].ToString();
                newRow.Cells[4].Range.Text = Math.Round(Convert.ToDouble(row["UnitPrice"])).ToString("#,##0.00");
            }
            else
            {
                MessageBox.Show("Cursor must be within a table.", 
                    "Actions Pane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //</Snippet3>
        

        //---------------------------------------------------------------------
        //<Snippet4>
        private void Insert_Click(object sender, System.EventArgs e)
        {
            System.Data.DataTable tbl = northwindDataSet.Products;
            System.Data.DataRow[] rows;

            // Check if a product is selected.
            if (this.productNameListBox.SelectedIndex >= 0)
            {
                System.Data.DataRowView productRow = (System.Data.DataRowView)this.productNameListBox.SelectedItem;

                string product = productRow.Row["ProductName"].ToString();
                string company = this.companyNameComboBox.Text;

                // Return the data row from the selected product.
                rows = tbl.Select("[ProductName] = '" + product.Replace("'", "''") + "'");

                this.AddData(rows[0], company);
            }
            else
            {
                MessageBox.Show("Please select a product.", "Actions Pane", MessageBoxButtons.OK);
            }
        }
        //</Snippet4>


        //---------------------------------------------------------------------
        public ActionsControl()
        {
            InitializeComponent();

            //<Snippet5>
            this.Insert.Click += new EventHandler(Insert_Click);
            //</Snippet5>

            //<Snippet33>
            this.Load += new EventHandler(ActionsControl_Load);
            //</Snippet33>
        }
    }
}
