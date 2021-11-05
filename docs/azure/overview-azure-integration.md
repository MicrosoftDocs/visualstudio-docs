---
title: Azure integration
description: Learn about how you can develop Azure applications and services in Visual Studio and deploy them to the cloud.
author: ghogen
manager: jmartens
ms.technology: vs-azure
ms.custom: vs-azure
ms.workload: azure-vs
ms.topic: overview
ms.date: 10/19/2021
ms.author: ghogen
monikerRange: ">=vs-2019"
---
# Overview: Azure integration

You can work with Azure in Visual Studio using many capabilities designed to make development and deployment to Azure easier.

## Provision Azure resources

This is a typical Visual Studio dialog where you can browse and search existing Azure resources. Above the list of existing resources, there is a button that lets you provision new ones:

:::moniker range="vs-2019"
![Screenshot showing how to select an Azure resource.](./media/select-azure-resource.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Screenshot showing how to select an Azure resource.](./media/vs-2022/select-azure-resource.png)
:::moniker-end

> [!NOTE]
> This example shows instances of Azure App Service, but a similar dialog exists for all Azure services that Visual Studio supports.

## Browse and search existing Azure resources

The following screenshot shows a typical Visual Studio dialog where you can browse and search existing Azure resources.

1. You can filter by Azure subscription using the drop-down
2. You can group the found instances either by Resource Group or by Resource Type (which effectively gives you a flat list)
3. You can search by the resource name

:::moniker range="vs-2019"
![Screenshot showing how to browse and search for Azure resources](./media/browse-search-azure-resource.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Screenshot showing how to browse and search for Azure resources](./media/vs-2022/browse-search-azure-resource.png)
:::moniker-end

> [!NOTE]
> This example shows instances of Azure App Service, but a similar dialog exists for all Azure services that Visual Studio supports.

## Deploy an application to Azure using Publish or GitHub Actions

Right-click on your project in [Solution Explorer](../ide/use-solution-explorer.md) and pick **Publish** from the context menu. The Publish wizard will guide you through the experience and if your project is hosted on GitHub.com you will automatically also be given the opportunity to configure CI/CD using GitHub Actions.

## Configure Azure dependencies to be emulated locally and connect to real services at deployment time

Use Connected Services to connect your application to local emulators and other local alternatives to Azure services. Get started by right-clicking on the **Connected Services** node in Solution Explorer and select **Manage Connected Services**.

:::moniker range="vs-2019"
![Screenshot showing local Azure emulators.](./media/local-azure-emulators.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Screenshot showing local Azure emulators.](./media/vs-2022/local-azure-emulators.png)
:::moniker-end

## Debug Azure Function projects offline without cost

Visual Studio will seamlessly emulate the Azure Functions service locally when you start debugging. You don't even have to be signed in with an Azure subscription.

## Remote debug Azure hosting services like Azure App Service

See [Attach to running processes with the Visual Studio debugger](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md#attach-to-a-net-core-process-running-on-azure-app-service-windows)
