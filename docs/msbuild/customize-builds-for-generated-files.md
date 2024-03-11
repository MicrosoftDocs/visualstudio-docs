---
title: Handle generated files in a build
description: Customize MSBuild project files in Visual Studio so that files generated during the build process are included in build output.
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
# Customize a build to handle generated files

In any given build, files that get generated during the build behave differently from static files (such as source files). For this reason, it's important to understand [How MSBuild Builds Projects](build-process-overview.md). The two phases are the [evaluation phase](build-process-overview.md#evaluation-phase) and the [execution phase](build-process-overview.md#execution-phase). During the evaluation phase, MSBuild reads your project, imports everything, creates properties, expands globs for items, and sets up the build process. During the execution phase, MSBuild performs the build by running targets and tasks with the data it parsed during the evaluation phase.

Files generated during execution don't exist during the evaluation phase, therefore they aren't included in the build process. To solve this problem, you must manually add the generated files into the build process. The recommended way to do this is by adding the new file to the `Content` or `None` items before the `BeforeBuild` target, as in the following example:

```xml
<Target Name="MyTarget" BeforeTargets="BeforeBuild">
  
  <!-- Some logic that generates your file goes here -->
  <!-- Generated files should be placed in $(IntermediateOutputPath) -->

  <ItemGroup>
    <!-- If your generated file was placed in `obj\` -->
    <None Include="$(IntermediateOutputPath)my-generated-file.xyz" CopyToOutputDirectory="PreserveNewest"/>
    <!-- If you know exactly where that file is going to be, you can hard code the path. -->
    <None Include="some\specific\path\my-generated-file.xyz" CopyToOutputDirectory="PreserveNewest"/>
    
    <!-- If you want to capture "all files of a certain type", you can glob like so. -->
    <None Include="some\specific\path\*.xyz" CopyToOutputDirectory="PreserveNewest"/>
    <None Include="some\specific\path\*.*" CopyToOutputDirectory="PreserveNewest"/>
  </ItemGroup>
</Target>
```

Adding your generated file to `None` or `Content` is sufficient for the build process to see it. You also want to ensure it gets added at the right time. Ideally, your target runs before `BeforeBuild`. `AssignTargetPaths` is another possible target, as it is the final opportunity to modify `None` and `Content` items (among others) before they are transformed into new items. See [Common Item Types](common-msbuild-project-items.md).

## Related content

- [Customize your build](customize-your-build.md).
