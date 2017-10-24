Public Class ThisAddIn
    '<Snippet2> 
    Private request As ContentService.getContentRequest
    Private proxy As ContentService.ContentServicePortTypeClient
    Private document As ContentService.requestedDocument()
    Private response As ContentService.getContentResponse
    Private appId As ContentService.appId
    Private WithEvents richTextContentControl As Microsoft.Office.Tools.Word.RichTextContentControl
    Private components As System.ComponentModel.Container
    Private primaryDocumentsBindingSource As System.Windows.Forms.BindingSource
    '</Snippet2> 

    '<Snippet3> 
    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        AddRichTextControlAtRange()
        InitializeServiceObjects()
    End Sub
    '</Snippet3> 

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    '<Snippet4> 
    Private Sub AddRichTextControlAtRange()

        Dim currentDocument As Word.Document = Me.Application.ActiveDocument
        currentDocument.Paragraphs(1).Range.InsertParagraphBefore()


        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(currentDocument)


        richTextContentControl = extendedDocument.Controls.AddRichTextContentControl _
            (currentDocument.Paragraphs(1).Range, "richTextControl2")
        richTextContentControl.PlaceholderText = _
            "Click here to download MSDN Library information about content controls."
    End Sub
    '</Snippet4> 

    '<Snippet6>
    Private Sub InitializeServiceObjects()
        request = New ContentService.getContentRequest()
        proxy = New ContentService.ContentServicePortTypeClient()
        document = New ContentService.requestedDocument(0) {}
        response = New ContentService.getContentResponse()
        appId = New ContentService.appId()
        components = New System.ComponentModel.Container()
        primaryDocumentsBindingSource = New System.Windows.Forms.BindingSource(components)
    End Sub
    '</Snippet6>

    '<Snippet5> 
    Private Sub richTextContentControl_Entering _
        (ByVal sender As Object, ByVal e As ContentControlEnteringEventArgs) _
        Handles richTextContentControl.Entering

        document(0) = New ContentService.requestedDocument()
        With document(0)
            .type = ContentService.documentTypes.primary
            .selector = "Mtps.Xhtml"
        End With

        With request
            .contentIdentifier = "ed59e522-dd6e-4c82-8d49-f5dbcfcc950d"
            .locale = "en-us"
            .version = "VS.90"
            .requestedDocuments = document
        End With

        response = proxy.GetContent(appId, request)

        primaryDocumentsBindingSource.DataSource = _
            response.primaryDocuments(0).Any.InnerText
        richTextContentControl.DataBindings.Add("Text", _
            primaryDocumentsBindingSource.DataSource, "", True, _
            System.Windows.Forms.DataSourceUpdateMode.OnValidation)
    End Sub
    '</Snippet5> 

End Class
