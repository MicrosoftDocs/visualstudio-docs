---
title: "How to: Create a SharePoint Project Item Extension | Microsoft Docs"
description: Review how to create a project item extension when you want to add functionality to a SharePoint project item that's already installed in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "project items [SharePoint development in Visual Studio], extending"
  - "SharePoint project items, extending"
  - "SharePoint development in Visual Studio, extending project items"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Create a SharePoint project item extension
  Create a project item extension when you want to add functionality to a SharePoint project item that is already installed in Visual Studio. For more information, see [Extend SharePoint project items](../sharepoint/extending-sharepoint-project-items.md).

### To create a project item extension

1. Create a class library project.

2. Add references to the following assemblies:

    - Microsoft.VisualStudio.SharePoint

    - System.ComponentModel.Composition

3. Create a class that implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> interface.

4. Add the following attributes to the class:

    - <xref:System.ComponentModel.Composition.ExportAttribute>. This attribute enables Visual Studio to discover and load your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> implementation. Pass the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> type to the attribute constructor.

    - <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemTypeAttribute>. In a project item extension, this attribute identifies the project item you want to extend. Pass the ID of the project item to the attribute constructor. For a list of the IDs of the project items that are included with Visual Studio, see [Extend SharePoint project items](../sharepoint/extending-sharepoint-project-items.md).

5. In your implementation of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension.Initialize%2A> method, use members of the *projectItemType* parameter to define the behavior of your extension. This parameter is an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemType> object that provides access to the events defined in the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemFileEvents> interfaces. To access a specific instance of the project item type you are extending, handle <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents> events such as <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemAdded> and <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemInitialized>.

## Example
 The following code example demonstrates how to create a simple extension for the Event Receiver project item. Each time the user adds an Event Receiver project item to a SharePoint project, this extension writes a message to the **Output** window and **Error List** window.

 :::code language="csharp" source="../sharepoint/codesnippet/CSharp/projectsystemexamples/extension/projectitemextension.cs" id="Snippet1":::
 :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/projectitemextension.vb" id="Snippet1":::

 This example uses the SharePoint project service to write the message to the **Output** window and **Error List** window. For more information, see [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md).

## Compile the code
 This example requires references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- System.ComponentModel.Composition

## Deploy the extension
 To deploy the extension, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploy Extensions for the SharePoint Tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [Extend SharePoint project items](../sharepoint/extending-sharepoint-project-items.md)
- [Walkthrough: Extend a SharePoint project item type](../sharepoint/walkthrough-extending-a-sharepoint-project-item-type.md)
