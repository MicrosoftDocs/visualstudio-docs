---
title: "Profiling and Windows Vista Security | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Profiling Tools,security"
  - "performance tools, security"
ms.assetid: 842112fc-b886-4801-8cd7-a25b314b0393
caps.latest.revision: 24
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Profiling and Windows Vista Security
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Depending on the [!INCLUDE[wiprlhext](../includes/wiprlhext-md.md)] User Access Permissions settings that a computer administrator has made available, an individual user might have security permission to profile a process on that computer. The following examples illustrate possible differences among users:  
  
- Some users may access advanced profiling features when the administrator has set the driver and service to start.  
  
- Domain users may access sample profiling only.  
  
- Some users may deny access to profiling to all other users.  
  
  For more information, see the ADMIN options in [VSPerfCmd](../profiling/vsperfcmd.md).  
  
## Cross-session profiling  
 *Cross-session profiling* is the ability to profile a process that runs in a different logon session. For example, most services run in session 0, and users cannot run directly in session 0. By using the **Attach to Process** button on the Performance Explorer toolbar, or the /attach option of the VSPerfCmd command line tool, you can profile most processes in different logon sessions.  
  
 You can see a list of the processes that are available by setting the cross-process profiling visibility options. These options are available in the **Attach to process** window that is displayed when you click **Attach to Process**:  
  
- **Show processes from all users**  
  
     When this option is not selected, the list displays only those processes that are owned by the current user. When **Show processes from all users** is selected, the list displays processes from all users.  
  
- **Show processes in all sessions**  
  
     When this option is not selected, the list displays processes in the current session. When this option is selected, the list displays processes in all sessions.  
  
## See Also  
 [Overviews](../profiling/overviews-performance-tools.md)   
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [How to: Attach to a Running Process](https://msdn.microsoft.com/636d0a52-4bfd-48d2-89ad-d7b9ca4dc4f4)
