---
title: "TASK_STATE_CANCELED Field | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "TASK_STATE_CANCELED field, Task class [.NET Framework debug engines]"
ms.assetid: f4f5a96a-8230-493d-9696-8d2716bda261
caps.latest.revision: 8
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
# TASK_STATE_CANCELED Field
The task was canceled before it reached the running state, or it acknowledged its cancellation and completed without exception.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field static assembly literal int32 TASK_STATE_CANCELED = int32(0x00800000)  
```  
  
## Remarks  
 If the [m_stateFlags](../../extensibility/debugger/m-stateflags-field.md) field contains this value, the <xref:System.Threading.Tasks.Task.Status%2A> property returns <xref:System.Threading.Tasks.TaskStatus?displayProperty=fullName>.  
  
## See Also  
 [Task Class](../../extensibility/debugger/task-class-internal-members.md)