---
title: "Redistributable Components"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5072281f-3cb3-4985-bd93-c7981233bf92
caps.latest.revision: 20
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Redistributable Components
The Visual Studio SDK includes code that you can distribute to users according to the terms of the Visual Studio SDK license agreement. Such redistributable components include Windows Installer packages and merge modules that become part of your product's setup process, and source code that you compile into your VSPackages.  
  
 The following table describes the redistributable components that are included in the Visual Studio SDK. The components can be found in *Visual Studio SDK installation path*\VisualStudioIntegration\Redistributables\\.  
  
|File name|Description|  
|---------------|-----------------|  
|VSSDKTestHost.exe|You can install this executable as part of your installation.|  
  
## Installing Redistributable Packages  
 Redistributable components that install executable code are provided as Windows Installer packages (.msi files) so that Microsoft can provide updates if they are required to address security vulnerabilities or other critical bugs.  
  
 Because Windows Installer allows for only one package to install at a time, installing a redistributable package requires that you use a separate executable program that installs several packages sequentially. Such a program is often called a *chainer* or a *bootstrapper*.  
  
> [!IMPORTANT]
>  *Nested installation* (also known as *concurrent installation*) is discouraged in Windows Installer because a "nested" product cannot be patched independently. It can be patched only by the product that installed it. Because the Visual Studio SDK redistributable packages install files to shared directories and must support independent patching, they must not be installed by using a nested installation.  
  
## See Also  
 [Releasing a Product](../VS_not_in_toc/Releasing-a-Visual-Studio-Integration-Product.md)