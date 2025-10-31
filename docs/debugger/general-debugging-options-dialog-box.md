---
title: "General, Debugging, Options Dialog Box"
description: Set Visual Studio debugger options to meet your debugging needs. You can configure break behavior, debugging levels, display behavior, and much else.
ms.date: "10/31/2025"
ms.topic: "ui-reference"
f1_keywords:
  - "vs.debug.options.General"
  - "VS.ToolsOptionsPages.Debugger.General"
  - "VS.ToolsOptionsPages.Debugger.ENC"
  - "vs.debug.options.ENC"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "Options dialog box, debugging"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# General debugging options

To set Visual Studio debugger options, select **Tools** > **Options**, and under **Debugging** select or deselect the checkboxes next to the **General** options. You can restore all default settings with **Tools** > **Import and Export Settings** > **Reset all settings**. To reset a subset of settings, save your settings with the **Import and Export Settings Wizard** before making the changes that you want to test, then import your saved settings afterward.

You can set the following **General** options:

**Ask before deleting all breakpoints**:
Requires confirmation before completing the **Delete All Breakpoints** command.

**Break all processes when one process breaks**:
Simultaneously breaks all processes to which the debugger is attached, when a break occurs.

**Break when exceptions cross AppDomain or managed/native boundaries**:
In managed or mixed-mode debugging, the common language runtime can catch exceptions that cross application domain boundaries or managed/native boundaries when three conditions are true:

   - **Condition 1**: When native code calls managed code by using COM Interop and the managed code throws an exception. See [Introduction to COM Interop](/dotnet/articles/visual-basic/programming-guide/com-interop/introduction-to-com-interop).

   - **Condition 2**: When managed code running in application domain 1 calls managed code in application domain 2, and the code in application domain 2 throws an exception. See [Programming with application domains](/dotnet/articles/framework/app-domains/index).

   - **Condition 3**: When code calls a function by using reflection, and that function throws an exception. See [Reflection](/dotnet/framework/reflection-and-codedom/reflection).
   
   - For conditions 2 and 3, the exception is sometimes caught by managed code in `mscorlib` rather than by the common language runtime. This option doesn't affect breaking on exceptions caught by `mscorlib`.

**Enable address-level debugging**:
Enables advanced features for debugging at the address level (the **Disassembly** window, the **Registers** window, and address breakpoints).

- **Show disassembly if source is not available**:
    Automatically shows the **Disassembly** window when you debug code for which the source is unavailable.

**Enable breakpoint filters**:
Enables you to set filters on breakpoints so they affect only specific processes, threads, or computers.

**Use the new Exception Helper**:
Enables the Exception Helper that replaces the exception assistant. (Exception Helper is supported starting in Visual Studio 2017)

   > [!NOTE]
   > For managed code, this option was previously called **Enable the exception assistant** .

**Enable Just My Code**:
The debugger displays and steps into user code ("My Code") only, ignoring system code and other code that's optimized or that doesn't have debugging symbols.

- **Warn if no user code on launch (Managed only)**:
   When debugging starts with Just My Code enabled, this option warns you if there's no user code ("My Code").

::: moniker range="visualstudio"
**Enable .NET Framework source stepping**:
Allows the debugger to step into .NET Framework source. Enabling this option automatically disables Just My Code. .NET Framework symbols are downloaded to a cache location. You can change the cache location in the **Debugging** > **Symbols** > **Search Locations** section with the **Cache symbols in this directory** option.
::: moniker-end

::: moniker range="<=vs-2022"
**Enable .NET Framework source stepping**:
Allows the debugger to step into .NET Framework source. Enabling this option automatically disables Just My Code. .NET Framework symbols are downloaded to a cache location. You can change the cache location in the **Debugging** > **Symbols** section with the **Cache symbols in this directory** option.
::: moniker-end

::: moniker range=">=vs-2022"
**Automatically deoptimize debugged functions when possible (.Net 8+, C++ Dynamic Debugging)**: When selected, deoptimizes debugged functions for a more comprehensive debugging experience.
::: moniker-end

**Suppress JIT optimization on module load (Managed only)**:
Disables the JIT optimization of managed code when a module is loaded and JIT is compiled while the debugger is attached. Disabling optimization might make it easier to debug some problems, although at the expense of performance. If you're using Just My Code, suppressing JIT optimization can cause nonuser code to appear as user code ("My Code"). For more information, see [JIT optimization and debugging](../debugger/jit-optimization-and-debugging.md).

