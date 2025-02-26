---
title: Use different build methods to build apps
description: Use the Visual Studio IDE build method, the MSBuild command-line tools build method, or Azure Pipelines build method to build an application.
ms.date: 2/3/2025
ms.subservice: compile-build
ms.topic: conceptual
helpviewer_keywords:
- builds [Visual Studio], about building in Visual Studio
- custom build steps, types of builds
author: ghogen
ms.author: ghogen
manager: mijacobs
---
# Compile and build in Visual Studio

For a first introduction to building within the IDE, see [Walkthrough: Building an application](walkthrough-building-an-application.md).

You can use any of the following methods to build an application: the Visual Studio IDE, the MSBuild command-line tools, and Azure Pipelines:

| Build Method | Benefits |
| --- |--- | --- |
| IDE |- Create builds immediately and test them in a debugger.<br />- Run multi-processor builds for C++ and C# projects.<br />-   Customize different aspects of the build system. |
| CMake | - Build C++ projects using the CMake tool<br />- Use the same build system across Linux and Windows platforms. |
| MSBuild command line| - Build projects without installing Visual Studio.<br />- Run multi-processor builds for all project types.<br />-   Customize most areas of the build system.|
| Azure Pipelines | - Automate your build process as part of a continuous integration/continuous delivery pipeline.<br />- Apply automated tests with every build.<br />- Employ virtually unlimited cloud-based resources for build processes.<br />- Modify the build workflow and create build activities to perform deeply customized tasks.|

The documentation in this section goes into further details of the IDE-based build process. For more information on the other methods, see [CMake](/cpp/build/cmake-projects-in-visual-studio), [MSBuild](../msbuild/msbuild.md) and [Azure Pipelines](/azure/devops/pipelines/index?view=vsts&preserve-view=true), respectively.

## Building from the IDE

When you create a project, Visual Studio created default build configurations for the project and the solution that contains the project.  These configurations define how the solutions and projects are built and deployed. Project configurations in particular are unique for a target platform (such as Windows or Linux) and build type (such as debug or release). You can edit these configurations however you like, and can also create your own configurations as needed.

For a first introduction to building within the IDE, see [Walkthrough: Building an application](walkthrough-building-an-application.md).

Next, see [Building and cleaning projects and solutions in Visual Studio](building-and-cleaning-projects-and-solutions-in-visual-studio.md) to learn about the different customizations you can make to the process. Customizations include [changing output directories](how-to-change-the-build-output-directory.md), [specifying custom build events](specifying-custom-build-events-in-visual-studio.md), [managing project dependencies](how-to-create-and-remove-project-dependencies.md), [managing build log files](how-to-view-save-and-configure-build-log-files.md), and [suppressing compiler warnings](how-to-suppress-compiler-warnings.md).

From there, you can explore a variety of other tasks:
- [Understand build configurations](understanding-build-configurations.md)
- [Configure projects to target platforms](how-to-configure-projects-to-target-platforms.md)
- [Manage project and solution properties](managing-project-and-solution-properties.md).
- Specify build events in [C#](how-to-specify-build-events-csharp.md) and [Visual Basic](how-to-specify-build-events-visual-basic.md)
- [Set build options](reference/options-dialog-box-projects-and-solutions-build-and-run.md)
- [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)

## Related content

- [Building (compiling) website projects](/previous-versions/hwxa5aha(v=vs.140))
- [CMake projects in Visual Studio](/cpp/build/cmake-projects-in-visual-studio)
