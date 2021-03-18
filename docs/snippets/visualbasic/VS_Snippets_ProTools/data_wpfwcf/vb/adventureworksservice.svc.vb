Imports System.Data.Services
Imports System.Data.Services.Common
Imports System.Linq
Imports System.ServiceModel.Web

'<Snippet1>
Public Class AdventureWorksService
    Inherits DataService(Of AdventureWorksLTEntities)

    ' This method is called only once to initialize service-wide policies.
    Public Shared Sub InitializeService(ByVal config As IDataServiceConfiguration)
        config.SetEntitySetAccessRule("SalesOrderHeaders", EntitySetRights.All)
        config.UseVerboseErrors = True
    End Sub
End Class
'</Snippet1>
