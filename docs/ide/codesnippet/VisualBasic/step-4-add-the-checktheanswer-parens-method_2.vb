    Private Sub Timer1_Tick() Handles Timer1.Tick

        If CheckTheAnswer() Then
            ' If CheckTheAnswer() returns true, then the user 
            ' got the answer right. Stop the timer  
            ' and show a MessageBox.
            Timer1.Stop()
            MessageBox.Show("You got all of the answers right!", "Congratulations!")
            startButton.Enabled = True
        ElseIf timeLeft > 0 Then
            ' If CheckTheAnswer() return false, keep counting
            ' down. Decrease the time left by one second and 
            ' display the new time left by updating the 
            ' Time Left label.
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