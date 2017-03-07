Public Class ThisDocument

    '<Snippet1>
    <CachedAttribute()> _
    Public CachedString As String = "This string is cached in the document."

    '<Snippet2>
    Private protectionTypeValue As Word.WdProtectionType

    Protected Overrides Sub UnprotectDocument()
        If Me.ProtectionType <> Word.WdProtectionType.wdNoProtection Then
            protectionTypeValue = Me.ProtectionType
            Me.Unprotect(securelyStoredPassword)
        End If
    End Sub
    '</Snippet2>

    '<Snippet3>
    Protected Overrides Sub ProtectDocument()
        Me.Protect(protectionTypeValue, password:=securelyStoredPassword)
    End Sub
    '</Snippet3>
    '</Snippet1>

    'Everything below here is "infrastructure" code to test out the 
    ' snippets.
    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        TextBox1.Text = Me.CachedString
    End Sub

    Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    Private securelyStoredPassword As Object = GetPassword()

    Private Shared Function GetPassword() As String
        Return "secure"
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Protect(Word.WdProtectionType.wdAllowOnlyReading)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(Me.CachedString)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.CachedString = Me.TextBox1.Text
    End Sub
End Class
