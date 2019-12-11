---
title: "Use MSBuild.exe to build specific targets in solutions"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "MSBuild, building specific targets in a solution"
  - "msbuild.exe, building specific targets in a solution"
  - "MSBuild, msbuild.exe"
ms.assetid: f46feb9b-4c16-4fec-b6e1-36a959692ba3
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Build specific targets in solutions by using MSBuild.exe
You can use *MSBuild.exe* to build specific targets of specific projects in a solution.

#### To build a specific target of a specific project in a solution

1. At the command line, type `MSBuild.exe <SolutionName>.sln`, where `<SolutionName>` corresponds to the file name of the solution that contains the target that you want to execute.

2. Specify the target after the `-target:` switch in the format \<ProjectName>:\<TargetName>. If the project name contains any of the characters `%`, `$`, `@`, `;`, `.`, `(`, `)`, or `'`, replace them with an `_` in the specified target name.

## Example
 The following example executes the `Rebuild` target of the `NotInSlnFolder` project, and then executes the `Clean` target of the `InSolutionFolder` project, which is located in the *NewFolder* solution folder.

```cmd
msbuild SlnFolders.sln -target:NotInSlnfolder:Rebuild;NewFolder\InSolutionFolder:Clean
```

## Troubleshooting

If you would like to examine the options available to you, you can use a debugging option provided by MSBuild to do so. Set the environment variable `MSBUILDEMITSOLUTION=1` and build your solution. This will produce an MSBuild file named *\<SolutionName>.sln.metaproj* that shows MSBuild's internal view of the solution at build time. You can inspect this view to determine what targets are available to build.

Do not build with this environment variable set unless you need this internal view. This setting can cause problems building projects in your solution.

## See also
- [Command-line reference](../msbuild/msbuild-command-line-reference.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [MSBuild](../msbuild/msbuild.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
