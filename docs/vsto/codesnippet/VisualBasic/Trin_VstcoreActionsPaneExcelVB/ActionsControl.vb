Public Class ActionsControl

    '--------------------------------------------------------------------------
    '<Snippet1>
    Private Sub ActionsControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Load

        Me.ComboBox1.DataSource = Globals.Sheet1.SuppliersBindingSource
        Me.ComboBox1.DisplayMember = "CompanyName"
    End Sub
    '</Snippet1>
End Class
