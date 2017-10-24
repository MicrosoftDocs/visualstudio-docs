<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class ActionsControl
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.components = New System.ComponentModel.Container
Dim CompanyNameLabel As System.Windows.Forms.Label
Dim ProductNameLabel As System.Windows.Forms.Label
Me.NorthwindDataSet = New Trin_VstcoreActionsPaneWordVB.NorthwindDataSet
Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.SuppliersTableAdapter = New Trin_VstcoreActionsPaneWordVB.NorthwindDataSetTableAdapters.SuppliersTableAdapter
Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox
Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.ProductsTableAdapter = New Trin_VstcoreActionsPaneWordVB.NorthwindDataSetTableAdapters.ProductsTableAdapter
Me.ProductNameListBox = New System.Windows.Forms.ListBox
Me.Insert = New System.Windows.Forms.Button
Me.FKProductsSuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
CompanyNameLabel = New System.Windows.Forms.Label
ProductNameLabel = New System.Windows.Forms.Label
CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.FKProductsSuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'CompanyNameLabel
'
CompanyNameLabel.AutoSize = True
CompanyNameLabel.Location = New System.Drawing.Point(12, 16)
CompanyNameLabel.Name = "CompanyNameLabel"
CompanyNameLabel.Size = New System.Drawing.Size(85, 13)
CompanyNameLabel.TabIndex = 1
CompanyNameLabel.Text = "Company Name:"
'
'ProductNameLabel
'
ProductNameLabel.AutoSize = True
ProductNameLabel.Location = New System.Drawing.Point(12, 68)
ProductNameLabel.Name = "ProductNameLabel"
ProductNameLabel.Size = New System.Drawing.Size(78, 13)
ProductNameLabel.TabIndex = 3
ProductNameLabel.Text = "Product Name:"
'
'NorthwindDataSet
'
Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
'
'SuppliersBindingSource
'
Me.SuppliersBindingSource.DataMember = "Suppliers"
Me.SuppliersBindingSource.DataSource = Me.NorthwindDataSet
'
'SuppliersTableAdapter
'
Me.SuppliersTableAdapter.ClearBeforeFill = True
'
'CompanyNameComboBox
'
Me.CompanyNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "CompanyName", True))
Me.CompanyNameComboBox.DataSource = Me.SuppliersBindingSource
Me.CompanyNameComboBox.DisplayMember = "CompanyName"
Me.CompanyNameComboBox.FormattingEnabled = True
Me.CompanyNameComboBox.Location = New System.Drawing.Point(15, 32)
Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
Me.CompanyNameComboBox.Size = New System.Drawing.Size(171, 21)
Me.CompanyNameComboBox.TabIndex = 2
'
'ProductsBindingSource
'
Me.ProductsBindingSource.DataMember = "Products"
Me.ProductsBindingSource.DataSource = Me.NorthwindDataSet
'
'ProductsTableAdapter
'
Me.ProductsTableAdapter.ClearBeforeFill = True
'
'ProductNameListBox
'
Me.ProductNameListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ProductsBindingSource, "ProductName", True))
Me.ProductNameListBox.DataSource = Me.FKProductsSuppliersBindingSource
Me.ProductNameListBox.DisplayMember = "ProductName"
Me.ProductNameListBox.FormattingEnabled = True
Me.ProductNameListBox.Location = New System.Drawing.Point(15, 84)
Me.ProductNameListBox.Name = "ProductNameListBox"
Me.ProductNameListBox.Size = New System.Drawing.Size(171, 95)
Me.ProductNameListBox.TabIndex = 4
'
'Insert
'
Me.Insert.Location = New System.Drawing.Point(15, 194)
Me.Insert.Name = "Insert"
Me.Insert.Size = New System.Drawing.Size(75, 23)
Me.Insert.TabIndex = 5
Me.Insert.Text = "Insert"
Me.Insert.UseVisualStyleBackColor = True
'
'FKProductsSuppliersBindingSource
'
Me.FKProductsSuppliersBindingSource.DataMember = "FK_Products_Suppliers"
Me.FKProductsSuppliersBindingSource.DataSource = Me.SuppliersBindingSource
'
'ActionsControl
'
Me.Controls.Add(Me.Insert)
Me.Controls.Add(ProductNameLabel)
Me.Controls.Add(Me.ProductNameListBox)
Me.Controls.Add(CompanyNameLabel)
Me.Controls.Add(Me.CompanyNameComboBox)
Me.Name = "ActionsControl"
Me.Size = New System.Drawing.Size(256, 258)
CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.FKProductsSuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents NorthwindDataSet As Trin_VstcoreActionsPaneWordVB.NorthwindDataSet
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuppliersTableAdapter As Trin_VstcoreActionsPaneWordVB.NorthwindDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Trin_VstcoreActionsPaneWordVB.NorthwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductNameListBox As System.Windows.Forms.ListBox
    Friend WithEvents Insert As System.Windows.Forms.Button
    Friend WithEvents FKProductsSuppliersBindingSource As System.Windows.Forms.BindingSource

End Class
