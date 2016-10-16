---
title: "About File Name Extensions"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "file extensions"
  - "file name extensions"
ms.assetid: 99f4f9ff-fb84-4258-9787-6890f308a57f
caps.latest.revision: 11
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
# About File Name Extensions
When you register a file extension of a VSPackage, you associate it with a version of [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)]. This is important if more than one version of [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] is installed on a computer.  
  
 File extensions for VSPackages are registered under HKEY_CLASSES_ROOT key with a default value that points to the associated programmatic identifier (ProgID).  
  
 The following is an example of the registration information for the .vcproj file extension:  
  
```  
HKEY_CLASSES_ROOT\  
   .vcproj\  
      (default)=" VisualStudio.vcproj.8.0"   
```  
  
 Files associated with [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] must have a versioned ProgID, such as `VisualStudio.vcproj.8.0`, to allow side-by-side installations of the product to maintain file extension associations among product versions. A version-specific ProgID also allows you to use standard verbs, such as open, edit, and so on, without the concern of overwriting or being overwritten by other applications or versions of [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)].  
  
 In certain cases, the ProgID associated with a file extension should not be changed. For example, the ProgID for the .htm file extension (progid = htmlfile) is hard coded in a number of places in the operating system, and is widely known and used in association with .htm and .html files.  
  
## See Also  
 [Registering File Name Extensions for Side-By-Side Deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md)   
 [Specifying File Handlers for File Name Extensions](../extensibility/specifying-file-handlers-for-file-name-extensions.md)