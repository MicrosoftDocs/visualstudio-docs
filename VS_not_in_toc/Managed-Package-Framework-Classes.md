---
title: "Managed Package Framework Classes"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 15aedcc3-c79a-460b-b620-43223f1ae81e
caps.latest.revision: 24
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Managed Package Framework Classes
The managed package framework (MPF) classes can be used to create VSPackages using managed code. They provide default implementations for many VSPackage interfaces. By hiding implementation details and complexities, MPF enables you to create Visual Studio integration products with a minimum amount of code.  
  
> [!WARNING]
>  Most of the assemblies that contain Managed Package Framework classes are shipped with the Visual Studio SDK. You can download the source code for the Managed Packaged Framework for Projects at [Managed Package Framework for Projects](http://mpfproj11.codeplex.com/).  
  
## MPF Namespaces  
 The following table lists the MPF namespaces provided by the Visual Studio SDK.  
  
|Name space|Contents|  
|----------------|--------------|  
|<xref:Microsoft.VisualStudio?qualifyHint=False>|Contains useful classes for handling COM errors, Visual Studio constants, and Win32 windows.|  
|<xref:Microsoft.VisualStudio.Package?qualifyHint=False>|Includes managed code wrappers for Visual Studio projects, editors, and MSBuild.|  
|<xref:Microsoft.VisualStudio.Shell?qualifyHint=False>|Includes MPF base classes from which you can derive an implementation of many common Visual Studio objects.|  
|<xref:Microsoft.VisualStudio.Shell.Design?qualifyHint=False>|Contains Visual Studio designer extensions.|  
|<xref:Microsoft.VisualStudio.Shell.Design.Serialization?qualifyHint=False>|Contains Visual Studio serialization designer extensions.|  
|<xref:Microsoft.VisualStudio.Shell.Design.Serialization.CodeDom?qualifyHint=False>|Contains Visual Studio CodeDom designer extensions.|  
|<xref:Microsoft.VisualStudio.Shell.Flavor?qualifyHint=False>|Supports project subtypes (also known as "flavors").|  
  
## See Also  
 [VSPackages and the Managed Package Framework](../VS_not_in_toc/VSPackages-and-the-Managed-Package-Framework.md)   
 [Using Visual Studio Interop Assemblies](../Topic/Using%20Visual%20Studio%20Interop%20Assemblies.md)   
 [VSPackages and the Managed Package Framework](../VS_not_in_toc/VSPackages-and-the-Managed-Package-Framework.md)