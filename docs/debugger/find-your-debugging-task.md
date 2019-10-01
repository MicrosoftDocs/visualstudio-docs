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

Use the information here to map your debugging task to the particular feature of the Visual Studio debugger that is relevant, and provide links to get you to the right place. This list of tasks is not exhaustive, but lists some of the more commonly used debugger features.

## Pause running code to inspect a line of code that may contain a bug

Set a breakpoint. For more information, see [Using breakpoints](using-breakpoints.md).

## Pause and inspect your app when it reaches a specific state

Try a conditional breakpoint to control where and when a breakpoint gets activated by using conditional logic. For more information, see [Breakpoint conditions](using-breakpoints.md#breakpoint-conditions).

## Check the value of variables while running your app

Hover over variables using [data tips](view-data-values-in-data-tips-in-the-code-editor.md) or [inspect variables in the Autos and Locals window](autos-and-locals-windows.md).

## Observe the changing value of a specific variable

Set a watch on the variable. For more information, see [Set a watch on variables](uwatch-and-quickwatch-windows.md).

## Pause only when a specific object’s property or value changes

For C++, set a [data breakpoint](using-breakpoints.md#BKMK_set_a_data_breakpoint_native_cplusplus_only). For apps using .NET Core 3, you can also set a [data breakpoint](using-breakpoints.md#BKMK_set_a_data_breakpoint_managed).

Otherwise, for C# and F# only, you can [track an object ID with a conditional breakpoint](using-breakpoints.md#using-object-ids-in-breakpoint-conditions-c-and-f).

## Learn the commands to step through your code while debugging

For more information, see [Navigate code with the debugger](navigating-through-code-with-the-debugger.md).

## Pause inside a loop at a certain iteration

Set a breakpoint using **Hit count** as a condition. For more information, see [Hit count](using-breakpoints.md#hit-count).

## Pause at the start of a function when you know the function name but not its location

You can do this with a function breakpoint. For more information, see [Set function breakpoints](using-breakpoints.md#BKMK_Set_a_breakpoint_in_a_source_file)

## Manage and keep track of your breakpoints

Use the **Breakpoints** window. For more information, see [Manage breakpoints](using-breakpoints.md#BKMK_Specify_advanced_properties_of_a_breakpoint_).

## Pause and debug when a specific handled or unhandled exception is thrown

Although the Exception Helper shows you where an error occurred, if you want to pause and debug the specific error, you can [tell the debugger to break when an exception is thrown](managing-exceptions-with-the-debugger.md#tell-the-debugger-to-break-when-an-exception-is-thrown).

## Set a breakpoint from the call stack

If you want to pause and debug code while examining execution flow or viewing functions in the **Call Stack** windows, see [Set a breakpoint in the Call Stack window](using-breakpoints.md#BKMK_Set_a_breakpoint_in_the_call_stack_window).

## Pause at a specific assembly instruction

You can do this by [setting a breakpoint from the **Disassembly** window](using-breakpoints.md#setting-a-breakpoint-in-the-disassembly-window).

## Send messages to the Output window without modifying code

Set a tracepoint. For more information, see [Using tracepoints](using-tracepoints.md).

## View strings that are too long for the debugger window

Open the built-in [string visualizer](view-strings-visualizer.md) while debugging.

## Customize information shown in the debugger

You may want to show information other than the object type as the value in different debugger windows. For C#, Visual Basic, F#, and C++/CLI, use the [DebuggerDisplay](using-the-debuggerdisplay-attribute.md) attribute. For more advanced options, you can also customize the UI by creating a [custom visualizer](create-custom-visualizers-of-data.md).

For native C++, use the [NatVis framework](create-custom-views-of-native-objects.md).

## Debug an app that is already running

See [Attach to a running processes](attach-to-running-processes-with-the-visual-studio-debugger.md).