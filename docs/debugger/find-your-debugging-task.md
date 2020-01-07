---
title: "Find your debugging task"
description: Identify the debugger feature that will help you debug your app
ms.custom: ""
ms.date: "10/01/2019"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugging [Visual Studio], find your feature"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Find your debugging task in Visual Studio

If you need help to map your debugging task to the correct feature of the Visual Studio debugger that is relevant, use the links provided in this article. The list of tasks here includes common tasks such as pausing code to debug, inspecting variables, and sending messages to the **Output** window. If you need an overview of debugger features, see [First look at the debugger](debugger-feature-tour.md) instead.

## Pause running code

### Pause running code to inspect a line of code that may contain a bug

Set a breakpoint. For more information, see [Using breakpoints](using-breakpoints.md).

### Pause and inspect your app when it reaches a specific state

Try a conditional breakpoint to control where and when a breakpoint gets activated by using conditional logic. For more information, see [Breakpoint conditions](using-breakpoints.md#breakpoint-conditions).

### Pause code only when a specific object’s property or value changes

For C++, set a [data breakpoint](using-breakpoints.md#BKMK_set_a_data_breakpoint_native_cplusplus). 
::: moniker range=">= vs-2019"
For apps using .NET Core 3, you can also set a [data breakpoint](using-breakpoints.md#BKMK_set_a_data_breakpoint_managed).
::: moniker-end

Otherwise, for C# and F# only, you can [track an object ID with a conditional breakpoint](using-breakpoints.md#using-object-ids-in-breakpoint-conditions-c-and-f).

### Pause code inside a loop at a certain iteration

Set a breakpoint using **Hit count** as a condition. For more information, see [Hit count](using-breakpoints.md#set-a-hit-count-condition).

### Pause code at the start of a function when you know the function name but not its location

You can do this with a function breakpoint. For more information, see [Set function breakpoints](using-breakpoints.md#BKMK_Set_a_breakpoint_in_a_source_file).

### Pause code at the start of multiple functions with the same name

When you have multiple functions with the same name (overloaded functions or functions in different projects), you can use a [function breakpoint](using-breakpoints.md#BKMK_Set_a_breakpoint_in_a_source_file).

### Manage and keep track of your breakpoints

Use the **Breakpoints** window. For more information, see [Manage breakpoints](using-breakpoints.md#BKMK_Specify_advanced_properties_of_a_breakpoint_).

### Pause code and debug when a specific handled or unhandled exception is thrown

Although the Exception Helper shows you where an error occurred, if you want to pause and debug the specific error, you can [tell the debugger to break when an exception is thrown](managing-exceptions-with-the-debugger.md#tell-the-debugger-to-break-when-an-exception-is-thrown).

### Set a breakpoint from the call stack

If you want to pause and debug code while examining execution flow or viewing functions in the **Call Stack** windows, see [Set a breakpoint in the Call Stack window](using-breakpoints.md#BKMK_Set_a_breakpoint_from_debugger_windows).

### Pause code at a specific assembly instruction

You can do this by [setting a breakpoint from the Disassembly window](using-breakpoints.md#BKMK_Set_a_breakpoint_from_debugger_windows).

## Execute code

### Learn the commands to step through your code while debugging

For more information, see [Navigate code with the debugger](navigating-through-code-with-the-debugger.md).

## Inspect data

### Check the value of variables while running your app

Hover over variables using [data tips](view-data-values-in-data-tips-in-the-code-editor.md) or [inspect variables in the Autos and Locals window](autos-and-locals-windows.md).

### Observe the changing value of a specific variable

Set a watch on the variable. For more information, see [Set a watch on variables](watch-and-quickwatch-windows.md).

### View strings that are too long for the debugger window

Open the built-in [string visualizer](view-strings-visualizer.md) while debugging.

## Configure debugging

### Customize information shown in the debugger

You may want to show information other than the object type as the value in different debugger windows. For C#, Visual Basic, F#, and C++/CLI code, use the [DebuggerDisplay](using-the-debuggerdisplay-attribute.md) attribute. For more advanced options, you can also customize the UI by creating a [custom visualizer](create-custom-visualizers-of-data.md).

For native C++, use the [NatVis framework](create-custom-views-of-native-objects.md).

### Configure debugger settings

To configure debugger options and debugger project settings, see [Debugger settings and preparation](debugger-settings-and-preparation.md).

## Additional tasks

### Fix an exception

See [Fix an exception](write-better-code-with-visual-studio.md#fix-an-exception).

### Edit code during a debugging session

Use [Edit and continue](edit-and-continue.md). For XAML, use [XAML Hot Reload](../xaml-tools/xaml-hot-reload.md).

### Send messages to the Output window without modifying code

Set a tracepoint. For more information, see [Using tracepoints](using-tracepoints.md).

## View the order in which functions are called

See [How to view the call stack](how-to-use-the-call-stack-window.md).

### Debug on remote machines

See [Remote debugging](remote-debugging.md).

### Debug an app that is already running

See [Attach to a running processes](attach-to-running-processes-with-the-visual-studio-debugger.md).

### Debug multithreaded applications

See [Debug multithreaded applications](debug-multithreaded-applications-in-visual-studio.md).