---
title: "Extending the SharePoint Project System | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, extending projects"
  - "SharePoint development in Visual Studio, extending project items"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Extend the SharePoint project system
  You can create SharePoint solutions by using a set of project templates and item templates in Visual Studio. These templates meet the requirements of many development scenarios, but you might discover some cases where they don't provide functionality that you require. In these cases, you can extend the SharePoint project system.

## Overview of the SharePoint project system
 The SharePoint project system is based on the fundamental component of *SharePoint project items*. A SharePoint project item represents a single SharePoint customization, such as a list definition, Web Part, or content type.

 A SharePoint project is a Visual Studio project that includes one or more SharePoint project items. SharePoint projects also contain additional components that define how project items are grouped into Features and packages for deployment.

 For more information about the contents of SharePoint project items and SharePoint projects, see [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).

## How to extend the SharePoint project system
 You can extend the SharePoint project system in the following ways:

- Define your own SharePoint project item types and associate them with new item templates or project templates in Visual Studio. For example, you can define a SharePoint project item type for creating a custom action or a field. For more information, see [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md).

- Extend SharePoint project item types that are already installed in Visual Studio. For example, you can add a shortcut menu item to a project item in **Solution Explorer** and customize the project item when a developer chooses the menu item. For more information, see [Extend SharePoint project items](../sharepoint/extending-sharepoint-project-items.md).

- Extend SharePoint projects. For example, you can add event handlers to perform specific tasks when items are added or removed from SharePoint projects. For more information, see [Extend SharePoint projects](../sharepoint/extending-sharepoint-projects.md).

- Extend the packaging and deployment behavior of SharePoint project items and SharePoint projects. For example, you can create your own deployment steps to execute when you deploy or retract a project, or you can perform additional custom tasks when Visual Studio executes certain deployment steps. For more information, see [Extend SharePoint packaging and deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md).

## Common development tasks
 You can perform the following common tasks in extensions of the SharePoint project system:

- Save custom string data with project items and in several different types of project files. For more information, see [Save data in extensions of the SharePoint project system](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md).

- Convert an object in the SharePoint project system to a corresponding object in the Visual Studio automation object model or integration object model, or vice versa. For more information, see [Conver between SharePoint project system types and other Visual Studio project types](../sharepoint/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md).

## See also
- [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md)
- [Extend SharePoint project items](../sharepoint/extending-sharepoint-project-items.md)
- [Extend SharePoint projects](../sharepoint/extending-sharepoint-projects.md)
- [Extend SharePoint packaging and deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md)
- [Save data in extensions of the SharePoint project system](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md)
- [Convert between SharePoint project system types and other Visual Studio project types](../sharepoint/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md)
- [Extend the SharePoint tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md)
- [Programming Concepts and Features for SharePoint Tools Extensions](../sharepoint/programming-concepts-and-features-for-sharepoint-tools-extensions.md)
