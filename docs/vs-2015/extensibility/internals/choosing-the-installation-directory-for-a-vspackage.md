---
title: "Choosing the Installation Directory for a VSPackage | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "VSPackages, installation directory"
ms.assetid: 01fbbb5b-f747-446c-afe0-2a081626a945
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# Choosing the Installation Directory for a VSPackage
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A VSPackage and its supporting files must be on a user's file system. The location depends on whether the VSPackage is managed or unmanaged, your side-by-side versioning scheme, and user choice.  
  
## Unmanaged VSPackages  
 An unmanaged VSPackage is a COM server that can be installed in any location. Its registration information must accurately reflects its location. Your installer user interface (UI) should provide a default location as a subdirectory of the ProgramFilesFolder Windows Installer property. For example:  
  
 [ProgramFilesFolder]MyCompany\MyVSPackageProduct\V1.0\  
  
 The user should be allowed to change the default directory to accommodate users who keep a small boot partition and prefer to install applications and tools on another volume.  
  
 If your side-by-side scheme uses a versioned VSPackage, you can use subdirectories to store different versions. For example:  
  
 [ProgramFilesFolder]MyCompany\MyVSPackageProduct\V1.0\2002\  
  
 [ProgramFilesFolder]MyCompany\MyVSPackageProduct\V1.0\2003\  
  
 [ProgramFilesFolder]MyCompany\MyVSPackageProduct\V1.0\2005\  
  
## Managed VSPackages  
 Managed VSPackages can also be installed in any location. However, you should consider always installing them to the global assembly cache (GAC) to reduce assembly load times. Because managed VSPackages are always strong-named assemblies, installing them in the GAC means that their strong-name signature verification takes only at installation time. Strong-named assemblies installed elsewhere in the file system must have their signatures verified every time they are loaded. When you install managed VSPackages in the GAC, use the regpkg tool's **/assembly** switch to write registry entries pointing to the assembly's strong name.  
  
 If you install managed VSPackages in a location other than the GAC, follow the earlier advice given for unmanaged VSPackages for choosing directory hierarchies. Use the regpkg tool's **/codebase** switch to write registry entries pointing to the path of the VSPackage assembly.  
  
 For more information, see [Registering and Unregistering VSPackages](../../extensibility/registering-and-unregistering-vspackages.md).  
  
## Satellite DLLs  
 By convention, VSPackage satellite DLLs — which contain resources for a particular locale — are located in subdirectories of the VSPackage directory. The subdirectories correspond to locale ID (LCID) values.  
  
 [Managing VSPackages](../../extensibility/managing-vspackages.md) indicates that registry entries control where [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] actually looks for a VSPackage's satellite DLL. However, [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] tries to load a satellite DLL in a subdirectory named for an LCID value, in the following order:  
  
1. Default LCID (VS LCID for example \1033 for English)  
  
2. Default LCID with the default sublanguage.  
  
3. System default LCID.  
  
4. System default LCID with the default sublanguage.  
  
5. U.S. English (.\1033 or .\0x409).  
  
   If your VSPackage DLL includes resources and the SatelliteDll\DllName registry entry points to it, [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] attempts to load them in the above order.  
  
## See Also  
 [Choosing Between Shared and Versioned VSPackages](../../extensibility/choosing-between-shared-and-versioned-vspackages.md)   
 [Managing VSPackages](../../extensibility/managing-vspackages.md)   
 [Managed Package Registration](https://msdn.microsoft.com/f69e0ea3-6a92-4639-8ca9-4c9c210e58a1)
