    Private Sub InsertButton_Click() Handles InsertButton.Click

        Dim newRegionID As Integer = 5
        Dim newRegionDescription As String = "NorthEastern"

        Try
            RegionTableAdapter1.Insert(newRegionID, newRegionDescription)

        Catch ex As Exception
            MessageBox.Show("Insert Failed")
        End Try

        RefreshDataset()
    End Sub


    Private Sub RefreshDataset()
        Me.RegionTableAdapter1.Fill(Me.NorthwindDataSet1._Region)
    End Sub