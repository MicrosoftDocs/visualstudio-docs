---
title: MSBuild Exploits Multiple Processors for Builds
description: Explore how MSBuild can exploit systems that have multiple processors or cores by creating a separate build process for each available processor.
ms.date: 06/25/2025
ms.topic: concept-article
helpviewer_keywords:
- multiple processors
- MSBuild, multiple processor systems
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
#customer intent: As a developer, I want to learn how MSBuild exploits systems with multiple processors or cores, so I can create separate build processes for each of my processors.
---

# MSBuild exploits multiple processors to build projects

MSBuild can take full advantage of systems that have multiple processors or multiple-core processors by creating a separate build process for each processor. For example, if a system has four processors, MSBuild creates four build processes.

MSBuild can process the multiple builds simultaneously, which reduces the overall build time. However, parallel builds can introduce changes in how the build processes occur.

This article describes process changes that can occur when multiple builds run simultaneously.

## Project-to-project references

When the Microsoft Build Engine encounters a project-to-project (P2P) reference during parallel builds for a project, it builds the reference one time only. If two projects have the same P2P reference, the reference isn't rebuilt for each project. Instead, the build engine returns the same P2P reference to both projects that have the dependency. MSBuild also supplies the same P2P reference to future requests in the session for the same target.

## Cycle detection

Cycle detection during parallel builds is the same behavior as for MSBuild 2.0. The one difference is that the newer version of MSBuild can report the detection of the cycle at a different time or in the build.

## Errors and exceptions during parallel builds

During parallel builds, errors and exceptions can occur at different times than they do during a nonparallel build. Also, if one project doesn't build, the other project builds continue. 

MSBuild doesn't stop any project building in parallel with a failed build. Other projects continue to build until they either succeed or fail. When the <xref:Microsoft.Build.Framework.IBuildEngine.ContinueOnError%2A> setting is enabled, no builds stop, even if an error occurs.

## C++ project (.vcxproj) and solution (.sln) files

Both C++ project (*.vcxproj*) and solution (*.sln*) files can be passed to the [MSBuild task](msbuild-task.md).

- **C++ projects**: The VCWrapperProject API is called and then the internal MSBuild project is created.
- **C++ solutions**: A SolutionWrapperProject instance is created and then the internal MSBuild project is created.

In both cases, the resulting project is handled like any other MSBuild project.

## Multi-process execution

Almost all build-related activities require the current directory to remain constant throughout the build process to prevent path-related errors. Projects can't run on different threads in MSBuild because they can cause the creation of multiple directories.

To avoid this problem but still enable multi-processor builds, MSBuild uses _process isolation_. This process enabled MSBuild to create a maximum of `n` processes, where `n` equals the number of processors available on the system. For example, if MSBuild builds a solution on a system with two processors, only two build processes are created. These processes are reused to build all the projects in the solution.

## Related content

- [Build multiple projects in parallel](building-multiple-projects-in-parallel-with-msbuild.md)
- [MSBuild tasks](msbuild-tasks.md)