::: moniker range="visualstudio"
**Configure the use of precompiled images (Managed only)**:
When you select this link, the **Visual Studio Debugger Options** dialog opens. To enable the option, select the **Prevent using precompiled images on module load** checkbox, and select **OK**. When selected, disables the loading of NGEN or ready to load (RDR) precompiled images.
::: moniker-end

::: moniker range="vs-2022"
**Prevent using precompiled images on module load (Managed only, resets on restart)**: When selected, disables the loading of NGEN or ready to load (RDR) precompiled images.
::: moniker-end

::: moniker range="visualstudio"
**Configure Just-in-Time debugging**:
When you select this link, the **Visual Studio Debugger Options** dialog opens. To enable the option, select the **Enable Just-in-Time debugging for these types of code** checkbox. Select one or more code types: **Native** and **Managed (.NET Framework)**, and then select **OK**. This option enables Just-in-Time debugging for the selected code type(s).
::: moniker-end

**Step over properties and operators (Managed only)**:
Prevents the debugger from stepping into properties and operators in managed code.

**Enable property evaluation and other implicit function calls**:
Turns on automatic evaluation of properties and implicit function calls in variables windows and the **QuickWatch** dialog box.

- **Call string conversion function on objects in variables windows**:
    Executes an implicit string conversion call when evaluating objects in variables windows. The result is displayed as a string instead of the type name. Only applies while debugging in C# code. This setting can be overridden by the DebuggerDisplay attribute (see [Using the DebuggerDisplay attribute](../debugger/using-the-debuggerdisplay-attribute.md)).

**Enable source server support**:
Tells the Visual Studio debugger to get source files from source servers that implement the SrcSrv (`srcsrv.dll`) protocol. Team Foundation Server and the Debugging Tools for Windows are two source servers that implement the protocol. For more information about SrcSrv setup, see the [SrcSrv](/windows-hardware/drivers/debugger/srcsrv) documentation. In addition, see [Specify symbol (.pdb) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).

> [!IMPORTANT]
> Because reading *.pdb* files can execute arbitrary code in the files, make sure that you trust the server.

- **Print source server diagnostic messages to the Output window**:
    When source server support is enabled, this setting turns on diagnostic display.

- **Allow source server for partial trust assemblies (Managed only)**:
    When source server support is enabled, this setting overrides the default behavior of not retrieving sources for partial trust assemblies.

- **Always run untrusted source server commands without prompting**:
    When source server support is enabled, this setting overrides the default behavior of prompting when running an untrusted command.

**Enable Source Link support**:
    Tells the Visual Studio debugger to download source files for *.pdb* files that contain Source Link information. For more information about Source Link, see the [Source link specification](/dotnet/standard/library-guidance/sourcelink).

> [!IMPORTANT]
> Because Source Link downloads files by using http or https, make sure you trust the *.pdb* file.

- **Fall back to Git Credential Manager authentication for all Source Link requests**:
    When Source Link support is enabled, and a Source Link request fails authentication, Visual Studio then calls the Git Credential Manager.

**Highlight entire source line for breakpoints and current statement (C++ only)**:
When the debugger highlights a breakpoint or current statement, it highlights the entire line.

**Require source files to exactly match the original version**:
Tells the debugger to verify that a source file matches the version of the source code used to build the executable you're debugging. When the version doesn't match, you're prompted to find a matching source. If a matching source isn't found, the source code isn't displayed during debugging.

**Redirect all Output window text to the Immediate window**:
Sends all debugger messages that would ordinarily appear in the **Output** window to the **Immediate** window instead.

**Show raw structure of objects in variables windows**:
Turns off all object structure view customizations. For more information about view customizations, see [Create custom views of managed objects](../debugger/create-custom-views-of-managed-objects.md).

::: moniker range="visualstudio"
**Enable JavaScript debugging for ASP.NET (Chrome and Edge)**:
Enables the script debugger for ASP.NET apps. On first use in Chrome, you might need to sign into the browser to enable Chrome extensions that you have installed. Disable this option to revert to legacy behavior.
::: moniker-end

::: moniker range="<=vs-2022"
**Enable JavaScript debugging for ASP.NET (Chrome, Edge and IE)**:
Enables the script debugger for ASP.NET apps. On first use in Chrome, you might need to sign into the browser to enable Chrome extensions that you have installed. Disable this option to revert to legacy behavior.
::: moniker-end

::: moniker range="<=vs-2019"
**Enable using the multi-target JavaScript debugger for debugging JavaScript in applicable targets (requires debugging restart)**
Enables connection to the browser and back-end simultaneously, allowing you to debug your code running in the client and server right from the editor.
::: moniker-end

