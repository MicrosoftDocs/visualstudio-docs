---
title: "Graphics API and Memory Statistics | Microsoft Docs"
description: Review the Graphics API Statistics and Memory Statistics tools, which show information on Direct3D API usage and GPU memory consumption of various resources.
ms.custom: SEO-VS-2020
ms.date: "03/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "vs.graphics.apistatistics"
  - "vs.graphics.memorystatistics"
ms.assetid: 27d2f303-e3ed-4219-9009-345a0d849506
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Graphics API and Memory Statistics
<!-- VERSIONLESS -->
Visual Studio 2017 and greater support the Graphics API Statistics and Memory Statistics tools.  These two tools let you view various bits of information on Direct3D API usage as well as GPU memory consumption of various resources.

## Graphics API Statistics
The Graphics API Statistics in Visual Studio Graphics Diagnostics lets you view all of the Direct3D calls that were made, and the count of each call.  To view the window, select the **View > API Statistics** menu item.

![API Statistics](media/gfx_diag_api_statistics.png)

This tool can be handy in discovering DirectX calls you may not realize you're making, or calls you are making too often.

You can right-click in the window to Copy All data as CSV, which can be pasted into something like Excel for further analysis.

## Memory Statistics
This tool will display how much memory the graphics driver is allocating for the resources you create in a frame.  To view this window, select the **View > Memory Statistics** menu item.

![Memory Statistics](media/gfx_diag_memory_statistics.png)

The **GPU Allocation** column displays the amount of memory used by the event displayed in the **Event** column.  You can also select the watch icon ![watch icon](media/gfx_watch.png) to view the [Resource History](graphics-event-list.md#resource-history) for the selected event.

As with the API Statistics tool, you can right-click in the window to Copy All data as CSV, which can be pasted into something like Excel for further analysis.

## See also
- [Graphics Diagnostics (Debugging DirectX Graphics)](visual-studio-graphics-diagnostics.md)
- [Resource History](graphics-event-list.md#resource-history)
<!-- /VERSIONLESS -->