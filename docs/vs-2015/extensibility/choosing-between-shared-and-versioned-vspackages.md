---
title: "Choosing Between Shared and Versioned VSPackages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "SxS"
  - "side-by-side installation"
  - "installation [Visual Studio SDK], side-by-side"
ms.assetid: e3128ac3-2e92-48e9-87ab-3b6c9d80e8c9
caps.latest.revision: 23
ms.author: gregvanl
manager: jillfra
---
# Choosing Between Shared and Versioned VSPackages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Different versions of Visual Studio can coexist on the same computer. VSPackages can support any mix of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] versions.  
  
 You can enable side-by-side installations of VSPackages through either of two strategies, the shared strategy or the versioned strategy. Both accommodate the presence of multiple versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] and associated versions of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)].  
  
 In the shared strategy, one VSPackage is registered for use in multiple versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. In the versioned strategy, multiple VSPackage DLLs are installed, one for each version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] that you support.  
  
## Shared VSPackages  
 Using a shared VSPackage is appropriate when you use the same VSPackage in multiple versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. To implement a shared VSPackage, you must take the following steps:  
  
- Make your VSPackage compatible with multiple versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. Two ways of doing so are available:  
  
  - Limit your VSPackage to using only the features of the earliest version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] that you support.  

  - Program your VSPackage to adapt to the version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] in which it is running. Then, if queries for newer services fail, your VSPackage can offer other services that are supported in older versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
- Register your VSPackage appropriately. For more information, see [VSPackage Registration](../extensibility/internals/vspackage-registration.md) and [Managed VSPackage Registration](https://msdn.microsoft.com/f69e0ea3-6a92-4639-8ca9-4c9c210e58a1).  
  
- Register file extensions appropriately. For more information, see [Registering File Name Extensions for Side-By-Side Deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md).  
  
- Create an installer that deploys your VSPackage for the appropriate versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. For more information, see [Installing VSPackages With Windows Installer](../extensibility/internals/installing-vspackages-with-windows-installer.md) and [Component Management](../extensibility/internals/component-management.md).  
  
- Address the issue of registration collisions. For more information, see [VSPackage Registration](../extensibility/internals/vspackage-registration.md).  
  
- Ensure that both shared and versioned files respect reference counting to allow safe installation and removal of multiple versions. For more information, see [Component Management](../extensibility/internals/component-management.md).  
  
## Versioned VSPackages  
 Under the versioned VSPackage strategy, you create one VSPackage for each version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] that you support. Doing this is appropriate when you expect to take advantage of services provided by later versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], because each VSPackage can evolve without affecting the others. Nevertheless, the versioned strategy of creating multiple binaries, either from a single code base or from multiple independent code bases, might entail more initial development than the shared strategy. Also, additional setup work might be required because you must create either a separate setup for each version or a single setup that detects the versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] that are installed and that your VSPackage supports.  
  
## Binary Compatibility  
 Generally, binary compatibility enables native-code VSPackages developed with earlier versions of Visual Studio to run in later versions of Visual Studio. However, there are three important exceptions:  
  
- If your VSPackage relies on a particular version of the common language runtime, then it must determine in which version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] it is running.  
  
- A VSPackage might have a dependency on a specific feature of another VSPackage or another product. Consequently, the VSPackage can run only where the dependency is satisfied.  
  
- A VSPackage might be affected by a security fix in a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] service pack or a later version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. In those cases, a VSPackage developed with an earlier version of the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] might not run in versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] after the security fix was applied. However, you can rebuild your package with the later version and have it also run in earlier versions.  
  
  Managed VSPackages must be built using a version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] and the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] that match the target version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
  In addition to planning for binary compatibility for your VSPackage binaries, you also should consider solution and project file formats. If your VSPackage creates a new project type, you must decide whether it can run in just one version or in multiple versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. For more information, see [Upgrading Custom Projects](../misc/upgrading-custom-projects.md).  
  
## See Also  
 [Installing VSPackages With Windows Installer](../extensibility/internals/installing-vspackages-with-windows-installer.md)   
 [Component Management](../extensibility/internals/component-management.md)
