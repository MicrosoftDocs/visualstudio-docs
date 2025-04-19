---
title: Add Azure Cache for Redis by using Connected Services
description: Learn how to add Azure Cache for Redis support to your app with the Visual Studio process for adding a connected service.
author: AngelosP
manager: mijacobs
ms.subservice: azure-development
ms.topic: conceptual
ms.date: 05/15/2023
ms.author: angelpe
monikerRange: ">= vs-2019"
---

# Add Azure Cache for Redis by using Visual Studio Connected Services

With Visual Studio, you can connect any of the following to Azure Cache for Redis by using the **Connected Services** feature:

- .NET Framework console app
- ASP.NET Model-View-Controller (MVC) (.NET Framework)
- ASP.NET Core
- .NET Core (including console app, WPF, Windows Forms, class library)
- .NET Core Worker Role
- Azure Functions
- Universal Windows Platform App
- Cordova

The connected service functionality adds all the needed references and connection code to your project, and modifies your configuration files appropriately.

## Prerequisites

- Visual Studio with the Azure workload installed.
- A project of one of the supported types
- [!INCLUDE [prerequisites-azure-subscription](includes/prerequisites-azure-subscription.md)]

## Connect to Azure Cache for Redis using Connected Services

:::moniker range="vs-2019"
1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add Connected Service**.

   If you don't see the **Connected Services** node, choose **Project** > **Connected Services** > **Add**.

1. In the **Connected Services** tab, select the + icon for **Service Dependencies**.

    ![Screenshot showing connected services selected in the menu pane. The + icon is highlighted for emphasis.](./media/vs-azure-tools-connected-services-storage/vs-2019/connected-services-tab.png)

1. In the **Add Dependency** page, select **Azure Cache for Redis**.

    ![Screenshot of the Add Dependency page. Azure Cache for Redis is selected.](./media/azure-redis-cache-add-connected-service/azure-redis-cache.png)

    If you aren't signed in already, sign in to your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure Cache for Redis** screen, select an existing Azure Cache for Redis, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Screenshot of the Configure Azure Cache for Redis screen. Next is highlighted.](./media/azure-redis-cache-add-connected-service/created-azure-redis-cache.png)

1. To create an Azure Cache for Redis:

   1. Select **Create a new Azure Redis Cache** at the bottom of the screen.

   1. Fill out the **Azure Cache for Redis: Create new** screen, and select **Create**.

       ![Screenshot of the Azure Cache for Redis create new page. Create is highlighted.](./media/azure-redis-cache-add-connected-service/create-new-azure-redis-cache.png)

   1. When the **Configure Azure Cache for Redis** screen is displayed, the new cache appears in the list. Select the new database in the list, and select **Next**.

1. Enter a connection string name, or choose the default, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot of the Azure Cache for Redis connection information page. Next is highlighted.](./media/azure-redis-cache-add-connected-service/connection-string.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot of the Summary of changes page. Finish is highlighted.](./media/azure-redis-cache-add-connected-service/summary-of-changes.png)

1. The connection appears under the **Service Dependencies** section of the **Connected Services** tab.

   ![Screenshot showing a list of configured service dependencies.](./media/azure-redis-cache-add-connected-service/service-dependencies-after.png)
:::moniker-end

:::moniker range=">=vs-2022"

> [!NOTE]
> For .NET Framework projects, Connected Services UI is slightly different. To see the differences, compare to the [Visual Studio 2019 version of this page](./azure-cache-for-redis-add-connected-service.md?view=vs-2019&preserve-view=true).

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add** to open the menu of available services.

   ![Screenshot showing Connected Services context menu options.](./media/azure-redis-cache-add-connected-service/vs-2022/add-connected-service-context-menu-2.png)

   If you don't see the **Connected Services** node, choose **Project** > **Connected Services** > **Add**.

