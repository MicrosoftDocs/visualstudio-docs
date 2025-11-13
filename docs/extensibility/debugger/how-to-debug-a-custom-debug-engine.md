---
title: 'How To: Debug a Custom Debug Engine'
description: Learn about the steps that allow you to use Visual Studio to debug your custom debug engine or a custom project type.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- debug engines, debugging
- debugging [Debugging SDK], custom debug engines
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debug a custom debug engine

A project type launches the debug engine (DE) from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDebuggableProjectCfg.DebugLaunch%2A> method. This means that the DE is launched under the control of the instance of Visual Studio controlling the project type. However, that instance of Visual Studio cannot debug the DE. What follows are the steps that allow you to debug your custom DE.

> [!NOTE]
> :     In the "Debug a custom debug engine" procedure, you must wait for the DE to start before you can attach to it. If you place a message box near the beginning of your DE that appears when the DE starts, you can attach at that point and then clear the message box to continue. That way, you can catch all DE events.

> [!WARNING]
> You must have remote debugging installed before you attempt the following procedures. See [Remote debugging](../../debugger/remote-debugging.md) for details.

## Debug a custom debug engine

1. Start *msvsmon.exe*, the Remote Debug Monitor.

2. From the **Tools** menu in *msvsmon.exe*, select **Options** to open the **Options** dialog box.

3. Select the "no authentication" option and click **OK**.

4. Start an instance of Visual Studio and open your custom DE project.

5. Start a second instance of Visual Studio and open your custom project that launches the DE (for development, this is typically in the experimental registry hive that is set up when VSIP is installed).

6. In this second instance of Visual Studio, load a source file from your custom project and start the program to be debugged. Wait a few moments to allow the DE to load, or wait until a breakpoint is hit.

7. In the first instance of Visual Studio (with your DE project), select **Attach to Process** from the **Debug** menu.

8. In the **Attach to Process** dialog box, change the **Transport** to **Remote (Native only with no authentication)**.

9. Change the **Qualifier** to the name of your machine (note: there is a history of entries, so you need to type this name only once).

10. In the **Available Processes** list, select the instance of your DE that is running and click the **Attach** button.

11. After the symbols have loaded in your DE, place breakpoints in your DE code.

12. Every time you stop and then restart the debugging process, repeat steps 6 through 10.

## Debug a custom project type

1. Start Visual Studio in the normal registry hive and load your project type project (this is, the source to your project type, not an instantiation of your project type).

2. Open the Project properties and go to the **Debug** page. For the **Command**, type the path to the Visual Studio IDE (by default, this is *[drive]*\Program Files\Microsoft Visual Studio 8\Common7\IDE\devenv.exe).

3. For the **Command Arguments**, type `/rootsuffix exp` for the experimental registry hive (created when VSIP was installed).

4. Click **OK** to accept the changes.

5. Start your project type by pressing **F5**. This launches a second instance of Visual Studio.

6. At this point, you can place breakpoints in your project type source code.

7. In the second instance of Visual Studio, load or create a new instance of your project type. During the load or creation, your breakpoints may be hit.

8. Debug your project type.

9. If you choose to debug the process of launching a DE, you can perform the steps in the "Debug a custom debug engine" procedure to attach to your DE after it is launched. This gives you three instances of Visual Studio running: one for your project type source, a second for your instantiated project type, and a third attached to your DE.

## Related content
- [Creating a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)
