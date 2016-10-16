---
title: "-SafeMode (devenv.exe)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "/SafeMode Devenv switch"
  - "Devenv, /SafeMode switch"
  - "SafeMode switch"
ms.assetid: b191f6a5-8f12-47ec-bcc7-b68149a22aa8
caps.latest.revision: 5
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
# /SafeMode (devenv.exe)
Starts [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] in safe mode, loading only the default environment and services.  
  
## Syntax  
  
```  
devenv /SafeMode   
```  
  
## Remarks  
 This switch prevents all third-party VSPackages from loading when [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] starts, thus ensuring stable execution.  
  
## Description  
 The following example starts [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] in safe mode.  
  
## Code  
  
```  
Devenv.exe /SafeMode  
```  
  
## See Also  
 [Devenv Command Line Switches](../reference/devenv-command-line-switches.md)