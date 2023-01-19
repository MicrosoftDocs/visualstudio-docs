---
title: "View  data with the Tabular visualizer  | Microsoft Docs"
description: Use tabular visualizer in Visual Studio debugger.
ms.date: "01/19/2023"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
helpviewer_keywords:
  - "tabular visualizer"
  - "visualizers, tabular"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: '>= vs-2022'
ms.workload:
  - "multiple"
---

# Tabular visualizers in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

While you are debugging in Visual Studio, you can view large collection objects with the built-in tabular visualizers. The visualizer shows data in a tabular view with one row per object and sortable columns for each field and property. 

There are two types of tabular visualizers. The DataSet visualizer allows you to view the contents of a DataSet, DataTable, DataView, or DataViewManager. The IEnumerable visualizer allows you to view objects such as Arrays, List, etc.

## Open the visualizer

To open the visualizer, you must be paused during debugging.

You can access the visualizer by clicking on the magnifying glass icon that appears next to the Value for one of those objects ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon")
in a debugger variables window or in a DataTip.

:::image type="content" source="../debugger/media/vs-2022/dbg-ienumerable-debugger-visualizer.png" alt-text="Diagram of Open a IEnumerable visualizer.":::

## DataSet visualizer 

The DataSet Visualizer allows you to view the contents of a DataSet, DataTable, DataView, or DataViewManager object. 

:::image type="content" source="../debugger/media/dbg-tips-dataset-visualizer.png " alt-text="Diagram of View the DataSet visualizer data.":::
## IEnumerable visualizer 

Starting in Visual Studio 2022, you can view IEnumerable collections in a tabular view.

The IEnumerable visualizer helps explore large collection objects in a more streamlined way. The visualizer supports IEnumerable collections where the object type (T) can be simple types or complex types like dictionaries.

:::image type="content" source="../debugger/media/vs-2022/dbg-ienumerable-visualizer-data.png" alt-text="Diagram of View the IEnumerable visualizer data.":::

You can use the right-click context menu to customize the view:

- Select **Hide Column** to hide duplicate data.
- Select **Expand Column** to see more details items in the complex data.
- Select **Hide Children** to get a more concise view of your data.

## Filter, sort, and export  visualizer data
- Both DataSet and IEnumerable support filtering, sorting, and exporting of visualizer data.
- You can sort the visualizer columns in ascending/descending order by clicking on the column name.
- You also can filter visualizer data based on a filter string. Enter the string in the filter box in the upper right corner and press Enter. The Visualizer returns all the rows that contain a value that matches the filter string.
- You can export the data from IEnumerable visualizers in CSV/Excel format using the dropdown on the top right corner.
- You can also export the filtered and sorted results in CSV/Excel format.

:::image type="content" source="../debugger/media/vs-2022/dbg-ienumerable-visualizer-filtering.gif" alt-text="Diagram of View the visualizer data filter.":::

## See also
- [View strings in a string visualizer](../debugger/view-strings-visualizer.md)
- [Create custom visualizers (C#, Visual Basic)](../debugger/create-custom-visualizers-of-data.md)
