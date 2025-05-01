---
title: Extend and customize the build process
description: Explore several ways you can modify the build process so you can control and customize how your projects build, including overriding properties.
ms.date: 5/1/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, overriding predefined targets
- MSBuild, overriding DependsOn properties
- MSBuild, extending Visual Studio builds
- MSBuild, DependsOn properties
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Extend the Visual Studio build process

The Visual Studio build process is defined by a series of MSBuild `.targets` files that are imported into your project file. These imports are implicit, if you use an SDK as Visual Studio projects usually do. One of these imported files, *Microsoft.Common.targets*, can be extended to allow you to run custom tasks at several points in the build process. This article explains three methods you can use to extend the Visual Studio build process:

- Create a custom target and specify when it should run by using `BeforeTargets` and `AfterTargets` attributes.

- Override the `DependsOn` properties defined in the common targets.

- Override specific predefined targets defined in the common targets (*Microsoft.Common.targets* or the files that it imports).

## AfterTargets and BeforeTargets

You can use `AfterTargets` and `BeforeTargets` attributes on your custom target to specify when it should run.

The following example shows how to use the `AfterTargets` attribute to add a custom target that does something with the output files. In this case, it copies the output files to a new folder *CustomOutput*.  The example also shows how to clean up the files created by the custom build operation with a `CustomClean` target by using a `BeforeTargets` attribute and specifying that the custom clean operation runs before the `CoreClean` target.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
     <TargetFramework>netcoreapp3.1</TargetFramework>
     <_OutputCopyLocation>$(OutputPath)..\..\CustomOutput\</_OutputCopyLocation>
  </PropertyGroup>

  <Target Name="CustomAfterBuild" AfterTargets="Build">
    <ItemGroup>
      <_FilesToCopy Include="$(OutputPath)**\*"/>
    </ItemGroup>
    <Message Text="_FilesToCopy: @(_FilesToCopy)" Importance="high"/>

    <Message Text="DestFiles:
        @(_FilesToCopy->'$(_OutputCopyLocation)%(RecursiveDir)%(Filename)%(Extension)')"/>

    <Copy SourceFiles="@(_FilesToCopy)"
          DestinationFiles=
          "@(_FilesToCopy->'$(_OutputCopyLocation)%(RecursiveDir)%(Filename)%(Extension)')"/>
  </Target>

  <Target Name="CustomClean" BeforeTargets="CoreClean">
    <Message Text="Inside Custom Clean" Importance="high"/>
    <ItemGroup>
      <_CustomFilesToDelete Include="$(_OutputCopyLocation)**\*"/>
    </ItemGroup>
    <Delete Files='@(_CustomFilesToDelete)'/>
  </Target>
</Project>
```

> [!WARNING]
> Be sure to use different names than the predefined targets (for example, the custom build target here is `CustomAfterBuild`, not `AfterBuild`), since those predefined targets are overridden by the SDK import which also defines them. Refer to the [table](#table-of-predefined-targets) at the end of this article for a list of predefined targets.

## Extend the DependsOn properties

Another way to extend the build process is to use the `DependsOn` properties (for example, `BuildDependsOn`), to specify targets that should be run before a standard target.

This method is preferable to overriding predefined targets, which is discussed in the next section. Overriding predefined targets is an older method that is still supported, but, because MSBuild evaluates the definition of targets sequentially, there's no way to prevent another project that imports your project from overriding the targets you already have overridden. So, for example, the last `AfterBuild` target defined in the project file, after all other projects have been imported, will be the one that is used during the build.

You can guard against unintended overrides of targets by overriding the `DependsOn` properties that are used in `DependsOnTargets` attributes throughout the common targets. For example, the `Build` target contains a `DependsOnTargets` attribute value of `"$(BuildDependsOn)"`. Consider:

```xml
<Target Name="Build" DependsOnTargets="$(BuildDependsOn)"/>
```

This piece of XML indicates that before the `Build` target can run, all the targets specified in the `BuildDependsOn` property must run first. The `BuildDependsOn` property is defined as:

```xml
<PropertyGroup>
    <BuildDependsOn>
        $(BuildDependsOn);
        BeforeBuild;
        CoreBuild;
        AfterBuild
    </BuildDependsOn>
</PropertyGroup>
```

You can override this property value by declaring another property named `BuildDependsOn` at the end of your project file. In an SDK-style project, this means you have to use explicit imports. See [Implicit and explicit imports](#explicit-and-implicit-imports), so that you can put the `DependsOn` property after the last import. By including the previous `BuildDependsOn` property in the new property, you can add new targets to the beginning and end of the target list. For example:

```xml
<PropertyGroup>
    <BuildDependsOn>
        MyCustomTarget1;
        $(BuildDependsOn);
        MyCustomTarget2
    </BuildDependsOn>
</PropertyGroup>

<Target Name="MyCustomTarget1">
    <Message Text="Running MyCustomTarget1..."/>
