---
title: "Troubleshoot breakpoints in the debugger | Microsoft Docs"
description: If a breakpoint is disabled or couldn't be set, it's displayed as a hollow circle. Look here information on problems that can occur when setting breakpoints.

ms.date: "12/09/2022"
ms.topic: "troubleshooting" 
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
f1_keywords:
  - "vs.debug.error.unable_to_set_data_breakpoint"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "debugging [Visual Studio], managed"
  - "debugging managed code, data breakpoint"
---

# Troubleshoot Breakpoints in the Visual Studio Debugger

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

## Breakpoint warning appeared

When debugging, a breakpoint has two possible visual states:

* A solid red circle, if the debugger successfully set a breakpoint in the target process.
* A hollow (white filled) circle, either the breakpoint is disabled or warning occurred when trying to set the breakpoint.

To determine the difference, hover over the breakpoint and see if there's a warning. The following two sections describe prominent warnings and how to fix them.

### Warning: `No Symbols have been loaded for this document`

Go to the **Modules** window (**Debug** > **Windows** > **Modules**) and check whether your module is loaded.

* If your module is loaded, check the **Symbol Status** column to see whether symbols have been loaded.
  * If symbols aren't loaded, check the symbol status to diagnose the issue. From the context menu on a module in the **Modules** window, select **Symbol Load Information...** to see where the debugger looked to try and load symbols. For more information about loading symbols, see [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).
  * If symbols are loaded, the PDB doesn't contain information about your source files. A few possible causes are:
    * If your source files were recently added, confirm that an up-to-date version of the module is being loaded.
    * It's possible to create stripped PDBs using the **/PDBSTRIPPED** linker option. Stripped PDBs don't contain source file information. Confirm you're working with a full PDB and not a stripped PDB.
    * The PDB file is partially corrupted. Delete the file and run a clean build of the module to try to resolve the issue.

* If your module isn't loaded, check the following to find the cause:
  * Confirm that you're debugging the right process.
  * Check to see that you're debugging the right code. You can find out what type of code the debugger is configured to debug in the **Processes** window (**Debug** > **Windows** > **Processes**). For example, if you're trying to debug C# code, confirm that your debugger is configured for the appropriate type and version of .NET (for example, Managed (v4\*) versus Managed (v2\*/v3\*) versus Managed (CoreCLR)).

### Warning: `… the current source code is different from the version built into...`

If a source file has changed and the source no longer matches the code you're debugging, the debugger cannot set breakpoints in the code by default. Normally, this problem happens when a source file is changed, but the source code wasn't rebuilt. To fix this issue, rebuild the project. If the build system thinks the project is already up-to-date even though it isn't, you can force the project system to rebuild. Rebuild the project either by saving the source file again or by cleaning the build output before building.

In rare scenarios, you may want to debug without having matching source code. Debugging without matching source code can lead to a confusing debugging experience, so make sure how you want to continue.

Follow one of the options to disable these safety checks:

* To modify a single breakpoint, hover over the breakpoint icon in the editor and select the settings (gear) icon. A peek window is added to the editor. At the top of the peek window, there's a hyperlink that indicates the location of the breakpoint. Select the hyperlink to allow modification of the breakpoint location and check **Allow the source code to be different from the original**.
* To modify this setting for all breakpoints, go to **Debug** > **Options and Settings**. On the **Debugging/General** page, clear the **Require source files that exactly match the original version** option. Make sure to reenable this option when you're finished debugging.

## The breakpoint didn't hit

If your breakpoint was successfully set, meaning no warning was issued, but breakpoint didn't get hit when you ran the code, check the following list: 

