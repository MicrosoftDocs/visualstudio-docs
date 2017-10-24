            // Create a new row.
            NorthwindDataSet.RegionRow newRegionRow;
            newRegionRow = northwindDataSet.Region.NewRegionRow();
            newRegionRow.RegionID = 5;
            newRegionRow.RegionDescription = "NorthWestern";

            // Add the row to the Region table
            this.northwindDataSet.Region.Rows.Add(newRegionRow);

            // Save the new row to the database
            this.regionTableAdapter.Update(this.northwindDataSet.Region);