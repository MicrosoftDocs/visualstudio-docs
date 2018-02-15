namespace Trin_VstcoreActionsPaneWordCS
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class AddTextControl
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
            this.toBox=new System.Windows.Forms.TextBox();
            this.fromBox=new System.Windows.Forms.TextBox();
            this.subjectBox=new System.Windows.Forms.TextBox();
            this.insertText=new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toBox
            // 
            this.toBox.Location=new System.Drawing.Point(4, 4);
            this.toBox.Name="toBox";
            this.toBox.Size=new System.Drawing.Size(100, 20);
            this.toBox.TabIndex=0;
            // 
            // fromBox
            // 
            this.fromBox.Location=new System.Drawing.Point(4, 31);
            this.fromBox.Name="fromBox";
            this.fromBox.Size=new System.Drawing.Size(100, 20);
            this.fromBox.TabIndex=1;
            // 
            // subjectBox
            // 
            this.subjectBox.Location=new System.Drawing.Point(4, 58);
            this.subjectBox.Name="subjectBox";
            this.subjectBox.Size=new System.Drawing.Size(100, 20);
            this.subjectBox.TabIndex=2;
            // 
            // insertText
            // 
            this.insertText.Location=new System.Drawing.Point(4, 98);
            this.insertText.Name="insertText";
            this.insertText.Size=new System.Drawing.Size(75, 23);
            this.insertText.TabIndex=3;
            this.insertText.Text="insertText";
            this.insertText.UseVisualStyleBackColor=true;
            this.insertText.Click+=new System.EventHandler(this.insertText_Click);
            // 
            // AddTextControl
            // 
            this.Controls.Add(this.insertText);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.toBox);
            this.Name="AddTextControl";
            this.Size=new System.Drawing.Size(170, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Button insertText;
    }
}
