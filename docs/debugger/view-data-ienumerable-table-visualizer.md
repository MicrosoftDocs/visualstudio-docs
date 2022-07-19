---
title: "View .NET collections with the IEnumerable visualizer  | Microsoft Docs"
description: Use the table visualizer in Visual Studio debugger to view IEnumerables.
ms.date: "04/08/2022"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
helpviewer_keywords:
  - "string visualizer"
  - "visualizers, string"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: '>= vs-2022'
ms.workload:
  - "multiple"
---
# View .NET collections with the IEnumerable visualizer in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Starting in Visual Studio 2022 Update 2 Preview 1, you can view IEnumerable collections in a tabular view.

The IEnumerable visualizer helps explore large collection objects in a more streamlined way. The visualizer supports IEnumerable collections where the object type (T) can be simple types or complex types like dictionaries.

## Open the visualizer

To open the IEnumerable visualizer, you must be paused during debugging.

1. Where you have an IEnumerable code implementation, find the magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon"):

   - Value column of the Locals and Watch window.
   - When you hover over a variable.

1. Select the icon to open the IEnumerable visualizer.

   :::image type="content" source="../debugger/media/vs-2022/dbg-open-IEnumerable-visualizer.png" alt-text="Open a IEnumerable visualizer":::

## View IEnumerable visualizer data

The visualizer shows the IEnumerable data in a  format.

:::image type="content" source="../debugger/media/vs-2022/dbg-IEnumerable-visualizer.png" alt-text="View the visualizer data":::

You can use the right-click context menu to customize the view:

- Select **Hide Column** to hide duplicate data.
- Select **Expand Column** to see more profound items in the complex data.
- Select **Hide Children** to get a more concise view of your data.

# Export visualizer data
- You can export the data from IEnumerable visualizers in CSV/Excel format using the dropdown on the top right corner.


# Filter and sort  visualizer data
- To sort the visualizer data by ascending/descending order click on the desired column title the visualizer data will be sorted.
- You also can filter visualizer data based desired filter string. Enter the string in the filter box on the upper right corner and hit enter. The Visualizer will return all the rows that contain a value that matches the filter string.
- You can also export the filtered and sorted results in CSV/Excel format.

:::image type="content" source="../debugger/media/vs-2022/dbg-IEnumerable-visualizer-filter.png" alt-text="View the visualizer data filter":::

## See also

- [Create custom visualizers (C#, Visual Basic)](../debugger/create-custom-visualizers-of-data.md)