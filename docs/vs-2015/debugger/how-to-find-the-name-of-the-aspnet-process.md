---
title: "How to: Find the Name of the ASP.NET Process | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ASP.NET debugging, ASP.NET process"
  - "ASP.NET process"
ms.assetid: 931a7597-b0f0-4a28-931d-46e63344435f
caps.latest.revision: 32
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Find the Name of the ASP.NET Process
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To attach to a running [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] application, you have to know the name of the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] process:  
  
- If you are running IIS 6.0 or IIS 7.0, the name is w3wp.exe.  
  
- If you are running an earlier version of IIS, the name is aspnet_wp.exe.  
  
  For applications built by using [!INCLUDE[vsprvslong](../includes/vsprvslong-md.md)] or later versions, the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] code can reside on the file system and run under the test server WebDev.WebServer.exe. In that case, you must attach to WebDev.WebServer.exe instead of the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] process. This scenario applies only to local debugging.  
  
  Older ASP applications run inside the IIS process inetinfo.exe when they are running in-process.  
  
> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To determine whether project code resides on the file system or IIS  
  
1. In Visual Studio, open **Solution Explorer** if it is not already open.  
  
2. Select the top node that contains the name of the application.  
  
3. If the **Properties** window title contains a file path, the application code resides on the file system.  
  
     Otherwise, the **Properties** window title will contain the name of the Web site.  
  
### To determine the IIS version under which the application is running  
  
1. Find **Administrative Tools** and run it. Depending on your operating system, this might be an icon inside **Control Panel**, or a menu entry that appears when you click **Start**.  
  
     In Windows XP, **Control Panel** can be in Category View or Classic View. In Category View, you have to click **Switch to Classic View** or **Performance and Maintenance** to see the **Administrative Tools** icon.  
  
2. From **Administrative Tools**, run Internet Information Services. An MMC dialog box appears.  
  
3. If there is more than one computer listed in the left pane, select the one on which the application code resides.  
  
4. The IIS version is in the **Version** column of the right pane.  
  
## See Also  
 [Prerequistes for Remote Debugging Web Applications](../debugger/prerequistes-for-remote-debugging-web-applications.md)   
 [System Requirements](../debugger/aspnet-debugging-system-requirements.md)   
 [Preparing to Debug ASP.NET](../debugger/preparing-to-debug-aspnet.md)   
 [Debugging Web Applications and Script](../debugger/debugging-web-applications-and-script.md)
