---
title: "MSBuild Response Files"
ms.custom: na
ms.date: 10/07/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9f53987b-20ee-470a-ab62-fce997bb5e15
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
# MSBuild Response Files
Response (.rsp) files are text files that contain MSBuild.exe command line switches. Each switch can be on a separate line or all switches can be on one line. Comment lines are prefaced with a **#** symbol. The **@** switch is used to pass another response file to MSBuild.exe.  
  
 The auto-response file is a special .rsp file that MSBuild.exe automatically uses when building a project. This file, MSBuild.rsp, must be in the same directory as MSBuild.exe, otherwise it will not be found. You can edit this file to specify default command line switches to MSBuild.exe. For example, if you use the same logger every time you build a project, you can add the **/logger** switch to MSBuild.rsp, and MSBuild.exe will use the logger every time a project is built.  
  
## See Also  
 [MSBuild Reference](../VS_IDE/MSBuild-Reference.md)   
 [Command-Line Reference](../VS_IDE/MSBuild-Command-Line-Reference.md)