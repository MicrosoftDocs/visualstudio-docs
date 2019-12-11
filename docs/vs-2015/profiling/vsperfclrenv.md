---
title: "VSPerfCLREnv | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "command-line tools, VSPerfCLREnv"
  - "command line, tools"
  - "performance tools, VSPerfCLREnv"
  - "profiling tools,VSPerfCLREnv"
  - "VSPerfCLREnv tool"
ms.assetid: 4bc9dd6e-379c-4930-9bba-59a4faa93303
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# VSPerfCLREnv
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VSPerfCLREnv tool is used to set environment variables that are required to profile a .NET Framework application. It uses the following syntax:  
  
```  
VsPerfCLREnv [/option]  
```  
  
 The option that you choose depends on which of the three types of profiling you use: sampling, instrumentation, or global. A separate option is required to include tier interaction data in the profiling data. The syntax for each option is described in the following tables.  
  
> [!NOTE]
> When you are finished profiling, run **VSPerfCLREnv** with the **/off** or **/globaloff** option to delete the environment variables necessary for profiling. For more information, see VSPerfCLREnv Options to Delete Environment Settings shown here.  
  
 **VSPerfCLREnv Options for Including Tier-Interaction Data**  
  
> [!WARNING]
> Tier interaction profiling can be collected using [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], or [!INCLUDE[vs_pro_current_short](../includes/vs-pro-current-short-md.md)]. However, tier interaction profiling data can be viewed only in [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)] and [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)].  
  
 Tier interaction profiling provides additional information about ADO.NET queries in multi-tiered applications. Data is collected only for synchronous function calls. Interaction data can be added to any profiling run using any profiling method.  
  
 The **InteractionOn** and **GlobalInteractionOn** options enable the collection of tier interaction data. The interaction option must be set after setting the VSPerfCLREnv environment variable that is required to profile a application.  
  
 The following example includes tier interaction data in a profiling run that uses the sampling method:  
  
```  
VSPerfCLREnv /SampleOn  
VSPerfCLREnv /InteractionOn  
VSPerfCmd /Start:Sample /Output:MyApp.exe.vsp /Launch:MyApp.exe  
```  
  
 The following example includes tier interaction data in a profiling run for a Windows service:  
  
```  
VSPerfCLREnv /GlobalSampleOn  
VSPerfCLREnv /GlobalInteractionOn  
REM Restart the computer and start the service  
VSPerfCmd /Start:Sample /Output:MyService.exe.vsp   
VSPerfCmd /Attach:MyService.exe  
```  
  
 **VSPerfCLREnv Options for Process Instrumentation Profiling**  
  
 The following table describes VSPerfCLREnv options for instrumentation profiling:  
  
|Option|Description|  
|------------|-----------------|  
|**TraceOn**|Enables profiling using the instrumentation method. Does not enable memory allocation profiling or collecting object lifetime data.|  
|**TraceGC**|Enables memory allocation profiling using the instrumentation method. Does not enable collecting object lifetime data.|  
|**TraceGCLife**|Enables memory allocation profiling and collecting object lifetime data using the instrumentation method.|  
  
 **VSPerfCLREnv Options for Process Sampling Profiling**  
  
 The following table describes VSPerfCLREnv options for sampling profiling:  
  
|Option|Description|  
|------------|-----------------|  
|**SampleOn**|Enables profiling using the sampling method. Does not enable memory allocation profiling or collecting object lifetime data.|  
|**SampleGC**|Enables memory allocation profiling using the sampling method. Does not enable collecting object lifetime data.|  
|**SampleGCLife**|Enables memory allocation profiling using the sampling method. Also enables collecting object lifetime data.|  
|**SampleLineOff**|Disables the collection of .NET line-level profiling data.|  
  
 **VSPerfCLREnv Options for Global Profiling**  
  
 To profile a managed service such as and ASP.NET web application that is started by the operating system instead of being started by the user, use options for global profiling of the VSPerfCLREnv options. The following table describes the global versions of VSPerfCLREnv options. These options set the appropriate environment variables in the registry.  
  
|Option|Description|  
|------------|-----------------|  
|**GlobalTraceOn**|Enables global profiling using the instrumentation method. Does not collect memory allocation events or object lifetime data.|  
|**GlobalTraceGC**|Enables global memory allocation profiling using the instrumentation method. Does not enable collecting object lifetime data.|  
|**GlobalTraceGCLife**|Enables global memory allocation profiling using the instrumentation method. Also enables the collection of object lifetime data.|  
|**GlobalSampleOn**|Enables global profiling using the sampling method. Does not enable collecting memory allocation events or object lifetime data.|  
|**GlobalSampleGC**|Enables global memory allocation profiling using the sampling method. Does not enable collecting object lifetime data.|  
|**GlobalSampleGCLife**|Enables global memory allocation profiling using the sampling method. Also enables collecting object lifetime data.|  
  
 **VSPerfCLREnv Options to Delete Environment Settings**  
  
 When you are finished profiling the managed application, use one of the following options to delete the environment variables that were added by VSPerfCLREnv. The following table describes how to delete both standard and global environment variables:  
  
|Option|Description|  
|------------|-----------------|  
|**Off**|Deletes environment variables for standard .NET profiling. Use this option when the non-global VSPerfClrEnv options were used to set the profiler environment variables.|  
|**GlobalOff**|Deletes environment variables for global .NET profiling. Use this option when the application was started by the operating system and not the profiler.|  
  
## Remarks  
 These options are not required for profiling a managed application if the application is started by using the Performance Explorer in the IDE. The Performance Explorer sets all the required environment settings for you.  
  
 If the correct environment was not set during profiling, a warning is reported during analysis and the managed function names will not be properly resolved.  
  
## See Also  
 [Profiling from the Command-Line](../profiling/using-the-profiling-tools-from-the-command-line.md)
