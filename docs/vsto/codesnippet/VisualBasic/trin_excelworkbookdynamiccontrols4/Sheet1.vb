
Public Class Sheet1

    '<Snippet6>
    Private vstoListObject As Microsoft.Office.Tools.Excel.ListObject
    Private Const DISP_E_BADINDEX As Integer = CInt(&H8002000B)

    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        Dim nativeListObject As Excel.ListObject = Nothing

        Try
            nativeListObject = Me.ListObjects("MyListObject")
        Catch ex As System.Runtime.InteropServices.COMException
            ' "MyListObject" does not exist.
            If ex.ErrorCode <> DISP_E_BADINDEX Then
                Throw
            End If
        End Try

        If nativeListObject IsNot Nothing Then
            vstoListObject = Me.Controls.AddListObject(nativeListObject)
        End If
    End Sub
    '</Snippet6>

    Private Sub Sheet1_Shutdown() Handles Me.Shutdown

    End Sub

End Class
