---
title: "Analyze memory usage"
ms.custom: "seodec18"
ms.date: "01/02/2018"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload: 
  - "multiple"
---
# Analyze memory usage
Use the debugger-integrated **Memory Usage** diagnostic tool to find memory leaks and inefficient memory usage. The Memory Usage tool lets you take one or more *snapshots* of the managed and native memory heap. You can collect snapshots of .NET, ASP.NET, native, or mixed mode (.NET and native) apps.  
  
-   You can analyze a single snapshot to understand the relative impact of the object types on memory use, and to find code in your app that uses memory inefficiently.  
  
-   You can also compare (diff) two snapshots of an app to find areas in your code that cause the memory use to increase over time.  

For detailed instructions, see the [Analyze memory usage](../profiling/memory-usage.md) tutorial.  Currently, to measure memory usage for a .NET Core app, you need to use the tool with the debugger attached. For other managed and native apps, you can use the tool either with or without the debugger attached.

You can use the profiling tools without the debugger with Windows 7 and later. Windows 8 and later is required to run profiling tools with the debugger (**Diagnostic Tools** window).
  
## Blogs and videos  

| | |
|---------|---------|
| ![movie camera icon for video](../install/media/video-icon.png "Watch a video") | [Watch a video](https://mva.microsoft.com/en-US/training-courses-embed/getting-started-with-visual-studio-2017-17798/Profiling-with-Diagnostics-Tools-in-Visual-Studio-2017-daHnzMD6D_9211787171) on using the diagnostics tools that shows how to analyze memory usage and CPU usage in Visual Studio 2017. |

 [Analyze CPU and memory while debugging](https://blogs.msdn.microsoft.com/visualstudio/2016/02/15/analyze-cpu-memory-while-debugging/)  
  
 [Visual C++ blog: Memory profiling in Visual C++ 2015](https://blogs.msdn.microsoft.com/vcblog/2015/10/21/memory-profiling-in-visual-c-2015/)  

## See also
 [Profiling in Visual Studio](../profiling/index.md)  
 [First look at profiling tools](../profiling/profiling-feature-tour.md)