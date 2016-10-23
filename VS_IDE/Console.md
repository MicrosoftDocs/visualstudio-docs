---
title: "Console"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e825ba66-1383-46ad-8712-396bc9c14036
caps.latest.revision: 7
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
# Console
The VSPerfCmd.exe **Console** option starts the specified application in a new command prompt window. **Console** can only be used with the VSPerfCmd **Launch** option. If the application is not a command-line application, **Console** has no effect.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Launch:AppName /Console  
```  
  
#### Parameters  
 None  
  
## Required Options  
 **Console** can only be specified on a command line that also contains the **Launch** option.  
  
 **Launch:** `AppName`  
 Starts the profiler and the application specified by `AppName`.  
  
## See Also  
 [VSPerfCmd](../VS_IDE/VSPerfCmd.md)   
 [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)   
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)