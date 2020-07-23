---
title: "How to: Set Performance Data File Name Options | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: d7a8d6b9-ab23-46fb-98ed-774781157860
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Set Performance Data File Name Options
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By default, you save a profiling data (.vsp) file by using the following syntax:  
  
 *Path\VSP-File\YYMMDD(N)* **.vsp**  
  
 You can change any naming parameter on the General page of the properties dialog box for the performance session.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
|Syntax Element|Description|  
|-|-|  
|*Path*|The directory that contains the report. The default location is the solution folder or the default location for the user's projects and solutions.|  
|*VSP-File*|The name of the profiling data file. The default name is the name of the solution or executable that is profiled.|  
|*YYMMDD*|A date stamp that shows the year, month and day that the profiling data was collected.|  
|*(N)*|If more than one profiling data file exists, an incremented number is added to the file name between parentheses.|  
  
### To change the naming syntax of the profiling data files of a performance session  
  
1. In **Performance Explorer**, right-click the name of the performance session, and then click **Properties**.  
  
2. Click **General**.  
  
3. Under **Report**, change any of the following settings:  
  
    |Name|Description|  
    |-|-|  
    |**Report location**|Specify a directory to store the profiling data files.|  
    |**Report name**|Specify a base name for the files.|  
    |**Automatically add new reports to the session**|Select the check box to automatically add the data file to the performance session.|  
    |**Append an incrementing number to generated reports**|Select the check box to add an incrementing number to the file name when more than one file of the same name exists. Clear the check box to overwrite an existing file.|  
    |**Use a timestamp for the number**|Select the check box to add a datestamp to the file name.|
