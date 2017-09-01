<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FillOrCancel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.btnFindByOrderID = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFillDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvCustomerOrders = New System.Windows.Forms.DataGridView()
        Me.btnFillOrder = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnFinishUpdates = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order ID:"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(216, 58)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(228, 31)
        Me.txtOrderID.TabIndex = 1
        '
        'btnFindByOrderID
        '
        Me.btnFindByOrderID.Location = New System.Drawing.Point(572, 32)
        Me.btnFindByOrderID.Name = "btnFindByOrderID"
        Me.btnFindByOrderID.Size = New System.Drawing.Size(235, 56)
        Me.btnFindByOrderID.TabIndex = 2
        Me.btnFindByOrderID.Text = "Find order"
        Me.btnFindByOrderID.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "If filling an order, specify filled date:"
        '
        'dtpFillDate
        '
        Me.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFillDate.Location = New System.Drawing.Point(572, 175)
        Me.dtpFillDate.Name = "dtpFillDate"
        Me.dtpFillDate.Size = New System.Drawing.Size(200, 31)
        Me.dtpFillDate.TabIndex = 4
        '
        'dgvCustomerOrders
        '
        Me.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerOrders.Location = New System.Drawing.Point(64, 243)
        Me.dgvCustomerOrders.Name = "dgvCustomerOrders"
        Me.dgvCustomerOrders.ReadOnly = True
        Me.dgvCustomerOrders.RowHeadersVisible = False
        Me.dgvCustomerOrders.RowTemplate.Height = 33
        Me.dgvCustomerOrders.Size = New System.Drawing.Size(1131, 311)
        Me.dgvCustomerOrders.TabIndex = 5
        '
        'btnFillOrder
        '
        Me.btnFillOrder.Location = New System.Drawing.Point(64, 633)
        Me.btnFillOrder.Name = "btnFillOrder"
        Me.btnFillOrder.Size = New System.Drawing.Size(199, 53)
        Me.btnFillOrder.TabIndex = 6
        Me.btnFillOrder.Text = "Fill Order"
        Me.btnFillOrder.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(359, 633)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(219, 52)
        Me.btnCancelOrder.TabIndex = 7
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'btnFinishUpdates
        '
        Me.btnFinishUpdates.Location = New System.Drawing.Point(1013, 633)
        Me.btnFinishUpdates.Name = "btnFinishUpdates"
        Me.btnFinishUpdates.Size = New System.Drawing.Size(182, 52)
        Me.btnFinishUpdates.TabIndex = 8
        Me.btnFinishUpdates.Text = "Finish"
        Me.btnFinishUpdates.UseVisualStyleBackColor = True
        '
        'FillOrCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 769)
        Me.Controls.Add(Me.btnFinishUpdates)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.btnFillOrder)
        Me.Controls.Add(Me.dgvCustomerOrders)
        Me.Controls.Add(Me.dtpFillDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFindByOrderID)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FillOrCancel"
        Me.Text = "Fill or cancel an order"
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents btnFindByOrderID As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFillDate As DateTimePicker
    Friend WithEvents dgvCustomerOrders As DataGridView
    Friend WithEvents btnFillOrder As Button
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents btnFinishUpdates As Button
End Class
