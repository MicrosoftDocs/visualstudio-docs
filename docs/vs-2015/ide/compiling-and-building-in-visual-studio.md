---
title: "Compiling and Building"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "builds [Visual Studio], about building in Visual Studio"
  - "custom build steps, types of builds"
ms.assetid: c7958821-285f-4e28-9e7a-b5d8b40336a1
caps.latest.revision: 30
author: jillre
ms.author: jillfra
manager: jillfra
---
# Compiling and Building in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use Visual Studio to build applications and to create assemblies and executable programs at frequent intervals during a development cycle. By building your code often, you can identify compile-time errors, such as incorrect syntax, misspelled keywords, and type mismatches, earlier. You can also detect and correct run-time errors, such as logic errors and semantic errors, by frequently building and running debug versions of the code.

 When you have fully developed and sufficiently debugged a project or solution, you can compile its components in a Release build. By default, a Release build is optimized and designed to be smaller and run faster than a debug version. For more information, see [Walkthrough: Building an Application](../ide/walkthrough-building-an-application.md).

## Choosing a Build Method
 You can build an application by using the default build options in the IDE, at a command prompt, or by using Team Foundation Build. Each of these options use MSBuild as the underlying technology, and each approach has specific benefits, as the following table shows.

|Build Method|Benefits|For more information|
|------------------|--------------|--------------------------|
|Using the IDE|-   You can more easily create and run builds immediately.<br />-   You can run multi-processor builds for C++ and C# projects.<br />-   You can customize some aspects of the build system.|[Building and Cleaning Projects and Solutions in Visual Studio](../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md)|
|Running an MSBuild command line|-   You can build projects without installing Visual Studio.<br />-   You can run multi-processor builds for all project types.<br />-   You can customize most areas of the build system.|[MSBuild](../msbuild/msbuild.md)|
|Using Team Foundation Build|-   You can automate your build process. For example, you can build one or more projects nightly or every time that code is checked in. You can also build projects on shared build servers rather than on your development computer.<br />-   You can quickly specify the code that you want to build, the tests that you want to run, and other common options.<br />-   You can modify the build workflow, and as needed, create build activities to perform deeply customized tasks.|[Build the application](/azure/devops/pipelines/index)|

## Building from the IDE
 When you create a project, default build configurations are defined for it, and a solution build configuration is assigned to it to provide context for builds. Solution configurations define how the projects in solution are built and deployed. Project configurations are a set of project properties that are unique for a platform and build type (for example, Release Win32). You can edit these default configurations, and you can create your own configurations. For more information, see [Introduction to the Project Designer](https://msdn.microsoft.com/898dd854-c98d-430c-ba1b-a913ce3c73d7) and [NIB How to: Modify Project Properties and Configuration Settings](https://msdn.microsoft.com/e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67).

 From within the IDE, you can perform the following additional tasks:

- [Change the build output directory](../ide/how-to-change-the-build-output-directory.md).

- [Identify projects that are dependent on the output from another project in order to build correctly](../ide/how-to-create-and-remove-project-dependencies.md).

- [Change the amount of information included in the build log or Output window for builds](../ide/how-to-view-save-and-configure-build-log-files.md).

- [Hide specific compiler warnings for Visual C#, Visual C++, or Visual Basic](../ide/how-to-suppress-compiler-warnings.md).

- [Specify custom pre-compile and post-compile actions for a build](../ide/specifying-custom-build-events-in-visual-studio.md).

- Improve build performance by using parallel builds. For more information, see [Building Multiple Projects in Parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md) or the blog post [Tuning C++ build parallelism](https://blogs.msdn.microsoft.com/msbuild/2010/03/07/tuning-c-build-parallelism-in-vs2010/).

## See Also
 [Walkthrough: Building an Application](../ide/walkthrough-building-an-application.md)
 [Understanding Build Configurations](../ide/understanding-build-configurations.md)
 [Understanding Build Platforms](../ide/understanding-build-platforms.md)
 [Building (Compiling) Web Site Projects](https://msdn.microsoft.com/library/a9cbb88c-8fff-4c67-848b-98fbfd823193)
 [How to: Create and Remove Project Dependencies](../ide/how-to-create-and-remove-project-dependencies.md)
