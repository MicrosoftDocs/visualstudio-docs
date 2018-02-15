---
title: "Extending SharePoint Projects | Microsoft Docs"
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
  - "projects [SharePoint development in Visual Studio], extending"
  - "SharePoint development in Visual Studio, extending projects"
  - "SharePoint projects, extending"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Extending SharePoint Projects
  Create a project extension when you want to customize project-level features of SharePoint projects. For example, you can add custom project properties, or respond to project-level events that are raised when the user develops a SharePoint solution in Visual Studio.  
  
## Creating Project Extensions  
 To extend a project item, build a Visual Studio extension assembly that implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> interface. For more information, see [How to: Create a SharePoint Project Extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md).  
  
 When you create a project extension, you can also add the following functionality to the SharePoint projects:  
  
-   Add a shortcut menu item. The menu item appears when you  open the shortcut menu for a SharePoint project node in **Solution Explorer** by right-clicking the node or choosing it and then choosing the Shift + F10 keys. For more information, see [How to: Add a Shortcut Menu Item to SharePoint Projects](../sharepoint/how-to-add-a-shortcut-menu-item-to-sharepoint-projects.md).  
  
-   Add a custom property. The property appears in the **Properties** window when you choose a SharePoint project in **Solution Explorer**. For more information, see [How to: Add a Property to SharePoint Projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md).  
  
 For a walkthrough that demonstrates how to create, deploy, and test a project extension, see [Walkthrough: Creating a SharePoint Project Extension](../sharepoint/walkthrough-creating-a-sharepoint-project-extension.md).  
  
## Understanding the Relationship Between Project Extensions and Project Instances  
 When you create a project extension, the extension loads when any kind of SharePoint project is opened in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] includes several SharePoint project templates, such as list definitions, content types, and event receivers. However, there is only one SharePoint project type. The project types that appear in the **New Project** dialog box are only templates that bundle together one or more SharePoint project items. Because there is only one SharePoint project type, extensions created for one project apply to all SharePoint projects. You cannot, for example, create an extension that applies to only a **Content Type** project.  
  
 To access a specific project instance, handle one of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents> events of the *projectService* parameter in your implementation of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize%2A> method. For example, to determine when a SharePoint project is added to a solution, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectAdded> event. For more information, see [How to: Create a SharePoint Project Extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md).  
  
## See Also  
 [How to: Create a SharePoint Project Extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md)   
 [How to: Add a Shortcut Menu Item to SharePoint Projects](../sharepoint/how-to-add-a-shortcut-menu-item-to-sharepoint-projects.md)   
 [How to: Add a Property to SharePoint Projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md)   
 [Walkthrough: Creating a SharePoint Project Extension](../sharepoint/walkthrough-creating-a-sharepoint-project-extension.md)   
 [Defining Custom SharePoint Project Item Types](../sharepoint/defining-custom-sharepoint-project-item-types.md)   
 [Extending SharePoint Project Items](../sharepoint/extending-sharepoint-project-items.md)   
 [Extending SharePoint Packaging and Deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md)   
 [Extending the SharePoint Project System](../sharepoint/extending-the-sharepoint-project-system.md)  
  
  