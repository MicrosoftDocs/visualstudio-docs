---
title: XML Schema Designer Content Model View
description: Learn about the Content Model View in the XAML Schema Designer that provides a graphic representation of local and global schema nodes and their components.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: e8db7c7d-31cf-479e-9dcc-299759891795
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-xml-tools
ms.workload:
- multiple
---
# Content Model View

The Content Model View provides a graphic representation of local and global schema nodes and their components, including simple and complex types, elements, model groups, attributes, and attribute groups. XML comments and processing instructions cannot be viewed in the Content Model View. The Content Model View contains two panels: a **Workspace** panel that contains a list of the nodes in the [XML schema designer workspace](../xml-tools/xml-schema-designer-workspace.md), and the design surface where you can see the content model of schema nodes that are selected in the **Workspace** panel. The Content Model View also includes the XML Schema Designer toolbar and the breadcrumb bar.

In the following image, the **Workspace** panel contains six schema nodes. The `purchaseOrder` node is selected in the **Workspace** panel and is displayed in the design surface.

![XML Schema Designer Content Model View](../xml-tools/media/xsddesigner_contentmodelview.gif)

## Workspace panel

After you add nodes to the workspace, the list of nodes will appear in the **Workspace** panel of the Content Model View. When you select nodes in the **Workspace** panel, they appear on the Content Model View design surface. To delete nodes from the workspace, use the XSD Designer toolbar, the **Workspace** panel right-click menu, or the **Delete** key.

For information about adding nodes, see the "Adding Nodes to the Workspace" section in [XML schema designer workspace](../xml-tools/xml-schema-designer-workspace.md).

## Design surface

When a node is selected in the **Workspace** panel, it is added to the Content Model View design surface where you can view the details of the node.

The content model of a node is represented by an expandable graphical tree with elements and attributes appearing as tree nodes. By default, only one level is expanded. Other information, such as compositors, type names, groups, and other containers are placed in a vertical bar (when expanded) along the elements and attributes they enclose. When you double-click a vertical bar, it becomes horizontal and the tree collapses. When you double-click a horizontal bar, it becomes vertical and the tree expands. Selecting the vertical bar selects all the nodes in the container. Expanders appear on the right of a node if an element can be expanded or collapsed.

If the design surface is blank, the XML editor, the **XML Schema Explorer**, and the watermark are shown. The *watermark* is a list of links to all the XSD Designer views. If the schema set has errors, the following text is displayed at the end of the list: "Use the Error List to view and fix the errors in the set."

## Breadcrumb bar

The breadcrumb bar at the bottom of the Content Model View shows where the selected node is located in the schema set.

## Context menus

When you right-click an item on the design surface or **Workspace** panel, a context menu appears. The following table describes the options that are available for the Content Model View design surface.

|Option|Description|
|-|-----------------|
|**Show in XML Schema Explorer**|Puts focus on the Schema Explorer and highlights the schema set node.|
|**Show in Graph View**|Switches to the Graph View.|
|**Generate Sample XML**|Available only for global elements. Generates a sample XML file for the global element.|
|**Show Documentation**|Shows or hides Annotation/Documentation node contents.|
|**Export Diagram as Image**|Saves the design surface to an XPS file.|
|**View Code**|Opens the file that contains the selected node in the XML editor. The item that is selected in the **XML Schema Explorer** is also selected in the XML editor.|
|**Properties Window**|Opens the **Properties** window (if it is not already open). This window displays information about the node.|

The following table describes the options that are available for the **Workspace** panel.

|Option|Description|
|-|-----------------|
|**Show in XML Schema Explorer**|Puts focus on the Schema Explorer and highlights the schema set node.|
|**Show in Graph View**|Switches to Graph View.|
|**Clear Workspace**|Clears the workspace and the design surface.|
|**Remove from Workspace**|Removes selected nodes from the workspace and the design surface.|
|**Remove all but selection from Workspace**|Removes nodes that are not selected from the workspace and the design surface.|
|**Generate Sample XML**|Available only for global elements. Generates a sample XML file for the global element.|
|**Select All**|Selects all the nodes in the **Workspace** panel.|
|**View Code**|Opens the file that contains the selected node in the XML editor. The item that is selected in the **XML Schema Explorer** is also selected in the XML editor.|
|**Properties Window**|Opens the **Properties** window (if it is not already open). This window displays information about the node.|

## Properties window

Use the right-click (context) menu to initially open the **Properties** window. By default, the **Properties** window appears in the lower right corner of Visual Studio. When you click a node that is rendered in the Content Model View, the properties of that node are displayed in the **Properties** Window.

## XSD designer toolbar

The following XSD Designer Toolbar buttons are enabled when the Content Model View is active.

![XML Schema Designer Toolbar](../xml-tools/media/xsdcontentmodelviewtoolbar.gif)

|Option|Description|
|-|-----------------|
|**Show Start View**|Switches to the [Start View](../xml-tools/start-view.md). This view can be accessed by using the keyboard shortcut: **Ctrl**+**1**.|
|**Show Content Model View**|Switches to the [Content Model View](../xml-tools/content-model-view.md). This view can be accessed by using the keyboard shortcut: **Ctrl**+**2**.|
|**Show Graph View**|Switches to the [Graph View](../xml-tools/graph-view.md). This view can be accessed by using the keyboard shortcut: **Ctrl**+**3**.|
|**Clear Workspace**|Clears the workspace and the design surface.|
|**Remove from Workspace**|Removes selected nodes from the workspace and the design surface.|
|**Remove all but selection from Workspace**|Removes nodes that are not selected from the workspace and the design surface.|
|**Show Documentation**|Shows or hides Annotation/Documentation node contents.|

## Pan/Scroll

You can pan the design surface by using the scrollbars or by holding the **Ctrl** key while you click and drag the mouse. When you pan the design surface using click and drag, the cursor changes to four crossed arrows pointing in four directions.

## Undo/Redo

The undo/redo capability is enabled in the Content Model View for the following actions:

- Adding a single node by dragging and dropping.

- Adding multiple nodes from the search results window in Schema Explorer.

- Adding nodes from the Start View.

- Deleting single or multiple nodes.

## Zoom

Zoom is available in the lower right corner of the Content Model View.

Zoom can be controlled in the following ways:

- By holding the **Ctrl** key and spinning the mouse wheel when the mouse is hovering over the Content Model View surface.

- By using the slider control. The slider shows the current zoom level.

The Zoom slider is opaque when you select it, hover over it, or use **Ctrl** with the mouse wheel to zoom; at all other times, it is transparent.

## XML editor integration

You can switch back and forth between the **XSD Designer** and the XML editor by using the right-click (context) menu.

If you make changes to the schema set in the XML editor the changes are synchronized in the Content Model View. For more information, see [Integration with XML editor](../xml-tools/integration-with-xml-editor.md).

## See also

- [XML Schema Designer Workspace](../xml-tools/xml-schema-designer-workspace.md)
