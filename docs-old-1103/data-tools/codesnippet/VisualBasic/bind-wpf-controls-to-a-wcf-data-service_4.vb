        If OrdersViewSource.View.CurrentPosition < CType(OrdersViewSource.View, CollectionView).Count - 1 Then
            OrdersViewSource.View.MoveCurrentToNext()
        End If