Public Class ThisDocument

    '--------------------------------------------------------------------------
    '<Snippet15>
    Private Sub ChartOptions1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ChartOptions1.SelectionChanged

        Try
            Dim shape As Word.Shape = Me.Shapes.Item(1)

            ' Activate the shape.
            shape.OLEFormat.Activate()

            Dim dataChart As Graph.Chart = CType(shape.OLEFormat.Object, Graph.Chart)
            dataChart.ChartType = Me.ChartOptions1.Selection

            ' Deactivate the shape.
            Me.ChartOptions1.Select()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '</Snippet15>


    '--------------------------------------------------------------------------
    '<Snippet7>
    Private Sub insertText_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles insertText.Click

        Me.displayText.Text += "Hello World!"
    End Sub
    '</Snippet7>


    '--------------------------------------------------------------------------
    '<Snippet3>
    Private Sub applyBoldFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles applyBoldFont.Click

        Me.fontText.Bold = Me.applyBoldFont.Checked
    End Sub
    '</Snippet3>


    '--------------------------------------------------------------------------
    '<Snippet4>
    Private Sub applyItalicFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles applyItalicFont.Click

        Me.fontText.Italic = Me.applyItalicFont.Checked
    End Sub
    '</Snippet4>


    '--------------------------------------------------------------------------
    '<Snippet5>
    Private Sub applyUnderlineFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles applyUnderlineFont.Click

        If Me.applyUnderlineFont.Checked Then
            Me.fontText.Underline = Word.WdUnderline.wdUnderlineSingle
        Else
            Me.fontText.Underline = Word.WdUnderline.wdUnderlineNone
        End If
    End Sub
    '</Snippet5>


    '--------------------------------------------------------------------------
    '<Snippet1>
    ' Create the command bar variables at the class level.
    Dim commandBar As Office.CommandBar
    Dim firstButton As Office.CommandBarButton
    Dim secondButton As Office.CommandBarButton

    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup
        AddToolbar()
    End Sub

    Private Sub AddToolbar()
        Try
            commandBar = Me.CommandBars("Test")
        Catch ex As ArgumentException
            ' Toolbar named Test does not exist so we should create it.
        End Try

        If commandBar Is Nothing Then
            commandBar = Application.CommandBars.Add("Test", 1, False, True)
        End If

        Try
            ' Add a button to the command bar and create an event handler.
            firstButton = CType(commandBar.Controls.Add(1), Office.CommandBarButton)
            firstButton.Style = Office.MsoButtonStyle.msoButtonCaption
            firstButton.Caption = "button 1"
            firstButton.Tag = "button1"
            AddHandler firstButton.Click, AddressOf ButtonClick

            ' Add a second button to the command bar and create an event handler.
            secondButton = CType(commandBar.Controls.Add(1), Office.CommandBarButton)
            secondButton.Style = Office.MsoButtonStyle.msoButtonCaption
            secondButton.Caption = "button 2"
            secondButton.Tag = "button2"
            AddHandler secondButton.Click, AddressOf ButtonClick

            commandBar.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Handles the event when a button on the new toolbar is clicked.
    Private Sub ButtonClick(ByVal ctrl As Office.CommandBarButton, ByRef Cancel As Boolean)
        MsgBox("You clicked: " & ctrl.Caption)
    End Sub
    '</Snippet1>

End Class
