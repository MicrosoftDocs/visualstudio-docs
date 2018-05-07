namespace Trin_VstcoreActionsPaneWordCS
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class ShowAllControl
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
            this.showCheck=new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // showCheck
            // 
            this.showCheck.AutoSize=true;
            this.showCheck.Location=new System.Drawing.Point(14, 20);
            this.showCheck.Name="showCheck";
            this.showCheck.Size=new System.Drawing.Size(82, 17);
            this.showCheck.TabIndex=0;
            this.showCheck.Text="showCheck";
            this.showCheck.UseVisualStyleBackColor=true;
            // 
            // ShowAllControl
            // 
            this.Controls.Add(this.showCheck);
            this.Name="ShowAllControl";
            this.Size=new System.Drawing.Size(170, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox showCheck;

    }
}
