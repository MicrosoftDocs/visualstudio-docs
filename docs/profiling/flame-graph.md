---
title: Identify hot paths with the Flame Graph
description: Find hot paths in your code with a visualized overview
ms.date: 09/30/2022
ms.topic: how-to
ms.assetid: 7501a20d-04a1-480f-a69c-201524aa709d
author: mistymadonna
ms.author: mihays
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: '>= vs-2022'
ms.workload: 
  - multiple
---
# Identify hot paths with a visualized call tree

Flame graphs are a visualization of categorized data, created to visualize stack traces of profiled software so that the most frequent code paths can be identified quickly and accurately.

The **Flame Graph** helps you identify hot paths in your code by visualizing a call tree. The graph gives a visual overview of where time is being spent in your application and you can click on specific nodes to dig into them further.

![Screenshot showing Flame Graph with tooltips displayed.](./media/vs-2022/flame-graph-tooltips.png "Flame Graph with tooltips displayed")

## Investigate hot paths

1. The Flame Graph view is in the CPU tool details tool window, above the source line highlighting view. After you've stopped your profiling session, you can view the Flame Graph by clicking **Open details**.

   ![Screenshot showing Open details selected.](./media/vs-2022/flame-graph-open-details.png "Open details view selected")

1. Select **Flame Graph** in the Current View dropdown selection.

   ![Screenshot showing Flame Graph view selected.](./media/vs-2022/flame-graph-view.png "Flame Graph view selected")

   ![Screenshot showing Flame Graph overview displayed.](./media/vs-2022/flame-graph-overview.png "Flame Graph overview displayed")

1. By default, the flame graph in the CPU tool is shown upside down or as an "icicle chart," where the y-axis is counting stack depth downwards from zero at the top. You can view the standard flame chart layout by clicking **Flip Flame Graph**.

   ![Screenshot showing Flip Flame Graph selected.](./media/vs-2022/flame-graph-flip.png "Flip Flame Graph selected")

## Navigation
In the Flame Graph view, you can navigate by clicking on a node with a mouse or using the keyboard.

|Keyboard shortcut|Command|
|-|-|
|Tab|Go to any node|
|Up/Down arrow|Go to a node's parent or child|
|Enter|Zoom in|
|Escape|Zoom out|

## See also

- [Diagnose high latency with CPU Insights](../profiling/cpu-insights.md)
- [Analyze CPU usage without debugging](../profiling/cpu-usage.md)