---
title: "Elements of the Isolated Shell | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio shell, isolated mode"
ms.assetid: f8d68c3d-9134-4a8f-b566-485956cd321e
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# Elements of the Isolated Shell
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can modify the registry settings, run-time settings, and application entry point of your isolated shell application, and its .vsct, .pkgdef, and.pkgundef files.  
  
## Registry Settings  
 Both the .pkgdef and the .pkgundef files modify the registry settings for the isolated shell application. When the application is run, the registry settings are defined in the following sequence:  
  
 When the application is run, the registry settings are defined in the following sequence:  
  
1. The registry key for the application is created.  
  
2. The registry is updated from the .pkgdef file of the application by defining specified keys and entries.  
  
3. For every package that is part of your application, the registry is updated from the .pkgdef file of that package. Each package is defined in the .pkgdef file of the application by the $RootKey$\Packages\\{*vsPackageGuid*} key for the package.  
  
4. The registry is updated from the AppEnvConfig.pkgdef and BaseConfig.pkgdef in the *Visual Studio SDK installation path*\Common7\IDE\ShellExtensions\Platform directory. These files are part of Visual Studio and also part of the Visual Studio Shell (isolated mode) redistributable package.  
  
5. The registry is updated from the .pkgundef file of the application by removing specified keys and entries.  
  
## Run-Time Settings  
 When a user starts the isolated shell application, it calls the Start entry point of the Visual Studio shell. Application settings are defined when your application starts, as follows:  
  
1. The Visual Studio shell checks the application registry for specific keys. If the setting for a key is specified in the call to the Start entry point, then that value overrides the value in the registry.  
  
2. If neither the registry nor the entry point parameter specifies the value of a setting, then the default value for the setting is used.  
  
   When a user starts your application from the command line, all command-line switches are passed to the Visual Studio shell, which treats them in the same way that Devenv does. For more information about Devenv switches, see [Devenv Command Line Switches](../ide/reference/devenv-command-line-switches.md) and [Devenv Command-Line Switches for VSPackage Development](../extensibility/devenv-command-line-switches-for-vspackage-development.md). For more information about how a package registers for command line switches, see [Adding Command-Line Switches](../extensibility/adding-command-line-switches.md).  
  
## The Start Entry Point  
 The Appenvstub.dll file contains entry points for accessing the isolated shell. When the application starts, it calls the Start entry point of Appenvstub.dll.  
  
 You can change the behavior of the application by changing the value of the last parameter that is passed to the Start entry point. For more information, see [Isolated Shell Entry Point Parameters (C++)](../extensibility/isolated-shell-entry-point-parameters-cpp.md).  
  
## The .Vsct File  
 The .vsct file lets you specify which standard Visual Studio UI elements are available in the application. For more information, see [.Vsct Files](../extensibility/modifying-the-isolated-shell-by-using-the-dot-vsct-file.md).  
  
## The .Pkgundef File  
 When the application is installed on a computer on which Visual Studio is already installed, a copy of the Visual Studio registry entries is made for the application. By default, the application uses VSPackages that are already installed on the computer. The .pkgundef file lets you exclude registry entries in order to remove specific elements of the Visual Studio shell or extensions from the application. For more information, see [.Pkgundef Files](../extensibility/modifying-the-isolated-shell-by-using-the-dot-pkgundef-file.md).  
  
 The .pkgundef file lets you exclude registry entries in order to remove specific elements of the Visual Studio shell or extensions from the application. For more information, see [.Pkgundef Files](../extensibility/modifying-the-isolated-shell-by-using-the-dot-pkgundef-file.md).  
  
 The set of package GUIDs that you can exclude are listed in [Package GUIDs of Visual Studio Features](../extensibility/package-guids-of-visual-studio-features.md).  
  
## The .Pkgdef File  
 The .pkgdef file lets you define registry entries for the application that are set when the application is installed. For a description of the .pkgdef file and a list of registry entries that the Visual Studio shell uses, see [.Pkgdef Files](../extensibility/modifying-the-isolated-shell-by-using-the-dot-pkgdef-file.md).  
  
## Substitution Strings  
 The substitution strings used in the .pkgdef and .pkgundef files are listed in [Substitution Strings Used in .Pkgdef and .Pkgundef Files](../extensibility/substitution-strings-used-in-dot-pkgdef-and-dot-pkgundef-files.md).  
  
## Other Settings  
 If your isolated shell application depends on Microsoft.VisualStudio.GraphModel.dll, you need to add the following binding redirect to your Isolated Shell application’s .config file:  
  
```  
<dependentAssembly>  
    <assemblyIdentity name="Microsoft.VisualStudio.GraphModel" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />  
    <bindingRedirect oldVersion="11.0.0.0" newVersion="12.0.0.0"/>  
</dependentAssembly>  
  
```
