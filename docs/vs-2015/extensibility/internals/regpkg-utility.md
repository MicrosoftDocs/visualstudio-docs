---
title: "RegPkg Utility | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "regpkg, registration utility"
  - "registration, regpkg utility"
ms.assetid: 1683ee18-59d1-4bab-a674-dd00dd960de3
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# RegPkg Utility
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

> [!NOTE]
> The preferred way to register packages in Visual Studio is by using .pkgdef files. This allows for extension deployment without having to access the system registry, which is a requirement for VSIX deployment. Pkgdef files are created by using the [CreatePkgDef Utility](../../extensibility/internals/createpkgdef-utility.md). For more information on Visual Studio package deployment, see [Shipping Visual Studio Extensions](../../extensibility/shipping-visual-studio-extensions.md).  
  
 The RegPkg.exe utility registers a VSPackage with [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] and prepares it for deployment. This utility is used behind the scenes during VSPackage development. It runs as part of the build process so that you can build and run a VSPackage in the experimental hive.  
  
 RegPkg can generate system registry scripts in several formats. You can incorporate these scripts in deployment projects such as .msi projects or Windows Installer XML Toolset files.  
  
 RegPkg.exe is typically located at \<*Visual Studio SDK installation path*>\VisualStudioIntegration\Tools\Bin\RegPkg.exe. RegPkg follows this syntax:  
  
```  
RegPkg [/root:<root>] [/regfile:<regfile>] [/rgsfile:<rgsfile> [/rgm]] [/vrgfile:<vrgfile>] [/codebase | /assembly] [/unregister] AssemblyPath  
```  
  
 /root:root  
 Performs registration under the specified  
  
 [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] root.  
  
 /regfile:FileName  
 Creates a .reg file rather than updating the registry.  Cannot be used with /vrgfile or /rgsfile or /wixfile.  
  
 /rgsfile:FileName  
 Creates a .rgs file rather than updating the registry.  Cannot be used with /vrgfile or /regfile or /wixfile.  
  
 /vrgfile:FileName  
 Creates a .vrg file rather than updating the registry.  Cannot be used with /regfile or /rgsfile or /wixfile.  
  
 /rgm  
 Creates a .rgm file in addition to the rgs file.  Must be combined with /rgsfile.  
  
 /wixfile:FileName  
 Creates a Windows Installer XML Toolset-compatible file rather than updating the registry.  Cannot be used with /regfile or /rgsfile or /vrgfile.  
  
 /codebase  
 Forces registration with CodeBase rather than Assembly.  
  
 /assembly  
 Forces registration with Assembly rather than CodeBase.  
  
 /unregister  
 Unregisters this package.  Cannot be used  
  
 with /regfile or /vrgfile or /rgsfile or /wixfile.  
  
## See Also  
 [Releasing a Product](../../misc/releasing-a-visual-studio-integration-product.md)   
 [Troubleshooting RegPkg Package Registration](../../extensibility/internals/troubleshooting-regpkg-package-registration.md)
