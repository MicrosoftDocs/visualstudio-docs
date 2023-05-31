---
title: Add Azure Storage by using Connected Services | Microsoft Docs
description: Add an Azure Storage service dependency to your app by using the Visual Studio Connected Services
author: ghogen
manager: jmartens
ms.technology: vs-azure
ms.custom: vs-azure
ms.workload: azure-vs
ms.topic: how-to
ms.date: 05/15/2023
ms.author: ghogen
---
# Adding Azure storage by using Visual Studio Connected Services

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

With Visual Studio, you can connect any of the following to Azure Storage by using the **Connected Services** feature:

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

## Connect to Azure Storage using Connected Services

:::moniker range="vs-2019"

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add Connected Service**.

    ![Screenshot showing "Add Azure connected service" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/add-connected-service.png)

1. In the **Connected Services** tab, select the + icon for **Service Dependencies**.

    ![Screenshot showing "Add Service Dependency" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/connected-services-tab.png)

1. In the **Add Dependency** page, select **Azure Storage**.

    ![Screenshot showing "Add Azure Storage" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/add-azure-storage.png)

    If you aren't signed in already, sign into your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure Storage** screen, select an existing storage account, and select **Next**.

    If you need to create a storage account, go to the next step. Otherwise, skip to step 6.

    ![Screenshot showing "Add existing storage account to project" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/select-azure-storage-account.png)

1. To create a storage account:

   1. Select **Create a storage account** at the bottom of the dialog.

   1. Fill out the **Azure Storage: Create new** dialog, and select **Create**.

       ![Screenshot showing "New Azure storage account" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/create-storage-account.png)

   1. When the **Azure Storage** dialog is displayed, the new storage account appears in the list. Select the new storage account in the list, and select **Next**.

1. Enter a connection string name, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot showing "Specify connection string" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/connection-string.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot showing "Summary of changes" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/summary-of-changes.png)

1. The storage connected service appears under the **Connected Services** node of your project.
:::moniker-end

:::moniker range=">=vs-2022"

1. Open your project in Visual Studio.

1. Press **Ctrl**+**Q** (or use the **Search** button in the Visual Studio IDE to the right of the main menu bar).

1. In **Feature search**, enter `Azure Storage`, and choose **Azure Storage - Project > Connected Services > Add > Azure Storage**.

   ![Screenshot of using Feature Search to search for Azure Storage.](./media/vs-2022/feature-search-azure-storage.png)

1. In the **Connect to dependency** page, select **Azure Storage**, and then click **Next**.

    ![Screenshot showing connecting to dependency - Azure Storage.](./media/vs-2022/connect-to-dependency-azure-storage.png)

    If you aren't signed in already, sign into your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Connect to Azure Storage** screen, select an existing storage account, and select **Next**.

    If you need to create a storage account, go to the next step. Otherwise, skip to the following step.

    ![Screenshot showing adding an existing storage account to project.](./media/vs-2022/connect-to-azure-storage.png)

1. To create a storage account:

   1. Select **Create new** by the green plus sign.

   1. Fill out the **Azure Storage: Create new** dialog, and select **Create**.

       ![New Azure storage account.](./media/vs-2022/azure-storage-create-account.png)

   1. When the **Azure Storage** dialog is displayed, the new storage account appears in the list. Select the new storage account in the list, and select **Next**.

1. Enter a connection string name, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot showing how to specify the connection string.](./media/vs-2022/azure-storage-connection-string.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot showing the summary of changes.](./media/vs-2022/summary-of-changes.png)

1. The storage connected service appears under the **Connected Services** node of your project.
:::moniker-end

## See also

- [Azure Storage forum](https://social.msdn.microsoft.com/forums/azure/home?forum=windowsazuredata)
- [Azure Storage documentation](/azure/storage/)
- [Connected services (Visual Studio for Mac)](/visualstudio/mac/connected-services)
