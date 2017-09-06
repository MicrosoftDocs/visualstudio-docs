
Imports System.Runtime.CompilerServices

Namespace UtilityLibraries
    Public Module StringLibrary
        <Extension>
        Public Function StartsWithUpper(s As String) As Boolean
            If (String.IsNullOrWhiteSpace(s)) Then
                Return False
            End If

            Return Char.IsUpper(s(0))
        End Function

        <Extension>
        Public Function StartsWithLower(s As String) As Boolean
            If (String.IsNullOrWhiteSpace(s)) Then
                Return False
            End If

            Return Char.IsLower(s(0))
        End Function

        <Extension>
        Public Function HasEmbeddedSpaces(s As String) As Boolean
             If (String.IsNullOrWhiteSpace(s)) Then
                Return False
            End If

           For Each ch In s.Trim()
                ' <Snippet1>
                If Char.IsWhiteSpace(ch) Then
                ' </Snippet1>
                    Return True
                End If
            Next

            Return False
        End Function
    End Module
End Namespace

