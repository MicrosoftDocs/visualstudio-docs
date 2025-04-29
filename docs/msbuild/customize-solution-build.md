---
title: Customize solution builds
description: Customize the solution build MSBuild prepares for command-line builds with settings that don't affect project builds.
ms.date: 04/29/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild

#customer intent: As a builder, I want to know how to customize MSBuild solution builds, so I can extend solution builds with files and settings that affect different subsets of files.

---

# Customize solution builds

When MSBuild builds a solution file, it first translates the file internally into a project file, and then builds that project file. The generated project file can import *before.\<solutionname>.sln.targets* before it defines any targets, and import *after.\<solutionname>.sln.targets* after it imports the targets.

The *before* and *after* targets files are installed to the *$\<MSBuildExtensionsPath>\\$\<MSBuildToolsVersion>\\SolutionFile\\ImportBefore* and *$\<MSBuildExtensionsPath>\\$\<MSBuildToolsVersion>\\SolutionFile\\ImportAfter* directories.

So, for example, you could define a new target to write a custom log message after *MyCustomizedSolution.sln* builds, by creating the following file named *after.MyCustomizedSolution.sln.targets* in the same directory.

```xml
<Project>
 <Target Name="EmitCustomMessage" AfterTargets="Build">
   <Message Importance="High" Text="The solution has completed the Build target" />
 </Target>
</Project>
```

The solution build is separate from the project builds, so these settings don't affect the project builds.

> [!IMPORTANT]
> Customizing the solution builds this way applies only to command-line builds using `MSBuild.exe` or `dotnet build`, and doesn't apply to builds inside Visual Studio. Therefore, it's best not to put customization at the solution level. A better alternative for customizing all projects in a solution is to use *Directory.Build.props* and *Directory.Build.targets* files in the solution folder.

Writing to the *$\<MSBuildExtensionsPath>\\$\<MSBuildToolsVersion>\\SolutionFile\\* folder usually requires elevated permissions. If you have many solution files to extend the same way, but you don't want to write to the *SolutionFile* folder, you can create the *Directory.Solution.props* and *Directory.Solution.targets* files and place them in the root path above the solution files you want to extend. *Directory.Solution.props* is imported at the beginning of the solution build, and *Directory.Solution.targets* is imported at the end of the solution build.

When you build a solution file, *Directory.Build.props* and *Directory.Build.targets* aren't imported, so you must use *Directory.Solution.props* and *Directory.Solution.targets* instead. The two types of files don't implicitly import each other.

When you have *Directory.Solution.props* or *Directory.Solution.targets* files in a root folder, but you don't want a solution under that folder to import those files, you can use the solution's *before.\<solutionname>.sln.targets* file to set the properties `$(ImportDirectorySolutionProps)` and `$(ImportDirectorySolutionTargets)` to `false`.

Or, you can use the `$(DirectorySolutionPropsPath)` and `$(DirectorySolutionTargetsPath)` properties to specify a different location for those files. This approach can be helpful if subsets of your solutions require certain property values or targets in common.

> [!NOTE]
> The solution build is supported with the `.slnx` solution file format in MSBuild 17.12 and later. Both *before.\<solutionname>.slnx.targets* and *before.\<solutionname>.sln.targets*, and the corresponding *after* files, work with MSBuild 17.14 and later.

For more information about build customization options, see [Customize your build](customize-your-build.md).
