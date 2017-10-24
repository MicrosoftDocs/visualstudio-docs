Option Explicit On
Option Strict On

Imports System
Imports System.Security.Permissions
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Security
Imports Microsoft.SharePoint.Utilities
Imports Microsoft.SharePoint.Workflow

Public Class ProjectTaskListEventReceiver 
    Inherits SPItemEventReceiver

	''' <summary>
	''' An item was added.
    ''' </summary>
    '<snippet1>
    Public Overrides Sub ItemAdded(ByVal properties As SPItemEventProperties)
        MyBase.ItemAdded(properties)
        Dim web As SPWeb = properties.OpenWeb()
        properties.ListItem("Due Date") = "July 1, 2009"
        properties.ListItem("Description") = "This is a critical task."
        properties.ListItem.Update()
    End Sub
    '</snippet1>


End Class
