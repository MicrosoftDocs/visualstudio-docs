Public Class Sheet3

    Private Sub Sheet3_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        'TODO: Delete this line of code to remove the default AutoFill for 'NorthwindDataSet.Employees'.
        'If Me.NeedsFill("NorthwindDataSet") Then
        '    Me.EmployeesTableAdapter.Fill(Me.NorthwindDataSet.Employees)
        'End If

        '<Snippet8>
        Me.Button1.Text = "Save"
        '</Snippet8>
    End Sub


    '--------------------------------------------------------------------------
    '<Snippet10>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Button1.Click

        Try
            Me.EmployeesTableAdapter.Update(Me.NorthwindDataSet.Employees)

        Catch ex As System.Data.DataException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '</Snippet10>

End Class
