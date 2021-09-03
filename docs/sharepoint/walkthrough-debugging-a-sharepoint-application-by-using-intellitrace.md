---
title: "Debug SharePoint application using IntelliTrace"
description: Use IntelliTrace to more easily debug and fix SharePoint applications. Create and add code to a feature receiver. Test the project. Collect IntelliTrace data.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "IntelliTrace [SharePoint development in Visual Studio]"
  - "standalone data collector"
  - "SharePoint development in Visual Studio, IntelliTrace"
  - "data collector"
  - "IntelliTrace"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Debug a SharePoint application by using IntelliTrace

By using IntelliTrace, you can more easily debug SharePoint solutions. Traditional debuggers give you only a snapshot of a solution at the current moment. However, you can use IntelliTrace to review past events that occurred in your solution and the context in which they occurred and navigate to the code.

 This walkthrough demonstrates how to debug a SharePoint project in Visual Studio by using Microsoft Monitoring Agent to collect IntelliTrace data from deployed applications. To analyze that data, you must use Visual Studio Enterprise. This project incorporates a feature receiver that, when the feature is activated, adds a task to the Task list and an announcement to the Announcements list. When the feature is deactivated, the task is marked as completed, and a second announcement is added to the Announcements list. However, the procedure contains a logical error that prevents the project from running correctly. By using IntelliTrace, you'll locate and correct the error.

 **Applies to:** The information in this topic applies to SharePoint solutions that were created in Visual Studio.

 This walkthrough illustrates the following tasks:

