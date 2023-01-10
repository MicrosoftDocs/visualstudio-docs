---
title: 'How to: Debug build race conditions'
description: Learn how to diagnose and fix race conditions in your MSBuild parallel builds.
ms.date: 01/31/2022
ms.topic: how-to
helpviewer_keywords:
- MSBuild, debug build race conditions
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# How to: Debug race conditions in MSBuild project builds

MSBuild supports parallel builds, which improves the performance of your builds by building multiple projects in parallel in different worker node processes running on different CPU cores. The performance benefit of building in parallel can be significant, but under certain circumstances, it can introduce the risk of errors arising from race conditions. By definition, a race condition is an error arising from multiple executing threads or processes trying to use the same resource. Manifested behavior may differ from build to build when there is a race condition, because sometimes one process will be ahead of the other, and sometimes behind it by differing amounts of time. By understanding and addressing the root causes of race conditions, you can fix intermittent build failures that arise from the race conditions, such as file I/O failures.

Error messages that arise from race conditions always include an operating system file I/O failure, but can have different MSBuild error codes, depending on what was happening in the build when the file I/O error occurred. Some examples might look like the following on the Windows platform:

```output
error MSB3677: Unable to move file "C:\IntermediatePath\MyAssembly.dll" to "C:\OutputPath\MyAssembly.dll".
Cannot create a file when that file already exists. [C:\PathToProject\SomeProject.csproj] 
```

```output
The process cannot access the file 'C:\PathToPackageOutut\MyPackage.1.0.nupkg' because it is being used by another process.
```

Race conditions in MSBuild builds can occur when a particular project is requested to build with more than one combination of property settings. MSBuild typically does a separate build for a referenced project whenever property settings differ, in case the output might also differ. Depending on the timing of concurrently running builds, move or copy operations can fail if a file is already present at the same location, or they can fail because the destination file is being used by another process, which is actually another instance of MSBuild running on another worker node. Also, file read operations can fail if another MSBuild process is reading or writing the same file.

You can permanently fix most build race conditions by understanding the cause and making appropriate changes in the project files, but only if the cause is in your own code. Race conditions can also be caused by bugs in SDK code, in which case the issue has to be reported to and investigated by the owners of the relevant SDK.

## Project references set properties inconsistently

Different builds of the same project are a normal part of a many build processes; they occur when more built output is requested for more than one combination of settings. For example, multiple target frameworks (such as `net472` and `net7`), or multiple target platform architectures (such as `Arm64` and `x64`). This is solved by specifying a different output folder for each combination of outputs. That way, the `Arm64` `net472` version of an assembly is output to a different folder than the other combinations and no conflict occurs. The default SDK settings already handle the examples mentioned here, but sometimes the occurrence of multiple combinations of settings is not as obvious and needs to be investigated.

Use the binary log (binLog) and preferably, the Structured Log Viewer, to examine the logs. Make sure the Verbosity setting is at set to Diagnostic.  You can use the output log from a successful run or a failed run; both contain the information necessary to identify the race condition using the technique described here.

Check the log for the path of the output file mentioned in the error message. If the issue is a race condition, there should be more than one write action to the same output file. Note the project and the settings of that project. If it's a project referenced from another project, you need to identify the original project that requested the referenced project to build (there could be several layers of references in complex projects). Look for the `ProjectReference` elements and follow the chain of dependencies until you can identify the project where the issue of multiple settings originates.

It could be that the different settings for multiple builds are intentional, but the problem is that the two builds output to the same folder. You can fix that by changing the output folder for the conflicting file in one or both builds.

It could be that the different settings for multiple builds are unintentional, and the fix is to use the same intended settings for both projects. The use of global properties (those specified on the command-line with the `/p` or `/property` option) need to be examined especially closely. If one invocation of a project build overrides a global property, but another invocation doesn't, then two different builds will occur. If building multiple versions of the same outputs isn't expected, and the two builds are both trying to use the same output folder and file, then you have a race condition.

To detect such cases, look at all the `ProjectReference` elements for the project that is experiencing the problem, and look for any the metadata `RemoveGlobalProperties`, `GlobalPropertiesToRemove`, `SetConfiguration`, `SetPlatform`, `SetTargetFramework`, or`AdditionalProperties`. Check for differences in the values set for these metadata between different ProjectReference elements across the solution.

To fix the issue, you could either make the output folder different for the two different property configurations, or, you can make whatever changes are appropriate to eliminate the difference. The approach to address the problem depends on the desired outcome. Do you really need two different versions of the built project? If not, you can change the ProjectReference elements to ensure that the same properties are set for each reference.

### Example

A simple case that demonstrates the pattern is presented here. Suppose you have a solution with several projects, one front-end client (`App`), two class libraries (`Middle1` and `Middle2`), and a library (`Base`), which is referenced by the two class libraries.

