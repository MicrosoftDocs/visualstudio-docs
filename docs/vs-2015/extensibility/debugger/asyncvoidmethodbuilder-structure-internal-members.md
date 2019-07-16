---
title: "AsyncVoidMethodBuilder Structure - Internal Members | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debug engines, AsyncVoidMethodBuilder structure [.NET Framework]"
  - "AsyncVoidMethodBuilder structure [.NET Framework debug engines]"
ms.assetid: fe2970ab-d4c5-4355-a8e4-772ee0a57178
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# AsyncVoidMethodBuilder Structure - Internal Members
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This topic describes the internal members of the <xref:System.Runtime.CompilerServices.AsyncVoidMethodBuilder> class. For general information about this class, see the <xref:System.Runtime.CompilerServices.AsyncVoidMethodBuilder> reference topic.  
  
 **Namespace:** <xref:System.Runtime.CompilerServices?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.class public sequential ansi sealed beforefieldinit System.Runtime.CompilerServices.AsyncVoidMethodBuilder  
       extends System.ValueType  
       implements System.Runtime.CompilerServices.IAsyncMethodBuilder  
```  
  
## Internal Members  
  
|Name|Description|  
|----------|-----------------|  
|[ObjectIdForDebugger property](../../extensibility/debugger/asyncvoidmethodbuilder-objectidfordebugger-property.md)|Gets an object that may be used to uniquely identify this builder to the debugger.|  
|[m_objectIdForDebugger field](../../extensibility/debugger/asyncvoidmethodbuilder-m-objectidfordebugger-field.md)|Represents the lazily initialized object used by the debugger to uniquely identify this builder.|  
  
## See Also  
 <xref:System.Runtime.CompilerServices.AsyncVoidMethodBuilder>   
 [Parallel Extension Internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)
