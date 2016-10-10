---
title: "-Command (devenv.exe)"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
H1: /Command (devenv.exe)
ms.assetid: 13c20cd6-f09d-400a-8b7b-ecc266a32cef
caps.latest.revision: 11
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
# -Command (devenv.exe)
Executes the specified command after launching the Visual Studio integrated development environment (IDE).  
  
## Syntax  
  
```  
devenv /command CommandName  
```  
  
## Arguments  
 `CommandName`  
 Required. The complete name of a Visual Studio command or its alias, enclosed in double quotation marks. For more information about command and alias syntax, see [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md).  
  
## Remarks  
 After startup is complete, the IDE executes the named command. If you use this switch, the IDE does not display the Visual Studio Start Page on startup.  
  
 If an add-in exposes a command, you can use this switch to launch the add-in from the command line. For more information, see [How to: Control Add-Ins By Using the Add-In Manager](../Topic/How%20to:%20Control%20Add-Ins%20By%20Using%20the%20Add-In%20Manager.md).  
  
## Example  
 This example launches Visual Studio and automatically runs the macro Open Favorite Files.  
  
```  
devenv /command "Macros.MyMacros.Module1.OpenFavoriteFiles"  
```  
  
## See Also  
 [Devenv Command Line Switches](../VS_IDE/Devenv-Command-Line-Switches.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)