---
title: "Troubleshooting snapshot debugging | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/07/2018"
ms.topic: "troubleshooting"
helpviewer_keywords:
  - "debugger"
ms.assetid: 511a0697-c68a-4988-9e29-8d0166ca044a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Troubleshooting and known issues for snapshot debugging in Visual Studio

If the steps described in this article do not resolve your issue, contact snaphelp@microsoft.com.

## Issue: Snappoint does not turn on

If you see a warning icon ![Snappoint warning icon](../debugger/media/snapshot-troubleshooting-snappoint-warning-icon.png "Snappoint warning icon") with your snappoint instead of the regular snappoint icon, then the snappoint is not turned on.

![Snappoint does not turn on](../debugger/media/snapshot-troubleshooting-dont-turn-on.png "Snappoint does not turn on")

Take these steps:

1. Make sure you have the same version of source code that was used to build and deploy your app.isua1. Make sure you are loading the correct symbols for your deployment. To do this, view the **Modules** window while Snapshot Debugging and verify the Symbol File column shows a .pdb file loaded for the module you are debugging. The Snapshot Debugger will try to automatically download and use symbols for your deployment.

## Issue: Symbols do not load when I open a Snapshot

If you see following window, symbols did not load.

![Symbols do not load](../debugger/media/snapshot-troubleshooting-symbols-wont-load.png "Symbols do not load")

Take these steps:

- Click the **Change Symbol Settings…** link on this page. In the **Debugging > Symbol** settings, add a symbol cache directory. Restart snapshot debugging after the symbol path has been set.

   The symbols, or .pdb files, available in your project must match your App Service deployment. Most deployments (deployment through Visual Studio, CI/CD with Azure Pipelines or Kudu, etc.) will publish your symbol files along to your App Service. Setting the symbol cache directory enables Visual Studio to use these symbols.

   ![Symbol settings](../debugger/media/snapshot-troubleshooting-symbol-settings.png "Symbol settings")

- Alternatively, if your organization uses a symbol server or drops symbols in a different path, use the symbol settings to load the correct symbols for your deployment.

## Issue: I cannot see the "Attach Snapshot Debugger" option in the Cloud Explorer

Take these steps:

- Make sure the Snapshot Debugger component is installed. Open the Visual Studio Installer, and check the **Snapshot Debugger** component in the Azure workload.
::: moniker range="< vs-2019"
- Make sure your app is supported. Currently, only ASP.NET (4.6.1+) and ASP.NET Core (2.0+) apps deployed to Azure App Services are supported.
::: moniker-end
::: moniker range=">= vs-2019"
- Make sure your app is supported:
  - Azure App Services - ASP.NET applications running on .NET Framework 4.6.1 or later.
  - Azure App Services - ASP.NET Core applications running on .NET Core 2.0 or later on Windows.
  - Azure Virtual Machines (and VMSS) - ASP.NET applications running on .NET Framework 4.6.1 or later.
  - Azure Virtual Machines (and VMSS) - ASP.NET Core applications running on .NET Core 2.0 or later on Windows.
  - Azure Kubernetes Services - ASP.NET Core applications running on .NET Core 2.2 or later on Debian 9.
  - Azure Kubernetes Services - ASP.NET Core applications running on .NET Core 2.2 or later on Alpine 3.8.
  - Azure Kubernetes Services - ASP.NET Core applications running on .NET Core 2.2 or later on Ubuntu 18.04.
::: moniker-end

## Issue: I only see Throttled Snapshots in the Diagnostic Tools

![Throttled snappoint](../debugger/media/snapshot-troubleshooting-throttled-snapshots.png "Throttled snappoint")

Take these steps:

- Snapshots take up little memory but do have a commit charge. If the Snapshot Debugger detects your server is under heavy memory load, it will not take snapshots. You can delete already captured snapshots by stopping the Snapshot Debugger session and trying again.

## Known Issues

- Snapshot debugging with multiple Visual Studio clients against the same App Service is not currently supported.
- Roslyn IL optimizations are not fully supported in ASP.NET Core projects. For some ASP.NET Core projects, you may not be able to see some variables or use some variables in conditional statements.
- Special variables, such as *$FUNCTION* or *$CALLER*, cannot be evaluated in conditional statements or logpoints for ASP.NET Core projects.
- Snapshot debugging does not work on App Services that have [Local Caching](/azure/app-service/app-service-local-cache) turned on.
- Snapshot debugging API Apps is not currently supported.

## Site Extension Upgrade

Snapshot Debugging and Application Insights depend on an ICorProfiler, which loads into the site process and causes file locking issues during upgrade. We recommend this process to ensure there is no down-time to your production site.

- Create a [Deployment Slot](/azure/app-service/web-sites-staged-publishing) within your App Service and deploy your site to the Slot.
- Swap the Slot with production from Cloud Explorer in Visual Studio or from the Azure portal.
- Stop the Slot site. This will take a few seconds to kill off the site w3wp.exe process from all instances.
- Upgrade the Slot site extension from the Kudu site or the Azure portal (*App Service Blade > Development Tools > Extensions > Update*).
- Start the Slot site. We recommend visiting the site to warm it up again.
- Swap the Slot with production.

## See also

- [Debugging in Visual Studio](../debugger/index.md)
- [Debug live ASP.NET apps using the Snapshot Debugger](../debugger/debug-live-azure-applications.md)
- [Debug live ASP.NET Azure Virtual Machines\Virtual Machines Scale Sets using the Snapshot Debugger](../debugger/debug-live-azure-virtual-machines.md)
- [Debug live ASP.NET Azure Kubernetes using the Snapshot Debugger](../debugger/debug-live-azure-kubernetes.md)
- [FAQ for snapshot debugging](../debugger/debug-live-azure-apps-faq.md)