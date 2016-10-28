    /// <summary>
    /// This timer is started when the player clicks 
    /// two icons that don't match,
    /// so it counts three quarters of a second 
    /// and then turns itself off and hides both icons
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timer1_Tick(object sender, EventArgs e)
    {
        // Stop the timer
        timer1.Stop();

        // Hide both icons
        firstClicked.ForeColor = firstClicked.BackColor;
        secondClicked.ForeColor = secondClicked.BackColor;

        // Reset firstClicked and secondClicked 
        // so the next time a label is
        // clicked, the program knows it's the first click
        firstClicked = null;
        secondClicked = null;
    }