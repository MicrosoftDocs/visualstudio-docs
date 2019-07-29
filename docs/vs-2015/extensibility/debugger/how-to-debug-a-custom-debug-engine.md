---
title: "How To: Debug a Custom Debug Engine | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debug engines, debugging"
  - "debugging [Debugging SDK], custom debug engines"
ms.assetid: df27a8d6-3938-45ff-b47f-b684e80b38a0
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# How To: Debug a Custom Debug Engine
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A project type launches the debug engine (DE) from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDebuggableProjectCfg.DebugLaunch%2A> method. This means that the DE is launched under the control of the instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] controlling the project type. However, that instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] cannot debug the DE. What follows are the steps to allow you to debug your custom DE.  
  
> [!NOTE]
> :     In the "Debugging a Custom Debug Engine" procedure, you must wait for the DE to start before you can attach to it. If you place a message box near the beginning of your DE that appears when the DE starts, you can attach at that point and then clear the message box to continue. That way, you can catch all DE events.  
  
> [!WARNING]
> You must have remote debugging installed before you attempt the following procedures. See [Remote Debugging](../../debugger/remote-debugging.md) for details.  
  
### Debugging a Custom Debug Engine  
  
1. Start msvsmon.exe, the Remote Debug Monitor.  
  
2. From the **Tools** menu in msvsmon.exe, select **Options** to open the **Options** dialog box.  
  
3. Select the "no authentication" option and click **OK**.  
  
4. Start an instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] and open your custom DE project.  
  
5. Start a second instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] and open your custom project that launches the DE (for development, this is typically in the experimental registry hive that is set up when VSIP is installed).  
  
6. In this second instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], load a source file from your custom project and start the program to be debugged. Wait a few moments to allow the DE to load, or wait until a breakpoint is hit.  
  
7. In the first instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] (with your DE project), select **Attach to Process** from the **Debug** menu.  
  
8. In the **Attach to Process** dialog box, change the **Transport** to **Remote (Native only with no authentication)**.  
  
9. Change the **Qualifier** to the name of your machine (note: there is a history of entries, so you need to type in this name only once).  
  
10. In the **Available Processes** list, select the instance of your DE that is running and click the **Attach** button.  
  
11. After the symbols have loaded in your DE, place breakpoints in your DE code.  
  
12. Every time you stop and then restart the debugging process, repeat steps 6 through 10.  
  
### Debugging a Custom Project Type  
  
1. Start [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] in the normal registry hive and load your project type project (this is, the source to your project type, not an instantiation of your project type).  
  
2. Open the Project properties and go to the **Debug** page. For the **Command**, type the path to the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] IDE (by default, this is *[drive]*\Program Files\Microsoft [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] 8\Common7\IDE\devenv.exe).  
  
3. For the **Command Arguments**, type `/rootsuffix exp` for the experimental registry hive (created when VSIP was installed).  
  
4. Click **OK** to accept the changes.  
  
5. Start your project type by pressing F5. This will launch a second instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)].  
  
6. At this point, you can place breakpoints in your project type source code.  
  
7. In the second instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], load or create a new instance of your project type. During the load or creation, your breakpoints may be hit.  
  
8. Debug your project type.  
  
9. If you choose to debug the process of launching a DE, you can perform the steps in the "Debugging a Custom Debug Engine" procedure to attach to your DE after it is launched. This will give you three instances of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] running: one for your project type source, a second for your instantiated project type, and a third attached to your DE.  
  
## See Also  
 [Creating a Custom Debug Engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)
