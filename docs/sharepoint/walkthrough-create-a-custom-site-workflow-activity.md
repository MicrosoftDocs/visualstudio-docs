---
title: "Walkthrough: Create a Custom Site Workflow Activity | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "custom workflow activities [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, custom workflow activities"
  - "site workflows [SharePoint development in Visual Studio]"
  - "workflow activities [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, site workflows"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Create a custom site workflow activity
  This walkthrough demonstrates how to create a custom activity for a site-level workflow using [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. (Site-level workflows apply to the whole site, not just a list on the site.) The custom activity creates a backup Announcements list and then copies the contents of the Announcements list into it.

 This walkthrough demonstrates the following tasks:

- Creating a site-level workflow.

- Creating a custom workflow activity.

- Creating and deleting a SharePoint list.

- Copying items from one list to another.

- Displaying a list on the QuickLaunch bar.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- Supported editions of [!INCLUDE[TLA#tla_win](../sharepoint/includes/tlasharptla-win-md.md)] and SharePoint.

- Visual Studio.

## Create a site workflow custom activity project
 First, create a project to hold and test the custom workflow activity.

#### To create a site workflow custom activity project

1. On the menu bar, choose **File** > **New** > **Project** to display the **New Project** dialog box.

2. Expand the **SharePoint** node under either **Visual C#** or **Visual Basic**, and then choose the **2010** node.

3. In the **Templates** pane, choose the **SharePoint 2010 Project** template.

4. In the **Name** box, enter **AnnouncementBackup**, and then choose the **OK** button.

     The **SharePoint Customization Wizard** appears.

5. On the **Specify the site and security level for debugging** page, choose the **Deploy as a farm solution** option button, and then choose the **Finish** button to accept the trust level and default site.

     This step sets the trust level for the solution as farm solution, the only available option for workflow projects.

6. In **Solution Explorer**, choose the project node, and then, on the menu bar, choose **Project** > **Add New Item**.

7. Under either **Visual C#** or **Visual Basic**, expand the **SharePoint** node, and then choose the **2010** node.

8. In the **Templates** pane, choose the **Sequential Workflow (Farm Solution only)** template, and then choose the **Add** button.

     The **SharePoint Customization Wizard** appears.

9. On the **Specify the workflow name for debugging** page, accept the default name (AnnouncementBackup - Workflow1). Change the workflow template type to **Site Workflow**, and then choose the **Next** button.

10. Choose the **Finish** button to accept the remaining default settings.

## Add a custom workflow activity class
 Next, add a class to the project to contain the code for the custom workflow activity.

#### To add a custom workflow activity class

1. On the menu bar, choose **Project** > **Add New Item** to display the **Add New Item** dialog box.

2. In the **Installed Templates** tree view, choose the **Code** node, and then choose the **Class** template in the list of project item templates. Use the default name Class1. Choose the **Add** button.

3. Replace all of the code in Class1 with the following:

     [!code-csharp[SP_AnnBackup#1](../sharepoint/codesnippet/CSharp/announcementbackup/class1.cs#1)]
     [!code-vb[SP_AnnBackup#1](../sharepoint/codesnippet/VisualBasic/announcementbackupvb/class1.vb#1)]

4. Save the project, and then, on the menu bar, choose **Build** > **Build Solution**.

     Class1 appears as a custom action in the **Toolbox** on the **AnnouncementBackup Components** tab.

## Add the custom activity to the site workflow
 Next, add an activity to the Workflow to contain the custom code.

#### To add a custom activity to the site workflow

1. Open Workflow1 in the workflow designer in design view.

2. Drag Class1 from the **Toolbox** so that it appears under the `onWorkflowActivated1` activity, or open the shortcut menu for Class1, choose **Copy**, open the shortcut menu for the line under the `onWorkflowActivated1` activity, and then choose **Paste**.

3. Save the project.

## Test the site workflow custom activity
 Next, run the project and start the site workflow. The custom activity creates a backup Announcements list and copies the contents from the current Announcements list into it. The code also checks whether a backup list already exists before creating one. If a backup list already exists, it is deleted. The code also adds a link to the new list on the SharePoint site's QuickLaunch bar.

#### To test the site workflow custom activity

1. Choose the **F5** key to run the project and deploy it to SharePoint.

2. On the QuickLaunch bar, choose the **Lists** link to display all of the lists that are available in the SharePoint site. Notice there is only one list for announcements named **Announcements**.

3. At the top of the SharePoint webpage, choose the **Site Workflows** link.

4. Under the Start a New Workflow section, choose the **AnnouncementBackup - Workflow1** link. This starts the site workflow and runs the code in the custom action.

5. On the QuickLaunch bar, choose the **Announcements Backup** link. Notice that all of the announcements that are contained in the **Announcements** list have been copied to this new list.

## See also
- [How to: Create an event receiver](../sharepoint/how-to-create-an-event-receiver.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