</Target>
<Target Name="MyCustomTarget2">
    <Message Text="Running MyCustomTarget2..."/>
</Target>
```

Projects that import your project file can further extend these properties without overwriting the customizations that you have made.

### To override a DependsOn property

1. Identify a predefined `DependsOn` property in the common targets that you want to override. See the following table for a list of the commonly overridden `DependsOn` properties.

2. Define another instance of the property or properties at the end of your project file. Include the original property, for example `$(BuildDependsOn)`, in the new property.

3. Define your custom targets before or after the property definition.

4. Build the project file.

### Commonly overridden DependsOn properties

| Property name | Added targets run before this point: |
| - | - |
| `BuildDependsOn` | The main build entry point. Override this property if you want to insert custom targets before or after the entire build process. |
| `RebuildDependsOn` | The `Rebuild` |
| `RunDependsOn` | The execution of the final build output (if it's a .EXE) |
| `CompileDependsOn` |The compilation (`Compile` target). Override this property if you want to insert custom processes before or after the compilation step. |
| `CreateSatelliteAssembliesDependsOn` | The creation of the satellite assemblies |
| `CleanDependsOn` | The `Clean` target (Deleting of all intermediate and final build outputs). Override this property if you want to clean up output from your custom build process. |
| `PostBuildEventDependsOn` | The `PostBuildEvent` target |
| `PublishBuildDependsOn` | Build publishing |
| `ResolveAssemblyReferencesDependsOn` | The `ResolveAssemblyReferences` target (finding the transitive closure of dependencies for a given dependency). See [`ResolveAssemblyReference`](resolveassemblyreference-task.md). |

### Example: BuildDependsOn and CleanDependsOn

The following example is similar to the `BeforeTargets` and `AfterTargets` example, but shows how to achieve similar functionality. It extends the build by using `BuildDependsOn` to add your own task `CustomAfterBuild` that copies the output files after the build, and also adds the corresponding `CustomClean` task by using `CleanDependsOn`.  

In this example, this is an SDK-style project. As mentioned in the note about SDK-style projects earlier in this article, you must use the manual import method instead of the `Sdk` attribute that Visual Studio uses when it generates project files.

```xml
<Project>
  <Import Project="Sdk.props" Sdk="Microsoft.NET.Sdk"/>

  <PropertyGroup>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <Import Project="Sdk.targets" Sdk="Microsoft.NET.Sdk"/>

  <PropertyGroup>
    <BuildDependsOn>
      $(BuildDependsOn);CustomAfterBuild
    </BuildDependsOn>

    <CleanDependsOn>
      $(CleanDependsOn);CustomClean
    </CleanDependsOn>

    <_OutputCopyLocation>$(OutputPath)..\..\CustomOutput\</_OutputCopyLocation>
  </PropertyGroup>

  <Target Name="CustomAfterBuild">
    <ItemGroup>
      <_FilesToCopy Include="$(OutputPath)**\*"/>
    </ItemGroup>
    <Message Importance="high" Text="_FilesToCopy: @(_FilesToCopy)"/>

    <Message Text="DestFiles:
      @(_FilesToCopy-&gt;'$(_OutputCopyLocation)%(RecursiveDir)%(Filename)%(Extension)')"/>

    <Copy SourceFiles="@(_FilesToCopy)"
          DestinationFiles="@(_FilesToCopy-&gt;'$(_OutputCopyLocation)%(RecursiveDir)%(Filename)%(Extension)')"/>
  </Target>

  <Target Name="CustomClean">
    <Message Importance="high" Text="Inside Custom Clean"/>
    <ItemGroup>
      <_CustomFilesToDelete Include="$(_OutputCopyLocation)**\*"/>
    </ItemGroup>
    <Delete Files="@(_CustomFilesToDelete)"/>
  </Target>
