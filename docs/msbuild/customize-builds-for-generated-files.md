---
title: Handle generated files in a build
description: Customize MSBuild project files in Visual Studio so that files generated during the build process are included in build output.
ms.date: 8/5/2025
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
  <WriteLinesToFile
      File="$(IntermediateOutputPath)GeneratedFile.cs"
      Lines='enum MyEnum { A, B }'
      Overwrite="true" />
    <ItemGroup>
      <Compile Include="$(IntermediateOutputPath)GeneratedFile.cs" />
    </ItemGroup>

  <ItemGroup>
    <!-- If your generated file was placed in `obj\` -->
    <None Include="$(IntermediateOutputPath)GeneratedFile.cs" CopyToOutputDirectory="PreserveNewest"/>
    <!-- If you know exactly where that file is going to be, you can hard code the path. -->
    <None Include="some\specific\path\my-generatedfile" CopyToOutputDirectory="PreserveNewest"/>
    
    <!-- If you want to capture "all files of a certain type", you can glob like so. -->
    <None Include="some\specific\path\*.xyz" CopyToOutputDirectory="PreserveNewest"/>
    <None Include="some\specific\path\*.*" CopyToOutputDirectory="PreserveNewest"/>
  </ItemGroup>
</Target>

 <Target Name="CleanGeneratedCode" AfterTargets="CoreClean">
  <Delete Files="$(IntermediateOutputPath)GeneratedFile.cs" />
</Target>
```

Adding your generated file to `None` or `Content` is sufficient for the build process to see it. You also want to ensure it gets added at the right time. Ideally, your target runs before `BeforeBuild`. `AssignTargetPaths` is another possible target, as it is the final opportunity to modify `None` and `Content` items (among others) before they are transformed into new items. See [Common Item Types](common-msbuild-project-items.md).

## Next steps

This example could be improved to support more realistic use cases. For example, to support [incremental builds](./incremental-builds.md) when the generated code depends on an input file, `Inputs` and `Outputs` should be provided to the target. Such a target would only regenerate the file if the date of the input file or files is more recent than the output file. Often when customizing for code generation, it's recommended to create a custom task. See [Create a custom task for code generation](./tutorial-custom-task-code-generation.md).

## Related content

- [Customize your build](customize-your-build.md).
