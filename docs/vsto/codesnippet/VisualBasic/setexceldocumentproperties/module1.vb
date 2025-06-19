'<Snippet1>
Imports Microsoft.VisualStudio.Tools.Applications.Runtime
Imports Microsoft.VisualStudio.Tools.Applications

Module Module1

    Sub Main()

        Dim assemblyLocation As String = ""
        Dim solutionID As Guid
        Dim deploymentManifestLocation As Uri = Nothing
        Dim documentLocation As String = ""
        Dim nonpublicCachedDataMembers As String() = Nothing

        Dim CommandLineArgs As  _
            System.Collections.ObjectModel.ReadOnlyCollection(Of String) = _
            My.Application.CommandLineArgs

        For i As Integer = 0 To CommandLineArgs.Count - 1

            Console.WriteLine(CommandLineArgs(i))
            Dim oArugment As String() = CommandLineArgs(i).Split("=")

            Select Case oArugment(0)

                Case "/assemblyLocation"
                    assemblyLocation = oArugment(1)

                Case "/deploymentManifestLocation"
                    If Not Uri.TryCreate(oArugment(1), UriKind.Absolute, _
                                         deploymentManifestLocation) Then
                        MsgBox("Error creating URI")
                    End If

                Case "/documentLocation"
                    documentLocation = oArugment(1)

                Case "/solutionID"
                    solutionID = Guid.Parse(oArugment(1))
            End Select
        Next
        Try
            ServerDocument.RemoveCustomization(documentLocation)
            ServerDocument.AddCustomization(documentLocation, assemblyLocation, _
                                            solutionID, deploymentManifestLocation, _
                                            True, nonpublicCachedDataMembers)

            Console.WriteLine("Installation Location Modified Successfully")

        Catch ex As System.IO.FileNotFoundException
            Console.WriteLine("The specified document does not exist.")
            Console.ReadLine()


        Catch ex As System.IO.IOException
            Console.WriteLine("The specified document is read-only.")
            Console.ReadLine()


        Catch ex As InvalidOperationException

            Console.WriteLine("The customization could not be removed.\n" &
                ex.Message)
            Console.ReadLine()


        Catch ex As DocumentNotCustomizedException
            Console.WriteLine("The document could not be customized.\n" &
                ex.Message)
            Console.ReadLine()

        End Try
    End Sub

End Module
'</Snippet1>


