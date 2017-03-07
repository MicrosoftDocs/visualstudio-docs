namespace Trin_VstcoreActionsPaneWordCS
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
            this.components=new System.ComponentModel.Container();
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label productNameLabel;
            this.northwindDataSet=new Trin_VstcoreActionsPaneWordCS.NorthwindDataSet();
            this.suppliersBindingSource=new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter=new Trin_VstcoreActionsPaneWordCS.NorthwindDataSetTableAdapters.SuppliersTableAdapter();
            this.companyNameComboBox=new System.Windows.Forms.ComboBox();
            this.productsBindingSource=new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter=new Trin_VstcoreActionsPaneWordCS.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.productNameListBox=new System.Windows.Forms.ListBox();
            this.Insert=new System.Windows.Forms.Button();
            this.fKProductsSuppliersBindingSource=new System.Windows.Forms.BindingSource(this.components);
            companyNameLabel=new System.Windows.Forms.Label();
            productNameLabel=new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsSuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName="NorthwindDataSet";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember="Suppliers";
            this.suppliersBindingSource.DataSource=this.northwindDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill=true;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize=true;
            companyNameLabel.Location=new System.Drawing.Point(13, 15);
            companyNameLabel.Name="companyNameLabel";
            companyNameLabel.Size=new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex=1;
            companyNameLabel.Text="Company Name:";
            // 
            // companyNameComboBox
            // 
            this.companyNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "CompanyName", true));
            this.companyNameComboBox.DataSource=this.suppliersBindingSource;
            this.companyNameComboBox.DisplayMember="CompanyName";
            this.companyNameComboBox.FormattingEnabled=true;
            this.companyNameComboBox.Location=new System.Drawing.Point(16, 40);
            this.companyNameComboBox.Name="companyNameComboBox";
            this.companyNameComboBox.Size=new System.Drawing.Size(171, 21);
            this.companyNameComboBox.TabIndex=2;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember="Products";
            this.productsBindingSource.DataSource=this.northwindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill=true;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize=true;
            productNameLabel.Location=new System.Drawing.Point(13, 74);
            productNameLabel.Name="productNameLabel";
            productNameLabel.Size=new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex=3;
            productNameLabel.Text="Product Name:";
            // 
            // productNameListBox
            // 
            this.productNameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productsBindingSource, "ProductName", true));
            this.productNameListBox.DataSource=this.fKProductsSuppliersBindingSource;
            this.productNameListBox.DisplayMember="ProductName";
            this.productNameListBox.FormattingEnabled=true;
            this.productNameListBox.Location=new System.Drawing.Point(16, 90);
            this.productNameListBox.Name="productNameListBox";
            this.productNameListBox.Size=new System.Drawing.Size(171, 95);
            this.productNameListBox.TabIndex=4;
            // 
            // Insert
            // 
            this.Insert.Location=new System.Drawing.Point(16, 202);
            this.Insert.Name="Insert";
            this.Insert.Size=new System.Drawing.Size(75, 23);
            this.Insert.TabIndex=5;
            this.Insert.Text="Insert";
            this.Insert.UseVisualStyleBackColor=true;
            // 
            // fKProductsSuppliersBindingSource
            // 
            this.fKProductsSuppliersBindingSource.DataMember="FK_Products_Suppliers";
            this.fKProductsSuppliersBindingSource.DataSource=this.suppliersBindingSource;
            // 
            // ActionsControl
            // 
            this.Controls.Add(this.Insert);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameListBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameComboBox);
            this.Name="ActionsControl";
            this.Size=new System.Drawing.Size(248, 234);
            this.Load+=new System.EventHandler(this.ActionsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsSuppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private Trin_VstcoreActionsPaneWordCS.NorthwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.ComboBox companyNameComboBox;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Trin_VstcoreActionsPaneWordCS.NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ListBox productNameListBox;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.BindingSource fKProductsSuppliersBindingSource;

    }
}
