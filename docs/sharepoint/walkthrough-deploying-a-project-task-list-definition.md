---
title: "Walkthrough: Deploying a Project Task List Definition"
description: In this walkthrough, use Visual Studio to create, customize, debug, and deploy a SharePoint list to track project tasks.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, deploying"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Walkthrough: Deploy a project task list definition

This walkthrough shows you how to use Visual Studio 2012 to create, customize, debug, and deploy a SharePoint list to track project tasks.

[!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites

- Supported editions of Microsoft Windows and SharePoint.

- Visual Studio 2017 or Azure DevOps Services.

## Create a SharePoint list

Create a SharePoint list project and associate the list definition with tasks.

1. Open the **New Project** dialog box, expand the **SharePoint** node, and then choose the **2010** node.

2. In the **Templates** pane, choose the **SharePoint 2010 Project** template, name the project **ProjectTaskList**, and then choose the **OK** button.

     The **SharePoint Customization Wizard** appears.

3. Specify the local SharePoint site that you use for debugging, choose the **Deploy as a farm solution** option button, and then choose the **Finish** button.

4. Open the shortcut menu for the project, and then choose **Add** > **New Item**.

5. In the **Templates** pane, choose the **List** template, and then choose the **Add** button.

     The **SharePoint Customization Wizard** appears.

6. In the **What name do you want to display for your list?** box, enter **Project Task List**.

7. Choose the **Create a non-customizable list based on an existing list type of** option button, and then, in its list, choose **Tasks**, and then choose the **Finish** button.

     The list, feature, and package appear in **Solution Explorer**.

## Add an event receiver

In the task list, you can add an event receiver that automatically sets the due date and description of the task. The following procedure adds a simple event handler to the list instance as an event receiver.

1. Open the shortcut menu for the project node, choose **Add**, and then choose **New Item**.

2. In the list of SharePoint templates, choose the **Event Receiver** template, and then name it **ProjectTaskListEventReceiver**.

     The **SharePoint Customization Wizard** appears.

3. On the **Choose Event Receiver Settings** page, choose **List Item Events** as the event receiver type in the **What type of event receiver do you want** list.

4. In the **What item should be the event source** list, choose **Tasks**.

5. In the list of events to handle, select the check box next to **An item was added**, and then choose the **Finish** button.

     A new event receiver node is added to the project with a code file that is named **ProjectTaskListEventReceiver**.

6. Add code to the `ItemAdded` method in the **ProjectTaskListEventReceiver** code file. Each time a new task is added, a default due date and a description is added to the task. The default due date is July 1, 2009.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/projecttasklist/projecttasklisteventreceiver/projecttasklisteventreceiver.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/projecttasklist1/projecttasklisteventreceiver/projecttasklisteventreceiver.vb" id="Snippet1":::
     ---

## Customize the project task list feature

When you create a SharePoint solution, Visual Studio automatically creates features for the default project items. You can customize the project task list settings for the SharePoint site by using the Feature Designer.

1. In **Solution Explorer**, expand **Features**.

2. Open the shortcut menu for **Feature1**, and then choose **View Designer**.

3. In the **Title** box, enter **Project Task List Feature**.

4. In the **Scope** list, choose **Web**.

5. In the **Properties** window, enter **1.0.0.0** as the value for the **Version** property.

## Customize the project task list package

When you create a SharePoint project, Visual Studio automatically adds the features that contain the default project items to the package. You can customize the project task list settings for the SharePoint site by using the Package Designer.

1. In **SolutionExplorer**, open the shortcut menu for **Package**, and then choose **View Designer**.

2. In the **Name** box, enter **ProjectTaskListPackage**.

3. Select the **Reset Web Server** check box.

## Build and test the project task list

When you run the project, the SharePoint site opens. However, you must manually navigate to the location of the task list.

1. Choose the **F5** key to build and deploy your project task list.

     The SharePoint site opens.

2. Choose the **Home** tab.

3. In the left sidebar, choose the **Project Task List** link.

     The Project Task List page appears.

4. In the **List Tools** tab, choose the **Items** tab.

5. In the **Items** group, choose the **New Item** button.

6. In the **Title** text box, enter **Task1**.

7. Choose the **Save** button.

     After the site is refreshed, the **Task1** task appears with a due date of 7/1/2009.

8. Choose **Task1**.

     The detailed view of the task appears, and the description shows "This is a critical task."

## Deploy the project task list

After you build and test the project task list, you can deploy it to the *local system* or a *remote system*. The local system is the same computer on which you developed the solution, whereas a remote system is a different computer.

### To deploy the project task list to the local system

On the Visual Studio menu bar, choose **Build** > **Deploy Solution**.

Visual Studio recycles the IIS application pool, retracts any existing versions of the solution, copies the solution package (*.wsp*) file to SharePoint, and then activates its features. You can now use the solution in SharePoint. For more information about deployment configuration steps, see [How to: Edit a SharePoint deployment configuration](../sharepoint/how-to-edit-a-sharepoint-deployment-configuration.md).

### To deploy the project task list to a remote system

1. On the Visual Studio menu bar, choose **Build** > **Publish**.

2. In the **Publish** dialog box, choose the **Publish to File System** option button.

     You can change the target location in the **Publish** dialog box by choosing the ellipsis button ![Ellipsis Icon](../sharepoint/media/ellipsisicon.gif "Ellipsis Icon") and then navigating to another location.

3. Choose the **Publish** button.

     A *.wsp* file is created for the solution.

4. Copy the *.wsp* file to the remote SharePoint system.

5. Use the PowerShell `Add-SPUserSolution` command to install the package on the remote SharePoint installation. (For farm solutions, use the `Add-SPSolution` command.)

     For example, `Add-SPUserSolution C:\MyProjects\ProjectTaskList\ProjectTaskList\bin\Debug\ProjectTaskList.wsp`.

6. Use the PowerShell `Install-SPUserSolution` command to deploy the solution. (For farm solutions, use the `Install-SPSolution` command.)

     For example, `Install-SPUserSolution -Identity ProjectTaskList.wsp -Site http://NewSiteName`.

     For more information about remote deployment, see [Using Solutions](/previous-versions/office/developer/sharepoint-2010/ee534972(v=office.14)) and [Adding and Deploying Solutions with PowerShell in SharePoint 2010](/powershell/module/sharepoint-server/install-spsolution?view=sharepoint-server-ps&preserve-view=true).

## Related content

- [Walkthrough: Create a site column, content type, and list for SharePoint](../sharepoint/walkthrough-create-a-site-column-content-type-and-list-for-sharepoint.md)
- [How to: Create an event receiver](../sharepoint/how-to-create-an-event-receiver.md)
- [Windows PowerShell for SharePoint Server 2010](/archive/technet-wiki/34284.sharepoint-2016-list-of-powershell-cmdlets)
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
