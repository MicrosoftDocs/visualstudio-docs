---
title: "AsyncTaskMethodBuilder&lt;TResult&gt;.m_task Field | Microsoft Docs"
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
  - "m_task field, AsyncTaskMethodBuilder<TResult> structure [.NET Framework debug engines]"
ms.assetid: 649abf0e-0fec-49d9-93b2-8953521f7ba5
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
# AsyncTaskMethodBuilder&lt;TResult&gt;.m_task Field
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