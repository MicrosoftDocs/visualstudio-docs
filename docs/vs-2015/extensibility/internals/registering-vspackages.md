---
title: "Registering VSPackages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "managed VSPackages, registering"
  - "registration, managed VSPackages"
ms.assetid: 79b9424e-7e9b-4fc8-9b9f-00212674573c
caps.latest.revision: 21
ms.author: gregvanl
manager: jillfra
---
# Registering VSPackages
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

[!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] relies on .pkgdef files to describe and locate a VSPackage. A .pkgdef file contains all the registration information that would otherwise be added to the system registry. Managed VSPackages are registered by adding attributes to the source code and then running the [CreatePkgDef Utility](../../extensibility/internals/createpkgdef-utility.md) on the resulting assembly to generate a .pkgdef file.  
  
## In This Section  
 [Specifying VSPackage File Location to the VS Shell](../../extensibility/internals/specifying-vspackage-file-location-to-the-vs-shell.md)  
 Describes the loading path for VSPackages.  
  
 [Registering and Unregistering VSPackages](../../extensibility/registering-and-unregistering-vspackages.md)  
 Explains how to register a VSPackage.  
  
 [Using a Custom Registration Attribute to Register an Extension](../../misc/using-a-custom-registration-attribute-to-register-an-extension.md)  
 Describes how to create a registration manifest that can be used to deploy a managed VSPackage.
