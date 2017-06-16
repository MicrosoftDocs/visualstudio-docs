---
title: "Tips and Tricks in the Visual Studio Debugger | Microsoft Docs"
ms.custom: ""
ms.date: "06/15/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "stepping"
  - "debugging [Visual Studio], execution control"
  - "execution, controlling in debugger"
ms.assetid: 5262d8b1-2648-429e-85d5-90fcaadfb362
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Learn Productivity Tips and Tricks for the Debugger in Visual Studio

Read here about productivity tips and tricks for the Visual Studio debugger. For a look at the basic features of the debugger, see [Debugger Feature Tour](../debugger/debugger-feature-tour.md) or [Get started with the debugger](../debugger/getting-started-with-the-debugger.md). In this topic, we cover some areas that are not included in the feature tour.

## Pin data tips

If you frequently hover view data tips while debugging, you may want to pin the data tip for the variable to give yourself quick access. The variable stays pinned even after restarting. To pin the data tip, just click the pin icon while hovering over it. You can pin multiple variables.

![Pinning a Data Tip](../debugger/media/dbg-tips-data-tips-pinned.png "PinningDataTip")

## Edit your code and continue debugging (C#, VB, C++)

In most languages supported by Visual Studio, you can edit your code in the middle of a debugging session and continue debugging. To do this, click into your code with your cursor while paused in the debugger, make edits, and press **F5**, **F10**, or **F11** to continue debugging.

![Edit and continue debugging](../debugger/media/dbg-tips-edit-and-continue.gif "EditAndContinue")

For more information on using the feature and on feature limitations, see [Edit and Continue](../debugger/edit-and-continue.md).

## Debug issues that are hard to reproduce

