---
title: "General, Debugging, Options Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.options.General"
  - "VS.ToolsOptionsPages.Debugger.General"
  - "VS.ToolsOptionsPages.Debugger.ENC"
  - "vs.debug.options.ENC"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
helpviewer_keywords: 
  - "Options dialog box, debugging"
ms.assetid: b33aee0b-43c3-4c26-8ed4-bc673f491503
caps.latest.revision: 50
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# General, Debugging, Options Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The**Tools / Options / Debugging / General** page lets you set the following options:  
  
 **Ask before deleting all breakpoints**  
 Requires confirmation before completing the **Delete All Breakpoints** command.  
  
 **Break all processes when one process breaks**  
 Simultaneously breaks all processes to which the debugger is attached, when a break occurs.  
  
 **Break when exceptions cross AppDomain or managed/native boundaries**  
 In managed or mixed-mode debugging, the common language runtime can catch exceptions that cross application domain boundaries or managed/native boundaries when the following conditions are true:  
  
 1\) When native code calls managed code by using COM Interop and the managed code throws an exception. See [Introduction to COM Interop](https://msdn.microsoft.com/library/8bd62e68-383d-407f-998b-29aa0ce0fd67).  
  
 2\) When managed code running in application domain 1 calls managed code in application domain 2, and the code in application domain 2 throws an exception. See [Programming with Application Domains](https://msdn.microsoft.com/bd36055b-56bd-43eb-b4d8-820c37172131).  
  
 3\) When code calls a function by using reflection, and the function throws an exception. See [Reflection](https://msdn.microsoft.com/library/d1a58e7f-fb39-4d50-bf84-e3b8f9bf9775).  
  
 In 2) and 3), the exception is sometimes caught by managed code in `mscorlib` instead of the common language runtime. This option does not affect breaking on exceptions caught by `mscorlib`.  
  
 **Enable address-level debugging**  
 Enables advanced features for debugging at the address level (the **Disassembly** window, the **Registers** window, and address breakpoints).  
  
 **Show disassembly if source is not available**  
 Automatically shows the **Disassembly** window when you try to debug code for which source is unavailable.  
  
 **Enable breakpoint filters**  
 Enables you to set filters on breakpoints so that they affect only specific processes, threads, or computers.  
  
 **Enable the exception assistant**  
 For managed code only. Managed exceptions open the  exception assistant dialog box.  See [Exception Assistant](https://msdn.microsoft.com/library/992892ac-9d52-44cc-bf09-b44bfc5befeb).  
  
 **Unwind the call stack on unhandled exceptions**  
 Causes the **Call Stack** window to roll back the call stack to the point before the unhandled exception occurred.  
  
 **Enable Just My Code**  
 The debugger displays and steps into user code ("My Code") only, ignoring system code and other code that is optimized or that does not have debugging symbols.  
  
 **Show all members for non-user objects in variables windows (Visual Basic only)**  
 Turns on display of non-public members in objects that are in non-user code (not "My Code").  
  
 **Warn if no user code on launch**  
 When debugging starts with Just My Code enabled, this option warns you if there is no user code ("My Code").  
  
 **Enable .NET Framework source stepping**  
 Allows the debugger to step into .NET Framework source. Enabling this option automatically disables Just My Code .NET Framework symbols will be downloaded to a cache location. You can change the cache location in the **Options** dialog box, **Debugging** category, **Symbols** page.  
  
 **Step over properties and operators (managed only)**  
 Prevents the debugger from stepping into properties and operators in managed code.  
  
 **Enable property evaluation and other implicit function calls**  
 Turns on automatic evaluation of properties and implicit function calls in variables windows and the **QuickWatch** dialog box.  
  
 **Call string conversion function on objects in variables windows (C# and JavaScript only)**  
 Executes an implicit string conversion call when evaluating objects in variables windows. Therefore, that result is displayed as a string instead of the type name. Only applies while debugging in C# code. This setting may be overridden by the DebuggerDisplay attribute (see [Using the DebuggerDisplay Attribute](../debugger/using-the-debuggerdisplay-attribute.md)).  
  
 **Enable source server support**  
 Tells the Visual Studio debugger to get source files from source servers that implement the SrcSrv (`srcsrv.dll`) protocol. Team Foundation Server and the Debugging Tools for Windows are two source servers that implement the protocol. For more information about SrcSrv setup, see the Debugging Tools for Windows documentation. In addition, see [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).  
  
> [!IMPORTANT]
> Because reading .pdb files can execute arbitrary code in the files, make sure that you trust the server.  
  
 **Print source server diagnostic messages to the Output window**  
 When source server support is enabled, this setting turns on diagnostic display.  
  
 **Allow source server for partial trust assemblies (Managed only)**  
 When source server support is enabled, this setting overrides the default behavior of not retrieving sources for partial trust assemblies.  
  
 **Highlight entire line for breakpoints and current statement**  
 When the debugger highlights a breakpoint or current statement, it highlights the entire line.  
  
 **Require source files to exactly match the original version**  
 Tells the debugger to verify that a source file matches the version of the source code used to build the executable you are debugging. If the version does not match, you’ll be prompted to find a matching source. If a matching source is not found, the source code will not be displayed during debugging.  
  
 **Redirect all Output window text to the Immediate window**  
 Sends all debugger messages that would ordinarily appear in the **Output** window to the **Immediate** window instead.  
  
 **Show raw structure of objects in variables windows**  
 Turns off all object structure view customizations. For more information about view customizations, see [Create custom views of managed objects](../debugger/create-custom-views-of-managed-objects.md).  
  
 **Suppress JIT optimization on module load (managed only)**  
 Disables the JIT optimization of managed code when a module is loaded and JIT is compiled while the debugger is attached. Disabling optimization may make it easier to debug some problems, although at the expense of performance. If you are using Just My Code, suppressing JIT optimization can cause non-user code to appear as user code ("My Code").  
  
 **Warn if no symbols on launch (native only)**  
 Displays a warning dialog box when you try to debug a program for which the debugger has no symbol information.  
  
 **Warn if script debugging is disabled on launch**  
 Displays a warning dialog box when the debugger is launched with script debugging disabled.  
  
 **Load dll exports**  
 Loads dll export tables. Symbol information from dll export tables can be useful if you are working with Windows messages, Windows procedures (WindowProcs), COM objects, or marshaling, or any dll for which you do not have symbols. Reading dll export information involves some overhead. Therefore, this capability is turned off by default.  
  
 To see what symbols are available in the export table of a dll, use `dumpbin /exports`. Symbols are available for any 32-bit system dll. By reading the `dumpbin /exports` output, you can see the exact function name, including non-alphanumeric characters. This is useful for setting a breakpoint on a function. Function names from dll export tables might appear truncated elsewhere in the debugger. The calls are listed in the calling order, with the current function (the most deeply nested) at the top. For more information, see [dump bin /exports](https://msdn.microsoft.com/library/2971ab7e-4ee6-478b-9c85-cda42a4ce1bf).  
  
 **Show parallel stacks diagram bottom-up**  
 Controls the direction in which stacks are displayed in the **Parallel Stacks** window.  
  
 **Ignore GPU memory access exceptions if the data written didn’t change the value**  
 Ignores race conditions that were detected during debugging if the data didn’t change. For more information, see [Debugging GPU Code](../debugger/debugging-gpu-code.md).  
  
 **Use Managed Compatibility Mode**  
 Replaces the default debugging engine with a legacy version to enable these scenarios:  
  
- You are using a .NET Framework language other than C#, VB, or F# that provides its own Expression Evaluator (this includes C++/CLI).  
  
- You want to enable Edit and Continue for C++ projects while mixed mode debugging.  
  
  Note that choosing Managed Compatibility mode disables some features that are implemented only in the default debugging engine.  
  
  **Use Native Compatibility Mode**  
  When this option is selected, the debugger uses the Visual Studio 2010 native debugger instead of the new native debugger.  
  
  You should use this option when you are debugging .NET C++ code, because the new debugging engine does not support evaluating .NET C++ expressions. However, enabling Native Compatibility Mode disables many features that depend on the current debugger implementation to operate. For example, the legacy engine lacks many visualizers for built-in types like `std::string` in Visual Studio 2015 projects.  Use Visual Studio 2013 projects for the optimal debugging experience in these cases.  
  
  **Use the legacy C# and VB expression evaluators**  
  The debugger will use the Visual Studio 2013 C#/VB expression evaluators instead of the Visual Studio 2015 Roslyn-based expression evaluators.  
  
  **Warn when using custom debugger visualizers against potentially unsafe processes (Managed only)**  
  Visual Studio warns you when you are using a custom debugger visualizer that is running code in the debuggee process, because it could be running unsafe code.  
  
  **Enable Windows debug heap allocator (Native only)**  
  Enables the windows debug heap to improve heap diagnostics. Enabling this option will impact debugging performance.  
  
  **Enable UI Debugging Tools for XAML**  
  The Live Visual Tree and the Live Property Explore windows will appear when you start debugging (F5) a supported project type. For more information, see [Inspect XAML properties while debugging](../debugger/inspect-xaml-properties-while-debugging.md).  
  
  **Preview selected elements in Live Visual Tree**  
  The XAML element whose context is selected is also selected in the **Live Visual Tree** window.  
  
  **Show runtime tools in application**  
  Shows the **Live Visual Tree** commands in a toolbar on the main window of the XAML application that is being debugged. This option was introduced in Visual Studio 2015 Update 2.  
  
  **Enable Diagnostic Tools while debugging**  
  The **Diagnostic Tools** window appears while you are debugging. For more information, see [Debugger-integrated profiling](/visualstudio/profiling/running-profiling-tools-with-or-without-the-debugger).  
  
  **Show elapsed time PerfTip while debugging**  
  The code window displays the elapsed time of a given method call when you are debugging.  
  
  **Enable Edit and Continue**  
  You can use the Edit and Continue functionality while debugging .  
  
  **Enable Native Edit and Continue**  
  You can use the Edit and Continue functionality while debugging native C++ code. For more information, see [Edit and Continue (Visual C++)](../debugger/edit-and-continue-visual-cpp.md).  
  
  **Apply changes on continue (Native only)**  
  Visual Studio automatically compiles and applies any outstanding code changes you have made when continuing the process from a break state. If not selected, you can choose to apply changes using the “Apply Code Changes” item under the Debug menu.  
  
  **Warn about stale code (Native only)**  
  Get warnings about stale code.  
  
  **Allow precompiling (Native only)**  
  Precompiling is allowed.  
  
## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)
