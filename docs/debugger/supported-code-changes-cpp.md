---
title: "Supported Code Changes (C++)"
description: Understand what code changes are supported when you are using the Edit and Continue feature while debugging a C++ project in Visual Studio.
ms.date: "02/18/2020"
ms.topic: "conceptual"
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
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Supported Code Changes (C++)

Edit and Continue for C++ projects handles most types of code changes. However, some changes cannot be applied during program execution. To apply these changes, you must stop execution and build a fresh version of the code.

 See [Edit and Continue (C++)](../debugger/edit-and-continue-visual-cpp.md) for information about working with Edit and Continue for C++ in Visual Studio.

## <a name="BKMK_Requirements"></a> Requirements
### Build settings (Project > Properties):
  1. **C/C++ > General > Debug Information Format**: Program Database for Edit and Continue (`/ZI`)
  1. **Linker > General > Enable Incremental Linking**: Yes (`/INCREMENTAL`)

     Any incompatible linker settings (such as `/SAFESEH`, or `/OPT:`...) should cause warning _LNK4075_ during build.  
     Example: `LINK : warning LNK4075: ignoring '/INCREMENTAL' due to '/OPT:ICF' specification`

### Debugger settings (Debug > Options > General):
  - Enable Native Edit and Continue

     Any incompatible compiler or linker settings cause an error during Edit and Continue.  
     Example: `Edit and Continue : error  : ‘file.cpp’ in ‘MyApp.exe’ was not compiled with Edit and Continue enabled. Ensure that the file is compiled with the Program Database for Edit and Continue (/ZI) option.`

## <a name="BKMK_Unsupported_changes"></a> Unsupported changes
 The following C/C++ changes cannot be applied during a debugging session. If you make any of these changes and then try to apply code changes, an error or warning message appears in the **Output** window.

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

* Modifying lambdas which:
  - Have a static or global member.
  - Are passed to a std::function. This causes a genuine ODR violation and results in C1092.

- Edit and Continue does not update static libraries. If you make a change in a static library, execution continues with the old version and no warning is issued.

## <a name="BKMK_Unsupported_scenarios"></a> Unsupported scenarios
 Edit and Continue for C/C++ is unavailable in the following debugging scenarios:

- Debugging native apps compiled with [/Zo (Enhance Optimized Debugging)](/cpp/build/reference/zo-enhance-optimized-debugging)

- Projects that use the VC 120 toolset and the C/C++ `/bigobj` switch. Edit and Continue with `/bigobj` is only supported in the VC 140 toolset.

- Mixed-mode (native/managed) debugging.

- JavaScript debugging.

- SQL debugging.

- Debugging a dump file.

- Editing code after an unhandled exception, when the **Unwind the call stack on unhandled exceptions** option is not selected.

- Debugging an app by using **Attach to** instead of running the app by choosing **Start** on the **Debug** menu.

- Debugging optimized code.

- Debugging an old version of your code after a new version failed to build because of build errors.

- Using a custom compiler (*cl.exe*) path. For security reasons, for recompilation of a file during Edit and Continue, Visual Studio always uses the installed compiler. If you are using a custom compiler path (for example, through a custom `$(ExecutablePath)` variable in your `*.props` file), a warning is displayed and Visual Studio falls back to using the installed compiler of the same version/architecture.

- Legacy Architectures/VC Toolsets. With the VC 140 toolset, the default debugger supports Edit and Continue with both X86 and X64 applications. Legacy toolsets support only X86 applications. Toolsets older than VC 120 should use the legacy debugger by checking “_Debug > Options > General >_ Use Native Compatibility Mode” in order to use Edit and Continue.

## <a name="BKMK_Linking_limitations"></a> Linking limitations

### <a name="BKMK_Linker_options_that_disable_Edit_and_Continue"></a> Linker options that disable Edit and Continue
 The following linker options disable Edit and Continue:

- Setting **/OPT:REF**, **/OPT:ICF**, or **/INCREMENTAL:NO** disables Edit and Continue with the following warning:  
     `LINK : warning LNK4075: ignoring /EDITANDCONTINUE due to /OPT specification`

- Setting **/ORDER**, **/RELEASE**, or **/FORCE** disables Edit and Continue with the following warning:  
     `LINK : warning LNK4075: ignoring /INCREMENTAL due to /option specification`

- Setting any option that prevents the creation of a program database (.pdb) file disables Edit and Continue with no specific warning.

### <a name="BKMK_Auto_relinking_limitations"></a> Auto relinking limitations
 By default, Edit and Continue relinks your program at the end of a debugging session to create an up-to-date executable.

 Edit and Continue cannot relink your program if you are debugging it from a location other than the original build location. A message tells you that you need to rebuild manually.

 Edit and Continue does not rebuild static libraries. If you make changes to a static library using Edit and Continue, you need to manually rebuild the library and relink apps using it.

 Edit and Continue does not invoke custom build steps. If your program uses custom build steps, you might want to rebuild manually so that custom build steps can be invoked. In that case, you can disable relinking after Edit and Continue to ensure that you are prompted to manually rebuild.

 **To disable relinking after Edit and Continue**

1. On the **Debug** menu, choose **Options and Settings**.

2. In the **Options** dialog box, under the **Debugging** node, and select the **Edit and Continue** node.

3. Clear the **Relink code changes after debugging** check box.

## <a name="BKMK_Precompiled_header_limitations"></a> Precompiled header limitations
 By default, Edit and Continue loads and processes precompiled headers in the background to speed up processing of code changes. Loading precompiled headers requires allocation of physical memory, which can be a problem if you are compiling on a machine with limited RAM. You can determine if this might be a problem by using the Windows Task Manager to determine the amount of available physical memory while you are debugging. If this amount is greater than the size of your precompiled headers, Edit and Continue should have no problem. If the amount is less than the size of your precompiled headers, you can prevent Edit and Continue from loading precompiled headers in the background.

 **To disable background loading of precompiled headers for Edit and Continue**

1. On the **Debug** menu, choose **Options and Settings**.

2. In the **Options** dialog box, under the **Debugging** node, and select the **Edit and Continue** node.

3. Clear the **Allow Precompiling** check box.

## <a name="BKMK_IDL_attribute_limitations"></a> IDL attribute limitations
 Edit and Continue does not regenerate interface definition language (IDL) files. Therefore, changes to IDL attributes will not be reflected while you are debugging. To see the result of changes to IDL attributes, you must stop debugging and rebuild your app. Edit and Continue does not generate an error or warning if IDL attributes have changed. For more information, see [IDL Attributes](/cpp/windows/idl-attributes).

## <a name="BKMK_Diagnosing_issues"></a> Diagnosing issues
 If your scenario does not fit any of the conditions mentioned above, you can gather further details by setting the following DWORD registry value:
 1. Open a Developer Command Prompt.
 2. Run the following command: 
    ::: moniker range=">=vs-2022" 
     `VsRegEdit.exe set “C:\Program Files\Microsoft Visual Studio\[Version]\[YOUR EDITION]” HKCU Debugger NativeEncDiagnosticLoggingLevel DWORD 1`
    ::: moniker-end
    ::: moniker range="vs-2019"
     `VsRegEdit.exe set “C:\Program Files (x86)\Microsoft Visual Studio\[Version]\[YOUR EDITION]” HKCU Debugger NativeEncDiagnosticLoggingLevel DWORD 1`
    ::: moniker-end

 Setting this value at the start of a debug session causes the various components of Edit and Continue to spew verbose logging to the **Output Window** > **Debug** pane.

## Related content

- [Edit and Continue (C++)](../debugger/edit-and-continue-visual-cpp.md)
- [Configure Edit and Continue](../debugger/how-to-enable-and-disable-edit-and-continue.md)
