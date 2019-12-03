---
title: "Args | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 20c35949-1f29-4282-ac75-4e6c237d71bc
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Args
The VSPerfCmd.exe **Args** option specifies a list of arguments that are passed to the target application of the **Launch** subcommand.

 **Args** can only be used when **Launch** is also specified on the command line. **Args** is optional when **Launch** is specified.

## Syntax

```cmd
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

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp
VSPerfCmd.exe /Launch:TestApp.exe /Args:"123, 'Hello World'"
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profiling stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profiling ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profiling services](../profiling/command-line-profiling-of-services.md)
