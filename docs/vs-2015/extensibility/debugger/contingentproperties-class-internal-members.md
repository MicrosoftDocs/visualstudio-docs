---
title: "ContingentProperties Class - Internal Members | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "ContingentProperties class [.NET Framework debug engines]"
  - "debug engines, ContingentProperties class [.NET Framework]"
ms.assetid: c49d1362-ab1c-4b6d-9950-fcae40e0e66b
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# ContingentProperties Class - Internal Members
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Contains additional properties for a <xref:System.Threading.Tasks.Task> object.  
  
 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.class auto ansi nested assembly beforefieldinit ContingentProperties  
       extends System.Object  
```  
  
## Members  
  
### Fields  
  
|Name|Description|  
|----------|-----------------|  
|[m_children](../../extensibility/debugger/m-children-field.md)|The list of child tasks that are registered with this task.|  
  
## Remarks  
 The .NET Framework initializes the fields of this class only when they are needed.  
  
## See Also  
 [Parallel Extension Internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)
