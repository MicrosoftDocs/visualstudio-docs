<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class ShowAllControl
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
Me.showCheck = New System.Windows.Forms.CheckBox
Me.SuspendLayout()
'
'showCheck
'
Me.showCheck.AutoSize = True
Me.showCheck.Location = New System.Drawing.Point(20, 28)
Me.showCheck.Name = "showCheck"
Me.showCheck.Size = New System.Drawing.Size(82, 17)
Me.showCheck.TabIndex = 0
Me.showCheck.Text = "showCheck"
Me.showCheck.UseVisualStyleBackColor = True
'
'ShowAllControl
'
Me.Controls.Add(Me.showCheck)
Me.Name = "ShowAllControl"
Me.Size = New System.Drawing.Size(170, 75)
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents showCheck As System.Windows.Forms.CheckBox

End Class
