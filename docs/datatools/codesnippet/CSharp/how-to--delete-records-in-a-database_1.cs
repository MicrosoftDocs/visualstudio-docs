            // Locate the row to delete.
            NorthwindDataSet.RegionRow oldRegionRow;
            oldRegionRow = northwindDataSet.Region.FindByRegionID(5);

            // Delete the row from the dataset
            oldRegionRow.Delete();

            // Delete the row from the database
            this.regionTableAdapter.Update(this.northwindDataSet.Region);