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
Me.ComboBox1 = New System.Windows.Forms.ComboBox
Me.SuspendLayout()
'
'ComboBox1
'
Me.ComboBox1.FormattingEnabled = True
Me.ComboBox1.Location = New System.Drawing.Point(16, 18)
Me.ComboBox1.Name = "ComboBox1"
Me.ComboBox1.Size = New System.Drawing.Size(171, 21)
Me.ComboBox1.TabIndex = 0
'
'ActionsControl
'
Me.Controls.Add(Me.ComboBox1)
Me.Name = "ActionsControl"
Me.Size = New System.Drawing.Size(210, 150)
Me.ResumeLayout(False)

End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
