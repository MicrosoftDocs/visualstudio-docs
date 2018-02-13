<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class HelloControl
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
Me.Button1 = New System.Windows.Forms.Button
Me.SuspendLayout()
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(21, 19)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(75, 23)
Me.Button1.TabIndex = 0
Me.Button1.Text = "Button1"
Me.Button1.UseVisualStyleBackColor = True
'
'HelloControl
'
Me.Controls.Add(Me.Button1)
Me.Name = "HelloControl"
Me.ResumeLayout(False)

End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
