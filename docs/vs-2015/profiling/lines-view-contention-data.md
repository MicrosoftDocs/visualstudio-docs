---
title: "Lines View - Contention Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Lines view"
ms.assetid: 859b02d2-eddf-4ad3-95de-0df67ee2ab03
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Lines View - Contention Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Lines view of contention data lists performance data for the statements that were executing when the samples were collected in the profiling run. In a source file, a statement can span more than one line in a source file, and a single line can include more than one statement.  
  
 A statement is identified by the following data:  
  
- The source file that contains the function statement.  
  
- The function that contains the statement.  
  
- The source line at which the statement starts.  
  
- The character in the source line at which the statement starts.  
  
- The source line at which the statement ends.  
  
- The character in the source line at which the statement ends.  
  
  The Line Name column provides a sortable concatenation of the identifier data.  
  
  The following table describes the columns of the Lines View report.  
  
|Column|Description|  
|------------|-----------------|  
|**Exclusive Blocked Time**|The amount of time during which this statement was blocked from executing code in the statement because of a contention event. Blocked time in functions that the statement called is not included.|  
|**Exclusive Blocked Time %**|The percentage of all blocked time in the process that was exclusive blocked time of the statement.|  
|**Exclusive Contentions**|The number of times that this statement was blocked from executing code in the statement because of a contention event. Contention events in functions that the statement called are not included.|  
|**Exclusive Contentions %**|The percentage of all contention events in the process that were exclusive contentions of this statement.|  
|**Function Address**|The address of the function that contains this statement.|  
|**Function Name**|The fully qualified name of the function that contains this statement.|  
|**Inclusive Blocked Time**|The blocked time in this statement and functions called in the statement.|  
|**Inclusive Blocked Time %**|The percentage of all blocked time in the process that was inclusive blocked time of the statement.|  
|**Inclusive Contentions**|The number of times that this statement and functions that were called in the statement were blocked from executing.|  
|**Inclusive Contentions %**|The percentage of all contention events in the process that were inclusive contentions of this statement.|  
|**Line Name**|A profiler-generated identifier of the line. The identifier uses the following syntax:`SourceFile`**;[**`LineNumberStart`**,**`CharacterStart`**]->;[**`LineNumberEnd`**,**`CharacterEnd`**]**|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Module Name**|The name of the module that contains the statement.|  
|**Module Path**|The path of the module that contains the statement.|  
|**Process ID**|The process ID (PID) of the profiled process.|  
|**Process Name**|The name of the process.|  
|**Source Character Begin**|The offset of the starting character in the source file line at which this statement starts.|  
|**Source Character End**|The offset of the starting character in the source file line at which this statement ends.|  
|**Source File**|The name of the source file that contains the function statement.|  
|**Source Line Begin**|The line number in the source file at which the statement starts.|  
|**Source Line End**|The line number in the source file at which the statement ends.|  
  
## See Also  
 [How to: Customize Report View Columns](../profiling/how-to-customize-report-view-columns.md)   
 [Lines View](../profiling/lines-view.md)   
 [Lines View - Sampling](../profiling/lines-view-dotnet-memory-sampling-data.md)   
 [Lines View](../profiling/lines-view-sampling-data.md)
