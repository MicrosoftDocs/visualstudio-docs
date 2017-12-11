Option Explicit On
Option Strict On

Imports System
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Security

''' <summary>
''' This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
''' </summary>
''' <remarks>
''' The GUID attached to this class may be used during packaging and should not be modified.
''' </remarks>

<GuidAttribute("17734b5e-280c-4554-8701-bc4a99768b0b")> _
Public Class Feature1EventReceiver 
    Inherits SPFeatureReceiver

    ' Uncomment the method below to handle the event raised after a feature has been activated.

    'Public Overrides Sub FeatureActivated(ByVal properties As SPFeatureReceiverProperties)
    'End Sub


    ' Uncomment the method below to handle the event raised before a feature is deactivated.

    ' <Snippet2>
    Public Overrides Sub FeatureDeactivating(ByVal properties As SPFeatureReceiverProperties)
        Try
            ' Get reference to SharePoint site.
            Dim site As SPSite = New SPSite("http://localhost")
            Dim web As SPWeb = site.OpenWeb("/")
            ' Get reference to Announcements list.
            Dim announcementsList As SPList = web.Lists("Announcements")
            ' Add new announcement to Announcements list.
            Dim oListItem As SPListItem = announcementsList.Items.Add
            oListItem("Title") = ("Deactivated Feature: " + properties.Definition.DisplayName)
            oListItem("Body") = (properties.Definition.DisplayName + (" was deactivated on: " + DateTime.Now.ToString))
            oListItem.Update()
        Catch e As Exception
            Console.WriteLine(("Error: " + e.ToString))
        End Try
    End Sub
    ' </Snippet2>

    ' Uncomment the method below to handle the event raised after a feature has been installed.

    'Public Overrides Sub FeatureInstalled(ByVal properties As SPFeatureReceiverProperties)
    'End Sub


    ' Uncomment the method below to handle the event raised before a feature is uninstalled.

    'Public Overrides Sub FeatureUninstalling(ByVal properties As SPFeatureReceiverProperties)
    'End Sub

    ' Uncomment the method below to handle the event raised when a feature is upgrading.

    'Public Overrides Sub FeatureUpgrading(ByVal properties As Microsoft.SharePoint.SPFeatureReceiverProperties, ByVal upgradeActionName As String, ByVal parameters As System.Collections.Generic.IDictionary(Of String, String))
    'End Sub

End Class
