---
title: DA0038 - High Rate of Lock contentions | Microsoft Docs
description: "System performance data that is collected with the profiling data indicates that a significantly high rate of lock contentions occurred during application execution."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.38
  - vs.performance.rules.DA0038
  - vs.performance.DA0038
ms.assetid: ae0c8b2f-17b2-4f3d-a834-aa2f6371753b
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0038: High rate of lock contentions

|Item|Value|
|-|-|
|Rule Id|DA0038|
|Category|.NET Framework Usage|
|Profiling method|Sampling<br /><br /> Instrumentation<br /><br /> .NET Memory|
|Message|A high rate of .NET Lock contentions is occurring. Please investigate the reason for this lock contention by running a Concurrency profile.|
|Rule type|Information|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 25 samples to trigger this rule.

## Cause
 System performance data that is collected with the profiling data indicates that a significantly high rate of lock contentions occurred during application execution. Consider profiling again using the concurrency profiling method to find the cause of the contentions.

## Rule description
 Locks are used to protect critical sections of code that must be executed serially by one thread at a time in a multi-threaded application. The Microsoft .NET Common Language Run-time (CLR) provides a full set of synchronization and locking primitives. For example, the C# language supports a lock statement (SyncLock in Visual Basic). A managed application can call the Monitor.Enter and Monitor.Exit methods in the System.Threading namespace to acquire and release a lock directly. The .NET Framework supports additional synchronization and locking primitives, including classes that support Mutexes, ReaderWriterLocks, and Semaphores. For more information, see [Overview of Synchronization Primitives](/dotnet/standard/threading/overview-of-synchronization-primitives) in the .NET Framework Developer's Guide on the MSDN Web site. The .NET Framework classes are themselves layered over lower level synchronization services built into the Windows operating system. These include critical section objects and many different Wait and event signaling functions. For more information, see the [Synchronization](/windows/win32/sync/synchronization) section of Win32 and COM Development in the MSDN Library

 Underlying both the .NET Framework classes and native Windows objects that are used for synchronization and locking are shared memory locations that must be changed using interlocked operations. Interlocked operations use hardware-specific instructions that operate on shared memory locations to change their state using atomic operations. Atomic operations are guaranteed to be consistent across all processors in the machine. Locks and WaitHandles are .NET objects that automatically use interlocked operations when they are set or reset. There may be other shared memory data structures in your application that also requires you to use interlocked operations in order to be updated in a thread-safe manner. For more information, see [Interlocked Operations](/dotnet/api/system.threading.interlocked) in the .NET Framework section of the MSDN Library.

 Synchronization and locking are mechanisms used to ensure that multi-threading applications execute correctly. Each thread of a multi-threaded application is an independent execution unit that is scheduled independently by the operating system. A lock contention occurs whenever a thread that is trying to acquire a lock is delayed because another thread is holding the lock.

 Locks are frequently nested. Nesting occurs when a thread executing a critical section performs a function that then requires another lock. Some amount of lock nesting is unavoidable. Your critical section may call a .NET Framework method that relies on locks to ensure it is thread-safe. A call from some critical section in your application into a Framework method that also locks using a different lock handle causes locks to nest. Nested locking conditions can lead to performance problems that are notoriously difficult to unravel and fix.

 This rule fires when measurements taken during a profiling run indicate there is an excessively high amount of lock contention. Lock contentions delay the execution of threads that are waiting for the lock. Even fairly small amounts of lock contention in unit tests or in load tests running on lower end hardware should be investigated.

> [!NOTE]
> When the rate of reported lock contentions in the profiling data is excessively high, the [DA0039: Very High Rate of Lock contentions](../profiling/da0039-very-high-rate-of-lock-contentions.md) warning message is fired instead of this information message.

## How to investigate a warning
 Double-click the message to navigate to the [Marks](../profiling/marks-view.md) view of the profiling data.  Find the **.NET CLR LocksAndThreads\Contention Rate / sec** column. Determine if there are specific phases of program execution where lock contention is heavier than other phases.

 This rule fires only when you are not using the concurrency profiling method. The concurrency profiling method is the best tool to use to diagnose performance problems related to lock contention in your application. Collect concurrency profiling data to understand the locking behavior of your application. This includes understanding which locks are heavily contended, how long thread execution time is delayed waiting for contended locks, and what specific code is implicated. Concurrency profiles collects data on all lock contentions, including the locking behavior of native Windows facilities, .NET Framework classes, and any other third-party libraries your application references. For information about concurrency profiling from the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE, see [Collect thread and process concurrency data](../profiling/collecting-thread-and-process-concurrency-data.md). For links to information about concurrency profiling from the command line, see the **Use the concurrency method to collect resource contention and thread activity data** section of [Use profiling methods from the command line](../profiling/using-profiling-methods-to-collect-performance-data-from-the-command-line.md).