1. Choose **Azure Cache for Redis**. The **Connect to dependency** page appears. You should see two options, one for a local emulator, **Redis Cache on container (Local)**, and one for connecting to the live Azure Cache for Redis service. You can reduce cost and simplify early development by starting with the local emulator. You can migrate to the live service later by repeating these steps and choosing the other option.

   ![Screenshot showing Azure Cache for Redis choices](./media/azure-redis-cache-add-connected-service/vs-2022/azure-cache-for-redis-add-dependency-2.png)

   If you choose the Azure Cache for Redis locally, click **Next** to the **Connect to Redis cache on container** screen.

   ![Screenshot showing connection options for Azure Cache for Redis in a local container.](./media/azure-redis-cache-add-connected-service/vs-2022/connect-to-redis-cache-on-container.png)

   Specify **Container name**, **Container image**, and port mappings or accept the defaults, and click **Next** to see the **Summary of changes** screen, which shows what changes would be made to your project. A NuGet package reference is added to your project and the connection code for the local emulator is added to your project.

   If you want to connect to the Azure service, continue to the next step, or if you aren't signed in already, sign in to your Azure account before continuing. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. To go with the live service, select **Azure Cache for Redis**.

    ![Screenshot of the Add Dependency page. Azure Cache for Redis is selected.](./media/azure-redis-cache-add-connected-service/azure-redis-cache.png)

    If you aren't signed in already, sign in to your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure Cache for Redis** screen, select an existing Azure Cache for Redis, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Screenshot of the Configure Azure Cache for Redis screen. Next is highlighted.](./media/azure-redis-cache-add-connected-service/created-azure-redis-cache.png)

1. To create an Azure Cache for Redis:

   1. Select **Create a new Azure Redis Cache** at the bottom of the screen.

   1. Fill out the **Azure Cache for Redis: Create new** screen, and select **Create**.

       ![Screenshot of the Azure Cache for Redis create new page. Create is highlighted.](./media/azure-redis-cache-add-connected-service/create-new-azure-redis-cache.png)

   1. When the **Configure Azure Cache for Redis** screen is displayed, the new cache appears in the list. Select the new database in the list, and select **Next**.

1. Enter a connection setting name, or accept the default.

   ![Screenshot of the Azure Cache for Redis connection information page. Next is highlighted.](./media/vs-2022/connect-to-azure-cache-for-redis.png)

   > [!NOTE]
   > For improved security, in Visual Studio 17.12 and later, this step creates a connection setting name; previous versions create a connection string. Connection strings stored in the local filesystem can lead to a security risk, if they're inadvertently exposed.

1. Click on **Additional settings** and choose whether you want the connection setting stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot of the Azure Cache for Redis additional settings page.](./media/vs-2022/connect-to-azure-cache-additional-settings.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot of the Summary of changes page. Finish is highlighted.](./media/azure-redis-cache-add-connected-service/summary-of-changes.png)

1. In Solution Explorer, double-click on the **Connected Services** node to open the **Connected Services** tab. The connection appears under the **Service Dependencies** section:

   ![Screenshot showing a list of configured service dependencies.](./media/azure-redis-cache-add-connected-service/service-dependencies-after.png)

   If you click on the three dots next to the dependency you added, you can see various options such as **Connect** to reopen the wizard and change the connection. You can also click the three dots at the top right of the window to see options to start local dependencies, change settings, and more.

:::moniker-end

## Next steps

For ASP.NET apps, common use cases for Azure Cache for Redis are to cache session state or page output (HTTP responses). ASP.NET Core provides built-in services for these use cases, which should be used instead when you're using ASP.NET Core.

To cache session state in an ASP.NET app, see [ASP.NET Session State Provider](/azure/azure-cache-for-redis/cache-aspnet-session-state-provider).

To cache page output in an ASP.NET app, see [ASP.NET Output Cache Provider](/azure/azure-cache-for-redis/cache-aspnet-output-cache-provider).

## Related content

- [Azure Cache for Redis product page](https://azure.microsoft.com/services/cache)
- [Azure Cache for Redis documentation](/azure/azure-cache-for-redis/)
