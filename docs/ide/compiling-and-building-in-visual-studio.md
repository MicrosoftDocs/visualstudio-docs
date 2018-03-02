---
title: "Compiling and building in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 07/14/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "builds [Visual Studio], about building in Visual Studio"
  - "custom build steps, types of builds"
ms.assetid: c7958821-285f-4e28-9e7a-b5d8b40336a1
caps.latest.revision: 28
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---

# Compiling and building in Visual Studio

Running a build creates assemblies and executable applications from your source code at any point during a development cycle. In general, the build process is very similar across many different project types such as Windows, ASP.NET, mobile apps, and others. The build process is also very similar across programming languages such as C#, Visual Basic, C++, and F#. 

By building your code often, you can quickly identify compile-time errors, such as incorrect syntax, misspelled keywords, and type mismatches. You can also quickly detect and correct run-time errors, such as logic errors and semantic errors, by frequently building and running debug versions of the code.  

A successful build is essentially a validation that the application's source code contains correct syntax and that all static references to libraries, assemblies, and other components have been resolved. This produces an application executable that can then be tested for proper functioning in both a [debugging environment](../debugger/index.md) and through a variety of manual and automated tests to [validate code quality](../test/improve-code-quality.md). Once the application has been fully tested, you can then compile a release version to deploy to your customers. For an introduction to this process, see [Walkthrough: Building an Application](../ide/walkthrough-building-an-application.md).  

Within the Visual Studio product family, there are three methods you can use to build an application: the Visual Studio IDE, the MSBuild command-line tools, and Team Foundation Build on Visual Studio Team Services:
 
| Build Method | Benefits | 
| --- |--- | --- |  
| IDE |- Create builds immediately and test them in a debugger.<br />- Run multi-processor builds for C++ and C# projects.<br />-   Customize different aspects of the build system. |
| MSBuild command line| - Build projects without installing Visual Studio.<br />- Run multi-processor builds for all project types.<br />-   Customize most areas of the build system.|
| Team Foundation Build | - Automate your build process as part of a continuous integration/continuous delivery pipeline.<br />- Apply automated tests with every build.<br />- Employ virtually unlimited could-based resources for build processes.<br />- Modify the build workflow and create build activities to perform deeply customized tasks.|  

The documentation in this section goes into further details of the IDE-based build process. For more information on the other methods, see [MSBuild](../msbuild/msbuild.md) and [Continuous integration and deployment](https://www.visualstudio.com/docs/build/overview), respectively.

## Overview of building from the IDE  

When you create a project, Visual Studio created default build configurations for the project and the solution that contains the project.  These configurations define how the solutions and projects are built and deployed. Project configurations in particular are unique for a target platform (such as Windows pr Linux) and build type (such as debug or release). You can edit these configurations however you like, and can also create your own configurations as needed.

For a first introduction to building within the IDE, see [Walkthrough: Building an Application](walkthrough-building-an-application.md).  

Next, see [Building and cleaning projects and solutions in Visual Studio](building-and-cleaning-projects-and-solutions-in-visual-studio.md) to learn about the different aspects customizations you can make to the process. Customizations include [changing output directories](how-to-change-the-build-output-directory.md), [specifying custom build events](specifying-custom-build-events-in-visual-studio.md), [managing project dependencies](how-to-create-and-remove-project-dependencies.md), [managing build log files](how-to-view-save-and-configure-build-log-files.md), and [suppressing compiler warnings](how-to-suppress-compiler-warnings.md).

From there, you can explore a variety of other tasks:
- [Understand build configurations](understanding-build-configurations.md)
- [Understand build platforms](understanding-build-platforms.md)
- [Manage Project and Solution Properties](managing-project-and-solution-properties.md).  
- Specify build events in [C#](how-to-specify-build-events-csharp.md) and [Visual Basic](how-to-specify-build-events-visual-basic.md). 
- [Set build options](reference/options-dialog-box-projects-and-solutions-build-and-run.md)
- [Build Multiple Projects in Parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md).  
  
## See Also  

- [Building (Compiling) Web Site Projects](http://msdn.microsoft.com/Library/a9cbb88c-8fff-4c67-848b-98fbfd823193)   
