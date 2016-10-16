---
title: "TargetCLR"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f9732480-287f-40f1-a4ff-b112e143b940
caps.latest.revision: 11
ms.author: "mikejo"
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
# TargetCLR
The **TargetCLR** option specifies the version of the common language run-time (CLR) to profile when more than one version of the CLR is loaded in an application.  
  
 By default, the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Profiling Tools target the first version of the CLR that is loaded by the application.  
  
## Syntax  
  
```  
VSPerfCmd.exe {/Launch:AppName | /Attach:PID} /TargetCLR[:ClrVersion] [Options]   
```  
  
#### Parameters  
 `ClrVersion`  
 The version number of the CLR. Use the version format **vN.N.NNNNN**.  
  
## Required Options  
 The **TargetCLR** option can only be used with the **Launch** or **Attach** options.  
  
 **Launch:** `AppName`  
 Starts the specified application and starts to profile.  
  
 **Attach:** `PID`  
 Starts to profile the specified process.  
  
## Example  
 In this example, the TargetCLR option is used to make sure that CLR version 4.0.11003 is profiled.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe /TargetCLR:v4.0.11003  
```