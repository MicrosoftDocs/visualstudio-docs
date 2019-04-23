---
title: "Lines View - Sampling Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Lines view"
ms.assetid: 46497249-c797-42c5-a02c-3e4bb3b4ee60
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Lines View - Sampling Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Lines view of sampling data lists performance data for the statements that were executing when the samples were collected in the profiling run.  
  
> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
 In a source file, a statement can span more than one line in a source file, and a single line can include more than one statement. A statement is identified by the following:  
  
- The source file that contains the function statement.  
  
- The function that contains the statement.  
  
- The source line at which the statement begins.  
  
- The character in the source line at which the statement starts.  
  
- The source line at which the statement ends.  
  
- The character in the source line at which the statement ends.  
  
  The Line Name column provides a sortable concatenation of the identifier data.  
  
  By definition, a statement does not call other functions. Therefore, only exclusive values are listed.  
  
|Column|Description|  
|------------|-----------------|  
|**Process ID**|The process ID (PID) of the profiling run.|  
|**Process Name**|The name of the process.|  
|**Module Name**|The name of the module that contains the function line.|  
|**Module Path**|The path of the module that contains the function line.|  
|**Source File**|The source file that contains the function line.|  
|**Function Name**|The name of the function.|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Function Address**|The starting address of the function.|  
|**Source Line Begin**|The starting line number in the source file at which this sample was collected.|  
|**Source Line End**|The ending line number in the source file at which this sample was collected.|  
|**Source Character Begin**|The offset of the starting character in the source file line at which this sample was collected.|  
|**Source Character End**|The offset of the ending character in the source file line at which this sample was collected.|  
|**Line Name**|A profiler-generated identifier of the line with the following syntax:`Source File`**;[**`Line Number Start`**,**`Character Start`**]->;[**`Line Number End`**,**`Character End`**]**|  
|**Exclusive Samples**|The total number of samples that were collected when the function line was executing.|  
|**Exclusive Samples %**|The percentage of all samples in the profiling run that were collected when the function line was executing.|  
  
## See Also  
 [Lines View - Sampling](../profiling/lines-view-dotnet-memory-sampling-data.md)
