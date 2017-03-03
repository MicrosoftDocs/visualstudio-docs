'<Snippet3>
Imports System

Namespace ServerExplorer.SharePointConnections.WebPartNode

    ' Contains basic data about a single Web Part on the SharePoint site. This class is 
    ' serializable so that instances of it can be sent between the WebPartNode and 
    ' WebPartCommands assemblies.
    <Serializable()> _
    Public Class WebPartNodeInfo

        Private siteIdValue As Guid
        Public Property SiteId As Guid
            Get
                Return siteIdValue
            End Get
            Set(ByVal value As Guid)
                siteIdValue = value
            End Set
        End Property

        Private idValue As Integer
        Public Property Id As Integer
            Get
                Return idValue
            End Get
            Set(ByVal value As Integer)
                idValue = value
            End Set
        End Property

        Private uniqueIdValue As Guid
        Public Property UniqueId As Guid
            Get
                Return uniqueIdValue
            End Get
            Set(ByVal value As Guid)
                uniqueIdValue = value
            End Set
        End Property

        Private nameValue As String
        Public Property Name As String
            Get
                Return nameValue
            End Get
            Set(ByVal value As String)
                nameValue = value
            End Set
        End Property

        Private imageUrlValue As String
        Public Property ImageUrl As String
            Get
                Return imageUrlValue
            End Get
            Set(ByVal value As String)
                imageUrlValue = value
            End Set
        End Property

    End Class
End Namespace
'</Snippet3>
