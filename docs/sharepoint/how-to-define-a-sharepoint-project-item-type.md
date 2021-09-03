---
title: "How to: Define a SharePoint Project Item Type | Microsoft Docs"
description: Understand how to define a project item type when you want to create a custom SharePoint project item.
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
# How to: Define a SharePoint project item type
  Define a project item type when you want to create a custom SharePoint project item. For more information, see [Defining custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md).

### To define a project item type

1. Create a class library project.

2. Add references to the following assemblies:

    - Microsoft.VisualStudio.SharePoint

    - System.ComponentModel.Composition

3. Create a class that implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> interface.

4. Add the following attributes to the class:

    - <xref:System.ComponentModel.Composition.ExportAttribute>. This attribute enables Visual Studio to discover and load your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> implementation. Pass the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> type to the attribute constructor.

    - <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemTypeAttribute>. In a project item type definition, this attribute specifies the string identifier for the new project item. We recommend that you use the format *company name*.*feature name* to help make sure that all project items have a unique name.

    - <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemIconAttribute>. This attribute specifies the icon to display for this project item in **Solution Explorer**. This attribute is optional; if you do not apply it to your class, Visual Studio displays a default icon for your project item. If you set this attribute, pass the fully qualified name of an icon or bitmap that is embedded in your assembly.

5. In your implementation of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType%2A> method, use members of the *projectItemTypeDefinition* parameter to define the behavior of the project item type. This parameter is an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition> object that provides access to the events defined in the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemFileEvents> interfaces. To access a specific instance of your project item type, handle <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents> events such as <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemAdded> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemInitialized>.

## Example
 The following code example demonstrates how to define a simple project item type. This project item type writes a message to the **Output** window and **Error List** window when a user adds a project item of this type to a project.

 :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/projectitemtype.vb" id="Snippet2":::
 :::code language="csharp" source="../sharepoint/codesnippet/CSharp/projectsystemexamples/extension/projectitemtype.cs" id="Snippet2":::

 This example uses the SharePoint project service to write the message to the **Output** window and **Error List** window. For more information, see [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md).

## Compile the code
 This example requires references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- System.ComponentModel.Composition

## Deploy the project item
 To enable other developers to use your project item, create a project template or a project item template. For more information, see [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).

 To deploy the project item, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly, the template, and any other files that you want to distribute with the project item. For more information, see [Deploy Extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md)
- [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md)
- [Walkthrough: Create a custom action project item with an item template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md)
- [Walkthrough: Create a site column project item with a project template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md)
- [How to: Add a property to a custom SharePoint project item type](../sharepoint/how-to-add-a-property-to-a-custom-sharepoint-project-item-type.md)
- [How to: Add a shortcut menu item to a custom SharePoint project item type](../sharepoint/how-to-add-a-shortcut-menu-item-to-a-custom-sharepoint-project-item-type.md)
