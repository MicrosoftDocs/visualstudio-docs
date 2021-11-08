---
title: "Performance Session Overview | Microsoft Docs"
description: Learn how to use Performance Tools to become productive quickly and increase the performance of yout code.
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Profiling Tools, performance session"
  - "performance sessions"
ms.assetid: 35752f95-a57a-4def-b64d-cf4899669e99
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Performance session overview
This overview explains the basics of profiling. Developers who are new to performance work will see how the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools can help them become productive quickly and increase the performance of their code. Developers who are experienced in profiling can gain an overview of specific Profiling Tools features and processes.

 The [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools help you identify performance issues in source code and compare the performance of possible solutions. Profiling Tools wizards and default settings can give you immediate insight into many performance issues. The features and options of the Profiling Tools provide exact control over the profiling process. This control includes the precise targeting of code sections, the collection of block-level timing information, and the inclusion of additional processor and system performance data in your data.

 The following steps make up the basic process of using the Profiling Tools:

1. Configure the performance session by specifying the collection method and the data that you want to collect.

2. Collect profiling data by running the application in the performance session.

3. Analyze the data to identify the performance issue.

4. Modify code in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE) to increases the application performance of the code

5. Collect profiling data on the changed code, and compare the profiling data of the original and changed data.

6. Generate a report that documents the increase in performance.

   To work with the information that is provided by profiling, you should have symbol information available for the binaries that you want to profile and for the binaries of the Windows operating system.

## Configure the performance session
 To configure a profiling session, select the profiling method that you want to use and the data that you want to collect. The Profiling Tools **Performance Wizard** can guide you through the basic configuration, and you can use the Performance Session property pages to add more options:

- Profiling methods include sampling, tracing, and memory allocation.

- Data values include time, processor and operating system performance counters, and application events such as page faults and kernel transitions.

  You can configure a performance session in a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] project as part of the project solution, or profile arbitrary binaries through the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE. You can specify session properties in the Performance Session property pages or you can use the Profiling Wizard.

## Collect profiling data
 You start the collection of profiling data from **Performance Explorer**. You can pause and resume profiling to limit the amount of data that you collect. You can also attach to a process that is already running.

 As soon as the application starts, the **Data Collection Control** window appears in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE. From the **Data Collection Control** window, you can profile specific parts of your application by pausing and resuming the collection process. You can also use the **Data Collection Control** window to insert marks into the data that is collected. Marks are user-defined data points that are displayed in profile views and that can be used to filter the profiling data.

 When the target application shuts down, the Profiling Tools generates a profiling data file (*.vsp) and displays the Summary Report view in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE.

## Analyze the data and identify performance issues
 When you end a profiling run, the data is analyzed and a summary is displayed in the Profiling Tools **Performance Report** view windows. Profiling data is collected for the call stack and individual functions of the target application. Report views display performance analysis for data ranges of the processes, threads, modules, functions, and source code lines of the application. Profiling data values for a function include the following:

- The overall time that was spent in the function and in child functions that were called by the function (inclusive values).

- The time that was spent executing only the code in the function (exclusive values).

  Over twelve different views enable you to analyze the profiling data in the most efficient way. View customizations enable you to filter and sort the data to find the functions that might be causing performance issues. Hot Path filtering provides immediate highlighting of the most active paths in Call Tree and Module views.

## Modify the application code
 After you have isolated one or more relevant performance issues, you can modify code by using the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE, and then collect profiling data for your changes.

## Collect profiling data again and compare the data between the profiling runs
 The Profiling Tools Comparison Report View displays the difference in module, function, or line performance between two selected profiling data files. You can specify the profiling data values that you want to compare, and you can switch between the Comparison View and views of the individual files.

## Generate a report of the results
 You can paste rows of any performance report view into e-mails and spreadsheets, and you can generate reports that contain the data for one or more views.

## See also
- [Overviews](../profiling/overviews-performance-tools.md)
- [Walkthrough: Identify performance problems](beginners-guide-to-cpu-sampling.md)
