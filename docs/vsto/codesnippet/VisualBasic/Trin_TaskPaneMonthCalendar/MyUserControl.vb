
'<Snippet1>
Imports Office = Microsoft.Office.Core
Imports PowerPoint = Microsoft.Office.Interop.PowerPoint
'</Snippet1>

Public Class MyUserControl

    '<Snippet2>
    Private TextBox As PowerPoint.Shape
    '</Snippet2>

    '<Snippet3>
    Private Sub MonthCalendar1_DateChanged( _
        ByVal sender As System.Object, _
        ByVal e As System.Windows.Forms.DateRangeEventArgs) _
        Handles MonthCalendar1.DateChanged

        Try
            If TextBox IsNot Nothing Then
                TextBox.Delete()
            End If

            Dim Slide As PowerPoint.Slide
            Slide = Globals.ThisAddIn.Application.ActivePresentation.Slides(1)
            TextBox = Slide.Shapes.AddTextbox( _
                Office.MsoTextOrientation.msoTextOrientationHorizontal, _
                50, 100, 600, 50)
            TextBox.TextFrame.TextRange.Text = e.Start.ToLongDateString()
            TextBox.TextFrame.TextRange.Font.Size = 48
            TextBox.TextFrame.TextRange.Font.Color.RGB = _
                System.Drawing.Color.DarkViolet.ToArgb()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.ToString())
        End Try
    End Sub
    '</Snippet3>
End Class
