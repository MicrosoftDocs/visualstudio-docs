---
title: "AsyncTaskMethodBuilder Structure - Internal Members | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debug engines, AsyncTaskMethodBuilder structure [.NET Framework]"
  - "AsyncTaskMethodBuilder structure [.NET Framework debug engines]"
ms.assetid: f32f5857-7ef8-45fd-8b5a-7f644eb98b11
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# AsyncTaskMethodBuilder structure - internal members
This topic describes the internal members of the <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder> class. For general information about this class, see the <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder> reference topic.

 **Namespace:** <xref:System.Runtime.CompilerServices?displayProperty=fullName>

 **Assembly:** mscorlib (in mscorlib.dll)

 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.class public sequential ansi sealed beforefieldinit System.Runtime.CompilerServices.AsyncTaskMethodBuilder
       extends System.ValueType
       implements System.Runtime.CompilerServices.IAsyncMethodBuilder
```

## Internal members

|Name|Description|
|----------|-----------------|
|[ObjectIdForDebugger property](../../extensibility/debugger/asynctaskmethodbuilder-objectidfordebugger-property.md)|Gets an object that may be used to uniquely identify this builder to the debugger.|
|[m_builder field](../../extensibility/debugger/asynctaskmethodbuilder-m-builder-field.md)|Represents the generic builder object to which this non-generic instance delegates.|

## See also
- <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder>
- [Parallel extension internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)