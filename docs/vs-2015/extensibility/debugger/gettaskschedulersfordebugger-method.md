---
title: "GetTaskSchedulersForDebugger Method | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "GetTaskSchedulersForDebugger method, TaskScheduler class [.NET Framework debug engines]"
ms.assetid: 58aa236a-5ab8-4695-b303-89dffdbcd946
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# GetTaskSchedulersForDebugger Method
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves an array of all <xref:System.Threading.Tasks.TaskScheduler> objects that are currently active.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.method assembly hidebysig static class System.Threading.Tasks.TaskScheduler[] GetTaskSchedulersForDebugger() cil managed  
```  
  
## Return Value  
 An array of all <xref:System.Threading.Tasks.TaskScheduler> objects that are currently active in this <xref:System.AppDomain>.  
  
## Remarks  
 This method is not thread safe and should not be used concurrently with other instances of <xref:System.Threading.Tasks.TaskScheduler>. It should be called from a debugger only when the debugger has suspended all other threads.  
  
## See Also  
 [TaskScheduler Class](../../extensibility/debugger/taskscheduler-class-internal-members.md)
