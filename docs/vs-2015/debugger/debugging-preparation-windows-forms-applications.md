---
title: "Debugging Preparation: Windows Forms Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
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
caps.latest.revision: 31
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debugging Preparation: Windows Forms Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Windows Forms project template creates a Windows Forms application. Debugging this type of application in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] is straightforward. For more information, see [Creating a Windows Application Project](https://msdn.microsoft.com/b2f93fed-c635-4705-8d0e-cf079a264efa).  
  
 When you create a Windows Forms project with the project template, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] automatically creates required settings for the Debug and Release configurations. If necessary, you can change these settings. These settings can be changed in the **\<project name> Property Pages** dialog box (**My Project** in Visual Basic).  
  
 For more information, see [Recommended Property Settings](../debugger/managed-debugging-recommended-property-settings.md).  
  
 The following table displays one additional recommended property setting.  
  
### Configuration Properties in Debug tab  
  
|**Property Name**|**Setting**|  
|-----------------------|-----------------|  
|**Start Action**|-   Set to **Start project,** most of the time. Set to **Start external program** if you want to start another executable when you start debugging (usually for debugging DLLs).|  
  
 You can debug Windows Forms applications from inside [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], or by attaching to an already running application. For more information about attaching, see [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).  
  
### To debug a C#, F#, or Visual Basic Windows Forms application  
  
1. Open the project in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
2. Create breakpoints as needed.  
  
    Because Windows Forms applications are event-driven, your breakpoints will go into event handler code, or into methods called by event handler code. Typical events in which to place breakpoints include:  
  
   1. Events associated with a control, such as Click, Enter, etc.  
  
   2. Events associated with application startup and shutdown, such as Load, Activated, etc.  
  
   3. Focus and Validation Events.  
  
      For more information, see [Creating Event Handlers in Windows Forms](https://msdn.microsoft.com/library/6514e530-c6b8-489c-a8d2-eda7b7072701).  
  
3. On the **Debug** menu, click **Start**.  
  
4. Debug using the techniques discussed in [Debugger Basics](../debugger/debugger-basics.md).  
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)   
 [How to: Set Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md)   
 [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)   
 [Windows Forms](https://msdn.microsoft.com/library/627df1e9-b254-41af-bbac-9a4f02810c54)
