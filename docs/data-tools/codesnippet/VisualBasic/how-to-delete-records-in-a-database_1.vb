        ' Locate the row to delete.
        Dim oldRegionRow As NorthwindDataSet.RegionRow
        oldRegionRow = NorthwindDataSet._Region.FindByRegionID(5)

        ' Delete the row from the dataset
        oldRegionRow.Delete()

        ' Delete the row from the database
        Me.RegionTableAdapter.Update(Me.NorthwindDataSet._Region)