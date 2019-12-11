---
title: "GetScheduledTasksForDebugger Method | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "GetScheduledTasksForDebugger method, TaskScheduler class [.NET Framework debug engines]"
ms.assetid: 7c9b4cde-6e4a-4cef-929f-7d02b1da5762
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# GetScheduledTasksForDebugger Method
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves an array of all scheduled tasks.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.method assembly hidebysig instance class System.Threading.Tasks.Task[] GetScheduledTasksForDebugger() cil managed  
```  
  
## Return Value  
 An array of all scheduled tasks. Each task is executing or has finished executing.  
  
## Remarks  
 This method is not thread safe and should not be used concurrently with other instances of <xref:System.Threading.Tasks.TaskScheduler> It should be called from a debugger only when the debugger has suspended all other threads.  
  
## See Also  
 [TaskScheduler Class](../../extensibility/debugger/taskscheduler-class-internal-members.md)
