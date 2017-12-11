namespace Trin_Excel_Dynamic_Controls
{
    partial class Ribbon1
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
            this.Button = this.Factory.CreateRibbonCheckBox();
            this.NamedRange = this.Factory.CreateRibbonCheckBox();
            this.ListObject = this.Factory.CreateRibbonCheckBox();
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
            this.group1.Items.Add(this.Button);
            this.group1.Items.Add(this.NamedRange);
            this.group1.Items.Add(this.ListObject);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // Button
            // 
            this.Button.Label = "Button";
            this.Button.Name = "Button";
            this.Button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button_Click);

            // 
            // NamedRange
            // 
            this.NamedRange.Label = "NamedRange";
            this.NamedRange.Name = "NamedRange";
            this.NamedRange.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.NamedRange_Click);
            // 
            // ListObject
            // 
            this.ListObject.Label = "ListObject";
            this.ListObject.Name = "ListObject";
            this.ListObject.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ListObject_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox Button;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox NamedRange;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ListObject;
    }

    partial class ThisRibbonCollection : Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
