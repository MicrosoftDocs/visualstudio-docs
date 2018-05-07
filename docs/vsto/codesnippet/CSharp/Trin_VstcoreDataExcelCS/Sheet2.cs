using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreDataExcelCS
{
    public partial class Sheet2
    {
        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(Sheet2_Startup);
        }


        //---------------------------------------------------------------------
        private void Sheet2_Startup(object sender, System.EventArgs e)
        {
            // TODO: Delete this line of code to remove the default AutoFill for 'northwindDataSet.Order Details'.
            if (this.NeedsFill("northwindDataSet"))
            {
                this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            }
            // TODO: Delete this line of code to remove the default AutoFill for 'northwindDataSet.Orders'.
            if (this.NeedsFill("northwindDataSet"))
            {
                this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            }


            //<Snippet15>
            this.button1.Text = "<";
            this.button2.Text = ">";
            //</Snippet15>


            //<Snippet16>
            this.button1.Click += new EventHandler(button1_Click);
            this.button2.Click += new EventHandler(button2_Click);
            //</Snippet16>
        }


        //---------------------------------------------------------------------
        //<Snippet17>
        private void button1_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.MovePrevious();
        }
        //</Snippet17>


        //---------------------------------------------------------------------
        //<Snippet18>
        private void button2_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.MoveNext();
        }
        //</Snippet18>
    }
}
