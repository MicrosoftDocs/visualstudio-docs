---
title: "Visual Studio Profiler API Reference (Native) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "performance tools, API"
  - "Profiler, API"
ms.assetid: a0c3be92-c263-4678-9fb9-bafead3bd5f5
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
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
# Visual Studio Profiler API Reference (Native)
Visual Studio Profiler APIs allow you to programmatically control the amount of data collected, and insert both timestamp and profile marks during profiling. To use native APIs, you include VSPerf.h header file and add the VSPerf.lib in your project.  
  
> [!NOTE]
>  By default, VSPerf.h and VSPerf.lib are located in \<drive>:\Program Files\Microsoft Visual Studio 9\Team Tools\Performance Tools\PerfSDK directory.  
  
## In This Section  
 [CommentMarkAtProfile](../profiling/commentmarkatprofile.md)  
  
 [CommentMarkProfile](../profiling/commentmarkprofile.md)  
  
 [MarkProfile](../profiling/markprofile.md)  
  
 [NameProfile](../profiling/nameprofile.md)  
  
 [ResumeProfile](../profiling/resumeprofile.md)  
  
 [StartProfile](../profiling/startprofile.md)  
  
 [StopProfile](../profiling/stopprofile.md)  
  
 [SuspendProfile](../profiling/suspendprofile.md)  
  
 [PROFILE_CURRENTID](../profiling/profile-currentid.md)  
  
## See Also  
 [Profiling Tools APIs](../profiling/profiling-tools-apis.md)   
 [Walkthrough: Using Profiler APIs](../profiling/walkthrough-using-profiler-apis.md)