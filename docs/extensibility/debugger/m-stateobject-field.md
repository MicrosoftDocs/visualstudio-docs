---
title: "m_stateObject Field | Microsoft Docs"
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
  - "m_stateObject field, Task class [.NET Framework debug engines]"
ms.assetid: 68c54b22-3e1c-4031-b9c7-b972c519d8a0
caps.latest.revision: 13
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
# m_stateObject Field
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