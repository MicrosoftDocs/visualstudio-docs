---
title: "Common MSBuild Project Properties | Microsoft Docs"
ms.date: "01/18/2018"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "msbuild, common properties"
  - "msbuild, project file properties"
  - "ExcludeDeploymentUrl property"
  - "project file properties (MSBuild)"
ms.assetid: 9857505d-ae15-42f1-936d-6cd7fb9dd276
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Common MSBuild project properties
The following table lists frequently used properties that are defined in the Visual Studio project files or included in *.targets* files that MSBuild provides.

 Project files in Visual Studio (*.csproj*, *.vbproj*, *.vcxproj*, and others) contain MSBuild XML code that runs when you build a project by using the IDE. Projects typically import one or more *.targets* files to define their build process. For more information, see [MSBuild .targets files](../msbuild/msbuild-dot-targets-files.md).

## List of common properties and parameters

| Property or parameter name | Description |
|------------------------------------| - |
| AdditionalLibPaths | Specifies additional folders in which compilers should look for reference assemblies. |
| AddModules | Causes the compiler to make all type information from the specified files available to the project you are compiling. This property is equivalent to the `/addModules` compiler switch. |
| ALToolPath | The path where *AL.exe* can be found. This property overrides the current version of *AL.exe* to enable use of a different version. |
| ApplicationIcon | The *.ico* icon file to pass to the compiler for embedding as a Win32 icon. The property is equivalent to the `/win32icon` compiler switch. |
| ApplicationManifest | Specifies the path of the file that is used to generate external User Account Control (UAC) manifest information. Applies only to Visual Studio projects targeting [!INCLUDE[windowsver](../deployment/includes/windowsver_md.md)].<br /><br /> In most cases, the manifest is embedded. However, if you use Registration Free COM or [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment, then the manifest can be an external file that is installed together with your application assemblies. For more information, see the NoWin32Manifest property in this topic. |
| AssemblyOriginatorKeyFile | Specifies the file that's used to sign the assembly (*.snk* or *.pfx*) and that's passed to the [ResolveKeySource task](../msbuild/resolvekeysource-task.md) to generate the actual key that's used to sign the assembly. |
| AssemblySearchPaths | A list of locations to search during build-time reference assembly resolution. The order in which paths appear in this list is meaningful because paths listed earlier takes precedence over later entries. |
| AssemblyName | The name of the final output assembly after the project is built. |
| BaseAddress | Specifies the base address of the main output assembly. This property is equivalent to the `/baseaddress` compiler switch. |
| BaseOutputPath | Specifies the base path for the output file. If it is set, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] will use `OutputPath = $(BaseOutputPath)\$(Configuration)\`. Example syntax: `<BaseOutputPath>c:\xyz\bin\</BaseOutputPath>` |
| BaseIntermediateOutputPath | The top-level folder where all configuration-specific intermediate output folders are created. The default value is `obj\`. The following code is an example: `<BaseIntermediateOutputPath>c:\xyz\obj\</BaseIntermediateOutputPath>` |
| BuildInParallel | A boolean value that indicates whether project references are built or cleaned in parallel when Multi-Proc [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] is used. The default value is `true`, which means that projects will be built in parallel if the system has multiple cores or processors. |
| BuildProjectReferences | A boolean value that indicates whether project references are built by [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)]. Automatically set to `false` if you are building your project in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE), `true` if otherwise. `-p:BuildProjectReferences=false` can be specified on the command line to avoid checking that referenced projects are up to date. |
| CleanFile | The name of the file that will be used as the "clean cache." The clean cache is a list of generated files to be deleted during the cleaning operation. The file is put in the intermediate output path by the build process.<br /><br /> This property specifies only file names that do not have path information. |
| CodePage | Specifies the code page to use for all source-code files in the compilation. This property is equivalent to the `/codepage` compiler switch. |
| CompilerResponseFile | An optional response file that can be passed to the compiler tasks. |
| Configuration | The configuration that you are building, either "Debug" or "Release." |
| CscToolPath | The path of *csc.exe*, the [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] compiler. |
| CustomBeforeMicrosoftCommonTargets | The name of a project file or targets file that is to be imported automatically before the common targets import. |
| DebugSymbols | A boolean value that indicates whether symbols are generated by the build.<br /><br /> Setting **-p:DebugSymbols=false** on the command line disables generation of program database (*.pdb*) symbol files. |
| DebugType | Defines the level of debug information that you want generated. Valid values are "full," "pdbonly," "portable", "embedded", and "none." |
| DefineConstants | Defines conditional compiler constants. Symbol/value pairs are separated by semicolons and are specified by using the following syntax:<br /><br /> *symbol1 = value1 ; symbol2 = value2*<br /><br /> The property is equivalent to the `/define` compiler switch. |
| DefineDebug | A boolean value that indicates whether you want the DEBUG constant defined. |
| DefineTrace | A boolean value that indicates whether you want the TRACE constant defined. |
| DelaySign | A boolean value that indicates whether you want to delay-sign the assembly rather than full-sign it. |
| Deterministic | A boolean value that indicates whether the compiler should produce identical assemblies for identical inputs. This parameter corresponds to the `/deterministic` switch of the *vbc.exe* and *csc.exe* compilers. |
| DisabledWarnings | Suppresses the specified warnings. Only the numeric part of the warning identifier must be specified. Multiple warnings are separated by semicolons. This parameter corresponds to the `/nowarn` switch of the *vbc.exe* compiler. |
| DisableFastUpToDateCheck | A boolean value that applies to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] only. The [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] build manager uses a process called FastUpToDateCheck to determine whether a project must be rebuilt to be up to date. This process is faster than using [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] to determine this. Setting the DisableFastUpToDateCheck property to `true` lets you bypass the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] build manager and force it to use [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] to determine whether the project is up to date. |
| DocumentationFile | The name of the file that is generated as the XML documentation file. This name includes only the file name and has no path information. |
| ErrorReport | Specifies how the compiler task should report internal compiler errors. Valid values are "prompt," "send," or "none." This property is equivalent to the `/errorreport` compiler switch. |
| ExcludeDeploymentUrl | The [GenerateDeploymentManifest task](../msbuild/generatedeploymentmanifest-task.md) adds a  deploymentProvider tag to the deployment manifest if the project file includes any of the following elements:<br /><br /> -   UpdateUrl<br />-   InstallUrl<br />-   PublishUrl<br /><br /> Using ExcludeDeploymentUrl, however, you can prevent the deploymentProvider tag from being added to the deployment manifest even if any of the above URLs are specified. To do this, add the following property to your project file:<br /><br /> `<ExcludeDeploymentUrl>true</ExcludeDeploymentUrl>` <br /><br />**Note:**  ExcludeDeploymentUrl is not exposed in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE and can be set only by manually editing the project file. Setting this property does not affect publishing within [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]; that is, the deploymentProvider tag will still be added to the URL specified by PublishUrl. |
| FileAlignment | Specifies, in bytes, where to align the sections of the output file. Valid values are 512, 1024, 2048, 4096, 8192. This property is equivalent to the `/filealignment` compiler switch. |
| FrameworkPathOverride | Specifies the location of *mscorlib.dll* and *microsoft.visualbasic.dll*. This parameter is equivalent to the `/sdkpath` switch of the *vbc.exe* compiler. |
| GenerateDocumentation | (C#, Visual Basic) A boolean parameter that indicates whether documentation is generated by the build. If `true`, the build generates documentation information and puts it in an *.xml* file together with the name of the executable file or library that the build task created. |
| GenerateSerializationAssemblies | Indicates whether XML serialization assemblies should be generated by *SGen.exe*, which can be set to on, auto, or off. This property is used for assemblies that target .NET Framework only. To generate XML serialization assemblies for .NET Standard or .NET Core assemblies, reference the *Microsoft.XmlSerializer.Generator* NuGet package. |
| IntermediateOutputPath | The full intermediate output path as derived from `BaseIntermediateOutputPath`, if no path is specified. For example, *\obj\debug\\*. |
| KeyContainerName | The name of the strong-name key container. |
| KeyOriginatorFile | The name of the strong-name key file. |
| MSBuildProjectExtensionsPath | Specifies the path where project extensions are located. By default, this takes the same value as `BaseIntermediateOutputPath`. |
| ModuleAssemblyName | The name of the assembly that the compiled module is to be incorporated into. The property is equivalent to the `/moduleassemblyname` compiler switch. |
| NoLogo | A boolean value that indicates whether you want compiler logo to be turned off. This property is equivalent to the `/nologo` compiler switch. |
| NoStdLib | A boolean value that indicates whether to avoid referencing the standard library (*mscorlib.dll*). The default value is `false`. |
| NoVBRuntimeReference | A boolean value that indicates whether the [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] runtime (*Microsoft.VisualBasic.dll*) should be included as a reference in the project. |
| NoWin32Manifest | A boolean value that indicates whether User Account Control (UAC) manifest information will be embedded in the application's executable. Applies only to Visual Studio projects targeting [!INCLUDE[windowsver](../deployment/includes/windowsver_md.md)]. In projects deployed using [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] and Registration-Free COM, this element is ignored. `False` (the default value) specifies that User Account Control (UAC) manifest information be embedded in the application's executable. `True` specifies that UAC manifest information not be embedded.<br /><br /> This property applies only to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] projects targeting [!INCLUDE[windowsver](../deployment/includes/windowsver_md.md)]. In projects deployed using [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] and Registration-Free COM, this property is ignored.<br /><br /> You should add NoWin32Manifest only if you do not want [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] to embed any manifest information in the application's executable; this process is called *virtualization*. To use virtualization, set `<ApplicationManifest>` in conjunction with `<NoWin32Manifest>` as follows:<br /><br /> -   For [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] projects, remove the `<ApplicationManifest>` node. (In [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] projects, `<NoWin32Manifest>` is ignored when an `<ApplicationManifest>` node exists.)<br />-   For [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] projects, set `<ApplicationManifest>` to `False` and `<NoWin32Manifest>` to `True`. (In [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] projects, `<ApplicationManifest>` overrides `<NoWin32Manifest>`.)<br /> This property is equivalent to the `/nowin32manifest` compiler switch of *vbc.exe*. |
| Optimize | A boolean value that when set to `true`, enables compiler optimizations. This property is equivalent to the `/optimize` compiler switch. |
| OptionCompare | Specifies how string comparisons are made. Valid values are "binary" or "text." This property is equivalent to the `/optioncompare` compiler switch of *vbc.exe*. |
| OptionExplicit | A boolean value that when set to `true`, requires explicit declaration of variables in the source code. This property is equivalent to the `/optionexplicit` compiler switch. |
| OptionInfer | A boolean value that when set to `true`, enables type inference of variables. This property is equivalent to the `/optioninfer` compiler switch. |
| OptionStrict | A boolean value that when set to `true`, causes the build task to enforce strict type semantics to restrict implicit type conversions. This property is equivalent to the `/optionstrict` switch of the *vbc.exe* compiler. |
| OutputPath | Specifies the path to the output directory, relative to the project directory, for example, *bin\Debug*. |
| OutputType | Specifies the file format of the output file. This parameter can have one of the following values:<br /><br /> -   Library. Creates a code library. (Default value.)<br />-   Exe. Creates a console application.<br />-   Module. Creates a module.<br />-   Winexe. Creates a Windows-based program.<br /><br /> This property is equivalent to the `/target` switch of the *vbc.exe* compiler. |
| OverwriteReadOnlyFiles | A boolean value that indicates whether you want to enable the build to overwrite read-only files or trigger an error. |
| PathMap | Specifies how to map physical paths to source path names output by the compiler. This property is equivalent to the `/pathmap` switch of the *csc.exe* compiler. |
| PdbFile | The file name of the *.pdb* file that you are emitting. This property is equivalent to the `/pdb` switch of the *csc.exe* compiler. |
| Platform | The operating system you are building for. Valid values are "Any CPU", "x86", and "x64". |
| ProduceReferenceAssembly | A boolean value that when set to `true` enables production of [reference assemblies](/dotnet/standard/assembly/reference-assemblies) for the current assembly. `Deterministic` should be `true` when using this feature. This property corresponds to the `/refout` switch of the *vbc.exe* and *csc.exe* compilers. |
| ProduceOnlyReferenceAssembly | A boolean value that instructs the compiler to emit only a reference assembly rather than compiled code. Cannot be used in conjunction with `ProduceReferenceAssembly`.  This property corresponds to the `/refonly` switch of the *vbc.exe* and *csc.exe* compilers. |
| RemoveIntegerChecks | A boolean value that indicates whether to disable integer overflow error checks. The default value is `false`. This property is equivalent to the `/removeintchecks` switch of the *vbc.exe* compiler. |
| SGenUseProxyTypes | A boolean value that indicates whether proxy types should be generated by *SGen.exe*. This applies only when *GenerateSerializationAssemblies* is set to on, and for .NET Framework only.<br /><br /> The SGen target uses this property to set the UseProxyTypes flag. This property defaults to true, and there is no UI to change this. To generate the serialization assembly for non-webservice types, add this property to the project file and set it to false before importing the *Microsoft.Common.Targets* or the *C#/VB.targets*. |
| SGenToolPath | An optional tool path that indicates where to obtain *SGen.exe* when the current version of *SGen.exe* is overridden. This property is used for .NET Framework only.|
| StartupObject | Specifies the class or module that contains the Main method or Sub Main procedure. This property is equivalent to the `/main` compiler switch. |
| ProcessorArchitecture | The processor architecture that is used when assembly references are resolved. Valid values are "msil," "x86," "amd64," or "ia64." |
| RootNamespace | The root namespace to use when you name an embedded resource. This namespace is part of the embedded resource manifest name. |
| Satellite_AlgorithmId | The ID of the *AL.exe* hashing algorithm to use when satellite assemblies are created. |
| Satellite_BaseAddress | The base address to use when culture-specific satellite assemblies are built by using the `CreateSatelliteAssemblies` target. |
| Satellite_CompanyName | The company name to pass into *AL.exe* during satellite assembly generation. |
| Satellite_Configuration | The configuration name to pass into *AL.exe* during satellite assembly generation. |
| Satellite_Description | The description text to pass into *AL.exe* during satellite assembly generation. |
| Satellite_EvidenceFile | Embeds the specified file in the satellite assembly that has the resource name "Security.Evidence." |
| Satellite_FileVersion | Specifies a string for the File Version field in the satellite assembly. |
| Satellite_Flags | Specifies a value for the Flags field in the satellite assembly. |
| Satellite_GenerateFullPaths | Causes the build task to use absolute paths for any files reported in an error message. |
| Satellite_LinkResource | Links the specified resource files to a satellite assembly. |
| Satellite_MainEntryPoint | Specifies the fully-qualified name (that is, class.method) of the method to use as an entry point when a module is converted to an executable file during satellite assembly generation. |
| Satellite_ProductName | Specifies a string for the Product field in the satellite assembly. |
| Satellite_ProductVersion | Specifies a string for the ProductVersion field in the satellite assembly. |
| Satellite_TargetType | Specifies the file format of the satellite assembly output file as "library," "exe," or "win." The default value is "library." |
| Satellite_Title | Specifies a string for the Title field in the satellite assembly. |
| Satellite_Trademark | Specifies a string for the Trademark field in the satellite assembly. |
| Satellite_Version | Specifies the version information for the satellite assembly. |
| Satellite_Win32Icon | Inserts an *.ico* icon file in the satellite assembly. |
| Satellite_Win32Resource | Inserts a Win32 resource (*.res* file) into the satellite assembly. |
| SubsystemVersion | Specifies the minimum version of the subsystem that the generated executable file can use. This property is equivalent to the `/subsystemversion` compiler switch. For information about the default value of this property, see [/subsystemversion (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/subsystemversion) or [/subsystemversion (C# compiler options)](/dotnet/csharp/language-reference/compiler-options/subsystemversion-compiler-option). |
| TargetCompactFramework | The version of the .NET Compact Framework that is required to run the application that you are building. Specifying this lets you reference certain framework assemblies that you may not be able to reference otherwise. |
| TargetFrameworkVersion | The version of the .NET Framework that is required to run the application that you are building. Specifying this lets you reference certain framework assemblies that you may not be able to reference otherwise. |
| TreatWarningsAsErrors | A boolean parameter that, if `true`, causes all warnings to be treated as errors. This parameter is equivalent to the `/nowarn` compiler switch. |
| UseHostCompilerIfAvailable | A boolean parameter that, if `true`, causes the build task to use the in-process compiler object, if it is available. This parameter is used only by [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. |
| Utf8Output | A boolean parameter that, if `true`, logs compiler output by using UTF-8 encoding. This parameter is equivalent to the `/utf8Output` compiler switch. |
| VbcToolPath | An optional path that indicates another location for *vbc.exe* when the current version of *vbc.exe* is overridden. |
| VbcVerbosity | Specifies the verbosity of the [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] compiler's output. Valid values are "Quiet," "Normal" (the default value), or "Verbose." |
| VisualStudioVersion | Specifies the version of Visual Studio under which this project should be considered to be running. If this property isn't specified, MSBuild sets it to a reasonable default value.<br /><br /> This property is used in several project types to specify the set of targets that are used for the build. If `ToolsVersion` is set to 4.0 or higher for a project, `VisualStudioVersion` is used to specify which sub-toolset to use. For more information, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md). |
| WarningsAsErrors | Specifies a list of warnings to treat as errors. This parameter is equivalent to the `/warnaserror` compiler switch. |
| WarningsNotAsErrors | Specifies a list of warnings that are not treated as errors. This parameter is equivalent to the `/warnaserror` compiler switch. |
| Win32Manifest | The name of the manifest file that should be embedded in the final assembly. This parameter is equivalent to the `/win32Manifest` compiler switch. |
| Win32Resource | The file name of the Win32 resource to be embedded in the final assembly. This parameter is equivalent to the `/win32resource` compiler switch. |

## See also
- [Common MSBuild project items](../msbuild/common-msbuild-project-items.md)
