        Private Sub Order_DetailsDataTable_Order_DetailsRowChanging(
            ByVal sender As System.Object, 
            ByVal e As Order_DetailsRowChangeEvent
          ) Handles Me.Order_DetailsRowChanging

            If CType(e.Row.Quantity, Short) <= 0 Then
                e.Row.SetColumnError("Quantity", "Quantity must be greater than 0")
            Else
                e.Row.SetColumnError("Quantity", "")
            End If
        End Sub