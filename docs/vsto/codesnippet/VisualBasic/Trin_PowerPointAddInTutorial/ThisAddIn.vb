Public Class ThisAddIn

    '<Snippet1>
    Private Sub Application_PresentationNewSlide(ByVal Sld As PowerPoint.Slide) _
        Handles Application.PresentationNewSlide
        Dim textBox As PowerPoint.Shape = Sld.Shapes.AddTextbox( _
            Office.MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 500, 50)
        textBox.TextFrame.TextRange.InsertAfter("This text was added by using code.")
    End Sub
    '</Snippet1>

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class
