---
title: "Extend the build process"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "MSBuild, overriding predefined targets"
  - "MSBuild, overriding DependsOn properties"
  - "MSBuild, extending Visual Studio builds"
  - "MSBuild, DependsOn properties"
ms.assetid: cb077613-4a59-41b7-96ec-d8516689163c
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Extend the Visual Studio build process
The [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] build process is defined by a series of [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] *.targets* files that are imported into your project file. One of these imported files, *Microsoft.Common.targets*, can be extended to allow you to run custom tasks at several points in the build process. This article explains two methods you can use to extend the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] build process:

- Overriding specific predefined targets defined in the common targets (*Microsoft.Common.targets* or the files that it imports).

- Overriding the "DependsOn" properties defined in the common targets.

## Override predefined targets
The common targets contains a set of predefined empty targets that is called before and after some of the major targets in the build process. For example, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] calls the `BeforeBuild` target before the main `CoreBuild` target and the `AfterBuild` target after the `CoreBuild` target. By default, the empty targets in the common targets do nothing, but you can override their default behavior by defining the targets you want in a project file that imports the common targets. By overriding the predefined targets, you can use [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] tasks to give you more control over the build process.

> [!NOTE]
> SDK-style projects have an implicit import of targets *after the last line of the project file*. This means that you cannot override default targets unless you specify your imports manually as described in [How to: Use MSBuild project SDKs](how-to-use-project-sdk.md).

#### To override a predefined target

1. Identify a predefined target in the common targets that you want to override. See the table below for the complete list of targets that you can safely override.

2. Define the target or targets at the end of your project file, immediately before the `</Project>` tag. For example:

    ```xml
    <Project>
        ...
        <Target Name="BeforeBuild">
            <!-- Insert tasks to run before build here -->
        </Target>
        <Target Name="AfterBuild">
            <!-- Insert tasks to run after build here -->
        </Target>
    </Project>
    ```

3. Build the project file.

The following table shows all of the targets in the common targets that you can safely override.

|Target name|Description|
|-----------------|-----------------|
|`BeforeCompile`, `AfterCompile`|Tasks that are inserted in one of these targets run before or after core compilation is done. Most customizations are done in one of these two targets.|
|`BeforeBuild`, `AfterBuild`|Tasks that are inserted in one of these targets will run before or after everything else in the build. **Note:**  The `BeforeBuild` and `AfterBuild` targets are already defined in comments at the end of most project files, allowing you to easily add pre- and post-build events to your project file.|
|`BeforeRebuild`, `AfterRebuild`|Tasks that are inserted in one of these targets run before or after the core rebuild functionality is invoked. The order of target execution in *Microsoft.Common.targets* is: `BeforeRebuild`, `Clean`, `Build`, and then `AfterRebuild`.|
|`BeforeClean`, `AfterClean`|Tasks that are inserted in one of these targets run before or after the core clean functionality is invoked.|
|`BeforePublish`, `AfterPublish`|Tasks that are inserted in one of these targets run before or after the core publish functionality is invoked.|
|`BeforeResolveReferences`, `AfterResolveReferences`|Tasks that are inserted in one of these targets run before or after assembly references are resolved.|
|`BeforeResGen`, `AfterResGen`|Tasks that are inserted in one of these targets run before or after resources are generated.|

## Override DependsOn properties
Overriding predefined targets is an easy way to extend the build process, but, because [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] evaluates the definition of targets sequentially, there is no way to prevent another project that imports your project from overriding the targets you already have overridden. So, for example, the last `AfterBuild` target defined in the project file, after all other projects have been imported, will be the one that is used during the build.

You can guard against unintended overrides of targets by overriding the DependsOn properties that are used in `DependsOnTargets` attributes throughout the common targets. For example, the `Build` target contains a `DependsOnTargets` attribute value of `"$(BuildDependsOn)"`. Consider:

```xml
<Target Name="Build" DependsOnTargets="$(BuildDependsOn)"/>
```

This piece of XML indicates that before the `Build` target can run, all the targets specified in the `BuildDependsOn` property must run first. The `BuildDependsOn` property is defined as:

```xml
<PropertyGroup>
    <BuildDependsOn>
        BeforeBuild;
        CoreBuild;
        AfterBuild
    </BuildDependsOn>
</PropertyGroup>
```

You can override this property value by declaring another property named `BuildDependsOn` at the end of your project file. By including the previous `BuildDependsOn` property in the new property, you can add new targets to the beginning and end of the target list. For example:

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

Projects that import your project files can override these properties without overwriting the customizations that you have made.

#### To override a DependsOn property

1. Identify a predefined DependsOn property in the common targets that you want to override. See the table below for a list of the commonly overridden DependsOn properties.

2. Define another instance of the property or properties at the end of your project file. Include the original property, for example `$(BuildDependsOn)`, in the new property.

3. Define your custom targets before or after the property definition.

4. Build the project file.

### Commonly overridden DependsOn properties

|Property name|Description|
|-------------------|-----------------|
|`BuildDependsOn`|The property to override if you want to insert custom targets before or after the entire build process.|
|`CleanDependsOn`|The property to override if you want to clean up output from your custom build process.|
|`CompileDependsOn`|The property to override if you want to insert custom processes before or after the compilation step.|

## See also
- [Visual Studio integration](../msbuild/visual-studio-integration-msbuild.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [.targets files](../msbuild/msbuild-dot-targets-files.md)
