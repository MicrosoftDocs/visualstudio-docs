<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.numOrderAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnAddFinish = New System.Windows.Forms.Button()
        Me.btnAddAnotherAccount = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numOrderAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Account"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(222, 113)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(221, 31)
        Me.txtCustomerID.TabIndex = 3
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(222, 39)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(221, 31)
        Me.txtCustomerName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpOrderDate)
        Me.GroupBox2.Controls.Add(Me.numOrderAmount)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(73, 306)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 219)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CreateOrder"
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderDate.Location = New System.Drawing.Point(222, 121)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(221, 31)
        Me.dtpOrderDate.TabIndex = 3
        '
        'numOrderAmount
        '
        Me.numOrderAmount.Location = New System.Drawing.Point(222, 59)
        Me.numOrderAmount.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numOrderAmount.Name = "numOrderAmount"
        Me.numOrderAmount.Size = New System.Drawing.Size(148, 31)
        Me.numOrderAmount.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Order Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Order Amount:"
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(601, 197)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(213, 66)
        Me.btnCreateAccount.TabIndex = 2
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(601, 458)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(213, 66)
        Me.btnPlaceOrder.TabIndex = 3
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnAddFinish
        '
        Me.btnAddFinish.Location = New System.Drawing.Point(73, 590)
        Me.btnAddFinish.Name = "btnAddFinish"
        Me.btnAddFinish.Size = New System.Drawing.Size(190, 73)
        Me.btnAddFinish.TabIndex = 4
        Me.btnAddFinish.Text = "Finish"
        Me.btnAddFinish.UseVisualStyleBackColor = True
        '
        'btnAddAnotherAccount
        '
        Me.btnAddAnotherAccount.Location = New System.Drawing.Point(547, 590)
        Me.btnAddAnotherAccount.Name = "btnAddAnotherAccount"
        Me.btnAddAnotherAccount.Size = New System.Drawing.Size(267, 73)
        Me.btnAddAnotherAccount.TabIndex = 5
        Me.btnAddAnotherAccount.Text = "Add another account"
        Me.btnAddAnotherAccount.UseVisualStyleBackColor = True
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 743)
        Me.Controls.Add(Me.btnAddAnotherAccount)
        Me.Controls.Add(Me.btnAddFinish)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewCustomer"
        Me.Text = "New Account and Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numOrderAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents numOrderAmount As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnAddFinish As Button
    Friend WithEvents btnAddAnotherAccount As Button
End Class
