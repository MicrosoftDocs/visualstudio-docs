
Public Class ThisWorkbook

    '<Snippet1>
    <CachedAttribute()> _
    Public CachedString As String = "This string is cached in the workbook."

    '<Snippet2>
    Private protectStructureValue As Boolean
    Private protectWindowsValue As Boolean

    Protected Overrides Sub UnprotectDocument()
        protectStructureValue = Me.ProtectStructure
        protectWindowsValue = Me.ProtectWindows

        Me.Unprotect(securelyStoredPassword)
    End Sub
    '</Snippet2>

    '<Snippet3>
    Protected Overrides Sub ProtectDocument()
        Me.Protect(securelyStoredPassword, protectStructureValue, _
            protectWindowsValue)
    End Sub
    '</Snippet3>
    '</Snippet1>

    Private Sub ThisWorkbook_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub ThisWorkbook_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    'Some helper stuff that doesn't factor into the actual code snippets.
    Friend securelyStoredPassword As String = GetPassword()

    Private Function GetPassword() As String
        Return "secure"
    End Function

End Class