**Load dll exports (Native only)**:
Loads dll export tables. Symbol information from dll export tables can be useful if you're working with Windows messages, Windows procedures (WindowProcs), COM objects, or marshaling, or any dll for which you don't have symbols. Reading dll export information involves some overhead. Therefore, this capability is turned off by default.

   - To see what symbols are available in the export table of a dll, use `dumpbin /exports`. Symbols are available for any 32-bit system dll. By reading the `dumpbin /exports` output, you can see the exact function name, including nonalphanumeric characters. This is useful for setting a breakpoint on a function. Function names from dll export tables might appear truncated elsewhere in the debugger. The calls are listed in the calling order, with the current function (the most deeply nested) at the top. For more information, see [dumpbin /exports](/cpp/build/reference/dash-exports).

::: moniker range="<=vs-2019"
**Show parallel stacks diagram bottom-up**:
Controls the direction in which stacks are displayed in the **Parallel Stacks** window.
::: moniker-end

**Ignore GPU memory access exceptions if the data written didn't change the value**:
Ignores race conditions that were detected during debugging if the data didn't change. For more information, see [Debugging GPU Code](../debugger/debugging-gpu-code.md).

::: moniker range="<= vs-2019"
**Use Managed Compatibility Mode**:
Replaces the default debugging engine with a legacy version to enable these scenarios:

- You're using a .NET language other than C#, Visual Basic, or F# that provides its own Expression Evaluator (this includes C++/CLI).

- You want to enable Edit and Continue for C++ projects during mixed mode debugging.

> [!NOTE]
> Choosing Managed Compatibility mode disables some features that are implemented only in the default debugging engine. The legacy debugging engine was replaced in Visual Studio 2012.
::: moniker-end

**Warn when using custom debugger visualizers against potentially unsafe processes (Managed only)**:
Visual Studio warns you when you're using a custom debugger visualizer that's running code in the debugged process, because it could be running unsafe code.

**Enable Windows debug heap allocator (Native only)**:
Enables the windows debug heap to improve heap diagnostics. Enabling this option impacts debugging performance.

::: moniker range="vs-2019"
**Enable UI Debugging Tools for XAML**:
The Live Visual Tree and the Live Property Explore windows appear when you start debugging (**F5**) a supported project type. For more information, see [Inspect XAML properties while debugging](../xaml-tools/inspect-xaml-properties-while-debugging.md).

- **Preview selected elements in Live Visual Tree**:
    The XAML element whose context is selected is also selected in the **Live Visual Tree** window.

- **Show runtime tools in application**:
    Shows the **Live Visual Tree** commands in a toolbar on the main window of the XAML application that's being debugged.

- **Enable XAML Hot Reload**:
    Allows you to use the XAML Hot Reload feature with XAML code when your app is running. (This feature was previously called "XAML Edit and Continue")

- **Enable Just My XAML**:
    Starting in Visual Studio 2019 version 16.4, the **Live Visual Tree** by default shows only XAML that is classified as user code. If you disable this option, all generated XAML code is shown in the tool.

- **Turn off selection mode when an element is selected**:
    Starting in Visual Studio 2019 version 16.4, the in-app toolbar element selector button (**Enable selection**) switches off when an element is selected. If you disable this option, element selection stays on until you click the in-app toolbar button again.

- **Apply XAML Hot Reload on document save**:
    Starting in Visual Studio 2019 version 16.6, applies XAML Hot Reload when you save your document.
::: moniker-end

**Enable Diagnostic Tools while debugging**:
The **Diagnostic Tools** window appears while you're debugging.

**Show elapsed time PerfTip while debugging**:
The code window displays the elapsed time of a given method call when you're debugging.

::: moniker range="vs-2022" 
**Enable Hot Reload**:
Enables the Hot Reload functionality while debugging.

- **Automatically apply changes on continue (Native only)**:
    Visual Studio automatically compiles and applies any outstanding code changes you have made when continuing the process from a break state. If not selected, you can choose to apply changes using the **Apply Code Changes** item under the **Debug** menu.

- **Warn about stale code (Native only)**:
    Get warnings about stale code.
::: moniker-end

::: moniker range="vs-2019" 
**Enable Edit and Continue**:
Enables the Edit and Continue functionality while debugging.

- **Enable Native Edit and Continue**:
    You can use the Edit and Continue functionality while debugging native C++ code. For more information, see [Edit and Continue (C++)](../debugger/edit-and-continue-visual-cpp.md).

