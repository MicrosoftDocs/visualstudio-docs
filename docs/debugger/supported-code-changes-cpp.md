---
title: "Supported Code Changes (C++)"
description: Understand what code changes are supported when you're using the Hot Reload feature while debugging a C++ project in Visual Studio.
ms.date: "04/28/2026"
ms.topic: concept-article
dev_langs:
  - "C++"
helpviewer_keywords:
  - "Edit and Continue, limitations"
  - "supported code changes"
  - "object files, limitations of Edit and Continue"
  - "C++ language, supported code changes"
  - "coding, supported code changes"
  - "resource files, limitations of Edit and Continue"
  - "code changes, handling in Edit and Continue"
  - "what's new [C++], supported code changes"
  - "code changes"
author: nitinme
ms.author: nitinme

ms.subservice: debug-diagnostics
---
# Supported Code Changes (C++)

The Hot Reload mechanism, previously called Edit and Continue, handles most types of code changes. However, some changes can't be applied during program execution. To apply these changes, you must stop execution and build a fresh version of the code.

See [Hot Reload (C++)](../debugger/edit-and-continue-visual-cpp.md) for information about working with Hot Reload for C++ in Visual Studio.

## <a name="BKMK_Requirements"></a> Requirements

### Build settings (Project > Properties)

- **C/C++ > General > Debug Information Format**: Program Database for Edit and Continue (`/ZI`)
- **Linker > General > Enable Incremental Linking**: Yes (`/INCREMENTAL`)

   Any incompatible linker settings (such as `/SAFESEH`, or `/OPT:`...) can cause the warning _LNK4075_ during build.
   Example: `LINK : warning LNK4075: ignoring '/INCREMENTAL' due to '/OPT:ICF' specification`

### Debugger settings (Debug > Options)

:::moniker range="visualstudio"

Open the **Debug** (or **Tools**) > **Options** pane, and expand the **All Settings** > **Debugging** > **.NET/C++ Hot Reload** section.

:::moniker-end
:::moniker range="vs-2022"

Open the **Debug** (or **Tools**) > **Options** dialog, and expand the **Debugging** > **.NET/C++ Hot Reload** section.

:::moniker-end
:::moniker range=">=vs-2022"

Select one or all of the following options to enable the feature:

- **Enable Hot Reload**: Enables Hot Reload when starting with the debugger attached (**F5**).

- **Enable Hot Reload when starting without debugging**: Enables Hot Reload when starting _without_ the debugger attached (**Ctrl** + **F5**).

- **Enable Hot Reload on File Save**: Enables Hot Reload when the file is saved.

- **Logging verbosity**: Set the level of logging when Hot Reload is enabled. Choose from **Minimal** (default), **Detailed**, or **Diagnostic**.

Altering these settings affects all projects you work on. You don't need to rebuild your application after changing a setting. If you build your application from the command line or from a makefile, but you debug in the Visual Studio environment, you can still use Edit and Continue if you set the `/ZI` option.

:::moniker-end


## <a name="BKMK_Unsupported_changes"></a> Unsupported changes

The following C/C++ changes can't be applied during a debugging session. If you make any of these changes and then try to apply code changes, an error or warning message appears in the **Output** window.

- Most changes to global or static data.

- Changes to executables that are copied from another machine and not built locally.

- Changes to a data type that affect the layout of an object, such as data members of a class.

- Adding more than 64k bytes of new code or data.

- Adding variables that require a constructor at a point before the instruction pointer.

- Changes that affect code that requires run-time initialization.

- Adding exception handlers, in some instances.

- Changes to resource files.

- Changes to code in read-only files.

- Changes to code without a corresponding PDB file.

- Changes to code that has no object file.

- Modifying lambdas in the following scenarios:

   - When lambdas have a static or global member.
   - When you pass lambdas to an `std::function`. This method causes a genuine ODR violation and results in C1092.

- Hot Reload doesn't update static libraries. If you make a change in a static library, execution continues with the old version and no warning is issued.

## <a name="BKMK_Unsupported_scenarios"></a> Unsupported scenarios

Hot Reload for C/C++ is unavailable in the following debugging scenarios:

- Debugging native apps compiled with [/Zo (Enhance Optimized Debugging)](/cpp/build/reference/zo-enhance-optimized-debugging)

- Projects that use the MSVC v120 toolset and the C/C++ `/bigobj` switch. Edit and Continue with `/bigobj` is only supported in the MSVC v140 and later build tools.

- Mixed-mode (native/managed) debugging.

- JavaScript debugging.

- SQL debugging.

- Debugging a dump file.

- Editing code after an unhandled exception, when the **Unwind the call stack on unhandled exceptions** option isn't selected.

- Debugging an app by using **Attach to** instead of running the app by choosing **Start** on the **Debug** menu.

- Debugging optimized code.

- Debugging an old version of your code after a new version failed to build because of build errors.

- Using a custom compiler (*cl.exe*) path. For security reasons, for recompilation of a file during Hot Reload, Visual Studio always uses the installed compiler. If you're using a custom compiler path (for example, through a custom `$(ExecutablePath)` variable in your `*.props` file), a warning is displayed and Visual Studio falls back to using the installed compiler of the same version/architecture.

- Legacy Architectures/MSVC toolsets. With the MSVC v140 toolset, the default debugger supports Hot Reload with both X86 and X64 applications. Legacy toolsets support only X86 applications. Toolsets older than MSVC v120 should use the legacy debugger by checking "_Debug > Options > General >_ Use Native Compatibility Mode" in order to use Edit and Continue.


## <a name="BKMK_IDL_attribute_limitations"></a> IDL attribute limitations

Hot Reload doesn't regenerate interface definition language (IDL) files. Therefore, changes to IDL attributes aren't reflected while you're debugging. To see the result of changes to IDL attributes, you must stop debugging and rebuild your app. Hot Reload doesn't generate an error or warning if IDL attributes have changed. For more information, see [IDL Attributes](/cpp/windows/idl-attributes).

## <a name="BKMK_Diagnosing_issues"></a> Diagnosing issues

If your scenario doesn't fit any of the conditions mentioned above, you can gather further details by setting the following DWORD registry value:

1. Open a Developer Command Prompt.

1. Run the following command: 

    ::: moniker range=">=vs-2022" 
     `VsRegEdit.exe set “C:\Program Files\Microsoft Visual Studio\[Version]\[YOUR EDITION]” HKCU Debugger NativeEncDiagnosticLoggingLevel DWORD 1`
    ::: moniker-end


Setting this value at the start of a debug session causes the various components of Hot Reload to spew verbose logging to the **Output Window** > **Debug** pane.

## Related content

- [Hot Reload (C++)](../debugger/edit-and-continue-visual-cpp.md)
- [Configure Hot Reload](../debugger/how-to-enable-and-disable-edit-and-continue.md)
