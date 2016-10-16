---
title: "Wizard (.Vsz) File"
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
  - ".vsz files"
  - "vsz files"
  - "wizards, files"
ms.assetid: 72e1d0f3-eef1-455e-b803-96827f030f50
caps.latest.revision: 9
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
# Wizard (.Vsz) File
The integrated development environment (IDE) uses .vsz files to start wizards. These .vsz files contain information that the IDE uses to determine which wizard to call and what information to pass to the wizard.  
  
 A .vsz file is a version of an .ini-formatted text file that has no sections. Information known to the IDE is stored at the beginning of the file. This provides a link between the wizard that the IDE calls and the parameters that are in the .vsz file to be passed to the IDE. The rest of the file provides parameters that are specific to the wizard and that are to be collected by the IDE and passed to the specific wizard.  
  
 The following example shows the contents of a .vsz file.  
  
```  
VSWizard 8.0  
Wizard=VsWizard.CBlankSiteWizard -or- {123-1234556-123334}  
Param="WIZARDNAME = Wizard One"  
Param="WIZARDUI = FALSE"  
```  
  
 Following are the parts in the .vsz file.  
  
|Part|Description|  
|----------|-----------------|  
|VSWizard|The first parameter in the file is the version number of the template file format. This version number must be 6.0, 7.0, 7.1, or 8.0. Other numbers cannot be started and cause an Invalid Format error.|  
|Wizard|This field contains the OLE ProgID of the wizard, or alternatively a GUID string representation of the CLSID of the wizard that is cocreated by the IDE.|  
|Param|These parts are optional. You can add as many as needed.|  
  
 The parameters enable the .vsz file to pass additional custom parameters to the wizard. Each value is passed as a string element in an array of variants to the wizard. For more information, see [Custom Parameters](../extensibility/custom-parameters.md). For information about how to use a .vsz file in the development of custom wizards, see [.Vsz File (Project Control)](../Topic/.Vsz%20File%20\(Project%20Control\).md)  
  
 To add a default locale ID to your .vsz file, specify `FALLBACK_LCID`=xxxx, where xxxx is the locale ID, for example, 1033 for English. When `FALLBACK_LCID` parameter is defined, the wizard uses the supplied fallback locale ID if the current ID is not found.  
  
## See Also  
 [Custom Parameters](../extensibility/custom-parameters.md)   
 [Wizards](../extensibility/wizards.md)   
 [Template Directory Description (.Vsdir) Files](../extensibility/template-directory-description--.vsdir--files.md)