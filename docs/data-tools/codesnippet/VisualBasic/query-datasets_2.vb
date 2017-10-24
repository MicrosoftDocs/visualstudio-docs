        Dim s As String = "primaryKeyValue"
        Dim foundRow As DataRow = DataSet1.Tables("AnyTable").Rows.Find(s)

        If foundRow IsNot Nothing Then
            MsgBox(foundRow(1).ToString())
        Else
            MsgBox("A row with the primary key of " & s & " could not be found")
        End If