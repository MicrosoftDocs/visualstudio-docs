---
title: Csc Task | Microsoft Docs
description: This article describes the MSBuild Csc task, which wraps the C# compiler, csc.exe, and produces .exe, .dll, or .netmodule files.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Csc
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- Csc task [MSBuild]
- MSBuild, Csc task
ms.assetid: d8c19b36-f5ca-484b-afa6-8ff3b90e103a
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Csc task

Wraps *csc.exe*, and produces executables (*.exe* files), dynamic-link libraries (*.dll* files), or code modules (*.netmodule* files). For more information about *csc.exe*, see [C# compiler options](/dotnet/csharp/language-reference/compiler-options/index).

## Parameters

The following table describes the parameters of the `Csc` task.

| Parameter | Description |
|------------------------------| - |
| `AdditionalLibPaths` | Optional `String[]` parameter.<br /><br /> Specifies additional directories to search for references. For more information, see [-lib (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/lib-compiler-option). |
| `AddModules` | Optional `String` parameter.<br /><br /> Specifies one or more modules to be part of the assembly. For more information, see [-addmodule (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/addmodule-compiler-option). |
| `AllowUnsafeBlocks` | Optional `Boolean` parameter.<br /><br /> If `true`, compiles code that uses the [unsafe](/dotnet/csharp/language-reference/keywords/unsafe) keyword. For more information, see [-unsafe (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/unsafe-compiler-option). |
| `ApplicationConfiguration` | Optional `String` parameter.<br /><br /> Specifies the application configuration file containing the assembly binding settings. |
| `BaseAddress` | Optional `String` parameter.<br /><br /> Specifies the preferred base address at which to load a DLL. The default base address for a DLL is set by the .NET Framework common language runtime. For more information, see [-baseaddress (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/baseaddress-compiler-option). |
| `CheckForOverflowUnderflow` | Optional `Boolean` parameter.<br /><br /> Specifies whether integer arithmetic that overflows the bounds of the data type causes an exception at run time. For more information, see [-checked (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/checked-compiler-option). |
| `CodePage` | Optional `Int32` parameter.<br /><br /> Specifies the code page to use for all source code files in the compilation. For more information, see [-codepage (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/codepage-compiler-option). |
| `DebugType` | Optional `String` parameter.<br /><br /> Specifies the debug type. `DebugType` can be `full` or `pdbonly`. The default is `full`, which enables a debugger to be attached to a running program. Specifying `pdbonly` enables source code debugging when the program is started in the debugger, but only displays assembler when the running program is attached to the debugger.<br /><br /> This parameter overrides the `EmitDebugInformation` parameter.<br /><br /> For more information, see [-debug (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/debug-compiler-option). |
| `DefineConstants` | Optional `String` parameter.<br /><br /> Defines preprocessor symbols. For more information, see [-define (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/define-compiler-option). |
| `DelaySign` | Optional `Boolean` parameter.<br /><br /> If `true`, specifies that you only want to place the public key in the assembly. If `false`, specifies that you want a fully signed assembly<br /><br /> This parameter has no effect unless used with either the `KeyFile` or `KeyContainer` parameter.<br /><br /> For more information, see [-delaysign (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/delaysign-compiler-option). |
| `Deterministic` | Optional `Boolean` parameter.<br/><br/> If `true`, causes the compiler to output an assembly whose binary content is identical across compilations if inputs are identical.<br/><br/>For more information, see [-deterministic (C# Compiler options)](/dotnet/csharp/language-reference/compiler-options/deterministic-compiler-option). |
| `DisabledWarnings` | Optional `String` parameter.<br /><br /> Specifies the list of warnings to be disabled. For more information, see [-nowarn (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/nowarn-compiler-option). |
| `DocumentationFile` | Optional `String` parameter.<br /><br /> Processes documentation comments to an XML file. For more information, see [-doc (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/doc-compiler-option). |
| `EmbedAllSources` | Optional `Boolean` parameter.<br /><br /> Embed all source files in the PDB. For more information, see [-embed (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/listed-alphabetically) |
| `EmitDebugInformation` | Optional `Boolean` parameter.<br /><br /> If `true`, the task generates debugging information and places it in a program database (.pdb) file. If `false`, the task emits no debug information. Default is `false`. For more information, see [-debug (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/debug-compiler-option). |
| `ErrorReport` | Optional `String` parameter.<br /><br /> Provides a convenient way to report a C# internal error to Microsoft. This parameter can have a value of `prompt`, `send`, or `none`. If the parameter is set to `prompt`, you will receive a prompt when an internal compiler error occurs. The prompt lets you send a bug report electronically to Microsoft. If the parameter is set to `send`, a bug report is sent automatically. If the parameter is set to `none`, the error is reported only in the text output of the compiler. Default is `none`. For more information, see [-errorreport (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/errorreport-compiler-option). |
| `FileAlignment` | Optional `Int32` parameter.<br /><br /> Specifies the size of sections in the output file. For more information, see [-filealign (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/filealign-compiler-option). |
| `GenerateFullPaths` | Optional `Boolean` parameter.<br /><br /> If `true`, specifies the absolute path to the file in the compiler output. If `false`, specifies the name of the file. Default is `false`. For more information, see [-fullpaths (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/fullpaths-compiler-option). |
| `KeyContainer` | Optional `String` parameter.<br /><br /> Specifies the name of the cryptographic key container. For more information, see [-keycontainer (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/keycontainer-compiler-option). |
| `KeyFile` | Optional `String` parameter.<br /><br /> Specifies the file name containing the cryptographic key. For more information, see [-keyfile (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/keyfile-compiler-option). |
| `LangVersion` | Optional `String` parameter.<br /><br /> Specifies the version of the language to use. For more information, see [-langversion (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/langversion-compiler-option). |
| `LinkResources` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Creates a link to a .NET Framework resource in the output file; the resource file is not placed in the output file.<br /><br /> Items passed into this parameter can have optional metadata entries named `LogicalName` and `Access`. `LogicalName` corresponds to the `identifier` parameter of the `/linkresource` switch, and `Access` corresponds to `accessibility-modifier` parameter. For more information, see [-linkresource (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/linkresource-compiler-option). |
| `MainEntryPoint` | Optional `String` parameter.<br /><br /> Specifies the location of the `Main` method. For more information, see [-main (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/main-compiler-option). |
| `ModuleAssemblyName` | Optional `String` parameter.<br /><br /> Specifies the name of the assembly that this module will be a part of. |
| `NoConfig` | Optional `Boolean` parameter.<br /><br /> If `true`, tells the compiler not to compile with the *csc.rsp* file. For more information, see [-noconfig (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/noconfig-compiler-option). |
| `NoLogo` | Optional `Boolean` parameter.<br /><br /> If `true`, suppresses display of compiler banner information. For more information, see [-nologo (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/miscellaneous#nologo). |
| `NoStandardLib` | Optional `Boolean` parameter.<br /><br /> If `true`, prevents the import of *mscorlib.dll*, which defines the entire System namespace. Use this parameter if you want to define or create your own System namespace and objects. For more information, see [-nostdlib (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/nostdlib-compiler-option). |
| `NoWin32Manifest` | Optional `Boolean` parameter.<br /><br /> If `true`, do not include the default Win32 manifest. |
| `Optimize` | Optional `Boolean` parameter.<br /><br /> If `true`, enables optimizations. If `false`, disables optimizations. For more information, see [-optimize (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/optimize-compiler-option). |
| `OutputAssembly` | Optional `String` output parameter.<br /><br /> Specifies the name of the output file. For more information, see [-out (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/out-compiler-option). |
| `OutputRefAssembly` | Optional `String` parameter.<br /><br /> Specifies the name of the output reference assembly file. For more information, see [-refout (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/refout-compiler-option). |
| `PdbFile` | Optional `String` parameter.<br /><br /> Specifies the debug information file name. The default name is the output file name with a *.pdb* extension. |
| `Platform` | Optional `String` parameter.<br /><br /> Specifies the processor platform to be targeted by the output file. This parameter can have a value of `x86`, `x64`, or `anycpu`. Default is `anycpu`. For more information, see [-platform (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/platform-compiler-option). |
| `References` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Causes the task to import public type information from the specified items into the current project. For more information, see [-reference (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/reference-compiler-option).<br /><br /> You can specify a C# reference alias in an MSBuild file by adding the metadata `Aliases` to the original "Reference" item. For example, to set the alias "LS1" in the following Csc command line:<br /><br /> `CSC /r:LS1=MyCodeLibrary.dll /r:LS2=MyCodeLibrary2.dll *.cs`<br /><br /> you would use:<br /><br /> `<Reference Include="MyCodeLibrary"> <Aliases>LS1</Aliases> </Reference>` |
| `Resources` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Embeds a .NET Framework resource into the output file.<br /><br /> Items passed into this parameter can have optional metadata entries named `LogicalName` and `Access`. `LogicalName` corresponds to the `identifier` parameter of the `/resource` switch, and `Access` corresponds to `accessibility-modifier` parameter. For more information, see [-resource (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/resource-compiler-option). |
| `ResponseFiles` | Optional `String` parameter.<br /><br /> Specifies the response file that contains commands for this task. For more information, see [@ (Specify response file)](/dotnet/csharp/language-reference/compiler-options/response-file-compiler-option). |
| `Sources` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies one or more C# source files. |
| `TargetType` | Optional `String` parameter.<br /><br /> Specifies the file format of the output file. This parameter can have a value of `library`, which creates a code library, `exe`, which creates a console application, `module`, which creates a module, or `winexe`, which creates a Windows program. The default value is `library`. For more information, see [-target (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/target-compiler-option). |
| `TreatWarningsAsErrors` | Optional `Boolean` parameter.<br /><br /> If `true`, treats all warnings as errors. For more information, see [-warnaserror (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/warnaserror-compiler-option). |
| `UseHostCompilerIfAvailable` | Optional `Boolean` parameter.<br /><br /> Instructs the task to use the in-process compiler object, if available. Used only by Visual Studio. |
| `Utf8Output` | Optional `Boolean` parameter.<br /><br /> Logs compiler output using UTF-8 encoding. For more information, see [-utf8output (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/utf8output-compiler-option). |
| `WarningLevel` | Optional `Int32` parameter.<br /><br /> Specifies the warning level for the compiler to display. For more information, see [-warn (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/warn-compiler-option). |
| `WarningsAsErrors` | Optional `String` parameter.<br /><br /> Specifies a list of warnings to treat as errors. For more information, see [-warnaserror (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/warnaserror-compiler-option).<br /><br /> This parameter overrides the `TreatWarningsAsErrors` parameter. |
| `WarningsNotAsErrors` | Optional `String` parameter.<br /><br /> Specifies a list of warnings that are not treated as errors. For more information, see [-warnaserror (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/warnaserror-compiler-option).<br /><br /> This parameter is only useful if the `TreatWarningsAsErrors` parameter is set to `true`. |
| `Win32Icon` | Optional `String` parameter.<br /><br /> Inserts an *.ico* file in the assembly, which gives the output file the desired appearance in **File Explorer**. For more information, see [-win32icon (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/win32icon-compiler-option). |
| `Win32Manifest` | Optional `String` parameter.<br /><br /> Specifies the Win32 manifest to be included. |
| `Win32Resource` | Optional `String` parameter.<br /><br /> Inserts a Win32 resource (*.res*) file in the output file. For more information, see [-win32res (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/win32res-compiler-option). |

[!INCLUDE [ToolTaskExtension arguments](includes/tooltaskextension-base-params.md)]

## Example

The following example uses the `Csc` task to compile an executable from the source files in the `Compile` item collection.

```xml
<CSC
    Sources="@(Compile)"
    OutputAssembly="$(AppName).exe"
    EmitDebugInformation="true" />
```

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)
