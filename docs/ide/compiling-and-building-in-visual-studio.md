---
title: Compile and build in Visual Studio
description: Learn how to build applications in Visual Studio using the IDE, MSBuild command-line tools, CMake, or Azure Pipelines for CI/CD automation.
ms.date: 2/23/2026
ms.subservice: compile-build
ms.topic: how-to
helpviewer_keywords:
- builds [Visual Studio], about building in Visual Studio
- custom build steps, types of builds
author: ghogen
ms.author: ghogen
manager: mijacobs
ai-usage: ai-assisted
ms.custom: awp-ai
---
# Compile and build in Visual Studio

Visual Studio provides multiple ways to build your applications, from interactive IDE builds with integrated debugging to automated CI/CD pipelines. This article helps you choose the right build method for your scenario and provides links to detailed documentation for each approach.

For a first introduction to building within the IDE, see [Tutorial: Build an application](walkthrough-building-an-application.md).

## Choose a build method

Use the following table to determine which build method best fits your needs:

| Build Method | Benefits |
| --- | --- |
| IDE |- Create builds immediately and test them in a debugger.<br />- Run multi-processor builds for C++ and C# projects.<br />-   Customize different aspects of the build system. |
| CMake | - Build C++ projects using the CMake tool<br />- Use the same build system across Linux and Windows platforms. |
| MSBuild command line| - Build projects without installing Visual Studio.<br />- Run multi-processor builds for all project types.<br />-   Customize most areas of the build system.|
| Azure Pipelines | - Automate your build process as part of a continuous integration/continuous delivery pipeline.<br />- Apply automated tests with every build.<br />- Employ virtually unlimited cloud-based resources for build processes.<br />- Modify the build workflow and create build activities to perform deeply customized tasks.|

The documentation in this section goes into further details of the IDE-based build process. For more information on the other methods, see [CMake](/cpp/build/cmake-projects-in-visual-studio), [MSBuild](../msbuild/msbuild.md) and [Azure Pipelines](/azure/devops/pipelines/index?view=vsts&preserve-view=true), respectively.

## Building from the IDE

When you create a project, Visual Studio creates default project and solution configurations. These configurations define how the solutions and projects are built and deployed. Project configurations are specific to a target platform (such as Windows or Linux) and build type (such as debug or release). You can edit these configurations however you like, and can also create your own configurations as needed. See [Project and solution configurations](understanding-build-configurations.md).

Next, see [Building and cleaning projects and solutions in Visual Studio](building-and-cleaning-projects-and-solutions-in-visual-studio.md) to learn about the different customizations you can make to the process. Customizations include [changing output directories](how-to-change-the-build-output-directory.md), [specifying custom build events](specifying-custom-build-events-in-visual-studio.md), [managing project dependencies](how-to-create-and-remove-project-dependencies.md), [managing build log files](how-to-view-save-and-configure-build-log-files.md), and [suppressing compiler warnings](how-to-suppress-compiler-warnings.md).

From there, you can explore a variety of other tasks:
- [Configure projects to target platforms](how-to-configure-projects-to-target-platforms.md)
- [Manage project and solution properties](managing-project-and-solution-properties.md)
- Specify build events in [C#](how-to-specify-build-events-csharp.md) and [Visual Basic](how-to-specify-build-events-visual-basic.md)
- [Set build options](configure-build-run-options.md)
- [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)

## Related content

- [Tutorial: Build an application](walkthrough-building-an-application.md)
- [MSBuild reference](../msbuild/msbuild.md)
- [CMake projects in Visual Studio](/cpp/build/cmake-projects-in-visual-studio)
- [Azure Pipelines documentation](/azure/devops/pipelines/?view=azure-devops&preserve-view=true)