1. If your code runs in more than one process or more than one computer, make sure that you're debugging the right process or computer.
2. Confirm that your code is running. To test that your code is running, add a call to `System.Diagnostics.Debugger.Break` (C#/VB) or `__debugbreak` (C++) to the line of code where you're trying to set the breakpoint and then rebuild your project.
3. If you're debugging optimized code, make sure the function where your breakpoint is set isn't being inlined into another function. The `Debugger.Break` test described in the previous check can work to test this issue as well.
4. For [attach to process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md) scenarios, make sure you are debugging the right type of code (for example, script code versus .NET Framework versus .NET 5+). To investigate, check the **Attach to** option in the Attach to Process dialog box, and choose **Select**, if necessary, to change the code type.

## I deleted a breakpoint, but I continue to hit it when I start debugging again

If you deleted a breakpoint while debugging, you may hit the breakpoint again the next time you start debugging. To stop hitting this breakpoint, make sure all the instances of the breakpoint are removed from the **Breakpoints** window.


## Diagnose C# data breakpoints: "Unable to set data breakpoint" errors

In this section, find the explanations, solutions, and workarounds for "Unable to set data breakpoint errors" that occur when using "Break when Value Changes".
> [!IMPORTANT]
> Managed Data Breakpoints is supported in .NET Core 3.0 and up and .NET 5.0.3 and up. You can download the latest [here](https://dotnet.microsoft.com/download).

The following list of errors may occur when using managed data breakpoints. They contain more explanation on why the error is happening and possible solutions or workarounds to resolve the error.

- *"The version of .NET used by the target process does not support data breakpoints. Data breakpoints require .NET Core 3.x or .NET 5.0.3+, running on x86 or x64."*

  - The support for managed data breakpoints began in .NET Core 3.0. It is currently not supported in .NET Framework, versions of .NET Core under 3.0, or versions of .NET under 5.0.3. 
    
  - **Solution**: The solution to this would be to upgrade your project to .NET Core 3.x or .NET 5+.

- *"The value cannot be found on the managed heap and cannot be tracked."*
  - Variable declared on the stack.
    - We do not support setting data breakpoints for variables created on the stack since this variable would be invalid once the function exits.
    - **Workaround**: Set breakpoints on lines where the variable is used.

  - "Break when Value changes" on a variable that is not expanded from a dropdown.
    - The debugger internally needs to know the object containing the field you want to track. The Garbage Collector may move your object around in the heap so the debugger needs to know the object that is holding the variable you wish to track. 
    - **Workaround**: If you are in a method within the object you wish to set a data breakpoint on, go up one frame and use the `locals/autos/watch` window to expand the object and set a data breakpoint the field you want.

- *"Data Breakpoints are not supported for static fields or static properties."*
    
  - Static fields and properties are not supported. 

- *"Fields and properties of structs cannot be tracked."*

  - Fields and properties of structs are not supported.

- *"The property value has changed and can no longer be tracked."*

  - A property may change how it is calculated during runtime, and if this happens, the number of variables that the property depends on increases and may exceed the hardware limitation. See `"The property is dependent on more memory than can be tracked by the hardware."` below.

- *"The property is dependent on more memory than can be tracked by the hardware."*
    
  - Each architecture has a set number of bytes and hardware data breakpoints that it can support and the property that you wish to set a data breakpoint on has exceeded that limit. Refer to the [Data Breakpoint Hardware Limitations](#data-breakpoint-hardware-limitations) table to find out how many hardware supported data breakpoints and bytes are available for the architecture you are using. 
  - **Workaround**: Set a data breakpoint on a value that may change within the property.

- *"Data Breakpoints are not supported when using the legacy C# expression evaluator."*

  - Data breakpoints are only supported on the non-legacy C# expression evaluator. 
  - **Solution**: You disable the legacy C# expression evaluator by going to `Debug -> Options` then under `Debugging -> General` uncheck `"Use the legacy C# and VB expression evaluators"`.

- *"Class **X** has a custom debugger view that blocks using data breakpoints on data specific only to it."*
  
  - Data breakpoints are only supported on memory that is created by the target process (the application that is being debugged). The memory that the data breakpoint is being set on has been flagged as possibly being owned by an object created by a [DebuggerTypeProxy attribute](using-debuggertypeproxy-attribute.md) or something else that isn't part of the target process.
  - **Workaround**: Expand the "Raw View" of the object(s) instead of expanding the DebuggerTypeProxy view of the object(s), and then set the data breakpoint. Doing so guarantees that the data breakpoint isn't on memory owned by an object created by a DebuggerTypeProxy attribute.

## Data breakpoint hardware limitations

The architecture (platform configuration) that your program runs on has a limited number of hardware data breakpoints it can use. The following table indicates how many registers are available to use per architecture.

| Architecture | Number of hardware supported data breakpoints | Max byte size|
| :-------------: |:-------------:| :-------------:|
| x86 | 4 | 4 |
| x64 | 4 | 8 |
| ARM | 1 | 4 |
| ARM64 | 2 | 8 |


