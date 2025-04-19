---
title: Customize the solution build
description: Customize the solution build prepared by MSBuild for command-line builds of solutions with settings that don't affect project builds.
ms.date: 02/28/2023
ms.topic: how-to
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---

# Customize the solution build

When MSBuild builds a solution file, it first translates it internally into a project file and then builds that. The generated project file imports `before.{solutionname}.sln.targets` before defining any targets and `after.{solutionname}.sln.targets` after importing targets, including targets installed to the `$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\SolutionFile\ImportBefore` and `$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\SolutionFile\ImportAfter` directories.

For example, you could define a new target to write a custom log message after building *MyCustomizedSolution.sln* by creating a file in the same directory named *after.MyCustomizedSolution.sln.targets* that contains

```xml
<Project>
 <Target Name="EmitCustomMessage" AfterTargets="Build">
   <Message Importance="High" Text="The solution has completed the Build target" />
 </Target>
</Project>
```

The solution build is separate from the project builds, so settings here do not affect project builds.

> [!IMPORTANT]
> Customizing the solution build in this way applies only to command-line builds with `MSBuild.exe` or `dotnet build`. It **does not** apply to builds inside Visual Studio. For this reason, it is not recommended to put customization at the solution level. A better alternative for customizing all projects in a solution is to use *Directory.Build.props* and *Directory.build.targets* files in the solution folder, as discussed elsewhere in this article.

When you have many solution files that you want to extend in the same way, but you don't want to write to the `$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\SolutionFile\` folder (which usually requires elevated permissions), you can create the files *Directory.Solution.props* and *Directory.Solution.targets* and place them in the root path above the solution files you want to extend. *Directory.Solution.props* is imported at the beginning of the solution build, and *Directory.Solution.targets* is imported at the end of the solution build. When you build a solution file, *Directory.Build.props* and *Directory.Build.targets* are not imported, so you must use *Directory.Solution.props* and *Directory.Solution.targets* instead. They do not implicitly import each other.

When you have *Directory.Solution.props* or *Directory.Solution.targets* in a root folder, but you have a solution under that folder that you don't want to import them, you can use the solution-specific files mentioned previously `before.{solutionname}.sln.targets` and `after.{solutionname}.sln.targets` to set the properties `$(ImportDirectorySolutionProps)` and `$(ImportDirectorySolutionTargets)` to false. Or, you can use the properties `$(DirectorySolutionPropsPath)` and `$(DirectorySolutionTargetsPath)` to specify a different location for those files. This could be helpful if you have various subsets of your solutions that require certain property values or targets common to the subsets.

> [!NOTE]
> The solution build is supported with the `.slnx` solution file format in MSBuild 17.12 and later. Both `before.{solutionname}.slnx.targets` and `before.{solutionname}.sln.targets` work (and likewise for the `after` forms) with MSBuild 17.14 and later.

## Related content

- [Customize your build](customize-your-build.md).
