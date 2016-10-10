---
title: "Mark"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1d72cef3-bb09-4bbb-8864-6ea0ab623ff9
caps.latest.revision: 8
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Mark
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
 [VSPerfCmd](../VS_IDE/VSPerfCmd.md)   
 [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)   
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)