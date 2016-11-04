---
title: "m_action Field | Microsoft Docs"
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
  - "m_action field, Task class [.NET Framework debug engines]"
ms.assetid: 201838c2-260d-4071-b6c3-f526874e19c9
caps.latest.revision: 9
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
# m_action Field
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