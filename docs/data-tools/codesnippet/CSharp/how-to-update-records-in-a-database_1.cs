            // Locate the row you want to update.
            NorthwindDataSet.RegionRow regionRow;
            regionRow = northwindDataSet.Region.FindByRegionID(1);

            // Assign the new value to the desired column.
            regionRow.RegionDescription = "East";

            // Save the updated row to the database.
            this.regionTableAdapter.Update(this.northwindDataSet.Region);