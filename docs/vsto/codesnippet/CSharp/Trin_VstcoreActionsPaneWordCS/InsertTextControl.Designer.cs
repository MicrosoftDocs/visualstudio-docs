namespace Trin_VstcoreActionsPaneWordCS
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class InsertTextControl
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
            this.addText=new System.Windows.Forms.Button();
            this.getName=new System.Windows.Forms.TextBox();
            this.getAddress=new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addText
            // 
            this.addText.Location=new System.Drawing.Point(23, 74);
            this.addText.Name="addText";
            this.addText.Size=new System.Drawing.Size(75, 23);
            this.addText.TabIndex=0;
            this.addText.Text="addText";
            this.addText.UseVisualStyleBackColor=true;
            this.addText.Click+=new System.EventHandler(this.addText_Click);
            // 
            // getName
            // 
            this.getName.Location=new System.Drawing.Point(13, 16);
            this.getName.Name="getName";
            this.getName.Size=new System.Drawing.Size(100, 20);
            this.getName.TabIndex=1;
            // 
            // getAddress
            // 
            this.getAddress.Location=new System.Drawing.Point(13, 43);
            this.getAddress.Name="getAddress";
            this.getAddress.Size=new System.Drawing.Size(100, 20);
            this.getAddress.TabIndex=2;
            // 
            // InsertTextControl
            // 
            this.Controls.Add(this.getAddress);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.addText);
            this.Name="InsertTextControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button addText;
        internal System.Windows.Forms.TextBox getName;
        internal System.Windows.Forms.TextBox getAddress;

    }
}
