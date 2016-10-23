---
title: "XML Schema Explorer"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2fc39e98-b194-456b-a452-cfafb0a52d66
caps.latest.revision: 3
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# XML Schema Explorer
The XML Schema Explorer is integrated with Microsoft Visual Studio and the XML Editor to enable you to work with XML Schema definition language (XSD) schemas. When you open an XML Schema file, the **Schema Set** node appears in the XML Schema Explorer. All the included, imported, or redefined schemas for your target file, as well as any files that are referenced through an `include` or `import` statement, also appear in the XML Schema Explorer.  
  
 The XML Schema Explorer enables you to do the following:  
  
-   Get a quick overview of the schema set.  
  
-   Browse and navigate the tree.  
  
-   Perform keyword and schema-specific searches. For more information, see [Searching the Schema Set](../VS_IDE/Searching-the-Schema-Set.md).  
  
-   Add the search results to the Graph View or Content Modle View  
  
-   Sort the tree by document order, type, or name. For more information, see [Sorting, Filtering, and Grouping](../VS_IDE/Sorting--Filtering--and-Grouping--XML-Schema-Explorer-.md).  
  
-   Open the XML Editor and jump to code locations in the XSD file. For more information, see [Integration with XML Editor](../VS_IDE/Integration-with-XML-Editor.md).  
  
-   Generate sample XML for global elements.  
  
 The XML Schema Explorer provides a hierarchal view of the schema set through a tree view. The XML Schema Explorer also provides search, filtering, navigation, and sorting. To access the XML Schema Explorer, do one of the following:  
  
-   If you are on the [Start View](../VS_IDE/Start-View.md), click the **XML Schema Explorer** link.  
  
-   If you are on the [Graph View](../VS_IDE/Graph-View.md) or the [Content Model View](../VS_IDE/Content-Model-View.md) and have nodes in your workspace, use the context menu to select the XML Schema Explorer.  
  
-   You can also select the XML Schema Explorerfrom the **View** menu.  
  
-   You can access the XML Schema Explorerfrom a .vb file that has a Visual Basic XML literal associated with an .xsd file. To see the schema set in the XML Schema Explorer, right click an XML node in an XML literal or an XML namespace import and select the **Show in Schema Explorer** command. For more information, see [Integration of XML Literals with XML Schema Explorer](../VS_IDE/Integration-of-XML-Literals-with-XML-Schema-Explorer.md).  
  
## Tree View  
 The XML Schema Explorer displays pre-compiled schema set information in a tree structure. The tree structure is organized as follows:  
  
-   At the top level is the schema set node.  
  
-   The second level contains the namespaces.  
  
-   The third level contains the files.  
  
-   The fourth level contains the global nodes. This can include elements, groups, complex types, simple types, attributes, attribute groups, and `include`, `import`, and `redefine` statements.  
  
 The following is an example of a tree structure:  
  
 ![XML Schema Explorer](../VS_IDE/media/XMLSchemaExplorer.gif "XMLSchemaExplorer")  
  
## Selection and Activation  
 To highlight and select a node, click once in the Schema Explorer.  
  
 To activate a node, double-click it or press **Enter** when the node is selected.  
  
-   Activating a node opens the file in which this node is defined (if the file is not already open) and selects the node in the file.  
  
-   Activating a file node opens the selected file (if it is not already open) and highlights the `<schema>` node.  
  
-   Activating a SchemaSet or a namespace node does nothing.  
  
## Draging and Dropping Nodes  
 You can drag and drop global nodes, file nodes, and namespace nodes onto an XSD Designer view. If the current view is the [Start View](../VS_IDE/Start-View.md), dragging a node on to the view will open the [Graph View](../VS_IDE/Graph-View.md). If the current view is the [Content Model View](../VS_IDE/Content-Model-View.md) or Graph View, the view will not change when you drop a node onto it.  
  
 Dropping files on the view will add all the global nodes in the file to the [XSD Designer Workspace](../VS_IDE/XML-Schema-Designer-Workspace.md). Dropping namespaces on the view will add all the global nodes in the namespace to the workspace. The workspace is shared between all the views.  
  
 You cannot drag and drop local nodes or imports.  
  
## In This Section  
  
-   [Searching the Schema Set](../VS_IDE/Searching-the-Schema-Set.md)  
  
-   [Sorting, Filtering, and Grouping](../VS_IDE/Sorting--Filtering--and-Grouping--XML-Schema-Explorer-.md)  
  
-   [Context Menus](../VS_IDE/Context-Menus--XML-Schema-Explorer-.md)  
  
-   [Integration of XML Literals with XML Schema Explorer](../VS_IDE/Integration-of-XML-Literals-with-XML-Schema-Explorer.md)  
  
## See Also  
 [How to: Add Nodes to the Workspace from the XML Schema Explorer](../VS_IDE/How-to--Add-Nodes-to-the-Workspace-from-the-XML-Schema-Explorer.md)