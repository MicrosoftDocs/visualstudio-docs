---
title: "m_stateFlags Field"
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
  - "m_stateFlags field, Task class [.NET Framework debug engines]"
ms.assetid: 82b20efc-08f2-4cd2-91f6-4e01e3da906b
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# m_stateFlags Field
Stores information about the current state of the \<xref:System.Threading.Tasks.Task> object.  
  
 **Namespace:** \<xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field assembly int32 modreq(System.Runtime.CompilerServices.IsVolatile) m_stateFlags  
```  
  
## Remarks  
 You typically use the \<xref:System.Threading.Tasks.Task.Status*?displayProperty=fullName> property to access this value.  
  
 This member can be any combination of the following values:  
  
-   [TASK_STATE_EXECUTED](../extensibility/task_state_executed-field.md)  
  
-   [TASK_STATE_FAULTED](../extensibility/task_state_faulted-field.md)  
  
-   [TASK_STATE_CANCELED](../extensibility/task_state_canceled-field.md)  
  
-   [TASK_STATE_WAITING_ON_CHILDREN](../extensibility/task_state_waiting_on_children-field.md)  
  
-   [TASK_STATE_RAN_TO_COMPLETION](../extensibility/task_state_ran_to_completion-field.md)  
  
## See Also  
 [Task Class](../extensibility/task-class---internal-members.md)