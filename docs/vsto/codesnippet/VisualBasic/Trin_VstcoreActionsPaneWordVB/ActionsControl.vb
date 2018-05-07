Public Class ActionsControl


    '--------------------------------------------------------------------------
    '<Snippet1>
    Private Sub ActionsControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Load

        Me.SuppliersTableAdapter.Fill(Me.NorthwindDataSet.Suppliers)
        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)
    End Sub
    '</Snippet1>


    '--------------------------------------------------------------------------
    '<Snippet2>
    Shared Sub SetHeadings(ByVal tblCell As Word.Cell, ByVal text As String)

        With tblCell.Range
            .Text = text
            .Font.Bold = True
            .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        End With
    End Sub
    '</Snippet2>


    '--------------------------------------------------------------------------
    '<Snippet3>
    Private Sub AddData(ByVal row As System.Data.DataRow, ByVal companyName As String)

        ' Create a table if it doesn't already exist.
        If Globals.ThisDocument.Tables.Count = 0 Then

            Try
                ' Create a table. 
                Dim tbl As Word.Table = Globals.ThisDocument.Tables.Add( _
                    Globals.ThisDocument.Application.Selection.Range, 1, 4)

                ' Insert headings.
                SetHeadings(tbl.Cell(1, 1), "Company Name")
                SetHeadings(tbl.Cell(1, 2), "Product Name")
                SetHeadings(tbl.Cell(1, 3), "Quantity")
                SetHeadings(tbl.Cell(1, 4), "Unit Price")

            Catch ex As Exception
                MessageBox.Show("Problem creating Products table: " & ex.Message, _
                    "Actions Pane", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ' Add data from data row to the table.
        Dim selection As Word.Selection = Globals.ThisDocument.Application.Selection

        If selection.Tables.Count > 0 Then

            Dim newRow As Word.Row = Globals.ThisDocument.Tables(1).Rows.Add()
            With newRow
                .Range.Font.Bold = False
                .Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                .Cells(4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                .Cells(1).Range.Text = companyName
                .Cells(2).Range.Text = row.Item("ProductName").ToString
                .Cells(3).Range.Text = row.Item("QuantityPerUnit").ToString
                .Cells(4).Range.Text = Math.Round(row.Item("UnitPrice"), 2)
            End With

        Else
            MessageBox.Show("Cursor must be within a table.", _
                "Actions Pane", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    '</Snippet3>


    '--------------------------------------------------------------------------
    '<Snippet4>
    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click

        Dim tbl As System.Data.DataTable = NorthwindDataSet.Products
        Dim rows() As System.Data.DataRow

        ' Check if a product is selected.
        If Not Me.ProductNameListBox.SelectedIndex < 0 Then

            Dim product As String = Me.ProductNameListBox.SelectedItem.Row.Item("ProductName")
            Dim company As String = Me.CompanyNameComboBox.Text

            ' Return the data row from the selected Product in the list box.
            rows = tbl.Select("[ProductName] = '" & product.Replace("'", "''") & "'")

            AddData(rows(0), company)

        Else
            MessageBox.Show("Please select a product.", "Actions Pane", MessageBoxButtons.OK)
        End If
    End Sub
    '</Snippet4>

End Class
