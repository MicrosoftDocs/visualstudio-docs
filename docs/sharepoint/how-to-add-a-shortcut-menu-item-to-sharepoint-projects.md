---
title: "How to: Add a Shortcut Menu Item to SharePoint Projects | Microsoft Docs"
titleSuffix: ""
description: Add a shortcut menu item to a SharePoint project in Visual Studio. The menu item appears when you right-click a project node in Solution Explorer.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "projects [SharePoint development in Visual Studio], extending"
  - "SharePoint development in Visual Studio, extending projects"
  - "SharePoint projects, extending"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add a shortcut menu item to SharePoint projects
  You can add a shortcut menu item to any SharePoint project. The menu item appears when a user right-clicks a project node in **Solution Explorer**.

 The following steps assume that you have already created a project extension. For more information, see [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md).

### To add a shortcut menu item to SharePoint projects

1. In the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize%2A> method of your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> implementation, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectMenuItemsRequested> event of the *projectService* parameter.

2. In your event handler for the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectMenuItemsRequested> event, add a new <xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object to the <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectMenuItemsRequestedEventArgs.ActionMenuItems%2A> or <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectMenuItemsRequestedEventArgs.AddMenuItems%2A> collection of the event arguments parameter.

3. In the <xref:Microsoft.VisualStudio.SharePoint.IMenuItem.Click> event handler for the new <xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object, perform the tasks you want to execute when a user clicks your shortcut menu item.

## Example
 The following code example demonstrates how to add a shortcut menu item to SharePoint project nodes in **Solution Explorer**. When the user right-clicks a project node and clicks the **Write Message to Output Window** menu item, Visual Studio displays a message in the **Output** window. This example uses the SharePoint project service to display the message. For more information, see [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md).

 :::code language="csharp" source="../sharepoint/codesnippet/CSharp/projectmenu/extension/projectitemextensionmenu.cs" id="Snippet1":::
 :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/projectmenu/extension/projectitemextensionmenu.vb" id="Snippet1":::

## Compile the code
 This example requires a class library project with references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- System.ComponentModel.Composition

## Deploy the extension
 To deploy the extension, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [Extend SharePoint projects](../sharepoint/extending-sharepoint-projects.md)
- [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md)
- [How to: Add a property to SharePoint projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md)
