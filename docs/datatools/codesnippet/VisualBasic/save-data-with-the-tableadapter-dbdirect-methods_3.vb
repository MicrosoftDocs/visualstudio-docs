    Private Sub DeleteButton_Click() Handles DeleteButton.Click

        Try
            RegionTableAdapter1.Delete(5, "Updated Region Description")

        Catch ex As Exception
            MessageBox.Show("Delete Failed")
        End Try

        RefreshDataset()
    End Sub