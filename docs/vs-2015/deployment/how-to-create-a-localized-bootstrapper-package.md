---
title: "How to: Create a Localized Bootstrapper Package | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
helpviewer_keywords: 
  - "localized bootstrapper packages"
  - "dependencies, creating localized bootstrapper packages"
  - "prerequisites, creating localized bootstrapper packages"
ms.assetid: 66a1bc7e-6540-4164-963d-557196a69d8a
caps.latest.revision: 17
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Create a Localized Bootstrapper Package
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

After you create a bootstrapper package, you can create localized versions of the bootstrapper package by creating two more files for each locale: a software license terms file (such as a eula.rtf) and a package manifest (package.xml).  
  
 By default, Visual Studio 2010 includes localized bootstrapper packages only for .NET Framework 4, .NET Framework 4 Client Profile, F# Runtime 2.0, and F# Runtime 4.0. You can create localized packages for other bootstrappers by completing three steps.  
  
1. Create a folder that is named after the locale name in \Program Files\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages\\*BootstrapperPackageName*.  
  
2. Create a file that contains the software license terms for the bootstrapper package and put it in the new folder.  
  
3. Create a package manifest named package.xml, update the strings and culture, and put the file in the new folder. If you have already created a bootstrapper of Visual Studio in the target language, you can copy the Visual Studio package.xml file and modify it in this step.  
  
> [!NOTE]
> If you are using a Setup project to deploy applications, you can localize your application by changing the **Localization** property.  
  
 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]  
  
### To create a localized bootstrapper package  
  
1. Create a folder that is named after the locale name.  
  
     On 32-bit computers, create the folder in the \Program Files\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages\\*BootstrapperPackageName*\ folder.  
  
     On 64-bit computers, create the folder in the \Program Files (86)\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages\\*BootstrapperPackageName*\ folder.  
  
     The following table shows the folder names that you can use to match a locale.  
  
    |Locale|Folder name|  
    |------------|-----------------|  
    |Chinese (Simplified)|zh-Hans|  
    |Chinese (Traditional)|zh-Hant|  
    |Czech|cs|  
    |German|de|  
    |English|en|  
    |Spanish|es|  
    |French|fr|  
    |Italian|it|  
    |Korean|ko|  
    |Japanese|ja|  
    |Polish|pl|  
    |Portuguese (Brazil)|pt-BR|  
    |Russian|ru|  
    |Turkish|tr|  
  
2. Create a file that contains the software license terms for the bootstrapper package and put it in the new folder.  
  
3. Create a package manifest named package.xml and put it in the new folder. For more information, see [How to: Create a Package Manifest](../deployment/how-to-create-a-package-manifest.md).  
  
4. Update the `<Strings>` section of the package manifest so that the strings are in the correct language for the locale.  
  
5. Change the `<String Name="Culture">` value to match the folder name.  
  
6. Save the package.xml file.  
  
### To create a bootstrapper package for .NET Framework 3.5 Service Pack 1 localized in French  
  
1. Create a folder that is named fr. The folder name must match the locale name.  
  
     On 32-bit computers, create the folder in the \Program Files\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages\DotNetFX35SP1\ folder.  
  
     On 64-bit computers, create the folder in the \Program Files (86)\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages\DotNetFX35SP1\ folder.  
  
2. Put a localized version of the software license terms into the fr folder.  
  
3. Copy the \Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages\DotNetFX35SP1\en\package.xml file to the fr folder, and open the file in the XML Designer.  
  
4. Update the `<Strings>` section of the package manifest so that the error strings are in French.  
  
5. Change the `<String Name="Culture">` value to fr.  
  
6. Save the package.xml file.  
  
## See Also  
 [Creating Bootstrapper Packages](../deployment/creating-bootstrapper-packages.md)   
 [Application Deployment Prerequisites](../deployment/application-deployment-prerequisites.md)   
 [How to: Create a Package Manifest](../deployment/how-to-create-a-package-manifest.md)
