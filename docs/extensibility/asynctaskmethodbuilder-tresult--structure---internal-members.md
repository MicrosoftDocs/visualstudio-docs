---
title: "AsyncTaskMethodBuilder&lt;TResult&gt; Structure - Internal Members"
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
  - "AsyncTaskMethodBuilder<TResult> structure [.NET Framework debug engines]"
  - "debug engines, AsyncTaskMethodBuilder<TResult> structure [.NET Framework]"
ms.assetid: 17ebc340-8170-4aff-bf54-dc4548c83632
caps.latest.revision: 4
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
# AsyncTaskMethodBuilder&lt;TResult&gt; Structure - Internal Members
This topic describes the internal members of the <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1> class. For general information about this class, see the <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1> reference topic.  
  
 **Namespace:** \<xref:System.Runtime.CompilerServices?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.class public sequential ansi sealed beforefieldinit System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>  
       extends System.ValueType  
       implements System.Runtime.CompilerServices.IAsyncMethodBuilder  
```  
  
## Internal Members  
  
|Name|Description|  
|----------|-----------------|  
|[ObjectIdForDebugger property](../extensibility/asynctaskmethodbuilder-tresult-.objectidfordebugger-property.md)|Gets an object that may be used to uniquely identify this builder to the debugger.|  
|[m_task field](../extensibility/asynctaskmethodbuilder-tresult-.m_task-field.md)|Represents the lazily initialized built task.|  
  
## See Also  
 \<xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1>   
 [Parallel Extension Internals for the .NET Framework](../extensibility/parallel-extension-internals-for-the-.net-framework.md)