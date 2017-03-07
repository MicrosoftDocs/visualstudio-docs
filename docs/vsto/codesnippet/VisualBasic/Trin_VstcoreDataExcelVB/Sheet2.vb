Public Class Sheet2

    '--------------------------------------------------------------------------
    Private Sub Sheet2_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

        'TODO: Delete this line of code to remove the default AutoFill for 'NorthwindDataSet.Order Details'.
        If Me.NeedsFill("NorthwindDataSet") Then
            Me.Order_DetailsTableAdapter.Fill(Me.NorthwindDataSet.Order_Details)
        End If

        'TODO: Delete this line of code to remove the default AutoFill for 'NorthwindDataSet.Orders'.
        If Me.NeedsFill("NorthwindDataSet") Then
            Me.OrdersTableAdapter.Fill(Me.NorthwindDataSet.Orders)
        End If


        '<Snippet15>
        Me.Button1.Text = "<"
        Me.Button2.Text = ">"
        '</Snippet15>
    End Sub


    '--------------------------------------------------------------------------
    '<Snippet17>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Button1.Click

        Me.OrdersBindingSource.MovePrevious()
    End Sub
    '</Snippet17>


    '--------------------------------------------------------------------------
    '<Snippet18>
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Button2.Click

        Me.OrdersBindingSource.MoveNext()
    End Sub
    '</Snippet18>
End Class
