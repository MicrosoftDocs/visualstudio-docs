---
title: "-Setup (devenv.exe)"
ms.custom: na
ms.date: 10/06/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
H1: /Setup (devenv.exe)
ms.assetid: 87608b7f-a156-400c-80f5-fc823f843e61
caps.latest.revision: 14
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# -Setup (devenv.exe)
Forces Visual Studio to merge the resource metadata that describes menus, toolbars, and command groups, from all available VSPackages.  
  
## Syntax  
  
```  
devenv /setup  
```  
  
## Remarks  
 This switch takes no arguments. The `devenv /setup` command is typically given as the last step of the installation process. Use of the `/setup` switch does not start Visual Studio.  
  
 You must run `devenv` as an administrator in order to use the [/setup (devenv.exe)](../VS_IDE/-Setup--devenv.exe-.md) and [/InstallVSTemplates (devenv.exe)](../VS_IDE/-InstallVSTemplates--devenv.exe-.md) switches.  
  
## Example  
 This example shows the last step in the installation of a version of Visual Studio that includes VSPackages.  
  
```  
devenv /setup  
```  
  
## See Also  
 [Devenv Command Line Switches](../VS_IDE/Devenv-Command-Line-Switches.md)