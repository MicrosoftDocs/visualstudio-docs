        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim SR As StreamReader = Nothing

            Try
                SR = New StreamReader(ApplicationDeployment.CurrentDeployment.DataDirectory & "\CSV.txt")
                MessageBox.Show(SR.ReadToEnd())
            Catch Ex As Exception
                MessageBox.Show("Could not read file.")
            Finally
                SR.Close()
            End Try
        End If