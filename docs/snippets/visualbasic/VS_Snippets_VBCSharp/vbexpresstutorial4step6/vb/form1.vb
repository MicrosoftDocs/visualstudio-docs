﻿Public Class Form1

    ' firstClicked points to the first Label control 
    ' that the player clicks, but it will be Nothing 
    ' if the player hasn't clicked a label yet
    Private firstClicked As Label = Nothing

    ' secondClicked points to the second Label control 
    ' that the player clicks
    Private secondClicked As Label = Nothing

    ' <snippet7>
    ''' <summary>
    ''' This timer is started when the player clicks 
    ''' two icons that don't match,
    ''' so it counts three quarters of a second 
    ''' and then turns itself off and hides both icons
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Timer1_Tick() Handles Timer1.Tick

        ' Stop the timer
        Timer1.Stop()

        ' Hide both icons
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor

        ' Reset firstClicked and secondClicked 
        ' so the next time a label is
        ' clicked, the program knows it's the first click
        firstClicked = Nothing
        secondClicked = Nothing

    End Sub
    ' </snippet7>

    ' <snippet8>
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

        ' The timer is only on after two non-matching 
        ' icons have been shown to the player, 
        ' so ignore any clicks if the timer is running
        If Timer1.Enabled Then Exit Sub

        Dim clickedLabel = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then
            ' If the clicked label is black, the player clicked
            ' an icon that's already been revealed --
            ' ignore the click
            If clickedLabel.ForeColor = Color.Black Then Exit Sub

            ' If firstClicked is Nothing, this is the first icon 
            ' in the pair that the player clicked, 
            ' so set firstClicked to the label that the player 
            ' clicked, change its color to black, and return
            If firstClicked Is Nothing Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                Exit Sub
            End If

            ' If the player gets this far, the timer isn't 
            ' running and firstClicked isn't Nothing, 
            ' so this must be the second icon the player clicked
            ' Set its color to black
            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black

            ' If the player gets this far, the player 
            ' clicked two different icons, so start the 
            ' timer (which will wait three quarters of 
            ' a second, and then hide the icons)
            Timer1.Start()
        End If

    End Sub
    ' </snippet8>

End Class




