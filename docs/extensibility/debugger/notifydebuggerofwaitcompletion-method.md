---
title: "NotifyDebuggerOfWaitCompletion Method | Microsoft Docs"
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
  - "NotifyDebuggerOfWaitCompletion method, Task class [.NET Framework debug engines]"
ms.assetid: 841c5908-4f3f-400b-a7b0-96a95f362817
caps.latest.revision: 5
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
# NotifyDebuggerOfWaitCompletion Method
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