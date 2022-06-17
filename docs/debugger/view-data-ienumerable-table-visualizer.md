---
title: "View IEnumerables in a table visualizer | Microsoft Docs"
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
# View IEnumerables in a table visualizer in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Starting in Visual Studio 2022 Update 2 Preview 1, you can view IEnumerable collections in a tabular view.

The table visualizer for IEnumerable helps explore large collection objects in a more streamlined way. The visualizer supports IEnumerable collections where the object type (T) can be simple types or complex types like dictionaries.

## Open the visualizer

To open the table visualizer, you must be paused during debugging.

1. Where you have an IEnumerable code implementation, find the magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon"):

   - Value column of the Locals and Watch window.
   - When you hover over a variable.

1. Select the icon to open the IEnumerable table visualizer.

   :::image type="content" source="../debugger/media/vs-2022/dbg-open-table-visualizer.png" alt-text="Open a table visualizer":::

## View table visualizer data

The visualizer shows the IEnumerable data in a table format.

:::image type="content" source="../debugger/media/vs-2022/dbg-table-visualizer.png" alt-text="View the visualizer data":::

You can use the right-click context menu to customize the view:

- Select **Hide Column** to hide duplicate data.
- Select **Expand Column** to see more profound items in the complex data.
- Select **Hide Children** to get a more concise view of your data.

## See also

- [Create custom visualizers (C#, Visual Basic)](../debugger/create-custom-visualizers-of-data.md)