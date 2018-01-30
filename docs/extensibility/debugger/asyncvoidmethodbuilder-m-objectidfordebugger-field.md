---
title: "AsyncVoidMethodBuilder.m_objectIdForDebugger Field | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "m_objectIdForDebugger field, AsyncVoidMethodBuilder structure [.NET Framework debug engines]"
ms.assetid: 81331a7b-6bec-46e4-a53e-515d0fad2400
caps.latest.revision: 3
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# AsyncVoidMethodBuilder.m_objectIdForDebugger Field
Represents the lazily initialized object used by the debugger to uniquely identify this builder.  
  
 **Namespace:** <xref:System.Runtime.CompilerServices?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field private object m_objectIdForDebugger  
```  
  
## See Also  
 <xref:System.Runtime.CompilerServices.AsyncVoidMethodBuilder>   
 [Parallel Extension Internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)