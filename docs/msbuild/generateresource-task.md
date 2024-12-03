---
title: GenerateResource Task
description: Use the MSBuild GenerateResource task to convert between .txt or .resx files and common language runtime binary .resources files.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#GenerateResource
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, GenerateResource task
- GenerateResource task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# GenerateResource task

Converts between `.txt` and `.resx` (XML-based resource format) files and common language runtime binary `.resources` files that can be embedded in a runtime binary executable or compiled into satellite assemblies. This task is typically used to convert `.txt` or `.resx` files to `.resources` files. The `GenerateResource` task is functionally similar to [resgen.exe](/dotnet/framework/tools/resgen-exe-resource-file-generator).

> [!CAUTION]
> Resources in `.resx` files may be serialized using `BinaryFormatter`, which is [not secure](/dotnet/standard/serialization/binaryformatter-security-guide). Include only those `.resx` files in your build process that you trust.

## Parameters

The following table describes the parameters of the `GenerateResource` task.

|Parameter|Description|
|---------------|-----------------|
|`AdditionalInputs`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Contains additional inputs to the dependency checking done by this task. For example, the project and targets files typically should be inputs, so that if they are updated, all resources are regenerated.|
|`EnvironmentVariables`|Optional `String[]` parameter.<br /><br /> Specifies an array of name-value pairs of environment variables that should be passed to the spawned *resgen.exe*, in addition to (or selectively overriding) the regular environment block.|
|`ExcludedInputPaths`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies an array of items that specify paths from which tracked inputs will be ignored during Up-to-date checking.|
|`ExecuteAsTool`|Optional `Boolean` parameter.<br /><br /> If `true`, runs *tlbimp.exe* and *aximp.exe* from the appropriate target framework out-of-proc to generate the necessary wrapper assemblies. This parameter allows multi-targeting of `ResolveComReferences`.|
|`FilesWritten`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the names of all files written to disk, including the cache file, if any. This parameter is useful for implementations of Clean.|
|`MinimalRebuildFromTracking`|Optional `Boolean` parameter.<br /><br /> Gets or sets a switch that specifies whether tracked incremental build will be used. If `true`, incremental build is turned on; otherwise, a rebuild will be forced.|
|`NeverLockTypeAssemblies`|Optional `Boolean` parameter.<br /><br /> Gets or sets a Boolean value that specifies whether to create a new [AppDomain](/dotnet/api/system.appdomain) to evaluate the resources (`.resx`) files (true) or to create a new [AppDomain](/dotnet/api/system.appdomain) only when the resources files reference a user's assembly (false).|
|`OutputResources`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the name of the generated files, such as `.resources` files. If you do not specify a name, the name of the matching input file is used and the `.resources` file that is created is placed in the directory that contains the input file.|
|`PublicClass`|Optional `Boolean` parameter.<br /><br /> If `true`, creates a strongly typed resource class as a public class.|
|`References`|Optional `String[]` parameter.<br /><br /> References to load types in `.resx` files from. `.resx` file data elements may have a .NET type. When the *.resx* file is read, this type must be resolved. Typically, it is resolved successfully by using standard type loading rules. If you provide assemblies in `References`, they take precedence.<br /><br /> This parameter isn't required for strongly typed resources.|
|`SdkToolsPath`|Optional `String` parameter.<br /><br /> Specifies the path to the SDK tools, such as *resgen.exe*.|
|`Sources`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the items to convert. Items passed to this parameter must have one of the following file extensions:<br /><br /> -   `.txt`: Specifies the extension for a text file to convert. Text files can only contain string resources.<br />-   `.resx`: Specifies the extension for an XML-based resource file to convert.<br />-   `.restext`: Specifies the same format as `.txt`. This different extension is useful if you want to clearly distinguish source files that contain resources from other source files in your build process.<br />-   `.resources`: Specifies the extension for a resource file to convert.|
|`StateFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the path to an optional cache file that is used to speed up dependency checking of links in `.resx` input files.|
|`StronglyTypedClassName`|Optional `String` parameter.<br /><br /> Specifies the class name for the strongly typed resource class. If this parameter isn't specified, the base name of the resource file is used.|
|`StronglyTypedFilename`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the filename for the source file. If this parameter isn't specified, the name of the class is used as the base filename, with the extension dependent on the language. For example: *MyClass.cs*.|
|`StronglyTypedLanguage`|Optional `String` parameter.<br /><br /> Specifies the language to use when generating the class source for the strongly typed resource. This parameter must match exactly one of the languages used by the CodeDomProvider. For example: `VB` or `C#`.<br /><br /> By passing a value to this parameter, you instruct the task to generate strongly typed resources.|
|`StronglyTypedManifestPrefix`|Optional `String` parameter.<br /><br /> Specifies the resource namespace or manifest prefix to use in the generated class source for the strongly typed resource.|
|`StronglyTypedNamespace`|Optional `String` parameter.<br /><br /> Specifies the namespace to use for the generated class source for the strongly typed resource. If this parameter isn't specified, any strongly typed resources are in the global namespace.|
|`TLogReadFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` read-only parameter.<br /><br /> Gets an array of items that represent the read tracking logs.|
|`TLogWriteFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` read-only parameter.<br /><br /> Gets an array of items that represent the write tracking logs.|
|`ToolArchitecture`|Optional <xref:System.String?displayProperty=fullName> parameter.<br /><br /> Used to determine whether or not *Tracker.exe* needs to be used to spawn *ResGen.exe*.<br /><br /> Should be parsable to a member of the <xref:Microsoft.Build.Utilities.ExecutableType> enumeration. If `String.Empty`, uses a heuristic to determine a default architecture. Should be parsable to a member of the `Microsoft.Build.Utilities.ExecutableType` enumeration.|
|`TrackerFrameworkPath`|Optional `String` parameter.<br /><br /> Specifies the path to the appropriate .NET Framework location that contains *FileTracker.dll*.<br /><br /> If set, the user takes responsibility for making sure that the bitness of the *FileTracker.dll* that they pass matches the bitness of the *ResGen.exe* that they intend to use. If not set, the task decides the appropriate location based on the current .NET Framework version.|
|`TrackerLogDirectory`|Optional `String` parameter.<br /><br /> Specifies the intermediate directory into which the tracking logs from running this task will be placed.|
|`TrackerSdkPath`|Optional `String` parameter.<br /><br /> Specifies the path to the appropriate Windows SDK location that contains *Tracker.exe*.<br /><br /> If set, the user takes responsibility for making sure that the bitness of the *Tracker.exe* that they pass matches the bitness of the *ResGen.exe* that they intend to use. If not set, the task decides the appropriate location based on the current Windows SDK.|
|`TrackFileAccess`|Optional <xref:System.Boolean> parameter.<br /><br /> If true, the directory of the input file is used for resolving relative file paths.|
|`UsePreserializedResources`|Optional `Boolean` parameter.<br /><br /> If `true`, specifies that non-String resources are to be serialized using <xref:System.Resources.Extensions.PreserializedResourceWriter> instead of <xref:System.Resources.ResourceWriter>, which isn't supported on .NET Core or .NET 5 or later.|
|`UseSourcePath`|Optional `Boolean` parameter.<br /><br /> If `true`, specifies that the input file's directory is to be used for resolving relative file paths.|

