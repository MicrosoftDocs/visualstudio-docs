---
title: Tips to improve performance
description: Explore tips to improve and optimize certain Visual Studio features that you might not be using to help improve performance.
ms.date: 05/16/2025
ms.topic: conceptual
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Visual Studio performance tips and tricks

Visual Studio performance recommendations are intended for low memory situations, which may occur in rare cases. In these situations, you can optimize certain Visual Studio features that you may not be using. The following tips aren't intended as general recommendations.

> [!NOTE]
> If you’re having difficulty using the product because of memory issues, let us know through the [feedback tool](../ide/how-to-report-a-problem-with-visual-studio.md).

## Use a 64-bit OS

If you upgrade your system from a 32-bit version of Windows to a 64-bit version, you expand the amount of virtual memory available to Visual Studio from 2 GB to 4 GB. A 64-bit operating system upgrade enables Visual Studio to handle larger workloads.

For more information, see [Memory Limits for Windows and Windows Server releases](/windows/desktop/Memory/memory-limits-for-windows-releases).

> [!TIP]
> Visual Studio 2022 on Windows is a 64-bit application. Earlier versions are 32-bit.

## Disable automatic file restore

Visual Studio automatically reopens documents that were left open in the previous session. This automatic file restore action can prolong the times it takes to load a solution by up to 30% or more, depending on the project type and the documents being opened. Designers like Windows Forms and XAML, and some JavaScript and TypeScript files, can be slow to open.

Visual Studio notifies you in a yellow bar when automatic document restore is causing a solution to load slower. You can disable automatic file reopening by following these steps:

1. Select **Tools** > **Options** to open the **Options** dialog box.

1. On the **Projects and Solution** > **General** page, deselect **Reopen documents on solution load**.

If you disable automatic file restore, a quick way to navigate to files you want to open is by using one of the [Go To](../ide/go-to.md) commands:

- For the general **Go To** functionality, select **Edit** > **Go To** > **Go To All**, or press **Ctrl**+**T**.

- Jump to the last edit location in a solution using **Edit** > **Go To** > **Go To Last Edit Location**, or by pressing **Ctrl**+**Shift**+**Backspace**.

- Use **Go To Recent File** to see a list of recently visited files in a solution. Select **Edit** > **Go To** > **Go To Recent File**, or press **Ctrl**+**1**, **Ctrl**+**R**.

## Configure debugging options

If you're typically running low on memory during debugging sessions, you can optimize performance by making one or more configuration changes.

- **Enable Just My Code**

    The simplest optimization is to enable the **Just My Code** feature, which only loads symbols for your project. Enabling this feature can result in a significant memory saving for debugging managed applications (.NET). This option is already enabled by default in some project types.

    To enable **Just My Code**, choose **Tools** > **Options** > **Debugging** > **General**, and then select **Enable Just My Code**.

- **Specify symbols to load**

    For native debugging, loading symbol files (*.pdb*) is expensive in terms of memory resources. You can configure your debugger symbol settings to conserve memory. Typically, you configure the solution to only load modules from your project.

    To specify symbol loading, choose **Tools** > **Options** > **Debugging** > **Symbols**.

    Set the options to **Load only specified modules** instead of **Load all modules**, and then specify which modules you care to load. While debugging, you can also right-click specific modules in the **Modules** window to explicitly include a module in the symbol load. (To open the window while debugging, choose **Debug** > **Windows** > **Modules**.)

    For more information, see [Specify symbol and source files in the debugger](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).

- **Disable Diagnostic Tools**

    It's recommended that you disable CPU profiling after use. This feature can consume large amounts of resources. Once CPU profiling is enabled, this state is persisted across subsequent debug sessions, so it’s worth explicitly turning it off when done. You may save some resources by disabling the diagnostic tools while debugging if you don't need the provided features.

    To disable the **Diagnostic Tools**, start a debugging session, select **Tools** > **Options** > **Debugging** > **General**, and then deselect the **Enable Diagnostic Tools while debugging** option.

    For more information, see [Profiling tools](../profiling/profiling-feature-tour.md).

## Disable tools and extensions

Some tools or extensions can be turned off to improve performance.

> [!TIP]
> You can often isolate performance issues by turning off extensions one at a time and rechecking performance.

### Managed language service (Roslyn)

