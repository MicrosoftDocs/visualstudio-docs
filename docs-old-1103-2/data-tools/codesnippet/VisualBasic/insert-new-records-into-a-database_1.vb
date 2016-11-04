        ' Create a new row.
        Dim newRegionRow As NorthwindDataSet.RegionRow
        newRegionRow = Me.NorthwindDataSet._Region.NewRegionRow()
        newRegionRow.RegionID = 5
        newRegionRow.RegionDescription = "NorthWestern"

        ' Add the row to the Region table
        Me.NorthwindDataSet._Region.Rows.Add(newRegionRow)

        ' Save the new row to the database
        Me.RegionTableAdapter.Update(Me.NorthwindDataSet._Region)