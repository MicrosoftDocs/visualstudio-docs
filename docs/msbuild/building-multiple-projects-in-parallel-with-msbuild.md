---
title: Build multiple projects in parallel with MSBuild
description: Explore the MSBuild settings that you can use to build multiple projects faster by running them in parallel in Visual Studio.
ms.date: 09/14/2023
ms.topic: how-to
helpviewer_keywords:
- parallel project builds
- building multiple projects in parallel
- msbuild, building projects in parallel
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Build multiple projects in parallel with MSBuild

You can use MSBuild to build multiple projects faster by running them in parallel. To run builds in parallel, you use the following settings on a multi-core or multiple processor computer:

- The `-maxcpucount` switch at a command prompt.

- The <xref:Microsoft.Build.Tasks.MSBuild.BuildInParallel%2A> task parameter on an MSBuild task.

> [!NOTE]
> The **-verbosity** (**-v**) switch in a command line can also affect build performance. Your build performance might decrease if the verbosity of your build log information is set to detailed or diagnostic, which are used for troubleshooting. For more information, see [Obtain build logs](../msbuild/obtaining-build-logs-with-msbuild.md) and [Command-line reference](../msbuild/msbuild-command-line-reference.md).

## -maxcpucount Switch

If you use the `-maxcpucount` switch, or `-m` for short, MSBuild can create the specified number of *MSBuild.exe* processes that may be run in parallel. These processes are also known as "worker processes." Each worker process uses a separate core or processor, if any are available, to build a project at the same time as other available processors may be building other projects. For example, setting this switch to a value of "4" causes MSBuild to create four worker processes to build the project.

If you include the `-maxcpucount` switch without specifying a value, MSBuild will use up to the number of processors on the computer.

For more information about this switch, which was introduced in MSBuild 3.5, see [Command-line reference](../msbuild/msbuild-command-line-reference.md).

The following example instructs MSBuild to use three worker processes. If you use this configuration, MSBuild can build three projects at the same time.

```cmd
msbuild.exe myproj.proj -maxcpucount:3
```

## BuildInParallel task parameter

`BuildInParallel` is an optional boolean parameter on an MSBuild task. When `BuildInParallel` is set to `true` (its default value is `true`), multiple worker processes are generated to build as many projects at the same time as possible. For this to work correctly, the `-maxcpucount` switch must be set to a value greater than 1.

Building in parallel only works for a single invocation of the MSBuild task, so if you invoke task batching, the parallelism is limited to each batch. See [MSBuild batching](msbuild-batching.md).

The following example shows how to build a target in a project file with multiple different property values in parallel by using the `BuildInParallel` parameter.

Here's the project file `do_it.proj` with a target that just prints a different message for each `SourceValue`:

```xml
<Project>
   <Target Name="DoIt">
      <Message Text="For this invocation SourceValue='$(SourceValue)'" Importance="High" />
   </Target>
</Project>
```

The following project builds a specified target `DoIt` in `do_it.proj` in parallel, using the item list and `AdditionalProperties` metadata to specify different values of the property `SourceValue`.

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
- [Tuning C++ build parallelism blog](https://devblogs.microsoft.com/visualstudio/tuning-c-build-parallelism-in-vs2010/)
