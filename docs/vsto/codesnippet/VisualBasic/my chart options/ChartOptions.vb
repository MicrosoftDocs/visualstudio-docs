Public Class ChartOptions
    '<Snippet9>
    Public Event SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private selectedType As Microsoft.Office.Interop.Graph.XlChartType = _
        Microsoft.Office.Interop.Graph.XlChartType.xlColumnClustered

    Public Property Selection() As Microsoft.Office.Interop.Graph.XlChartType
        Get
            Return Me.selectedType
        End Get
        Set(ByVal value As Microsoft.Office.Interop.Graph.XlChartType)
            Me.selectedType = value
        End Set
    End Property
    '</Snippet9>


    '<Snippet10>
    Private Sub areaBlockChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles areaBlockChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlAreaStacked
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub
    '</Snippet10>


    '<Snippet11>
    Private Sub barChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles barChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlBarClustered
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub
    '</Snippet11>


    '<Snippet12>
    Private Sub columnChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles columnChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlColumnClustered
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub
    '</Snippet12>


    '<Snippet13>
    Private Sub lineChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles lineChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then
            Me.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlLineMarkers
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub
    '</Snippet13>
End Class
