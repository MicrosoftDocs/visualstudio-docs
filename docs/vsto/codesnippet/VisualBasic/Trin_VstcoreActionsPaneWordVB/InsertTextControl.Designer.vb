<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class InsertTextControl
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
Me.addText = New System.Windows.Forms.Button
Me.getName = New System.Windows.Forms.TextBox
Me.getAddress = New System.Windows.Forms.TextBox
Me.SuspendLayout()
'
'addText
'
Me.addText.Location = New System.Drawing.Point(20, 100)
Me.addText.Name = "addText"
Me.addText.Size = New System.Drawing.Size(75, 23)
Me.addText.TabIndex = 0
Me.addText.Text = "addText"
Me.addText.UseVisualStyleBackColor = True
'
'getName
'
Me.getName.Location = New System.Drawing.Point(20, 16)
Me.getName.Name = "getName"
Me.getName.Size = New System.Drawing.Size(100, 20)
Me.getName.TabIndex = 1
'
'getAddress
'
Me.getAddress.Location = New System.Drawing.Point(20, 55)
Me.getAddress.Name = "getAddress"
Me.getAddress.Size = New System.Drawing.Size(100, 20)
Me.getAddress.TabIndex = 2
'
'InsertTextControl
'
Me.Controls.Add(Me.getAddress)
Me.Controls.Add(Me.getName)
Me.Controls.Add(Me.addText)
Me.Name = "InsertTextControl"
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents addText As System.Windows.Forms.Button
    Friend WithEvents getName As System.Windows.Forms.TextBox
    Friend WithEvents getAddress As System.Windows.Forms.TextBox

End Class
