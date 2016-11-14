---
title: "How to: Add a Dependency to a VSIX Package | Microsoft Docs"
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
  - "package reference"
  - "package assembly"
  - "package dll"
  - "vsix reference"
ms.assetid: 8f20177b-dab9-43a3-b959-81a591b451d6
caps.latest.revision: 12
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
# How to: Add a Dependency to a VSIX Package
You can set up a VSIX package deployment that installs any dependencies that are not already present on the target computer. To accomplish this, include the VSIX dependencies to the source.extension.vsixmanifest file.  
  
#### To add a dependency  
  
1.  Open the source.extension.vsixmanifest file in the **Design** view. Go to the **Dependencies** tab and click **New**.  
  
2.  To add an installed extension: in the **Add New Dependency** dialog box, select **Installed extension** and then, for the **Name**, select an extension on the list.  
  
3.  To add another VSIX that is not installed: : in the **Add New Dependency** dialog box, select **File on file system** and then use the **Browse** button to select the VSIX.  
  
## See Also  
 [VSIX Extension Schema 1.0 Reference](http://msdn.microsoft.com/en-us/76e410ec-b1fb-4652-ac98-4a4c52e09a2b)   
 [Anatomy of a VSIX Package](../extensibility/anatomy-of-a-vsix-package.md)   
 [Preparing Extensions for Windows Installer Deployment](../extensibility/preparing-extensions-for-windows-installer-deployment.md)