---
title: "Performance Report Overview | Microsoft Docs"
description: View the profiling data in the Performance Report window of the Visual Studio Team System Development Edition integrated development environment.
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling tools, about performance rerports"
  - "performance, reports"
  - "performance reports, about performance reports"
ms.assetid: 7324c24c-fd09-479b-b2ad-e0c3b613e040
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Performance Report overview
You can view the profiling data of a performance session in the **Performance Report** window of the Visual Studio Team System Development Edition integrated development environment (IDE). The profiling data is saved in .vsp and .vsps files. Report view windows enable you to view and analyze application performance issues.

> [!CAUTION]
> A profiling data file contains sensitive information such as the computer name, the version of the operating system, file paths, memory information, and other computer setup information. You should maintain strict control over the distribution of the data, both in its native .*vsp* format and when it is exported to a .*csv* or an .*xml* file.
>
> If event tracing data is collected as part of the performance session, additional information might appear in the event tracing log (.*etl*) file. This information includes your domain and user name; therefore, you should maintain strict control over the distribution of the log file.

## Performance Report window
 The Performance Report window is a tool window that is used to view, manage, and filter performance data and it includes a customizable query control.

 On the main toolbar of the Performance Report window, you can access each view. Click the arrow next to the **Current View** list to display and select the individual views that are available.

 The Performance Report window provides the following data views:

### Summary View
 By default, profiling data is displayed in the Summary view. This view is a starting point in your investigation into performance issues. From each line in the Summary view, you can move to more detailed views by right-clicking the function or module name. For more information, see [Summary View](../profiling/summary-view.md).

### Caller/Callee View
 The Caller/Callee view displays a call tree for an individual function. The view is divided into three parts:

- The target function is displayed in the middle of the view.

- The functions that called the function (callers) are displayed above the target function.

- The functions that are called by the target function (callees) are displayed below the target.

  You can select a different function by double-clicking any function in the called list or the callee list. For more information, see [Caller/Callee View](../profiling/caller-callee-view.md).

### Call Tree View
 The Call Tree view displays the function execution paths that were traversed in the profiled application. The root of the tree is the entry point into the application or component. Each function node lists all the functions that it called and performance data about those function calls.

 The Call Tree view can also expand and highlight the execution path of a function that consumed the most time or was sampled most frequently. To display the most active path, right-click the function and then click **Expand Hot Path**. For more information, see [Call Tree View](../profiling/call-tree-view.md).

### Process View
 The Process view displays performance data for each process and thread that was profiled. For more information, see [Process View](../profiling/process-view.md).

### Modules View
 The Modules view lists the modules in the project and presents profiling data for each module. Expand or collapse the module name to display function profiling data. When the data was collected by using sampling, source code line and instruction pointer profiling data is also available. For more information, see [Modules View](../profiling/modules-view.md).

### Functions View
 The Functions view lists the functions that were called during profiling. For more information, see [Functions View](../profiling/functions-view.md).

### Line View
 The Lines view enables you to view the specific source code lines that were executed during sampling profiling. For more information, see [Lines View](../profiling/lines-view.md).

### Instruction Pointer (IP) View
 The Instruction Pointer view enables you to view the specific instructions that were executed during sampling profiling. For more information, see [Instruction Pointers (IPs) View](../profiling/instruction-pointers-ips-view.md).

### Allocation View
 The Allocation view is available if **Collect .NET object allocation** was selected on the **General** page of the **Performance Session** properties dialog box. See [Performance session overview](../profiling/performance-session-overview.md). The Allocation view lists the .NET objects that were allocated by the application or component. When an object row is expanded, a call tree is displayed. The call tree shows the execution paths that resulted in the creation of the object. Information is also displayed about the number of inclusive and exclusive allocations for each function in the call tree. The Allocation view can also expand and highlight the execution path of a function that allocated the largest number of objects. To display the most active path, right-click the function and then click **Expand Hot Path**. For more information, see [Collect .NET memory allocation and lifetime data](../profiling/collecting-dotnet-memory-allocation-and-lifetime-data.md) and [Allocations View](../profiling/dotnet-memory-allocations-view.md).

### Objects Lifetime View
 The Object Lifetime view is available if **Collect .NET object allocation information** and **Also collect .NET object lifetime information** were selected on the **General** page of the **Performance Session** properties dialog box.

 The Object Lifetime view displays the total number of instances of each type and the number of objects that were collected in each garbage collection generation. For more information, see [Object Lifetime View](../profiling/object-lifetime-view.md).

## Customizable filter control
 The customizable filter control has the following options:

- **Import Filter** - retrieves a previously saved custom query.

- **Export Filter** - saves the custom query to the specified location.

- **Execute Query** - runs the query as displayed in the custom query control.

- **Stop Query** - stops execution of a query that is running. This button is not available if no query is running.

- **Show Query** - shows/hides the custom query control.

- **Save Analyzed** - saves the report together with its current analysis as a .vsps file.

- **Export** - saves the current report in .CVS-formatted or .XML-formatted file, with options to save the different views.

## See also
- [Analyze performance tools data](../profiling/analyzing-performance-tools-data.md)
- [Performance report views](../profiling/performance-report-views.md)
