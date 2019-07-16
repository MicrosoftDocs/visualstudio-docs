---
title: "How to: Build Specific Targets in Solutions By Using MSBuild.exe | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "MSBuild, building specific targets in a solution"
  - "msbuild.exe, building specific targets in a solution"
  - "MSBuild, msbuild.exe"
ms.assetid: f46feb9b-4c16-4fec-b6e1-36a959692ba3
caps.latest.revision: 12
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Build Specific Targets in Solutions By Using MSBuild.exe
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use MSBuild.exe to build specific targets of specific projects in a solution.  
  
### To build a specific target of a specific project in a solution  
  
1. At the command line, type `MSBuild.exe <SolutionName>.sln`, where `<SolutionName>` corresponds to the file name of the solution that contains the target that you want to execute.  
  
2. Specify the target after the **/t** switch in the format *ProjectName*:*TargetName*.  
  
## Example  
 The following example executes the `Rebuild` target of the `NotInSlnFolder` project, and then executes the `Clean` target of the `InSolutionFolder` project, which is located in the `NewFolder` solution folder.  
  
```  
msbuild SlnFolders.sln /t:NotInSlnfolder:Rebuild;NewFolder\InSolutionFolder:Clean  
```  
  
## See Also  
 [Command-Line Reference](../msbuild/msbuild-command-line-reference.md)   
 [MSBuild Reference](../msbuild/msbuild-reference.md)   
 [MSBuild](msbuild.md)  
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)
