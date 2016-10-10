---
title: "File Tracking"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e6c66ac0-3464-451f-9192-3b98dca21b4a
caps.latest.revision: 6
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# File Tracking
File tracking logs calls to the Windows file system for a process and its child processes. By calling the functions listed below, programs control when to turn this logging on and off and specify the log file to use.  
  
## In This Section  
 [EndTrackingContext](../VS_IDE/EndTrackingContext.md)  
 Stop tracking the current context.  
  
 [ResumeTracking](../VS_IDE/ResumeTracking.md)  
 Resume tracking after a call to [SuspendTracking](../VS_IDE/SuspendTracking.md).  
  
 [SetThreadCount](../VS_IDE/SetThreadCount.md)  
 Set the number of threads to use for tracking.  
  
 [StartTrackingContext](../VS_IDE/StartTrackingContext.md)  
 Begin a new tracking context.  
  
 [StartTrackingContextWithRoot](../VS_IDE/StartTrackingContextWithRoot.md)  
 Begin a new tracking context with a specified root.  
  
 [StopTrackingAndCleanup](../VS_IDE/StopTrackingAndCleanup.md)  
 End tracking and release resources used.  
  
 [SuspendTracking](../VS_IDE/SuspendTracking.md)  
 Temporarily suspend tracking.  
  
 [WriteAllTLogs](../VS_IDE/WriteAllTLogs.md)  
 Write out the tracking logs for all contexts.  
  
 [WriteContextTLogs](../VS_IDE/WriteContextTLogs.md)  
 Write out the tracking log for the current context.