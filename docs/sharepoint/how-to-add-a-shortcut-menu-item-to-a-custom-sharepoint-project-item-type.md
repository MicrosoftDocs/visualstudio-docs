---
title: "Add shortcut menu item to custom SharePoint project item type"
titleSuffix: ""
description: Know how to add a shortcut menu item to a custom SharePoint project item type. The menu item appears when you right-click the project item in Solution Explorer.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint project items, defining your own types"
  - "project items [SharePoint development in Visual Studio], defining your own types"
  - "SharePoint development in Visual Studio, defining new project item types"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add a shortcut menu item to a custom SharePoint project item type
  When you define a custom SharePoint project item type, you can add a shortcut menu item to the project item. The menu item appears when a user right-clicks the project item in **Solution Explorer**.

 The following steps assume that you have already defined your own SharePoint project item type. For more information, see [How to: Define a SharePoint project item type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md).

### To add a shortcut menu item to a custom project item type

1. In the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType%2A> method of your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> implementation, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event of the *projectItemTypeDefinition* parameter.

2. In your event handler for the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event, add a new <xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object to the <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.ViewMenuItems%2A> or <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.AddMenuItems%2A> collection of the event arguments parameter.

3. In the <xref:Microsoft.VisualStudio.SharePoint.IMenuItem.Click> event handler for the new <xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object, perform the tasks you want to execute when a user chooses your shortcut menu item.

## Example
 The following code example demonstrates how to add a context menu item to a custom project item type. When the user opens the shortcut menu from the project item in **Solution Explorer** and chooses the **Write Message to Output Window** menu item, Visual Studio displays a message in the **Output** window.

 :::code language="csharp" source="../sharepoint/codesnippet/CSharp/projectitemmenuandproperty/extension/projectitemtypemenu.cs" id="Snippet4":::
 :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/projectitemmenuandproperty/extension/projectitemtypemenu.vb" id="Snippet4":::

 This example uses the SharePoint project service to write the message to the **Output** window. For more information, see [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md).

## Compile the code
 This example requires a class library project with references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- System.ComponentModel.Composition

## Deploy the project item
 To enable other developers to use your project item, create a project template or a project item template. For more information, see [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).

 To deploy the project item, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly, the template, and any other files that you want to distribute with the project item. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [How to: Define a SharePoint project item type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md)
- [How to: Add a property to a custom SharePoint project item type](../sharepoint/how-to-add-a-property-to-a-custom-sharepoint-project-item-type.md)
- [Defining custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md)
