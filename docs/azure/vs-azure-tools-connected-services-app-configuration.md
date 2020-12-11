---
title: Add Azure App Configuration by using Connected Services | Microsoft Docs
description: Add an Azure Configuration service dependency to your app by using the Visual Studio Connected Services
author: gohogen
manager: 
ms.custom: vs-azure
ms.workload: azure-vs
ms.topic: how-to
ms.date: 12/11/2020
ms.author: gohogen
---
# Adding Azure App Configuration by using Visual Studio Connected Services

In this tutorial, you will learn how to easily add everything you need to start using Azure App Configuration to manage your configuration and feature flags for web projects in Visual Studio, whether you are using ASP.NET Core or any type of ASP.NET project. By using the Connected Services feature in Visual Studio, you can have Visual Studio automatically add all the code, NuGet packages, and configuration settings you need to connect to your App Configuration resource in Azure.

<!-- does this note apply for app config? -->
> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Connected services in Visual Studio for Mac](/visualstudio/mac/connected-services). 
## Prerequisites

- Visual Studio with the Azure workload installed.
- A project of one of the supported types

## Connect to Azure App Configuration using Connected Services

::: moniker range="vs-2017"

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and from the context menu, select **Add Connected Service**.

    ![Add Azure connected service](./media/vs-azure-tools-connected-services-storage/add-connected-service.png)

1. In the **Connected Services** page, select the + icon for **Service Dependencies**.

    ![Add Azure Storage](./media/vs-azure-tools-connected-services-storage/add-azure-storage.png)

1. In the **Azure Storage** dialog, select an existing storage account, and select **Add**.

    If you need to create a storage account, go to the next step. Otherwise, skip to step 6.

    ![Add existing storage account to project](./media/vs-azure-tools-connected-services-storage/select-azure-storage-account.png)

1. To create a storage account:

   1. Select **Create a New Storage Account** at the bottom of the dialog.

   1. Fill out the **Create Storage Account** dialog, and select **Create**.

       ![New Azure storage account](./media/vs-azure-tools-connected-services-storage/create-storage-account.png)

   1. When the **Azure Storage** dialog is displayed, the new storage account appears in the list. Select the new storage account in the list, and select **Add**.

1. The storage connected service appears under the **Service References** node of your project.
:::moniker-end

:::moniker range=">=vs-2019"

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add Connected Service**.

    ![Add Azure connected service](./media/vs-azure-tools-connected-services-storage/vs-2019/add-connected-service.png)

1. In the **Connected Services** tab, select the + icon for **Service Dependencies**.

    ![Add Service Dependency](./media/vs-azure-tools-connected-services-storage/vs-2019/connected-services-tab.png)

1. In the **Add Dependency** page, select **Azure App Configuration**.

    ![Add App Configuration](./media/vs-azure-tools-connected-services-app-configuration/add-azure-app-configuration.png)

    If you aren't signed in already, sign into your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/account/free).

1. In the **Configure Azure App Configuration** screen, select your subscription and an existing configuration store. Then select **Next**.

    If you need to create an App Configuration store, go to the next step. Otherwise, skip to step 6.

    ![Add existing configuration account to project](./media/vs-azure-tools-connected-services-app-configuration/select-config-store.png)

1. To create an app configuration store:

   1. Select the + icon to the right of the **App Configuration stores** header. 

   1. Fill out the **Azure App Configuration: Create new** dialog, and select **Create**. Note that the Resource Name field needs to be unique. 

       ![New Azure app config store](./media/vs-azure-tools-connected-services-app-configuration/create-new-config-store.png)

   1. When the **Azure App Configuration** dialog is displayed, the new configuration store appears in the list. Select this new store, then select **Next**.

1. Enter a connection string name, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Specify connection string](./media/vs-azure-tools-connected-services-app-configuration/connection-string-app-config.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Summary of changes](./media/vs-azure-tools-connected-services-app-configuration/summary-of-changes-app-config.png)

1. Once the **Dependency configuration process** has finished, Azure App Configuration now appears under the **Service Dependencies** node of your project.
:::moniker-end

## See also

- [Azure App Configuration documentation](https://docs.microsoft.com/azure/azure-app-configuration/overview)
- [Tutorial for using dynamic configuration in an App Configuration connected ASP.NET Core app](https://docs.microsoft.com/azure/azure-app-configuration/enable-dynamic-configuration-aspnet-core)
- [Connected services (Visual Studio for Mac)](/visualstudio/mac/connected-services)