---
title: "AsyncTaskMethodBuilder Structure - Internal Members"
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
  - "debug engines, AsyncTaskMethodBuilder structure [.NET Framework]"
  - "AsyncTaskMethodBuilder structure [.NET Framework debug engines]"
ms.assetid: f32f5857-7ef8-45fd-8b5a-7f644eb98b11
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
# AsyncTaskMethodBuilder Structure - Internal Members
This topic describes the internal members of the \<xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder> class. For general information about this class, see the \<xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder> reference topic.  
  
 **Namespace:** \<xref:System.Runtime.CompilerServices?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.class public sequential ansi sealed beforefieldinit System.Runtime.CompilerServices.AsyncTaskMethodBuilder  
       extends System.ValueType  
       implements System.Runtime.CompilerServices.IAsyncMethodBuilder  
```  
  
## Internal Members  
  
|Name|Description|  
|----------|-----------------|  
|[ObjectIdForDebugger property](../extensibility/asynctaskmethodbuilder.objectidfordebugger-property.md)|Gets an object that may be used to uniquely identify this builder to the debugger.|  
|[m_builder field](../extensibility/asynctaskmethodbuilder.m_builder-field.md)|Represents the generic builder object to which this non-generic instance delegates.|  
  
## See Also  
 \<xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder>   
 [Parallel Extension Internals for the .NET Framework](../extensibility/parallel-extension-internals-for-the-.net-framework.md)