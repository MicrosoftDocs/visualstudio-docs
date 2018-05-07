---
title: "TASK_STATE_FAULTED Field | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: 
  - "vs-ide-sdk"
ms.topic: "conceptual"
helpviewer_keywords: 
  - "TASK_STATE_FAULTED field, Task class [.NET Framework debug engines]"
ms.assetid: ced826ae-09a9-4acf-af00-a2343d396bb8
author: "gregvanl"
ms.author: "gregvanl"
manager: douge
ms.workload: 
  - "vssdk"
---
# TASK_STATE_FAULTED Field
The task completed due to an unhandled exception.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field static assembly literal int32 TASK_STATE_FAULTED = int32(0x00400000)  
```  
  
## Remarks  
 If the [m_stateFlags](../../extensibility/debugger/m-stateflags-field.md) field contains this value, the <xref:System.Threading.Tasks.Task.Status%2A> property returns <xref:System.Threading.Tasks.TaskStatus?displayProperty=fullName>.  
  
## See Also  
 [Task Class](../../extensibility/debugger/task-class-internal-members.md)