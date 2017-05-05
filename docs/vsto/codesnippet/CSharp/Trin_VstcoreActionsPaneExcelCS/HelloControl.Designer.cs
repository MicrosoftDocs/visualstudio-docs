namespace Trin_VstcoreActionsPaneExcelCS
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class HelloControl
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
            this.button1=new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location=new System.Drawing.Point(20, 18);
            this.button1.Name="button1";
            this.button1.Size=new System.Drawing.Size(75, 23);
            this.button1.TabIndex=0;
            this.button1.Text="button1";
            this.button1.UseVisualStyleBackColor=true;
            this.button1.Click+=new System.EventHandler(this.button1_Click);
            // 
            // HelloControl
            // 
            this.Controls.Add(this.button1);
            this.Name="HelloControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}
