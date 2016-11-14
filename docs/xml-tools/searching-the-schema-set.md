---
title: "Searching the Schema Set | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ec1395e0-d03c-4130-810d-f2db656937bd
caps.latest.revision: 3
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Searching the Schema Set
The XML Schema Explorer enables you to search the schema set in the following ways:  
  
-   Keyword search.  
  
-   Schema-specific search.  
  
## Keyword Search  
 You perform keyword searches by entering a substring in the **Search SchemaSet** text box of the XML Schema Explorer toolbar.  
  
 ![XML Schema Explorer Keyword Search](../xml-tools/media/schemaexplorersearch.gif "SchemaExplorerSearch")  
  
 The XML Schema Explorer searches the schema set for the following:  
  
-   Any `name` or `ref` attributes that match the specified keyword. This enables you to find elements, attributes, types, and so on by name.  
  
-   The `schemaLocation` attributes of include statements.  
  
-   The `namespace` attributes of import statements.  
  
## Schema Specific Search  
 The XML Schema Explorer also includes built-in searches that you can access by using the context menu of the XML Schema Explorer. For more information about available context menus, see [Context Menus](../xml-tools/context-menus-xml-schema-explorer.md). You can also perform a schema-specific search from the Start View; for more information, see the "Schema Set Details" section in the [Start View](../xml-tools/start-view.md) topic.  
  
## Displaying and Navigating Search Results  
 After the search is finished, the summary results pane is added to the toolbar with the results of the search. The search results are also highlighted in the XML Schema Explorer and marked by ticks on the vertical scroll bar. You can navigate the search results by using the **Go To Next Search Result** and **Go To Previous Search Result** buttons on the summary results pane of the XML Schema Explorer toolbar; by using the keyboard keys F3 and Shift+F3; or by clicking the tick marks in the scroll bar.  
  
 You can add the search results to the workspace by clicking the **Add highlighted nodes to Workspace** button on the summary results pane.  
  
 ![XML Schema Explorer Search Result](../xml-tools/media/schemaexplorersearchresult.gif "SchemaExplorerSearchResult")  
  
## Clearing Search Results  
 To clear the search results, click the **x** button on the summary results pane of the XML Schema Explorer Search toolbar.  
  
## See Also  
 [XML Schema Explorer](../xml-tools/xml-schema-explorer.md)