- [Create a Feature Receiver](#create-a-feature-receiver)

- [Add Code to the Feature Receiver](#add-code-to-the-feature-receiver)

- [Test the Project](#test-the-project)

- [Collect IntelliTrace Data by using Microsoft Monitoring Agent](#collect-intellitrace-data-by-using-microsoft-monitoring-agent)

- [Debug and Fix the SharePoint Solution](#debug-and-fix-the-sharepoint-solution)

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites

You need the following components to complete this walkthrough:

- Supported editions of Windows and SharePoint.

- Visual Studio Enterprise.

## Create a feature receiver

First, you create an empty SharePoint project that has a feature receiver.

1. Create a SharePoint solution project targeting the version of SharePoint you have installed, and name it **IntelliTraceTest**.

     The **SharePoint Customization Wizard** appears, in which you can specify both the SharePoint site for your project and the trust level of the solution.

2. Choose the **Deploy as a farm solution** option button, and then choose the **Finish** button.

     IntelliTrace operates only on farm solutions.

3. In **Solution Explorer**, open the shortcut menu for the **Features** node, and then choose **Add Feature**.

     *Feature1.feature* appears.

4. Open the shortcut menu for Feature1.feature, and then choose **Add Event Receiver** to add a code module to the feature.

## Add code to the feature receiver

Next, add code to two methods in the feature receiver: `FeatureActivated` and `FeatureDeactivating`. These methods trigger whenever a feature is activated or deactivated in SharePoint, respectively.

1. At the top of the `Feature1EventReceiver` class, add the following code, which declares variables that specify the SharePoint site and subsite:

    ```vb
    ' SharePoint site and subsite.
    Private siteUrl As String = "http://localhost"
    Private webUrl As String = "/"
    ```

    ```csharp
    // SharePoint site and subsite.
    private string siteUrl = "http://localhost";
    private string webUrl = "/";
    ```

2. Replace the `FeatureActivated` method with the following code:

    ```vb
    Public Overrides Sub FeatureActivated(ByVal properties As SPFeatureReceiverProperties)
        Try
            Using site As New SPSite(siteUrl)
                Using web As SPWeb = site.OpenWeb(webUrl)
                    ' Reference the lists.
                    Dim announcementsList As SPList = web.Lists("Announcements")
                    Dim taskList As SPList = web.Lists("Tasks")

                    ' Add an announcement to the Announcements list.
                    Dim listItem As SPListItem = announcementsList.Items.Add()
                    listItem("Title") = "Activated Feature: " & Convert.ToString(properties.Definition.DisplayName)
                    listItem("Body") = Convert.ToString(properties.Definition.DisplayName) & " was activated on: " & DateTime.Now.ToString()
                    listItem.Update()

                    ' Add a task to the Task list.
                    Dim newTask As SPListItem = taskList.Items.Add()
                    newTask("Title") = "Deactivate feature: " & Convert.ToString(properties.Definition.DisplayName)
                    newTask.Update()
                End Using
            End Using

        Catch e As Exception
            Console.WriteLine("Error: " & e.ToString())
        End Try

    End Sub
    ```

    ```csharp
    public override void FeatureActivated(SPFeatureReceiverProperties properties)
    {
        try
        {
            using (SPSite site = new SPSite(siteUrl))
            {
                using (SPWeb web = site.OpenWeb(webUrl))
                {
                    // Reference the lists.
                    SPList announcementsList = web.Lists["Announcements"];
                    SPList taskList = web.Lists["Tasks"];

                    // Add an announcement to the Announcements list.
                    SPListItem listItem = announcementsList.Items.Add();
                    listItem["Title"] = "Activated Feature: " + properties.Definition.DisplayName;
                    listItem["Body"] = properties.Definition.DisplayName + " was activated on: " + DateTime.Now.ToString();
                    listItem.Update();

                    // Add a task to the Task list.
                    SPListItem newTask = taskList.Items.Add();
                    newTask["Title"] = "Deactivate feature: " + properties.Definition.DisplayName;
                    newTask.Update();
                }
            }
        }

        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.ToString());
        }

    }
    ```

3. Replace the `FeatureDeactivating` method with the following code:

    ```vb
    Public Overrides Sub FeatureDeactivating(ByVal properties As SPFeatureReceiverProperties)
        ' The following line induces an error to demonstrate debugging.
        ' Remove this line later for proper operation.
        Throw New System.InvalidOperationException("Serious error occurred!")
        Try
            Using site As New SPSite(siteUrl)
                Using web As SPWeb = site.OpenWeb(webUrl)
                    ' Reference the lists.
                    Dim taskList As SPList = web.Lists("Tasks")
                    Dim announcementsList As SPList = web.Lists("Announcements")

                    ' Add an announcement that the feature was deactivated.
                    Dim listItem As SPListItem = announcementsList.Items.Add()
                    listItem("Title") = "Deactivated Feature: " & Convert.ToString(properties.Definition.DisplayName)
                    listItem("Body") = Convert.ToString(properties.Definition.DisplayName) & " was deactivated on: " & DateTime.Now.ToString()
                    listItem.Update()

                    ' Find the task that the feature receiver added to the Task list when the
                    ' feature was activated.
                    Dim qry As New SPQuery()
                    qry.Query = "<Where><Contains><FieldRef Name='Title' /><Value Type='Text'>Deactivate</Value></Contains></Where>"
                    Dim taskItems As SPListItemCollection = taskList.GetItems(qry)

                    For Each taskItem As SPListItem In taskItems
                        ' Mark the task as complete.
                        taskItem("PercentComplete") = 1
                        taskItem("Status") = "Completed"
                        taskItem.Update()
                    Next
                End Using

            End Using

        Catch e As Exception
            Console.WriteLine("Error: " & e.ToString())
        End Try

    End Sub
    ```

    ```csharp
    public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
    {
        // The following line induces an error to demonstrate debugging.
        // Remove this line later for proper operation.
        throw new System.InvalidOperationException("A serious error occurred!");
        try
        {
            using (SPSite site = new SPSite(siteUrl))
            {
                using (SPWeb web = site.OpenWeb(webUrl))
                {
                    // Reference the lists.
                    SPList taskList = web.Lists["Tasks"];
                    SPList announcementsList = web.Lists["Announcements"];

                    // Add an announcement that the feature was deactivated.
                    SPListItem listItem = announcementsList.Items.Add();
                    listItem["Title"] = "Deactivated Feature: " + properties.Definition.DisplayName;
                    listItem["Body"] = properties.Definition.DisplayName + " was deactivated on: " + DateTime.Now.ToString();
                    listItem.Update();

                    // Find the task that the feature receiver added to the Task list when the
                    // feature was activated.
                    SPQuery qry = new SPQuery();
                    qry.Query = "<Where><Contains><FieldRef Name='Title' /><Value Type='Text'>Deactivate</Value></Contains></Where>";
                    SPListItemCollection taskItems = taskList.GetItems(qry);

                    foreach (SPListItem taskItem in taskItems)
                    {
                        // Mark the task as complete.
                        taskItem["PercentComplete"] = 1;
                        taskItem["Status"] = "Completed";
                        taskItem.Update();
                    }
                }
            }

        }

        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.ToString());
        }
    }
    ```

## Test the project

Now that the code is added to the feature receiver and the data collector is running, deploy and run the SharePoint solution to test whether it works correctly.

> [!IMPORTANT]
> For this example, an error is thrown in the FeatureDeactivating event handler. Later in this walkthrough, you locate this error by using the .iTrace file that the data collector created.

1. Deploy the solution to SharePoint, and then open the SharePoint site in a browser.

     The feature automatically activates, causing its feature receiver to add an announcement and a task.

2. Display the contents of the Announcements and Tasks lists.

     The Announcements list should have a new announcement that's named **Activated feature: IntelliTraceTest_Feature1**, and the Tasks list should have a new task that's named **Deactivate feature: IntelliTraceTest_Feature1**. If either of these items is missing, verify whether the feature is activated. If it isn't activated, activate it.

3. Deactivate the feature by performing the following steps:

   1. On the **Site Actions** menu in SharePoint, choose **Site Settings**.

   2. Under **Site Actions**, choose the **Manage site features** link.

   3. Next to **IntelliTraceTest Feature1**, choose the **Deactivate** button.

   4. On the Warning page, choose the **Deactivate this feature** link.

      The FeatureDeactivating() event handler throws an error.

## Collect IntelliTrace data by using Microsoft Monitoring Agent

If you install Microsoft Monitoring Agent on the system that's running SharePoint, you can debug SharePoint solutions by using data that's more specific than the generic information that IntelliTrace returns. The agent works outside of Visual Studio by using PowerShell cmdlets to capture debug information while your SharePoint solution runs.

> [!NOTE]
> The configuration information in this section is specific to this example. For more information about other configuration options, see [Using the IntelliTrace stand-alone collector](../debugger/using-the-intellitrace-stand-alone-collector.md).

1. On the computer that's running SharePoint, [set up Microsoft Monitoring Agent and start to monitor your solution](../debugger/using-the-intellitrace-stand-alone-collector.md).

2. Deactivate the feature:

   1. On the **Site Actions** menu in SharePoint, choose **Site Settings**.

   2. Under **Site Actions**, choose the **Manage site features** link.

   3. Next to **IntelliTraceTest Feature1**, choose the **Deactivate** button.

   4. On the Warning page, choose the **Deactivate this feature** link.

      An error occurs (in this case, because of the error thrown in the FeatureDeactivating() event handler).

3. In the PowerShell window, run the [Stop-WebApplicationMonitoring](/previous-versions/system-center/powershell/system-center-2012-r2/dn472753(v=sc.20)) command to create the .iTrace file, stop monitoring, and restart your SharePoint solution.

     **Stop-WebApplicationMonitoring**  *"\<SharePointSite>\\<SharePointAppName\>"*

## Debug and fix the SharePoint solution

Now you can view the IntelliTrace log file in Visual Studio to find and fix the error in the SharePoint solution.

1. In the \IntelliTraceLogs folder, open the .iTrace file in Visual Studio.

     The **IntelliTrace Summary** page appears. Because the error wasn't handled, a SharePoint correlation ID (a GUID) appears in the unhandled exception area of the **Analysis** section. Choose the **Call Stack** button if you want to view the call stack where the error occurred.

2. Choose the **Debug Exception** button.

     If prompted, load symbol files. In the **IntelliTrace** window, the exception is highlighted as "Thrown: Serious error occurred!".

     In the IntelliTrace window, choose the exception to display the code that failed.

3. Fix the error by opening the SharePoint solution and then either commenting out or removing the **throw** statement at the top of the FeatureDeactivating() procedure.

4. Rebuild the solution in Visual Studio, and then redeploy it to SharePoint.

5. Deactivate the feature by performing the following steps:

    1. On the **Site Actions** menu in SharePoint, choose **Site Settings**.

    2. Under **Site Actions**, choose the **Manage site features** link.

    3. Next to **IntelliTraceTest Feature1**, choose the **Deactivate** button.

    4. On the Warning page, choose the **Deactivate this feature** link.

6. Open the Task list, and verify that the **Status** value of the Deactivate task is "Completed" and its **% Complete** value is 100%.

     The code now runs properly.

## See also

- [Verify and debug SharePoint code](../sharepoint/verifying-and-debugging-sharepoint-code.md)
- [IntelliTrace](../debugger/intellitrace.md)
- [Walkthrough: Verify SharePoint Code by Using Unit Tests](/previous-versions/visualstudio/visual-studio-2010/gg599006\(v\=vs.100\))
