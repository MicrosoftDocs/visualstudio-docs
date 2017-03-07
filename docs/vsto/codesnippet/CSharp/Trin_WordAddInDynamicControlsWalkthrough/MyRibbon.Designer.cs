namespace Trin_WordAddInDynamicControlsWalkthrough
{
    partial class MyRibbon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.addButtonCheckBox = this.Factory.CreateRibbonCheckBox();
            this.addRichTextCheckBox = this.Factory.CreateRibbonCheckBox();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.addButtonCheckBox);
            this.group1.Items.Add(this.addRichTextCheckBox);
            this.group1.Label = "Add Controls";
            this.group1.Name = "group1";
            // 
            // addButtonCheckBox
            // 
            this.addButtonCheckBox.Label = "Add Button";
            this.addButtonCheckBox.Name = "addButtonCheckBox";
            this.addButtonCheckBox.Click += this.addButtonCheckBox_Click;
            // 
            // addRichTextCheckBox
            // 
            this.addRichTextCheckBox.Label = "Add Rich Text Control";
            this.addRichTextCheckBox.Name = "addRichTextCheckBox";
            this.addRichTextCheckBox.Click += this.addRichTextCheckBox_Click;
            // 
            // MyRibbon
            // 
            this.Name = "MyRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += this.MyRibbon_Load;
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox addButtonCheckBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox addRichTextCheckBox;
    }

    partial class ThisRibbonCollection : Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection
    {
        internal MyRibbon MyRibbon
        {
            get { return this.GetRibbon<MyRibbon>(); }
        }
    }
}
