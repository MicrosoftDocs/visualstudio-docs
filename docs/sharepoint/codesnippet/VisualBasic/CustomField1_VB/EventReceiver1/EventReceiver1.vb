Option Explicit On
Option Strict On

Imports System
Imports System.Security.Permissions
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Security
Imports Microsoft.SharePoint.Utilities
Imports Microsoft.SharePoint.Workflow

Public Class EventReceiver1 
    Inherits SPItemEventReceiver

	''' <summary>
	''' An item was added.
    ''' </summary>
    ' <Snippet1>
    Public Overrides Sub ItemAdded(ByVal properties As SPItemEventProperties)
        properties.ListItem("Patient Name") = "Scott Brown"
        properties.ListItem.Update()
        MyBase.ItemAdded(properties)
    End Sub
    ' </Snippet1>

End Class
