    /// <summary>
    /// Every label's Click event is handled by this event handler
    /// </summary>
    /// <param name="sender">The label that was clicked</param>
    /// <param name="e"></param>
    private void label_Click(object sender, EventArgs e)
    {
        Label clickedLabel = sender as Label;

        if (clickedLabel != null)
        {
            // If the clicked label is black, the player clicked
            // an icon that's already been revealed --
            // ignore the click
            if (clickedLabel.ForeColor == Color.Black)
                return;

            // If firstClicked is null, this is the first icon 
            // in the pair that the player clicked,
            // so set firstClicked to the label that the player 
            // clicked, change its color to black, and return
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;

                return;
            }
        }
    }