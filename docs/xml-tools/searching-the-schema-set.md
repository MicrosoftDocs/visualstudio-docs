---
title: XML Schema Explorer - search the schema set
description: Learn how to do a keyword search and schema-specific search of the schema set in the XML Schema Explorer.
ms.date: 11/04/2016
ms.topic: article
author: dzsquared
ms.author: drskwier
manager: mijacobs
ms.subservice: xml-tools
---
# Search the schema set

The **XML Schema Explorer** enables you to search the schema set in the following ways:

- Keyword search.

- Schema-specific search.

## Keyword search

You perform keyword searches by entering a substring in the **Search SchemaSet** text box of the **XML Schema Explorer** toolbar.

![XML Schema Explorer Keyword Search](../xml-tools/media/schemaexplorersearch.gif)

The **XML Schema Explorer** searches the schema set for the following attributes:

- Any `name` or `ref` attributes that match the specified keyword. You can find elements, attributes, types, and so on, by name.

- The `schemaLocation` attributes of include statements.

- The `namespace` attributes of import statements.

## Schema specific search

The **XML Schema Explorer** also includes built-in searches that you can access by using the context (right-click) menu of the **XML Schema Explorer**. For more information about available context menus, see [Context menus](../xml-tools/context-menus-xml-schema-explorer.md). You can also perform a schema-specific search from the Start View; for more information, see the "Schema Set Details" section in the [Start View](../xml-tools/start-view.md) topic.

## Display and navigate search results

After the search is finished, the summary results pane is added to the toolbar with the results of the search. The search results are also highlighted in the **XML Schema Explorer** and marked by ticks on the vertical scroll bar. You can navigate the search results by using the **Go To Next Search Result** and **Go To Previous Search Result** buttons on the summary results pane of the **XML Schema Explorer** toolbar; by using the keyboard keys **F3** and **Shift**+**F3**; or by clicking the tick marks in the scroll bar.

You can add the search results to the workspace by clicking the **Add highlighted nodes to Workspace** button on the summary results pane.

![XML Schema Explorer Search Result](../xml-tools/media/schemaexplorersearchresult.gif)

## Clear search results

To clear the search results, click the **x** button on the summary results pane of the **XML Schema Explorer** Search toolbar.

## Related content

- [XML Schema Explorer](../xml-tools/xml-schema-explorer.md)
