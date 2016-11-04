---
title: "-UseEnv (devenv.exe) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VC.Project.UseEnvVars.ExcludePath"
  - "VC.Project.UseEnvVars.LibraryPath"
  - "VC.Project.UseEnvVars.SourcePath"
  - "VC.Project.UseEnvVars.Include"
  - "VC.Project.UseEnvVars.Path"
  - "VC.Project.UseEnvVars.ReferencePath"
helpviewer_keywords: 
  - "UseEnv switch"
  - "/UseEnv Devenv switch"
  - "Devenv, /UseEnv"
ms.assetid: 2dd14603-a61b-42d2-ba31-427a0ee8a799
caps.latest.revision: 6
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
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
# /UseEnv (devenv.exe)
Starts [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] and loads environmental variables into the **VC++ Directories** dialog box.  
  
## Syntax  
  
```  
Devenv /useenv  
```  
  
## Example  
 The following example starts [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] and loads environment variables into the **VC++ Directories** dialog box.  
  
```  
Devenv.exe /useenv  
```  
  
## See Also  
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)