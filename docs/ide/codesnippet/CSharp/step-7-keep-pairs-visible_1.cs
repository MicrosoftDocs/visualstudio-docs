            // If the player gets this far, the timer isn't
            // running and firstClicked isn't null,
            // so this must be the second icon the player clicked
            // Set its color to black
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            // If the player clicked two matching icons, keep them 
            // black and reset firstClicked and secondClicked 
            // so the player can click another icon
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }

            // If the player gets this far, the player 
            // clicked two different icons, so start the 
            // timer (which will wait three quarters of 
            // a second, and then hide the icons)
            timer1.Start();
        }
    }