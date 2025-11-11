---
title: Add Azure App Configuration with Connected Services
description: Connect an Azure Configuration service dependency to your application by using Connected Services in Visual Studio on Windows.
author: ghogen
manager: 
ms.topic: how-to
ms.date: 05/15/2023
ms.author: ghogen
monikerRange: ">=vs-2019"
ms.custom: sfi-image-nochange
---

# Adding Azure App Configuration by using Visual Studio Connected Services

In this tutorial, you will learn how to easily add everything you need to start using Azure App Configuration to manage your configuration and feature flags for web projects in Visual Studio. By using the Connected Services feature in Visual Studio, you can have Visual Studio automatically add all the code, NuGet packages, and configuration settings you need to connect to your App Configuration resource in Azure. To use this feature, you must be using Visual Studio 2019 version 16.9 or later.

You can use the App Configuration Connected Services feature in the following project types:

- ASP.NET Core
- .NET Core Console
- .NET Framework projects.

## Prerequisites

- Visual Studio (see [Visual Studio downloads] (https://aka.ms/vs/download/?cid=learn-onpage-download-cta)) with the **Azure development** workload installed.
- A project of one of the supported types
- [!INCLUDE [prerequisites-azure-subscription](includes/prerequisites-azure-subscription.md)]

## Connect to Azure App Configuration using Connected Services

:::moniker range="vs-2019"

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add Connected Service**.

    ![Screenshot showing "Add Azure connected service" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/add-connected-service.png)

1. In the **Connected Services** tab, select the + icon for **Service Dependencies**.

    ![Screenshot showing "Add Service Dependency" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/connected-services-tab.png)

1. In the **Add Dependency** page, select **Azure App Configuration**.

    ![Screenshot showing "Add App Configuration" screen.](./media/vs-azure-tools-connected-services-app-configuration/add-azure-app-configuration.png)

    If you aren't signed in already, sign in to your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/pricing/purchase-options/azure-account?cid=msft_learn).

1. In the **Configure Azure App Configuration** screen, select your subscription and an existing configuration store. Then select **Next**.

    If you need to create an App Configuration store, go to the next step. Otherwise, skip to step 6.

    ![Screenshot showing "Add existing configuration account to project" screen.](./media/vs-azure-tools-connected-services-app-configuration/select-config-store.png)

1. To create an app configuration store:

   1. Select the + icon to the right of the **App Configuration stores** header.

   1. Fill out the **Azure App Configuration: Create new** dialog, and select **Create**. Note that the Resource Name field needs to be unique.

       ![Screenshot showing New Azure app config store.](./media/vs-azure-tools-connected-services-app-configuration/create-new-config-store.png)

   1. When the **Azure App Configuration** dialog is displayed, the new configuration store appears in the list. Select this new store, then select **Next**.

1. Enter a connection string name, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot showing "Specify connection string" screen.](./media/vs-azure-tools-connected-services-app-configuration/connection-string-app-config.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot showing summary of changes.](./media/vs-azure-tools-connected-services-app-configuration/summary-of-changes-app-config.png)

1. Once the **Dependency configuration process** has finished, Azure App Configuration now appears under the **Service Dependencies** node of your project.

:::moniker-end

:::moniker range=">=vs-2022"

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add** to open the menu of available services.

   ![Screenshot showing Connected Services context menu options.](./media/vs-2022/add-connected-service-context-menu-2.png)

1. Choose **Azure App Configuration**. The **Connect to dependency** page appears.

   ![Screenshot showing Connect to dependency for Azure App Configuration.](./media/vs-2022/connect-to-dependency-app-configuration.png)

    If you aren't signed in already, sign in to your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/pricing/purchase-options/azure-account?cid=msft_learn).

1. In the **Configure Azure App Configuration** screen, select your subscription and an existing configuration store. Then select **Next**.

    If you need to create an App Configuration store, go to the next step. Otherwise, skip to step 6.

    ![Screenshot showing 'Add existing configuration account to project".](./media/vs-azure-tools-connected-services-app-configuration/select-config-store.png)

1. To create an app configuration store:

   1. Select the + icon to the right of the **App Configuration stores** header.

   1. Fill out the **Azure App Configuration: Create new** dialog, and select **Create**. Note that the Resource Name field needs to be unique.

       ![Screenshot showing new Azure app config store.](./media/vs-azure-tools-connected-services-app-configuration/create-new-config-store.png)

   1. When the **Azure App Configuration** dialog is displayed, the new configuration store appears in the list. Select this new store, then select **Next**.

1. Enter a connection string name, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot showing "Specify connection string" screen.](./media/vs-azure-tools-connected-services-app-configuration/connection-string-app-config.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot showing summary of changes.](./media/vs-azure-tools-connected-services-app-configuration/summary-of-changes-app-config.png)

   Once the **Dependency configuration process** has finished, Azure App Configuration now appears under the **Service Dependencies** node of your project.

1. In Solution Explorer, double-click on the **Connected Services** node to open the **Connected Services** tab. The connection appears under the **Service Dependencies** section:

   ![Screenshot of Service Dependencies section showing Azure App Configuration connection.](./media/vs-2022/app-configuration-added.png)

   There's also a *Secrets.json* entry that supports secure storage of the connection string locally. Read about how this works at [Screenshot showing safe storage of app secrets in development in ASP.NET Core](/aspnet/core/security/app-secrets?tabs=windows).

   If you click on the three dots next to the dependencies you added, you can see various options such as **Connect** to reopen the wizard and change the connection, and for *Secrets.json*, the option to manage secrets. You can also click the three dots at the top right of the window to see options to start local dependencies, change settings, and more.

::: moniker-end

## Related content

- [Azure App Configuration documentation](/azure/azure-app-configuration/overview)
- [Tutorial for using dynamic configuration in an App Configuration connected ASP.NET Core app](/azure/azure-app-configuration/enable-dynamic-configuration-aspnet-core)
