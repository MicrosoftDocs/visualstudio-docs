Class MainWindow 

    '<Snippet1>
    Dim ProductViewSource As System.Windows.Data.CollectionViewSource
    Dim AdventureWorksLTDataSet As AdventureWorksProductsEditor.AdventureWorksLTDataSet
    Dim AdventureWorksLTDataSetProductTableAdapter As AdventureWorksProductsEditor.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        AdventureWorksLTDataSet = CType(Me.FindResource("AdventureWorksLTDataSet"), AdventureWorksProductsEditor.AdventureWorksLTDataSet)
        'Load data into the table Product. You can modify this code as needed.
        AdventureWorksLTDataSetProductTableAdapter = New AdventureWorksProductsEditor.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter()
        AdventureWorksLTDataSetProductTableAdapter.Fill(AdventureWorksLTDataSet.Product)
        ProductViewSource = CType(Me.FindResource("ProductViewSource"), System.Windows.Data.CollectionViewSource)
        ProductViewSource.View.MoveCurrentToFirst()
    End Sub
    '</Snippet1>



    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles backButton.Click
        '<Snippet2>
        If ProductViewSource.View.CurrentPosition > 0 Then
            ProductViewSource.View.MoveCurrentToPrevious()
        End If
        '</Snippet2>
    End Sub

    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles nextButton.Click
        '<Snippet3>
        If ProductViewSource.View.CurrentPosition < CType(ProductViewSource.View, CollectionView).Count - 1 Then
            ProductViewSource.View.MoveCurrentToNext()
        End If
        '</Snippet3>
    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles saveButton.Click
        '<Snippet4>
        AdventureWorksLTDataSetProductTableAdapter.Update(AdventureWorksLTDataSet.Product)
        '</Snippet4>
    End Sub
End Class
