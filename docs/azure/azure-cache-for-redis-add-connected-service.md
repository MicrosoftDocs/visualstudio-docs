---
title: Add Azure Cache for Redis by using Connected Services | Microsoft Docs
description: Learn how to add Azure cache for Redis support to your app with the Visual Studio process for adding a connected service.
ms.custom: kr2b-contr-experiment
author: AngelosP test2
manager: jmartens
ms.technology: vs-azure
ms.workload: azure-vs
ms.topic: conceptual
ms.date: 08/17/2020
ms.author: angelpe
monikerRange: ">= vs-2019"
---
# Add Azure Cache for Redis by using Visual Studio Connected Services

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

With Visual Studio, you can connect any of the following to Azure Cache for Redis by using the **Connected Services** feature:

- .NET Framework console app
- ASP.NET MVC (.NET Framework) 
- ASP.NET Core
- .NET Core (including console app, WPF, Windows Forms, class library)
- .NET Core Worker Role
- Azure Functions
- Universal Windows Platform App
- Xamarin
- Cordova

The connected service functionality adds all the needed references and connection code to your project, and modifies your configuration files appropriately.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Connected services in Visual Studio for Mac](/visualstudio/mac/connected-services).
## Prerequisites

- Visual Studio with the Azure workload installed.
- A project of one of the supported types

## Connect to Azure Cache for Redis using Connected Services

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add Connected Service**.

1. In the **Connected Services** tab, select the + icon for **Service Dependencies**.

    ![Screenshot showing connected services selected in the menu pane. The + icon is highlighted for emphasis.](./media/vs-azure-tools-connected-services-storage/vs-2019/connected-services-tab.png)

1. In the **Add Dependency** page, select **Azure Cache for Redis**.

    ![Screenshot of the Add Dependency page. Azure Cache for Redis is selected.](./media/azure-redis-cache-add-connected-service/azure-redis-cache.png)

    If you aren't signed in already, sign into your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure Cache for Redis** screen, select an existing Azure Cache for Redis, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Screenshot of the Configure Azure Cache for Redis screen. Next is highlighted.](./media/azure-redis-cache-add-connected-service/created-azure-redis-cache.png)

1. To create an Azure Redis Cache:

   1. Select **Create a new Azure Redis Cache** at the bottom of the screen.

   1. Fill out the **Azure Cache for Redis: Create new** screen, and select **Create**.

       ![Screenshot of the Azure Cache for Redis create new page. Create is highlighted.](./media/azure-redis-cache-add-connected-service/create-new-azure-redis-cache.png)

   1. When the **Configure Azure Cache for Redis** screen is displayed, the new cache appears in the list. Select the new database in the list, and select **Next**.

1. Enter a connection string name, or choose the default, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot of the Azure Cache for Redis connection information page. Next is highlighted.](./media/azure-redis-cache-add-connected-service/connection-string.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot of the Summary of changes page. Finish is highlighted.](./media/azure-redis-cache-add-connected-service/summary-of-changes.png)

1. The connection appears under the **Service Dependencies** section of the **Connected Services** tab.

   ![Screenshot showing a list of configured service dependencies](./media/azure-redis-cache-add-connected-service/service-dependencies-after.png)

## See also

- [Azure Cache for Redis product page](https://azure.microsoft.com/services/cache)
- [Azure Cache for Redis documentation](/azure/azure-cache-for-redis/)
- [Connected services (Visual Studio for Mac)](/visualstudio/mac/connected-services)
