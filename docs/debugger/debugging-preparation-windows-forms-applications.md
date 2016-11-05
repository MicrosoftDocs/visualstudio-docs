---
title: "Debugging Preparation: Windows Forms Applications | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "debugging Windows applications"
  - "Windows applications, debugging"
  - "debugging [Visual Studio], Windows applications"
  - "debugging [J#], Windows applications"
  - "debugging [C#], Windows applications"
  - "debugging [Visual Basic], Windows applications"
ms.assetid: 7092ee7f-8378-4def-aef8-1695bd97cf14
caps.latest.revision: 28
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Debugging Preparation: Windows Forms Applications
The Windows Forms project template creates a Windows Forms application. Debugging this type of application in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] is straightforward. For more information, see [Creating a Windows Application Project](http://msdn.microsoft.com/en-us/b2f93fed-c635-4705-8d0e-cf079a264efa).  
  
 When you create a Windows Forms project with the project template, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] automatically creates required settings for the Debug and Release configurations. If necessary, you can change these settings. These settings can be changed in the **\<project name> Property Pages** dialog box (**My Project** in Visual Basic).  
  
 For more information, see [Recommended Property Settings](../debugger/managed-debugging-recommended-property-settings.md).  
  
 The following table displays one additional recommended property setting.  
  
### Configuration Properties in Debug tab  
  
|**Property Name**|**Setting**|  
|-----------------------|-----------------|  
|**Start Action**|-   Set to **Start project,** most of the time. Set to **Start external program** if you want to start another executable when you start debugging (usually for debugging DLLs).|  
  
 You can debug Windows Forms applications from inside [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], or by attaching to an already running application. For more information about attaching, see [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).  
  
### To debug a C#, F#, or Visual Basic Windows Forms application  
  
1.  Open the project in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
2.  Create breakpoints as needed.  
  
     Because Windows Forms applications are event-driven, your breakpoints will go into event handler code, or into methods called by event handler code. Typical events in which to place breakpoints include:  
  
    1.  Events associated with a control, such as Click, Enter, etc.  
  
    2.  Events associated with application startup and shutdown, such as Load, Activated, etc.  
  
    3.  Focus and Validation Events.  
  
     For more information, see [Creating Event Handlers in Windows Forms](../Topic/Creating%20Event%20Handlers%20in%20Windows%20Forms.md).  
  
3.  On the **Debug** menu, click **Start**.  
  
4.  Debug using the techniques discussed in [Debugger Basics](../debugger/debugger-basics.md).  
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)   
 [How to: Set Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md)   
 [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)   
 [Windows Forms](../Topic/Windows%20Forms.md)