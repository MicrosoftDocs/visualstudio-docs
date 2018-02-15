Imports Word = Microsoft.Office.Interop.Word
'TODO:  Follow these steps to enable the Ribbon (XML) item:

'1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

'Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
'    Return New MyRibbon()
'End Function

'2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
'   actions, such as clicking a button. Note: if you have exported this Ribbon from the
'   Ribbon designer, move your code from the event handlers to the callback methods and
'   modify the code to work with the Ribbon extensibility (RibbonX) programming model.

'3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.

'For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.

<Runtime.InteropServices.ComVisible(True)> _
    Public Class MyRibbon
    Implements Office.IRibbonExtensibility

    Private ribbon As Office.IRibbonUI

    Public Sub New()
    End Sub

    Public Function GetCustomUI(ByVal ribbonID As String) As String Implements Office.IRibbonExtensibility.GetCustomUI
        Return GetResourceText("Trin_Ribbon_Custom_Tab_XML_O12.MyRibbon.xml")
    End Function
    '<Snippet2>
    Public Sub OnTextButton(ByVal control As Office.IRibbonControl)
        Dim currentRange As Word.Range = Globals.ThisAddIn.Application.Selection.Range
        currentRange.Text = "This text was added by the Ribbon."
    End Sub
    '</Snippet2>
    '<Snippet3>
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
    '</Snippet3>
#Region "Ribbon Callbacks"
    'Create callback methods here. For more information about adding callback methods, select the Ribbon XML item in Solution Explorer and then press F1.
    Public Sub Ribbon_Load(ByVal ribbonUI As Office.IRibbonUI)
        Me.ribbon = ribbonUI
    End Sub



#End Region

#Region "Helpers"

    Private Shared Function GetResourceText(ByVal resourceName As String) As String
        Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Dim resourceNames() As String = asm.GetManifestResourceNames()
        For i As Integer = 0 To resourceNames.Length - 1
            If String.Compare(resourceName, resourceNames(i), StringComparison.OrdinalIgnoreCase) = 0 Then
                Using resourceReader As IO.StreamReader = New IO.StreamReader(asm.GetManifestResourceStream(resourceNames(i)))
                    If resourceReader IsNot Nothing Then
                        Return resourceReader.ReadToEnd()
                    End If
                End Using
            End If
        Next
        Return Nothing
    End Function

#End Region

End Class