</Project>
```

The order of elements is important. The `BuildDependsOn` and `CleanDependsOn` elements must appear after importing the standard SDK targets file.

## Override predefined targets

The common `.targets` files contain a set of predefined empty targets that are called before and after some of the major targets in the build process. For example, MSBuild calls the `BeforeBuild` target before the main `CoreBuild` target and the `AfterBuild` target after the `CoreBuild` target. By default, the empty targets in the common targets do nothing, but you can override their default behavior by defining the targets you want in a project file. The methods described earlier in this article are preferred, but you might encounter older code that uses this method.

If your project uses an SDK (for example `Microsoft.Net.Sdk`), you need to make a change from implicit to explicit imports, as discussed in [Explicit and implicit imports](#explicit-and-implicit-imports).

### To override a predefined target

1. If the project uses the `Sdk` attribute, change that to the explicit import syntax. See [Explicit and implicit imports](#explicit-and-implicit-imports).

1. Identify a predefined target in the common targets that you want to override. See the following table for the complete list of targets that you can safely override.

1. Define the target or targets at the end of your project file, immediately before the `</Project>` tag and after the explicit SDK import. For example:

    ```xml
    <Project>
        <Import Project="Sdk.props" Sdk="Microsoft.NET.Sdk" />
        ...
        <Import Project="Sdk.targets" Sdk="Microsoft.NET.Sdk" />
        <Target Name="BeforeBuild">
            <!-- Insert tasks to run before build here -->
        </Target>
        <Target Name="AfterBuild">
            <!-- Insert tasks to run after build here -->
        </Target>
    </Project>
    ```

    Note that the `Sdk` attribute on the top-level `Project` element has been removed.

1. Build the project file.

## Table of predefined targets

The following table shows all of the targets in the common targets that you can override.

|Target name|Description|
|-----------------|-----------------|
|`BeforeCompile`, `AfterCompile`|Tasks that are inserted in one of these targets run before or after core compilation is done. Most customizations are done in one of these two targets.|
|`BeforeBuild`, `AfterBuild`|Tasks that are inserted in one of these targets will run before or after everything else in the build. **Note:**  The `BeforeBuild` and `AfterBuild` targets are already defined in comments at the end of most project files, allowing you to easily add pre- and post-build events to your project file.|
|`BeforeRebuild`, `AfterRebuild`|Tasks that are inserted in one of these targets run before or after the core rebuild functionality is invoked. The order of target execution in *Microsoft.Common.targets* is: `BeforeRebuild`, `Clean`, `Build`, and then `AfterRebuild`.|
|`BeforeClean`, `AfterClean`|Tasks that are inserted in one of these targets run before or after the core clean functionality is invoked.|
|`BeforePublish`, `AfterPublish`|Tasks that are inserted in one of these targets run before or after the core publish functionality is invoked.|
|`BeforeResolveReferences`, `AfterResolveReferences`|Tasks that are inserted in one of these targets run before or after assembly references are resolved.|
|`BeforeResGen`, `AfterResGen`|Tasks that are inserted in one of these targets run before or after resources are generated.|

There are many more targets in the build system and .NET SDK, see [MSBuild targets - SDK and default build targets](msbuild-targets.md#sdk-and-default-build-targets).

## Best practices for custom targets

The properties `DependsOnTargets` and `BeforeTargets` can both specify that a target must run before another target, but they are both needed in different scenarios. They differ in which target the dependency requirement is specified. You only have control over your own targets and can't safely modify the system targets or other imported target, so that constraints your choice of methods.

When authoring a custom target, follow these general guidelines to ensure your target is executed in the intended order.

1. Use the `DependsOnTargets` attribute to specify targets that you require to be done before your target executes. For a chain of targets you control, each target can specify the previous member of the chain in `DependsOnTargets`.

1. Use `BeforeTargets` for any target that you do not control that you must execute before (like `BeforeTargets="PrepareForBuild"` for a target that needs to run early in the build).

1. Use `AfterTargets` for any target that you do not control that guarantees the outputs you need are available. For example, specify `AfterTargets="ResolveReferences"` for something that will modify a list of references.

1. You can use these in combination. For example, `DependsOnTargets="GenerateAssemblyInfo" BeforeTargets="BeforeCompile"`.

## Explicit and implicit imports

Projects generated by Visual Studio usually use the `Sdk` attribute on the project element. These types of projects are called SDK-style projects. See [Use MSBuild project SDKs](how-to-use-project-sdk.md). Here's an example:

```xml
<Project Sdk="Microsoft.Net.Sdk">
```

When your project uses the `Sdk` attribute, two imports are implicitly added, one at the beginning of your project file, and one at the end.

The implicit imports are equivalent to having an import statement like this as the first line in the project file, after the `Project` element:

```xml
<Import Project="Sdk.props" Sdk="Microsoft.NET.Sdk" />
```

and the following import statement as the last line in the project file:

```xml
<Import Project="Sdk.targets" Sdk="Microsoft.NET.Sdk" />
```

This syntax is referred to as *explicit SDK imports*. When you use this explicit syntax, you should omit the `Sdk` attribute on the project element.

The implicit SDK import is equivalent to importing the specific "common"  `.props` or `.targets` files that is a typical construct in older project files, such as:

```xml
<Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
```

and

```xml
<Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
```

Any such old references should be replaced with the explicit SDK syntax shown earlier in this section.

Using the explicit SDK syntax means you can add your own code before the first import, or after the final SDK import. That means you can change the behavior by setting properties before the first import that will take effect in the imported `.props` file, and you can override a target that's defined in one of the SDK `.targets` files after the final import. Using this method, you can override `BeforeBuild` or `AfterBuild` as discussed next.

## Next steps

There's much more you can do with MSBuild to customize the build. See [Customize your build](customize-your-build.md).

## Related content

- [Visual Studio integration](../msbuild/visual-studio-integration-msbuild.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild targets](./msbuild-targets.md)
- [.targets files](../msbuild/msbuild-dot-targets-files.md)
- [Target build order](./target-build-order.md)
