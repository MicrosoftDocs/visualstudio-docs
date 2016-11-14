---
title: "Component Management | Microsoft Docs"
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
  - "installation [Visual Studio SDK], components"
  - "installation [Visual Studio SDK], file management"
ms.assetid: 029bffa2-6841-4caa-a41a-442467e1aedc
caps.latest.revision: 13
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
# Component Management
Units of tasks in the Windows Installer are referred to as Windows Installer components (sometimes called WICs or just components). A GUID identifies each WIC, which is the basic unit of installation and reference counting for setups that use Windows Installer.  
  
 Although you can use several products to create your VSPackage installer, this discussion assumes the use of Windows Installer (.msi) files. When creating your installer, you must correctly manage file deployment so that the correct reference counting happens at all times. Consequently, different versions of your product will not interfere with or break each other in a mix of install and uninstall scenarios.  
  
 In Windows Installer, reference counting occurs at the component level. You must carefully organize your resources — files, registry entries, and so on — into components. There are other levels of organization — such as modules, features, and products — that can help in different scenarios. For more information, see [Windows Installer Basics](../../extensibility/internals/windows-installer-basics.md).  
  
## Guidelines of Authoring Setup for Side-by-side Installation  
  
-   Author files and registry keys that are shared among versions into their own components.  
  
     This allows you to easily consume them in the next version. For example, type libraries that are registered globally, file extensions, other items registered in HKEY_CLASSES_ROOT, and so on.  
  
-   Group shared components into separate merge modules.  
  
     This helps you author correctly for side-by-side moving forward.  
  
-   Install shared files and registry keys by using the same Windows Installer components across versions.  
  
     If you use a different component, files and registry entries are uninstalled when one versioned VSPackage is uninstalled but another VSPackage is still installed.  
  
-   Do not mix versioned and shared items in the same component.  
  
     Doing so makes it impossible to install shared items to a global location and versioned items to isolated locations.  
  
-   Do not have shared registry keys that point to versioned files.  
  
     If you do, the shared keys will be overwritten when another versioned VSPackage is installed. After you remove the second version, the file to which the key is pointing is gone.  
  
## See Also  
 [Choosing Between Shared and Versioned VSPackages](../../extensibility/choosing-between-shared-and-versioned-vspackages.md)   
 [VSPackage Setup Scenarios](../../extensibility/internals/vspackage-setup-scenarios.md)