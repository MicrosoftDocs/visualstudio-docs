Public Class ThisWorkbook

    '--------------------------------------------------------------------------
    '<Snippet3>
    Private Sub ThisWorkbook_New() Handles Me.New
        ' Your code goes here.
    End Sub
    '</Snippet3>


    '--------------------------------------------------------------------------
    Class AnObject
        Shared Sub aMethod()
        End Sub
    End Class

    Private Sub Test()

        '<Snippet5>
        Dim t As New System.Threading.Thread(AddressOf AnObject.aMethod)

        t.SetApartmentState(System.Threading.ApartmentState.STA)
        t.Start()
        '</Snippet5>
    End Sub

End Class
