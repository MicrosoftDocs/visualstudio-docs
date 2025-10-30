---
title: "Differences Between Sandboxed and Farm Solutions"
description: Understand the differences between sandboxed and farm solutions. Know how Visual Studio approaches debugging with either type of solution.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, sandboxed solutions"
  - "sandboxed solutions [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, farm solutions"
  - "farm solutions [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Differences between sandboxed and farm solutions

  When you compile a SharePoint solution, it deploys to the SharePoint server and a debugger attaches to debug it. The process used to debug the solution depends on the setting of the Sandboxed Solution property: sandboxed solution or farm solution.

 For more information, see [Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md).

## Farm solutions
 Farm solutions, which are hosted in the IIS worker process (W3WP.exe), run code that can affect the whole farm. When you debug a SharePoint project whose Sandboxed Solution property is set to "farm solution," the system's IIS application pool recycles before SharePoint retracts or deploys the feature so as to release any files locked by the IIS worker process. Only the IIS application pool serving the SharePoint project's site URL is recycled.

## Sandboxed solutions
 Sandboxed solutions, which are hosted in the SharePoint user code solution worker process (SPUCWorkerProcess.exe), run code that can only affect the site collection of the solution. Because sandboxed solutions do not run in the IIS worker process, neither the IIS application pool nor the IIS server must restart. Visual Studio attaches the debugger to the SPUCWorkerProcess process that the SPUserCodeV4 service in SharePoint automatically triggers and controls. It is not necessary for the SPUCWorkerProcess process to recycle to load the latest version of the solution.

## Either type of solution
 With either solution type, Visual Studio also attaches the debugger to the browser to enable client-side script debugging. Visual Studio uses the script debugging engine for this purpose. To enable script debugging, you must change the default browser settings when you are prompted.

 Visual Studio attaches the debugger only to the W3WP or SPUCWorkerProcess processes running the current site. Visual Studio also attaches the managed COM Plus and workflow debugging engines.

## Related content
- [Debug SharePoint solutions](../sharepoint/debugging-sharepoint-solutions.md)
- [Build and debug SharePoint solutions](../sharepoint/building-and-debugging-sharepoint-solutions.md)
- [Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md)
