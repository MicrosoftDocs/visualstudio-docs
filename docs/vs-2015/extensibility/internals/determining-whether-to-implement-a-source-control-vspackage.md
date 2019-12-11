---
title: "Determining Whether to Implement a Source Control VSPackage | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "source control packages, about source control packages"
ms.assetid: 60b3326e-e7e2-4729-95fc-b682e7ad5c99
caps.latest.revision: 25
ms.author: gregvanl
manager: jillfra
---
# Determining Whether to Implement a Source Control VSPackage
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This section elaborates the choices of source control plug-ins and source control VSPackages for extending source control solutions and gives broad guidelines about choosing a suitable integration path.  
  
## Small Source Control Solution with Limited Resources  
 If you have limited resources and cannot be burdened with the overhead of writing a source control package, you can create Source Control Plug-in API-based plug-ins. This allows you to work side by side with source control packages, and you can switch between source control plug-ins and packages on demand. For more information, see [Registration and Selection](../../extensibility/internals/registration-and-selection-source-control-vspackage.md).  
  
## Large Source Control Solution with a Rich Feature Set  
 If you want to implement a source control solution that provides a rich source control model that is not adequately captured by using the Source Control Plug-in API, you may consider a source control package as the integration path. This applies especially if you would rather replace the Source Control Adapter Package (which communicates with source control plug-ins and provides a basic source control UI) with your own so that you can handle the source control events in a custom manner. If you already have a satisfactory source control UI and want to preserve that experience in [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], the source control package option lets you do just that. The source control package is not generic and is designed solely for use with [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] IDE.  
  
 If you want to implement a source control solution that provides flexibility and richer control over the source control logic and UI, you may prefer the source control package integration route. You can:  
  
1. Register your own source control VSPackage (see [Registration and Selection](../../extensibility/internals/registration-and-selection-source-control-vspackage.md)).  
  
2. Replace the default source control UI with your custom UI (see [Custom User Interface](../../extensibility/internals/custom-user-interface-source-control-vspackage.md)).  
  
3. Specify glyphs to be used and handle Solution Explorer glyph events (see [Glyph Control](../../extensibility/internals/glyph-control-source-control-vspackage.md)).  
  
4. Handle Query Edit and Query Save events (see [Query Edit Query Save](../../extensibility/internals/query-edit-query-save-source-control-vspackage.md)).  
  
## See Also  
 [Creating a Source Control Plug-in](../../extensibility/internals/creating-a-source-control-plug-in.md)
