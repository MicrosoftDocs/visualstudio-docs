Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        saveDocument()

    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

#Region "createDocument"

    Private Sub createDocument()
        ' Create a blank document that is not based on a template
        '<Snippet1>
        Me.Application.Documents.Add("")
        '</Snippet1>
        ' Create a document based on a drawing
        If (True) Then
            '<Snippet2>
            Dim docPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\test\MyDrawing.vsd"
            Me.Application.Documents.Add(docPath)
            '</Snippet2>
        End If

        ' Create a document based on a stencil
        If (True) Then
            '<Snippet3>
            Dim docPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\test\MyStencil.vss"
            Me.Application.Documents.Add(docPath)
            '</Snippet3>
        End If

        ' Create a document based on a template
        If (True) Then
            '<Snippet4>
            Dim docPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\test\MyTemplate.vst"
            Me.Application.Documents.Add(docPath)
            '</Snippet4>
        End If
    End Sub 'createDocument

#End Region

#Region "openDocument"


    Private Sub openDocument()
        ' Open a document based on a drawing
        If (True) Then
            '<Snippet5>
            Dim docPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\test\MyDrawing.vsd"
            Me.Application.Documents.Open(docPath)
            '</Snippet5>
        End If

        ' Open a document based on a drawing as read-only, open, and docked
        If (True) Then
            '<Snippet6>
            Dim docPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\test\MyDrawing.vsd"
            Me.Application.Documents.OpenEx(docPath, CShort(Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenDocked) + CShort(Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenRO))
            '</Snippet6>
        End If

    End Sub 'openDocument

#End Region

#Region "closeDocument"
    Private Sub closeDocument()
        Me.Application.Documents.Open("d:\test\myDrawing.vsd")
        ' set a visio document to the currently active document and then close
        '<Snippet7>
        Me.Application.ActiveDocument.Close()
        '</Snippet7>
    End Sub 'closeDocument 
#End Region

#Region "printDocument"
    Private Sub printDocument()
        Me.Application.Documents.Open("d:\test\flowchart.vsd")
        ' set a visio document to the currently active document and then print the entire doc
        '<Snippet8>
        Me.Application.ActiveDocument.Print()
        '</Snippet8>

        ' set a visio document to the currently active document and then print only the first page
        '<Snippet9>
        Dim pageIndex As Integer = 1
        Dim visioDocPages As Visio.Pages = Me.Application.ActiveDocument.Pages
        If pageIndex <= visioDocPages.Count Then
            visioDocPages(pageIndex).Print()
        End If
        '</Snippet9>
    End Sub 'printDocument

#End Region

#Region "saveDocument"


    Private Sub saveDocument()
        ' Open a document based on a drawing
        Me.Application.Documents.Open("d:\docs\test\myDrawing.vsd")

        '<Snippet10>
        Dim docPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\test\MyDrawing.vsd"
        Me.Application.ActiveDocument.SaveAs(docPath)
        '</Snippet10>

        '<Snippet11>
        Me.Application.ActiveDocument.Save()
        '</Snippet11>

        '<Snippet12>
        Dim newDocPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\test\MyOtherDrawing.vsd"
        Me.Application.ActiveDocument.SaveAsEx(newDocPath, CShort(Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visSaveAsRO) + CShort(Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visSaveAsListInMRU))
        '</Snippet12>
    End Sub 'saveDocument


#End Region

#Region "addShapes"

    Private Sub addShapes()

        Me.Application.Documents.Add("")

        Dim visioPage As Visio.Page = Me.Application.ActivePage

        Dim visioStencil As Visio.Document = Me.Application.Documents.Open("Basic Shapes.vss")

        Dim visioRectMaster As Visio.Master = visioStencil.Masters("Rectangle")
        Dim visioRectShape As Visio.Shape = visioPage.Drop(visioRectMaster, 4.25, 5.5)
        visioRectShape.Text = "Rectangle text."

        Dim visioStarMaster As Visio.Master = visioStencil.Masters("5-Point Star 7")
        Dim visioStarShape As Visio.Shape = visioPage.Drop(visioStarMaster, 2.0, 5.5)
        visioStarShape.Text = "Star text."

        Dim visioHexagonMaster As Visio.Master = visioStencil.Masters("Hexagon")
        Dim visioHexagonShape As Visio.Shape = visioPage.Drop(visioHexagonMaster, 7.0, 5.5)
        visioHexagonShape.Text = "Hexagon text."

    End Sub 'addShapes 


    Private Sub addShapes2()
        '<Snippet13>
        Me.Application.Documents.Add("")

        Dim visioDocs As Visio.Documents = Me.Application.Documents
        Dim visioStencil As Visio.Document = visioDocs.OpenEx("Basic Shapes.vss", CShort(Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenDocked))

        Dim visioPage As Visio.Page = Me.Application.ActivePage

        Dim visioRectMaster As Visio.Master = visioStencil.Masters("Rectangle")
        Dim visioRectShape As Visio.Shape = visioPage.Drop(visioRectMaster, 4.25, 5.5)
        visioRectShape.Text = "Rectangle text."

        Dim visioStarMaster As Visio.Master = visioStencil.Masters("5-Point Star 7")
        Dim visioStarShape As Visio.Shape = visioPage.Drop(visioStarMaster, 2.0, 5.5)
        visioStarShape.Text = "Star text."

        Dim visioHexagonMaster As Visio.Master = visioStencil.Masters("Hexagon")
        Dim visioHexagonShape As Visio.Shape = visioPage.Drop(visioHexagonMaster, 7.0, 5.5)
        visioHexagonShape.Text = "Hexagon text."
        '</Snippet13>
    End Sub 'addShapes2 
#End Region

#Region "copyShapes"

    Private Sub copyShapesNormal()
        '<Snippet14>
        Me.Application.Documents.Add("")
        Dim copyPage As Visio.Page
        Dim pastePage As Visio.Page
        Dim rectangle As Visio.Shape = Nothing
        Dim oval As Visio.Shape = Nothing

        Dim visioPages As Visio.Pages = Me.Application.ActiveDocument.Pages

        visioPages.Add()

        Try
            copyPage = visioPages(1)
            rectangle = copyPage.DrawRectangle(1.1, 2.2, 4.5, 6.7)
            oval = copyPage.DrawOval(1, 8.75, 3.5, 6.25)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            pastePage = visioPages(2)
            rectangle.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNormal)
            pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNormal)
            oval.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNormal)
            pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNormal)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '</Snippet14>
    End Sub

    Private Sub copyShapesNoTranslate()
        '<Snippet15>
        Me.Application.Documents.Add("")
        Dim copyPage As Visio.Page
        Dim pastePage As Visio.Page
        Dim rectangle As Visio.Shape = Nothing
        Dim oval As Visio.Shape = Nothing

        Dim visioPages As Visio.Pages = Me.Application.ActiveDocument.Pages

        visioPages.Add()

        Try
            copyPage = visioPages(1)
            rectangle = copyPage.DrawRectangle(1.1, 2.2, 4.5, 6.7)
            oval = copyPage.DrawOval(1, 8.75, 3.5, 6.25)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            pastePage = visioPages(2)
            rectangle.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate)
            pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate)
            oval.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate)
            pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '</Snippet15>
    End Sub

#End Region

End Class