For information about .NET Compiler Platform ("Roslyn") performance considerations, see [Performance considerations for large solutions](https://github.com/dotnet/roslyn/blob/main/docs/wiki/Performance-considerations-for-large-solutions.md).

- **Disable CodeLens**

    Visual Studio performs a **Find All References** task on each method as it is displayed. CodeLens provides features such as the inline display of the number of references. The work is performed in a separate process such as *ServiceHub.RoslynCodeAnalysisService32*. In large solutions, or on resource-constrained systems, this feature can have a significant impact on performance. If you’re experiencing memory issues, for example, when loading a large solution on a 4-GB machine, or high CPU usage for this process, you can disable CodeLens to free up resources.

    To disable **CodeLens**, choose **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**, and deselect the feature.

    For more information, see [Find code changes and other history with CodeLens](find-code-changes-and-other-history-with-codelens.md).

### Other tools and extensions

- **Disable Extensions**

    Extensions are additional software components added to Visual Studio that provide new functionality or extend existing functionality. Extensions can often be a source of memory resource issues. If you’re experiencing memory resource problems, try disabling extensions one at a time to see how it impacts the scenario or workflow.

    To disable extensions, go to **Extensions** > **Manage Extensions**, and disable a particular extension.

- **Disable map mode**

    [**Map mode**](how-to-track-your-code-by-customizing-the-scrollbar.md#display-modes) displays lines of code, in miniature, on the scroll bar. Map mode is enabled by default.

    To disable map mode, go to **Tools** > **Options** > **Text Editor** > **All Languages** > **Scroll Bars**, and in the **Behavior** section, deselect the **Use map mode for vertical scroll bar** option.

- **Disable word wrap**

    [**Word wrap**](./reference/how-to-manage-word-wrap-in-the-editor.md) displays the portion of a long line of code that extends beyond the current width of the code editor window. Word wrap is on by default.

    To disable word wrap for a project that you're currently working on, go to **Edit** > **Advanced** > **Word Wrap**. (You can toggle this setting by using the same menu commands.)

    To disable word wrap for all projects, go to **Tools** > **Options** > **General** > **Text Editor** > **All Languages** > **General**, and in the **Settings** section, deselect the **Word wrap** option.

- **Disable XAML Designer**

    The XAML designer is enabled by default, but only consumes resources if you open a *.xaml* file. If you work with XAML files but don't wish to use the designer functionality, disable this feature to free up some memory.

    To disable XAML Designer, go to **Tools** > **Options** > **XAML Designer** > **Enable XAML Designer**, and deselect the option.

- **Remove workloads**

    You can use the Visual Studio Installer to remove workloads that are no longer used. This action can streamline the startup and runtime cost by skipping packages and assemblies that aren’t needed anymore.

- **Add untracked files to local .gitignore**

    Visual Studio runs the Git command `git status` with untracked files to provide a seamless experience when you add new files to a repository. When there are a large number of untracked files, `git status` can consume extra memory. To ignore these files and improve performance of `git status`, you can add these files or folders to your local .gitignore file. To access the file, go to **Git** > **Settings** > **Git Repository Settings**. Then, in the **Git files** section, select **Add** to create a .gitignore file, or select **Edit** if you already have one.

- **Enable commit graph in Git tooling**

    [New in Visual Studio 2022 version 17.2](https://aka.ms/vs-2022-17-2-release): If you're experiencing delays when you view your Git repository or branch history in Visual Studio, we've integrated a "commit graph" feature that can help. To use commit graph, make sure you [download and install Visual Studio 2022](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta). To learn more about commit graph, see the [Supercharge your Git experience in Visual Studio](https://devblogs.microsoft.com/visualstudio/supercharge-your-git-experience-in-vs/) blog post.

## Force a garbage collection

The CLR uses a garbage collection memory management system. In this system, sometimes memory is used by objects that are no longer needed. This state is temporary; the garbage collector releases this memory based on its performance and resource usage heuristics. You can force the CLR to collect any unused memory by using a hotkey in Visual Studio. If there's a significant amount of garbage waiting for collection and you force a garbage collection, you should see the memory usage of the *devenv.exe* process drop in **Task Manager**. It’s rarely necessary to use this method. However, after an expensive operation has completed (such as a full build, debug session, or a solution open event), it can help you determine how much memory is really being used by the process. Because Visual Studio is mixed (managed & native), it’s occasionally possible for the native allocator and the garbage collector to compete for limited memory resources. Under conditions of high memory usage, it may help to force the garbage collector to run.

To force a garbage collection, use this keyboard shortcut: **Ctrl**+**Alt**+**Shift**+**F12**, **Ctrl**+**Alt**+**Shift**+**F12** (press it twice).

If forcing garbage collection reliably makes your scenario work, file a report through the [Visual Studio feedback tool](how-to-report-a-problem-with-visual-studio.md) as this behavior is likely to be a bug.

For a detailed description of the CLR garbage collector, see [Fundamentals of garbage collection](/dotnet/standard/garbage-collection/fundamentals).

## Related content

- [Optimize Visual Studio performance](../ide/optimize-visual-studio-performance.md)