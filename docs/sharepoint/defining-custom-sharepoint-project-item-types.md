---
title: "Defining Custom SharePoint Project Item Types | Microsoft Docs"
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
# Defining Custom SharePoint Project Item Types
  Define a new SharePoint project item type when you want to create a new kind of SharePoint project item. For example, Visual Studio does not include SharePoint project items for adding fields or custom actions to a SharePoint site. You can define your own types of SharePoint project items for creating fields, custom actions, or other types of SharePoint components.  
  
## Tasks for Defining SharePoint Project Item Types  
 To define a custom project item type, build a Visual Studio extension assembly that implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> interface. For more information, see [How to: Define a SharePoint Project Item Type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md).  
  
 When you define a custom project item type, you can also add the following functionality to the project item:  
  
-   Add a shortcut menu item to the project item. The menu item appears when you open the shortcut menu for the project item in **Solution Explorer** by right-clicking the project item or by choosing it and then choosing the Shift + F10 keys. For more information, see [How to: Add a Shortcut Menu Item to a Custom SharePoint Project Item Type](../sharepoint/how-to-add-a-shortcut-menu-item-to-a-custom-sharepoint-project-item-type.md).  
  
-   Add a custom property to the project item. The property appears in the **Properties** window when you choose the project item in **Solution Explorer**. For more information, see [How to: Add a Property to a Custom SharePoint Project Item Type](../sharepoint/how-to-add-a-property-to-a-custom-sharepoint-project-item-type.md).  
  
 To enable other developers to use your project item in Visual Studio, create an .spdata file and create an item template or project template that is associated with the project item. For more information, see [Creating Item Templates and Project Templates for SharePoint Project Items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).  
  
## Understanding the Relationship Between Project Item Types and Project Item Instances  
 When you define a SharePoint project item type, Visual Studio loads your extension when a project item of the associated type is added to a SharePoint project. For example, if you define a new **Custom Action** project item type, Visual Studio loads your extension when a user adds a **Custom Action** project item to a project. Visual Studio uses the same instance of your extension for all instances of the associated project item type. In the previous example, if the user adds a second **Custom Action** project item to the project, the same instance of your extension is used to customize the second project item.  
  
 To access a specific instance of your project item type, handle one of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents> events of the *projectItemTypeDefinition* parameter in your implementation of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType%2A> method. For example, to determine when a project item of your custom type is added to a project, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemAdded> event. For more information, see [How to: Define a SharePoint Project Item Type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md).  
  
## See Also  
 [How to: Define a SharePoint Project Item Type](../sharepoint/how-to-define-a-sharepoint-project-item-type.md)   
 [How to: Add a Property to a Custom SharePoint Project Item Type](../sharepoint/how-to-add-a-property-to-a-custom-sharepoint-project-item-type.md)   
 [How to: Add a Shortcut Menu Item to a Custom SharePoint Project Item Type](../sharepoint/how-to-add-a-shortcut-menu-item-to-a-custom-sharepoint-project-item-type.md)   
 [Creating Item Templates and Project Templates for SharePoint Project Items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md)   
 [Walkthrough: Creating a Custom Action Project Item with an Item Template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md)   
 [Walkthrough: Creating a Site Column Project Item with a Project Template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md)   
 [Walkthrough: Creating a Custom Action Project Item with an Item Template, Part 2](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-2.md)   
 [Walkthrough: Creating a Site Column Project Item with a Project Template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md)   
 [Deploying Extensions for the SharePoint Tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md)  
  
  