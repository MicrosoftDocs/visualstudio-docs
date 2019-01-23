---
title: "TargetCLR | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: f9732480-287f-40f1-a4ff-b112e143b940
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# TargetCLR
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **TargetCLR** option specifies the version of the common language run-time (CLR) to profile when more than one version of the CLR is loaded in an application.  
  
 By default, the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools target the first version of the CLR that is loaded by the application.  
  
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
