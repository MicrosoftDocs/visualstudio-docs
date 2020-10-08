Class MainWindow 

    '<Snippet2>
    Private DataServiceClient As AdventureWorksService.AdventureWorksLTEntities
    Private SalesQuery As System.Data.Services.Client.DataServiceQuery(Of AdventureWorksService.SalesOrderHeader)
    Private OrdersViewSource As CollectionViewSource

    Private Sub Window_Loaded(ByVal Sender As Object, ByVal e As RoutedEventArgs) Handles MyBase.Loaded

        ' TODO: Modify the port number in the following URI as required.
        DataServiceClient = New AdventureWorksService.AdventureWorksLTEntities( _
        New Uri("http://localhost:32415/AdventureWorksService.svc"))
        SalesQuery = DataServiceClient.SalesOrderHeaders

        OrdersViewSource = CType(Me.FindResource("SalesOrderHeadersViewSource"), CollectionViewSource)
        OrdersViewSource.Source = SalesQuery.Execute()
        OrdersViewSource.View.MoveCurrentToFirst()
    End Sub
    '</Snippet2>

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles backButton.Click
        '<Snippet3>
        If OrdersViewSource.View.CurrentPosition > 0 Then
            OrdersViewSource.View.MoveCurrentToPrevious()
        End If
        '</Snippet3>
    End Sub

    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles nextButton.Click
        '<Snippet4>
        If OrdersViewSource.View.CurrentPosition < CType(OrdersViewSource.View, CollectionView).Count - 1 Then
            OrdersViewSource.View.MoveCurrentToNext()
        End If
        '</Snippet4>
    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles saveButton.Click
        '<Snippet5>
        Dim CurrentOrder As AdventureWorksService.SalesOrderHeader = CType(OrdersViewSource.View.CurrentItem, AdventureWorksService.SalesOrderHeader)

        DataServiceClient.UpdateObject(CurrentOrder)
        DataServiceClient.SaveChanges()
        '</Snippet5>
    End Sub
End Class
