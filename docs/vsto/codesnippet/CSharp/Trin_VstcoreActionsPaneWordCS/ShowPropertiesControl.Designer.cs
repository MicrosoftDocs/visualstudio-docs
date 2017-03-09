namespace Trin_VstcoreActionsPaneWordCS
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class ShowPropertiesControl
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
            this.tableProperties=new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableProperties
            // 
            this.tableProperties.Location=new System.Drawing.Point(17, 15);
            this.tableProperties.Name="tableProperties";
            this.tableProperties.Size=new System.Drawing.Size(75, 23);
            this.tableProperties.TabIndex=0;
            this.tableProperties.Text="tableProperties";
            this.tableProperties.UseVisualStyleBackColor=true;
            this.tableProperties.Click+=new System.EventHandler(this.tableProperties_Click);
            // 
            // ShowPropertiesControl
            // 
            this.Controls.Add(this.tableProperties);
            this.Name="ShowPropertiesControl";
            this.Size=new System.Drawing.Size(170, 50);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button tableProperties;

    }
}
