        If ProductViewSource.View.CurrentPosition < CType(ProductViewSource.View, CollectionView).Count - 1 Then
            ProductViewSource.View.MoveCurrentToNext()
        End If