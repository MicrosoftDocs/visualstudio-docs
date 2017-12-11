<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChartOptions
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.columnChart = New System.Windows.Forms.RadioButton()
        Me.barChart = New System.Windows.Forms.RadioButton()
        Me.lineChart = New System.Windows.Forms.RadioButton()
        Me.areaBlockChart = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'columnChart
        '
        Me.columnChart.AutoSize = True
        Me.columnChart.Location = New System.Drawing.Point(22, 20)
        Me.columnChart.Name = "columnChart"
        Me.columnChart.Size = New System.Drawing.Size(90, 17)
        Me.columnChart.TabIndex = 0
        Me.columnChart.TabStop = True
        Me.columnChart.Text = "RadioButton1"
        Me.columnChart.UseVisualStyleBackColor = True
        '
        'barChart
        '
        Me.barChart.AutoSize = True
        Me.barChart.Location = New System.Drawing.Point(22, 44)
        Me.barChart.Name = "barChart"
        Me.barChart.Size = New System.Drawing.Size(90, 17)
        Me.barChart.TabIndex = 1
        Me.barChart.TabStop = True
        Me.barChart.Text = "RadioButton1"
        Me.barChart.UseVisualStyleBackColor = True
        '
        'lineChart
        '
        Me.lineChart.AutoSize = True
        Me.lineChart.Location = New System.Drawing.Point(22, 79)
        Me.lineChart.Name = "lineChart"
        Me.lineChart.Size = New System.Drawing.Size(90, 17)
        Me.lineChart.TabIndex = 2
        Me.lineChart.TabStop = True
        Me.lineChart.Text = "RadioButton1"
        Me.lineChart.UseVisualStyleBackColor = True
        '
        'areaBlockChart
        '
        Me.areaBlockChart.AutoSize = True
        Me.areaBlockChart.Location = New System.Drawing.Point(22, 129)
        Me.areaBlockChart.Name = "areaBlockChart"
        Me.areaBlockChart.Size = New System.Drawing.Size(90, 17)
        Me.areaBlockChart.TabIndex = 3
        Me.areaBlockChart.TabStop = True
        Me.areaBlockChart.Text = "RadioButton1"
        Me.areaBlockChart.UseVisualStyleBackColor = True
        '
        'ChartOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.areaBlockChart)
        Me.Controls.Add(Me.lineChart)
        Me.Controls.Add(Me.barChart)
        Me.Controls.Add(Me.columnChart)
        Me.Name = "ChartOptions"
        Me.Size = New System.Drawing.Size(199, 234)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents columnChart As System.Windows.Forms.RadioButton
    Friend WithEvents barChart As System.Windows.Forms.RadioButton
    Friend WithEvents lineChart As System.Windows.Forms.RadioButton
    Friend WithEvents areaBlockChart As System.Windows.Forms.RadioButton

End Class
