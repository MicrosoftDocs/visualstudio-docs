---
title: "TASK_STATE_RAN_TO_COMPLETION Field | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "TASK_STATE_RAN_TO_COMPLETION field, Task class [.NET Framework debug engines]"
ms.assetid: 0f4830af-fe0c-4141-b768-817f4e426b8c
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# TASK_STATE_RAN_TO_COMPLETION Field
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The task completed execution successfully.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field static assembly literal int32 TASK_STATE_RAN_TO_COMPLETION = int32(0x02000000)  
```  
  
## Remarks  
 If the [m_stateFlags](../../extensibility/debugger/m-stateflags-field.md) field contains this value, the <xref:System.Threading.Tasks.Task.Status%2A> property returns <xref:System.Threading.Tasks.TaskStatus?displayProperty=fullName>.  
  
## See Also  
 [Task Class](../../extensibility/debugger/task-class-internal-members.md)
