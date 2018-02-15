using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel=Microsoft.Office.Interop.Excel;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreDataExcelCS
{
    public partial class Sheet1
    {
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
        }


        //---------------------------------------------------------------------
        //<Snippet11>
        [Microsoft.VisualStudio.Tools.Applications.Runtime.Cached()]
        public DataSet employeesDataSet;
        //</Snippet11>


        //---------------------------------------------------------------------
        //<Snippet12>
        public DataSet dataSet1;
        //</Snippet12>

        private void Test2()
        {
            //<Snippet13>
            dataSet1 = new DataSet();

            if (!this.IsCached("dataSet1"))
            {
                this.StartCaching("dataSet1");
            }
            //</Snippet13>


            //<Snippet14>
            if (this.IsCached("dataSet1"))
            {
                this.StopCaching("dataSet1");
            }
            //</Snippet14>
        }


        //---------------------------------------------------------------------
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {

            //<Snippet2>
            this.button1.Text = "|<";
            this.button2.Text = "<";
            this.button3.Text = ">";
            this.button4.Text = ">|";
            //</Snippet2>


            //<Snippet3>
            this.button1.Click += new EventHandler(button1_Click);
            this.button2.Click += new EventHandler(button2_Click);
            this.button3.Click += new EventHandler(button3_Click);
            this.button4.Click += new EventHandler(button4_Click);
            //</Snippet3>
        }


        //---------------------------------------------------------------------
        //<Snippet4>
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.customersBindingSource.MoveFirst();
        }
        //</Snippet4>

        //<Snippet5>
        private void button2_Click(object sender, System.EventArgs e)
        {
            this.customersBindingSource.MovePrevious(); 
        }
        //</Snippet5>

        //<Snippet6>
        private void button3_Click(object sender, System.EventArgs e)
        {
            this.customersBindingSource.MoveNext();
        }
        //</Snippet6>

        //<Snippet7>
        private void button4_Click(object sender, System.EventArgs e)
        {
            this.customersBindingSource.MoveLast();
        }
        //</Snippet7>


        //---------------------------------------------------------------------
        private void Test1()
        {
            //<Snippet1>
            this.namedRange1.DataBindings["Value2"].WriteValue();
            //</Snippet1>

            //<Snippet19>
            this.namedRange1.DataBindings["Value2"].DataSourceUpdateMode = 
                DataSourceUpdateMode.OnPropertyChanged;
            //</Snippet19>

            //<Snippet20>
            this.customersBindingSource.EndEdit();
            //</Snippet20>

            //<Snippet21>
            this.customersTableAdapter.Update(this.northwindDataSet.Customers);
            //</Snippet21>
        }
    }
}
