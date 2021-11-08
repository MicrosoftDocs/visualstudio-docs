---
title: "User (VSPerfCmd) | Microsoft Docs"
description: Learn how the User option specifies the domain and user name of the account that owns the profiled process.
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: ee1a478e-374d-4f30-ae28-d260b9d4723a
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# User (VSPerfCmd)
The **User** option specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged on user. The process owner is listed in the User Name column on the **Processes** tab of Windows Task Manager.

 The **User** option can only be specified on a command line that also contains the **Start** option.

## Syntax

```cmd
VSPerfCmd.exe /Start:Method /Output:FileName /User:[Domain\]UserName [Options]
```

#### Parameters
 `Domain`
 The name of the user's domain.

 `UserName`
 The name of the user.

## Required options
 The **User** option can only be used with the **Start** option.

 **Start:** `Method`
 Initializes the profiler to the specified profiling method.

## Example
 The following example demonstrates the use of the **User** option.

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp /User:SYSTEM
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
