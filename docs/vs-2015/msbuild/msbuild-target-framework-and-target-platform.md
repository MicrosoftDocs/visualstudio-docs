---
title: "MSBuild Target Framework and Target Platform | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
ms.assetid: df6517c5-edd6-4cc4-97ad-b3cdfc78e799
caps.latest.revision: 13
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Target Framework and Target Platform
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A project can be built to run on a *target framework*, which is a particular version of the .NET Framework, and a *target platform*, which is a particular software architecture.  For example, you can target an application to run on the .NET Framework 2.0 on a 32-bit platform that is compatible with the 802x86 processor family (“x86”). The combination of target framework and target platform is known as the *target context*.  
  
## Target Framework and Profile  
 A target framework is the particular version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] that your project is built to run on. Specification of a target framework is required because it enables compiler features and assembly references that are exclusive to that version of the framework.  
  
 Currently, the following versions of the .NET Framework are available for use:  
  
- The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] 2.0 (included in Visual Studio 2005)  
  
- The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] 3.0 (included in [!INCLUDE[wiprlhext](../includes/wiprlhext-md.md)])  
  
- The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] 3.5 (included in [!INCLUDE[vs_orcas_long](../includes/vs-orcas-long-md.md)])  
  
- The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] 4 (included in Visual Studio 2010)  
  
- The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] 4.5 (included in [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)])  
  
- The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] 4.5.1 (included in [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)])  
  
- The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] 4.5.2  
  
- The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] 4.6 (included in [!INCLUDE[vs_dev14](../includes/vs-dev14-md.md)])  
  
  The versions of the .NET Framework differ from one another in the list of assemblies that each makes available to reference. For example, you cannot build Windows Presentation Foundation (WPF) applications unless your project targets the .NET Framework version 3.0 or above.  
  
  The target framework is specified in the `TargetFrameworkVersion` property in the project file. You can change the target framework for a project by using the project property pages in the Visual Studio integrated development environment (IDE). For more information, see [How to: Target a Version of the .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md). The available values for `TargetFrameworkVersion` are `v2.0`, `v3.0`, `v3.5`, `v4.0`, `v4.5`, `v4.5.1`, `v4.5.2`, and `v4.6`.  
  
```  
<TargetFrameworkVersion>v4.0</TargetFrameworkVersion>  
```  
  
 A *target profile* is a subset of a target framework. For example, the .NET Framework 4 Client profile does not include references to the MSBuild assemblies.  
  
 The target profile is specified in the `TargetFrameworkProfile` property in a project file. You can change the target profile by using the target-framework control in the project property pages in the IDE. For more information, see [How to: Target a Version of the .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md).  
  
```  
<TargetFrameworkVersion>v4.0</TargetFrameworkVersion>  
<TargetFrameworkProfile>Client</TargetFrameworkProfile>  
```  
  
## Target Platform  
 A *platform* is combination of hardware and software that defines a particular runtime environment. For example,  
  
- `x86` designates a 32-bit Windows operating system that is running on an Intel 80x86 processor or its equivalent.  
  
- `Xbox` designates the Microsoft Xbox 360 platform.  
  
  A *target platform* is the particular platform that your project is built to run on. The target platform is specified in the `Platform` build property in a project file. You can change the target platform by using the project property pages or the **Configuration Manager** in the IDE.  
  
```  
<PropertyGroup>  
   <Platform>x86</Platform>  
</PropertyGroup>  
  
```  
  
 A *target configuration* is a subset of a target platform. For example, the `x86``Debug` configuration does not include most code optimizations. The target configuration is specified in the `Configuration` build property in a project file. You can change the target configuration by using the project property pages or the **Configuration Manager**.  
  
```  
<PropertyGroup>  
   <Platform>x86</Platform>  
   <Configuration>Debug</Configuration>  
<PropertyGroup>  
  
```  
  
## See Also  
 [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)
