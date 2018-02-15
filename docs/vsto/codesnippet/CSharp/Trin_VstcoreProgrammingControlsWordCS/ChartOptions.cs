using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trin_VstcoreProgrammingControlsWordCS
{
    public partial class ChartOptions : UserControl
    {
        //<Snippet9>
        public event EventHandler SelectionChanged;

        private Microsoft.Office.Interop.Graph.XlChartType selectedType =
            Microsoft.Office.Interop.Graph.XlChartType.xlColumnClustered;

        public Microsoft.Office.Interop.Graph.XlChartType Selection
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
        //</Snippet9>


        //<Snippet10>
        private void areaBlockChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlAreaStacked;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        //</Snippet10>


        //<Snippet11>
        private void barChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlBarClustered;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        //</Snippet11>


        //<Snippet12>
        private void columnChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlColumnClustered;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        //</Snippet12>


        //<Snippet13>
        private void lineChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlLineMarkers;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        //</Snippet13>


        //<Snippet14>
        public ChartOptions()
        {
            InitializeComponent();

            areaBlockChart.CheckedChanged += new EventHandler(areaBlockChart_CheckedChanged);
            barChart.CheckedChanged += new EventHandler(barChart_CheckedChanged);
            columnChart.CheckedChanged += new EventHandler(columnChart_CheckedChanged);
            lineChart.CheckedChanged += new EventHandler(lineChart_CheckedChanged);
        }
        //</Snippet14>
    }
}
