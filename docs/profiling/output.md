---
title: "Output | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 5e286e61-4548-42cf-a635-e608c5edbe2b
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Output
The **Output** option specifies the name of the profiling data file for the performance session. **Output** must be used with the **Start** option.

## Syntax

```cmd
VSPerfCmd.exe /Start:Method /Output:FileName [Options]
```

#### Parameters
 `FileName`
 The name of the data file. Full and partial paths are accepted. If a path is not specified, the file is created in the current directory.

## Required options
 The **Output** option must be used with the **Start** option.

 **Start:** `Method`
 Specifies the output file name.

## Example
 In the following example, the profiling data file is created in the current directory.

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