- **Apply changes on continue (Native only)**:
    Visual Studio automatically compiles and applies any outstanding code changes you have made when continuing the process from a break state. If not selected, you can choose to apply changes using the **Apply Code Changes** item under the **Debug** menu.

- **Warn about stale code (Native only)**:
    Get warnings about stale code.
::: moniker-end

::: moniker range=">=vs-2022" 
**Show Run To Click button while debugging**:
When this option is selected, the [Run to Click](../debugger/debugger-feature-tour.md#run-to-a-point-in-your-code-quickly-using-the-mouse) button is shown while debugging.
::: moniker-end

::: moniker range="vs-2019" 
**Show Run to Click button in editor while debugging**:
When this option is selected, the [Run to Click](../debugger/debugger-feature-tour.md#run-to-a-point-in-your-code-quickly-using-the-mouse) button is shown while debugging.
::: moniker-end

**Automatically close the console when debugging stops**:
Tells Visual Studio to close the console at the end of a debugging session.

::: moniker range=">= vs-2019"
**Enable fast expression evaluation (Managed only)**:
Allows the debugger to attempt faster evaluation by simulating execution of simple properties and methods.

**Load debug symbols in external process (Native only)**:
Enables this [memory optimization](https://devblogs.microsoft.com/cppblog/out-of-process-debugger-for-c-in-visual-studio-2019/) while debugging.

**Bring Visual Studio to the foreground when breaking in the debugger**:
Switches Visual Studio to the foreground when you pause in the debugger.
::: moniker-end

::: moniker range=">= vs-2022"
**Keep expanded data tips open until clicked away**:
When this option is selected, an expanded data tip stays expanded until you click away from it.

**Enable the External Sources node in Solution Explorer**: When selected, shows decompiled code under the External Sources node.

**Automatically decompile to source when needed (Managed only)**: When selected, automatically decompiles external .NET code when stepping into external code.

**Highlight current statement and statements with breakpoints**:
When the debugger highlights a breakpoint or current statement, it highlights the entire line.

**Show variable values inline in editor while debugging**:
Display the values for variables in the highlighted statement in the debugger.
::: moniker-end

::: moniker range="visualstudio"
- **Show return values inline**:
Display the return values for the highlighted statement in the debugger.

- **Show function argument values inline**:
Display the values for function arguments in the highlighted statement in the debugger.

- **Show current line expression values inline**:
Display the values for expressions within the current line in the debugger.
::: moniker-end

## Options available in older versions of Visual Studio

If you're using an older version of Visual Studio, some other options might be present.

**Enable Edge Developer Tools for UWP JavaScript Apps (Experimental)**:
Enables developer tools for UWP JavaScript apps in Microsoft Edge.

**Enable legacy Chrome JavaScript debugger for ASP.NET**:
Enables the legacy Chrome JavaScript script debugger for ASP.NET apps. On first use in Chrome, you might need to sign into the browser to enable Chrome extensions that you have installed.

**Enable the exception assistant**:
For managed code, enables the exception assistant. Starting in Visual Studio 2017, the Exception Helper replaced the exception assistant.

**Unwind the call stack on unhandled exceptions**:
Causes the **Call Stack** window to roll back the call stack to the point before the unhandled exception occurred.

**Use experimental way to launch Chrome JavaScript debugging when running Visual Studio as Administrator**:
Tells Visual Studio to try a new way to launch Chrome during JavaScript debugging.

**Warn if no symbols on launch (native only)**:
Displays a warning dialog box when you debug a program for which the debugger has no symbol information.

**Warn if script debugging is disabled on launch**:
Displays a warning dialog box when the debugger is launched with script debugging disabled.

::: moniker range="vs-2019"
**Use Managed Compatibility Mode**:
When this option is selected, the debugger uses the Visual Studio 2010 managed debugger, which was required when you debug C++/CLI code.

**Use Native Compatibility Mode**:
When this option is selected, the debugger uses the Visual Studio 2010 native debugger instead of the new native debugger.

- Use this option when you're debugging .NET C++ code, because the new debugging engine doesn't support evaluating .NET C++ expressions. However, enabling Native Compatibility Mode disables many features that depend on the current debugger implementation to operate. For example, the legacy engine lacks many visualizers for built-in types like `std::string` in Visual Studio 2015 projects. Use Visual Studio 2013 projects for the optimal debugging experience in these cases.
::: moniker-end

## See also

- [Debugging in Visual Studio](../debugger/index.yml)
- [First look at the debugger](../debugger/debugger-feature-tour.md)
