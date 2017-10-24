        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("ja-JP")
            GetSatelliteAssemblies(Thread.CurrentThread.CurrentUICulture.ToString())
        End Sub

        Private Shared Sub GetSatelliteAssemblies(ByVal groupName As String)
            If (ApplicationDeployment.IsNetworkDeployed) Then

                Dim deploy As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

                If (deploy.IsFirstRun) Then
                    Try
                        deploy.DownloadFileGroup(groupName)
                    Catch de As DeploymentException
                        ' Log error. Do not report this error to the user, because a satellite
                        ' assembly may not exist if the user's culture and the application's
                        ' default culture match.
                    End Try
                End If
            End If
        End Sub