The build completes successfully every time, if the project files for these libraries are authored as follows:

```xml
<!-- Base.csproj -->
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\Base\Base.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>

</Project>
```

```xml
<!-- Middle1.csproj -->
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\Base\Base.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>

</Project>
```

```xml
<!-- Middle2.csproj -->
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\Base\Base.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>

</Project>
```

```xml
<!-- App.csproj -->
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\Middle1\Middle1.csproj" />
    <ProjectReference Include="..\Middle2\Middle2.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>

</Project>
```

But, with one small change to one of the middle layer libraries, a build race condition is introduced:

```xml
<!-- Middle1.csproj -->
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\Base\Base.csproj" AdditionalProperties="SpecialMode=true" />
  </ItemGroup>

  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>

</Project>
```

The change results in two different builds of `Base`, one with `SpecialMode=true` and another without it. The error would reference the Base.dll output, for example, you might sometimes get an error that `Base.dll` could not be written "because it is being used by another process."

## ProjectReference properties conflict with global property

Global properties, that is, when you set a property on the command line with the `/p` or `/property` option, are implicitly used for referenced project builds. However, by using `RemoveGlobalProperties` or `GlobalPropertiesToRemove`, you can omit some or all global property settings for any given project reference, so if those properties are not used consistently, you can have a situation where more than one version of a referenced project is built with the global property set, and another where it's unset or has a different value.

## Packaging unintentionally triggers project builds

If your build packages the output of projects that have been built previously, you might encounter a race condition when your packaging build logic specifies different property settings than the original projects used when they were built. When this is the case, MSBuild normally would trigger a rebuild of those projects because of the mismatch in properties. This situation can lead to race conditions. Consider setting `BuildProjectReferences` to `false` in the packaging project, so that the projects that are being packaged are never asked to be built. This would mean that the packaging build should only be requested when project builds are previously done and up-to-date.

## Diagnosing and fixing race conditions

You should suspect a race condition error when move operations, copy operations, or file writes for files generated by your build fail sometimes, but not necessarily every time you build. If this is happening, you should first check that you don't have any other program running that is using those files, such as a Visual Studio debugger session on the same machine. Second, does the problem go away if you use the MSBuild `/m:1` option? This is the command-line option that tells MSBuild the number of nodes to use for builds. If set to 1, then builds proceed serially, and a race condition cannot occur. Using the `/m:1` option is a workaround you can use to work around the race condition, but it's not a long-term solution, since it significantly increases the time required to complete a build. If the build only demonstrates the intermittent file I/O failure when parallel build is enabled (number of processors is greater than 1), then that is a build race condition.

To locate and fix a race condition:

1. Generate a log. Set the verbosity to `Detailed` or greater (for example, use the command-line option `-verbosity:Detailed`). To troubleshoot the race condition, it is recommended to generate a binary log (use the `/bl` or `/binlog` option) and view it with the [Structured Log Viewer](https://msbuildlog.com/). To get a useful log for diagnosing a race condition, it is not required that the log be from a failed run, because you can still locate the multiple places where the output that produced the error is accessed.

1. Whether that particular run failed or not, open the log (or `.binlog` file) and search for the filename of the file that triggers the failure and find all the places where the file is used.

1. Note the property settings in effect for each instance of that project's build. The structured log viewer makes this fairly easy, since every individual project build has a **Properties** node listing all the property settings in effect for that project build. If you're using a text log, the properties set for a build are output in text when the verbosity setting is `Detailed` or `Diagnostic`. Compare the lists of properties for each build of the project that generates the failed output. You should see a difference, if the problem is actually a race condition.

1. Search the project files for `ProjectReference` where the `Include` attribute specifies that project. Look at the metadata for metadata settings that affect properties. In the first example, it's the inconsistent `AdditionalProperties` metadata setting (in one place, but not in the other) that is the source of the problem.

1. Consider the meaning of property settings that are different, and whether they would materially impact the build output. If the property setting differences are meaningful and the output is intended to be distinct, then the fix is to use a different folder for each variation of the setting, just as the .NET SDK does for the platform, the configuration (for example, Debug or Release), or the target framework. If the property setting difference is unintentional or insignificant, then try to find a way to change the project code to eliminate the difference in the properties. In the above example, this could be accomplished by adding the `AdditionalProperties="SpecialMode=true"` metadata to the `ProjectReference` in *Middle2.csproj*, or by removing the `AdditionalProperties` metadata from *Middle1.csproj*. The appropriate change depends on the specific requirements of your application, service, or target.

## See also

[Build multiple projects in parallel with MSBuild](building-multiple-projects-in-parallel-with-msbuild.md)
[How MSBuild builds projects](build-process-overview.md)