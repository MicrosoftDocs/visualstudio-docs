        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (ProceedButton.Enabled)
            {
                accepted = true;
                this.Close();
            }
        }