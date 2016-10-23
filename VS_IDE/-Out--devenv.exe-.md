---
title: "-Out (devenv.exe)"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
H1: /Out (devenv.exe)
ms.assetid: 9002d8c2-36d4-451c-b489-8f01932f31f7
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
# -Out (devenv.exe)
Specifies a file to store and display errors when you run, build, rebuild, or deploy a solution.  
  
## Syntax  
  
```  
devenv /out FileName  
```  
  
## Arguments  
 `FileName`  
 Required. The path and name of the file to receive errors when you build an executable.  
  
## Remarks  
 If a file name that does not exist is specified, the file is created automatically. If the file already exists, the results are appended to the existing contents of the file.  
  
 Command line build errors are displayed in the **Command** window and the Solution Builder view of the **Output** window. This option is useful if you are running unattended builds and need to see the results.  
  
## Example  
 This example runs `MySolution` and writes errors to the file `MyErrorLog.txt`.  
  
```  
devenv /run "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /out "C:\MyErrorLog.txt"  
```  
  
## See Also  
 [Devenv Command Line Switches](../VS_IDE/Devenv-Command-Line-Switches.md)   
 [/Run (devenv.exe)](../VS_IDE/-Run--devenv.exe-.md)   
 [/Build (devenv.exe)](../VS_IDE/-Build--devenv.exe-.md)   
 [/Rebuild (devenv.exe)](../VS_IDE/-Rebuild--devenv.exe-.md)   
 [/Deploy (devenv.exe)](../VS_IDE/-Deploy--devenv.exe-.md)