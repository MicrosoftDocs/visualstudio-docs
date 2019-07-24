---
title: "Add shortcut menu item to SharePoint project item extension"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "project items [SharePoint development in Visual Studio], extending"
  - "SharePoint project items, extending"
  - "SharePoint development in Visual Studio, extending project items"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add a shortcut menu item to a SharePoint project item extension
  You can add a shortcut menu item to an existing SharePoint project item by using a project item extension. The menu item appears when a user right-clicks the project item in **Solution Explorer**.

 The following steps assume that you have already created a project item extension. For more information, see [How to: Create a SharePoint project item extension](../sharepoint/how-to-create-a-sharepoint-project-item-extension.md).

### To add a shortcut menu item in a project item extension

1. In the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension.Initialize%2A> method of your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> implementation, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event of the *projectItemType* parameter.

2. In your event handler for the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event, add a new <xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object to the <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.ViewMenuItems%2A> or <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.AddMenuItems%2A> collection of the event arguments parameter.

3. In the <xref:Microsoft.VisualStudio.SharePoint.IMenuItem.Click> event handler for the new <xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object, perform the tasks you want to execute when a user clicks your shortcut menu item.

## Example
 The following code example demonstrates how to add a shortcut menu item to the Event Receiver project item. When the user right-clicks the project item in **Solution Explorer** and clicks the **Write Message to Output Window** menu item, Visual Studio displays a message in the **Output** window.

 [!code-vb[SPExtensibility.ProjectItemExtension.MenuAndProperty#1](../sharepoint/codesnippet/VisualBasic/projectitemmenuandproperty/extension/projectitemextensionmenu.vb#1)]
 [!code-csharp[SPExtensibility.ProjectItemExtension.MenuAndProperty#1](../sharepoint/codesnippet/CSharp/projectitemmenuandproperty/extension/projectitemextensionmenu.cs#1)]

 This example uses the SharePoint project service to write the message to the **Output** window. For more information, see [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md).

## Compile the code
 This example requires a class library project with references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- System.ComponentModel.Composition

## Deploy the extension
 To deploy the extension, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [How to: Create a SharePoint project item extension](../sharepoint/how-to-create-a-sharepoint-project-item-extension.md)
- [How to: Add a property to a SharePoint project item extension](../sharepoint/how-to-add-a-property-to-a-sharepoint-project-item-extension.md)
- [Extend SharePoint project items](../sharepoint/extending-sharepoint-project-items.md)
- [Walkthrough: Extend a SharePoint project item type](../sharepoint/walkthrough-extending-a-sharepoint-project-item-type.md)
