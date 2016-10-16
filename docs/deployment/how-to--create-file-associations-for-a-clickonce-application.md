---
title: "How to: Create File Associations For a ClickOnce Application"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "file associations, ClickOnce applications"
  - "ClickOnce deployment, file associations"
ms.assetid: 835230c8-3177-440f-85e3-e40f1d8b4f9d
caps.latest.revision: 7
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
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
# How to: Create File Associations For a ClickOnce Application
[!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications can be associated with one or more file name extensions, so that the application will be started automatically when the user opens a file of those types. Adding file name extension support to a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application is straightforward.  
  
### To create file associations for a ClickOnce application  
  
1.  Create a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application normally, or use your existing [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application.  
  
2.  Open the application manifest with a text or XML editor, such as Notepad.  
  
3.  Find the `assembly` element. For more information, see [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md).  
  
4.  As a child of the `assembly` element, add a `fileAssociation` element. The `fileAssociation` element has four attributes:  
  
    -   `extension`: The file name extension you want to associate with the application.  
  
    -   `description`: A description of the file type, which will appear in the Windows shell.  
  
    -   `progid`: A string uniquely identifying the file type, to mark it in the registry.  
  
    -   `defaultIcon`: An icon to use for this file type. The icon must be added as a file resource in the application manifest. For more information, see [How to: Include a Data File in a ClickOnce Application](../deployment/how-to--include-a-data-file-in-a-clickonce-application.md).  
  
     For an example of the `file` and `fileAssociation` elements, see [\<fileAssociation> Element](../deployment/-fileassociation--element--clickonce-application-.md).  
  
5.  If you want to associate more than one file type with the application, add additional `fileAssociation` elements. Note that the `progid` attribute should be different for each.  
  
6.  Once you have finished with the application manifest, re-sign the manifest. You can do this from the command line by using Mage.exe.  
  
     `mage -Sign WindowsFormsApp1.exe.manifest -CertFile mycert.pfx`  
  
     For more information, see [Mage.exe (Manifest Generation and Editing Tool)](../Topic/Mage.exe%20\(Manifest%20Generation%20and%20Editing%20Tool\).md)  
  
## See Also  
 [\<fileAssociation> Element](../deployment/-fileassociation--element--clickonce-application-.md)   
 [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md)   
 [Mage.exe (Manifest Generation and Editing Tool)](../Topic/Mage.exe%20\(Manifest%20Generation%20and%20Editing%20Tool\).md)