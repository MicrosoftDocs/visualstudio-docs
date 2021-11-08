---
title: Console | Microsoft Docs
description: Use the Console option of VSPerfCmd.exe to start the specified application in a new command prompt window. You must use it with the Launch option.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: e825ba66-1383-46ad-8712-396bc9c14036
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# Console
The VSPerfCmd.exe **Console** option starts the specified application in a new command prompt window. **Console** can only be used with the VSPerfCmd **Launch** option. If the application is not a command-line application, **Console** has no effect.

## Syntax

```cmd
VSPerfCmd.exe /Launch:AppName /Console
```

#### Parameters
 None

## Required Options
 **Console** can only be specified on a command line that also contains the **Launch** option.

 **Launch:** `AppName`
 Starts the profiler and the application specified by `AppName`.

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
