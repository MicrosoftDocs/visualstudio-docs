---
title: "FAQ for snapshot debugging | Microsoft Docs"
ms.date: "11/07/2017"
ms.topic: "reference"
helpviewer_keywords:
  - "debugger"
ms.assetid: 944f1eb0-a74b-4d28-ae2b-a370cd869add
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Frequently Asked Questions for snapshot debugging in Visual Studio

Here is a list of questions that might come up when debugging live Azure applications using the Snapshot Debugger.

#### What is the performance cost of taking a snapshot?

When the Snapshot Debugger captures a snapshot of your app, it is forking the app's process and suspending the forked copy. When you debug a snapshot, you are debugging against the forked copy of the process. This process takes only 10-20 milliseconds but does not copy the full heap of the app. Instead, it copies only the page table and sets pages to copy on write. If some of your app's objects on the heap change, their respective pages are then copied. Each snapshot therefore has a small in-memory cost (on the order of hundreds of kilobytes for most apps).

#### What happens if I have a scaled-out Azure App Service (multiple instances of my app)?

When you have multiple instances of your app, snappoints get applied to every single instance. Only the first snappoint to hit with the conditions specified creates a snapshot. If you have multiple snappoints, subsequent snapshots come from the same instance that created the first snapshot. Logpoints sent to the output window will only show messages from one instance, while logpoints sent to application logs send messages from every instance.

#### How does the Snapshot Debugger load symbols?

The Snapshot Debugger requires that you have the matching symbols for your application either local or deployed to your Azure App Service. (Embedded PDBs are currently not supported.) The Snapshot Debugger automatically downloads symbols from your Azure App Service. As of Visual Studio 2017 version 15.2, deploying to Azure App Service also deploys your app's symbols.

#### Does the Snapshot Debugger work against release builds of my application?

Yes - the Snapshot Debugger is intended to work against release builds. When a snappoint is placed in a function, the function is recompiled back to a debug version, making it debuggable. When you stop the Snapshot Debugger, the functions are returned to their release build.

#### Can logpoints cause side effects in my production application?

No - any log messages you add to your app are evaluated virtually. They cannot cause any side effects in your application. However, some native properties may not be accessible with logpoints.

#### Does the Snapshot Debugger work if my server is under load?

Yes, snapshot debugging can work for servers under load. The Snapshot Debugger throttles and does not capture snapshots in situations where there is a low amount of free memory on your server.

#### How do I uninstall the Snapshot Debugger?

You can uninstall the Snapshot Debugger site extension on your App Service with the following steps:

1. Turn off your App Service either through the Cloud Explorer in Visual Studio or Azure portal.
1. Navigate to your App Service's Kudu site (that is, yourappservice.**scm**.azurewebsites.net) and navigate to **Site extensions**.
1. Click the X on the Snapshot Debugger site extension to remove it.

#### Why are ports opened during a Snapshot Debugger session?

Snapshot Debugger needs to open certain ports in order to debug the snapshots taken in Azure.  These are the same ports required for remote debugging, [you can find the list of ports here](../debugger/remote-debugger-port-assignments.md).

## See also

- [Debugging in Visual Studio](../debugger/index.md)
- [Debug live ASP.NET apps using the Snapshot Debugger](../debugger/debug-live-azure-applications.md)
- [Debug live ASP.NET Azure Virtual Machines\Virtual Machines Scale Sets using the Snapshot Debugger](../debugger/debug-live-azure-virtual-machines.md)
- [Debug live ASP.NET Azure Kubernetes using the Snapshot Debugger](../debugger/debug-live-azure-kubernetes.md)
- [Troubleshooting and known issues for snapshot debugging](../debugger/debug-live-azure-apps-troubleshooting.md)