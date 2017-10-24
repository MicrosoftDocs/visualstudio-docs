    ''' <summary>
    ''' Check every icon to see if it is matched, by 
    ''' comparing its foreground color to its background color. 
    ''' If all of the icons are matched, the player wins
    ''' </summary>
    Private Sub CheckForWinner()

        ' Go through all of the labels in the TableLayoutPanel, 
        ' checking each one to see if its icon is matched
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing AndAlso 
               iconLabel.ForeColor = iconLabel.BackColor Then Exit Sub
        Next

        ' If the loop didn't return, it didn't find 
        ' any unmatched icons
        ' That means the user won. Show a message and close the form
        MessageBox.Show("You matched all the icons!", "Congratulations")
        Close()

    End Sub