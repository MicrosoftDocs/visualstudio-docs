---
title: Reliability Warnings
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- vs.codeanalysis.reliabilityrules
helpviewer_keywords:
- warnings, reliability
- reliability warnings
- managed code analysis warnings, reliability warnings
ms.assetid: 77886846-10a2-4585-968a-7eb60ebe07e8
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
- multiple
---
# Reliability warnings

Reliability warnings support library and application reliability, such as correct memory and thread usage. The reliability rules include:

|Rule|Description|
|----------|-----------------|
|[CA2000: Dispose objects before losing scope](../code-quality/ca2000.md)|Because an exceptional event might occur that will prevent the finalizer of an object from running, the object should be explicitly disposed before all references to it are out of scope.|
|[CA2001: Avoid calling problematic methods](../code-quality/ca2001.md)|A member calls a potentially dangerous or problematic method.|
|[CA2002: Do not lock on objects with weak identity](../code-quality/ca2002.md)|An object is said to have a weak identity when it can be directly accessed across application domain boundaries. A thread that tries to acquire a lock on an object that has a weak identity can be blocked by a second thread in a different application domain that has a lock on the same object.|
|[CA2003: Do not treat fibers as threads](../code-quality/ca2003.md)|A managed thread is being treated as a Win32 thread.|
|[CA2004: Remove calls to GC.KeepAlive](../code-quality/ca2004.md)|If you are converting to SafeHandle usage, remove all calls to GC.KeepAlive (object). In this case, classes should not have to call GC.KeepAlive, assuming they do not have a finalizer but rely on SafeHandle to finalize the OS handle for them.|
|[CA2006: Use SafeHandle to encapsulate native resources](../code-quality/ca2006.md)|Use of IntPtr in managed code might indicate a potential security and reliability problem. All uses of IntPtr must be reviewed to determine whether use of a SafeHandle, or similar technology, is required in its place.|
|[CA2007: Do not directly await a Task](../code-quality/ca2007.md)|An asynchronous method [awaits](/dotnet/csharp/language-reference/keywords/await) a <xref:System.Threading.Tasks.Task> directly.|
|[CA2009: Do not call ToImmutableCollection on an ImmutableCollection value](../code-quality/ca2009.md)|`ToImmutable` method was unnecessarily called on an immutable collection from <xref:System.Collections.Immutable> namespace.|
|[CA2011: Do not assign property within its setter](../code-quality/ca2011.md) | A property was accidentally assigned a value within its own [set accessor](/dotnet/csharp/programming-guide/classes-and-structs/using-properties#the-set-accessor). |
|[CA2012: Use ValueTasks correctly](../code-quality/ca2012.md) | ValueTasks returned from member invocations are intended to be directly awaited.  Attempts to consume a ValueTask multiple times or to directly access one's result before it's known to be completed may result in an exception or corruption.  Ignoring such a ValueTask is likely an indication of a functional bug and may degrade performance. |
|[CA2013: Do not use ReferenceEquals with value types](../code-quality/ca2013.md) | When comparing values using <xref:System.Object.ReferenceEquals%2A?displayProperty=fullName>, if objA and objB are value types, they are boxed before they are passed to the <xref:System.Object.ReferenceEquals%2A> method. This means that even if both objA and objB represent the same instance of a value type, the <xref:System.Object.ReferenceEquals%2A> method nevertheless returns false. |
|[CA2014: Do not use stackalloc in loops.](../code-quality/ca2014.md) | Stack space allocated by a stackalloc is only released at the end of the current method's invocation.  Using it in a loop can result in unbounded stack growth and eventual stack overflow conditions. |
|[CA2015: Do not define finalizers for types derived from MemoryManager&lt;T&gt;](../code-quality/ca2015.md) | Adding a finalizer to a type derived from <xref:System.Buffers.MemoryManager%601> may permit memory to be freed while it is still in use by a <xref:System.Span%601>. |
|[CA2016: Forward the CancellationToken parameter to methods that take one](ca2016.md) | Forward the `CancellationToken` parameter to methods that take one to ensure the operation cancellation notifications gets properly propagated, or pass in `CancellationToken.None` explicitly to indicate intentionally not propagating the token. |
