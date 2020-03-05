---
title: "VSPackages and the Managed Package Framework | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "managed package framework"
  - "VSPackages, managed package framework"
  - "managed VSPackages, managed package framework"
ms.assetid: e8d80e0f-6b5b-4baf-a7df-59fd808c60cd
caps.latest.revision: 16
manager: jillfra
---
# VSPackages and the Managed Package Framework
You can reduce development time by creating a VSPackage with the managed package framework (MPF) classes instead of by using COM interop classes.  
  
 There are two ways to create a managed VSPackage:  
  
- Use the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Package project template  
  
     For more information, see [Walkthrough: Creating a Menu Command By Using the Visual Studio Package Template](https://msdn.microsoft.com/library/1985fa7d-aad4-4866-b356-a125b6a246de).  
  
- Build your VSPackage without the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Package project template  
  
     For example, you can copy a sample VSPackage and change the GUIDs and the names. 
  
## In This Section  
 [Managed Package Framework Classes](../misc/managed-package-framework-classes.md)  
 Describes and lists the MPF class namespaces and DLL files.  
  
## Related Sections  
 [Walkthrough: Creating a Menu Command By Using the Visual Studio Package Template](https://msdn.microsoft.com/library/1985fa7d-aad4-4866-b356-a125b6a246de)  
 Explains how to create a managed VSPackage.  
  
 [Managed VSPackages](../misc/managed-vspackages.md)  
 Introduces aspects of VSPackages that apply to managed code.