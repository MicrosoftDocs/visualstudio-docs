namespace Trin_Ribbon_ObjectModel_DOTNET4
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //<Snippet1>
        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
            if (System.DateTime.Now.Hour > 16)
            {
                Microsoft.Office.Tools.Ribbon.RibbonButton button =
                    this.Factory.CreateRibbonButton();
                button.Label = "New Button";
                group1.Items.Add(button);
            }
        }
        //</Snippet1>

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
            this.button1 = this.Factory.CreateRibbonButton();
            this.checkBox1 = this.Factory.CreateRibbonCheckBox();
            this.button2 = this.Factory.CreateRibbonButton();
            this.menu1 = this.Factory.CreateRibbonMenu();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "tab1";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.checkBox1);
            this.group1.Items.Add(this.button2);
            this.group1.Items.Add(this.menu1);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.Label = "button1";
            this.button1.Name = "button1";
            // 
            // menu1
            // 
            this.menu1.Description = "This is a cool description.";
            this.menu1.Dynamic = true;
            this.menu1.Items.Add(this.button2);
            this.menu1.ItemSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu1.Label = "menu1";
            this.menu1.Name = "menu1";
            this.menu1.ShowImage = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Label = "checkBox1";
            this.checkBox1.Name = "checkBox1";
            // 
            // customerButton
            // 
            this.button2.Label = "button2";
            this.button2.Name = "customerButton";
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

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;

    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
