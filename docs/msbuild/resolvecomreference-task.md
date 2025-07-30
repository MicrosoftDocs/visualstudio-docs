---
title: ResolveComReference Task
description: Learn how MSBuild uses the ResolveComReference task to take a list of one or more type library names or .tlb files and resolve them to locations on disk.
ms.date: 07/25/2019
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#ResolveComReference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, ResolveCOMReference task
- ResolveCOMReference task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# ResolveComReference task

Takes a list of one or more type library names or *.tlb* files and resolves those type libraries to locations on disk.

## Parameters

 The following table describes the parameters of the `ResolveCOMReference` task.

|Parameter|Description|
|---------------|-----------------|
|`DelaySign`|Optional `Boolean` parameter.<br /><br /> If `true`, places the public key in the assembly. If `false`, fully signs the assembly.|
|`EnvironmentVariables`|Optional `String[]` parameter.<br /><br /> Array of pairs of environment variables, separated by equal signs. These variables are passed to the spawned *tlbimp.exe* and *aximp.exe* in addition to, or selectively overriding, the regular environment block.|
|`ExecuteAsTool`|Optional `Boolean` parameter.<br /><br /> If `true`, runs *tlbimp.exe* and *aximp.exe* from the appropriate target framework out-of-proc to generate the necessary wrapper assemblies. This parameter enables multi-targeting.|
|`IncludeVersionInInteropName`|Optional `Boolean` parameter.<br /><br /> If `true`, the type library version is included in the wrapper name. The default is `false`.|
|`KeyContainer`|Optional `String` parameter.<br /><br /> Specifies a container that holds a public/private key pair.|
|`KeyFile`|Optional `String` parameter.<br /><br /> Specifies an item that contains a public/private key pair.|
|`NoClassMembers`|Optional `Boolean` parameter.|
|`ResolvedAssemblyReferences`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the resolved assembly references.|
|`ResolvedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the fully qualified files on disk that correspond to the physical locations of the type libraries that were provided as input to this task.|
|`ResolvedModules`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]`parameter.|
|`SdkToolsPath`|Optional <xref:System.String?displayProperty=fullName> parameter.<br /><br /> If `ExecuteAsTool` is `true`, this parameter must be set to the SDK tools path for the framework version being targeted.|
|`StateFile`|Optional `String` parameter.<br /><br /> Specifies the cache file for COM component timestamps. If not present, every run regenerates all the wrappers.|
|`TargetFrameworkVersion`|Optional `String` parameter.<br /><br /> Specifies the project target framework version.<br /><br /> The default is `String.Empty`. which means there is no filtering for a reference based on the target framework.|
|`TargetProcessorArchitecture`|Optional `String` parameter.<br /><br /> Specifies the preferred target processor architecture. Passed to the *tlbimp.exe*/machine flag after translation.<br /><br /> The parameter value should be a member of <xref:Microsoft.Build.Utilities.ProcessorArchitecture>.|
|`TypeLibFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the type library file path to COM references. Items included in this parameter may contain item metadata. For more information, see the section [TypeLibFiles item metadata](#typelibfiles-item-metadata).|
|`TypeLibNames`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the type library names to resolve. Items included in this parameter must contain some item metadata. For more information, see the section [TypeLibNames item metadata](#typelibnames-item-metadata).|
|`WrapperOutputDirectory`|Optional `String` parameter.<br /><br /> The location on disk where the generated interop assembly is placed. If this item metadata is not specified, the task uses the absolute path of the directory where the project file is located.|

## TypeLibNames item metadata

 The following table describes the item metadata available for items passed to the `TypeLibNames` parameter.

|Metadata|Description|
|--------------|-----------------|
|`GUID`|Required item metadata.<br /><br /> The GUID for the type library. If this item metadata is not specified, the task fails.|
|`VersionMajor`|Required item metadata.<br /><br /> The major version of the type library. If this item metadata is not specified, the task fails.|
|`VersionMinor`|Required item metadata.<br /><br /> The minor version of the type library. If this item metadata is not specified, the task fails.|
|`EmbedInteropTypes`|Optional `Boolean` metadata.<br /><br />  If `true`, embed the interop types from this reference directly into your assembly rather than generating an interop DLL.|
|`LocaleIdentifier`|Optional item metadata.<br /><br /> The Locale Identifier (or LCID) for the type library. This identifier is specified as a 32-bit value that identifies the human language preferred by a user, region, or application. If this item metadata is not specified, the task uses a default locale identifier of "0."|
|`WrapperTool`|Optional item metadata.<br /><br /> Specifies the wrapper tool that is used to generate the assembly wrapper for this type library. If this item metadata is not specified, the task uses a default wrapper tool of "tlbimp." The available, case insensitive choices of type libraries are:<br /><br /> -   `Primary`: Use this wrapper tool when you want to use an already generated primary interop assembly for the COM component. When you use this wrapper tool, do not specify a wrapper output directory because that causes the task to fail.<br />-   `TLBImp`: Use this wrapper tool when you want to generate an interop assembly for the COM component.<br /> -   `PrimaryOrTLBImp`: Use this wrapper tool when you are unsure whether `Primary` or `TLBImp` is appropriate. The `Primary` logic is applied first, then `TLBImp`.<br />-   `AXImp`: Use this wrapper tool when you want to generate an interop assembly for an ActiveX Control.|

## TypeLibFiles item metadata

 The following table describes the item metadata available for items passed to the `TypeLibFiles` parameter.

|Metadata|Description|
|--------------|-----------------|
|`EmbedInteropTypes`|Optional `Boolean` parameter.<br /><br />  If `true`, embed the interop types from this reference directly into your assembly rather than generating an interop DLL.|
|`WrapperTool`|Optional item metadata.<br /><br /> Specifies the wrapper tool that is used to generate the assembly wrapper for this type library. If this item metadata is not specified, the task uses a default wrapper tool of "tlbimp." The available, case insensitive choices of type libraries are:<br /><br /> -   `Primary`: Use this wrapper tool when you want to use an already generated primary interop assembly for the COM component. When you use this wrapper tool, do not specify a wrapper output directory because that causes the task to fail.<br />-   `TLBImp`: Use this wrapper tool when you want to generate an interop assembly for the COM component.<br />-   `AXImp`: Use this wrapper tool when you want to generate an interop assembly for an ActiveX Control.|

> [!NOTE]
> The more information that you provide to uniquely identify a type library, the greater the possibility that the task resolves to the correct file on disk.

## Remarks

In addition to the parameters listed in this article, this task inherits parameters from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [Task base class](../msbuild/task-base-class.md).

The COM DLL doesn't need to be registered on the machine for this task to work.

## MSB4803 Error

If you try to run a project that uses the `ResolveCOMReference` task from the `dotnet` CLI commands, you get the error:

```output
MSB4803: The task "ResolveComReference" is not supported on the .NET Core version of MSBuild. Please use the .NET Framework version of MSBuild.
```

This task is not supported on the .NET Core version of MSBuild, which is what's used when you run the `dotnet build` command from the command line. Try building the project by invoking [MSBuild.exe](msbuild-command-line-reference.md) from the Visual Studio Developer Command Prompt, since this executable uses the .NET Framework version of MSBuild.

## Related content

- [Troubleshoot COM references](troubleshoot-com-references.md).
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
