---
title: "TaskScheduler Class - Internal Members | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "TaskScheduler class [.NET Framework debug engines]"
  - "debug engines, TaskScheduler class [.NET Framework]"
ms.assetid: 87f1c969-0217-4464-8907-7609c1bf61d3
caps.latest.revision: 10
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# TaskScheduler Class - Internal Members
This topic describes the internal members of the <xref:System.Threading.Tasks.TaskScheduler?displayProperty=fullName> class that help you implement a custom debugger. For general information about this class, see the <xref:System.Threading.Tasks.TaskScheduler> reference topic.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.class public abstract auto ansi beforefieldinit System.Threading.Tasks.TaskScheduler  
       extends System.Object  
```  
  
## Members  
  
### Methods  
  
|Name|Description|  
|----------|-----------------|  
|[GetScheduledTasksForDebugger](../../extensibility/debugger/getscheduledtasksfordebugger-method.md)|Retrieves an array of all scheduled tasks.|  
|[GetTaskSchedulersForDebugger](../../extensibility/debugger/gettaskschedulersfordebugger-method.md)|Retrieves an array of all <xref:System.Threading.Tasks.TaskScheduler> objects that are currently active.|  
  
## Remarks  
  
## See Also  
 <xref:System.Threading.Tasks.TaskScheduler?displayProperty=fullName>   
 [Parallel Extension Internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)