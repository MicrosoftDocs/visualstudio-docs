---
title: Compiling building
ms.date: 07/14/2017
ms.technology: vs-ide-compile
ms.topic: conceptual
helpviewer_keywords:
  - "builds [Visual Studio], about building in Visual Studio"
  - "custom build steps, types of builds"
ms.assetid: c7958821-285f-4e28-9e7a-b5d8b40336a1
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
  - "multiple"
---
# Compile and build in Visual Studio

When you build source code, the build engine creates assemblies and executable applications. In general, the build process is very similar across many different project types such as Windows, ASP.NET, mobile apps, and others. The build process is also similar across programming languages such as C#, Visual Basic, C++, and F#.

By building your code often, you can quickly identify compile-time errors, such as incorrect syntax, misspelled keywords, and type mismatches. You can also detect and correct run-time errors, such as logic errors and semantic errors, by building and running debug versions of the code.

A successful build validates that the application's source code contains correct syntax and that all static references to libraries, assemblies, and other components can resolve. An application executable is produced that can be tested for proper functioning in both a [debugging environment](../debugger/index.yml) and through a variety of manual and automated tests to [validate code quality](../test/improve-code-quality.md). Once the application has been fully tested, you can compile a release version to deploy to your customers. For an introduction to this process, see [Walkthrough: Building an application](../ide/walkthrough-building-an-application.md).

You can use any of the following methods to build an application: the Visual Studio IDE, the MSBuild command-line tools, and Azure Pipelines:

| Build Method | Benefits |
| --- |--- | --- |
| IDE |- Create builds immediately and test them in a debugger.<br />- Run multi-processor builds for C++ and C# projects.<br />-   Customize different aspects of the build system. |
| MSBuild command line| - Build projects without installing Visual Studio.<br />- Run multi-processor builds for all project types.<br />-   Customize most areas of the build system.|
| Azure Pipelines | - Automate your build process as part of a continuous integration/continuous delivery pipeline.<br />- Apply automated tests with every build.<br />- Employ virtually unlimited cloud-based resources for build processes.<br />- Modify the build workflow and create build activities to perform deeply customized tasks.|

The documentation in this section goes into further details of the IDE-based build process. For more information on the other methods, see [MSBuild](../msbuild/msbuild.md) and [Azure Pipelines](/azure/devops/pipelines/index?view=vsts), respectively.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Compile and build in Visual Studio for Mac](/visualstudio/mac/compiling-and-building).

## Overview of building from the IDE

When you create a project, Visual Studio created default build configurations for the project and the solution that contains the project.  These configurations define how the solutions and projects are built and deployed. Project configurations in particular are unique for a target platform (such as Windows or Linux) and build type (such as debug or release). You can edit these configurations however you like, and can also create your own configurations as needed.

For a first introduction to building within the IDE, see [Walkthrough: Building an application](walkthrough-building-an-application.md).

Next, see [Building and cleaning projects and solutions in Visual Studio](building-and-cleaning-projects-and-solutions-in-visual-studio.md) to learn about the different aspects customizations you can make to the process. Customizations include [changing output directories](how-to-change-the-build-output-directory.md), [specifying custom build events](specifying-custom-build-events-in-visual-studio.md), [managing project dependencies](how-to-create-and-remove-project-dependencies.md), [managing build log files](how-to-view-save-and-configure-build-log-files.md), and [suppressing compiler warnings](how-to-suppress-compiler-warnings.md).

From there, you can explore a variety of other tasks:
- [Understand build configurations](understanding-build-configurations.md)
- [Understand build platforms](understanding-build-platforms.md)
- [Manage project and solution properties](managing-project-and-solution-properties.md).
- Specify build events in [C#](how-to-specify-build-events-csharp.md) and [Visual Basic](how-to-specify-build-events-visual-basic.md).
- [Set build options](reference/options-dialog-box-projects-and-solutions-build-and-run.md)
- [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md).

## See also

- [Building (compiling) website projects](https://msdn.microsoft.com/Library/a9cbb88c-8fff-4c67-848b-98fbfd823193)
- [Compile and build (Visual Studio for Mac)](/visualstudio/mac/compiling-and-building)