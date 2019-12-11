---
title: "AsyncTaskMethodBuilder.m_builder Field | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "m_builder field, AsyncTaskMethodBuilder structure [.NET Framework debug engines]"
ms.assetid: bfaf25a2-0f08-413f-b474-9ce0d97c0eeb
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# AsyncTaskMethodBuilder.m_builder field
Represents the generic builder object to which this non-generic instance delegates.

 **Namespace:** <xref:System.Runtime.CompilerServices?displayProperty=fullName>

 **Assembly:** mscorlib (in mscorlib.dll)

 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.field private valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<valuetype System.Threading.Tasks.VoidTaskResult> m_builder
```

## Remarks

## See also
- <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder>
- [Parallel extension internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)