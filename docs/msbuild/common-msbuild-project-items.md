---
title: Common MSBuild Project Items
description: Learn about common MSBuild project items. Items are named references to one or more strings (for example, filenames), and have metadata like file names, paths, and version numbers.
ms.date: 4/2/2025
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, common project items
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Common MSBuild project items

In MSBuild, an item is a named reference to one or more strings, such as filenames. Items contain metadata such as file names, paths, and version numbers. All project types in Visual Studio have several items in common. These items are defined in the file *Microsoft.Build.CommonTypes.xsd*.

This article lists all the common project items defined in MSBuild itself. Items and properties provided by the .NET SDK are documented at [MSBuild reference for Microsoft.Net.Sdk](/dotnet/core/project-sdk/msbuild-props).

## `Reference`

Represents a .NET assembly (managed) reference in the project.

|Item metadata name|Description|
|---------------|-----------------|
|HintPath|Optional string. Relative or absolute path of the assembly.|
|Name|Optional string. The display name of the assembly, for example, "System.Windows.Forms."|
|FusionName|Optional string. Specifies the simple or strong fusion name for the item.<br /><br /> When this attribute is present, it can save time because the assembly file doesn't have to be opened to obtain the fusion name.|
|SpecificVersion|Optional boolean. Specifies whether only the version in the fusion name should be referenced.|
|Aliases|Optional string. Any aliases for the reference.|
|Private|Optional boolean. Specifies whether the reference should be copied to the output folder. This attribute matches the **Copy Local** property of the reference that's in the Visual Studio IDE.|

> [!NOTE]
> The `Reference` item type can also be use to reference pregenerated wrapper assemblies for native COM objects, for example, if you used `tlbimp` to generate a PIA (Primary Interop Assembly). This type of reference is an appropriate choice when you want to pregenerate the COM wrapper assemblies yourself with known inputs, instead of relying on MSBuild's algorithm to generate COM wrappers at build time, which introduces a dependency on the state of the system registry on the build machine where MSBuild is run. 

## COMReference

Represents a COM (unmanaged) component reference in the project. This item is used by the [ResolveComReference task](./resolvecomreference-task.md), which generates the wrapper assemblies, or, if `EmbedInteropTypes` is used, embeds the interop types in your assembly. Using this type of reference introduces a dependency on the system registry on the build machine, which is used to look up the referenced COM object. COM artifacts and COM entries in the registry can change when products are installed, updated, or uninstalled on the machine (or when you run the same build on a different machine), potentially producing a different wrapper assembly even if the build logic hasn't changed.

This item doesn't apply to C++ projects.

|Item metadata name|Description|
|---------------|-----------------|
|Name|Optional string. The display name of the component.|
|Guid|Required string. A GUID for the component, in the form {12345678-1234-1234-1234-123456781234}.|
|VersionMajor|Required string. The major part of the version number of the component. For example, "5" if the full version number is "5.46."|
|VersionMinor|Required string. The minor part of the version number of the component. For example, "46" if the full version number is "5.46."|
|EmbedInteropTypes|Optional boolean. If true, embed the interop types from this reference directly into your assembly rather than generating an interop DLL.|
|Lcid|Optional string. The LocaleID for the component.|
|WrapperTool|Optional string. The name of the wrapper tool that is used on the component. Values are:<br /><br />1. primary<br />2. tlbimp<br />3. primaryortlbimp<br />4. `aximp`|
|Isolated|Optional boolean. Specifies whether the component is a reg-free component.|

## COMFileReference

Represents a list of type libraries to reference by file path, instead of using the system registry. This type of reference can be a good alternative to COMReference in cases where want to avoid a dependency on the build machine's registry, either because the account that runs the build doesn't have elevated privileges to edit the registry on the build server, or you don't want the build to have a dependency on the state of the registry. If you use `COMFileReference` to reference an artifact on a system path, then your build has a dependency on the system state. If the system artifact changes due to a change in the state of the system, such as when products are installed, updated, or uninstalled (or if you run the same build on a different machine), then the wrapper assembly can change, even if the build logic hasn't changed. To ensure a consistent build result, you can cache a known copy of the COM artifact in a place you control, such as under your project or solution folder, and reference that instead of the system artifact.

This item doesn't apply to non-.NET projects.

