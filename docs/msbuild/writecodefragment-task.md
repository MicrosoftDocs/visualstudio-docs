---
title: WriteCodeFragment Task
description: Learn how MSBuild uses the WriteCodeFragment task to generate a temporary code file from the specified generated code fragment.
ms.date: 02/28/2025
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, WriteCodeFragment task
- WriteCodeFragment task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# WriteCodeFragment task

Generates a temporary code file from the specified generated code fragment. Does not delete the file.

## Parameters

 The following table describes the parameters of the `WriteCodeFragment` task.

|Parameter|Description|
|---------------|-----------------|
|`AssemblyAttributes`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Description of the attributes to write. The item `Include` value is the full type name of the attribute, for example, `System.AssemblyVersionAttribute`.<br /><br /> Each metadata is the name-value pair of a parameter. Parameters are assumed to be of type `String` in MSBuild 17.6 and earlier, but in MSBuild 17.7 and later, you can also use types other than `String` that are part of `mscorlib`. For example, you can use `true` and `false` Boolean values, integers, enums, and floating point types. The type is automatically inferred from the syntax. For a type not in `mscorlib`, specify the type for the parameter by providing metadata values in the form `{parameter}_TypeName`.<br/><br/>Some attributes only allow positional constructor arguments. However, you can use such arguments in any attribute. To set positional constructor attributes, use metadata names that resemble `_Parameter1`, `_Parameter2`, and so on.  A parameter index can't be skipped.<br/><br/>In MSBuild 17.7 or later, you can also specify metadata of the form `{parameter}_IsLiteral` to instruct the task to interpret the parameter value text as is, without surrounding with quotes (as is done in the default case for string values). |
|`Language`|Required `String` parameter.<br /><br /> Specifies the language of the code to generate.<br /><br /> `Language` can be any language for which a CodeDom provider is available, for example, "C#" or "VisualBasic." The emitted file will have the default file name extension for that language.|
|`OutputDirectory`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the destination folder for the generated code, typically the intermediate folder.|
|`OutputFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the path of the file that was generated. If this parameter is set by using a file name, the destination folder is prepended to the file name. If it's set by using a root, the destination folder is ignored.<br /><br /> If this parameter isn't set, the output file name is the destination folder, an arbitrary file name, and the default file name extension for the specified language.|

## Remarks

In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

This task isn't normally used directly in user code.

:::moniker range=">=vs-2022"
## Generate assembly-level attributes

In MSBuild 17.7 and later, this task was updated to support a greater variety of parameter types for assembly-level attributes. MSBuild 17.6 and earlier supported only `String` as a parameter type for assembly-level attributes. With MSBuild 17.7 and later, you can construct any .NET assembly attribute, not only those whose parameters were string types, as in earlier versions of MSBuild.

For example, to define the assembly-level attribute `CLSCompliant(true)`, which uses a Boolean parameter, you can use the following syntax:

```xml
<ItemGroup>
    <AssemblyAttribute Include="System.CLSCompliantAttribute">
        <_Parameter1>true</_Parameter1>
    </AssemblyAttribute>
</ItemGroup>
```

The code generated depends on the target language. For C#, it would be as follows:

```csharp
[assembly: System.CLSCompliantAttribute(true)]
```

Types defined in `mscorlib` are automatically inferred, such as Boolean in the previous example. You can define metadata of the form `{parameter}_TypeName` to specify types that can't be inferred.

```xml
<ItemGroup>
    <AssemblyAttribute Include="Microsoft.Owin.OwinStartup">
        <_Parameter1>Microsoft.Examples.Startup</_Parameter1>
        <_Parameter1_TypeName>System.Type</_Parameter1_TypeName>
    </AssemblyAttribute>
</ItemGroup>
```

The code generated in C# is as follows:

```csharp
[assembly: Microsoft.Owin.OwinStartup(typeof(Microsoft.Examples.Startup))]
```

For more complicated parameter values, you can use the `{parameter}_IsLiteral`.

```xml
<ItemGroup>
    <AssemblyAttribute Include="NUnit.Framework.Parallelizable">
        <_Parameter1>NUnit.Framework.ParallelScope.Fixtures</_Parameter1>
        <_Parameter1_IsLiteral>true</_Parameter1_IsLiteral>
    </AssemblyAttribute>
</ItemGroup>
```

The previous example produces the following assembly attribute in C#:

```output
[assembly: NUnit.Framework.Parallelizable(NUnit.Framework.ParallelScope.Fixtures)]
```

You can use any syntax that would normally be allowed in an attribute declaration in the language of the project. For an array parameter, you can use code like the following:

```xml
<ItemGroup>
  <AssemblyAttribute Include="TestAttribute">
    <_Parameter1>new int[] { 1, 3, 5 } /* odd numbers */</_Parameter1>
    <_Parameter1_IsLiteral>true</_Parameter1_IsLiteral>
  </AssemblyAttribute>
