---
title: "-DebugExe (devenv.exe)"
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
  - "Devenv, /DebugExe switch"
  - "DebugExe switch"
  - "/DebugExe [devenv.exe]"
ms.assetid: cd700006-1648-418f-924b-4b1e5c1412ab
caps.latest.revision: 4
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
# /DebugExe (devenv.exe)
Opens the specified executable file to be debugged.  
  
## Syntax  
  
```  
Devenv /debugexe ExecutableFile  
```  
  
## Arguments  
 `ExecutableFile`  
 Required. The path and file name of an .exe file.  
  
 If the .exe file is not found or does not exist, no warning or error is displayed and [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] starts normally.  
  
## Remarks  
 Any strings following the `ExecutableFile` parameter are passed to that file as arguments.  
  
## Example  
 The following example opens the file `MyApplication.exe` for debugging.  
  
```  
Devenv.exe /debugexe MyApplication.exe  
```  
  
## See Also  
 [Devenv Command Line Switches](../reference/devenv-command-line-switches.md)