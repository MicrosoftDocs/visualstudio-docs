---
title: "How to: Build to a common output directory"
description: Learn how you can change the build output paths of your projects to force all outputs to be placed in the same folder.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.technology: vs-ide-compile
ms.topic: how-to
helpviewer_keywords:
  - "output directory"
  - "builds [Visual Studio], common directory"
  - "common directory"
ms.assetid: 1fcc2c48-07cb-4c4f-9556-36945e7dfc4e
author: ghogen
ms.author: ghogen
manager: jmartens
ms.workload:
  - "multiple"
---
# How to: Build to a common output directory

By default, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] builds each project in a solution in its own folder inside the solution. You can change the build output paths of your projects to force all outputs to be placed in the same folder.

## To place all solution outputs in a common directory

1. Click on one project in the solution.

2. On the **Project** menu, click **Properties**.

3. Depending on the type of project, click on either the **Compile** tab or the **Build** tab, and set the **Output path** to a folder to use for all projects in the solution.

4. Open the project file for the project, and add the following property declaration to the first property group.

   ```xml
   <PropertyGroup>
     <!-- existing property declarations are here -->
     <UseCommonOutputDirectory>true</UseCommonOutputDirectory>
   </PropertyGroup>
   ```

   Setting `UseCommonOutputDirectory` to `true` tells Visual Studio and its underlying build engine (MSBuild) that you're putting multiple project outputs in the same folder, and so MSBuild omits the copying step that normally happens when projects depend on other projects.

5. Repeat steps 1-4 for all projects in the solution. You can skip some projects if you have some exceptional projects that should not use the common output directory.

## To set the intermediate output directory for a project (.NET projects)

1. Open the project file.

1. Add the following property declaration to the first property group.

   ```xml
   <PropertyGroup>
     <!-- existing property declarations are here -->
     <IntermediateOutputPath>path</IntermediateOutputPath>
   <PropertyGroup>
   ```

   The path is relative to the project file, or you can use an absolute path. If you want to put the project name in the path, you can reference it by using the MSBuild properties `$(MSBuildProjectName)`, `$(MSBuildProjectDirectory)`. For more properties you can use, see [MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md).

1. Visual Studio still creates the obj folder under the project folder when you build, but it's empty. You can delete it as part of the build process. One way to do that is to add a post-build event to run the following command:

   ```cmd
   rd "$(ProjectDir)obj" /s /q
   ```

   See [Specify custom build events](specifying-custom-build-events-in-visual-studio.md).

   The obj folder is not created when you build from the MSBuild command line.

## See also

- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)
- [How to: Change the build output directory](../ide/how-to-change-the-build-output-directory.md)