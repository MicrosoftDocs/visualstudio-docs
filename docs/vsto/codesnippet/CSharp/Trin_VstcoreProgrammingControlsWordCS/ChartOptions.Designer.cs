namespace Trin_VstcoreProgrammingControlsWordCS
{
    partial class ChartOptions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components=null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnChart=new System.Windows.Forms.RadioButton();
            this.barChart=new System.Windows.Forms.RadioButton();
            this.lineChart=new System.Windows.Forms.RadioButton();
            this.areaBlockChart=new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // columnChart
            // 
            this.columnChart.AutoSize=true;
            this.columnChart.Location=new System.Drawing.Point(14, 15);
            this.columnChart.Name="columnChart";
            this.columnChart.Size=new System.Drawing.Size(84, 17);
            this.columnChart.TabIndex=0;
            this.columnChart.Text="columnChart";
            this.columnChart.UseVisualStyleBackColor=true;
            // 
            // barChart
            // 
            this.barChart.AutoSize=true;
            this.barChart.Location=new System.Drawing.Point(14, 39);
            this.barChart.Name="barChart";
            this.barChart.Size=new System.Drawing.Size(65, 17);
            this.barChart.TabIndex=1;
            this.barChart.Text="barChart";
            this.barChart.UseVisualStyleBackColor=true;
            // 
            // lineChart
            // 
            this.lineChart.AutoSize=true;
            this.lineChart.Location=new System.Drawing.Point(14, 63);
            this.lineChart.Name="lineChart";
            this.lineChart.Size=new System.Drawing.Size(66, 17);
            this.lineChart.TabIndex=2;
            this.lineChart.Text="lineChart";
            this.lineChart.UseVisualStyleBackColor=true;
            // 
            // areaBlockChart
            // 
            this.areaBlockChart.AutoSize=true;
            this.areaBlockChart.Location=new System.Drawing.Point(14, 87);
            this.areaBlockChart.Name="areaBlockChart";
            this.areaBlockChart.Size=new System.Drawing.Size(98, 17);
            this.areaBlockChart.TabIndex=3;
            this.areaBlockChart.Text="areaBlockChart";
            this.areaBlockChart.UseVisualStyleBackColor=true;
            // 
            // ChartOptions
            // 
            this.AutoScaleDimensions=new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.areaBlockChart);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.columnChart);
            this.Name="ChartOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton columnChart;
        private System.Windows.Forms.RadioButton barChart;
        private System.Windows.Forms.RadioButton lineChart;
        private System.Windows.Forms.RadioButton areaBlockChart;
    }
}
