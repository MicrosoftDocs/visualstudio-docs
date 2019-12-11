---
title: Reliability Warnings
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "vs.codeanalysis.reliabilityrules"
helpviewer_keywords:
  - "warnings, reliability"
  - "reliability warnings"
  - "managed code analysis warnings, reliability warnings"
ms.assetid: 77886846-10a2-4585-968a-7eb60ebe07e8
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
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
