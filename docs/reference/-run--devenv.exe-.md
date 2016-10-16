---
title: "-Run (devenv.exe)"
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
  - "/run Devenv"
  - "run Devenv switch"
  - "applications [Visual Studio], running"
  - "/r Devenv switch"
  - "Devenv, /run switch"
  - "r Devenv switch (/r)"
ms.assetid: b1f22f9d-39a5-4918-8a2a-4b5c1e872665
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
# /Run (devenv.exe)
Compiles and runs the specified project or solution.  
  
## Syntax  
  
```  
devenv {/run|/r} {SolutionName|ProjectName}  
```  
  
## Arguments  
 `SolutionName`  
 Required. The full path and name of a solution file.  
  
 `ProjectName`  
 Required. The full path and name of a project file.  
  
## Remarks  
 Compiles and runs the specified project or solution according to the settings specified for the active solution configuration. This switch launches the integrated development environment (IDE) and leaves it active after the project or solution has completed running.  
  
-   Enclose strings that include spaces in double quotation marks.  
  
-   Summary information, including errors, can be displayed in the **Command** window, or in any log file specified with the `/out` switch.  
  
## Example  
 This example runs the solution `MySolution` using the active deployment configuration.  
  
```  
devenv /run "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln"  
```  
  
## See Also  
 [Devenv Command Line Switches](../reference/devenv-command-line-switches.md)   
 [/Runexit (devenv.exe)](../reference/-runexit--devenv.exe-.md)   
 [/Build (devenv.exe)](../reference/-build--devenv.exe-.md)   
 [/Rebuild (devenv.exe)](../reference/-rebuild--devenv.exe-.md)   
 [/Out (devenv.exe)](../reference/-out--devenv.exe-.md)