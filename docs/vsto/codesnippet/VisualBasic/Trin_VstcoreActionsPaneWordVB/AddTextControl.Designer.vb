<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class AddTextControl
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
Me.toBox = New System.Windows.Forms.TextBox
Me.fromBox = New System.Windows.Forms.TextBox
Me.subjectBox = New System.Windows.Forms.TextBox
Me.insertText = New System.Windows.Forms.Button
Me.SuspendLayout()
'
'toBox
'
Me.toBox.Location = New System.Drawing.Point(4, 4)
Me.toBox.Name = "toBox"
Me.toBox.Size = New System.Drawing.Size(100, 20)
Me.toBox.TabIndex = 0
'
'fromBox
'
Me.fromBox.Location = New System.Drawing.Point(4, 31)
Me.fromBox.Name = "fromBox"
Me.fromBox.Size = New System.Drawing.Size(100, 20)
Me.fromBox.TabIndex = 1
'
'subjectBox
'
Me.subjectBox.Location = New System.Drawing.Point(4, 58)
Me.subjectBox.Name = "subjectBox"
Me.subjectBox.Size = New System.Drawing.Size(100, 20)
Me.subjectBox.TabIndex = 2
'
'insertText
'
Me.insertText.Location = New System.Drawing.Point(4, 97)
Me.insertText.Name = "insertText"
Me.insertText.Size = New System.Drawing.Size(75, 23)
Me.insertText.TabIndex = 3
Me.insertText.Text = "insertText"
Me.insertText.UseVisualStyleBackColor = True
'
'AddTextControl
'
Me.Controls.Add(Me.insertText)
Me.Controls.Add(Me.subjectBox)
Me.Controls.Add(Me.fromBox)
Me.Controls.Add(Me.toBox)
Me.Name = "AddTextControl"
Me.Size = New System.Drawing.Size(170, 135)
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents toBox As System.Windows.Forms.TextBox
    Friend WithEvents fromBox As System.Windows.Forms.TextBox
    Friend WithEvents subjectBox As System.Windows.Forms.TextBox
    Friend WithEvents insertText As System.Windows.Forms.Button

End Class
