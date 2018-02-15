'<Snippet2>
Imports System.Data
Imports System.Runtime.InteropServices
Imports Excel = Microsoft.Office.Interop.Excel
'</Snippet2>

'<Snippet3>
<ComVisible(True)> _
Public Interface IAddInUtilities
    Sub ImportData()
End Interface

<ComVisible(True)> _
<ClassInterface(ClassInterfaceType.None)> _
Public Class AddInUtilities
    Implements IAddInUtilities

    ' This method tries to write a string to cell A1 in the active worksheet.
    Public Sub ImportData() Implements IAddInUtilities.ImportData

        Dim activeWorksheet As Excel.Worksheet = Globals.ThisAddIn.Application.ActiveSheet

        If activeWorksheet IsNot Nothing Then
            Dim range1 As Excel.Range = activeWorksheet.Range("A1")
            range1.Value2 = "This is my data"
        End If
    End Sub
End Class
'</Snippet3>