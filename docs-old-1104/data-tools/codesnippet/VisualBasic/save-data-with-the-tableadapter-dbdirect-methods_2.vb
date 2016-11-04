    Private Sub UpdateButton_Click() Handles UpdateButton.Click

        Dim newRegionID As Integer = 5

        Try
            RegionTableAdapter1.Update(newRegionID, "Updated Region Description", 5, "NorthEastern")

        Catch ex As Exception
            MessageBox.Show("Update Failed")
        End Try

        RefreshDataset()
    End Sub