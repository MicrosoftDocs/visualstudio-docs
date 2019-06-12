---
title: "m_stateObject Field | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "m_stateObject field, Task class [.NET Framework debug engines]"
ms.assetid: 68c54b22-3e1c-4031-b9c7-b972c519d8a0
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# m_stateObject Field
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

An object that represents data that the action will use.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field assembly object m_stateObject  
```  
  
## Remarks  
 This is the `state` parameter in the <xref:System.Threading.Tasks.Task.%23ctor%2A> constructor. It is also the backing field for the <xref:System.Threading.Tasks.Task.AsyncState%2A?displayProperty=fullName> property.  
  
## See Also  
 [Task Class](../../extensibility/debugger/task-class-internal-members.md)
