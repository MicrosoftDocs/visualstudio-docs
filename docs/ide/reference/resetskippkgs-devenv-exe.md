---
title: "-ResetSkipPkgs (devenv.exe) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "/ResetSkipPkgs Devenv switch"
  - "Devenv, /ResetSkipPkgs switch"
  - "ResetSkipPkgs switch"
ms.assetid: 7ece64f9-cfa4-4b34-b0d9-1c338b9557b3
caps.latest.revision: 3
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# /ResetSkipPkgs (devenv.exe)
Clears all options to skip loading added to VSPackages by users wishing to avoid loading problem VSPackages, then starts [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].  
  
## Syntax  
  
```  
Devenv /ResetSkipPkgs  
```  
  
## Remarks  
 The presence of a SkipLoading tag disables the loading of a VSPackage; clearing the tag re-enables the loading of the VSPackage.  
  
## Example  
 The following example clears all SkipLoading tags.  
  
```  
Devenv.exe /ResetSkipPkgs  
```  
  
## See Also  
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)