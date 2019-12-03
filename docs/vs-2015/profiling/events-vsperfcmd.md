---
title: "Events (VSPerfCmd) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: eb139327-4783-4f2a-874c-efad377a7be4
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Events (VSPerfCmd)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VSPerfCmd.exe **Events** option controls Event Tracing for Windows (ETW) logging. ETW data is saved to an .etl file that is separate from the profiler data file. The data can be viewed in a report using the [VSPerfReport](../profiling/vsperfreport.md) /summary:etw command.  
  
 The **Events** option can be called at any time before the VSPerfCmd **Shutdown** command is called to stop profiling.  
  
## Syntax  
  
```  
VSPerfCmd.exe /events {On|Off} {Guid|ProviderName} [,Flags[,Level]  
```  
  
#### Parameters  
 **On**&#124;**Off**  
 Starts or stops collecting event data.  
  
 `Guid`  
 The GUID of the provider control.  
  
 `ProviderName`  
 The name of the provider that is registered with Windows Management Instrumentation (WMI).  
  
 `Flags`  
 A "0x"-prefixed hexadecimal flags value that is defined by the event provider.  
  
 `Level`  
 Specifies the amount of data collected. `Level` is defined by the event provider.  
  
 The **Events** option understands the following kernel keywords as provider names:  
  
 **Process**  
 Process events  
  
 **Thread**  
 Thread events  
  
 **Image**  
 Image load and unload events  
  
 **Disk**  
 Disk I/O events  
  
 **File**  
 File I/O events  
  
 **Hardfault**  
 Hard page faults  
  
 **Pagefault**  
 Soft page faults  
  
 **Network**  
 Network events  
  
 **Registry**  
 Registry access events  
  
 Note that the Kernel Provider can only be enabled. It cannot be disabled, nor can its flags be modified, until the monitor shuts down.  
  
## Remarks  
  
> [!NOTE]
> When CLR ETW events are enabled, additional startup data is also collected in the Trace View report. To exclude startup events from appearing in the report, use the following command:  
  
```  
C:\<path>VSPerfCmd -events on, \".NET Common Language Runtime\", 0x7fffffff, 5  
```  
  
> [!IMPORTANT]
> If you do not exclude the startup events, then because these events are not listed in the Managed Object Format (MOF) file, they appear as GUIDs in the report. For more information, see this page on the Microsoft Web site: [Sample Managed Object Format (MOF) File](https://go.microsoft.com/fwlink/?linkid=37118).  
  
## See Also  
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)   
 [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)   
 [Profiling Services](../profiling/command-line-profiling-of-services.md)
