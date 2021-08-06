---
title: Mark | Microsoft Docs
description: Learn how the VSPerfCmd.exe Mark option inserts the specified information into the profiling data file.
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 1d72cef3-bb09-4bbb-8864-6ea0ab623ff9
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# Mark
The *VSPerfCmd.exe* **Mark** option inserts the specified information into the profiling data file. Mark can be listed in a separate VSPerfReport report or in the Mark Report view of the profiler UI. **Mark** can be used to specify start and end points in report and view filters.

 The **Mark** option must be the only option specified on the command line.

## Syntax

```cmd
VSPerfCmd.exe /Mark:MarkID,[MarkName]
```

#### Parameters
 `MarkID`
 A user-defined integer that is listed as the Mark ID in profiler views and reports. `MarkID` does not have to be unique.

 `MarkName`
 (Optional) A user-defined string that is listed as the Mark Name in profiler views and reports. If `MarkName` is not specified, the Mark Name field of the mark listing is empty. Enclose strings that contain spaces or forward slashes ("/") in quotation marks.

## Example
 This example inserts a mark with an ID of 123 and a mark name of "TestMark".

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp
VSPerfCmd.exe /Launch:TestApp.exe
VSPerfCmd.exe /Mark:123,TestMark
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
