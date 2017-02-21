#Region "Using directives"

Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Office = Microsoft.Office.Core

'<Snippet1>
Imports Word = Microsoft.Office.Interop.Word
'</Snippet1>

#End Region

'<Snippet2>
' TODO:
' This is an override of the RequestService method in ThisAddin class.
' To hook up your custom ribbon uncomment this code.
Partial Public Class ThisAddIn

    Private ribbon As MyRibbon

    Protected Overrides Function RequestService(ByVal serviceGuid As System.Guid) As Object

        If (serviceGuid = GetType(Office.IRibbonExtensibility).GUID) Then
            If ribbon Is Nothing Then
                ribbon = New MyRibbon()
            End If

            Return ribbon
        End If

        Return MyBase.RequestService(serviceGuid)
    End Function

End Class
'</Snippet2>


<ComVisible(True)> _
    Public Class MyRibbon
    Implements Office.IRibbonExtensibility

#Region "Fields"
    Private ribbon As Office.IRibbonUI
#End Region

#Region "Initialization"

    Public Sub New()
    End Sub

    Public Function GetCustomUI(ByVal ribbonID As String) As String Implements Office.IRibbonExtensibility.GetCustomUI
        Return GetResourceText("MyRibbon.xml")
    End Function

    Public Sub OnLoad(ByVal ribbonUI As Office.IRibbonUI)
        Me.ribbon = ribbonUI
    End Sub

#End Region

    '<Snippet3>
    Public Sub OnTextButton(ByVal control As Office.IRibbonControl)
        Dim currentRange As Word.Range = Globals.ThisAddIn.Application.Selection.Range
        currentRange.Text = "This text was added by the Ribbon."
    End Sub
    '</Snippet3>

    '<Snippet4>
    Public Sub OnTableButton(ByVal control As Office.IRibbonControl)
        Dim missing As Object = System.Type.Missing

        Dim currentRange As Word.Range = Globals.ThisAddIn.Application.Selection.Range
        Dim newTable As Word.Table = Globals.ThisAddIn.Application.ActiveDocument.Tables.Add( _
                currentRange, 3, 4)

        ' Get all of the borders except for the diagonal borders.
        Dim borders() As Word.Border = New Word.Border(6) {}
        borders(0) = newTable.Borders(Word.WdBorderType.wdBorderLeft)
        borders(1) = newTable.Borders(Word.WdBorderType.wdBorderRight)
        borders(2) = newTable.Borders(Word.WdBorderType.wdBorderTop)
        borders(3) = newTable.Borders(Word.WdBorderType.wdBorderBottom)
        borders(4) = newTable.Borders(Word.WdBorderType.wdBorderHorizontal)
        borders(5) = newTable.Borders(Word.WdBorderType.wdBorderVertical)

        ' Format each of the borders.
        For Each border As Word.Border In borders
            border.LineStyle = Word.WdLineStyle.wdLineStyleSingle
            border.Color = Word.WdColor.wdColorBlue
        Next
    End Sub
    '</Snippet4>

#Region "Helpers"
    Public Shared Function GetResourceText(ByVal resourceName As String) As String
        Dim asm As Assembly = Assembly.GetExecutingAssembly()
        Dim resources As String() = asm.GetManifestResourceNames()
        For Each resource As String In resources
            If resource.EndsWith(resourceName) Then
                Dim resourceReader As System.IO.StreamReader
                resourceReader = New System.IO.StreamReader(asm.GetManifestResourceStream(resource))
                If Not resourceReader Is Nothing Then
                    Return resourceReader.ReadToEnd()
                End If
            End If
        Next
        Return Nothing
    End Function
#End Region
End Class
