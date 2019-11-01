---
title: "How to: Extend a SharePoint Node in Server Explorer | Microsoft Docs"
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
# How to: Extend a SharePoint node in Server Explorer
  You can extend nodes under the **SharePoint Connections** node in **Server Explorer**. This is useful when you want to add new child nodes, shortcut menu items, or properties to an existing node. For more information, see [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md).

### To extend a SharePoint node in Server Explorer

1. Create a class library project.

2. Add references to the following assemblies:

    - Microsoft.VisualStudio.SharePoint

    - Microsoft.VisualStudio.SharePoint.Explorer.Extensions

    - System.ComponentModel.Composition

3. Create a class that implements the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension> interface.

4. Add the <xref:System.ComponentModel.Composition.ExportAttribute> attribute to the class. This attribute enables Visual Studio to discover and load your <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension> implementation. Pass the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension> type to the attribute constructor.

5. Add the <xref:Microsoft.VisualStudio.SharePoint.Explorer.ExplorerNodeTypeAttribute> attribute to the class. This attribute specifies the string identifier for the type of node that you want to extend.

     To specify built-in node types provided by Visual Studio, pass one of the following enumeration values to the attribute constructor:

    - <xref:Microsoft.VisualStudio.SharePoint.Explorer.ExplorerNodeTypes>: Use these values to specify site connection nodes (the nodes that display site URLs), site nodes, or all other parent nodes in **Server Explorer**.

    - <xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.ExtensionNodeTypes>: Use these values to specify one of the built-in nodes that represent an individual component on a SharePoint site, such as a node that represents a list, field, or content type.

6. In your implementation of the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension.Initialize%2A> method, use members of the *nodeType* parameter to add features to the node. This parameter is an <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeType> object that provides access to the events defined in the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeEvents> interface. For example, you can handle the following events:

    - <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeEvents.NodeChildrenRequested>: Handle this event to add new child nodes to the node. For more information, see [How to: Add a custom SharePoint node to Server Explorer](../sharepoint/how-to-add-a-custom-sharepoint-node-to-server-explorer.md).

    - <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeEvents.NodeMenuItemsRequested>: Handle this event to add a custom shortcut menu item to the node.

    - <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeEvents.NodePropertiesRequested>: Handle this event to add custom properties to the node. The properties appear in the **Properties** window when the node is selected.

## Example
 The following code example demonstrates how to create two different types of node extensions:

- An extension that adds a context menu item to SharePoint site nodes. When you click the menu item, it displays the name of the node that was clicked.

- An extension that adds a custom property named **ContosoExampleProperty** to each node that represents a field named **Body**.

  [!code-csharp[SPExtensibility.ProjectSystemExtension.General#9](../sharepoint/codesnippet/CSharp/projectsystemexamples/extension/serverexplorerextension.cs#9)]
  [!code-vb[SPExtensibility.ProjectSystemExtension.General#9](../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/serverexplorerextension.vb#9)]

  This extension adds an editable string property to nodes. You can also create custom properties that display read-only data from the SharePoint server. For an example that demonstrates how to do this, see [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md).

## Compile the code
 This example requires references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- Microsoft.VisualStudio.SharePoint.Explorer.Extensions

- System.ComponentModel.Composition

- System.Windows.Forms

## Deploy the extension
 To deploy the **Server Explorer** extension, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [How to: Add a custom SharePoint node to Server Explorer](../sharepoint/how-to-add-a-custom-sharepoint-node-to-server-explorer.md)
- [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md)
- [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md)
- [Associate custom data with SharePoint tools extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md)
