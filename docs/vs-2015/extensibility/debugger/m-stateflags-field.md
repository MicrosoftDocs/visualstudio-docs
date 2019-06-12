---
title: "m_stateFlags Field | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "m_stateFlags field, Task class [.NET Framework debug engines]"
ms.assetid: 82b20efc-08f2-4cd2-91f6-4e01e3da906b
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# m_stateFlags Field
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Stores information about the current state of the <xref:System.Threading.Tasks.Task> object.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field assembly int32 modreq(System.Runtime.CompilerServices.IsVolatile) m_stateFlags  
```  
  
## Remarks  
 You typically use the <xref:System.Threading.Tasks.Task.Status%2A?displayProperty=fullName> property to access this value.  
  
 This member can be any combination of the following values:  
  
- [TASK_STATE_EXECUTED](../../extensibility/debugger/task-state-executed-field.md)  
  
- [TASK_STATE_FAULTED](../../extensibility/debugger/task-state-faulted-field.md)  
  
- [TASK_STATE_CANCELED](../../extensibility/debugger/task-state-canceled-field.md)  
  
- [TASK_STATE_WAITING_ON_CHILDREN](../../extensibility/debugger/task-state-waiting-on-children-field.md)  
  
- [TASK_STATE_RAN_TO_COMPLETION](../../extensibility/debugger/task-state-ran-to-completion-field.md)  
  
## See Also  
 [Task Class](../../extensibility/debugger/task-class-internal-members.md)
