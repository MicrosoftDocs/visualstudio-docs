---
title: "CreatePkgDef Utility | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "package definition"
  - "create pkgdef"
  - "pkgdef"
  - "createpkgdef"
ms.assetid: c745cb76-47a6-49ff-9eed-16af0f748e35
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# CreatePkgDef Utility
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Takes a .dll file for a Visual Studio extension as a parameter and creates a .pkgdef file to accompany the .dll. The .pkgdef file contains all the information that would otherwise be written to the system registry when the extension is installed.  
  
> [!NOTE]
> Most of the project templates that are included in the Visual Studio SDK automatically create .pkgdef files as part of the build process. This document is intended for those who want to create packages manually, or convert existing packages to use .pkgdef deployment.  
  
## Syntax  
  
```  
CreatePkgDef /out=FileName [/codebase] [/assembly] AssemblyPath  
```  
  
## Arguments  
 /out=`FileName`  
 Required. Sets the name of the .pkgdef output file to`FileName`.  
  
 /codebase  
 Optional. Forces registration with the CodeBase utility.  
  
 /assembly  
 Forces registration with the Assembly utility.  
  
 `AssemblyPath`  
 The path of the .dll file from which you want to generate the .pkgdef.  
  
## Remarks  
 Extension deployment by using .pkgdef files replaces the registry requirements of earlier versions of Visual Studio.  
  
 The .pkgdef files must be installed in one of the following locations: %localappdata%\Microsoft\Visual Studio\14.0\Extensions\ or %vsinstalldir%\Common7\IDE\Extensions\\. If the installation folder is %localappdata%\Microsoft\Visual Studio\14.0\Extensions\\, the extension will be recognized by Visual Studio, but will be disabled by default. The user can enable the extension by using **Extensions and Updates**. If the installation folder is %vsinstalldir%\Common7\IDE\Extensions\\, the extension is enabled by default.  
  
> [!NOTE]
> The **Extensions and Updates** tool cannot be used to access an extension unless it is installed as part of a VSIX package.  
  
## See Also  
 [CreateExpInstance Utility](../../extensibility/internals/createexpinstance-utility.md)