|Item metadata name|Description|
|---------------|-----------------|
|EmbedInteropTypes|Optional boolean. If true, embed the interop types from this reference directly into your assembly rather than generating an interop DLL.|
|WrapperTool|Optional string. The name of the wrapper tool that is used on the component. Values are:<br /><br />1.  primary<br />2. tlbimp<br />3. primaryortlbimp<br />4. `aximp`|

## NativeReference

Represents a native manifest file or a reference to such a file.

|Item metadata name|Description|
|---------------|-----------------|
|Name|Required string. The base name of the manifest file.|
|HintPath|Required string. The relative path of the manifest file.|

## ProjectReference

Represents a reference to another project. `ProjectReference` items are transformed into [Reference](#reference) items by the `ResolveProjectReferences` target, so any valid metadata on a Reference may be valid on `ProjectReference`, if the transformation process doesn't overwrite it.

|Item metadata name|Description|
|---------------|-----------------|
|Name|Optional string. The display name of the reference.|
|GlobalPropertiesToRemove|Optional `string[]`. Names of properties to remove when building the referenced project, for example `RuntimeIdentifier;PackOnBuild`. Defaults to empty.|
|Project|Optional string. A GUID for the reference, in the form {12345678-1234-1234-1234-123456781234}.|
|OutputItemType|Optional string. Item type to emit target outputs into. Default is blank. If the Reference metadata is set to "true" (default), then target outputs become references for the compiler.|
|ReferenceOutputAssembly|Optional boolean. If set to `false`, doesn't include the output of the referenced project as a [Reference](#reference) of this project, but still ensures that the other project builds before this one. Defaults to `true`.|
|Private|Optional boolean. Specifies whether the reference should be copied to the output folder. This attribute matches the **Copy Local** property of the reference that's in the Visual Studio IDE.|
|SetConfiguration|Optional string. Sets the global property `Configuration` for the referenced project, for example `Configuration=Release`.|
|SetPlatform|Optional string. Sets the global property `Platform` for the referenced project, for example `Platform=AnyCPU`.|
|SetTargetFramework|Optional string. Sets the global property `TargetFramework` for the referenced project, for example `TargetFramework=netstandard2.0`.|
|SkipGetTargetFrameworkProperties|Optional boolean. If `true`, builds the referenced project without negotiating the most compatible `TargetFramework` value. Defaults to `false`.|
|Targets|Optional `string[]`. Semicolon separated list of targets in the referenced projects that should be built. Default is the value of `$(ProjectReferenceBuildTargets)`, which defaults to empty, indicating the default targets. When building in Visual Studio (as opposed to `MSBuild.exe` or `dotnet build`), specifying this does not prevent Visual Studio from building the default targets of the referenced project.|

> [!NOTE]
> There is a difference between how project references work between .NET Framework and .NET Core (including .NET 5 and later). In .NET Framework projects, project references aren't transitive. That is, if Project1 references Project2, and Project2 references Project3, you can't code against Project3 from Project1. However, in .NET Core (including .NET 5 and later), project references *are* transitive. You can code against Project3 in Project1.

## Compile

Represents the source files for the compiler.

| Item metadata name | Description |
|-----------------------| - |
| DependentUpon | Optional string. Specifies the file this file depends on to compile correctly. |
| AutoGen | Optional boolean. Indicates whether the file was generated for the project by the Visual Studio integrated development environment (IDE). |
| Link | Optional string. The notational path to be displayed when the file is physically located outside the influence of the project file. |
| Visible | Optional boolean. Indicates whether to display the file in **Solution Explorer** in Visual Studio. |
| CopyToOutputDirectory | Optional string. Determines whether to copy the file to the output directory. Values are:<br /><br /> 1. Never<br />2. Always<br />3. PreserveNewest<br />4. IfDifferent |

## EmbeddedResource

Represents resources to be embedded in the generated assembly.

| Item metadata name | Description |
|-----------------------| - |
| Culture | Optional string. Specifies the culture of the resource file. If specified, the build process doesn't auto-infer the culture based on file extension (which is dependent on the cultures available to .NET/OS on the machine hosting the build). Setting either `Culture={culture identifier}` or `WithCulture=false` metadata is highly recommended. |
| WithCulture | Optional bool. Specifies that the file is culture neutral and culture detection by [`AssignCulture`](./assignculture-task.md) task should be skipped. Setting either `Culture={culture identifier}` or `WithCulture=false` metadata is highly recommended. |
| DependentUpon | Optional string. Specifies the file this file depends on to compile correctly |
| Generator | Optional string. The name of any file generator that is run on this item. |
| LastGenOutput | Optional string. The name of the file that was created by any file generator that ran on this item. |
| CustomToolNamespace | Optional string. The namespace in which any file generator that runs on this item should create code. |
| Link | Optional string. The notational path is displayed if the file is physically located outside the influence of the project. |
| Visible | Optional boolean. Indicates whether to display the file in **Solution Explorer** in Visual Studio. |
| CopyToOutputDirectory | Optional string. Determines whether to copy the file to the output directory. Values are:<br /><br /> 1. Never<br />2. Always<br />3. PreserveNewest<br />4. IfDifferent |
| LogicalName | Required string. The logical name of the embedded resource. |

## Content

Represents files that aren't compiled into the project, but may be embedded or published together with it.

| Item metadata name | Description |
|-----------------------| - |
| DependentUpon | Optional string. Specifies the file this file depends on to compile correctly. |
| Generator | Optional string. The name of any file generator that runs on this item. |
| LastGenOutput | Optional string. The name of the file that was created by any file generator that was run on this item. |
| CustomToolNamespace | Optional string. The namespace in which any file generator that runs on this item should create code. |
| Link | Optional string. The notational path to be displayed if the file is physically located outside the influence of the project. |
| PublishState | Required string. The publish state of the content, either:<br /><br /> - Default<br />-   Included<br />-  Excluded<br />- DataFile<br />- Prerequisite |
| IsAssembly | Optional boolean. Specifies whether the file is an assembly. |
| Visible | Optional boolean. Indicates whether to display the file in **Solution Explorer** in Visual Studio. |
| CopyToOutputDirectory | Optional string. Determines whether to copy the file to the output directory. Values are:<br /><br /> 1. Never<br />2. Always<br />3. PreserveNewest<br />4. IfDifferent |
| TargetPath | Optional string. The output path (relative to the configuration- and/or platform-specific output directory) of an item, including the filename. This respects the `Link` metadata, if provided. If TargetPath isn't provided, it's computed during the build process. See [AssignTargetPath](assigntargetpath-task.md). |

## None

Represents files that should have no role in the build process.

| Item metadata name | Description |
|-----------------------| - |
| DependentUpon | Optional string. Specifies the file this file depends on to compile correctly. |
| Generator | Optional string. The name of any file generator that is run on this item. |
| LastGenOutput | Optional string. The name of the file that was created by any file generator that ran on this item. |
| CustomToolNamespace | Optional string. The namespace in which any file generator that runs on this item should create code. |
| Link | Optional string. The notational path to be displayed if the file is physically located outside the influence of the project. |
| Visible | Optional boolean. Indicates whether to display the file in **Solution Explorer** in Visual Studio. |
| CopyToOutputDirectory | Optional string. Determines whether to copy the file to the output directory. Values are:<br /><br /> 1. Never<br />2. Always<br />3. PreserveNewest<br />4. IfDifferent |

## AssemblyMetadata

Represents assembly attributes to be generated as `[AssemblyMetadata(key, value)]`.

| Item metadata name | Description |
|-----------------------| - |
| Include | Becomes the first parameter (the key) in the `AssemblyMetadataAttribute` attribute constructor. |
| Value | Required string. Becomes the second parameter (the value) in the `AssemblyMetadataAttribute` attribute constructor. |

> [!NOTE]
> This item applies to projects using the SDK for .NET 5 (and .NET Core) and later versions.

## InternalsVisibleTo

Specifies assemblies to be emitted as `[InternalsVisibleTo(..)]` assembly attributes.

| Item metadata name | Description |
|-----------------------| - |
| Include | The assembly name. |
| Key | Optional string. The public key of the assembly. |

> [!NOTE]
> This item applies to projects using the SDK for .NET 5 (and .NET Core) and later versions.

## BaseApplicationManifest

Represents the base application manifest for the build, and contains ClickOnce deployment security information.

## CodeAnalysisImport

Represents the FxCop project to import.

## Import

Represents assemblies whose namespaces should be imported by the Visual Basic compiler.

## Folder

This element is only used by Visual Studio as a placeholder for an empty folder. When the folder is populated, it's replaced by another element.

## See also

- [Common MSBuild project properties](../msbuild/common-msbuild-project-properties.md)
- [Common MSBuild item metadata](common-msbuild-item-metadata.md)
