---
title: "m_children Field | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "m_children field, ContingentProperties class [.NET Framework debug engines]"
ms.assetid: 0a3b5653-7bc0-4a7a-8963-9020bc52b9cb
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# m_children Field
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The list of child tasks that are registered with this task.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field public class System.Collections.Generic.List`1<class System.Threading.Tasks.Task> m_children  
```  
  
## Remarks  
 While the task is running, only the thread that executes the task should access this array.  
  
 If the task is completed, other threads can access this field as long as they do not add anything to it or remove anything from it.  
  
## See Also  
 [ContingentProperties Class](../../extensibility/debugger/contingentproperties-class-internal-members.md)
