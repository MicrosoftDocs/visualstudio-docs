---
title: "CrossSession | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: b9fcb9c3-7903-478c-9b7c-dbd94092fcba
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# CrossSession
The *VSPerfCmd.exe* **CrossSession** option enables the profiler to collect data from any console session. The **CrossSession** option must be used with the **Start** option.

 You can use the abbreviation **CS** in place of **CrossSession**.

## Syntax

```cmd
VSPerfCmd.exe /Start:Method /CrossSession [Options]
```

#### Parameters
 None

## Valid Options
 To enable profiling in another session, the **CrossSession** option must be specified with the **Start** option. **CrossSession** must also be specified in any subsequent **VSPerfCmd Attach** and **Detach** commands.

 **Start:** `Method`
 The **Start** option initializes the profiler to the specified profiling method.

 **Attach:** _PID_[**,**_PID_]
 Begins profiling the specified processes.

 **Detach**[**:**_PID_[,_PID_]]
 Stops profiling the specified processes.

## Example
 In this example, the **CrossSession** option is used to attach to an application that was started in another console session.

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp /CrossSession
VSPerfCmd.exe /Attach:12345 /CS
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
