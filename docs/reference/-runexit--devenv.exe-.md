---
title: "-Runexit (devenv.exe)"
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
  - "runexit Devenv switch"
  - "Devenv, /runexit switch"
  - "/runexit Devenv switch"
ms.assetid: bfc94875-5fc0-4110-b961-d59c0b403790
caps.latest.revision: 10
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
# /Runexit (devenv.exe)
Compiles and runs the specified project or solution, and then closes the integrated development environment (IDE).  
  
## Syntax  
  
```  
devenv /runexit {SolutionName|ProjectName}  
```  
  
## Arguments  
 `SolutionName`  
 Required. The full path and name of a solution file.  
  
 `ProjectName`  
 Required. The full path and name of a project file.  
  
## Remarks  
 Compiles and runs the specified project or solution according to the settings specified for the active solution configuration. This switch minimizes the IDE while the project or solution is run, and it closes the IDE after the project or solution has completed running.  
  
-   Enclose strings that include spaces in double quotation marks.  
  
-   Summary information, including errors, can be displayed in the **Command** window, or in any log file specified with the `/out` switch.  
  
## Example  
 This example runs the solution `MySolution` in a minimized IDE using the active deployment configuration, and then closes the IDE.  
  
```  
devenv /runexit "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln"  
```  
  
## See Also  
 [Devenv Command Line Switches](../reference/devenv-command-line-switches.md)   
 [/Run (devenv.exe)](../reference/-run--devenv.exe-.md)   
 [/Build (devenv.exe)](../reference/-build--devenv.exe-.md)   
 [/Rebuild (devenv.exe)](../reference/-rebuild--devenv.exe-.md)   
 [/Out (devenv.exe)](../reference/-out--devenv.exe-.md)