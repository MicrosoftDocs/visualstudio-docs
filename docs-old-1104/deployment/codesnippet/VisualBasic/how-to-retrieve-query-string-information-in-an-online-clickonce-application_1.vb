    Private Function GetQueryStringParameters() As NameValueCollection
        Dim NameValueTable As New NameValueCollection()

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim QueryString As String = ApplicationDeployment.CurrentDeployment.ActivationUri.Query
            NameValueTable = HttpUtility.ParseQueryString(QueryString)
        End If

        GetQueryStringParameters = NameValueTable
    End Function