        Dim tableAdapter As New NorthwindDataSetTableAdapters.CustomersTableAdapter()

        Dim rowsAffected As Integer
        rowsAffected = CType(tableAdapter.UpdateContactTitle("Sales Manager", "ALFKI"), Integer)