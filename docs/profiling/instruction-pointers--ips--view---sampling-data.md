---
title: "Instruction Pointers (IPs) View - Sampling Data"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Instruction Pointers view"
ms.assetid: c7f647bb-c5a3-4708-9f9d-33c0fd6e2e96
caps.latest.revision: 11
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Instruction Pointers (IPs) View - Sampling Data
The IPs view of sampling data lists performance data for the assembly instructions that were directly executing when the samples were collected in the profiling run.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
|Column|Description|  
|------------|-----------------|  
|**Process ID**|The process ID (PID) of the profiling run.|  
|**Process Name**|The name of the process.|  
|**Module Name**|The name of the module that contains the instruction.|  
|**Module Path**|The path of the module that contains the instruction.|  
|**Source File**|The source file that contains the instruction.|  
|**Function Name**|The name of the function that contains the instruction.|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Function Address**|The starting memory address of the function in the loaded binary.|  
|**Source Line Begin**|The starting line number in the source file at which this sample was collected.|  
|**Source Line End**|The ending line number in the source file at which this sample was collected.|  
|**Source Character Begin**|The offset of the starting character in the source file line at which this sample was collected.|  
|**Source Character End**|The offset of the ending character in the source file line at which this sample was collected.|  
|**Instruction Address**|The address of the instruction in the loaded binary.|  
|**Exclusive Samples**|The total number of samples that were collected when the instruction was executing.|  
|**Exclusive Samples %**|The percentage of all samples in the profiling run that were collected when the instruction was executing.|  
  
## See Also  
 [Instruction Pointers (IPs) View - Sampling](../profiling/instruction-pointers--ips--view---.net-memory-sampling-data.md)