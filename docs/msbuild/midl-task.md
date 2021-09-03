---
title: MIDL Task | Microsoft Docs
description: Learn about the MSBuild MIDL task, which wraps the Microsoft Interface Definition Language (MIDL) compiler tool, midl.exe. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VC.Project.VCMidlTool.ServerStubFile
- VC.Project.VCMidlTool.ApplicationConfigurationMode
- VC.Project.VCMidlTool.GenerateServerFiles
- VC.Project.VCMidlTool.ClientStubFile
- VC.Project.VCMidlTool.LocaleID
- VC.Project.VCMidlTool.GenerateClientFiles
- VC.Project.VCMidlTool.SuppressCompilerWarnings
- VC.Project.VCMidlTool.TypeLibFormat
- vc.task.midl
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild (C++), MIDL task
- MIDL task (MSBuild (C++))
ms.assetid: 727efa8c-3336-40b8-8bef-ae6cbd77a422
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MIDL task

Wraps the Microsoft Interface Definition Language (MIDL) compiler tool, *midl.exe*. For more information, see [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

## Parameters

 The following describes the parameters of the **MIDL** task. Most task parameters, and a few sets of parameters, correspond to a command-line option.

- **AdditionalIncludeDirectories**

     Optional **String[]** parameter.

     Adds a directory to the list of directories that are searched for imported IDL files, included header files, and application configuration files (ACF).

     For more information, see the **/I** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **AdditionalOptions**

     Optional **String** parameter.

     A list of command-line options. For example, /\<option1> /\<option2> /\<option#>. Use this parameter to specify command-line options that are not represented by any other MIDL task parameter.

     For more information, see [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **ApplicationConfigurationMode**

     Optional **Boolean** parameter.

     If `true`, lets you use some ACF keywords in the IDL file.

     For more information, see the **/app_config** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **ClientStubFile**

     Optional **String** parameter.

     Specifies the name of the client stub file for an RPC interface.

     For more information, see the **/cstub** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference). Also see the **ServerStubFile** parameter in this table.

- **CPreprocessOptions**

     Optional **String** parameter.

     Specifies options to pass to the C/C++ preprocessor. Specify a space-delimited list of preprocessor options. Must contain the `/E` option.

     For more information, see the **/cpp_opt** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **DefaultCharType**

     Optional **String** parameter.

     Specifies the default character type that the C compiler will use to compile the generated code.

     Specify one of the following values, each of which corresponds to a command-line option.

    |Value|Command-line option|
    |-----------|--------------------------|
    |**Signed**|**/char signed**|
    |**Unsigned**|**/char unsigned**|
    |**Ascii**|**/char ascii7**|

     For more information, see the **/char** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **DllDataFileName**

     Optional **String** parameter.

     Specifies the file name for the generated *dlldata* file for a proxy DLL.

     For more information, see the **/dlldata** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **EnableErrorChecks**

     Optional **String** parameter.

     Specifies the type of error checking that the generated stubs will perform at run time.

     Specify one of the following values, each of which corresponds to a command-line option.

    |Value|Command-line option|
    |-----------|--------------------------|
    |**None**|**/error none**|
    |**EnableCustom**|**/error**|
    |**All**|**/error all**|

     For more information, see the **/error** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **ErrorCheckAllocations**

     Optional **Boolean** parameter.

     If `true`, check for out-of-memory errors.

     For more information, see the **/error allocation** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **ErrorCheckBounds**

     Optional **Boolean** parameter.

     If `true`, checks the size of conformant-varying and varying arrays against the transmission length specification.

     For more information, see the **/error bounds_check** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **ErrorCheckEnumRange**

     Optional **Boolean** parameter.

     If `true`, checks that enum values are in an allowable range.

     For more information, see the **/error enum** option in command-line help (**/?**) for *midl.exe*.

- **ErrorCheckRefPointers**

     Optional **Boolean** parameter.

     If `true`, check that no null reference pointers are passed to client stubs.

     For more information, see the **/error ref** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **ErrorCheckStubData**

     Optional **Boolean** parameter.

     If `true`, generates a stub that catches unmarshaling exceptions on the server side and propagates them back to the client.

     For more information, see the **/error stub_data** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **GenerateClientFiles**

     Optional **String** parameter.

     Specifies whether the compiler generates client-side C source files for an RPC interface.

     Specify one of the following values, each of which corresponds to a command-line option.

    |Value|Command-line option|
    |-----------|--------------------------|
    |**None**|**/client none**|
    |**Stub**|**/client stub**|

     For more information, see the **/client** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **GenerateServerFiles**

     Optional **String** parameter.

     Specifies whether the compiler generates server-side C source files for an RPC interface.

     Specify one of the following values, each of which corresponds to a command-line option.

    |Value|Command-line option|
    |-----------|--------------------------|
    |**None**|**/server none**|
    |**Stub**|**/server stub**|

     For more information, see the **/server** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **GenerateStublessProxies**

     Optional **Boolean** parameter.

     If `true`, generates fully interpreted stubs together with stubless proxies for object interfaces.

     For more information, see the **/Oicf** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **GenerateTypeLibrary**

     Optional **Boolean** parameter.

     If `true`, a type library (*.tlb*) file is not generated.

     For more information, see the **/notlb** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **HeaderFileName**

     Optional **String** parameter.

     Specifies the name of the generated header file.

     For more information, see the **/h** or **/header** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **IgnoreStandardIncludePath**

     Optional **Boolean** parameter.

     If `true`, the MIDL task searches only the directories specified by using the **AdditionalIncludeDirectories** switch, and ignores the current directory and the directories specified by the INCLUDE environment variable.

     For more information, see the **/no_def_idir** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **InterfaceIdentifierFileName**

     Optional **String** parameter.

     Specifies the name of the *interface identifier file* for a COM interface. This overrides the default name obtained by adding "_i.c" to the IDL file name.

     For more information, see the **/iid** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **LocaleID**

     Optional **int** parameter.

     Specifies the *locale identifier* that enables the use of international characters in input files, file names, and directory paths. Specify a decimal locale identifier.

     For more information, see the **/lcid** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference). Also see [Locale identifiers](/windows/desktop/intl/locale-identifiers).

