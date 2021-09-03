---
title: Context Menus in XML Schema Explorer
description: Learn about the Context Menus in XML Schema Explorer that contain items for performing schema-specific searches and other operations. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 42ab17ca-b8c1-40d7-beda-d033f66fe874
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-xml-tools
ms.workload:
- multiple
---
# Context menus (XML Schema Explorer)

A context menu is the menu that appears when you right-click on something. The following context menu items are used to perform schema-specific searches and other operations.

## Node type: Schema set

The following table describes the options that are available for a schema set node.

|Option|Description|
|-|-----------------|
|**Show Most Likely Root Elements**|Finds and highlights all global elements that are not referenced from global elements other than themselves.|
|**Show Global Types**|Finds and highlights all global types in the schema set.|
|**Show Global Elements**|Finds and highlights all global elements in the schema set.|
|**Properties Window**|Opens the **Properties** window (if it is not already open). This window displays information about the node.|

## Node type: Namespace
The following table describes the options that are available for a namespace node.

|Option|Description|
|-|-----------------|
|**Show All Inbound References**|Finds and highlights files that import the selected namespace.|
|**Show All Outbound References**|For every file in the selected namespace, finds and highlights the following:<br /><br /> -   All namespaces referenced in import statements without a `schemaLocation` attribute.<br />-   All files in namespaces other than the selected one that are specified in the `schemaLocation` attribute in import and include statements.|
|**Show Global Types**|Finds and highlights all global types in the selected namespace.|
|**Show Global Elements**|Finds and highlights all global elements in the selected namespace.|
|**Properties Window**|Opens the **Properties** window (if it is not already open). This window displays information about the node.|

## Node type: File
The following table describes the options that are available for a file node.

|Option|Description|
|-|-----------------|
|**Show All Inbound References**|Finds and highlights all files that specify the selected file in the `schemaLocation` attributes of their include and import statements.|
|**Show All Outbound References**|Finds and highlights the following:<br /><br /> -   All namespaces specified in the namespace attributes of all import statements that do not have the `schemaLocation` attribute.<br />-   All files specified in the `schemaLocation` attributes of all import and include statements.|
|**Show Global Types**|Finds and highlights all global types in this file.|
|**Show Global Elements**|Finds and highlights all global elements in this file.|
|**View Code**|Opens the file that contains the selected node in the XML editor. The item that is selected in the XML Schema Explorer will also be selected in the XML editor.|
|**Properties Window**|Opens the **Properties** window (if it is not already open). This window displays information about the node.|

## All global node types
The following table describes the options that are available for all global nodes.

|Option|Description|
|-|-----------------|
|**Show in Graph View**|Opens the Graph View. If the selected node is not in the workspace, adds it to the workspace and selects the node.|
|**Show in Content Model View**|Opens the Content Model View. If the selected node is not in the workspace, adds it to the workspace and selects the node.|
|**View Code**|Opens the file that contains the selected node in the XML editor. The item that is selected in the XML Schema Explorer will also be selected in the XML editor.|
|**Properties Window**|Opens the **Properties** window (if it is not already open). This window displays information about the node.|

## Node type: Element
In addition to the global node options described above, the context menu for element nodes has the following options:

|Option|Description|
|-|-----------------|
|**Go To Type Definition**|Navigates to the type definition of the selected element. This is applicable when the type that is used for the element is a global type.|
|**Go To The Original Element**|For element references, navigates to the actual definition of the element.|
|**Show All References**|For global elements, finds and highlights all references (elements that have `ref="selectedElement"`) to the selected element.|
|**Show Members Of Substitution Group**|For heads of a substitution group, finds and highlights all elements that are members of the substitution group of which the selected element is a member. This shows direct and indirect participants.|
|**Show Substitution Group Heads**|For global elements that are members of a substitution group, finds and highlights all direct and indirect heads for the selected element, such as the following:<br /><br /> -   A substitution group head specified on the selected element.<br />-   A substitution group head specified on its head element.|
|**Generate Sample XML**|Available only for global elements. Generates a sample XML file for the global element.|

## Node type: Global types
In addition to the global node options described above, the context menu for global type nodes has the following options:

|Option|Description|
|-|-----------------|
|**Show Base Type**|If the selected type is derived from a global type, navigates to the base type of the selected type.|
|**Show All References**|Finds and highlights all references to the selected type. This includes elements and attributes of the selected type and types derived from the selected type.|
|**Show All Derived Types**|Finds and highlights all types that are directly and indirectly derived from the selected type.|
|**Show All Ancestors**|Show all parent (base) types.|

## Node type: Attribute
In addition to the global node options described above, the context menu for attribute nodes has the following options:

|Option|Description|
|-|-----------------|
|**Go To Type Definition**|When the type that is used for the attribute is a global type, navigates to the type definition of the selected attribute.|
|**Go To The Original Attribute**|For attribute references, navigates to the actual definition of the attribute.|
|**Show All References**|For global attributes, finds and highlights all references (other attributes that have `ref="selectedAttribute"`) to the selected attribute.|

## Node type: Attribute group
In addition to the global node options described above, the context menu for attribute group nodes has the following options:

|Option|Description|
|-|-----------------|
|**Go To Definition**|For references, navigates to the actual definition of the attribute.|
|**Show All Members**|Finds and highlights all members of the attribute group.|
|**Show All References**|Finds and highlights all references (attribute groups that have `ref="selectedAttributeGroup"`) to the selected attribute group.|

## Node type: Named group
In addition to the global node options described above, the context menu for named group nodes has the following options:

|Option|Description|
|-|-----------------|
|**Go To Definition**|For references, navigates to the actual definition of the attribute.|
|**Show All Members**|Finds and highlights all members of the named group.|
|**Show All References**|Finds and highlights all references (groups that have `ref="selectedGroup"`) to the selected group.|

## See also

- [XML Schema Explorer](../xml-tools/xml-schema-explorer.md)
- [Searching the schema set](../xml-tools/searching-the-schema-set.md)
