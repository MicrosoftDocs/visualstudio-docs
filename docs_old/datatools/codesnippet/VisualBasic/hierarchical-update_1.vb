        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)