Public Class ThisAddIn

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        '<snippet1> 
        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveSheet
        If NativeWorksheet IsNot Nothing Then
            Dim vstoSheet As Microsoft.Office.Tools.Excel.Worksheet =
                Globals.Factory.GetVstoObject(NativeWorksheet)
        End If
        '</snippet1> 

        '<snippet2> 
        Dim NativeWorkbook As Microsoft.Office.Interop.Excel.Workbook =
            Globals.ThisAddIn.Application.ActiveWorkbook
        If NativeWorkbook IsNot Nothing Then
            Dim vstoWorkbook As Microsoft.Office.Tools.Excel.Workbook =
                Globals.Factory.GetVstoObject(NativeWorkbook)
        End If
        '</snippet2> 

        '<snippet3> 
        Dim sheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveSheet
        If sheet.ListObjects.Count > 0 Then
            Dim listObject As Excel.ListObject = sheet.ListObjects(1)
            Dim vstoListObject As Microsoft.Office.Tools.Excel.ListObject =
                Globals.Factory.GetVstoObject(listObject)
        End If
        '</snippet3> 

    End Sub

    '<Snippet4>
    WithEvents displayAddress As Microsoft.Office.Tools.Excel.Action

    Private Sub AddSmartTagToWorkbook(ByVal workbook As Excel.Workbook)
        ' Create a smart tag for .NET Framework 3.5 projects.
        ' Dim smartTagDemo As New  _
        '    Microsoft.Office.Tools.Excel.SmartTag( _
        '    "www.microsoft.com/Demo#DemoSmartTag", _
        '    "Demonstration Smart Tag")
        ' Create a smart tag for .NET Framework 4 projects.
        Dim smartTagDemo As SmartTag = Globals.Factory.CreateSmartTag(
            "www.microsoft.com/Demo#DemoSmartTag",
            "Demonstration Smart Tag")

        ' Specify a term and an expression to recognize.
        smartTagDemo.Terms.Add("sale")
        smartTagDemo.Expressions.Add( _
            New System.Text.RegularExpressions.Regex( _
            "[I|i]ssue\s\d{5,6}"))

        ' Create the action for .NET Framework 3.5 projects.
        ' displayAddress = New Microsoft.Office.Tools.Excel.Action( _
        '    "To be replaced")
        ' Create the action for .NET Framework 4 projects.
        displayAddress = Globals.Factory.CreateAction("To be replaced")

        ' Add the action to the smart tag.
        smartTagDemo.Actions = New Microsoft.Office.Tools.Excel.Action() { _
                displayAddress}


        ' Get the host item for the workbook in .NET Framework 3.5 projects.
        ' Dim vstoWorkbook As Microsoft.Office.Tools.Excel.Workbook = _
        '  workbook.GetVstoObject()
        ' Get the host item for the workbook in .NET Framework 4 projects.
        Dim vstoWorkbook As Microsoft.Office.Tools.Excel.Workbook = _
            Globals.Factory.GetVstoObject(workbook)

        ' Add the smart tag to the active workbook.
        vstoWorkbook.VstoSmartTags.Add(smartTagDemo)
    End Sub


    Private Sub DisplayAddress_BeforeCaptionShow(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Excel.ActionEventArgs) _
        Handles displayAddress.BeforeCaptionShow

        Dim clickedAction As Microsoft.Office.Tools.Excel.Action = _
            TryCast(sender, Microsoft.Office.Tools.Excel.Action)

        If clickedAction IsNot Nothing Then
            clickedAction.Caption = "Display the address of " & e.Text
        End If

    End Sub

    Private Sub DisplayAddress_Click(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Excel.ActionEventArgs) _
        Handles displayAddress.Click

        Dim smartTagAddress As String = e.Range.Address( _
            ReferenceStyle:=Excel.XlReferenceStyle.xlA1)
        MsgBox("The recognized text '" & e.Text & _
                "' is at range " & smartTagAddress)
    End Sub
    '</Snippet4>
    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
