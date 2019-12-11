---
title: "Extending the SharePoint Tools in Visual Studio | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Visual Studio, extending tools"
  - "extensibility [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, extending tools"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Extend the SharePoint tools in Visual Studio
  The SharePoint tools in Visual Studio meet the requirements of many application development scenarios. However, you might discover cases where they do not provide functionality that you or other developers require. In these cases, you can extend the SharePoint tools to create the functionality that you need.

## How to extend the SharePoint tools
 You can extend the SharePoint project system and the **SharePoint Connections** node in the **Server Explorer** window.

### Extend the SharePoint project system
 Visual Studio includes a set of project templates and item templates that you can use to create SharePoint solutions. For example, there are templates for event receivers, list definitions, workflows, and Web Parts. However, you can also define your own types of SharePoint project items for creating SharePoint components such as fields or custom actions. You can also create extensions for SharePoint project item types that are already installed in Visual Studio, and you can create extensions for SharePoint projects.

 For more information, see [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md).

### Extend the SharePoint connections node in Server Explorer
 In Visual Studio, you can use the **SharePoint Connections** node in the **Server Explorer** window to view many of the components of one or more local SharePoint sites in a hierarchical tree view. You can also extend the **SharePoint Connections** node in the following ways:

- By adding your own nodes. This is useful if you want to display components of SharePoint sites that are not displayed by default.

- By extending existing nodes. For example, you can add a new child node to an existing node, or you can add a shortcut menu item to a node and perform tasks when a developer clicks the menu item.

  For more information, see [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md).

## Development computer requirements
 To create extensions for the SharePoint tools, your development computer must meet the same requirements for creating SharePoint solutions in Visual Studio.

 We also recommend that you install the [!INCLUDE[vssdk_current_long](../sharepoint/includes/vssdk-current-long-md.md)]. The SDK includes project templates and tools that you can use to extend Visual Studio. In particular, the SDK includes a project template you can use to easily create a Visual Studio Extension (VSIX) package. VSIX packages are the preferred way to deploy Visual Studio extensions in Visual Studio. All SharePoint tools extensions must be deployed by using VSIX packages. All of the walkthroughs in this documentation assume that you have the [!INCLUDE[vssdk_current_long](../sharepoint/includes/vssdk-current-long-md.md)] installed.

 To install the Visual Studio SDK, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md). For more information about Visual Studio extensions, see [Starting to Develop Visual Studio Extensions](../extensibility/starting-to-develop-visual-studio-extensions.md).

## See also

- [Overview of the programming model of SharePoint tools extensions](../sharepoint/overview-of-the-programming-model-of-sharepoint-tools-extensions.md)
- [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md)
- [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md)
- [Programming concepts and features for SharePoint tools extensions](../sharepoint/programming-concepts-and-features-for-sharepoint-tools-extensions.md)
- [Reference &#40;SharePoint Tools extensibility&#41;](../sharepoint/reference-sharepoint-tools-extensibility.md)
- [Debug extensions for the SharePoint tools in Visual Studio](../sharepoint/debugging-extensions-for-the-sharepoint-tools-in-visual-studio.md)
- [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md)