## Remarks

Because `.resx` files may contain links to other resource files, it isn't sufficient to simply compare `.resx` and `.resources` file timestamps to see if the outputs are up to date. Instead, the `GenerateResource` task follows the links in the `.resx` files and checks the timestamps of the linked files as well. This means that you should not generally use `Inputs` and `Outputs` attributes on the target containing the `GenerateResource` task, as this may cause it to be skipped when it should actually run.

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

When using MSBuild 4.0 to target .NET 3.5 projects, the build may fail on x86 resources. To work around this problem, you can build the target as an AnyCPU assembly.

The parameter `UsePreserializedResources` gets its value from the property `$(GenerateResourceUsePreserializedResources)` in the normal .NET build process. This property is set to `true` by default in .NET Core projects and projects that use .NET 5 or later. You can set `$(GenerateResourceUsePreserializedResources)` to `true` to allow the .NET SDK to build projects targeting .NET Framework 4.6.1 or later that use non-string resources. The assembly `System.Resources.Extensions` must be available at runtime. It is available in .NET Core 3.0 and later and .NET 5 and later, and can be used in .NET Framework 4.6.1 or later via PackageReference.|

## Example

The following example uses the `GenerateResource` task to generate `.resources` files from the files specified by the `Resx` item collection.

```xml
<GenerateResource
    Sources="@(Resx)"
    OutputResources="@(Resx->'$(IntermediateOutputPath)%(Identity).resources')">
    <Output
        TaskParameter="OutputResources"
        ItemName="Resources"/>
</GenerateResource>
```

The `GenerateResource` task uses the `<LogicalName>` metadata of an `<EmbeddedResource>` item to name the resource that is embedded in an assembly.

Assuming that the assembly is named myAssembly, the following code generates an embedded resource named `someQualifier.someResource.resources`:

```xml
<ItemGroup>
    <EmbeddedResource Include="myResource.resx">
        <LogicalName>someQualifier.someResource.resources</LogicalName>
        <WithCulture>false</WithCulture>
    </EmbeddedResource>
</ItemGroup>
```

Without the `<LogicalName>` metadata, the resource would be named `myAssembly.myResource.resources`.  This example applies only to the Visual Basic and Visual C# build process.

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
