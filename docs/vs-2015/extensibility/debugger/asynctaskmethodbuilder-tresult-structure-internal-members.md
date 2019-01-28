---
title: "AsyncTaskMethodBuilder&lt;TResult&gt; Structure - Internal Members | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "AsyncTaskMethodBuilder<TResult> structure [.NET Framework debug engines]"
  - "debug engines, AsyncTaskMethodBuilder<TResult> structure [.NET Framework]"
ms.assetid: 17ebc340-8170-4aff-bf54-dc4548c83632
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# AsyncTaskMethodBuilder&lt;TResult&gt; Structure - Internal Members
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This topic describes the internal members of the <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder%601> class. For general information about this class, see the <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder%601> reference topic.  
  
 **Namespace:** <xref:System.Runtime.CompilerServices?displayProperty=fullName>  
  
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
|[ObjectIdForDebugger property](../../extensibility/debugger/asynctaskmethodbuilder-tresult-objectidfordebugger-property.md)|Gets an object that may be used to uniquely identify this builder to the debugger.|  
|[m_task field](../../extensibility/debugger/asynctaskmethodbuilder-tresult-m-task-field.md)|Represents the lazily initialized built task.|  
  
## See Also  
 <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder%601>   
 [Parallel Extension Internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)
