---
title: "Authoring a Windows Installer Package | Microsoft Docs"
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
  - ".msi files, VSPackages"
  - "msi files, VSPackages"
ms.assetid: 0ce7c21d-0d3f-47fe-a0bb-eed506e32609
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
# Authoring a Windows Installer Package
Data drives the Windows Installer model. Rather than writing a procedural script to copy files and write registry entries, for example, you author rows and columns in database tables that contain file and registry data.  
  
## Database Entries  
 To install a VSPackage, a Windows Installer package must contain database entries to perform the following tasks:  
  
-   Search the system to locate the versions of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] your VSPackage supports (using Windows Installer tables that include AppSearch, CompLocator, RegLocator, DrLocator, and Signature).  
  
-   Cancel the installation if no supported version of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is installed or if another system requirement of the VSPackage is not met (using the LaunchCondition table).  
  
-   Install the VSPackage and dependent files (using the directory, component, and file tables).  
  
-   Add appropriate information for the VSPackage to the registry (using the Registry table).  
  
-   Integrate the VSPackage in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] by calling **devenv.exe /setup** (using the CustomAction table).  
  
 For more information, see [Windows Installer](http://msdn.microsoft.com/library/cc185688\(VS.85\).aspx).  
  
## Setup Tools  
 A variety of third-party setup tools provide a development environment for Windows Installer packages. Two free tools are the following:  
  
-   InstallShield Limited Edition  
  
     You can get a limited version of InstallShield through the Visual Studio **New Project** dialog. Expand **Other Project Types** and then select **Setup and Deployment**. Select the InstallShield template.  
  
-   Windows Installer XML Toolset  
  
     The Toolset builds Windows Installer packages from XML source files. The Toolset is a Microsoft open-source project. You can download the source code and executables from [http://sourceforge.net/projects/wix](http://sourceforge.net/projects/wix).  
  
 For commercial products that integrate into [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] by using the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)], see [http://visualstudiogallery.com](http://visualstudiogallery.com/).  
  
## See Also  
 [Installing VSPackages With Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md)