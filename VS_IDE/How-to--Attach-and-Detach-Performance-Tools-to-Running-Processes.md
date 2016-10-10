---
title: "How to: Attach and Detach Performance Tools to Running Processes"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 56a99c39-e7f6-4f48-ae56-04ab8e022bf7
caps.latest.revision: 30
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# How to: Attach and Detach Performance Tools to Running Processes
The profiler can be used to attach to or detach from a running process to make sampling and gathering performance data easier. You can use this method to profile a process when you want to avoid gathering data about application load time, or to monitor the performance of a process after it reaches a specific state.  
  
> [!NOTE]
>  The following steps apply to attaching and detaching processes from within the Visual Studio integrated development environmnent (IDE). For information about how to use command line tools, see [Profiling from the Command-Line](../VS_IDE/Using-the-Profiling-Tools-From-the-Command-Line.md). For information about how to profile services, see [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md).  
  
 The processes that are available to profile depend on the User Access Permissions that are set by an administrator of the computer. A User account may, for example, have permission for any of the following:  
  
-   Advanced profiling features, when the administrator has set the driver and service to start.  
  
-   Sample profiling only (domain users).  
  
-   Deny access to profiling to everybody.  
  
 For more information, see [Profiling and Windows Vista Security](../VS_IDE/Profiling-and-Windows-Vista-Security.md) and the ADMIN options in [VSPerfCmd](../VS_IDE/VSPerfCmd.md).  
  
### To attach to a running process  
  
1.  On the **Analyze** menu, point to **Profiler** and then click **Attach/Detach**.  
  
     \- or -  
  
     In **Performance Explorer**, right-click the performance session, and then click **Attach/Detach**.  
  
     The **Attach Profiler to Process** dialog box appears.  
  
2.  Click the name of the process that you want to attach to.  
  
3.  Click **Attach**.  
  
### To detach from a running process  
  
1.  On the **Analyze** menu, point to **Profiler** and then click **Attach/Detach**.  
  
     \- or -  
  
     In **Performance Explorer**, right-click the performance session, and then click **Attach/Detach**.  
  
     The **Attach Profiler to Process** dialog box appears.  
  
2.  Click the image name from which you want to detach.  
  
3.  Click **Detach**.  
  
## See Also  
 [Controlling Data Collection](../VS_IDE/Controlling-Data-Collection.md)   
 [Performance Session Overview](../VS_IDE/Performance-Session-Overview.md)   
 [How to: Start and End Performance Data Collection](../VS_IDE/How-to--Start-and-End-Performance-Data-Collection.md)   
 [Profiling and Windows Vista Security](../VS_IDE/Profiling-and-Windows-Vista-Security.md)   
 [VSPerfCmd](../VS_IDE/VSPerfCmd.md)