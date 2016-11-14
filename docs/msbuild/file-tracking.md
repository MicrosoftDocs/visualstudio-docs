---
title: "File Tracking | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "msbuild, file tracking"
ms.assetid: e6c66ac0-3464-451f-9192-3b98dca21b4a
caps.latest.revision: 6
author: "kempb"
ms.author: "kempb"
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
# File Tracking
File tracking logs calls to the Windows file system for a process and its child processes. By calling the functions listed below, programs control when to turn this logging on and off and specify the log file to use.  
  
## In This Section  
 [EndTrackingContext](../msbuild/endtrackingcontext.md)  
 Stop tracking the current context.  
  
 [ResumeTracking](../msbuild/resumetracking.md)  
 Resume tracking after a call to [SuspendTracking](../msbuild/suspendtracking.md).  
  
 [SetThreadCount](../msbuild/setthreadcount.md)  
 Set the number of threads to use for tracking.  
  
 [StartTrackingContext](../msbuild/starttrackingcontext.md)  
 Begin a new tracking context.  
  
 [StartTrackingContextWithRoot](../msbuild/starttrackingcontextwithroot.md)  
 Begin a new tracking context with a specified root.  
  
 [StopTrackingAndCleanup](../msbuild/stoptrackingandcleanup.md)  
 End tracking and release resources used.  
  
 [SuspendTracking](../msbuild/suspendtracking.md)  
 Temporarily suspend tracking.  
  
 [WriteAllTLogs](../msbuild/writealltlogs.md)  
 Write out the tracking logs for all contexts.  
  
 [WriteContextTLogs](../msbuild/writecontexttlogs.md)  
 Write out the tracking log for the current context.