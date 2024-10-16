---
title: "Walkthrough: Profiling a SharePoint Application"
description: In this walkthrough, use the profiling tools in Visual Studio to optimize the performance of a SharePoint application.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, profiling"
  - "performance testing [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, performance testing"
  - "profiling [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Walkthrough: Profile a SharePoint application

  This walkthrough shows how to use the profiling tools in Visual Studio to optimize the performance of a SharePoint application. The example application is a SharePoint feature event receiver that contains an idle loop that degrades the performance of the feature event receiver. The Visual Studio profiler enables you to locate and eliminate the most expensive (slowest-performing) part of the project, also known as the *hot path*.

 This walkthrough demonstrates the following tasks:

- [Add a feature and feature event receiver](#add-a-feature-and-feature-event-receiver).

- [Configure and Deploy the SharePoint application](#configure-and-deploy-the-sharepoint-application).

- [Run the SharePoint Application](#run-the-sharepoint-application).

- [View and interpret the profile results](#view-and-interpret-the-profile-results).

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- Supported editions of Microsoft Windows and SharePoint.

- Visual Studio 2012.

## Create a SharePoint project
 First, create a SharePoint project.

### To create a SharePoint project

1. On the menu bar, choose **File** > **New** > **Project** to display the **New Project** dialog box.

2. Expand the **SharePoint** node under either **Visual C#** or **Visual Basic**, and then choose the **2010** node.

3. In the templates pane, choose the **SharePoint 2010 Project** template.

4. In the **Name** box, enter **ProfileTest**, and then choose the **OK** button.

    The **SharePoint Customization Wizard** appears.

5. On the **Specify the site and security level for debugging** page, enter the URL for the SharePoint server site where you want to debug the site definition, or use the default location (http://<em>system name</em>/).

6. In the **What is the trust level for this SharePoint solution?** section, choose the **Deploy as a farm solution** option button.

    Currently, you can only profile farm solutions. For more information about sandboxed solutions versus farm solutions, see [Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md).

7. Choose the **Finish** button. The project appears in **Solution Explorer**.

## Add a feature and feature event receiver
 Next, add a feature to the project along with an event receiver for the feature. This event receiver will contain the code to be profiled.

### To add a feature and feature event receiver

1. In **Solution Explorer**, open the shortcut menu for the **Features** node, choose **Add Feature**, and leave the name at the default value, **Feature1**.

2. In **Solution Explorer**, open the shortcut menu for **Feature1**, and then choose **Add Event Receiver**.

     This adds a code file to the feature with several commented-out event handlers and opens the file for editing.

3. In the event receiver class, add the following variable declarations.

    ### [C#](#tab/csharp)
    ```csharp
    // SharePoint site/subsite.
    private string siteUrl = "http://localhost";
    private string webUrl = "/";
    ```

    ### [VB](#tab/vb)
    ```vb
    ' SharePoint site/subsite.
    Private siteUrl As String = "http://localhost"
    Private webUrl As String = "/"
    ```
    ---

4. Replace the `FeatureActivated` procedure with the following code.

    ### [C#](#tab/csharp)
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

                    // Add a new announcement to the Announcements list.
                    SPListItem listItem = announcementsList.Items.Add();
                    listItem["Title"] = "Activated Feature: " + properties.Definition.DisplayName;
                    listItem["Body"] = properties.Definition.DisplayName + " was activated on: " +
    DateTime.Now.ToString();
                    // Waste some time.
                    TimeCounter();
                    // Update the list.
                    listItem.Update();
                }
            }
        }

        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.ToString());
        }
    }
    ```

    ### [VB](#tab/vb)
    ```vb
    Public Overrides Sub FeatureActivated(properties As SPFeatureReceiverProperties)
        Try
            Using site As New SPSite(siteUrl)
                Using web As SPWeb = site.OpenWeb(webUrl)
                    ' Reference the lists.
                    Dim announcementsList As SPList = web.Lists("Announcements")

                    ' Add a new announcement to the Announcements list.
                    Dim listItem As SPListItem = announcementsList.Items.Add()
                    listItem("Title") = "Activated Feature: " & Convert.ToString(properties.Definition.DisplayName)
                    listItem("Body") = Convert.ToString(properties.Definition.DisplayName) & " was activated on: " & DateTime.Now.ToString()
                    ' Waste some time.
                    TimeCounter()
                    ' Update the list.
                    listItem.Update()
                End Using
            End Using

        Catch e As Exception
            Console.WriteLine("Error: " & e.ToString())
        End Try
    End Sub
    ```
    ---

5. Add the following procedure below the `FeatureActivated` procedure.

    ### [C#](#tab/csharp)
    ```csharp
    public void TimeCounter()
    {
        for (int i = 0; i < 100000; i++)
        {
            for (int j = 0; j < 10000; j++)
            {
                int result = i * j;
            }
        }
    }
    ```

    ### [VB](#tab/vb)
    ```vb

    Public Sub TimeCounter()
        Dim result As Integer
        For i As Integer = 0 To 99999
            For j As Integer = 0 To 9999
                result = i * j
            Next j
        Next i
    End Sub
    ```
    ---

6. In **Solution Explorer**, open the shortcut menu for the project (**ProfileTest**), and then choose **Properties**.

7. In the **Properties** dialog box, choose the **SharePoint** tab.

8. In the **Active Deployment Configuration** list, choose **No Activation**.

     Selecting this deployment configuration enables you to manually activate the feature later in SharePoint.

9. Save the project.

## Configure and Deploy the SharePoint application
 Now that the SharePoint project is ready, configure it and deploy it to the SharePoint server.

### To configure and deploy the SharePoint application

1. On the **Analyze** menu, choose **Launch Performance Wizard**.

2. On page one of the **Performance Wizard**, leave the method of profiling as **CPU sampling** and choose the **Next** button.

     The other profiling methods can be used in more advanced profiling situations. For more information, see [Understanding Performance Collection Methods](../profiling/understanding-performance-collection-methods.md).

3. On page two of the **Performance Wizard**, leave the profile target as **ProfileTest** and choose the **Next** button.

     If a solution has multiple projects, they appear in this list.

4. On page three of the **Performance Wizard**, clear the **Enable Tier Interaction Profiling** check box, and then choose the **Next** button.

     The Tier Interaction Profiling (TIP) feature is useful for measuring the performance of applications that query databases and for showing you the number of times a web page is requested. Because that data is not required for this example, we will not enable this feature.

5. On page four of the **Performance Wizard**, leave the **Launch profiling after the wizard finishes** check box selected, and then choose the **Finish** button.

     The wizard enables application profiling on the server, displays the **Performance Explorer** window, and then builds, deploys, and runs the SharePoint application.

## Run the SharePoint application
 Activate the feature in SharePoint, triggering the `FeatureActivation` event code to run.

### To run the SharePoint application

1. In SharePoint, open the **Site Actions** menu, and then choose **Site Settings**.

2. In the **Site Actions** list, choose the **Manage site features** link.

3. In the **Features** list, choose the **Activate** button next to **ProfileTest Feature1**.

     There is a pause when you do this, due to the idle loop being called in the `FeatureActivated` function.

4. On the **Quick Launch** bar, choose **Lists** and then in the **Lists** list, choose **Announcements**.

     Notice that a new announcement has been added to the list stating that the feature was activated.

5. Close the SharePoint site.

     After you close SharePoint, the profiler creates and displays a Sample Profiling Report and saves it as a .vsp file in the **ProfileTest** project's folder.

## View and interpret the profile results
 Now that you have run and profiled the SharePoint application, view the test results.

### To view and interpret the profile results

1. In the **Functions Doing the Most Individual Work** section of the Sample Profiling Report, notice that `TimeCounter` is near the top of the list.

     This location indicates that `TimeCounter` was one of the functions with the highest number of samples, meaning it's one of the biggest performance bottlenecks in the application. This situation isn't surprising, however, because it was purposely designed that way for demonstration purposes.

2. In the **Functions Doing the Most Individual Work** section, choose the `ProcessRequest` link to display the cost distribution for the `ProcessRequest` function.

     In the **Called functions** section for `ProcessRequest`, notice that the **FeatureActiviated** function is listed as the most expensive called function.

3. In the **Called functions** section, choose the **FeatureActivated** button.

     In the **Called functions** section for **FeatureActivated**, the `TimeCounter` function is listed as the most expensive called function. In the **Function Code View** pane, the highlighted code (`TimeCounter`) is the hotspot and indicates where the correction is needed.

4. Close the Sample Profiling Report.

     To view the report again at any time, open the .vsp file in the **Performance Explorer** window.

## Fix the code and reprofile the application
 Now that hotspot function in the SharePoint application has been identified, fix it.

### To fix the code and reprofile the application

1. In the feature event receiver code, comment out the `TimeCounter` method call in `FeatureActivated` to prevent it from being called.

2. Save the project.

3. In **Performance Explorer**, open the Targets folder, and then choose the **ProfileTest** node.

4. On the **Performance Explorer** toolbar, in the **Actions** tab, choose the **Start Profiling** button.

     If you want to change any of the profiling properties prior to reprofiling the application, choose the **Launch Performance Wizard** button instead.

5. Follow the instructions in the **Running the SharePoint Application** section, previously in this topic.

     The feature should activate much faster now that the call to the idle loop has been eliminated. The Sample Profiling Report should reflect this.

## Related content
- [Performance Session Overview](../profiling/performance-session-overview.md)
- [Beginners Guide to Performance Profiling](../profiling/beginners-guide-to-performance-profiling.md)
- [Find Application Bottlenecks with Visual Studio Profiler](/archive/msdn-magazine/2008/march/find-application-bottlenecks-with-visual-studio-profiler)