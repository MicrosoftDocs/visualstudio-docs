---
title: "TaskScheduler Class - Internal Members | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "TaskScheduler class [.NET Framework debug engines]"
  - "debug engines, TaskScheduler class [.NET Framework]"
ms.assetid: 87f1c969-0217-4464-8907-7609c1bf61d3
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# TaskScheduler Class - Internal Members
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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
