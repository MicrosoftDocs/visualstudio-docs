---
title: Build multiple projects in parallel with MSBuild
description: Explore the MSBuild settings that you can use to build multiple projects faster by running them in parallel in Visual Studio.
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
ms.topic: concept-article
ms.date: 02/21/2025
helpviewer_keywords:
- parallel project builds
- building multiple projects in parallel
- msbuild, building projects in parallel

# Customer intent: As a developer, I want to learn how to use the MSBuild command in Visual Studio to run multiple projects in parallel so that I can build projects faster.

---

# Build multiple projects in parallel with MSBuild

To build multiple projects faster, you can use MSBuild to run builds in parallel. To do so, use the following settings on multi-core or multiple processor computers:

- Set the `-maxcpucount` switch when you run MSBuild at a command prompt.

- Set the <xref:Microsoft.Build.Tasks.MSBuild.BuildInParallel%2A> task parameter to `true` on an MSBuild task.

> [!NOTE]
> Your build performance might decrease if you use the `-verbosity` (`-v`) switch to set the verbosity of your build log information to detailed or diagnostic. This switch is often used for troubleshooting. For more information, see [Obtain build logs with MSBuild](../msbuild/obtaining-build-logs-with-msbuild.md) and [MSBuild command-line reference](../msbuild/msbuild-command-line-reference.md).

## -maxcpucount MSBuild switch

If you use the `-maxcpucount` (`-m`) switch, which was introduced in MSBuild 3.5, MSBuild creates the specified number of *MSBuild.exe* processes that can be run in parallel. These processes are also known as *worker processes*. Each worker process uses a separate core or processor, if any are available, to build a project at the same time as other available processors might be building other projects.
For example, setting this switch to a value of `4` causes MSBuild to create four worker processes to build the project.

If you include the `-maxcpucount` switch without specifying a value, MSBuild uses up to the number of processors on the computer.

For more information about this switch, see [MSBuild command-line reference](../msbuild/msbuild-command-line-reference.md).

The following example instructs MSBuild to use three worker processes. With this configuration, MSBuild can build three projects at the same time.

```cmd
msbuild.exe myproj.proj -maxcpucount:3
```

## BuildInParallel MSBuild task parameter

`BuildInParallel` is an optional boolean parameter on an MSBuild task. When you set `BuildInParallel` to `true` (default value), multiple worker processes are generated to build as many projects at the same time as possible. For this parameter to work correctly, set the `-maxcpucount` switch to a value greater than one.

When you use MSBuild to building in parallel, it works only for a single invocation of the MSBuild task. Therefore, if you invoke task batching, the parallelism is limited to each batch. For more information, see [MSBuild batching](msbuild-batching.md).

The following examples show how to build a target in a project file with multiple different property values in parallel by using the `BuildInParallel` parameter.

In this example, the project file `do_it.proj` has a target that prints a different message for each `SourceValue`.

```xml
<Project>
   <Target Name="DoIt">
      <Message Text="For this invocation SourceValue='$(SourceValue)'" Importance="High" />
   </Target>
</Project>
```

The following project builds a specified target *DoIt* in a project named *do_it.proj* in parallel, using the item list and `AdditionalProperties` metadata to specify different values of the property `SourceValue`.

```xml
<Project>
   <ItemGroup>
      <_Project Include="do_it.proj" AdditionalProperties="SourceValue=Test1" />
      <_Project Include="do_it.proj" AdditionalProperties="SourceValue=Test2" />
      <_Project Include="do_it.proj" AdditionalProperties="SourceValue=Test3" />
      <_Project Include="do_it.proj" AdditionalProperties="SourceValue=Test4" />
   </ItemGroup>
   <Target Name="Build">
      <MSBuild Projects="@(_Project)" Targets="DoIt" BuildInParallel="true" />
   </Target>
</Project>
```

## Related content

- [Use multiple processors to build projects](../msbuild/using-multiple-processors-to-build-projects.md)
- [Write multi-processor-aware loggers](../msbuild/writing-multi-processor-aware-loggers.md)
- [Tune C++ build parallelism blog](https://devblogs.microsoft.com/visualstudio/tuning-c-build-parallelism-in-vs2010/)
