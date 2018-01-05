---
title: "Visual Studio Performance Tips and Tricks | Microsoft Docs"
ms.date: "08/31/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "debugger"
ms.assetid: 2fbcb59e-e981-4b40-8b7a-c1140d31ec4b
caps.latest.revision: 1
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Visual Studio Performance Tips and Tricks

Visual Studio performance recommendations are intended for low memory situations, which may occur in rare cases. In these situations, you can optimize certain Visual Studio features that you may not be using. The following tips are not intended as general recommendations.

> [!NOTE]
> If you’re having difficulty using the product because of memory issues, let us know through the feedback tool.

## Optimize your environment

- **Use a 64bit OS**

    If you upgrade your system from a 32-bit version of Windows to a 64-bit version, you expand the amount of virtual memory available to Visual Studio from 2 GB to 4 GB. This enables Visual Studio to handle significantly larger workloads even though it is 32-bit process.

    For more information, see [Memory limits](https://msdn.microsoft.com/en-us/library/windows/desktop/aa366778(v=vs.85).aspx#memory_limits) and [Using /LARGEADDRESSAWARE on 64-bit Windows](https://blogs.msdn.microsoft.com/oldnewthing/20050601-24/?p=35483/).

## Configure solution and projects

If you have a very large solution with many projects, you may benefit by making the following optimizations:

- **Unload Projects**

    You can manually unload rarely used individual projects from Solution Explorer using the right-click context menu.

- **Refactor the solution**

    You can split your solution into several smaller solution files with commonly used projects. This refactoring should significantly reduce memory usage for your workflow. Smaller solutions also load faster.

## Configure debugging options
If you are typically running low on memory during debugging sessions, you can optimize performance by making one or more configuration changes.

- **Enable Just My Code**

    The simplest optimization is to enable the **Just My Code** feature, which only loads symbols for your project. Enabling this feature can result in a significant memory saving for debugging managed applications (.NET). This option is already enabled by default in some project types.

    To enable **Just My Code**, choose **Tools > Options > Debugging > General**, and then select **Enable Just My Code**.

- **Specify symbols to load**

    For native debugging, loading symbol files (.pdb) is expensive in terms of memory resources. You can configure your debugger symbol settings to conserve memory. Typically, you configure the solution to only load modules from your project.

    To specify symbol loading, choose **Tools > Options > Debugging > Symbols**.

    Set the options to **Only specified modules** instead of **All modules** and then specify which modules you care to load. While debugging, you can also right-click specific modules in the **Modules** window to explicitly include a module in the symbol load. (To open the window while debugging, choose **Debug > Windows > Modules**.)

    For more information, see [Understanding symbol files](https://blogs.msdn.microsoft.com/visualstudioalm/2015/01/05/understanding-symbol-files-and-visual-studios-symbol-settings/).

- **Disable Diagnostic Tools**

    It is recommended that you disable CPU profiling after use. This feature can consume large amounts of resources. Once CPU profiling is enabled, this state is persisted across subsequent debug sessions, so it’s worth explicitly turning it off when done. You may save some resources by disabling the diagnostic tools while debugging if you do not need the provided features.

    To disable the Diagnostic Tools, start a debugging session, choose **Tools > Options > Enable Diagnostic Tools**, and deselect the option.

    For more information, see [Profiling Tools](../profiling/profiling-tools.md).

## Disable tools and extensions
Some tools or extensions may to turned off to improve performance.

> [!TIP]
> You can often isolate performance issues by turning off extensions one at a time and rechecking performance.

### Managed Language Services (Roslyn)

For information about Roslyn performance considerations, see [Performance considerations for large solutions] (https://github.com/dotnet/roslyn/wiki/Performance-considerations-for-large-solutions).

- **Disable Full Solution Analysis**

    Visual Studio performs analysis on your entire solution in order to provide a rich experience about errors before invoking a build. This feature is useful to identify errors as soon as possible. However, for very large solutions, this feature can consume significant memory resources. If you’re experiencing memory pressure or similar issues, you can disable this experience to free up these resources. By default, this option is enabled for Visual Basic and disabled for C#.

    To disable **Full Solution Analysis**, choose **Tools > Options > Text Editor > <Visual Basic or C#>**. Then choose **Advanced** and deselect **Enable full solution analysis**.

- **Disable CodeLens**

    Visual Studio performs a **Find All References** task on each method as it is displayed. CodeLens provides features such as the inline display of the number of references. The work is performed in a separate process (for example, ServiceHub.RoslynCodeAnalysisService32). In very large solutions or on resource constrained systems, this feature can have significant impact on performance even though it is run at a low priority. If you’re experiencing high CPU in this process, or memory issues (for example, when loading a large solution on a 4-GB machine), you can try disabling this feature to free up resources.

    To disable CodeLens, choose **Tools > Options > Text Editor > All Languages > CodeLens**, and deselect the feature.

    This feature is available in Visual Studio Professional and Visual Studio Enterprise.

### Other tools and extensions

- **Disable Extensions**

    Extensions are additional software components added to Visual Studio that provide new functionality or extend existing functionality. Extensions can often be a source of memory resource issues. If you’re experiencing memory resource problems, try disabling extensions one at a time to see how it impacts the scenario or workflow.

    To disable extensions, go to **Tools | Extensions and Updates**, and disable a particular extension.

- **Disable XAML Designer**

    The XAML designer is enabled by default, but only consumes resources if you open a .XAML file. If you work with XAML files but do not wish to use the designer functionality, disable this feature to free up some memory.

    To disable XAML Designer, go to **Tools > Options > XAML Designer > Enable XAML Designer**, and deselect the option.

- **Remove workloads**

    You can use the Visual Studio Installer to remove workloads that are no longer used. This action can streamline the startup and runtime cost by skipping packages and assemblies that aren’t needed anymore.

## Force a garbage collection

The CLR uses a garbage collection memory management system. In this system, sometimes memory is used by objects that are no longer needed. This state is temporary; the garbage collector will release this memory based on its performance and resource usage heuristics. You can force the CLR to collect any unused memory by using a hotkey in Visual Studio. If there is a significant amount of garbage waiting for collection and you force a garbage collection, you should see the memory usage of the devenv.exe process drop in Task Manager. It’s rarely necessary to use this method. However, after an expensive operation has completed (such as a full build, debug session, or a solution open event), it can help you determine how much memory is really being used by the process. Because Visual Studio is mixed (managed & native), it’s occasionally possible for the native allocator and the garbage collector to compete for limited memory resources. Under conditions of high memory usage, it may help to force the garbage collector to run.

To force a garbage collection, use the hotkey: **Ctrl+Alt+Shift+F12**, **Ctrl+Alt+Shift+F12** (press it twice).

If forcing garbage collection reliably makes your scenario work, file a report through the Visual Studio feedback tool as this behavior is likely to be a bug.

For a detailed description of the CLR garbage collector, see [Fundamental of Garbage Collection](https://msdn.microsoft.com/en-us/library/ee787088(v=vs.110).aspx).

## See Also  
 [Visual Studio IDE](../ide/index.md)
