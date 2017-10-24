    Private Sub FindErrors()
        Dim table As Data.DataTable
        Dim row As Data.DataRow

        If DataSet1.HasErrors Then

            For Each table In DataSet1.Tables
                If table.HasErrors Then

                    For Each row In table.Rows
                        If row.HasErrors Then

                            ' Process error here.
                        End If
                    Next
                End If
            Next
        End If
    End Sub