- **MkTypLibCompatible**

     Optional **Boolean** parameter.

     If `true`, requires the format of the input file to be compatible with *mktyplib.exe* version 2.03.

     For more information, see the **/mktyplib203** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference). Also, see [ODL file syntax](/previous-versions/windows/desktop/automat/odl-file-syntax) on the MSDN website.

- **OutputDirectory**

     Optional **String** parameter.

     Specifies the default directory where the MIDL task writes output files.

     For more information, see the **/out** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **PreprocessorDefinitions**

     Optional **String[]** parameter.

     Specifies one or more *defines*; that is, a name and an optional value to be passed to the C preprocessor as if by a `#define` directive. The form of each define is, *name[=value]*.

     For more information, see the **/D** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference). Also, see the **UndefinePreprocessorDefinitions** parameter in this table.

- **ProxyFileName**

     Optional **String** parameter.

     Specifies the name of the interface proxy file for a COM interface.

     For more information, see the **/proxy** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **RedirectOutputAndErrors**

     Optional **String** parameter.

     Redirects output, such as error messages and warnings, from standard output to the specified file.

     For more information, see the **/o** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **ServerStubFile**

     Optional **String** parameter.

     Specifies the name of the server stub file for an RPC interface.

     For more information, see the **/sstub** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference). Also, see the **ClientStubFile** parameter in this table.

- **Source**

     Required `ITaskItem[]` parameter.

     Specifies a list of source files separated by spaces.

- **StructMemberAlignment**

     Optional **String** parameter.

     Specifies the alignment (*packing level*) of structures in the target system.

     Specify one of the following values, each of which corresponds to a command-line option.

    |Value|Command-line option|
    |-----------|--------------------------|
    |**NotSet**|*\<none>*|
    |**1**|**/Zp1**|
    |**2**|**/Zp2**|
    |**4**|**/Zp4**|
    |**8**|**/Zp8**|

     For more information, see the **/Zp** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference). The **/Zp** option is equivalent to the **/pack** option and the older **/align** option.

- **SuppressCompilerWarnings**

     Optional **Boolean** parameter.

     If `true`, suppresses warning messages from the MIDL task.

     For more information, see the **/no_warn** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **SuppressStartupBanner**

     Optional `Boolean` parameter.

     If `true`, prevents the display of the copyright and version number message when the task starts.

     For more information, see the **/nologo** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **TargetEnvironment**

     Optional **String** parameter.

     Specifies the environment in which the application runs.

     Specify one of the following values, each of which corresponds to a command-line option.

    |Value|Command-line option|
    |-----------|--------------------------|
    |**NotSet**|*\<none>*|
    |**Win32**|**/env win32**|
    |**Itanium**|**/env ia64**|
    |**X64**|**/env x64**|

     For more information, see the **/env** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **TrackerLogDirectory**

     Optional `String` parameter.

     Specifies the intermediate directory where tracking logs for this task are stored.

- **TypeLibFormat**

     Optional **String** parameter.

     Specifies the format of the type library file.

     Specify one of the following values, each of which corresponds to a command-line option.

    |Value|Command-line option|
    |-----------|--------------------------|
    |**NewFormat**|**/newtlb**|
    |**OldFormat**|**/oldtlb**|

     For more information, see the **/newtlb** and **/oldtlb** options in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **TypeLibraryName**

     Optional **String** parameter.

     Specifies the name of the type library file.

     For more information, see the **/tlb** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **UndefinePreprocessorDefinitions**

     Optional **String[]** parameter.

     Removes any previous definition of a name by passing the name to the C preprocessor as if by a `#undefine` directive. Specify one or more previously defined names.

     For more information, see the **/U** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference). Also, see the **PreprocessorDefinitions** parameter in this table.

- **ValidateAllParameters**

     Optional `Boolean` parameter.

     If `true`, generates additional error-checking information that is used to perform integrity checks at run time. If `false`, the error-checking information is not generated.

     For more information, see the **/robust** and **/no_robust** options in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference).

- **WarnAsError**

     Optional `Boolean` parameter.

     If `true`, treats all warnings as errors.

     If the **WarningLevel** MIDL task parameter is not specified, warnings at the default level, level 1, are treated as errors.

     For more information, see the **/WX** options in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference). Also, see the **WarningLevel** parameter in this table.

- **WarningLevel**

     Optional **String** parameter.

     Specifies the severity (*warning level*) of warnings to emit. No warning is emitted for a value of 0. Otherwise, a warning is emitted if its warning level is numerically less than or equal to the specified value.

     Specify one of the following values, each of which corresponds to a command-line option.

    |Value|Command-line option|
    |-----------|--------------------------|
    |**0**|**/W0**|
    |**1**|**/W1**|
    |**2**|**/W2**|
    |**3**|**/W3**|
    |**4**|**/W4**|

     For more information, see the **/W** option in [MIDL command-line reference](/windows/desktop/Midl/midl-command-line-reference). Also, see the **WarnAsError** parameter in this table.

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
