---
title: "How to: Add a Shortcut Menu Item to a Custom SharePoint Project Item Type | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint project items, defining your own types"
  - "project items [SharePoint development in Visual Studio], defining your own types"
  - "SharePoint development in Visual Studio, defining new project item types"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add a Shortcut Menu Item to a Custom SharePoint Project Item Type
  When you define a custom SharePoint project item type, you can add a shortcut menu item to the project item. The menu item appears when a user right-clicks the project item in **Solution Explorer**.  
  
 The following steps assume that you have already defined your own SharePoint project item type. For more information, see [How to: Define a SharePoint Project Item Type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md).  
  
### To add a shortcut menu item to a custom project item type  
  
1.  In the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType%2A> method of your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> implementation, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event of the *projectItemTypeDefinition* parameter.  
  
2.  In your event handler for the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event, add a new <xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object to the <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.ViewMenuItems%2A> or <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.AddMenuItems%2A> collection of the event arguments parameter.  
  
3.  In the <xref:Microsoft.VisualStudio.SharePoint.IMenuItem.Click> event handler for the new <xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object, perform the tasks you want to execute when a user chooses your shortcut menu item.  
  
## Example  
 The following code example demonstrates how to add a context menu item to a custom project item type. When the user opens the shortcut menu from the project item in **Solution Explorer** and chooses the **Write Message to Output Window** menu item, Visual Studio displays a message in the **Output** window.  
  
 [!code-csharp[SPExtensibility.ProjectItemExtension.MenuAndProperty#4](../sharepoint/codesnippet/CSharp/projectitemmenuandproperty/extension/projectitemtypemenu.cs#4)]
 [!code-vb[SPExtensibility.ProjectItemExtension.MenuAndProperty#4](../sharepoint/codesnippet/VisualBasic/projectitemmenuandproperty/extension/projectitemtypemenu.vb#4)]  
  
 This example uses the SharePoint project service to write the message to the **Output** window. For more information, see [Using the SharePoint Project Service](../sharepoint/using-the-sharepoint-project-service.md).  
  
## Compiling the Code  
 This example requires a class library project with references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Project Item  
 To enable other developers to use your project item, create a project template or a project item template. For more information, see [Creating Item Templates and Project Templates for SharePoint Project Items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).  
  
 To deploy the project item, create a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly, the template, and any other files that you want to distribute with the project item. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [How to: Define a SharePoint Project Item Type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md)   
 [How to: Add a Property to a Custom SharePoint Project Item Type](../sharepoint/how-to-add-a-property-to-a-custom-sharepoint-project-item-type.md)   
 [Defining Custom SharePoint Project Item Types](../sharepoint/defining-custom-sharepoint-project-item-types.md)  
  
  