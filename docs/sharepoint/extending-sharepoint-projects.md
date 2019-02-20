---
title: "Extending SharePoint Projects | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "projects [SharePoint development in Visual Studio], extending"
  - "SharePoint development in Visual Studio, extending projects"
  - "SharePoint projects, extending"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Extend SharePoint projects
  Create a project extension when you want to customize project-level features of SharePoint projects. For example, you can add custom project properties, or respond to project-level events that are raised when the user develops a SharePoint solution in Visual Studio.

## Create project extensions
 To extend a project item, build a Visual Studio extension assembly that implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> interface. For more information, see [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md).

 When you create a project extension, you can also add the following functionality to the SharePoint projects:

- Add a shortcut menu item. The menu item appears when you  open the shortcut menu for a SharePoint project node in **Solution Explorer** by right-clicking the node or choosing it and then choosing the **Shift**+**F10** keys. For more information, see [How to: Add a shortcut menu item to SharePoint projects](../sharepoint/how-to-add-a-shortcut-menu-item-to-sharepoint-projects.md).

- Add a custom property. The property appears in the **Properties** window when you choose a SharePoint project in **Solution Explorer**. For more information, see [How to: Add a property to SharePoint projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md).

  For a walkthrough that demonstrates how to create, deploy, and test a project extension, see [Walkthrough: Create a SharePoint project extension](../sharepoint/walkthrough-creating-a-sharepoint-project-extension.md).

## Understand the relationship between project extensions and project instances
 When you create a project extension, the extension loads when any kind of SharePoint project is opened in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] includes several SharePoint project templates, such as list definitions, content types, and event receivers. However, there is only one SharePoint project type. The project types that appear in the **New Project** dialog box are only templates that bundle together one or more SharePoint project items. Because there is only one SharePoint project type, extensions created for one project apply to all SharePoint projects. You cannot, for example, create an extension that applies to only a **Content Type** project.

 To access a specific project instance, handle one of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents> events of the *projectService* parameter in your implementation of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize%2A> method. For example, to determine when a SharePoint project is added to a solution, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectAdded> event. For more information, see [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md).

## See also
- [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md)
- [How to: Add a shortcut menu item to SharePoint projects](../sharepoint/how-to-add-a-shortcut-menu-item-to-sharepoint-projects.md)
- [How to: Add a property to SharePoint projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md)
- [Walkthrough: Create a SharePoint project extension](../sharepoint/walkthrough-creating-a-sharepoint-project-extension.md)
- [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md)
- [Extend SharePoint project items](../sharepoint/extending-sharepoint-project-items.md)
- [Extend SharePoint packaging and deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md)
- [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md)
