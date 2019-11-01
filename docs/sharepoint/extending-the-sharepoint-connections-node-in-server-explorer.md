---
title: "Extending the SharePoint Connections Node in Server Explorer | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint Connections [SharePoint development in Visual Studio], extending a node"
  - "SharePoint development in Visual Studio, extending SharePoint Connections node in Server Explorer"
  - "SharePoint Connections [SharePoint development in Visual Studio], creating a new node type"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Extend the SharePoint connections node in Server Explorer
  In Visual Studio, you can connect to local SharePoint sites on the development computer by using the **SharePoint Connections** node in the **Server Explorer** window. This node displays many of the components of local SharePoint sites in a hierarchical tree view. For example, you can view the lists, document libraries, and content types on local sites. For more information about using **Server Explorer** to connect to local SharePoint sites, see [Browse SharePoint connections using Server Explorer](../sharepoint/browsing-sharepoint-connections-using-server-explorer.md).

 You can extend the **SharePoint Connections** node by creating extensions for existing nodes, or by creating a custom node type and adding it to the hierarchy of nodes.

## Tasks for extending the SharePoint connections node
 To extend an existing node, create a Visual Studio extension that implements the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension> interface. When you extend a node, you can add functionality to the node such as your own shortcut menu items or custom properties. For more information, see [How to: Extend a SharePoint node in Server Explorer](../sharepoint/how-to-extend-a-sharepoint-node-in-server-explorer.md).

 To create a custom node type, create a Visual Studio extension that implements the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeProvider> interface. Create a custom node if you want to display components of SharePoint sites that are not displayed in **Server Explorer** by default. For example, **Server Explorer** does not display the Web Part gallery of a SharePoint site by default, but you can add a custom node that does this. For more information, see [How to: Add a custom SharePoint node to Server Explorer](../sharepoint/how-to-add-a-custom-sharepoint-node-to-server-explorer.md) and [Walkthrough: Extend Server Explorer to Display Web Parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md).

## Add custom properties to nodes
 When you extend a node or create a custom node type, you can add custom properties to the node. The properties appear in the **Properties** window when the node is selected.

 There are two types of custom properties you can add to a node:

- Properties that display a set of read-only data from the SharePoint site. The data describes the SharePoint component that the node represents. For a walkthrough that demonstrates how to do this, see [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md).

- Properties that display custom read/write data. For a code example that demonstrates how to do this, see [How to: Extend a SharePoint node in Server Explorer](../sharepoint/how-to-extend-a-sharepoint-node-in-server-explorer.md).

## Get data for built-in nodes
 All of the built-in nodes provided by Visual Studio include some data about the SharePoint component that they represent. For example, a node that represents a list on the SharePoint site provides some data about the list, such as the title and the URL of the default view for the list.

 To access this data, retrieve a data object from the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A> property of the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode> object that represents the node you are interested in. The type of the data object depends on the type of the node.

 The following code example demonstrates how to get the data object for a list node. To see this example in the context of a larger example, see [How to: Get data for a built-in SharePoint node in Server Explorer](../sharepoint/how-to-get-data-for-a-built-in-sharepoint-node-in-server-explorer.md).

 [!code-vb[SPExtensibility.ProjectSystemExtension.General#11](../sharepoint/codesnippet/VisualBasic/projectsystemexamples/extension/serverexplorerextensionnodeinfo.vb#11)]
 [!code-csharp[SPExtensibility.ProjectSystemExtension.General#11](../sharepoint/codesnippet/CSharp/projectsystemexamples/extension/serverexplorerextensionnodeinfo.cs#11)]

 The following table lists the data object types for each built-in node type.

|Node type|Data object type|
|---------------|----------------------|
|SharePoint site node|<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerSiteNodeInfo>|
|Content type|<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.IContentTypeNodeInfo>|
|Feature|<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.IFeatureNodeInfo>|
|Field|<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.IFieldNodeInfo>|
|List|<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.IListNodeInfo>|
|List template|<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.IListTemplateNodeInfo>|
|List view (Microsoft.SharePoint.SPView)|<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.IListViewNodeInfo>|
|Workflow association|<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.IWorkflowAssociationNodeInfo>|
|Workflow template|<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.IWorkflowTemplateNodeInfo>|

 For more information about using the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A> property, see [Associate custom data with SharePoint tools extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md).

## See also
- [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md)
- [How to: Extend a SharePoint node in Server Explorer](../sharepoint/how-to-extend-a-sharepoint-node-in-server-explorer.md)
- [How to: Add a custom SharePoint node to Server Explorer](../sharepoint/how-to-add-a-custom-sharepoint-node-to-server-explorer.md)
- [How to: Get data for a built-in SharePoint node in Server Explorer](../sharepoint/how-to-get-data-for-a-built-in-sharepoint-node-in-server-explorer.md)
- [Associate custom data with SharePoint tools extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md)
- [Browse SharePoint connections using Server Explorer](../sharepoint/browsing-sharepoint-connections-using-server-explorer.md)
- [Extend the SharePoint tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md)
