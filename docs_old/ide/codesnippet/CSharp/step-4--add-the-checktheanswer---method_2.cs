    private void timer1_Tick(object sender, EventArgs e)
    {
        if (CheckTheAnswer())
        {
            // If CheckTheAnswer() returns true, then the user 
            // got the answer right. Stop the timer  
            // and show a MessageBox.
            timer1.Stop();
            MessageBox.Show("You got all the answers right!",
                            "Congratulations!");
            startButton.Enabled = true;
        }
        else if (timeLeft > 0)
        {
           // If CheckTheAnswer() return false, keep counting
           // down. Decrease the time left by one second and 
           // display the new time left by updating the 
           // Time Left label.
           timeLeft--;
            timeLabel.Text = timeLeft + " seconds";
        }
        else
        {
            // If the user ran out of time, stop the timer, show 
            // a MessageBox, and fill in the answers.
            timer1.Stop();
            timeLabel.Text = "Time's up!";
            MessageBox.Show("You didn't finish in time.", "Sorry!");
            sum.Value = addend1 + addend2;
            startButton.Enabled = true;
        }
    }