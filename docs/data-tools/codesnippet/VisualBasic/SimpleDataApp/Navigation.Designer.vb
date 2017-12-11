<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navigation
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
        Me.btnGoToAdd = New System.Windows.Forms.Button()
        Me.btnGoToFillOrCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What do you want to do?"
        '
        'btnGoToAdd
        '
        Me.btnGoToAdd.Location = New System.Drawing.Point(106, 162)
        Me.btnGoToAdd.Name = "btnGoToAdd"
        Me.btnGoToAdd.Size = New System.Drawing.Size(296, 48)
        Me.btnGoToAdd.TabIndex = 1
        Me.btnGoToAdd.Text = "Add an account"
        Me.btnGoToAdd.UseVisualStyleBackColor = True
        '
        'btnGoToFillOrCancel
        '
        Me.btnGoToFillOrCancel.Location = New System.Drawing.Point(106, 235)
        Me.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel"
        Me.btnGoToFillOrCancel.Size = New System.Drawing.Size(296, 51)
        Me.btnGoToFillOrCancel.TabIndex = 2
        Me.btnGoToFillOrCancel.Text = "Fill or cancel an order"
        Me.btnGoToFillOrCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(474, 391)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 58)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Navigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 544)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGoToFillOrCancel)
        Me.Controls.Add(Me.btnGoToAdd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Navigation"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnGoToAdd As Button
    Friend WithEvents btnGoToFillOrCancel As Button
    Friend WithEvents btnExit As Button
End Class
