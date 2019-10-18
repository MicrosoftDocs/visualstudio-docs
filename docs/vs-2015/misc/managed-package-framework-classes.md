---
title: "Managed Package Framework Classes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "managed package framework, helper classes"
  - "managed package helper classes"
  - "Visual Studio SDK, managed package helper classes"
  - "classes [Visual Studio SDK], managed package framework"
ms.assetid: 15aedcc3-c79a-460b-b620-43223f1ae81e
caps.latest.revision: 24
manager: jillfra
---
# Managed Package Framework Classes
The managed package framework (MPF) classes can be used to create VSPackages using managed code. They provide default implementations for many VSPackage interfaces. By hiding implementation details and complexities, MPF enables you to create [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] integration products with a minimum amount of code.  
  
> [!WARNING]
> Most of the assemblies that contain Managed Package Framework classes are shipped with the Visual Studio SDK. You can download the source code for the Managed Packaged Framework for Projects at [Managed Package Framework for Projects](http://mpfproj11.codeplex.com/).  
  
## MPF Namespaces  
 The following table lists the MPF namespaces provided by the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)].  
  
|Name space|Contents|  
|----------------|--------------|  
|<xref:Microsoft.VisualStudio>|Contains useful classes for handling COM errors, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] constants, and Win32 windows.|  
|<xref:Microsoft.VisualStudio.Package>|Includes managed code wrappers for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] projects, editors, and MSBuild.|  
|<xref:Microsoft.VisualStudio.Shell>|Includes MPF base classes from which you can derive an implementation of many common Visual Studio objects.|  
|<xref:Microsoft.VisualStudio.Shell.Design>|Contains [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] designer extensions.|  
|<xref:Microsoft.VisualStudio.Shell.Design.Serialization>|Contains [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] serialization designer extensions.|  
|<xref:Microsoft.VisualStudio.Shell.Design.Serialization.CodeDom>|Contains [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] CodeDom designer extensions.|  
|<xref:Microsoft.VisualStudio.Shell.Flavor>|Supports project subtypes (also known as "flavors").|  
  
## See also  
 [VSPackages and the Managed Package Framework](../misc/vspackages-and-the-managed-package-framework.md)   
 [Using Visual Studio Interop Assemblies](../extensibility/internals/using-visual-studio-interop-assemblies.md)   
 [VSPackages and the Managed Package Framework](../misc/vspackages-and-the-managed-package-framework.md)