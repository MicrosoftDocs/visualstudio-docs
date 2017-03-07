
Public Class Sheet1

    Private Sub Sheet1_Startup() Handles Me.Startup

    End Sub

    Private Sub Sheet1_Shutdown() Handles Me.Shutdown

    End Sub

    'Dim dataChart As Excel.Chart = New Excel.Chart()

    '--------------------------------------------------------------------------
    '<Snippet19>
    Private Sub ChartOptions1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ChartOptions1.SelectionChanged

        Try
            dataChart.ChartType = Me.ChartOptions1.Selection
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '</Snippet19>


    '--------------------------------------------------------------------------
    '<Snippet7>
    Private Sub applyBoldFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles applyBoldFont.Click

        Me.textFont.Font.Bold = Me.applyBoldFont.Checked
    End Sub
    '</Snippet7>


    '--------------------------------------------------------------------------
    '<Snippet8>
    Private Sub applyItalicFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles applyItalicFont.Click

        Me.textFont.Font.Italic = Me.applyItalicFont.Checked
    End Sub
    '</Snippet8>


    '--------------------------------------------------------------------------
    '<Snippet9>
    Private Sub applyUnderlineFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles applyUnderlineFont.Click

        If Me.applyUnderlineFont.Checked Then
            Me.textFont.Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle
        Else
            Me.textFont.Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleNone
        End If
    End Sub
    '</Snippet9>


    '--------------------------------------------------------------------------
    '<Snippet11>
    Private Sub insertText_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles insertText.Click

        Me.displayText.Text += "Hello World! "
    End Sub
    '</Snippet11>


    '--------------------------------------------------------------------------
    '<Snippet4>
    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup

        Dim salesButton As Microsoft.Office.Tools.Excel.Controls.Button
        salesButton = Me.Controls.AddButton(Me.Range("C5"), "salesButton")
        salesButton.Text = "Calculate Total Sales"
    End Sub
    '</Snippet4>


    '--------------------------------------------------------------------------
    Sub Test2()
        '<Snippet5>
        Dim control1 As Microsoft.Office.Tools.Excel.Controls.Button = _
            Me.Controls.AddButton(Me.Range("A1"), "control1")
        '</Snippet5>


        '<Snippet6>
        control1.Placement = Microsoft.Office.Interop.Excel.XlPlacement.xlFreeFloating
        '</Snippet6>
    End Sub


    '--------------------------------------------------------------------------
    Sub Test1()
        Dim range1 As Object = Nothing

        '<Snippet2>
        Dim customControl As New UserControl1()

        Dim dynamicControl As Microsoft.Office.Tools.Excel.ControlSite = _
            Me.Controls.AddControl(customControl, range1, "dynamic")
        '</Snippet2>

        '<Snippet3>
        ' Property is set in relation to the document.
        dynamicControl.Top = 100

        ' Property is set in relation to the container control.
        customControl.Top = 100
        '</Snippet3>
    End Sub

End Class
