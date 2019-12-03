---
title: "Error: Unable to set Data Breakpoint | Microsoft Docs"
ms.date: "12/3/2019"
ms.topic: "troubleshooting"
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
# How to: Debug with Managed Data Breakpoints
> [!IMPORTANT]
> Managed Data Breakpoints is supported in .NET Core 3.0 and up. You can download the latest [here](https://dotnet.microsoft.com/download).

If you are interested in using the "Break when Value changes" feature in .NET Core 3.0. Please see usage in the [documentation](using-breakpoints.md#set-data-breakpoints-net-core-30-or-higher).

# Troubleshooting "Unable to set data breakpoint" Errors

Below is a list of errors that may occur when using managed data breakpoints. They contain additional explanation on why the error is happening and possible solutions or workarounds to resolve error.

1. *"The version of .NET used by the target process does not support data breakpoints. Data breakpoints require .NET Core 3.0+ running on x86 or x64."*

    - The support for managed data breakpoints began in .NET Core 3.0. It is currently not supported in .NET Framework or version of .NET Core under 3.0. 
    
    - **Solution**: The solution to this would be to upgrade your project to .NET Core 3.0.

2. *"The value cannot be found on the managed heap and cannot be tracked."*

    - This error can occur because of multiple reasons:

    1. Variable declared on the stack.
        - We do not support setting data breakpoints for variables created on the stack since this variable will be invalid once the function exits.
        - **Workaround**: Set breakpoints on lines where the variable is used.

    2. "Break when Value changes" on a variable that is not expanded from a dropdown.
        - The debugger internally needs to know the object containing the field you want to track. The Garbage Collector may move your object around in the heap so the debugger will need to know the object that is holding the variable you wish to track. 
        - **Workaround**: If you are in a method within the object you wish to set a data breakpoint on, go up one frame and use the `locals/autos/watch` window to expand the object and set a data breakpoint the field you want.

3. *"Data Breakpoints are not supported for static fields or static properties."*
    
    - Static fields and properties are not supported at the moment. If you are interested in this feature, please provide [feedback](#provide-feedback).

4. *"Fields and properties of structs cannot be tracked."*

    - Fields and properties of structs are not supported at the moment. If you are interested in this feature, please provide [feedback](#provide-feedback).

5. *"The property value has changed and can no longer be tracked."*

    - A property may change how it is calculated during runtime, and if this happens, the number of variables that the property depends on increases and may exceed the hardware limitation. See `"The property is dependent on more memory than can be tracked by the hardware."` below.

6. *"The property is dependent on more memory than can be tracked by the hardware."*
    
    - Each architecture has a set number of bytes and hardware data breakpoints that it can support and the property that you wish to set a data breakpoint on has exceeded that limit. Please refer to the this [documentation](hardware-supported-data-breakpoints.md) to find out how many hardware supported data breakpoints and bytes are available for the architecture you are using. 
    - **Workaround**: Set a data breakpoint on a value that may change within the property.

7. *"Data Breakpoints are not supported when using the legacy C# expression evaluator."*

    - Data breakpoints are only supported on the non-legacy C# expression evaluator. 
    - **Solution**: You disable the legacy C# expression evaluator by going to `Debug -> Options` then under `Debugging -> General` uncheck `"Use the legacy C# and VB expression evaluators"`.


## Provide feedback
For any issues or suggestions about this feature, please let us know via Help > Send Feedback > [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) in the IDE or in the [Developer Community](https://developercommunity.visualstudio.com/).

## See also
[DevBlog: Break When Value Changes: Data Breakpoints for .NET Core in Visual Studio 2019](https://devblogs.microsoft.com/visualstudio/break-when-value-changes-data-breakpoints-for-net-core-in-visual-studio-2019/)
