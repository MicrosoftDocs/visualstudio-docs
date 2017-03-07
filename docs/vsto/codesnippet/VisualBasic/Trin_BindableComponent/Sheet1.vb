Public Class Sheet1

    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        SetBindingContext()
    End Sub

    Private Sub Sheet1_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    ' Snippet1 - BindableComponent class overview
    ' Snippet2 - DataBindings property
    ' Snippet3 - BindingContext property
    ' <Snippet1>
    ' <Snippet2>
    Private namedRange1 As Microsoft.Office.Tools.Excel.NamedRange
    Private WithEvents button1 As Microsoft.Office.Tools.Excel.Controls.Button
    Private customerNames As String() = _
        {"Reggie", "Sally", "Henry", "Christine"}
    Private ds As DataSet

    Private Sub SetBindingContext()
        namedRange1 = Me.Controls.AddNamedRange(Me.Range("A1", _
            System.Type.Missing), "namedRange1")

        ' Create a button that scrolls through the data 
        ' displayed in the NamedRange.
        button1 = Me.Controls.AddButton(50, 20, 100, 20, "button1")
        button1.Text = "Display next item"

        ' Create a data table with one column.
        ds = New DataSet()
        Dim table As DataTable = ds.Tables.Add("Customers")
        Dim column1 As New DataColumn("Names", GetType(String))
        table.Columns.Add(column1)

        ' Add the names to the table.
        Dim row As DataRow
        Dim i As Integer
        For i = 0 To customerNames.Length - 1
            row = table.NewRow()
            row("Names") = customerNames(i)
            table.Rows.Add(row)
        Next i

        ' Create a new Binding that links the Value2 property
        ' of the NamedRange and the Names column.
        '<Snippet4>
        Dim binding1 As New Binding("Value2", ds, "Customers.Names", True)
        namedRange1.DataBindings.Add(binding1)
        '</Snippet4>
    End Sub
    ' </Snippet2>

    ' <Snippet3>
    ' Displays the next data item in the NamedRange.
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button1.Click

        If Not (namedRange1.BindingContext Is Nothing) Then
            Dim bindingManager1 As BindingManagerBase = _
                namedRange1.BindingContext(ds, "Customers")

            ' Display the next item.
            If bindingManager1.Position < bindingManager1.Count - 1 Then
                bindingManager1.Position += 1

                ' Display the first item.
            Else
                bindingManager1.Position = 0
            End If
        End If
    End Sub
    ' </Snippet3>
    ' </Snippet1>

End Class
