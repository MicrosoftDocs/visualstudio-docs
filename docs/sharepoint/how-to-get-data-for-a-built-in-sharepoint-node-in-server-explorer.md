---
title: "Get data for built-in SharePoint node in Server Explorer"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint Connections [SharePoint development in Visual Studio], extending a node"
  - "SharePoint development in Visual Studio, extending SharePoint Connections node in Server Explorer"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Get data for a built-in SharePoint node in Server Explorer
  For each built-in SharePoint node in **Server Explorer**, you can get data for the underlying SharePoint component that the node represents. For more information, see [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md).

## Example
 The following code example demonstrates how to get data for the underlying SharePoint list that a list node represents in **Server Explorer**. By default, list nodes have a **View in Browser** context menu item that you can click to open the lists in a Web browser. This example extends list nodes by adding a **View in Visual Studio** context menu item that opens the lists directly in Visual Studio. The code accesses the list data for the node to get the URL of the list to open in Visual Studio.

 [!code-vb[SPExtensibility.ProjectSystemExtension.General#10](../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/serverexplorerextensionnodeinfo.vb#10)]
 [!code-csharp[SPExtensibility.ProjectSystemExtension.General#10](../sharepoint/codesnippet/CSharp/projectsystemexamples/extension/serverexplorerextensionnodeinfo.cs#10)]

 This example uses the SharePoint project service to obtain the <xref:EnvDTE.DTE> object that is used to open lists in Visual Studio. For more information about the SharePoint project service, see [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md).

 For more information about the basic tasks to create an extension for a SharePoint node, see [How to: Extend a SharePoint node in Server Explorer](../sharepoint/how-to-extend-a-sharepoint-node-in-server-explorer.md).

## Compile the code
 This example requires references to the following assemblies:

- EnvDTE

- Microsoft.VisualStudio.SharePoint

- Microsoft.VisualStudio.SharePoint.Explorer.Extensions

- System.ComponentModel.Composition

## Deploy the extension
 To deploy the **Server Explorer** extension, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md)
- [How to: Extend a SharePoint node in Server Explorer](../sharepoint/how-to-extend-a-sharepoint-node-in-server-explorer.md)
- [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md)
- [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md)
