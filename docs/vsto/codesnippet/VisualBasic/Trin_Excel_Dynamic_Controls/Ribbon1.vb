Imports Microsoft.Office.Tools.Ribbon
'<Snippet1>
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Tools.Excel
Imports Microsoft.Office.Tools.Excel.Extensions
'</Snippet1>
Public Class Ribbon1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub
    '<Snippet2>
    Private Sub Button_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles Button.Click

        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)


        Dim buttonName As String = "MyButton"

        If CType(sender, RibbonCheckBox).Checked Then
            Dim selection As Excel.Range = Globals.ThisAddIn.Application.Selection
            If Not (selection Is Nothing) Then
                Dim button As New Microsoft.Office.Tools.Excel.Controls.Button()
                worksheet.Controls.AddControl(button, selection, buttonName)
            End If
        Else
            worksheet.Controls.Remove(buttonName)
        End If
    End Sub
    '</Snippet2>
    '<Snippet3>
    Private Sub NamedRange_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles NamedRange.Click

        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim rangeName As String = "MyNamedRange"

        If CType(sender, RibbonCheckBox).Checked Then
            Dim selection As Excel.Range = Globals.ThisAddIn.Application.Selection
            If Not (selection Is Nothing) Then
                Dim namedRange As NamedRange = _
                    worksheet.Controls.AddNamedRange(selection, rangeName)
            End If
        Else
            worksheet.Controls.Remove(rangeName)
        End If
    End Sub
    '</Snippet3>
    '<Snippet4>
    Private Sub ListObject_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles ListObject.Click

        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)


        Dim listObjectName As String = "MyListObject"

        If CType(sender, RibbonCheckBox).Checked Then
            Dim selection As Excel.Range = _
                Globals.ThisAddIn.Application.Selection
            If Not (selection Is Nothing) Then
                worksheet.Controls.AddListObject(selection, listObjectName)
            End If
        Else
            worksheet.Controls.Remove(listObjectName)
        End If
    End Sub
    '</Snippet4>
End Class
