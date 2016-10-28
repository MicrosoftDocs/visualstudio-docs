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