---
title: "WaitStart | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 6c737177-2dfb-4150-963e-a49ac9aaa591
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# WaitStart
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The WaitStart option causes the VSPerfCmd.exe Start sub-command to return only when the profiler has initialized or when the specified number of seconds has passed. By default, the Start command returns immediately. If the Start sub command returns without initializing the profiler, an error is returned. If the number of seconds is not specified, the Start command waits indefinitely.  
  
 The WaitStart option is useful in batch files to insure that profiler has been initialized.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Start:Method /Output:FileName[Options] /StartWait[:Seconds]  
```  
  
#### Parameters  
 `Seconds`  
 The number of seconds to wait before returning from the Start sub-command.  
  
## Required Options  
 The WaitStart option can only be used with the Start sub-command.  
  
 **Output:** `filename`  
 Specifies the output file name.  
  
## Remarks  
  
## Example  
 In this batch file example, the Start command will wait for 5 seconds for the profiler to initialize.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp /WaitStart:5  
if not %errorlevel% 0 goto :error_tag  
VSPerfCmd.exe /Launch:TestApp.exe  
goto :end  
:error_tag  
@echo Could not start Profiler!  
@echo Error %errorlevel%  
:end  
```
