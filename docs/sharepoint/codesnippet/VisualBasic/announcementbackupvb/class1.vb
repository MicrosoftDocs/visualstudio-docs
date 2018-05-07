' <Snippet1>
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Microsoft.SharePoint

Namespace AnnouncementBackup
    ' This custom activity will back up all of the announcements 
    ' in the Announcements list on the SharePoint site.
    Public Class Class1
        Inherits System.Workflow.ComponentModel.Activity
        Public Sub New()
            MyBase.New()
        End Sub

        ' Triggers when the activity is executed.
        Protected Overrides Function Execute(ByVal executionContext As System.Workflow.ComponentModel.ActivityExecutionContext) As System.Workflow.ComponentModel.ActivityExecutionStatus
            Try
                ' Get a reference to the SharePoint site.
                Dim site As SPSite = New SPSite(("http://" + System.Environment.MachineName))
                Dim web As SPWeb = site.OpenWeb("/")
                ' Reference the original Announcements list.
                Dim aList As SPList = web.GetList("/Lists/Announcements")
                ' If the Announcements Backup list already exists, delete it.
                Try
                    Dim bList As SPList = web.GetList("/Lists/Announcements Backup")
                    bList.Delete()
                Catch
                End Try
                ' Create a new backup Announcements list and reference it.
                Dim newAnnID As Guid = web.Lists.Add("Announcements Backup", "A backup Announcements list.", SPListTemplateType.Announcements)
                Dim bakList As SPList = web.Lists(newAnnID)
                ' Copy announcements from original to backup Announcements list.
                For Each item As SPListItem In aList.Items
                    Dim newAnnItem As SPListItem = bakList.Items.Add
                    For Each field As SPField In aList.Fields
                        If Not field.ReadOnlyField Then
                            newAnnItem(field.Id) = item(field.Id)
                        End If
                    Next
                    newAnnItem.Update()
                Next
                ' Put the Backup Announcements list on the QuickLaunch bar.
                bakList.OnQuickLaunch = True
                bakList.Update()
            Catch errx As Exception
                System.Diagnostics.Debug.WriteLine(("Error: " + errx.ToString))
            End Try
            Return MyBase.Execute(executionContext)
        End Function
    End Class
End Namespace
' </Snippet1>
