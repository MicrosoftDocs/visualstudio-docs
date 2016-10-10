---
title: "-ResetSkipPkgs (devenv.exe)"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
H1: /ResetSkipPkgs (devenv.exe)
ms.assetid: 7ece64f9-cfa4-4b34-b0d9-1c338b9557b3
caps.latest.revision: 3
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
# -ResetSkipPkgs (devenv.exe)
Clears all options to skip loading added to VSPackages by users wishing to avoid loading problem VSPackages, then starts Visual Studio.  
  
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
 [Devenv Command Line Switches](../VS_IDE/Devenv-Command-Line-Switches.md)