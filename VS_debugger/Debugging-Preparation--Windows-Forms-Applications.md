---
title: "Debugging Preparation: Windows Forms Applications"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - VB
  - CSharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7092ee7f-8378-4def-aef8-1695bd97cf14
caps.latest.revision: 28
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
# Debugging Preparation: Windows Forms Applications
The Windows Forms project template creates a Windows Forms application. Debugging this type of application in Visual Studio is straightforward. For more information, see [Creating a Windows Application Project](assetId:///b2f93fed-c635-4705-8d0e-cf079a264efa).  
  
 When you create a Windows Forms project with the project template, Visual Studio automatically creates required settings for the Debug and Release configurations. If necessary, you can change these settings. These settings can be changed in the **<project name\> Property Pages** dialog box (**My Project** in Visual Basic).  
  
 For more information, see [Recommended Property Settings](../VS_debugger/Managed-Debugging--Recommended-Property-Settings.md).  
  
 The following table displays one additional recommended property setting.  
  
### Configuration Properties in Debug tab  
  
|**Property Name**|**Setting**|  
|-----------------------|-----------------|  
|**Start Action**|-   Set to **Start project,** most of the time. Set to **Start external program** if you want to start another executable when you start debugging (usually for debugging DLLs).|  
  
 You can debug Windows Forms applications from inside Visual Studio, or by attaching to an already running application. For more information about attaching, see [Attach to Running Processes](../VS_debugger/Attach-to-Running-Processes-with-the-Visual-Studio-Debugger.md).  
  
### To debug a C#, F#, or Visual Basic Windows Forms application  
  
1.  Open the project in Visual Studio.  
  
2.  Create breakpoints as needed.  
  
     Because Windows Forms applications are event-driven, your breakpoints will go into event handler code, or into methods called by event handler code. Typical events in which to place breakpoints include:  
  
    1.  Events associated with a control, such as Click, Enter, etc.  
  
    2.  Events associated with application startup and shutdown, such as Load, Activated, etc.  
  
    3.  Focus and Validation Events.  
  
     For more information, see [Creating Event Handlers in Windows Forms](../Topic/Creating%20Event%20Handlers%20in%20Windows%20Forms.md).  
  
3.  On the **Debug** menu, click **Start**.  
  
4.  Debug using the techniques discussed in [Debugger Basics](../VS_debugger/Debugger-Basics.md).  
  
## See Also  
 [Debugging Managed Code](../VS_debugger/Debugging-Managed-Code.md)   
 [C#, F#, and Visual Basic Project Types](../VS_debugger/Debugging-Preparation--C#--F#--and-Visual-Basic-Project-Types.md)   
 [How to: Set Debug and Release Configurations](../VS_debugger/How-to--Set-Debug-and-Release-Configurations.md)   
 [Project Settings for  C# Debug Configurations](../VS_debugger/Project-Settings-for--C#-Debug-Configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../VS_debugger/Project-Settings-for-a-Visual-Basic-Debug-Configuration.md)   
 [Attach to Running Processes](../VS_debugger/Attach-to-Running-Processes-with-the-Visual-Studio-Debugger.md)   
 [Windows Forms](../Topic/Windows%20Forms.md)