If it is difficult or time-consuming to recreate a particular state in your app, consider whether the use of a conditional breakpoint will help. You can use [conditional breakpoints](../debugger/using-breakpoints.md#BKMK_Specify_a_breakpoint_condition_using_a_code_expression) and filter breakpoints to avoid breaking into your app code until the app enters a desired state (such as a state in which a variable is storing bad data). You can set conditions using expressions, filters, hit counts, and so on.

#### To create a conditional breakpoint

1. Right-click a breakpoint icon (the red ball) and choose **Conditions**.

2. In the **Breakpoint Settings** window, type an expression.

    ![Conditional Breakpoint](../debugger/media/dbg-multithreaded-conditional-breakpoint.png "ConditionalBreakpoint")

3. If you are interested in another type of condition, select **Filter** instead of **Conditional expression** in the **Breakpoint Settings** dialog box, and then follow the filter tips.

## Track an out-of-scope object (.NET)

It's easy to view variables using debugger windows like the **Watch** window. However, when a variable goes out of scope in the **Watch** window, you may notice that it is grayed out. In some app scenarios, the value of a variable may change even when the variable is out of scope, and you might want to watch it closely (for example, a variable may get garbage collected). You can track the variable by creating an Object ID for it in the **Watch** window.

#### To create an object ID

1.  Set a breakpoint near a variable that you want to track.

2.  Start the debugger (**F5**) and stop at the breakpoint.

3. Find the variable in the **Locals** window (**Debug / Windows / Locals**), right-click the variable, and select **Make Object ID**.

    ![Create an Object ID](../debugger/media/dbg-tips-watch-create-object-id.png "CreateObjectID")
  
4.  You should see a **$** plus a number in the **Locals** window. This is the object ID.
  
5.  Right-click the object ID variable and choose **Add Watch**.

For more information, see [Create an Object ID](https://docs.microsoft.com/en-us/visualstudio/debugger/watch-and-quickwatch-windows.md#bkmk_objectIds).

## View return values for functions

To view return values for your functions, look at the functions that appear in the **Autos** window while you are stepping through your code. To see the return value for a function, make sure that the function you are interested in has already executed (press **F10** once if you are currently stopped on the function call). If the window is closed, use **Debug / Windows / Autos** to open the **Autos** window.

![Immediate Window](../debugger/media/dbg-tips-autos-window.png "ImmediateWindow")

In addition, you can enter functions in the **Immediate** window to view return values. (Open it using **Debug / Windows / Immediate**.)

![Immediate Window](../debugger/media/dbg-tips-immediate-window.png "ImmediateWindow")

You can also use [pseudovariables](..debugger/pseudovariables.md) in the **Watch** and **Immediate** window, such as `$ReturnValue`.

## Inspect strings in a visualizer

When working with strings, it can be helpful to view the entire formatted string. To view a plain text, XML, HTML, or JSON string, click the magnifying glass icon while hovering over a variable containing a string value. For XAML code, you can also view `DataSet`, `DataView`, and `DataTable` objects in visualizers.

![Open a String Visualizer](../debugger/media/dbg-tips-string-visualizers.png "OpenStringVisualizer")

A string vizualizer may help you find out whether a string is malformed, depending on the string type. For example, a blank **Value** field indicates the string is not recognized by the visualizer type. For more information, see [String Visualizer Dialog Box](../debugger/string-visualizer-dialog-box.md).

![JSON String Visualizer](../debugger/media/dbg-tips-string-visualizer-json.png "JSONStringVisualizer")

## Break into code on handled exceptions

The debugger will break into your code on unhandled exceptions. However, handled exceptions (such as those that occur within a `try/catch` block) can also be a source of bugs and you may want to investigate when they occur. You can configure the debugger to break into code even for handled exceptions by configuring options in the **Exception Settings** dialog box. Open this dialog box by choosing **Debug / Windows / Exception Settings**.

The **Exception Settings** dialog box allows you to tell the debugger to break into code on specific exceptions. In the illustration below, the debugger will break into your code whenever a `System.NullReferenceException` occurs. For more information, see [Managing exceptions](../debugger/managing-exceptions-with-the-debugger.md).

![Exception Settings Dialog Box](../debugger/media/dbg-tips-exception-settings.png "ExceptionSettingsDialogBox")

## Debug deadlocks and race conditions

If you need to debug the kinds of issues that are common to multithreaded apps, it will often help to view the location of threads while debugging. You can do this easily using the **Show Threads in Source** button.

#### To show threads in your source code

1.  While debugging, click the **Show Threads in Source** button ![Show Threads in Source](../debugger/media/dbg-multithreaded-show-threads.png "ThreadMarker") in the **Debug** toolbar.
  
2.  Look at the gutter on the left side of the window. On this line, you will see a *thread marker* icon  ![Thread Marker](../debugger/media/dbg-thread-marker.png "ThreadMarker") that resembles two cloth threads. The thread marker indicates that a thread is stopped at this location.

    Notice that a thread marker may be partially concealed by a breakpoint.
  
3.  Hover the pointer over the thread marker. A DataTip appears. The DataTip tells you the name and thread ID number for each stopped thread.

    You can also view the location of threads in the [Parallel Stacks window](../debugger/get-started-debugging-multithreaded-apps.md).

## Examine payloads for web services and network resources (UWP)

In UWP apps, you can analyze network operations performed using the `Windows.Web.Http` API. You can use this tool to help debug web services and network resources. To use the tool, select **Debug / Performance Profiler**. Select **Network**, and then choose **Start**. In your app, go through the scenario that uses `Windows.Web.Http`, and then choose **Stop collection** to generate the report.

![Network Usage profiling tool](../profiling/media/prof-tour-network-usage.png "Diag Network Usage")

Select an operation in the summary view to view more details.

![Detailed information in the Network Usage tool](../profiling/media/prof-tour-network-usage-details.png "Diag Network Usage Details")

For more information, see [Network Usage](../profiling/network-usage.md).

## Get more familiar with how the debugger attaches to your app

To attach to your running app, the debugger must load symbol (.pdb) files generated for the exact same build of the app you are trying to debug. You can examine how Visual Studio loads symbol files using the **Modules** window. Some understanding of symbol files will also help you if, while debugging, you run into a message such as `The breakpoint will not currently be hit. No symbols have been loaded for this document`.

The Modules window can tell you what modules the debugger is treating as user code, or [*My Code*](../debugger/just-my-code.md), and the symbol loading status for the module. In most scenarios, the debugger will automatically find symbol files for user code, but if you want to step into (or debug) .NET framework code, system code, or third-party library code, extra steps are required to obtain the correct symbol files.

![View symbol information in the Modules window](../debugger/media/dbg-tips-modules-window.png "ViewSymbolInformation")

You can load symbol information directly from the **Modules** window by right-clicking and choosing **Load Symbols**. In most scenarios, you will not need to do this. But if you are trying to debug non-user code or a version of the app built by someone else, this can be useful information.

To find out how the debugger classifies code as user code, see [Just My Code](../debugger/just-my-code.md). To find out more about symbol files, see [Specify symbol (.pdb) and source files in the Visual Studio debugger](specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).
