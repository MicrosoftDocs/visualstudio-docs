---
title: "Registering VSPackages | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "managed VSPackages, registering"
  - "registration, managed VSPackages"
ms.assetid: 79b9424e-7e9b-4fc8-9b9f-00212674573c
caps.latest.revision: 20
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Registering VSPackages
[!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] relies on .pkgdef files to describe and locate a VSPackage. A .pkgdef file contains all the registration information that would otherwise be added to the system registry. Managed VSPackages are registered by adding attributes to the source code and then running the [CreatePkgDef Utility](../../extensibility/internals/createpkgdef-utility.md) on the resulting assembly to generate a .pkgdef file.  
  
## In This Section  
 [Specifying VSPackage File Location to the VS Shell](../../extensibility/internals/specifying-vspackage-file-location-to-the-vs-shell.md)  
 Describes the loading path for VSPackages.  
  
 [Registering and Unregistering VSPackages](../../extensibility/registering-and-unregistering-vspackages.md)  
 Explains how to register a VSPackage.  
  
 [Using a Custom Registration Attribute to Register an Extension](../../misc/using-a-custom-registration-attribute-to-register-an-extension.md)  
 Describes how to create a registration manifest that can be used to deploy a managed VSPackage.