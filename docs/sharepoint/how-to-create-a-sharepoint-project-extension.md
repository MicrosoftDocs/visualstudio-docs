---
title: "How to: Create a SharePoint Project Extension | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.prod: "visual-studio-dev14"
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
ms.assetid: ceecb9cb-4a5d-44c9-992f-9624737ac996
caps.latest.revision: 29
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
---
# How to: Create a SharePoint Project Extension
  Create a project extension when you want to add functionality to any SharePoint project that is open in Visual Studio. For more information, see [Extending the SharePoint Project System](../sharepoint/extending-the-sharepoint-project-system.md).  
  
### To create a project extension  
  
1.  Create a class library project.  
  
2.  Add references to the following assemblies:  
  
    -   Microsoft.VisualStudio.SharePoint  
  
    -   System.ComponentModel.Composition  
  
3.  Create a class that implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> interface.  
  
4.  Add the <xref:System.ComponentModel.Composition.ExportAttribute> to the class. This attribute enables Visual Studio to discover and load your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> implementation. Pass the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> type to the attribute constructor.  
  
5.  In your implementation of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize%2A> method, use members of the *projectService* parameter to define the behavior of your extension. This parameter is an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object that provides access to the events defined in the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents> interface.  
  
## Example  
 The following code example demonstrates how to create a simple project extension that handles most of the SharePoint project events that are defined by the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents> interface. To test the code, create a SharePoint project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] and then add more projects to the solution, change project property values, or delete or exclude a project. The extension notifies you of the events by writing messages to the **Output** window and **Error List** window.  
  
 [!code-vb[SPExtensibility.ProjectSystemExtension.General#3](../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/projectextension.vb#3)]
 [!code-vb[SPExtensibility.ProjectSystemExtension.General#3](../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/savedatatoprojectfile.vb#3)]
 [!code-cs[SPExtensibility.ProjectSystemExtension.General#3](../sharepoint/codesnippet/CSharp/projectsystemexamples/extension/projectextension.cs#3)]  
  
 This example uses the SharePoint project service to write the message to the **Output** window and **Error List** window. For more information, see [Using the SharePoint Project Service](../sharepoint/using-the-sharepoint-project-service.md).  
  
 For examples that demonstrate how to handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectMenuItemsRequested> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectPropertiesRequested> events, see [How to: Add a Shortcut Menu Item to SharePoint Projects](../sharepoint/how-to-add-a-shortcut-menu-item-to-sharepoint-projects.md) and [How to: Add a Property to SharePoint Projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md).  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the extension, create a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending the SharePoint Project System](../sharepoint/extending-the-sharepoint-project-system.md)   
 [How to: Add a Shortcut Menu Item to SharePoint Projects](../sharepoint/how-to-add-a-shortcut-menu-item-to-sharepoint-projects.md)   
 [How to: Add a Property to SharePoint Projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md)   
 [Walkthrough: Creating a SharePoint Project Extension](../sharepoint/walkthrough-creating-a-sharepoint-project-extension.md)  
  
  