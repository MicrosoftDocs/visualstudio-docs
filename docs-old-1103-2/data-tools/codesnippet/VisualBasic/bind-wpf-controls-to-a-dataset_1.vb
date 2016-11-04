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