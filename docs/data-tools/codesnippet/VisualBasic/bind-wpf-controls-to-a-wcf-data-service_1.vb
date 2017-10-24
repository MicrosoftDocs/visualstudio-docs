Public Class AdventureWorksService
    Inherits DataService(Of AdventureWorksLTEntities)

    ' This method is called only once to initialize service-wide policies.
    Public Shared Sub InitializeService(ByVal config As IDataServiceConfiguration)
        config.SetEntitySetAccessRule("SalesOrderHeaders", EntitySetRights.All)
        config.UseVerboseErrors = True
    End Sub
End Class