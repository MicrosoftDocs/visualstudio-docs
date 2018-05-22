---
title: "Visual Studio Profiler API Reference (Native) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
helpviewer_keywords: 
  - "performance tools, API"
  - "Profiler, API"
ms.assetid: a0c3be92-c263-4678-9fb9-bafead3bd5f5
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "cplusplus"
---
# Visual Studio profiler API reference (native)
Visual Studio Profiler APIs allow you to programmatically control the amount of data collected, and insert both timestamp and profile marks during profiling. To use native APIs, you include VSPerf.h header file and add the VSPerf.lib in your project.  
  
> [!NOTE]
>  By default, VSPerf.h and VSPerf.lib are located in a folder named PerfSDK. \<drive>:\Program Files\Microsoft Visual Studio 14.0\Team Tools\Performance Tools\PerfSDK directory, for example.  
  
## In this section  
 [CommentMarkAtProfile](../profiling/commentmarkatprofile.md)  
  
 [CommentMarkProfile](../profiling/commentmarkprofile.md)  
  
 [MarkProfile](../profiling/markprofile.md)  
  
 [NameProfile](../profiling/nameprofile.md)  
  
 [ResumeProfile](../profiling/resumeprofile.md)  
  
 [StartProfile](../profiling/startprofile.md)  
  
 [StopProfile](../profiling/stopprofile.md)  
  
 [SuspendProfile](../profiling/suspendprofile.md)  
  
 [PROFILE_CURRENTID](../profiling/profile-currentid.md)  
  
## See also  
 [Profiling tools APIs](../profiling/profiling-tools-apis.md)   
 [Walkthrough: Using profiler APIs](../profiling/walkthrough-using-profiler-apis.md)
