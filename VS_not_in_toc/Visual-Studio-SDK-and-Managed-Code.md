---
title: "Visual Studio SDK and Managed Code"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 16b3d88e-b5d8-49a5-a5d7-07cbb0b7e4fc
caps.latest.revision: 20
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
# Visual Studio SDK and Managed Code
*Managed code* is code that is written in any language that targets the common language runtime (CLR), such as Visual Basic, Visual C#, or Visual C++. Regardless of the language that it is written in, all managed code is compiled into Microsoft Intermediate Language (MSIL) instead of native code.  
  
## Environment Support for Managed VSPackages  
 To support creating a VSPackage or project with a managed language such as Visual C#, the Visual Studio SDK provides the following:  
  
-   The Visual Studio interop assemblies, which enable VSPackages written in managed code to interoperate with the unmanaged (COM) Visual Studio integrated development environment (IDE). For more information, see [Using Visual Studio Interop Assemblies](../Topic/Using%20Visual%20Studio%20Interop%20Assemblies.md).  
  
-   A set of Managed Package Framework (MPF) classes that provides a higher-level abstraction for working with the Visual Studio IDE. These classes encapsulate some of the most frequently used interfaces and types in the Visual Studio interop assemblies. They greatly reduce the amount of work that you must do to provide the basic functionality of a VSPackage or project. For more information, see [Managed Package Framework Classes](../VS_not_in_toc/Managed-Package-Framework-Classes.md).  
  
-   A set of basic VSPackage samples written in managed code. The managed samples build on an example of a simple, fully functional VSPackage to demonstrate a basic editor, a tool window, an object extender, and other components. For more information, see [VSSDK Samples](../VS_not_in_toc/VSSDK-Samples.md).  
  
## See Also  
 [Managed VSPackages](../VS_not_in_toc/Managed-VSPackages.md)   
 [Using Visual Studio Interop Assemblies](../Topic/Using%20Visual%20Studio%20Interop%20Assemblies.md)   
 [Managed Package Framework Classes](../VS_not_in_toc/Managed-Package-Framework-Classes.md)