    private void showButton_Click(object sender, EventArgs e)
    {
        // Show the Open File dialog. If the user clicks OK, load the
        // picture that the user chose.
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            pictureBox1.Load(openFileDialog1.FileName);
        }
    }