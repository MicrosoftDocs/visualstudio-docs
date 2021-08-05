---
description: "This topic describes the internal members of the System.Runtime.CompilerServices.AsyncTaskMethodBuilder class."
title: AsyncTaskMethodBuilder&lt;TResult&gt; Structure - Internal Members | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- AsyncTaskMethodBuilder<TResult> structure [.NET Framework debug engines]
- debug engines, AsyncTaskMethodBuilder<TResult> structure [.NET Framework]
ms.assetid: 17ebc340-8170-4aff-bf54-dc4548c83632
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# AsyncTaskMethodBuilder&lt;TResult&gt; structure - internal members
This topic describes the internal members of the <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder%601> class. For general information about this class, see the <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder%601> reference topic.

 **Namespace:** <xref:System.Runtime.CompilerServices?displayProperty=fullName>

 **Assembly:** mscorlib (in mscorlib.dll)

 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.class public sequential ansi sealed beforefieldinit System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>
       extends System.ValueType
       implements System.Runtime.CompilerServices.IAsyncMethodBuilder
```

## Internal members

|Name|Description|
|----------|-----------------|
|[ObjectIdForDebugger property](../../extensibility/debugger/asynctaskmethodbuilder-tresult-objectidfordebugger-property.md)|Gets an object that may be used to uniquely identify this builder to the debugger.|
|[m_task field](../../extensibility/debugger/asynctaskmethodbuilder-tresult-m-task-field.md)|Represents the lazily initialized built task.|

## See also
- <xref:System.Runtime.CompilerServices.AsyncTaskMethodBuilder%601>
- [Parallel extension internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)
