---
title: "Troubleshooting and FAQ for snapshot debugging | Microsoft Docs"
ms.date: "11/07/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "debugger"
ms.assetid: 511a0697-c68a-4988-9e29-8d0166ca044a
caps.latest.revision: 1
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
---
# Troubleshooting, FAQ, and known issues for snapshot debugging in Visual Studio

If the steps described in this topic do not resolve your issue, contact snaphelp@microsoft.com.
 
## Issue: Snappoint does not turn on

If you see a warning icon ![Snappoint warning icon](../debugger/media/snapshot-troubleshooting-snappoint-warning-icon.png "Snappoint warning icon") with your snappoint instead of the regular snappoint icon, then the snappoint is not turned on.

![Snappoint does not turn on](../debugger/media/snapshot-troubleshooting-dont-turn-on.png "Snappoint does not turn on")

Take these steps:

1. Make sure you have the same version of source code that was used to build and deploy your app. 
2. Make sure you are loading the correct symbols for your deployment. The Snapshot Debugger can automatically download and use symbols.
 
## Issue: Symbols do not load when I open a Snapshot

If you see following window, symbols did not load.

![Symbols do not load](../debugger/media/snapshot-troubleshooting-symbols-wont-load.png "Symbols do not load")

Take these steps:

- Click the **Change Symbol Settings…** link on this page. In the **Debugging > Symbol** settings, add a symbol cache directory. Restart snapshot debugging after the symbol path has been set.

    The symbols, or .pdb files, available in your project must match your App Service deployment. Most deployments (deployment through Visual Studio, CI/CD with VSTS or Kudu, etc.) will publish your symbol files along to your App Service. Setting the symbol cache directory enables Visual Studio to use these symbols.

    ![Symbol settings](../debugger/media/snapshot-troubleshooting-symbol-settings.png "Symbol settings")

- Alternatively, if your organization uses a symbol server or drops symbols in a different path, use the symbol settings to load the correct symbols for your deployment.
 
## Issue: I cannot see the "Attach Snapshot Debugger" option in the Cloud Explorer

Take these steps:

- Make sure the Snapshot Debugger component is installed. Open the Visual Studio Installer, and check the **Snapshot Debugger** component in the Azure workload.
- Make sure your app is supported. Currently, only ASP.NET (4.6.1+) and ASP.NET Core (2.0+) apps deployed to Azure App Services are supported.
 
## Issue: I only see Throttled Snapshots in the Diagnostic Tools

![Throttled snappoint](../debugger/media/snapshot-troubleshooting-throttled-snapshots.png "Throttled snappoint")

Take these steps:

- Snapshots take up very little memory but do have a commit charge. If the Snapshot Debugger detects your server is under heavy memory load, it will not take snapshots. You can delete already captured snapshots by stopping the Snapshot Debugger session and trying again.

## Frequently Asked Questions

#### What is the performance cost of taking a snapshot? 
When the Snapshot Debugger captures a snapshot of your app, it is forking the app's process and suspending the forked copy. When you debug a snapshot, you are debugging against the forked copy of the process. This process takes only 10-20 milliseconds but does not copy the full heap of the app; instead, it copies only the page table and sets pages to copy on write. If some of your app's objects on the heap change, their respective pages are then copied. Each snapshot therefore has a very small in-memory cost (on the order of hundreds of kilobytes for most apps). 

#### What happens if I have a scaled-out Azure App Service (multiple instances of my app)?
When you have multiple instances of your app, snappoints get applied to every single instance. Only the first snappoint to hit with the conditions specified creates a snapshot. If you have multiple snappoints, subsequent snapshots come from the same instance that created the first snapshot. Logpoints sent to the output window will only show messages from one instance, while logpoints sent to application logs send messages from every instance. 

#### How does the Snapshot Debugger load symbols?
The Snapshot Debugger requires that you have the matching symbols for your application either locally or deployed to your Azure App Service (embedded PDBs are currently not supported). The Snapshot Debugger automatically downloads symbols from your Azure App Service. As of Visual Studio 2017 (version 15.2), deploying to Azure App Service also deploys your app's symbols.

#### Does the Snapshot Debugger work against release builds of my application?
Yes - the Snapshot Debugger is intended to work against release builds. When a snappoint is placed in a function, the function is recompiled back to a debug version, making it debuggable. When you stop the Snapshot Debugger, the functions are returned to their release build. 

#### Can logpoints cause side effects in my production application?
No - any log messages you add to your app are evaluated virtually. They cannot cause any side effects in your application. However, some native properties may not be accessible with logpoints. 

#### Does the Snapshot Debugger work if my server is under load?
Yes, snapshot debugging can work for servers under load. The Snapshot Debugger throttles and does not capture snapshots in situations where there is a low amount of free memory on your server.

#### How do I uninstall the Snapshot Debugger?
You can uninstall the Snapshot Debugger from Visual Studio by uninstalling it from **Tools / Extension and Updates**. Uninstalling the Snapshot Debugger site extension from your App Service currently must be done manually. You can uninstall the Snapshot Debugger site extension on your App Service with the following steps:
1. Navigate to your App Service's Kudu site (that is, yourappservice.**scm**.azurewebsites.net and navigate to the **Debug console**.
2. Navigate to D:/home/SiteExtensions/Microsoft.VisualStudio.SnapshotDebugger.AzureAppServices.Standalone and delete the applicationHost.xdt.
3. Navigate to the **Process explorer** in Kudu and kill all w3wp.exe processes (note that this action restarts your site).
4. Navigate to the **Debug console** and delete the Microsoft.VisualStudio.SnapshotDebugger.AzureAppServices.Standalone folder from D:/home/SiteExtensions and D:/home/site/siteextensions.

## Known Issues

* Snapshot debugging with multiple Visual Studio clients against the same App Service is not currently supported.
* Roslyn IL optimizations are not fully supported in ASP.NET Core projects. For some ASP.NET Core projects, you may not be able to see some variables or use some variables in conditional statements. 
* Special variables, such as *$FUNCTION* or *$CALLER*, cannot be evaluated in conditional statements or logpoints for ASP.NET Core projects.
* Snapshot debugging does not work on App Services that have [Local Caching](https://docs.microsoft.com/en-us/azure/app-service/app-service-local-cache) turned on.

## See Also  
 [Debugging in Visual Studio](../debugger/index.md)
