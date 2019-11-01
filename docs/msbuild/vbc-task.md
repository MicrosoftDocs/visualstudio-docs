---
title: "Vbc Task | Microsoft Docs"
ms.date: "04/12/2018"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#Vbc"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "Vbc task [MSBuild]"
  - "MSBuild, Vbc task"
ms.assetid: 595278b1-2782-4577-b1ba-b4b5ab5625a3
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---

# Vbc task
Wraps *vbc.exe*, which produces executables (*.exe*), dynamic-link libraries (*.dll*), or code modules (*.netmodule*). For more information on *vbc.exe*, see [Visual Basic command-line compiler](/dotnet/visual-basic/reference/command-line-compiler/index).

## Parameters
 The following table describes the parameters of the `Vbc` task.

| Parameter | Description |
|------------------------------| - |
| `AdditionalLibPaths` | Optional `String[]` parameter.<br /><br /> Specifies additional folders in which to look for assemblies specified in the References attribute. |
| `AddModules` | Optional `String[]` parameter.<br /><br /> Causes the compiler to make all type information from the specified file(s) available to the project you are currently compiling. This parameter corresponds to the [-addmodule](/dotnet/visual-basic/reference/command-line-compiler/addmodule) switch of the *vbc.exe* compiler. |
| `BaseAddress` | Optional `String` parameter.<br /><br /> Specifies the base address of the DLL. This parameter corresponds to the [-baseaddress](/dotnet/visual-basic/reference/command-line-compiler/baseaddress) switch of the *vbc.exe* compiler. |
| `CodePage` | Optional `Int32` parameter.<br /><br /> Specifies the code page to use for all source code files in the compilation. This parameter corresponds to the [-codepage](/dotnet/visual-basic/reference/command-line-compiler/codepage) switch of the *vbc.exe* compiler. |
| `DebugType` | Optional `String[]` parameter.<br /><br /> Causes the compiler to generate debugging information. This parameter can have the following values:<br /><br /> -   `full`<br />-   `pdbonly`<br /><br /> The default value is `full`, which enables attaching a debugger to the running program. A value of `pdbonly` allows source code debugging when the program is started in the debugger, but displays assembly language code only when the running program is attached to the debugger. For more information, see [-debug (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/debug). |
| `DefineConstants` | Optional `String[]` parameter.<br /><br /> Defines conditional compiler constants. Symbol/value pairs are separated by semicolons and are specified with the following syntax:<br /><br /> *symbol1* `=` *value1* `;` *symbol2* `=` *value2*<br /><br /> This parameter corresponds to the [-define](/dotnet/visual-basic/reference/command-line-compiler/define) switch of the *vbc.exe* compiler. |
| `DelaySign` | Optional `Boolean` parameter.<br /><br /> If `true`, the task places the public key in the assembly. If `false`, the task fully signs the assembly. The default value is `false`.This parameter has no effect unless used with the `KeyFile` parameter or the `KeyContainer` parameter. This parameter corresponds to the [-delaysign](/dotnet/visual-basic/reference/command-line-compiler/delaysign) switch of the *vbc.exe* compiler. |
| `Deterministic` | Optional `Boolean` parameter.<br/><br/> If `true`, causes the compiler to output an assembly whose binary content is identical across compilations if inputs are identical.<br/><br/>For more information, see [-deterministic](/dotnet/visual-basic/reference/command-line-compiler/deterministic). |
| `DisabledWarnings` | Optional `String` parameter.<br /><br /> Suppresses the specified warnings. You only need to specify the numeric part of the warning identifier. Multiple warnings are separated by semicolons. This parameter corresponds to the [-nowarn](/dotnet/visual-basic/reference/command-line-compiler/nowarn) switch of the *vbc.exe* compiler. |
| `DocumentationFile` | Optional `String` parameter.<br /><br /> Processes documentation comments to the specified XML file. This parameter overrides the `GenerateDocumentation` attribute. For more information, see [-doc](/dotnet/visual-basic/reference/command-line-compiler/doc). |
| `EmitDebugInformation` | Optional `Boolean` parameter.<br /><br /> If `true`, the task generates debugging information and places it in a *.pdb* file. For more information, see [-debug (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/debug). |
| `ErrorReport` | Optional `String` parameter.<br /><br /> Specifies how the task should report internal compiler errors. This parameter can have the following values:<br /><br /> -   `prompt`<br />-   `send`<br />-   `none`<br /><br /> If `prompt` is specified and an internal compiler error occurs, the user is prompted with an option of whether to send the error data to Microsoft.<br /><br /> If `send` is specified and an internal compiler error occurs, the task sends the error data to Microsoft.<br /><br /> The default value is `none`, which reports errors in text output only.<br /><br /> This parameter corresponds to the [-errorreport](/dotnet/visual-basic/reference/command-line-compiler/errorreport) switch of the *vbc.exe* compiler. |
| `FileAlignment` | Optional `Int32` parameter.<br /><br /> Specifies, in bytes, where to align the sections of the output file. This parameter can have the following values:<br /><br /> -   `512`<br />-   `1024`<br />-   `2048`<br />-   `4096`<br />-   `8192`<br /><br /> This parameter corresponds to the [-filealign](/dotnet/visual-basic/reference/command-line-compiler/filealign) switch of the *vbc.exe* compiler. |
| `GenerateDocumentation` | Optional `Boolean` parameter.<br /><br /> If `true`, generates documentation information and places it in an XML file with the name of the executable file or library that the task is creating. For more information, see [-doc](/dotnet/visual-basic/reference/command-line-compiler/doc). |
| `Imports` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Imports namespaces from the specified item collections. This parameter corresponds to the [-imports](/dotnet/visual-basic/reference/command-line-compiler/imports) switch of the *vbc.exe* compiler. |
| `KeyContainer` | Optional `String` parameter.<br /><br /> Specifies the name of the cryptographic key container. This parameter corresponds to the [-keycontainer](/dotnet/visual-basic/reference/command-line-compiler/keycontainer) switch of the *vbc.exe* compiler. |
| `KeyFile` | Optional `String` parameter.<br /><br /> Specifies the file name containing the cryptographic key. For more information, see [-keyfile](/dotnet/visual-basic/reference/command-line-compiler/keyfile). |
| `LangVersion` | Optional <xref:System.String?displayProperty=fullName> parameter.<br /><br /> Specifies the [language version](/dotnet/visual-basic/language-reference/configure-language-version), such as "15.5". |
| `LinkResources` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Creates a link to a .NET Framework resource in the output file; the resource file is not placed in the output file. This parameter corresponds to the [-linkresource](/dotnet/visual-basic/reference/command-line-compiler/linkresource) switch of the *vbc.exe* compiler. |
| `MainEntryPoint` | Optional `String` parameter.<br /><br /> Specifies the class or module that contains the `Sub Main` procedure. This parameter corresponds to the [-main](/dotnet/visual-basic/reference/command-line-compiler/main) switch of the *vbc.exe* compiler. |
| `ModuleAssemblyName` | Optional `String` parameter.<br /><br /> Specifies the assembly that this module is a part of. |
| `NoConfig` | Optional `Boolean` parameter.<br /><br /> Specifies that the compiler should not use the *vbc.rsp* file. This parameter corresponds to the [-noconfig](/dotnet/visual-basic/reference/command-line-compiler/noconfig) parameter of the *vbc.exe* compiler. |
| `NoLogo` | Optional `Boolean` parameter.<br /><br /> If `true`, suppresses display of compiler banner information. This parameter corresponds to the [-nologo](/dotnet/visual-basic/reference/command-line-compiler/nologo) switch of the *vbc.exe* compiler. |
| `NoStandardLib` | Optional `Boolean` parameter.<br /><br /> Causes the compiler not to reference the standard libraries. This parameter corresponds to the [-nostdlib](/dotnet/visual-basic/reference/command-line-compiler/nostdlib) switch of the *vbc.exe* compiler. |
| `NoVBRuntimeReference` | Optional `Boolean` parameter.<br /><br /> Internal use only. If true, prevents the automatic reference to *Microsoft.VisualBasic.dll*. |
| `NoWarnings` | Optional `Boolean` parameter.<br /><br /> If `true`, the task suppresses all warnings. For more information, see [-nowarn](/dotnet/visual-basic/reference/command-line-compiler/nowarn). |
| `Optimize` | Optional `Boolean` parameter.<br /><br /> If `true`, enables compiler optimizations. This parameter corresponds to the [-optimize](/dotnet/visual-basic/reference/command-line-compiler/optimize) switch of the *vbc.exe* compiler. |
| `OptionCompare` | Optional `String` parameter.<br /><br /> Specifies how string comparisons are made. This parameter can have the following values:<br /><br /> -   `binary`<br />-   `text`<br /><br /> The value `binary` specifies that the task uses binary string comparisons. The value `text` specifies that the task uses text string comparisons. The default value of this parameter is `binary`. This parameter corresponds to the [-optioncompare](/dotnet/visual-basic/reference/command-line-compiler/optioncompare) switch of the *vbc.exe* compiler. |
| `OptionExplicit` | Optional `Boolean` parameter.<br /><br /> If `true`, explicit declaration of variables is required. This parameter corresponds to the [-optionexplicit](/dotnet/visual-basic/reference/command-line-compiler/optionexplicit) switch of the *vbc.exe* compiler. |
| `OptionInfer` | Optional `Boolean` parameter.<br /><br /> If `true`, allows type inference of variables. |
| `OptionStrict` | Optional `Boolean` parameter.<br /><br /> If `true`, the task enforces strict type semantics to restrict implicit type conversions. This parameter corresponds to the [-optionstrict](/dotnet/visual-basic/reference/command-line-compiler/optionstrict) switch of the *vbc.exe* compiler. |
| `OptionStrictType` | Optional `String` parameter.<br /><br /> Specifies which strict type semantics generate a warning. Currently, only "custom" is supported. This parameter corresponds to the [-optionstrict](/dotnet/visual-basic/reference/command-line-compiler/optionstrict) switch of the *vbc.exe* compiler. |
| `OutputAssembly` | Optional `String` output parameter.<br /><br /> Specifies the name of the output file. This parameter corresponds to the [-out](/dotnet/visual-basic/reference/command-line-compiler/out) switch of the *vbc.exe* compiler. |
| `Platform` | Optional `String` parameter.<br /><br /> Specifies the processor platform to be targeted by the output file. This parameter can have a value of `x86`, `x64`, `Itanium`, or `anycpu`. Default is `anycpu`. This parameter corresponds to the [-platform](/dotnet/visual-basic/reference/command-line-compiler/platform) switch of the *vbc.exe* compiler. |
| `References` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Causes the task to import public type information from the specified items into the current project. This parameter corresponds to the [-reference](/dotnet/visual-basic/reference/command-line-compiler/reference) switch of the *vbc.exe* compiler. |
| `RemoveIntegerChecks` | Optional `Boolean` parameter.<br /><br /> If `true`, disables integer overflow error checks. The default value is `false`. This parameter corresponds to the [-removeintchecks](/dotnet/visual-basic/reference/command-line-compiler/removeintchecks) switch of the *vbc.exe* compiler. |
| `Resources` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Embeds a .NET Framework resource into the output file. This parameter corresponds to the [-resource](/dotnet/visual-basic/reference/command-line-compiler/resource) switch of the *vbc.exe* compiler. |
| `ResponseFiles` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the response file that contains commands for this task. This parameter corresponds to the [@ (Specify Response File)](/dotnet/visual-basic/reference/command-line-compiler/specify-response-file) option of the *vbc.exe* compiler. |
| `RootNamespace` | Optional `String` parameter.<br /><br /> Specifies the root namespace for all type declarations. This parameter corresponds to the [-rootnamespace](/dotnet/visual-basic/reference/command-line-compiler/rootnamespace) switch of the *vbc.exe* compiler. |
| `SdkPath` | Optional `String` parameter.<br /><br /> Specifies the location of *mscorlib.dll* and *microsoft.visualbasic.dll*. This parameter corresponds to the [-sdkpath](/dotnet/visual-basic/reference/command-line-compiler/sdkpath) switch of the *vbc.exe* compiler. |
| `Sources` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies one or more Visual Basic source files. |
| `TargetCompactFramework` | Optional `Boolean` parameter.<br /><br /> If `true`, the task targets the [!INCLUDE[Compact](../extensibility/includes/compact_md.md)]. This switch corresponds to the [-netcf](/dotnet/visual-basic/reference/command-line-compiler/netcf) switch of the *vbc.exe* compiler. |
| `TargetType` | Optional `String` parameter.<br /><br /> Specifies the file format of the output file. This parameter can have a value of `library`, which creates a code library, `exe`, which creates a console application, `module`, which creates a module, or `winexe`, which creates a Windows program. Default is `library`. This parameter corresponds to the [-target](/dotnet/visual-basic/reference/command-line-compiler/target) switch of the *vbc.exe* compiler. |
| `Timeout` | Optional `Int32` parameter.<br /><br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is `Int.MaxValue`, indicating that there is no time out period. |
| `ToolPath` | Optional `String` parameter.<br /><br /> Specifies the location from where the task will load the underlying executable file (*vbc.exe*). If this parameter is not specified, the task uses the SDK installation path corresponding to the version of the framework that is running [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)]. |
| `TreatWarningsAsErrors` | Optional `Boolean` parameter.<br /><br /> If `true`, all warnings are treated as errors. For more information, see [-warnaserror (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/warnaserror). |
| `UseHostCompilerIfAvailable` | Optional `Boolean` parameter.<br /><br /> Instructs the task to use the in-process compiler object, if available. Used only by [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. |
| `Utf8Output` | Optional `Boolean` parameter.<br /><br /> Logs compiler output using UTF-8 encoding. This parameter corresponds to the [-utf8output](/dotnet/visual-basic/reference/command-line-compiler/utf8output) switch of the *vbc.exe* compiler. |
| `Verbosity` | Optional `String` parameter.<br /><br /> Specifies the verbosity of the compiler's output. Verbosity can be `Quiet`, `Normal` (the default), or `Verbose`. |
| `WarningsAsErrors` | Optional `String` parameter.<br /><br /> Specifies a list of warnings to treat as errors. For more information, see [-warnaserror (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/warnaserror).<br /><br /> This parameter overrides the `TreatWarningsAsErrors` parameter. |
| `WarningsNotAsErrors` | Optional `String` parameter.<br /><br /> Specifies a list of warnings that are not treated as errors. For more information, see [-warnaserror (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/warnaserror).<br /><br /> This parameter is only useful if the `TreatWarningsAsErrors` parameter is set to `true`. |
| `Win32Icon` | Optional `String` parameter.<br /><br /> Inserts an *.ico* file in the assembly, which gives the output file the desired appearance in **File Explorer**. This parameter corresponds to the [-win32icon](/dotnet/visual-basic/reference/command-line-compiler/win32icon) switch of the *vbc.exe* compiler. |
| `Win32Resources` | Optional `String` parameter.<br /><br /> Inserts a Win32 resource (*.res*) file in the output file. This parameter corresponds to the [-win32resource](/dotnet/visual-basic/reference/command-line-compiler/win32resource) switch of the *vbc.exe* compiler. |

## Remarks
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension base class](../msbuild/tooltaskextension-base-class.md).

## Example
 The following example compiles a Visual Basic project.

```xml
<VBC
   Sources="@(sources)"
   Resources="strings.resources"
   Optimize="true"
   OutputAssembly="out.exe"/>
```

## See also
- [Visual Basic command-line compiler](/dotnet/visual-basic/reference/command-line-compiler/index)
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
