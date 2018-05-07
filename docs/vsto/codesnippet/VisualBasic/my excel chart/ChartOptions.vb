Public Class ChartOptions

    '<Snippet13>
    Public Event SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private selectedType As Microsoft.Office.Interop.Excel.XlChartType = _
        Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered

    Public Property Selection() As Microsoft.Office.Interop.Excel.XlChartType
        Get
            Return Me.selectedType
        End Get
        Set(ByVal value As Microsoft.Office.Interop.Excel.XlChartType)
            Me.selectedType = value
        End Set
    End Property
    '</Snippet13>


    '<Snippet14>
    Private Sub areaBlockChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles areaBlockChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlAreaStacked
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub
    '</Snippet14>


    '<Snippet15>
    Private Sub barChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles barChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlBarClustered
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub
    '</Snippet15>


    '<Snippet16>
    Private Sub columnChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles columnChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub
    '</Snippet16>


    '<Snippet17>
    Private Sub lineChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles lineChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlLineMarkers
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub
    '</Snippet17>
End Class
