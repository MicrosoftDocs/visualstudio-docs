---
title: Common MSBuild Project Properties
description: Learn about common MSBuild project properties that can be defined or used in project files or included in .targets files that MSBuild provides.
ms.date: 4/17/2025
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
f1_keywords:
- "http://schemas.microsoft.com/developer/msbuild/2003#AdditionalLibPaths"
- "http://schemas.microsoft.com/developer/msbuild/2003#AddModules"
- "http://schemas.microsoft.com/developer/msbuild/2003#ALToolPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#ApplicationIcon"
- "http://schemas.microsoft.com/developer/msbuild/2003#ApplicationManifest"
- "http://schemas.microsoft.com/developer/msbuild/2003#AssemblyOriginatorKeyFile"
- "http://schemas.microsoft.com/developer/msbuild/2003#AssemblySearchPaths"
- "http://schemas.microsoft.com/developer/msbuild/2003#AssemblyName"
- "http://schemas.microsoft.com/developer/msbuild/2003#BaseAddress"
- "http://schemas.microsoft.com/developer/msbuild/2003#BaseIntermediateOutputPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#BaseOutputPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#BuildInParallel"
- "http://schemas.microsoft.com/developer/msbuild/2003#BuildProjectReferences"
- "http://schemas.microsoft.com/developer/msbuild/2003#CleanFile"
- "http://schemas.microsoft.com/developer/msbuild/2003#CodePage"
- "http://schemas.microsoft.com/developer/msbuild/2003#CompilerResponseFile"
- "http://schemas.microsoft.com/developer/msbuild/2003#Configuration"
- "http://schemas.microsoft.com/developer/msbuild/2003#CscToolPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#CustomAfterMicrosoftCommonTargets"
- "http://schemas.microsoft.com/developer/msbuild/2003#CustomBeforeMicrosoftCommonTargets"
- "http://schemas.microsoft.com/developer/msbuild/2003#DebugSymbols"
- "http://schemas.microsoft.com/developer/msbuild/2003#DebugType"
- "http://schemas.microsoft.com/developer/msbuild/2003#DefineConstants"
- "http://schemas.microsoft.com/developer/msbuild/2003#DefineDebug"
- "http://schemas.microsoft.com/developer/msbuild/2003#DefineTrace"
- "http://schemas.microsoft.com/developer/msbuild/2003#DelaySign"
- "http://schemas.microsoft.com/developer/msbuild/2003#Deterministic"
- "http://schemas.microsoft.com/developer/msbuild/2003#DirectoryBuildPropsPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#DirectoryBuildTargetsPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#DisableFastUpToDateCheck"
- "http://schemas.microsoft.com/developer/msbuild/2003#DocumentationFile"
- "http://schemas.microsoft.com/developer/msbuild/2003#ErrorReport"
- "http://schemas.microsoft.com/developer/msbuild/2003#ExcludeDeploymentUrl"
- "http://schemas.microsoft.com/developer/msbuild/2003#FileAlignment"
- "http://schemas.microsoft.com/developer/msbuild/2003#FrameworkPathOverride"
- "http://schemas.microsoft.com/developer/msbuild/2003#GenerateDocumentation"
- "http://schemas.microsoft.com/developer/msbuild/2003#GenerateFullPaths"
- "http://schemas.microsoft.com/developer/msbuild/2003#GenerateSerializationAssemblies"
- "http://schemas.microsoft.com/developer/msbuild/2003#ImportDirectoryBuildProps"
- "http://schemas.microsoft.com/developer/msbuild/2003#ImportDirectoryBuildTargets"
- "http://schemas.microsoft.com/developer/msbuild/2003#IntermediateOutputPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#KeyContainerName"
- "http://schemas.microsoft.com/developer/msbuild/2003#KeyOriginatorFile"
- "http://schemas.microsoft.com/developer/msbuild/2003#ModuleAssemblyName"
- "http://schemas.microsoft.com/developer/msbuild/2003#MSBuildProjectExtensionsPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#MSBuildTreatWarningsAsErrors"
- "http://schemas.microsoft.com/developer/msbuild/2003#MSBuildWarningsAsErrors"
- "http://schemas.microsoft.com/developer/msbuild/2003#MSBuildWarningsAsMessages"
- "http://schemas.microsoft.com/developer/msbuild/2003#NoLogo"
- "http://schemas.microsoft.com/developer/msbuild/2003#NoStdLib"
- "http://schemas.microsoft.com/developer/msbuild/2003#NoVBRuntimeReference"
- "http://schemas.microsoft.com/developer/msbuild/2003#NoWarn"
- "http://schemas.microsoft.com/developer/msbuild/2003#NoWin32Manifest"
- "http://schemas.microsoft.com/developer/msbuild/2003#Optimize"
- "http://schemas.microsoft.com/developer/msbuild/2003#OptionCompare"
- "http://schemas.microsoft.com/developer/msbuild/2003#OptionExplicit"
- "http://schemas.microsoft.com/developer/msbuild/2003#OptionInfer"
- "http://schemas.microsoft.com/developer/msbuild/2003#OptionStrict"
- "http://schemas.microsoft.com/developer/msbuild/2003#OutDir"
- "http://schemas.microsoft.com/developer/msbuild/2003#OutputPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#OutputType"
- "http://schemas.microsoft.com/developer/msbuild/2003#OverwriteReadOnlyFiles"
- "http://schemas.microsoft.com/developer/msbuild/2003#PathMap"
- "http://schemas.microsoft.com/developer/msbuild/2003#PdbFile"
- "http://schemas.microsoft.com/developer/msbuild/2003#Platform"
- "http://schemas.microsoft.com/developer/msbuild/2003#ProcessorArchitecture"
- "http://schemas.microsoft.com/developer/msbuild/2003#ProduceOnlyReferenceAssembly"
- "http://schemas.microsoft.com/developer/msbuild/2003#ProduceReferenceAssembly"
- "http://schemas.microsoft.com/developer/msbuild/2003#RegisterAssemblyMSBuildArchitecture"
- "http://schemas.microsoft.com/developer/msbuild/2003#RegisterForCOMInterop"
- "http://schemas.microsoft.com/developer/msbuild/2003#RemoveIntegerChecks"
- "http://schemas.microsoft.com/developer/msbuild/2003#RootNamespace"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_AlgorithmId"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_BaseAddress"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_CompanyName"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_Configuration"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_Description"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_EvidenceFile"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_FileVersion"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_Flags"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_GenerateFullPaths"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_LinkResource"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_MainEntryPoint"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_ProductName"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_ProductVersion"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_TargetType"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_Title"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_Trademark"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_Version"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_Win32Icon"
- "http://schemas.microsoft.com/developer/msbuild/2003#Satellite_Win32Resource"
- "http://schemas.microsoft.com/developer/msbuild/2003#SGenToolPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#SGenUseProxyTypes"
- "http://schemas.microsoft.com/developer/msbuild/2003#SkipInvalidConfigurations"
- "http://schemas.microsoft.com/developer/msbuild/2003#StartupObject"
- "http://schemas.microsoft.com/developer/msbuild/2003#SubsystemVersion"
- "http://schemas.microsoft.com/developer/msbuild/2003#TargetCompactFramework"
- "http://schemas.microsoft.com/developer/msbuild/2003#TargetFrameworkVersion"
- "http://schemas.microsoft.com/developer/msbuild/2003#TreatWarningsAsErrors"
- "http://schemas.microsoft.com/developer/msbuild/2003#UseCommonOutputDirectory"
- "http://schemas.microsoft.com/developer/msbuild/2003#UseHostCompilerIfAvailable"
- "http://schemas.microsoft.com/developer/msbuild/2003#Utf8Output"
- "http://schemas.microsoft.com/developer/msbuild/2003#VbcToolPath"
- "http://schemas.microsoft.com/developer/msbuild/2003#VbcVerbosity"
- "http://schemas.microsoft.com/developer/msbuild/2003#VisualStudioVersion"
- "http://schemas.microsoft.com/developer/msbuild/2003#WarningsAsErrors"
- "http://schemas.microsoft.com/developer/msbuild/2003#WarningLevel"
- "http://schemas.microsoft.com/developer/msbuild/2003#WarningsNotAsErrors"
- "http://schemas.microsoft.com/developer/msbuild/2003#Win32Manifest"
- "http://schemas.microsoft.com/developer/msbuild/2003#Win32Resource"
helpviewer_keywords:
- msbuild, common properties
- msbuild, project file properties
- ExcludeDeploymentUrl property
- project file properties (MSBuild)
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Common MSBuild project properties

