---
title: "Solutions Overview | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "solutions, about solutions"
ms.assetid: 3b21e3a1-170a-4485-941e-6b04b7b27886
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Solutions Overview
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A solution is a grouping of one or more projects that work together to create an application. The project and status information pertaining to the solution are stored in two different solution files. The solution (.sln) file is text-based and can be placed under source code control and shared between users. The solution user option (.suo) file is binary. As a result, the .suo file cannot be placed under source code control and contains user-specific information.  
  
 Any VSPackage can write to either type of solution file. Because of the nature of the files, there are two different interfaces implemented to write to them. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps> interface writes text information to the .sln file and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionOpts> interface writes binary streams to the .suo file.  
  
> [!NOTE]
> A project does not have to explicitly write an entry for itself into the solution file; the environment handles that for the project. Therefore, unless you want to add additional content specifically to the solution file, you do not need to register your VSPackage in this way.  
  
 Each VSPackage supporting solution persistence uses three interfaces, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionPersistence> interface, which is implemented by the environment and called by the VSPackage, and `IVsPersistSolutionProps` and `IVsPersistSolutionOpts`, which are both implemented by the VSPackage. The `IVsPersistSolutionOpts` interface only needs to be implemented if private information is to be written by the VSPackage to the .suo file.  
  
 When a solution is opened, the following process takes place.  
  
1. The environment reads the solution.  
  
2. If the environment finds a `CLSID`, it loads the corresponding VSPackage.  
  
3. If a VSPackage is loaded, the environment calls `QueryInterface` for <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage> interface, for the interface that the VSPackage requires.  
  
   1. When reading from an .sln file, the environment calls `QueryInterface` for `IVsPersistSolutionProps`.  
  
   2. When reading from an .suo file, the environment calls `QueryInterface` for `IVsPersistSolutionOpts`.  
  
   Specific information relating to the use of these files can be found in [Solution (.Sln) File](../../extensibility/internals/solution-dot-sln-file.md) and [Solution User Options (.Suo) File](../../extensibility/internals/solution-user-options-dot-suo-file.md).  
  
> [!NOTE]
> If you want to create a new solution configuration consisting of two projects' configurations and excluding a third from the build, you need to use the Property Pages UI or automation. You can’t change the solution build manager configurations and their properties directly, but you can manipulate the solution build manager using the `SolutionBuild` class from DTE in the automation model. For more information about configuring solutions, see [Solution Configuration](../../extensibility/internals/solution-configuration.md).  
  
## See also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionOpts>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionPersistence>
