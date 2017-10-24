    ''' <summary>
    ''' Every label's Click event is handled by this event handler
    ''' </summary>
    ''' <param name="sender">The label that was clicked</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub label_Click(ByVal sender As System.Object, 
                            ByVal e As System.EventArgs) Handles Label9.Click, 
        Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, 
        Label3.Click, Label2.Click, Label16.Click, Label15.Click, Label14.Click, 
        Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click

        Dim clickedLabel = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then

            ' If the clicked label is black, the player clicked 
            ' an icon that's already been revealed -- 
            ' ignore the click
            If clickedLabel.ForeColor = Color.Black Then Exit Sub

            clickedLabel.ForeColor = Color.Black
        End If
    End Sub