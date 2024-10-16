---
title: Debug Azure services
description: You can debug Azure services with Visual Studio. Use the links in this article to learn about the various ways to do this.
ms.date: 09/14/2018
ms.topic: how-to
helpviewer_keywords:
  - debugger
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Debug Azure services in Visual Studio

You can use Visual Studio to debug Azure services in different scenarios:

To debug a production app hosted in:

- Azure App Service

  - Using Visual Studio Enterprise, see [Debug live ASP.NET apps using the Snapshot Debugger](../debugger/debug-live-azure-applications.md).

  - Using attach to process in Visual Studio, see [Remote debug ASP.NET Core on Azure](../debugger/remote-debugging-azure-app-service.md).

- Azure App Service or Service Fabric, using Application Insights, see [Debug snapshots on exceptions in .NET apps](/azure/application-insights/app-insights-snapshot-debugger).

- Azure virtual machine or Azure virtual machine scale set, see [Debug live ASP.NET Azure Virtual Machines and Azure virtual machine scale sets using the Snapshot Debugger](../debugger/debug-live-azure-virtual-machines.md).

- Azure Kubernetes Service, see [Debug live ASP.NET Azure Kubernetes Services using the Snapshot Debugger](../debugger/debug-live-azure-kubernetes.md).

To remote debug:

- ASP.NET on Internet Information Services (IIS) (Azure App Service or an Azure VM), see [Remote Debugging ASP.NET on Azure](remote-debugging-azure.md).

- ASP.NET on Azure Service Fabric, see [Debug a remote Service Fabric application](/azure/service-fabric/service-fabric-debugging-your-application#debug-a-remote-service-fabric-application)

## Related content

- [Debugging in Visual Studio](../debugger/index.yml)