The following table lists frequently used properties that are defined in the Visual Studio project files or included in `.targets` files that MSBuild provides.

Properties provided by the .NET SDK are documented at [MSBuild reference for Microsoft.Net.Sdk](/dotnet/core/project-sdk/msbuild-props).

Project files in Visual Studio (`.csproj`, `.vbproj`, `.vcxproj`, and others) contain MSBuild XML code that runs when you build a project by using the IDE. Projects typically import one or more `.targets` files to define their build process. For more information, see [MSBuild .targets files](../msbuild/msbuild-dot-targets-files.md).

When setting property values, keep in mind that common properties may be set, reset, or used in a number of imported files. Therefore, it matters where you set a property--in your project file, in *Directory.Build.props*, or in another imported file. If you're setting a property somewhere and not getting the expected result, consider where and how the property is changed or used in all the files imported by your project, including imports that are added implicitly when you're using the `Sdk` attribute. See [Choose between adding properties to a .props or .targets file](customize-your-build.md#choose-between-adding-properties-to-a-props-or-targets-file). Preprocessing can help with this (see the `/preprocess` or `/pp` command-line option at [MSBuild command-line reference](./msbuild-command-line-reference.md)).

## List of common properties and parameters

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| AdditionalLibPaths | .NET | Specifies additional folders in which compilers should look for reference assemblies. |
| AddModules | .NET | Causes the compiler to make all type information from the specified files available to the project you're compiling. This property is equivalent to the `/addModules` compiler switch. |
| ALToolPath | .NET | The path to *AL.exe*. This property overrides the current version of *AL.exe* to enable use of a different version. |
| ApplicationIcon | .NET | The `.ico` icon file to pass to the compiler for embedding as a Win32 icon. The property is equivalent to the `/win32icon` compiler switch. |
| ApplicationManifest | All | Specifies the path of the file that is used to generate external User Account Control (UAC) manifest information. Applies only to Visual Studio projects targeting Windows Vista.<br /><br /> In most cases, the manifest is embedded. However, if you use Registration Free COM or ClickOnce deployment, then the manifest can be an external file that is installed together with your application assemblies. For more information, see the NoWin32Manifest property in this article. |
| AssemblyOriginatorKeyFile | .NET | Specifies the file used to sign the assembly (`.snk` or `.pfx`) and that's passed to the [ResolveKeySource task](../msbuild/resolvekeysource-task.md) to generate the actual key used to sign the assembly. |
| AssemblySearchPaths | .NET | A list of locations to search during build-time reference assembly resolution. The order in which paths appear in this list is meaningful because paths listed earlier take precedence over later entries. |
| AssemblyName | .NET | The name of the final output assembly after the project is built. |

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| BaseAddress | .NET | Specifies the base address of the main output assembly. This property is equivalent to the `/baseaddress` compiler switch. |
| BaseIntermediateOutputPath | All | The top-level folder where all configuration-specific intermediate output folders are created. The default value is `obj\`. The following code is an example: `<BaseIntermediateOutputPath>c:\xyz\obj\</BaseIntermediateOutputPath>` |
| BaseOutputPath | All | Specifies the base path for the output file. If it's set, MSBuild uses `OutputPath = $(BaseOutputPath)\$(Configuration)\`. Example syntax: `<BaseOutputPath>c:\xyz\bin\</BaseOutputPath>` |
| BuildInParallel | All | A boolean value that indicates whether project references are built or cleaned in parallel when Multi-Proc MSBuild is used. The default value is `true`, which means that projects will be built in parallel if the system has multiple cores or processors. |
| BuildProjectReferences | All | A boolean value that indicates whether project references are built by MSBuild. Automatically set to `false` if you're building your project in the Visual Studio integrated development environment (IDE), `true` if otherwise. `-p:BuildProjectReferences=false` can be specified on the command line to avoid checking that referenced projects are up to date. |

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| CleanFile | All | The name of the file that will be used as the "clean cache." The clean cache is a list of generated files to be deleted during the cleaning operation. The file is put in the intermediate output path by the build process.<br /><br /> This property specifies only file names that don't have path information. |
| CodePage | .NET | Specifies the code page to use for all source-code files in the compilation. This property is equivalent to the `/codepage` compiler switch. |
| CompilerResponseFile | .NET | An optional response file that can be passed to the compiler tasks. |
| Configuration | All | The configuration that you're building, generally `Debug` or `Release`, but configurable at the solution and project levels. |
| CscToolPath | C# | The path of *csc.exe*, the C# compiler. |
| CustomAfterMicrosoftCommonTargets | All | The name of a project file or targets file that is to be imported automatically after the common targets import. |
| CustomBeforeMicrosoftCommonTargets | All | The name of a project file or targets file that is to be imported automatically before the common targets import. |

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| DebugSymbols | All | A boolean value that indicates whether symbols are generated by the build.<br /><br /> Setting **-p:DebugSymbols=false** on the command line disables generation of program database (`.pdb`) symbol files. |
| DebugType | All | Defines the level of debug information that you want generated. Valid values are `full`, `pdbonly`, `portable`, `embedded`, and `none`. |
| DefineConstants | .NET | Defines conditional compiler constants. Symbol/value pairs are separated by semicolons and are specified by using language-dependent syntax:<br /><br /> C#: `symbol1; symbol2`<br /><br /> Visual Basic: `symbol1 = value1, symbol2 = value2`<br /><br />  The property is equivalent to the `/define` compiler switch. |
| DefineDebug | All |  A boolean value that indicates whether you want the DEBUG constant defined. |
| DefineTrace | All | A boolean value that indicates whether you want the TRACE constant defined. |
| DelaySign | .NET | A boolean value that indicates whether you want to delay-sign the assembly rather than full-sign it. |
| Deterministic | .NET | A boolean value that indicates whether the compiler should produce identical assemblies for identical inputs. This parameter corresponds to the `/deterministic` switch of the compilers. |
| DirectoryBuildPropsPath | All | Specifies the path to the *Directory.Build.props* file; if defined, this property overrides the default search algorithm. See [Customize your build](customize-your-build.md#choose-between-adding-properties-to-a-props-or-targets-file). |
| DirectoryBuildTargetsPath| All | Specifies the path to the *Directory.Build.targets* file; if defined, this property overrides the default search algorithm. See [Customize your build](customize-your-build.md#choose-between-adding-properties-to-a-props-or-targets-file). |
| DisableFastUpToDateCheck | All | A boolean value that applies to Visual Studio only. The Visual Studio build manager uses a process called FastUpToDateCheck to determine whether a project must be rebuilt to be up to date. This process is faster than using MSBuild to determine this. Setting the DisableFastUpToDateCheck property to `true` lets you bypass the Visual Studio build manager and force it to use MSBuild to determine whether the project is up to date. |
| DocumentationFile | .NET | The name of the file that is generated as the XML documentation file. This name includes only the file name and has no path information. |

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| ErrorReport | .NET | Specifies how the compiler task should report internal compiler errors. Valid values are `prompt`, `send`, or `none`. This property is equivalent to the `/errorreport` compiler switch. |
| ExcludeDeploymentUrl | .NET | The [GenerateDeploymentManifest task](../msbuild/generatedeploymentmanifest-task.md) adds a  deploymentProvider tag to the deployment manifest if the project file includes any of the following elements:<br /><br /> -   UpdateUrl<br />-   InstallUrl<br />-   PublishUrl<br /><br /> Using ExcludeDeploymentUrl, however, you can prevent the deploymentProvider tag from being added to the deployment manifest even if any of the above URLs are specified. To do this, add the following property to your project file:<br /><br /> `<ExcludeDeploymentUrl>true</ExcludeDeploymentUrl>` <br /><br />**Note:**  ExcludeDeploymentUrl isn't exposed in the Visual Studio IDE and can be set only by manually editing the project file. Setting this property doesn't affect publishing within Visual Studio; that is, the deploymentProvider tag will still be added to the URL specified by PublishUrl. |
| FileAlignment | .NET | Specifies, in bytes, where to align the sections of the output file. Valid values are 512, 1024, 2048, 4096, 8192. This property is equivalent to the `/filealignment` compiler switch. |
| FrameworkPathOverride | Visual Basic | Specifies the location of *mscorlib.dll* and *microsoft.visualbasic.dll*. This parameter is equivalent to the `/sdkpath` switch of the *vbc.exe* compiler. |
| GenerateDocumentationFile | .NET | A boolean parameter that indicates whether documentation is generated by the build. If `true`, the build generates documentation information and puts it in an `.xml` file together with the name of the executable file or library that the build task created. |
| GenerateFullPaths | C# | Generate full paths for filenames in output by using the [`-fullpaths`](/dotnet/csharp/language-reference/compiler-options/fullpaths-compiler-option) compiler option. |
| GenerateResourceUsePreserializedResources | .NET | When MSBuild reads `.resx` files and generates `.resources` files, indicates whether to use the preserialized resources instead of deserializing and then reserializing each resource (for backward compatibility with .NET Framework). |
| GenerateSerializationAssemblies | .NET | Indicates whether XML serialization assemblies should be generated by *SGen.exe*, which can be set to on, auto, or off. This property is used for assemblies that target .NET Framework only. To generate XML serialization assemblies for .NET Standard or .NET Core assemblies, reference the *Microsoft.XmlSerializer.Generator* NuGet package. |

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| ImportDirectoryBuildProps | All | A boolean value that indicates whether to import a *Directory.Build.props* file. See [Customize your build](customize-your-build.md#choose-between-adding-properties-to-a-props-or-targets-file).|
| ImportDirectoryBuildTargets | All | A boolean value that indicates whether to import a *Directory.Build.targets* file. See [Customize your build](customize-your-build.md#choose-between-adding-properties-to-a-props-or-targets-file). |
| IntermediateOutputPath | All | The full intermediate output path as derived from `BaseIntermediateOutputPath`, if no path is specified. For example, *obj\debug\\*. |
| KeyContainerName | All | The name of the strong-name key container. |
| KeyOriginatorFile | All | The name of the strong-name key file. |
| ModuleAssemblyName | .NET | The name of the assembly that the compiled module is to be incorporated into. The property is equivalent to the `/moduleassemblyname` compiler switch. |
| MSBuildProjectExtensionsPath | All | Specifies the path where project extensions are located. By default, this takes the same value as `BaseIntermediateOutputPath`. |
| MSBuildTreatWarningsAsErrors | All | A boolean value that tells MSBuild to treat all warnings as errors, unless they're suppressed. |
| MSBuildWarningsAsErrors | All | Specifies a list of warning codes to treat as errors. Separate multiple warnings by semicolons. If you're using the .NET SDK property `WarningsAsErrors`, `MSBuildWarningsAsErrors` will default to the value of `WarningsAsErrors`.|
| MSBuildWarningsAsMessages | All | Specifies a list of warning codes to suppress by treating them as low-importance messages. Separate multiple warnings by semicolons. Note that some warnings emitted by MSBuild can't be suppressed by using this property; to suppress them, use the command-line switch `-warnAsMessage`. If you're using the .NET SDK property `NoWarn`, `MSBuildWarningsAsMessages` will default to the value of `NoWarn`.|

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| NoLogo | All | A boolean value that indicates whether you want compiler logo to be turned off. This property is equivalent to the `/nologo` compiler switch. |
| NoStdLib | .NET | A boolean value that indicates whether to avoid referencing the standard library (*mscorlib.dll*). The default value is `false`. |
| NoVBRuntimeReference | Visual Basic | A boolean value that indicates whether the Visual Basic runtime (*Microsoft.VisualBasic.dll*) should be included as a reference in the project. |
| NoWarn | .NET | Suppresses the specified warnings. Only the numeric part of the warning identifier must be specified. Multiple warnings are separated by semicolons. This parameter corresponds to the `/nowarn` switch of the compilers. |
| NoWin32Manifest | .NET | A boolean value that indicates whether User Account Control (UAC) manifest information will be embedded in the application's executable. Applies only to Visual Studio projects targeting Windows Vista. In projects deployed using ClickOnce and Registration-Free COM, this element is ignored. `False` (the default value) specifies that User Account Control (UAC) manifest information be embedded in the application's executable. `True` specifies that UAC manifest information not be embedded.<br /><br /> This property applies only to Visual Studio projects targeting Windows Vista. In projects deployed using ClickOnce and Registration-Free COM, this property is ignored.<br /><br /> You should add NoWin32Manifest only if you don't want Visual Studio to embed any manifest information in the application's executable; this process is called *virtualization*. To use virtualization, set `<ApplicationManifest>` in conjunction with `<NoWin32Manifest>` as follows:<br /><br /> -   For Visual Basic projects, remove the `<ApplicationManifest>` node. (In Visual Basic projects, `<NoWin32Manifest>` is ignored when an `<ApplicationManifest>` node exists.)<br />-   For C# projects, set `<ApplicationManifest>` to `False` and `<NoWin32Manifest>` to `True`. (In C# projects, `<ApplicationManifest>` overrides `<NoWin32Manifest>`.)<br /> This property is equivalent to the `/nowin32manifest` compiler switch of *vbc.exe*. |
| Optimize | .NET | A boolean value that when set to `true`, enables compiler optimizations. This property is equivalent to the `/optimize` compiler switch. |
| OptionCompare | VisualBasic | Specifies how string comparisons are made. Valid values are `binary` or `text`. This property is equivalent to the `/optioncompare` compiler switch of *vbc.exe*. |
| OptionExplicit | Visual Basic | A boolean value that when set to `true`, requires explicit declaration of variables in the source code. This property is equivalent to the `/optionexplicit` compiler switch. |
| OptionInfer | Visual Basic | A boolean value that when set to `true`, enables type inference of variables. This property is equivalent to the `/optioninfer` compiler switch. |
| OptionStrict | Visual Basic | A boolean value that when set to `true`, causes the build task to enforce strict type semantics to restrict implicit type conversions. This property is equivalent to the `/optionstrict` switch of the *vbc.exe* compiler. |
| OutDir | All | Indicates the final output location for the project or solution. When you build a solution, OutDir can be used to gather multiple project outputs in one location. In addition, OutDir is included in AssemblySearchPaths used for resolving references. For example, *bin\Debug*. |
| OutputPath | All | Specifies the path to the output directory, relative to the project directory, for example, *bin\Debug* or *bin\Debug\\$(Platform)* in non-AnyCPU builds.|
| OutputType | All |  Specifies the file format of the output file. This parameter can have one of the following values:<br /><br /> -   Library. Creates a code library. (Default value.)<br />-   Exe. Creates a console application.<br />-   Module. Creates a module.<br />-   Winexe. Creates a Windows-based program.<br /><br /> For C# and Visual Basic, this property is equivalent to the `/target` switch. The output type can be automatically overridden by inferencing. See [OutputType set to WinExe for WPF and WinForms apps](/dotnet/core/compatibility/sdk/5.0/automatically-infer-winexe-output-type). Disable inferencing by setting `DisableWinExeOutputInference` to `true`. |
| OverwriteReadOnlyFiles | All | A boolean value that indicates whether you want to enable the build to overwrite read-only files or trigger an error. |

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| PathMap | .NET | Specifies how to map physical paths to source path names output by the compiler. This property is equivalent to the `/pathmap` switch of the compilers. |
| PdbFile | .NET | The file name of the `.pdb` file that you're emitting. This property is equivalent to the `/pdb` switch of the *csc.exe* compiler. |
| Platform | All | The operating system you're building for. Examples for .NET Framework builds are `Any CPU`, `x86`, and `x64`. |
| ProcessorArchitecture | .NET | The processor architecture that is used when assembly references are resolved. Valid values are `msil`, `x86`, `amd64`, or `ia64`. |
| ProduceOnlyReferenceAssembly | .NET | A boolean value that instructs the compiler to emit only a reference assembly rather than compiled code. Can't be used in conjunction with `ProduceReferenceAssembly`.  This property corresponds to the `/refonly` switch of the *vbc.exe* and *csc.exe* compilers. |
| ProduceReferenceAssembly | .NET | A boolean value that when set to `true` enables production of [reference assemblies](/dotnet/standard/assembly/reference-assemblies) for the current assembly. `Deterministic` should be `true` when using this feature. This property corresponds to the `/refout` switch of the *vbc.exe* and *csc.exe* compilers. |
| RegisterAssemblyMSBuildArchitecture | Windows only | Specifies the default architecture for which the managed DLL is registered. This property is useful because COM uses the Windows registry to store the registrations in architecture-specific hives. For example, on a Windows system, an AnyCPU managed assembly can have its types registered in the 64-bit hive and/or in the 32-bit (WoW) hive, and the build uses this property to determine which architecture-specific registry hive to use. Valid values include `x86`, `x64`, and `ARM64`. |
| RegisterForCOMInterop | Windows only | Indicates that your managed application will expose a COM object (a COM callable wrapper). See [Build page - Output section](../ide/reference/build-page-project-designer-csharp.md). This setting affects only the machine on which the project is building. If you're deploying to other machines, call [regasm.exe](/dotnet/framework/tools/regasm-exe-assembly-registration-tool) to register the assembly on the target machine.|
| RemoveIntegerChecks | Visual Basic | A boolean value that indicates whether to disable integer overflow error checks. The default value is `false`. This property is equivalent to the `/removeintchecks` switch of the *vbc.exe* compiler. |
| RootNamespace | All | The root namespace to use when you name an embedded resource. This namespace is part of the embedded resource manifest name. |

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| Satellite_AlgorithmId | .NET | The ID of the *AL.exe* hashing algorithm to use when satellite assemblies are created. |
| Satellite_BaseAddress | .NET | The base address to use when culture-specific satellite assemblies are built by using the `CreateSatelliteAssemblies` target. |
| Satellite_CompanyName | .NET | The company name to pass into *AL.exe* during satellite assembly generation. |
| Satellite_Configuration | .NET | The configuration name to pass into *AL.exe* during satellite assembly generation. |
| Satellite_Description | .NET | The description text to pass into *AL.exe* during satellite assembly generation. |
| Satellite_EvidenceFile | .NET | Embeds the specified file in the satellite assembly that has the resource name "Security.Evidence." |
| Satellite_FileVersion | .NET | Specifies a string for the File Version field in the satellite assembly. |
| Satellite_Flags | .NET | Specifies a value for the Flags field in the satellite assembly. |
| Satellite_GenerateFullPaths | .NET | Causes the build task to use absolute paths for any files reported in an error message. |
| Satellite_LinkResource | .NET | Links the specified resource files to a satellite assembly. |
| Satellite_MainEntryPoint | .NET | Specifies the fully qualified name (that is, class.method) of the method to use as an entry point when a module is converted to an executable file during satellite assembly generation. |
| Satellite_ProductName | .NET | Specifies a string for the Product field in the satellite assembly. |
| Satellite_ProductVersion | .NET | Specifies a string for the ProductVersion field in the satellite assembly. |
| Satellite_TargetType | .NET | Specifies the file format of the satellite assembly output file as "library," "exe," or "win." The default value is "library." |
| Satellite_Title | .NET | Specifies a string for the Title field in the satellite assembly. |
| Satellite_Trademark | .NET | Specifies a string for the Trademark field in the satellite assembly. |
| Satellite_Version | .NET | Specifies the version information for the satellite assembly. |
| Satellite_Win32Icon | .NET | Inserts an `.ico` icon file in the satellite assembly. |
| Satellite_Win32Resource | .NET | Inserts a Win32 resource (`.res` file) into the satellite assembly. |
| SGenToolPath | .NET | An optional tool path that indicates where to obtain *SGen.exe* when the current version of *SGen.exe* is overridden. |

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| SGenUseProxyTypes | .NET | A boolean value that indicates whether proxy types should be generated by *SGen.exe*. This applies only when *GenerateSerializationAssemblies* is set to on.<br /><br /> The SGen target uses this property to set the UseProxyTypes flag. This property defaults to true, and there's no UI to change this. To generate the serialization assembly for non-webservice types, add this property to the project file and set it to false before importing the *Microsoft.Common.Targets* or the *C#/VB.targets*. |
| SkipInvalidConfigurations | All | When `true`, generate a warning on invalid platform and configuration combinations, but don't fail the build; when `false` or undefined (the default), generate an error. |
| StartupObject | .NET | Specifies the class or module that contains the Main method or Sub Main procedure. This property is equivalent to the `/main` compiler switch. |
| SubsystemVersion | .NET | Specifies the minimum version of the subsystem that the generated executable file can use. This property is equivalent to the `/subsystemversion` compiler switch. For information about the default value of this property, see [/subsystemversion (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/subsystemversion) or [/subsystemversion (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/subsystemversion-compiler-option). |
| TargetCompactFramework | .NET | The version of the .NET Compact Framework that is required to run the application that you're building. Specifying this lets you reference certain framework assemblies that you may not be able to reference otherwise. |
| TargetFrameworkVersion | .NET | The version of the .NET Framework that is required to run the application that you're building. Specifying this lets you reference certain framework assemblies that you may not be able to reference otherwise. |
| TreatWarningsAsErrors | .NET | A boolean parameter that, if `true`, causes all warnings to be treated as errors. This parameter is equivalent to the `/nowarn` compiler switch. |
| UseCommonOutputDirectory | .NET | A boolean property that you can set to `true` when you want all build outputs in a solution to use the same output directory. If `true`, referenced projects' output isn't copied to projects that use those dependencies, as is normally the case when this setting is `false`. Setting this parameter to `true` doesn't change the actual output directory of any projects; you still need to set the output directory to the desired common output directory for each project that requires it.|
| UseHostCompilerIfAvailable | .NET | A boolean parameter that, if `true`, causes the build task to use the in-process compiler object, if it's available. This parameter is used only by Visual Studio. |
| Utf8Output | .NET | A boolean parameter that, if `true`, logs compiler output by using UTF-8 encoding. This parameter is equivalent to the `/utf8Output` compiler switch. |

| Property or parameter name | Project types | Description |
|------------------------------------| - | - |
| VbcToolPath | Visual Basic | An optional path that indicates another location for *vbc.exe* when the current version of *vbc.exe* is overridden. |
| VbcVerbosity | Visual Basic | Specifies the verbosity of the Visual Basic compiler's output. Valid values are "Quiet," "Normal" (the default value), or "Verbose." |
| VisualStudioVersion | All | Specifies the version of Visual Studio under which this project should be considered to be running. If this property isn't specified, MSBuild sets it to a default value of `{VisualStudioMajorVersion}.0`; for instance it will be `17.0` for all versions of Visual Studio 2022.<br /><br /> This property is used in several project types to specify the set of targets that are used for the build. If `ToolsVersion` is set to 4.0 or higher for a project, `VisualStudioVersion` is used to specify which sub-toolset to use. For more information, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md). |
| WarningsAsErrors | .NET | Specifies a list of warnings to treat as errors. This parameter is equivalent to the `/warnaserror` compiler switch. |
| WarningLevel | All | Specifies the warning level to pass to the compilers for warnings emitted by the compiler. This setting doesn't affect MSBuild warnings, which don't have level designations. See [Warning Level](/dotnet/csharp/language-reference/compiler-options/errors-warnings#warninglevel) in the C# compiler documentation and [/W (Warning level)](/cpp/build/reference/compiler-option-warning-level) in the C++ compiler documentation. |
| WarningsNotAsErrors | .NET | Specifies a list of warnings that aren't treated as errors. This parameter is equivalent to the `/warnaserror` compiler switch. |
| Win32Manifest | .NET | The name of the manifest file that should be embedded in the final assembly. This parameter is equivalent to the `/win32Manifest` compiler switch. |
| Win32Resource | .NET | The file name of the Win32 resource to be embedded in the final assembly. This parameter is equivalent to the `/win32resource` compiler switch. |

Properties specific to .NET SDK projects, such as `TargetFramework`, are documented at [Framework properties](/dotnet/core/project-sdk/msbuild-props#framework-properties).

## See also

- [Common MSBuild project items](../msbuild/common-msbuild-project-items.md)
- [Common MSBuild item metadata](common-msbuild-item-metadata.md)
- [MSBuild Reserved and Well-known Properties](msbuild-reserved-and-well-known-properties.md)
- [MSBuild reference for .NET SDK projects](/dotnet/core/project-sdk/msbuild-props)
