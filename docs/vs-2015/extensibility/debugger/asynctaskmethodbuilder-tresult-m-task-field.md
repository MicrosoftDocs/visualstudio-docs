---
title: "AsyncTaskMethodBuilder&lt;TResult&gt;.m_task Field | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "m_task field, AsyncTaskMethodBuilder<TResult> structure [.NET Framework debug engines]"
ms.assetid: 649abf0e-0fec-49d9-93b2-8953521f7ba5
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# AsyncTaskMethodBuilder&lt;TResult&gt;.m_task Field
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Represents the lazily initialized built task.  
  
 **Namespace:** <xref:System.Runtime.CompilerServices?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field private class System.Threading.Tasks.Task`1<!TResult> m_task  
```  
  
## See Also  
 <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder%601>   
 [Parallel Extension Internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)
