---
title: "GC (VSPerfCmd) | Microsoft Docs"
description: Review the GC option in the VSPerfCmd.exe tool. The GC option enables the collection of .NET Framework memory allocation and object lifetime data.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 7c81e88b-a748-4cf5-a7a1-3429608e1b54
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# GC (VSPerfCmd)
The **GC** option enables the collection of .NET Framework memory allocation and object lifetime data. The **GC** option can only be used with the sampling profiling method and only with the **Launch** option.

 When you are using the **GC** option, the VSPerfClrEnv **/sampleon** command is not required.

 If no parameters are specified, or if the **Allocation** parameter is specified, only .NET Framework memory allocation data is collected. If the **Lifetime** parameter is specified, both .NET Framework memory allocation and .NET Framework object lifetime data is collected.

## Syntax

```cmd
VSPerfCmd.exe /Launch:AppName /GC[:{Allocation|Lifetime}] [Options]
```

#### Parameters
 **Allocation**
 Default. Collects .NET Framework memory allocation data.

 **Lifetime**
 Collects both .NET Framework memory allocation data and .NET Framework object lifetime data.

## Required Options
 The **GC** option can only be used with the **Launch** option.

 **Launch:** `AppName`
 Starts the specified application and begins profiling with the sampling method.

## Example
 The following example launches an application and collects .NET Framework memory allocation data.

```cmd
VSPerfCmd.exe /Launch:TestApp.exe /gc
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
