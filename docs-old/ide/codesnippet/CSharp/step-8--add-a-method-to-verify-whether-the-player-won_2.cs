            // If the player gets this far, the timer isn't
            // running and firstClicked isn't null, 
            // so this must be the second icon the player clicked
            // Set its color to black
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            // Check to see if the player won
            CheckForWinner();

            // If the player clicked two matching icons, keep them 
            // black and reset firstClicked and secondClicked 
            // so the player can click another icon
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }