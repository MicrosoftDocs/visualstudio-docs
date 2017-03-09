namespace Trin_VstcoreActionsPaneExcelCS
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class ActionsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components=null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            this.comboBox1=new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled=true;
            this.comboBox1.Location=new System.Drawing.Point(15, 19);
            this.comboBox1.Name="comboBox1";
            this.comboBox1.Size=new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex=0;
            // 
            // ActionsControl
            // 
            this.Controls.Add(this.comboBox1);
            this.Name="ActionsControl";
            this.Size=new System.Drawing.Size(210, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
    }
}
