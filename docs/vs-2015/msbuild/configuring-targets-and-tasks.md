---
title: "Configuring Targets and Tasks | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
ms.assetid: 9aabe67a-1720-4bbf-80d3-822b3ccf75c0
caps.latest.revision: 10
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Configuring Targets and Tasks
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can configure MSBuild targets and tasks to run out-of-process with MSBuild so that you can target contexts that differ from the one you are running on. For example, you can target a 32-bit .NET Framework 2.0 application while the development computer is running on a 64-bit .NET Framework 4.5 operating system. You can also target computers that run with the .NET Framework 4 or earlier. The combination of 32- or 64-bitness and the specific .NET Framework version is known as the *target context*.  
  
## Installation  
 The .NET Framework 4.5 and 4.5.1 replace the common language runtime (CLR), targets, tasks, and tools of the .NET Framework 4 without renaming them. The .NET Framework 4.5.1 is installed as part [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)].  
  
 If you want to install MSBuild separately from Visual Studio, you can download the installation package from [MSBuild Download](https://go.microsoft.com/fwlink/?LinkId=309745). You must also install the .NET Framework versions you wish to use also.  
  
## Targets and Tasks  
 MSBuild runs certain build tasks out of process to target a larger set of contexts.  For example, a 32-bit MSBuild might run a build task in a 64-bit process to target a 64-bit computer. This is controlled by `UsingTask` arguments and `Task` parameters. The targets installed by the .NET Framework 4.5 set these arguments and parameters, and no changes are required to build applications for the various target contexts.  
  
 If you want to create your own target context, you must set these arguments and parameters appropriately. Look in the .NET Framework 4.5 Microsoft.Common.targets file and the Microsoft.Common.Tasks file for examples.  For information about how to create a custom task that can work with multiple target contexts, or how to modify existing tasks, see [How to: Configure Targets and Tasks](../msbuild/how-to-configure-targets-and-tasks.md).  
  
## See Also  
 [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)
