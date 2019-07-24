---
title: "AsyncVoidMethodBuilder Structure - Internal Members | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debug engines, AsyncVoidMethodBuilder structure [.NET Framework]"
  - "AsyncVoidMethodBuilder structure [.NET Framework debug engines]"
ms.assetid: fe2970ab-d4c5-4355-a8e4-772ee0a57178
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# AsyncVoidMethodBuilder structure - internal members
This topic describes the internal members of the <xref:System.Runtime.CompilerServices.AsyncVoidMethodBuilder> class. For general information about this class, see the <xref:System.Runtime.CompilerServices.AsyncVoidMethodBuilder> reference topic.

 **Namespace:** <xref:System.Runtime.CompilerServices?displayProperty=fullName>

 **Assembly:** mscorlib (in mscorlib.dll)

 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.class public sequential ansi sealed beforefieldinit System.Runtime.CompilerServices.AsyncVoidMethodBuilder
       extends System.ValueType
       implements System.Runtime.CompilerServices.IAsyncMethodBuilder
```

## Internal members

|Name|Description|
|----------|-----------------|
|[ObjectIdForDebugger property](../../extensibility/debugger/asyncvoidmethodbuilder-objectidfordebugger-property.md)|Gets an object that may be used to uniquely identify this builder to the debugger.|
|[m_objectIdForDebugger field](../../extensibility/debugger/asyncvoidmethodbuilder-m-objectidfordebugger-field.md)|Represents the lazily initialized object used by the debugger to uniquely identify this builder.|

## See also
- <xref:System.Runtime.CompilerServices.AsyncVoidMethodBuilder>
- [Parallel extension internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)