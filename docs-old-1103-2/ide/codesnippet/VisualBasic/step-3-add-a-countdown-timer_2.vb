    Private Sub Timer1_Tick() Handles Timer1.Tick

        If timeLeft > 0 Then
            ' Display the new time left
            ' by updating the Time Left label.
            timeLeft -= 1
            timeLabel.Text = timeLeft & " seconds"
        Else
            ' If the user ran out of time, stop the timer, show
            ' a MessageBox, and fill in the answers.
            Timer1.Stop()
            timeLabel.Text = "Time's up!"
            MessageBox.Show("You didn't finish in time.", "Sorry!")
            sum.Value = addend1 + addend2
            startButton.Enabled = True
        End If

    End Sub