---
title: "-Updateconfiguration (devenv.exe) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "/updateconfiguration Devenv switch"
  - "Devenv, /updateconfiguration switch"
  - "updateconfiguration Devenv switch"
ms.assetid: 9a1084cc-8b68-4ccc-aaea-f95939164338
caps.latest.revision: 3
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# /Updateconfiguration (devenv.exe)
Notifies [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] to merge the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] packages on the system and check the MEF cache for any changes.  
  
## Syntax  
  
```  
devenv /updateconfiguration  
```  
  
## Remarks  
 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] runs this command automatically when you install a VSIX package. You should run `devenv.exe /updateconfiguration` after patching your files so that [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] updates the MEF cache. This enables you to evaluate whether your fix is adequate.  
  
## Example  
 The following command line causes [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] to merge the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] packages on the system and check the MEF cache for any changes.  
  
```  
Devenv.exe /updateconfiguration  
```  
  
## See Also  
 [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)   
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)