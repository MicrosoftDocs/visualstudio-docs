Public Class ThisWorkbook

    Private Sub ThisWorkbook_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub ThisWorkbook_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub


    '--------------------------------------------------------------------------
    '<Snippet12>
    Private Sub SetPassword()
        Dim password As String
        Dim confirmPassword As String

        password = Me.Application.InputBox("Enter the new password:").ToString()
        confirmPassword = Me.Application.InputBox("Confirm the password:").ToString()

        If password <> confirmPassword Then
            MessageBox.Show("The passwords you typed do not match.")
            Globals.ThisWorkbook.Password = ""
        Else
            Globals.ThisWorkbook.Password = password
        End If
    End Sub
    '</Snippet12>


    '--------------------------------------------------------------------------
    Sub Test()
        Dim getPasswordFromUser As String = "password"

        '<Snippet11>
        Me.Unprotect(getPasswordFromUser)
        '</Snippet11>


        '<Snippet10>
        Me.Protect(getPasswordFromUser)
        '</Snippet10>


        '<Snippet6>
        Me.SaveCopyAs("C:\Book1.xlsx")
        '</Snippet6>


        '<Snippet5>
        Me.SaveAs("C:\Book1.xml")
        '</Snippet5>

        '<Snippet4>
        Me.Save()
        '</Snippet4>

        Dim wkb As Excel.Workbook
        For Each wkb In Me.Application.Workbooks
            wkb.Save()
        Next wkb

    End Sub

End Class
