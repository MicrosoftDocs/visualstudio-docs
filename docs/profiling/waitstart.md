---
title: WaitStart | Microsoft Docs
description: Learn that the WaitStart option causes the VSPerfCmd.exe Start sub-command to return only when the profiler has initialized or when the specified number of seconds has passed.
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 6c737177-2dfb-4150-963e-a49ac9aaa591
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# WaitStart
The WaitStart option causes the *VSPerfCmd.exe* Start sub-command to return only when the profiler has initialized or when the specified number of seconds has passed. By default, the Start command returns immediately. If the Start sub command returns without initializing the profiler, an error is returned. If the number of seconds is not specified, the Start command waits indefinitely.

 The WaitStart option is useful in batch files to insure that profiler has been initialized.

## Syntax

```cmd
VSPerfCmd.exe /Start:Method /Output:FileName[Options] /WaitStart[:Seconds]
```

#### Parameters
 `Seconds`
 The number of seconds to wait before returning from the Start sub-command.

## Required options
 The WaitStart option can only be used with the Start sub-command.

 **Output:** `filename`
 Specifies the output file name.

## Remarks

## Example
 In this batch file example, the Start command will wait for 5 seconds for the profiler to initialize.

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp /WaitStart:5
if not %errorlevel% 0 goto :error_tag
VSPerfCmd.exe /Launch:TestApp.exe
goto :end
:error_tag
@echo Could not start Profiler!
@echo Error %errorlevel%
:end
```
