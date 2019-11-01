---
title: "AsyncVoidMethodBuilder.m_objectIdForDebugger Field | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "m_objectIdForDebugger field, AsyncVoidMethodBuilder structure [.NET Framework debug engines]"
ms.assetid: 81331a7b-6bec-46e4-a53e-515d0fad2400
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# AsyncVoidMethodBuilder.m_objectIdForDebugger field
Represents the lazily initialized object used by the debugger to uniquely identify this builder.

 **Namespace:** <xref:System.Runtime.CompilerServices?displayProperty=fullName>

 **Assembly:** mscorlib (in mscorlib.dll)

 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.field private object m_objectIdForDebugger
```

## See also
- <xref:System.Runtime.CompilerServices.AsyncVoidMethodBuilder>
- [Parallel extension internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)