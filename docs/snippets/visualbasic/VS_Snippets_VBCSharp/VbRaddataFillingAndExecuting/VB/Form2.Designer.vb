<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
Me.NorthwindDataSet = New VB.NorthwindDataSet
Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.CustomersTableAdapter = New VB.NorthwindDataSetTableAdapters.CustomersTableAdapter
Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
Me.CustomersDataGridView = New System.Windows.Forms.DataGridView
Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
Me.CustomersBindingNavigator.SuspendLayout()
CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'NorthwindDataSet
'
Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
'
'CustomersBindingSource
'
Me.CustomersBindingSource.DataMember = "Customers"
Me.CustomersBindingSource.DataSource = Me.NorthwindDataSet
'
'CustomersTableAdapter
'
Me.CustomersTableAdapter.ClearBeforeFill = True
'
'CustomersBindingNavigator
'
Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem})
Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
Me.CustomersBindingNavigator.Size = New System.Drawing.Size(492, 25)
Me.CustomersBindingNavigator.TabIndex = 0
Me.CustomersBindingNavigator.Text = "BindingNavigator1"
'
'BindingNavigatorMoveFirstItem
'
Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
Me.BindingNavigatorMoveFirstItem.Text = "Move first"
'
'BindingNavigatorMovePreviousItem
'
Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
'
'BindingNavigatorSeparator
'
Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
'
'BindingNavigatorPositionItem
'
Me.BindingNavigatorPositionItem.AccessibleName = "Position"
Me.BindingNavigatorPositionItem.AutoSize = False
Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
Me.BindingNavigatorPositionItem.Text = "0"
Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
'
'BindingNavigatorCountItem
'
Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
Me.BindingNavigatorCountItem.Text = "of {0}"
Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
'
'BindingNavigatorSeparator1
'
Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
'
'BindingNavigatorMoveNextItem
'
Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
Me.BindingNavigatorMoveNextItem.Text = "Move next"
'
'BindingNavigatorMoveLastItem
'
Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
Me.BindingNavigatorMoveLastItem.Text = "Move last"
'
'BindingNavigatorSeparator2
'
Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
'
'BindingNavigatorAddNewItem
'
Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
Me.BindingNavigatorAddNewItem.Text = "Add new"
'
'BindingNavigatorDeleteItem
'
Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
Me.BindingNavigatorDeleteItem.Text = "Delete"
'
'CustomersBindingNavigatorSaveItem
'
Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
'
'CustomersDataGridView
'
Me.CustomersDataGridView.AutoGenerateColumns = False
Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
Me.CustomersDataGridView.DataSource = Me.CustomersBindingSource
Me.CustomersDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable
Me.CustomersDataGridView.Location = New System.Drawing.Point(30, 47)
Me.CustomersDataGridView.Name = "CustomersDataGridView"
Me.CustomersDataGridView.Size = New System.Drawing.Size(317, 220)
Me.CustomersDataGridView.TabIndex = 1
'
'DataGridViewTextBoxColumn1
'
Me.DataGridViewTextBoxColumn1.DataPropertyName = "CustomerID"
Me.DataGridViewTextBoxColumn1.HeaderText = "CustomerID"
Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
'
'DataGridViewTextBoxColumn2
'
Me.DataGridViewTextBoxColumn2.DataPropertyName = "CompanyName"
Me.DataGridViewTextBoxColumn2.HeaderText = "CompanyName"
Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
'
'DataGridViewTextBoxColumn3
'
Me.DataGridViewTextBoxColumn3.DataPropertyName = "ContactName"
Me.DataGridViewTextBoxColumn3.HeaderText = "ContactName"
Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
'
'DataGridViewTextBoxColumn4
'
Me.DataGridViewTextBoxColumn4.DataPropertyName = "ContactTitle"
Me.DataGridViewTextBoxColumn4.HeaderText = "ContactTitle"
Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
'
'DataGridViewTextBoxColumn5
'
Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
'
'DataGridViewTextBoxColumn6
'
Me.DataGridViewTextBoxColumn6.DataPropertyName = "City"
Me.DataGridViewTextBoxColumn6.HeaderText = "City"
Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
'
'DataGridViewTextBoxColumn7
'
Me.DataGridViewTextBoxColumn7.DataPropertyName = "Region"
Me.DataGridViewTextBoxColumn7.HeaderText = "Region"
Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
'
'DataGridViewTextBoxColumn8
'
Me.DataGridViewTextBoxColumn8.DataPropertyName = "PostalCode"
Me.DataGridViewTextBoxColumn8.HeaderText = "PostalCode"
Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
'
'DataGridViewTextBoxColumn9
'
Me.DataGridViewTextBoxColumn9.DataPropertyName = "Country"
Me.DataGridViewTextBoxColumn9.HeaderText = "Country"
Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
'
'DataGridViewTextBoxColumn10
'
Me.DataGridViewTextBoxColumn10.DataPropertyName = "Phone"
Me.DataGridViewTextBoxColumn10.HeaderText = "Phone"
Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
'
'DataGridViewTextBoxColumn11
'
Me.DataGridViewTextBoxColumn11.DataPropertyName = "Fax"
Me.DataGridViewTextBoxColumn11.HeaderText = "Fax"
Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
'
'Form2
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(492, 315)
Me.Controls.Add(Me.CustomersDataGridView)
Me.Controls.Add(Me.CustomersBindingNavigator)
Me.Name = "Form2"
Me.Text = "Form2"
CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
Me.CustomersBindingNavigator.ResumeLayout(False)
Me.CustomersBindingNavigator.PerformLayout()
CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents NorthwindDataSet As VB.NorthwindDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As VB.NorthwindDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
