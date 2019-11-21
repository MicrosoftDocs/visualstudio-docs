---
title: "Building Multiple Projects in Parallel with MSBuild | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "parallel project builds"
  - "building multiple projects in parallel"
  - "msbuild, building projects in parallel"
ms.assetid: c8c9aadc-33ad-4aa1-b07d-b879e9eabda0
caps.latest.revision: 23
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Building Multiple Projects in Parallel with MSBuild
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use MSBuild to build multiple projects faster by running them in parallel. To run builds in parallel, you use the following settings on a multi-core or multiple processor computer:  
  
- The `/maxcpucount` switch at a command prompt.  
  
- The <xref:Microsoft.Build.Tasks.MSBuild.BuildInParallel%2A> task parameter on an MSBuild task.  
  
> [!NOTE]
> The **/verbosity** (**/v**) switch in a command line can also affect build performance. Your build performance might decrease if the verbosity of your build log information is set to detailed or diagnostic, which are used for troubleshooting. For more information, see [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md) and [Command-Line Reference](../msbuild/msbuild-command-line-reference.md).  
  
## /maxcpucount Switch  
 If you use the `/maxcpucount` switch, or `/m` for short, MSBuild can create the specified number of MSBuild.exe processes that may be run in parallel. These processes are also known as "worker processes." Each worker process uses a separate core or processor, if any are available, to build a project at the same time as other available processors may be building other projects. For example, setting this switch to a value of "4" causes MSBuild to create four worker processes to build the project.  
  
 If you include the `/maxcpucount` switch without specifying a value, MSBuild will use up to the number of processors on the computer.  
  
 For more information about this switch, which was introduced in MSBuild 3.5, see [Command-Line Reference](../msbuild/msbuild-command-line-reference.md).  
  
 The following example instructs MSBuild to use three worker processes. If you use this configuration, MSBuild can build three projects at the same time.  
  
```  
msbuild.exe myproj.proj /maxcpucount:3  
```  
  
## BuildInParallel Task Parameter  
 `BuildInParallel` is an optional boolean parameter on a [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] task. When `BuildInParallel` is set to `true` (its default value), multiple worker processes are generated to build as many projects at the same time as possible. For this to work correctly, the `/maxcpucount` switch must be set to a value greater than 1, and the system must be at least dual-core or have two or more processors.  
  
 The following is an example, taken from microsoft.common.targets, about how to set the `BuildInParallel` parameter.  
  
```  
<PropertyGroup>  
    <BuildInParallel Condition="'$(BuildInParallel)' ==   
        ''">true</BuildInParallel>  
</PropertyGroup>  
<MSBuild  
    Projects="@(_MSBuildProjectReferenceExistent)"  
    Targets="GetTargetPath"  
    BuildInParallel="$(BuildInParallel)"  
    Properties="%(_MSBuildProjectReferenceExistent.SetConfiguration);   
        %(_MSBuildProjectReferenceExistent.SetPlatform)"  
    Condition="'@(NonVCProjectReference)'!='' and   
        ('$(BuildingSolutionFile)' == 'true' or   
        '$(BuildingInsideVisualStudio)' == 'true' or   
        '$(BuildProjectReferences)' != 'true') and     
        '@(_MSBuildProjectReferenceExistent)' != ''"  
    ContinueOnError="!$(BuildingProject)">  
    <Output TaskParameter="TargetOutputs"   
        ItemName="_ResolvedProjectReferencePaths"/>  
</MSBuild>  
```  
  
## See Also  
 [Using Multiple Processors to Build Projects](../msbuild/using-multiple-processors-to-build-projects.md)   
 [Writing Multi-Processor-Aware Loggers](../msbuild/writing-multi-processor-aware-loggers.md)   
 [Tuning C++ Build Parallelism blog](https://go.microsoft.com/fwlink/?LinkId=251457)
