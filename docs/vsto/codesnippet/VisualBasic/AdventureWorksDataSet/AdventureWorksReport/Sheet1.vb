
Public Class Sheet1

    '<Snippet8>
    Private ProductTableAdapter As New  _
        AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter()

    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        If Me.NeedsFill("AdventureWorksLTDataSet") Then
            Me.ProductTableAdapter.Fill(Me.AdventureWorksLTDataSet.Product)
        End If
    End Sub
    '</Snippet8>

    Private Sub Sheet1_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class
