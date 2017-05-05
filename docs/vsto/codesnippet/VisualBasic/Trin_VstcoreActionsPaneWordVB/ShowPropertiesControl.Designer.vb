<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class ShowPropertiesControl
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
Me.tableProperties = New System.Windows.Forms.Button
Me.SuspendLayout()
'
'tableProperties
'
Me.tableProperties.Location = New System.Drawing.Point(13, 14)
Me.tableProperties.Name = "tableProperties"
Me.tableProperties.Size = New System.Drawing.Size(75, 23)
Me.tableProperties.TabIndex = 0
Me.tableProperties.Text = "tableProperties"
Me.tableProperties.UseVisualStyleBackColor = True
'
'ShowPropertiesControl
'
Me.Controls.Add(Me.tableProperties)
Me.Name = "ShowPropertiesControl"
Me.Size = New System.Drawing.Size(170, 50)
Me.ResumeLayout(False)

End Sub
    Friend WithEvents tableProperties As System.Windows.Forms.Button

End Class
