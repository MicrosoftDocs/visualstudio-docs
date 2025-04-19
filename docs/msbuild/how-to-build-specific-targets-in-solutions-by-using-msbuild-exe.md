---
title: Use MSBuild.exe to build specific targets in solutions
description: Discover how to use the MSBuild.exe command line to build specific targets of specific projects in your solutions and get help with troubleshooting.
ms.date: 12/3/2024
ms.topic: how-to
helpviewer_keywords:
- MSBuild, building specific targets in a solution
- msbuild.exe, building specific targets in a solution
- MSBuild, msbuild.exe
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Build specific targets in solutions by using MSBuild.exe

You can use *MSBuild.exe* to build specific targets of specific projects in a solution.

## To build a specific target of a specific project in a solution

1. At the command line, change directory to the solution folder and type `MSBuild.exe <SolutionName>.sln`, but don't hit enter yet. Use your solution name.

2. Specify the target after the `-target:` switch in the format \<ProjectName>:\<TargetName>. If the project name contains any of the characters `%`, `$`, `@`, `;`, `.`, `(`, `)`, or `'`, replace them with an `_` in the specified target name.

If you're not sure what targets are available, you can get a list of targets available for a single project by invoking MSBuild with the `-targets` (`-ts`) switch. For example, `MSBuild.exe -ts SomeProject.proj`. The `-targets` or `-ts` option is only available on project files, not the solution file.

## Example

 The following example executes the `Rebuild` target of the `NotInSlnFolder` project, and then executes the `Clean` target of the `InSolutionFolder` project, which is located in the *NewFolder* solution folder.

```cmd
msbuild SlnFolders.sln -target:NotInSlnfolder:Rebuild;NewFolder\InSolutionFolder:Clean
```

Building a specific target also triggers other dependent targets to build.

> [!NOTE]
> The path used in the `targets` switch is not a filesystem path. It is a path in the solution's internal representation, and visible in **Solution Explorer**. For example, you can't use filesystem path syntax such as `.` or `..` in the `targets` switch. That is why a project referenced in another filesystem location like `NotInSlnFolder` doesn't require an explicit path, but a project within a solution folder `InSolutionFolder` does. Solutions can also have folders, created by **Add** > **Solution folder** in Visual Studio. Those folders are used to organize projects within the solution when viewed in **Solution Explorer** in Visual Studio. The layout in the filesystem can be different from the solution folder structure. See [Solution folders](../ide/solutions-and-projects-in-visual-studio.md#solution-folder).

## Troubleshooting

If you would like to examine the solution project, you can use a debugging option provided by MSBuild to do so. Set the environment variable `MSBUILDEMITSOLUTION=1` and build your solution. This will produce an MSBuild file named *\<SolutionName>.sln.metaproj* that shows MSBuild's internal view of the solution at build time. You can inspect this view to determine what targets are available to build, and other configuration details.

Do not build with this environment variable set unless you need this internal view. This setting can cause problems building projects in your solution. Look in the [binary log](obtaining-build-logs-with-msbuild.md#save-a-binary-log) instead.

## Related content

- [Command-line reference](../msbuild/msbuild-command-line-reference.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [MSBuild](../msbuild/msbuild.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
