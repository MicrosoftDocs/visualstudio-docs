---
title: "m_parent Field | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "m_parent field, Task class [.NET Framework debug engines]"
ms.assetid: da9e3dc7-8e9b-4c3a-a9e0-12921b5300c6
caps.latest.revision: 9
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# m_parent Field
The backing field for the <xref:System.Threading.Tasks.Task?displayProperty=fullName> `Parent` property.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field private initonly class System.Threading.Tasks.Task m_parent  
```  
  
## Remarks  
  
## See Also  
 [Task Class](../../extensibility/debugger/task-class-internal-members.md)