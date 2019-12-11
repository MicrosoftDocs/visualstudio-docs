---
title: "Resolving Assemblies at Design Time | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "msbuild"
ms.assetid: 20dae076-733e-49c1-a2e9-b336757ae21d
caps.latest.revision: 12
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Resolving Assemblies at Design Time
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you add a reference to an assembly through the .NET tab of the Add Reference dialog, the reference points to an intermediate reference assembly, that is, an assembly that contains all the type and signature information, but that does not necessarily contain any code. The .NET tab lists reference assemblies that correspond to runtime assemblies in the .NET Framework. In addition, it lists reference assemblies that correspond to runtime assemblies in the registered AssemblyFoldersEx folders used by third parties.  
  
## Multi-Targeting  
 [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)] lets you target versions of the .NET Framework that run either on the Common Language Runtime (CLR) version 2.0 or version 4. This includes .NET Framework versions 2.0, 3.0, 3.5, 4, 4.5, and 4.5.1, and Silverlight versions 1.0, 2.0, and 3.0. If a new .NET Framework version that is based on CLR version 2.0 or version 4 is released, the Framework can be installed by using a targeting pack, and it will automatically show up as a target in Visual Studio.  
  
## How Type Resolution Works  
 At runtime, the CLR resolves the types in the assembly by looking in the GAC, the bin directory, and in any probing paths. This is handled by the fusion loader. But, how does the fusion loader know what it is looking for? This depends on a resolution made at design time, when the application is built.  
  
 During the build, the compiler resolves application types by using reference assemblies. In .NET Framework versions 2.0, 3.0, 3.5, 4, 4.5, and 4.5.1, the reference assemblies are installed when the .NET Framework is installed.  
  
 The reference assemblies are supplied by the targeting pack that ships with the corresponding version of the .NET Framework SDK. The Framework itself provides only the runtime assemblies. In order to build applications, you need to install both the .NET Framework and the corresponding .NET Framework SDK.  
  
 When you target a specific .NET Framework, the build system resolves all types by using the reference assemblies in the targeting pack. At runtime, the fusion loader resolves these same types to the runtime assemblies, which are typically located in the GAC.  
  
 If reference assemblies are not available, then the build system resolves assembly types by using the runtime assemblies. Because runtime assemblies in the GAC are not distinguished by minor version numbers, it is possible that resolution will be made to the wrong assembly. This could happen, for example, if a new method introduced in the .NET Framework version 3.5 is referenced while targeting version 3.0. The build will succeed, and the application will run on the build machine, but will fail when deployed to a machine that does not have version 3.5 installed.  
  
 The targeting pack that now ships with the .NET Framework SDK includes a list of all of the runtime assemblies in that version of the Framework, called the redistribution (redist) list. This makes it impossible for the build system to resolve types against the wrong version of the assembly.  
  
## See Also  
 [Advanced Concepts](../msbuild/msbuild-advanced-concepts.md)
