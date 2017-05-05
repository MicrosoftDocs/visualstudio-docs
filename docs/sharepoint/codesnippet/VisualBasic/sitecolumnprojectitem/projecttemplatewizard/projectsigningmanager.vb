'<Snippet8>
Imports EnvDTE
Imports System
Imports System.IO
Imports System.Runtime.InteropServices

Friend Class ProjectSigningManager
    Private Const KEY_FILENAME As String = "key.snk"
    Private keyBuffer As Byte()
    Private strongNameGenerated As Boolean = False

#Region "Methods used by the project wizard"

    Friend Sub GenerateKeyFile()
        If Not strongNameGenerated Then
            keyBuffer = CreateNewKeyPair()
            strongNameGenerated = True
        End If
    End Sub

    Friend Sub AddKeyFile(ByVal project As Project)
        If strongNameGenerated Then
            AddKeyFileToProject(project)
        End If
    End Sub
#End Region

#Region "Private members"

    Private Function CreateNewKeyPair() As Byte()
        Dim buffer As IntPtr = IntPtr.Zero
        Dim bufferSize As UInteger
        Dim keyBuffer As Byte()

        Try
            If 0 = NativeMethods.StrongNameKeyGen(IntPtr.Zero, 0, buffer, bufferSize) Then
                Marshal.ThrowExceptionForHR(NativeMethods.StrongNameErrorInfo())
            End If
            If buffer = IntPtr.Zero Then
                Throw New InvalidOperationException("Cannot generate the strong name key.")
            End If

            ' Copy generated key to managed memory.
            keyBuffer = New Byte(bufferSize) {}
            Marshal.Copy(buffer, keyBuffer, 0, CInt(bufferSize))
        Finally
            ' Free native resources.
            NativeMethods.StrongNameFreeBuffer(buffer)
        End Try
        Return keyBuffer
    End Function

    Private Sub AddKeyFileToProject(ByVal project As Project)

        ' Save the key to a file.
        If keyBuffer IsNot Nothing Then
            Try
                Dim destinationDirectory As String = Path.GetDirectoryName(project.FullName)
                Dim keySavePath As String = Path.Combine(destinationDirectory, KEY_FILENAME)

                File.WriteAllBytes(keySavePath, keyBuffer)
                project.ProjectItems.AddFromFile(keySavePath)

                ' Add properties in the project to use the key for signing.
                Dim projProps As EnvDTE.Properties = project.Properties
                projProps.Item("SignAssembly").Value = True
                projProps.Item("AssemblyOriginatorKeyFile").Value = KEY_FILENAME
            Catch e As Exception
                Throw New Exception("Cannot add the strong name key to the project. " & e.Message, e)
            End Try
        End If
    End Sub

    Private Class NativeMethods
        <DllImport("mscoree.dll")>
        Friend Shared Function StrongNameFreeBuffer(ByVal pbMemory As IntPtr) As Integer
        End Function

        <DllImport("mscoree.dll", CharSet:=CharSet.Unicode, ExactSpelling:=True)>
        Friend Shared Function StrongNameKeyGen(ByVal wszKeyContainer As IntPtr, ByVal dwFlags As UInteger, _
            ByRef KeyBlob As IntPtr, ByRef KeyBlobSize As UInteger) As Integer
        End Function

        <DllImport("mscoree.dll", CharSet:=CharSet.Unicode)>
        Friend Shared Function StrongNameErrorInfo() As Integer
        End Function
    End Class
#End Region
End Class
'</Snippet8>
