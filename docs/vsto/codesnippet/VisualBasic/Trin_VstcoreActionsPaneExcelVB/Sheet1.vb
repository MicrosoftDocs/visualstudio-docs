
Public Class Sheet1

    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
'TODO: Delete this line of code to remove the default AutoFill for 'NorthwindDataSet.Products'.
If Me.NeedsFill("NorthwindDataSet") Then
    Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)
End If
'TODO: Delete this line of code to remove the default AutoFill for 'NorthwindDataSet.Suppliers'.
If Me.NeedsFill("NorthwindDataSet") Then
    Me.SuppliersTableAdapter.Fill(Me.NorthwindDataSet.Suppliers)
End If

    End Sub

    Private Sub Sheet1_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class
