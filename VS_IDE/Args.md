---
title: "Args"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 20c35949-1f29-4282-ac75-4e6c237d71bc
caps.latest.revision: 10
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Args
The VSPerfCmd.exe **Args** option specifies a list of arguments that are passed to the target application of the **Launch** subcommand.  
  
 **Args** can only be used when **Launch** is also specified on the command line. **Args** is optional when **Launch** is specified.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Launch:AppName /Args:Arguments [Options]  
```  
  
#### Parameters  
 `Arguments`  
 A list of arguments to the target application of the **Launch** command.  
  
## Required Options  
 **Launch:** `AppName`  
 Starts the specified application and begins profiling with the sampling method.  
  
## Example  
 The following example uses the **Args** option to pass arguments to TestApp.exe.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe /Args:"123, 'Hello World'"  
```  
  
## See Also  
 [VSPerfCmd](../VS_IDE/VSPerfCmd.md)   
 [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)   
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)