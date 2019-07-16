---
title: "m_action Field | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "m_action field, Task class [.NET Framework debug engines]"
ms.assetid: 201838c2-260d-4071-b6c3-f526874e19c9
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# m_action Field
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The delegate that represents the code to execute in the <xref:System.Threading.Tasks.Task> object.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field assembly object m_action  
```  
  
## Remarks  
 This is the `action` parameter in the <xref:System.Threading.Tasks.Task.%23ctor%2A> constructor.  
  
## See Also  
 [Task Class](../../extensibility/debugger/task-class-internal-members.md)
