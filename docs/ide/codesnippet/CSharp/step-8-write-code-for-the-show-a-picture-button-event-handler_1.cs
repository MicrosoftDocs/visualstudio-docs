    private void showButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            pictureBox1.Load(openFileDialog1.FileName);  
        }
    }