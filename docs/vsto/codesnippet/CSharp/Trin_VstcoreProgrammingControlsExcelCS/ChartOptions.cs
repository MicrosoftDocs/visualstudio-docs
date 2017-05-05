using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trin_VstcoreProgrammingControlsExcelCS
{
    public partial class ChartOptions : UserControl
    {
        //<Snippet13>
        public event EventHandler SelectionChanged;

        private Microsoft.Office.Interop.Excel.XlChartType selectedType =
            Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;

        public Microsoft.Office.Interop.Excel.XlChartType Selection
        {
            get
            {
                return this.selectedType;
            }
            set
            {
                this.selectedType = value;
            }
        }
        //</Snippet13>


        //<Snippet14>
        private void areaBlockChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlAreaStacked;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        //</Snippet14>


        //<Snippet15>
        private void barChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlBarClustered;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        //</Snippet15>


        //<Snippet16>
        private void columnChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        //</Snippet16>


        //<Snippet17>
        private void lineChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlLineMarkers;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        //</Snippet17>


        //<Snippet18>
        public ChartOptions()
        {
            InitializeComponent();

            areaBlockChart.CheckedChanged += new EventHandler(areaBlockChart_CheckedChanged);
            barChart.CheckedChanged += new EventHandler(barChart_CheckedChanged);
            columnChart.CheckedChanged += new EventHandler(columnChart_CheckedChanged);
            lineChart.CheckedChanged += new EventHandler(lineChart_CheckedChanged);
        }
        //</Snippet18>
    }
}
