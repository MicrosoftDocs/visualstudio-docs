        ' Locate the row you want to update.
        Dim regionRow As NorthwindDataSet.RegionRow
        regionRow = NorthwindDataSet._Region.FindByRegionID(1)

        ' Assign the new value to the desired column.
        regionRow.RegionDescription = "East"

        ' Save the updated row to the database
        Me.RegionTableAdapter.Update(Me.NorthwindDataSet._Region)