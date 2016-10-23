---
title: "-SafeMode (devenv.exe)"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
H1: /SafeMode (devenv.exe)
ms.assetid: b191f6a5-8f12-47ec-bcc7-b68149a22aa8
caps.latest.revision: 5
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# -SafeMode (devenv.exe)
Starts Visual Studio in safe mode, loading only the default environment and services.  
  
## Syntax  
  
```  
devenv /SafeMode   
```  
  
## Remarks  
 This switch prevents all third-party VSPackages from loading when Visual Studio starts, thus ensuring stable execution.  
  
## Description  
 The following example starts Visual Studio in safe mode.  
  
## Code  
  
```  
Devenv.exe /SafeMode  
```  
  
## See Also  
 [Devenv Command Line Switches](../VS_IDE/Devenv-Command-Line-Switches.md)