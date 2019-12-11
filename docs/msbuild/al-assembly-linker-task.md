---
title: "AL (Assembly Linker) Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#AL"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "AL task [MSBuild]"
  - "MSBuild, AL task"
ms.assetid: 2ddefbf2-5662-4d55-99a6-ac383bf44560
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# AL (Assembly Linker) task
The AL task wraps *AL.exe*, a tool that is distributed with the [!INCLUDE[winsdklong](../deployment/includes/winsdklong_md.md)]. This Assembly Linker tool is used to create an assembly with a manifest from one or more files that are either modules or resource files. Compilers and development environments might already provide these capabilities, so it is often not necessary to use this task directly. The Assembly Linker is most useful to developers needing to create a single assembly from multiple component files, such as those that might be produced from mixed-language development. This task does not combine the modules into a single assembly file; the individual modules must still be distributed and available in order for the resulting assembly to load correctly. For more information on *AL.exe*, see [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker).

## Parameters
 The following table describes the parameters of the `AL` task.

| Parameter | Description |
|---------------------| - |
| `AlgorithmID` | Optional `String` parameter.<br /><br /> Specifies an algorithm to hash all files in a multifile assembly except the file that contains the assembly manifest. For more information, see the documentation for the `/algid` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `BaseAddress` | Optional `String` parameter.<br /><br /> Specifies the address at which a DLL will be loaded on the user's computer at run time. Applications load faster if you specify the base address of the DLLs, rather than letting the operating system relocate the DLLs in the process space. This parameter corresponds to the /base[address](/dotnet/framework/tools/al-exe-assembly-linker). |
| `CompanyName` | Optional `String` parameter.<br /><br /> Specifies a string for the `Company` field in the assembly. For more information, see the documentation for the `/comp[any]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Configuration` | Optional `String` parameter.<br /><br /> Specifies a string for the `Configuration` field in the assembly. For more information, see the documentation for the `/config[uration]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Copyright` | Optional `String` parameter.<br /><br /> Specifies a string for the `Copyright` field in the assembly. For more information, see the documentation for the `/copy[right]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Culture` | Optional `String` parameter.<br /><br /> Specifies the culture string to associate with the assembly. For more information, see the documentation for the `/c[ulture]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `DelaySign` | Optional `Boolean` parameter.<br /><br /> `true` to place only the public key in the assembly; `false` to fully sign the assembly. For more information, see the documentation for the `/delay[sign]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Description` | Optional `String` parameter.<br /><br /> Specifies a string for the `Description` field in the assembly. For more information, see the documentation for the `/descr[iption]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `EmbedResources` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Embeds the specified resources in the image that contains the assembly manifest. This task copies the contents of the resource file into the image. The items passed in to this parameter may have optional metadata attached to them called `LogicalName` and `Access`. The `LogicalName` metadata is used to specify the internal identifier for the resource.  The `Access` metadata can be set to `private` in order to make the resource not visible to other assemblies. For more information, see the documentation for the `/embed[resource]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `EvidenceFile` | Optional `String` parameter.<br /><br /> Embeds the specified file in the assembly with the resource name of `Security.Evidence`.<br /><br /> You cannot use `Security.Evidence` for regular resources. This parameter corresponds to the `/e[vidence]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `ExitCode` | Optional `Int32` output read-only parameter.<br /><br /> Specifies the exit code provided by the executed command. |
| `FileVersion` | Optional `String` parameter.<br /><br /> Specifies a string for the `File Version` field in the assembly. For more information, see the documentation for the `/fileversion` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Flags` | Optional `String` parameter.<br /><br /> Specifies a value for the `Flags` field in the assembly. For more information, see the documentation for the `/flags` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `GenerateFullPaths` | Optional `Boolean` parameter.<br /><br /> Causes the task to use the absolute path for any files that are reported in an error message. This parameter corresponds to the `/fullpaths` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `KeyContainer` | Optional `String` parameter.<br /><br /> Specifies a container that holds a key pair. This will sign the assembly (give it a strong name) by inserting a public key into the assembly manifest. The task will then sign the final assembly with the private key. For more information, see the documentation for the `/keyn[ame]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `KeyFile` | Optional `String` parameter.<br /><br /> Specifies a file that contains a key pair or just a public key to sign an assembly. The compiler inserts the public key in the assembly manifest and then signs the final assembly with the private key. For more information, see the documentation for the `/keyf[ile]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `LinkResources` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Links the specified resource files to an assembly. The resource becomes part of the assembly, but the file is not copied. The items passed in to this parameter may have optional metadata attached to them called `LogicalName`, `Target`, and `Access`. The `LogicalName` metadata is used to specify the internal identifier for the resource. The `Target` metadata can specify the path and filename to which the task copies the file, after which it compiles this new file into the assembly. The `Access` metadata can be set to `private` in order to make the resource not visible to other assemblies. For more information, see the documentation for the `/link[resource]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `MainEntryPoint` | Optional `String` parameter.<br /><br /> Specifies the fully qualified name (*class.method*) of the method to use as an entry point when converting a module to an executable file. This parameter corresponds to the `/main` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `OutputAssembly` | Required <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the name of the file generated by this task. This parameter corresponds to the `/out` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Platform` | Optional `String` parameter.<br /><br /> Limits which platform this code can run on; must be one of `x86`, `Itanium`, `x64`, or `anycpu`. The default is `anycpu`. This parameter corresponds to the `/platform` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `ProductName` | Optional `String` parameter.<br /><br /> Specifies a string for the `Product` field in the assembly. For more information, see the documentation for the `/prod[uct]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `ProductVersion` | Optional `String` parameter.<br /><br /> Specifies a string for the `ProductVersion` field in the assembly. For more information, see the documentation for the `/productv[ersion]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `ResponseFiles` | Optional `String[]` parameter.<br /><br /> Specifies the response files that contain additional options to pass through to the Assembly Linker. |
| `SdkToolsPath` | Optional `String` parameter.<br /><br /> Specifies the path to the SDK tools, such as resgen.exe. |
| `SourceModules` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> One or more modules to be compiled into an assembly. The modules will be listed in the manifest of the resulting assembly, and will still need to distributed and available in order for the assembly to load. The items passed into this parameter may have additional metadata called `Target`, which specifies the path and filename to which the task copies the file, after which it compiles this new file into the assembly. For more information, see the documentation for [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). This parameter corresponds to the list of modules passed into *Al.exe* without a specific switch. |
| `TargetType` | Optional `String` parameter.<br /><br /> Specifies the file format of the output file: `library` (code library), `exe` (console application), or `win` (Windows-based application). The default is `library`. This parameter corresponds to the `/t[arget]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `TemplateFile` | Optional `String` parameter.<br /><br /> Specifies the assembly from which to inherit all assembly metadata, except the culture field. The specified assembly must have a strong name.<br /><br /> An assembly that you create with the `TemplateFile` parameter will be a satellite assembly. This parameter corresponds to the `/template` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Timeout` | Optional `Int32` parameter.<br /><br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is `Int.MaxValue`, indicating that there is no time out period. |
| `Title` | Optional `String` parameter.<br /><br /> Specifies a string for the `Title` field in the assembly. For more information, see the documentation for the `/title` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `ToolPath` | Optional `String` parameter.<br /><br /> Specifies the location from where the task will load the underlying executable file (Al.exe). If this parameter is not specified, the task uses the SDK installation path corresponding to the version of the framework that is running [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)]. |
| `Trademark` | Optional `String` parameter.<br /><br /> Specifies a string for the `Trademark` field in the assembly. For more information, see the documentation for the `/trade[mark]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Version` | Optional `String` parameter.<br /><br /> Specifies the version information for this assembly. The format of the string is *major.minor.build.revision*. The default value is 0. For more information, see the documentation for the `/v[ersion]` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Win32Icon` | Optional `String` parameter.<br /><br /> Inserts an *.ico* file in the assembly. The *.ico* file gives the output file the desired appearance in File Explorer. This parameter corresponds to the `/win32icon` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |
| `Win32Resource` | Optional `String` parameter.<br /><br /> Inserts a Win32 resource (*.res* file) in the output file. For more information, see the documentation for the `/win32res` option in [Al.exe (Assembly Linker)](/dotnet/framework/tools/al-exe-assembly-linker). |

## Remarks
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension base class](../msbuild/tooltaskextension-base-class.md).

## Example
 The following example creates an assembly with the specified options.

```xml
<AL
    EmbedResources="@(EmbeddedResource)"
    Culture="%(EmbeddedResource.Culture)"
    TemplateFile="@(IntermediateAssembly)"
    KeyContainer="$(KeyContainerName)"
    KeyFile="$(KeyOriginatorFile)"
    DelaySign="$(DelaySign)"

    OutputAssembly=
       "%(EmbeddedResource.Culture)\$(TargetName).resources.dll">

    <Output TaskParameter="OutputAssembly"
        ItemName="SatelliteAssemblies"/>
</AL>
```

## See also
* [Task reference](../msbuild/msbuild-task-reference.md)
* [Tasks](../msbuild/msbuild-tasks.md)
