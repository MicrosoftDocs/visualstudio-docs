---
title: "Unable to set data breakpoint | Microsoft Docs"
description: Find explanations, solutions, and workarounds for "Unable to set data breakpoint errors" that occur when using "Break when Value Changes".
ms.custom: SEO-VS-2020
ms.date: "5/19/2020"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.unable_to_set_data_breakpoint"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "debugging [Visual Studio], managed"
  - "debugging managed code, data breakpoint"
ms.assetid: b06b5d65-424b-490f-bf58-97583cd7006a
author: "wardengnaw"
ms.author: "waan"
manager: caslan
ms.workload:
  - "multiple"
---
# Troubleshooting data breakpoint errors
This page will walk you through on resolving common errors seen when using "Break when Value Changes"

## Diagnosing "Unable to set data breakpoint" errors
> [!IMPORTANT]
> Managed Data Breakpoints is supported in .NET Core 3.0 and up and .NET 5.0.3 and up. You can download the latest [here](https://dotnet.microsoft.com/download).

Below is a list of errors that may occur when using managed data breakpoints. They contain more explanation on why the error is happening and possible solutions or workarounds to resolve the error.

- *"The version of .NET used by the target process does not support data breakpoints. Data breakpoints require .NET Core 3.x or .NET 5.0.3+, running on x86 or x64."*

  - The support for managed data breakpoints began in .NET Core 3.0. It is currently not supported in .NET Framework, versions of .NET Core under 3.0, or versions of .NET under 5.0.3. 
    
  - **Solution**: The solution to this would be to upgrade your project to .NET Core 3.x or .NET 5+.

- *"The value cannot be found on the managed heap and cannot be tracked."*
  - Variable declared on the stack.
    - We do not support setting data breakpoints for variables created on the stack since this variable will be invalid once the function exits.
    - **Workaround**: Set breakpoints on lines where the variable is used.

  - "Break when Value changes" on a variable that is not expanded from a dropdown.
    - The debugger internally needs to know the object containing the field you want to track. The Garbage Collector may move your object around in the heap so the debugger will need to know the object that is holding the variable you wish to track. 
    - **Workaround**: If you are in a method within the object you wish to set a data breakpoint on, go up one frame and use the `locals/autos/watch` window to expand the object and set a data breakpoint the field you want.

- *"Data Breakpoints are not supported for static fields or static properties."*
    
  - Static fields and properties are not supported at the moment. If you are interested in this feature, please provide [feedback](#provide-feedback).

- *"Fields and properties of structs cannot be tracked."*

  - Fields and properties of structs are not supported at the moment. If you are interested in this feature, please provide [feedback](#provide-feedback).

- *"The property value has changed and can no longer be tracked."*

  - A property may change how it is calculated during runtime, and if this happens, the number of variables that the property depends on increases and may exceed the hardware limitation. See `"The property is dependent on more memory than can be tracked by the hardware."` below.

- *"The property is dependent on more memory than can be tracked by the hardware."*
    
  - Each architecture has a set number of bytes and hardware data breakpoints that it can support and the property that you wish to set a data breakpoint on has exceeded that limit. Please refer to the [Data Breakpoint Hardware Limitations](#data-breakpoint-hardware-limitations) table to find out how many hardware supported data breakpoints and bytes are available for the architecture you are using. 
  - **Workaround**: Set a data breakpoint on a value that may change within the property.

- *"Data Breakpoints are not supported when using the legacy C# expression evaluator."*

  - Data breakpoints are only supported on the non-legacy C# expression evaluator. 
  - **Solution**: You disable the legacy C# expression evaluator by going to `Debug -> Options` then under `Debugging -> General` uncheck `"Use the legacy C# and VB expression evaluators"`.

- *"Class **X** has a custom debugger view that blocks using data breakpoints on data specific only to it."*
  
  - Data breakpoints are only supported on memory that is created by the target process (the application that is being debugged). The memory that the data breakpoint is being set on has been flagged as possibly being owned by an object created by a [DebuggerTypeProxy attribute](using-debuggertypeproxy-attribute.md) or something else that isn't part of the target process.
  - **Workaround**: Expand the "Raw View" of the object(s) instead of expanding the DebuggerTypeProxy view of the object(s), and then set the data breakpoint. This will guarantee that the data breakpoint isn't on memory owned by an object created by a DebuggerTypeProxy attribute.

## Data breakpoint hardware limitations

The architecture (platform configuration) that your program runs on has a limited number of hardware data breakpoints it can use. The table below indicates how many registers are available to use per architecture.

| Architecture | Number of hardware supported data breakpoints | Max byte size|
| :-------------: |:-------------:| :-------------:|
| x86 | 4 | 4 |
| x64 | 4 | 8 |
| ARM | 1 | 4 |
| ARM64 | 2 | 8 |

## Provide feedback

For any issues or suggestions about this feature, please let us know via Help > Send Feedback > [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) in the IDE or in the [Developer Community](https://aka.ms/feedback/suggest?space=8).

## See also

- [Using "Break when Value changes" in .NET](using-breakpoints.md#BKMK_set_a_data_breakpoint_managed).
- [DevBlog: Break When Value Changes: Data Breakpoints for .NET Core in Visual Studio 2019](https://devblogs.microsoft.com/visualstudio/break-when-value-changes-data-breakpoints-for-net-core-in-visual-studio-2019/)
