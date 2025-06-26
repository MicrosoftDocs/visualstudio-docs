---
title: Incremental Builds for New or Stale Targets
description: Explore how to use MSBuild to run incremental builds for new or stale targets only, and not for targets that are up-to-date.
ms.date: 06/26/2025
ms.topic: concept-article
helpviewer_keywords:
- MSBuild, incremental builds
- incremental builds
- MSBuild, building incrementally
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
#customer intent: As a developer, I want to run incremental builds with MSBuild, so I can build only new targets or out-of-date targets.
---

# MSBuild incremental builds for new or stale targets

When you build a large project, it's important that built targets that are still up-to-date don't rebuild. If all targets build every time, each build can take a long time to complete.

In an incremental build, only the unbuilt targets of the project or stale (out-of-date) targets build. The Microsoft Build Engine (MSBuild) compares the timestamps of the input files with the timestamps of the output files. MSBuild determines whether to skip, build, or partially rebuild each target.

The incremental build process requires a one-to-one mapping between inputs and outputs for targets. You can use _transforms_ to enable targets to identify the input-to-ouput mapping. For more information, see [Transforms](msbuild-transforms.md).

## Specify inputs and outputs

MSBuild can build a target incrementally if the inputs and outputs in the target are specified in the project file. You specify the values with the `Inputs` and `Outputs` attributes of the `Target` element.

The following example specifies the `@(CSFile)` item list for the `Inputs` and the *hello.exe* file for the `Outputs` of a target:

```xml
<Target Name="Build"
    Inputs="@(CSFile)"
    Outputs="hello.exe">
    ...
</Target>
```

MSBuild compares the timestamps of the inputs and the outputs for the target. In the example, if any file in the `@(CSFile)` item list is newer than the *hello.exe* file, MSBuild builds the target; otherwise, the target is skipped:

```xml
<Target Name="Build"
    Inputs="@(CSFile)"
    Outputs="hello.exe">

    <Csc
        Sources="@(CSFile)"
        OutputAssembly="hello.exe"/>
</Target>
```

## Compare one-to-one mapping versus no direct mapping

When you specify inputs and outputs in a target, either each output maps to one input directly, or no direct mapping exists between the outputs and inputs. In the example, the [Csc task](csc-task.md) specifies an output assembly that doesn't map to a single input. For this task, the output depends on all of the inputs.

Here are some considerations about one-to-one mapping versus no direct mapping:

- A target with no direct mapping between inputs and outputs always builds more often than a target where each output maps to a single input. If a target has no direct mapping, MSBuild can't determine the specific outputs to rebuild when only some inputs change.

- Tasks that can identify a direct mapping between the outputs and inputs are most suitable for incremental builds. An example is the [LC task](lc-task.md) task, which generates a *.license* file. 

- Tasks that produce a single output assembly from multiple inputs aren't suitable for incremental builds. Examples include the [Csc task](csc-task.md) that wraps the *csc.exe* file and produces executables, libraries, and modules, and the [Vbc task](vbc-task.md) that wraps the *vbc.exe* file.

## Use transforms to create a one-to-one mapping

The following example defines a project that builds content files for a Help system. The project works by converting source *.txt* files into intermediate *.content* files, which are combined with XML metadata files to produce the final *.help* file used by the system. The project includes the following tasks:

- `GenerateContentFiles`: Converts *.txt* files into *.content* files.
- `BuildHelp`: Combines *.content* files and XML metadata files to build the final *.help* file.

The project uses [transforms](msbuild-transforms.md) to create a one-to-one mapping between inputs and outputs in the `GenerateContentFiles` task. The `Output` element is set to automatically use the outputs from the `GenerateContentFiles` task as the inputs for the `BuildHelp` task.

The project file contains `Convert` and `Build` targets. The `GenerateContentFiles` and `BuildHelp` tasks are placed in the `Convert` and `Build` targets respectively, so each target can build incrementally. The `Output` element definition places the outputs of the `GenerateContentFiles` task in the `ContentFile` item list, to use as inputs for the `BuildHelp` task. This approach automatically provides the outputs from one task as the inputs for another task. You don't have to list the individual items or item lists manually in each task.

> [!NOTE]
> Although the `Convert` target can build incrementally, all outputs from that target are always required as inputs for the `Build` target. MSBuild automatically provides all the outputs from one target as inputs for another target when you use the `Output` element.

```xml
<Project DefaultTargets="Build"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >

    <ItemGroup>
        <TXTFile Include="*.txt"/>
        <XMLFiles Include="\metadata\*.xml"/>
    </ItemGroup>

    <Target Name = "Convert"
        Inputs="@(TXTFile)"
        Outputs="@(TXTFile->'%(Filename).content')">

        <GenerateContentFiles
            Sources = "@(TXTFile)">
            <Output TaskParameter = "OutputContentFiles"
                ItemName = "ContentFiles"/>
        </GenerateContentFiles>
    </Target>

    <Target Name = "Build" DependsOnTargets = "Convert"
        Inputs="@(ContentFiles);@(XMLFiles)"
        Outputs="$(MSBuildProjectName).help">

        <BuildHelp
            ContentFiles = "@(ContentFiles)"
            MetadataFiles = "@(XMLFiles)"
            OutputFileName = "$(MSBuildProjectName).help"/>
    </Target>
</Project>
```

## Related content

- [Targets](msbuild-targets.md)
- [Target element (MSBuild)](target-element-msbuild.md)
- [Transforms](msbuild-transforms.md)