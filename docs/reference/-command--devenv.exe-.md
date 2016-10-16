---
title: "-Command (devenv.exe)"
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
  - "Devenv, /command switch"
  - "/command Devenv switch"
ms.assetid: 13c20cd6-f09d-400a-8b7b-ecc266a32cef
caps.latest.revision: 11
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
# /Command (devenv.exe)
Executes the specified command after launching the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] integrated development environment (IDE).  
  
## Syntax  
  
```  
devenv /command CommandName  
```  
  
## Arguments  
 `CommandName`  
 Required. The complete name of a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command or its alias, enclosed in double quotation marks. For more information about command and alias syntax, see [Visual Studio Commands](../reference/visual-studio-commands.md).  
  
## Remarks  
 After startup is complete, the IDE executes the named command. If you use this switch, the IDE does not display the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Start Page on startup.  
  
 If an add-in exposes a command, you can use this switch to launch the add-in from the command line. For more information, see [How to: Control Add-Ins By Using the Add-In Manager](../Topic/How%20to:%20Control%20Add-Ins%20By%20Using%20the%20Add-In%20Manager.md).  
  
## Example  
 This example launches [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] and automatically runs the macro Open Favorite Files.  
  
```  
devenv /command "Macros.MyMacros.Module1.OpenFavoriteFiles"  
```  
  
## See Also  
 [Devenv Command Line Switches](../reference/devenv-command-line-switches.md)   
 [Visual Studio Command Aliases](../reference/visual-studio-command-aliases.md)