---
title: "Sorting, Filtering, and Grouping (XML Schema Explorer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-xml-tools
ms.topic: conceptual
ms.assetid: 4a914de0-9ffc-4526-9603-92e460e52513
caps.latest.revision: 11
author: jillre
ms.author: jillfra
manager: jillfra
---
# Sorting, Filtering, and Grouping (XML Schema Explorer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic describes the options that are available through the **Sorting, Filtering, and Grouping Options** menu on the XML Schema Explorer toolbar.

## Filter Options
 The following filter options are available. By default, the **Show Namespaces** and **Show Schema Files** options are selected.

- **Show Namespaces**.

- **Show Schema Files**.

- **Show Compositors (sequence/choice/all)**.

## Sorting Options
 The following sorting options are available. The default is **Sort By Type**. Sort By options do not apply to files and namespaces.

- **Sort By Type**.

- **Sort By Name**.

- **Document Order**.

### Sort By Type
 When the **Sort By Type** option is selected, global nodes are sorted in the following order. Nodes are then sorted alphabetically within each group.

1. `import` nodes.

2. `include` nodes.

3. `redefine` nodes.

4. `attribute` nodes.

5. `attributeGroup` nodes.

6. `complexType` nodes.

7. `simpleType` nodes.

8. `element` nodes.

9. `group` nodes.

### Sort By Name
 When the **Sort By Name** option is selected, global nodes are sorted in the following order:

1. `import` nodes (in alphabetical order of namespaces).

2. `include` nodes (in alphabetical order of `schemaLocation` attributes).

3. `redefine` nodes (in alphabetical order of `schemaLocation` attributes).

4. Other global nodes in alphabetical order.

### Document Order
 The **Document Order** option is available when the **Show Schema Files** option is selected. When **Document Order** is selected, global nodes are displayed in the order in which they appear in the schema file.

## Persisting Sort/Filter Options
 The sorting, filtering, and grouping options are saved to the registry for each user, no matter which solution or files were open when the settings were changed.
