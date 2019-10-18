---
title: "XML Schema Designer Graph View"
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 5881afde-3f24-4eb9-bff8-6cb3fc8aade7
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Graph view

The Graph View provides a graphic representation of global schema nodes and the relationships between the nodes. Note that the Graph View does not allow you to alter the layout of the schema set on the design surface. The Graph View also includes the XML Schema Designer toolbar and the breadcrumb bar.

The following image shows the Graph View with six global nodes on its design surface.

![XML Schema Designer Graph View](../xml-tools/media/xsddesigner_graphview.gif)

## Design surface

The design surface of the Graph View displays the contents of the [XML schema designer workspace](../xml-tools/xml-schema-designer-workspace.md). If the workspace contains any global nodes from the schema set, the nodes are shown on the Graph View design surface and arrows are drawn between the nodes that have relationships.

Double-clicking a node in the Graph View will bring up XML editor.

To delete selected nodes from the workspace, use the XSD Designer toolbar or the **Delete** key.

If the design surface is blank, the XML editor, the **XML Schema Explorer**, and the watermark are shown. The *watermark* is a list of links to all the XSD Designer views.

![XSD Designer; Graph View](../xml-tools/media/xsdgraphviewwatermark.gif)

If the schema set has errors, the following text is displayed at the end of the list: "Use the Error List to view and fix the errors in the set."

## Breadcrumb bar

The breadcrumb bar at the bottom of the Graph View shows where the selected node is located in the schema set. If multiple items are selected, the breadcrumb bar will be blank.

## Context (right-click) menu

The following table describes the options that are available for all the nodes on the Graph View design surface.

|Option|Description|
|-|-----------------|
|**Show in XML Schema Explorer**|Puts focus on the Schema Explorer and highlights the schema set node.|
|**Show in Graph View**|Switches to the Graph View (grayed out).|
|**Generate Sample XML**|Available only for global elements. Generates a sample XML file for the global element.|
|**Clear Workspace**|Clears the workspace and the design surface.|
|**Remove from Workspace**|Removes selected nodes from the workspace and the design surface.|
|**Remove all but selection from Workspace**|Removes nodes that are not selected from the workspace and the design surface.|
|**Export Diagram as Image**|Saves the design surface to an XPS file.|
|**Select All**|Selects all the nodes on the design surface.|
|**View Code**|Opens the file that contains the selected node in the XML editor. The item that is selected in the **XML Schema Explorer** is also selected in the XML editor.|
|**Properties Window**|Opens the **Properties** window (if it is not already open). This window displays information about the node.|

In addition to the common options described above, the context menu for global elements also has the following options:

|Option|Description|
|-|-----------------|
|**Add Type Definition**|Adds the base type to the diagram.|
|**Add All References**|Adds all the nodes that refer to the element and draws arrows to indicate relationships between them.|
|**Add Substitution Group Members**|Adds all substitution group members. This option appears in the view if the element is the head or member of a substitution group.|
|**Generate Sample XML**|Generates a sample XML file for the global element.|

In addition to the common options described above, the context menu for global simple and global complex types also has the following options:

|Option|Description|
|-|-----------------|
|**Add Base Type**|If the selected type is derived from a global type, adds the base type of the selected type.|
|**Add All References**|Adds all references of the selected type. This includes elements and attributes of the selected type, and types derived from the selected type.|
|**Add All Derived Types**|Adds all types that are directly and indirectly derived from the selected type.|
|**Add All Ancestors**|Adds all parent (base) types.|

In addition to the common options described above, the context menu for global groups and attribute groups also has the following options:

|Option|Description|
|-|-----------------|
|**Add All References**|Adds all nodes that refer to the group and draws arrows to indicate relationships between them.|
|**Add All Members**|Adds all members of the group and draws arrows to indicate relationships between them.|

In addtion to the common options described above, the context menu for global attributes also has the following options:

|Option|Description|
|-|-----------------|
|**Add All References**|Adds all nodes that refer to the group and draws arrows to indicate relationships between them.|

## Properties window

Use the context (right-click) menu to initially open the **Properties** window. By default, the **Properties** window appears in the lower right corner of Visual Studio. When you click a node that is rendered in the Content Model View, the properties of that node will be displayed in the **Properties** Window.

## XSD toolbar

The following XSD Toolbar buttons are enabled when the Graph View is active.

![XML Schema Designer Toolbar](../xml-tools/media/xsdgraphviewtoolbar.gif)

|Option|Description|
|-|-----------------|
|**Show Start View**|Switches to the [Start View](../xml-tools/start-view.md). This view can be accessed by using the keyboard shortcut: **Ctrl**+**1**.|
|**Show Content Model View**|Switches to the [Content Model View](../xml-tools/content-model-view.md). This view can be accessed by using the keyboard shortcut: **Ctrl**+**2**.|
|**Show Graph View**|Switches to the [Graph View](../xml-tools/graph-view.md). This view can be accessed by using the keyboard shortcut: **Ctrl**+**3**.|
|**Clear Workspace**|Clears the workspace and the design surface.|
|**Remove from Workspace**|Removes selected nodes from the workspace and the design surface.|
|**Remove all but selection from Workspace**|Removes nodes that are not selected from the workspace and the design surface. This option is enabled in the Content Model View and in the Graph View.|
|**Left to Right**|Changes the layout in the Graph View to a left-to-right hierarchical representation of nodes. This option can be accessed by using the keyboard shortcut: **Alt**+**right arrow**.|
|**Right to Left**|Changes the layout in the Graph View to a right-to-left hierarchical representation of nodes. This option can be accessed by using the keyboard shortcut: **Alt**+**left arrow**.|
|**Top to Bottom**|Changes the layout in the Graph View to a top-to-bottom hierarchical representation of nodes. This option can be accessed by using the keyboard shortcut: **Alt**+**down arrow**.|
|**Bottom to Top**|Changes the layout in the Graph View to a bottom-to-top hierarchical representation of nodes. This option can be accessed by using the keyboard shortcut: **Alt**+**up arrow**.|

## Pan/Scroll

You can pan the design surface by using the scrollbars or by holding the **Ctrl** key while you click and drag the mouse. When you pan the design surface using click and drag, the cursor will change to four crossed arrows pointing in four directions.

## Undo/Redo

The undo/redo capability is enabled in the Graph View for the following actions:

- Adding a single node by dragging and dropping.

- Adding multiple nodes from the search results window in Schema Explorer or Start View queries.

- Deleting single or multiple nodes.

## Zoom

Zoom is available in the lower right corner of the Graph View.

Zoom can be controlled in the following ways:

- By holding the **Ctrl** key and spinning the mouse wheel when the mouse is hovering over the Graph View surface.

- By using the slider control. The slider shows the current zoom level.

The Zoom slider is opaque when you select it, hover over it, or use **Ctrl** with the mouse wheel to zoom; at all other times, it is transparent.

## XML editor integration

You can switch back and forth between the Graph View and the XML editor by clicking a node and using the View Code context (right-click) menu.

If you make changes to the schema set in the XML editor, the changes will be synchronized in the Graph View. For more information, see [Integration with XML editor](../xml-tools/integration-with-xml-editor.md).

## See also

- [Design Surface](../xml-tools/xml-schema-designer-workspace.md)