---
title: "Using Multiple Processors to Build Projects | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "multiple processors"
  - "MSBuild, multiple processor systems"
ms.assetid: 49fa36c9-8e14-44f5-8a2b-34146cf6807b
caps.latest.revision: 13
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Using Multiple Processors to Build Projects
MSBuild can take advantage of systems that have multiple processors, or multiple-core processors. A separate build process is created for each available processor. For example, if the system has four processors, then four build processes are created. [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] can process these builds simultaneously, and therefore overall build time is reduced. However, parallel building introduces some changes in how build processes occur. This topic discusses those changes.  
  
## Project to Project References  
 When the [!INCLUDE[vstecmsbuildengine](../msbuild/includes/vstecmsbuildengine_md.md)] encounters a project-to-project (P2P) reference while it is using parallel builds to build a project, it builds the reference only one time. If two projects have the same P2P reference, the reference is not rebuilt for each project. Instead, the build engine returns the same P2P reference to both projects that depend on it. Future requests in the session for the same target are provided the same P2P reference.  
  
## Cycle Detection  
 Cycle detection functions the same as it did in [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] 2.0, except that now [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] can report the detection of the cycle at a different time or in the build.  
  
## Errors and Exceptions During Parallel Builds  
 In parallel builds, errors and exceptions can occur at different times than they do in a non-parallel build, and when one project does not build, the other project builds continue. [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] will not stop any project build that is building in parallel with the one that failed. Other projects continue to build until they either succeed or fail. However, if <xref:Microsoft.Build.Framework.IBuildEngine.ContinueOnError%2A> has been enabled, then no builds will stop even if an error occurs.  
  
## Visual C++ Project (.vcproj) and Solution (.sln) Files  
 Both [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] projects (.vcproj) and solution (.sln) files can be passed to the [MSBuild Task](../msbuild/msbuild-task.md). For [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] projects, VCWrapperProject is called, and then the internal [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project is created. For [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] solutions, a SolutionWrapperProject is created, and then the internal [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project is created. In both cases, the resulting project is treated the same as any other [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project.  
  
## Multi-Process Execution  
 Almost all build-related activities require the current directory to remain constant throughout the build process to prevent path-related errors. Therefore, projects cannot run on different threads in [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] because they would cause multiple directories to be created.  
  
 To avoid this problem but still enable multi-processor builds, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] uses "process isolation." By using process isolation, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] can create a maximum of `n` processes, where `n` equals the number of processors available on the system. For example, if [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] builds a solution on a system that has two processors, then only two build processes are created. These processes are re-used to build all the projects in the solution.  
  
## See Also  
 [Building Multiple Projects in Parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)   
 [Tasks](../msbuild/msbuild-tasks.md)