---
title: "File Tracking"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "msbuild, file tracking"
ms.assetid: e6c66ac0-3464-451f-9192-3b98dca21b4a
caps.latest.revision: 6
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
 [EndTrackingContext](../reference/endtrackingcontext.md)  
 Stop tracking the current context.  
  
 [ResumeTracking](../reference/resumetracking.md)  
 Resume tracking after a call to [SuspendTracking](../reference/suspendtracking.md).  
  
 [SetThreadCount](../reference/setthreadcount.md)  
 Set the number of threads to use for tracking.  
  
 [StartTrackingContext](../reference/starttrackingcontext.md)  
 Begin a new tracking context.  
  
 [StartTrackingContextWithRoot](../reference/starttrackingcontextwithroot.md)  
 Begin a new tracking context with a specified root.  
  
 [StopTrackingAndCleanup](../reference/stoptrackingandcleanup.md)  
 End tracking and release resources used.  
  
 [SuspendTracking](../reference/suspendtracking.md)  
 Temporarily suspend tracking.  
  
 [WriteAllTLogs](../reference/writealltlogs.md)  
 Write out the tracking logs for all contexts.  
  
 [WriteContextTLogs](../reference/writecontexttlogs.md)  
 Write out the tracking log for the current context.