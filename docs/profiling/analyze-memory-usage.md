---
title: "Analyze Memory Usage in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/02/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Analyze Memory Usage
Use the debugger-integrated **Memory Usage** diagnostic tool to find memory leaks and inefficient memory usage. The Memory Usage tool lets you take one or more *snapshots* of the managed and native memory heap. You can collect snapshots of .NET, native, or mixed mode (.NET and native) apps.  
  
-   You can analyze a single snapshot to understand the relative impact of the object types on memory use, and to find code in your app that uses memory inefficiently.  
  
-   You can also compare (diff) two snapshots of an app to find areas in your code that cause the memory use to increase over time.  

For detailed instructions, see the [Analyze memory usage](../profiling/memory-usage.md) tutorial. To analyze memory usage without attaching the debugger, see [Memory usage without the debugger](memory-usage-without-debugging2.md).
  
## Blogs and videos  

|         |         |
|---------|---------|
|  ![movie camera icon for video](../install/media/video-icon.png "Watch a video")  |    [Watch a video](https://mva.microsoft.com/en-US/training-courses-embed/getting-started-with-visual-studio-2017-17798/Profiling-with-Diagnostics-Tools-in-Visual-Studio-2017-daHnzMD6D_9211787171) on using the diagnostics tools that shows how to analyze memory usage and CPU usage in Visual Studio 2017. |

 [Analyze CPU and Memory While Debugging](https://blogs.msdn.microsoft.com/visualstudio/2016/02/15/analyze-cpu-memory-while-debugging/)  
  
 [Visual C++ Blog: Memory Profiling in Visual C++ 2015](https://blogs.msdn.microsoft.com/vcblog/2015/10/21/memory-profiling-in-visual-c-2015/)  

## See Also
 [Profiling in Visual Studio](../profiling/index.md)  
 [Profiling Feature Tour](../profiling/profiling-feature-tour.md)