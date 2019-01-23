---
title: "NotifyDebuggerOfWaitCompletion Method | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "NotifyDebuggerOfWaitCompletion method, Task class [.NET Framework debug engines]"
ms.assetid: 841c5908-4f3f-400b-a7b0-96a95f362817
caps.latest.revision: 6
ms.author: gregvanl
manager: jillfra
---
# NotifyDebuggerOfWaitCompletion Method
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Placeholder method used as a breakpoint target by the debugger. This method must not be inlined or optimized.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
## Syntax  
  
```vb  
private void NotifyDebuggerOfWaitCompletion()  
```  
  
## Remarks  
 All join operations with a task should call this method if their debugger notification bit is set.  
  
## Requirements  
  
## See Also  
 [Task Class](../../extensibility/debugger/task-class-internal-members.md)
