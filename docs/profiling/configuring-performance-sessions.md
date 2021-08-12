---
title: "Configuring Performance Sessions | Microsoft Docs"
description: Learn how to configure the Visual Studio Profiling Tools to collect the performance data you want. This article lists the common tasks and provides links.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "common tasks, performance"
  - "common tasks, profiling tools"
  - "profiling tools, common tasks"
  - "performance, gathering data"
ms.assetid: e1c3ba41-ffca-4edf-9a7f-8a5a9244ef9b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Configure performance sessions
By using [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools, you can collect a wide variety of performance data for a large number of application types. This section shows you how to use the Performance Wizard and properties of the performance session and target binary to configure Profiling Tools to collect the data that interests you. Profiling Tools configuration properties can also be used to control how much data is collected in a profiling run. For more information, see [Control data collection](../profiling/controlling-data-collection.md).

> [!NOTE]
> In many cases, using the default properties of the Performance Wizard is an effective way of collecting profiling data. For more information, see [Beginners guide to performance profiling](../profiling/beginners-guide-to-performance-profiling.md) and [Getting started](../profiling/getting-started-with-performance-tools.md).

## Common tasks

| Task | Related Content |
| - | - |
| **Set the basic profiling options:** You should configure [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] to use the Microsoft symbol server. This will make sure that you have access to symbols, such as function and parameter names, for the current version of Windows and other Microsoft applications. You can also specify other general options before a profiling session starts, such as system permissions to the profiling tools and the names of profiling data files. | -   [How to: Reference Windows symbol information](../profiling/how-to-reference-windows-symbol-information.md)<br />-   [How to: Serialize symbol information](../profiling/how-to-serialize-symbol-information.md)<br />-   [How to: Set the current session](../profiling/how-to-set-the-current-session.md)<br />-   [How to: Set permissions](../profiling/how-to-set-permissions.md)<br />-   [How to: Set performance data file name options](../profiling/how-to-set-performance-data-file-name-options.md) |
| **Specify the data that you want to collect:** The procedures that you use to configure a profiling session depend on the type of target application that you want to profile and the type of performance data that you want to collect. | -   [How to: Choose collection methods](../profiling/how-to-choose-collection-methods.md)<br />-   [Collect performance statistics by using sampling](../profiling/collecting-performance-statistics-by-using-sampling.md)<br />-   [Collect .NET memory allocation and lifetime data](../profiling/collecting-dotnet-memory-allocation-and-lifetime-data.md)<br />-   [Collect detailed timing data by using instrumentation](../profiling/collecting-detailed-timing-data-by-using-instrumentation.md)<br />-   [How to: Profile JavaScript code in web pages](../profiling/how-to-profile-javascript-code-in-web-pages.md)<br />-   [Collect thread and process concurrency data](../profiling/collecting-thread-and-process-concurrency-data.md)<br />-   [Collect additional performance data](../profiling/collecting-additional-performance-data.md) |
| **Set advanced configuration options:** When you profile .NET Framework applications that load multiple versions of the common language run-time (CLR), you can specify which version to profile. When you have multiple .exe files in a performance session, you can set the start order of the binaries. | -   [How to: Specify the .NET Framework runtime](../profiling/how-to-specify-the-dotnet-framework-runtime.md)<br />-   [How to: Specify the binary to start](../profiling/how-to-specify-the-binary-to-start.md) |

## Related sections
- [Control data collection](../profiling/controlling-data-collection.md)

## See also
- [Performance Explorer](../profiling/performance-explorer.md)
