        private void InsertButton_Click(object sender, EventArgs e)
        {
            Int32 newRegionID = 5;
            String newRegionDescription = "NorthEastern";

            try
            {
                regionTableAdapter1.Insert(newRegionID, newRegionDescription);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Failed");
            }
            RefreshDataset();
        }


        private void RefreshDataset()
        {
            this.regionTableAdapter1.Fill(this.northwindDataSet1.Region);
        }