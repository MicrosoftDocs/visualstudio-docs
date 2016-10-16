---
title: "Status"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ba656fa4-ef9d-4d8c-a3b6-739c3b5d23ae
caps.latest.revision: 7
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Status
The VSPerfCmd.exe **Status** option displays information about the state of the profiler and any processes that are currently being profiled.  
  
 The **Status** option must be the only option specified on the command line. The profiler must be initialized with the VSPerfCmd.exe **Start** option before any status can be displayed.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Status  
```  
  
#### Parameters  
 None  
  
## Remarks  
 The **Status** option displays the following state information for the profiler.  
  
 **Output File Name**  
 The path and file name of the current profiler data file.  
  
 **Collection Mode**  
 SAMPLE or TRACE  
  
 **Maximum Processes**  
 The maximum number of processes that can be profiled at one time and the number of currently active processes.  
  
 **Maximum Threads**  
 The maximum number of threads that can be profiled at one time.  
  
 **Number of Buffers**  
 The number of memory buffers dedicated to writing profiling data.  
  
 **Size of Buffers**  
 The size in bytes of a memory buffer.  
  
 The **Status** option displays the following state information for each process that is currently being profiled.  
  
 **Process**  
 The name of the profiled process.  
  
 **Process ID**  
 The system identifier of the process.  
  
 **Num Threads**  
 The number of threads currently executing.  
  
 **Start/Stop Count**  
 The primary internal profiler count to control data collection for this process. The count must be equal to one to collect data. The Start/Stop count can be manipulated by the profiler APIs and the VSPerfCmd options **GlobalOn**, **GlobalOff**, **ProcessOn**, **ProcessOff**, **ThreadOn**, and **ThreadOff**.  
  
 **Suspend/Resume Count**  
 The secondary internal profiler count to control data collection for this process. The count must be less than or equal to zero to collect data. The **Suspend/Resume** count can be manipulated only by the profiler APIs.  
  
 **Users with access rights to monitor**  
 Lists the names of users who have access to the profiler. Additional users can be granted access by using the VSPerfCmd.exe **Admin** option  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-asp.net-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)