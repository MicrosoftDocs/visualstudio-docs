---
title: "Troubleshoot breakpoints in the debugger | Microsoft Docs"
description: If a breakpoint is disabled or could not be set, it is displayed as a hollow circle. Look here information on problems that can occur when setting breakpoints.

ms.date: "01/23/2018"
ms.topic: "troubleshooting"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Troubleshoot Breakpoints in the Visual Studio Debugger

## Breakpoint Warnings

When debugging, a breakpoint has two possible visual states: a solid red circle and a hollow (white filled) circle. If the debugger is able to successfully set a breakpoint in the target process, it will stay a solid red circle. If the breakpoint is a hollow circle, either the breakpoint is disabled or warning occurred when trying to set the breakpoint. To determine the difference, hover over the breakpoint and see if there is a warning.

The following two sections describe prominent warnings and how to fix them.

### "No Symbols have been loaded for this document"

Go to the **Modules** window (**Debug** > **Windows** > **Modules**) and check whether your module is loaded.
* If your module is loaded, check the **Symbol Status** column to see whether symbols have been loaded.
  * If symbols are not loaded, check the symbol status to diagnose the issue. From the context menu on a module in the **Modules** window, click **Symbol Load Information...** to see where the debugger looked to try and load symbols. For more information about loading symbols, see [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).
  * If symbols are loaded, the PDB does not contain information about your source files. These are a few possible causes:
    * If your source files were recently added, confirm that an up-to-date version of the module is being loaded.
    * It is possible to create stripped PDBs using the **/PDBSTRIPPED** linker option. Stripped PDBs do not contain source file information. Confirm you are working with a full PDB and not a stripped PDB.
    * The PDB file is partially corrupted. Delete the file and perform a clean build of the module to try to resolve the issue.

* If your module is not loaded, check the following to find the cause:
  * Confirm that you are debugging the right process.
  * Check to see that you are debugging the right kind of code. You can find out what type of code the debugger is configured to debug in the **Processes** window (**Debug** > **Windows** > **Processes**). For example, if you are trying to debug C# code, confirm that your debugger is configured for the appropriate type and version of .NET (for example, Managed (v4\*) versus Managed (v2\*/v3\*) versus Managed (CoreCLR)).

### "… the current source code is different from the version built into..."

If a source file has changed and the source no longer matches the code you are debugging, the debugger will not set breakpoints in the code by default. Normally, this problem happens when a source file is changed, but the source code wasn’t rebuilt. To fix this issue, rebuild the project. If the build system thinks the project is already up-to-date even though it isn’t, you can force the project system to rebuild either by saving the source file again or by cleaning the project’s build output before building.

In rare scenarios, you may want to debug without having matching source code. Debugging without matching source code can lead to a confusing debugging experience, so make sure that this is how you want to proceed.

To disable these safety checks, do one of the following:
* To modify a single breakpoint, hover over the breakpoint icon in the editor and click the settings (gear) icon. A peek window is added to the editor. At the top of the peek window, there is a hyperlink that indicates the location of the breakpoint. Click the hyperlink to allow modification of the breakpoint location and check **Allow the source code to be different from the original**.
* To modify this setting for all breakpoints, go to **Debug** > **Options and Settings**. On the **Debugging/General** page, clear the **Require source files that exactly match the original version** option. Make sure to reenable this option when you are finished debugging.

## The breakpoint was successfully set (no warning), but didn’t hit

This section provides information to troubleshoot issues when the debugger isn’t displaying any warnings – the breakpoint is a solid red circle while actively debugging, yet the breakpoint isn’t being hit.

Here are a few things to check:
1. If your code runs in more than one process or more than one computer, make sure that you are debugging the right process or computer.
2. Confirm that your code is running. To test that your code is running, add a call to `System.Diagnostics.Debugger.Break` (C#/VB) or `__debugbreak` (C++) to the line of code where you are trying to set the breakpoint and then rebuild your project.
3. If you are debugging optimized code, make sure the function where your breakpoint is set isn’t being inlined into another function. The `Debugger.Break` test described in the previous check can work to test this issue as well.

## I deleted a breakpoint, but I continue to hit it when I start debugging again

If you deleted a breakpoint while debugging, you may hit the breakpoint again the next time you start debugging. To stop hitting this breakpoint, make sure all the instances of the breakpoint are removed from the **Breakpoints** window.
