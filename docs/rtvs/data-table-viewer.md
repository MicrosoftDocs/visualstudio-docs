---
title: "Data Table Viewer in R Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 4/10/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-r"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6c669434-40d8-4970-92cc-502a98c8b5ab
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
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


# Data table viewer

Because the data for each team is *tabular*, it makes sense to view them in a table form. If you click on the magnifying glass icon next to the team name, you'll open up the Data Table Viewer:

![](media/variable-explorer-table-view.png)

The column headings in the data table viewer control the sorting behavior of a column. You can click on a single column heading to toggle between sorting ascending and descending by that column. If you hold down the Shift key while clicking on the column headings, you can multi-select several columns. The sequence in which you click the column headings determines the order in which the sorting is performed. For example, in the figure below, we are sorting first by cylinder, and then by displacement.

![](media/variable-explorer-table-view-sorting.png)

You can now view multiple data frames in separate Data Table Viewer tabs. Using Visual Studio's window layout features, you can drag the tabs to arrange them side-by-side as well:

![](media/repl-multiple-datatables.png)