</ItemGroup>
```

When you use `IsLiteral`, the syntax is interpreted by the appropriate compiler, and is therefore language-specific. If you have situations where more than one language share the same MSBuild import files and/or project files, you might need to use conditional syntax to ensure the code compiles with the relevant project-specific language.

> [!NOTE]
> The syntax described in this section (`_TypeName` and `_IsLiteral` suffixes) isn't supported in F#.
:::moniker-end

## Example

A typical use case for the `WriteCodeFragment` task is in a target that generates a file that defines an assembly-level attribute and adds that to the build. With `AssemblyAttribute` defined, you can invoke the `WriteCodeFragment` task as in the following code.

```xml
<Target Name="AddAssemblyVersion" BeforeTargets="Build">
  <ItemGroup>
     <AssemblyAttribute Include="AssemblyVersion">
       <_Parameter1>1.2.3.4</_Parameter1>
     </AssemblyAttribute>
  </ItemGroup>
  <WriteCodeFragment AssemblyAttributes="@(AssemblyAttribute)"
                     Language="C#"
                     OutputDirectory="$(IntermediateOutputPath)"
                     OutputFile="AssemblyVersion.cs">
    <Output TaskParameter="OutputFile" ItemName="Compile" />
    <Output TaskParameter="OutputFile" ItemName="FileWrites" />
  </WriteCodeFragment>
</Target>
```

The `OutputFile` is given a specific filename; if not specified, a filename is randomly generated. Also, to add the generated file to the build, the `Compile` item list is given as an output. The file is also added to the `FileWrites` item list, so that it is deleted when the `Clean` target is run.

### Handle incremental build

You might need to take special care to ensure that your use of the `WriteCodeFragment` task doesn't break [incremental build](how-to-build-incrementally.md). To emit the assembly version in code, you wouldn't want to force everything to rebuilt unless the assembly number changed. To accomplish this, you can emit a file using `WriteLinesToFile` and use that as an input for the `AddAssemblyVersion` task. The input can't just be a property, it has to be a file timestamp comparison in order for the incremental build mechanism to work. The following example shows how you might implement `AddAssemblyVersion` in real-world code to preserve incremental build:

```xml
<Project DefaultTargets="WriteFile">
    <PropertyGroup>
        <Version>1.2.3.4</Version>
    </PropertyGroup>

    <!-- This target ensures that we cache the inputs to the generated C# file so that we only run that generation
         when the inputs change. Since some inputs are not Files, we have to 'elevate' them to the file level 
         in some way. The easiest way is to literally write a file.
        
         There are no inputs/outputs because we need to compute paths everytime -
            however we get 'incrementality' because the WriteLinesToFile task will only write the file if the
            contents are different.

        We need to
          * write the cache file to use as an input to the next target
          * compute the generated file path to use an an output in the next target
    -->
    <Target Name="ComputeVersionFileWrite">
        <WriteLinesToFile File="$(IntermediateOutputPath)AssemblyVersion_cache.txt" Lines="$(Version)"
            WriteOnlyWhenDifferent="true"
            Overwrite="true" />
        <ItemGroup>
            <FileWrites Include="$(IntermediateOutputPath)AssemblyVersion_cache.txt" />
            <_GeneratedAssemblyVersionFile Include="$(IntermediateOutputPath)AssemblyVersion.cs" />
        </ItemGroup>
    </Target>

    <!-- with all the work done above, this Target looks simple. The main thing we do here
    is, if we write a file, add it to FileWrites for cleanup.  -->
    <Target Name="WriteFile" DependsOnTargets="ComputeVersionFileWrite" Inputs="$(IntermediateOutputPath)AssemblyVersion_cache.txt" Outputs="@(_GeneratedAssemblyVersionFile)">
        <ItemGroup>
            <AssemblyAttribute Include="AssemblyVersion">
                <_Parameter1>$(Version)</_Parameter1>
            </AssemblyAttribute>
        </ItemGroup>
        <WriteCodeFragment AssemblyAttributes="@(AssemblyAttribute)"
                            Language="C#"
                            OutputDirectory="$(IntermediateOutputPath)"
                            OutputFile="AssemblyVersion.cs" >
            <Output TaskParameter="OutputFile" ItemName="FileWrites" />
        </WriteCodeFragment>
    </Target>
</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
