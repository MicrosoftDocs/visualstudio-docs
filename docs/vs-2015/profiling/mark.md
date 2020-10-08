---
title: "Mark | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 1d72cef3-bb09-4bbb-8864-6ea0ab623ff9
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Mark
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VSPerfCmd.exe **Mark** option inserts the specified information into the profiling data file. Mark can be listed in a separate VSPerfReport report or in the Mark Report view of the profiler UI. **Mark** can be used to specify start and end points in report and view filters.  
  
 The **Mark** option must be the only option specified on the command line.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Mark:MarkID,[MarkName]  
```  
  
#### Parameters  
 `MarkID`  
 A user-defined integer that is listed as the Mark ID in profiler views and reports. `MarkID` does not have to be unique.  
  
 `MarkName`  
 (Optional) A user-defined string that is listed as the Mark Name in profiler views and reports. If `MarkName` is not specified, the Mark Name field of the mark listing is empty. Enclose strings that contain spaces or forward slashes ("/") in quotation marks.  
  
## Example  
 This example inserts a mark with an ID of 123 and a mark name of "TestMark".  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
VSPerfCmd.exe /Launch:TestApp.exe  
VSPerfCmd.exe /Mark:123,TestMark  
```  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
