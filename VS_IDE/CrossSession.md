---
title: "CrossSession"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b9fcb9c3-7903-478c-9b7c-dbd94092fcba
caps.latest.revision: 10
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
# CrossSession
The VSPerfCmd.exe **CrossSession** option enables the profiler to collect data from any console session. The **CrossSession** option must be used with the **Start** option.  
  
 You can use the abbreviation **CS** in place of **CrossSession**.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Start:Method /CrossSession [Options]  
```  
  
#### Parameters  
 None  
  
## Valid Options  
 To enable profiling in another session, the **CrossSession** option must be specified with the **Start** option. **CrossSession** must also be specified in any subsequent **VSPerfCmd Attach** and **Detach** commands.  
  
 **Start:** `Method`  
 The **Start** option initializes the profiler to the specified profiling method.  
  
 **Attach:** *PID*[**,***PID*]  
 Begins profiling the specified processes.  
  
 **Detach**[**:***PID*[,*PID*]]  
 Stops profiling the specified processes.  
  
## Example  
 In this example, the **CrossSession** option is used to attach to an application that was started in another console session.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp /CrossSession  
VSPerfCmd.exe /Attach:12345 /CS  
```  
  
## See Also  
 [VSPerfCmd](../VS_IDE/VSPerfCmd.md)   
 [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)   
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)