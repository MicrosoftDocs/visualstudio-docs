---
title: "-Log (devenv.exe) | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Devenv, /Log switch"
  - "Log switch [devenv.exe]"
  - "/Log Devenv switch"
ms.assetid: ae23c4ae-2376-4fe3-b8d2-81d34e61c8ba
caps.latest.revision: 13
author: gewarren
ms.author: gewarren
manager: "ghogen"
---
# /Log (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [-Log (devenv.exe)](https://docs.microsoft.com/visualstudio/ide/reference/log-devenv-exe).  
  
  
Logs all activity to the log file for troubleshooting. This file appears after you've called `devenv /log` at least once. By default, the log file is:  
  
 *%APPDATA%*\Microsoft\VisualStudio\\*Version*\ActivityLog.xml  
  
 where *Version* is the Visual Studio version. However, you may specify a different path and file name.  
  
## Syntax  
  
```  
Devenv /log Path\NameOfLogFile  
```  
  
## Remarks  
 This switch must appear at the end of the command line, after all other switches.  
  
 The log is written for all instances of Visual Studio that you've invoked with the /log switch. It doesn't log instances of Visual Studio that you've invoked without the switch.  
  
## See Also  
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)



