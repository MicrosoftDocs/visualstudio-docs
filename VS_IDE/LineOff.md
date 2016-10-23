---
title: "LineOff"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 76082063-20ef-47ae-ad64-81b43b654865
caps.latest.revision: 9
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
# LineOff
By default, the profiler collects the source code line number and line number offset data when you are using the sampling profiling method. The VSPerfCmd **LineOff** option disables line number data collection when VSPerfCmd is used to start the application. Profiling data is collected to the function level when **LineOff** is specified.  
  
 You can use **LineOff** only with the **Launch** option, and only when the profiler has been initialized to sampling by using the **Start**:**Sample** option.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Launch:AppName /LineOff [Options]  
```  
  
#### Parameters  
 None  
  
## Required Options  
 The **LineOff** option can only be used on a command line that contains the **Launch** option.  
  
 **Launch:** `AppName`  
 Starts the specified application and begins profiling with the sampling method.  
  
## Example  
 This example starts the application and the profiler, and disables line-level sampling.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe /LineOff  
```  
  
## See Also  
 [VSPerfCmd](../VS_IDE/VSPerfCmd.md)   
 [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)   
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)