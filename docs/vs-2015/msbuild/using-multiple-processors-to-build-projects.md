---
title: "Using Multiple Processors to Build Projects | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "multiple processors"
  - "MSBuild, multiple processor systems"
ms.assetid: 49fa36c9-8e14-44f5-8a2b-34146cf6807b
caps.latest.revision: 17
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Using Multiple Processors to Build Projects
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

MSBuild can take advantage of systems that have multiple processors, or multiple-core processors. A separate build process is created for each available processor. For example, if the system has four processors, then four build processes are created. [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] can process these builds simultaneously, and therefore overall build time is reduced. However, parallel building introduces some changes in how build processes occur. This topic discusses those changes.  
  
## Project to Project References  
 When the [!INCLUDE[vstecmsbuildengine](../includes/vstecmsbuildengine-md.md)] encounters a project-to-project (P2P) reference while it is using parallel builds to build a project, it builds the reference only one time. If two projects have the same P2P reference, the reference is not rebuilt for each project. Instead, the build engine returns the same P2P reference to both projects that depend on it. Future requests in the session for the same target are provided the same P2P reference.  
  
## Cycle Detection  
 Cycle detection functions the same as it did in [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] 2.0, except that now [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] can report the detection of the cycle at a different time or in the build.  
  
## Errors and Exceptions During Parallel Builds  
 In parallel builds, errors and exceptions can occur at different times than they do in a non-parallel build, and when one project does not build, the other project builds continue. [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] will not stop any project build that is building in parallel with the one that failed. Other projects continue to build until they either succeed or fail. However, if <xref:Microsoft.Build.Framework.IBuildEngine.ContinueOnError%2A> has been enabled, then no builds will stop even if an error occurs.  
  
## Visual C++ Project (.vcproj) and Solution (.sln) Files  
 Both [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] projects (.vcproj) and solution (.sln) files can be passed to the [MSBuild Task](../msbuild/msbuild-task.md). For [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] projects, VCWrapperProject is called, and then the internal [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project is created. For [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] solutions, a SolutionWrapperProject is created, and then the internal [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project is created. In both cases, the resulting project is treated the same as any other [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project.  
  
## Multi-Process Execution  
 Almost all build-related activities require the current directory to remain constant throughout the build process to prevent path-related errors. Therefore, projects cannot run on different threads in [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] because they would cause multiple directories to be created.  
  
 To avoid this problem but still enable multi-processor builds, [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] uses "process isolation." By using process isolation, [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] can create a maximum of `n` processes, where `n` equals the number of processors available on the system. For example, if [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] builds a solution on a system that has two processors, then only two build processes are created. These processes are re-used to build all the projects in the solution.  
  
## See also  
 [Building Multiple Projects in Parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)   
 [Tasks](../msbuild/msbuild-tasks.md)
