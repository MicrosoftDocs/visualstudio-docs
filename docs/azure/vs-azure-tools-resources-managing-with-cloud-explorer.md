---
title: Managing Azure resources with Cloud Explorer | Microsoft Docs
description: Learn how to use Cloud Explorer to browse and manage Azure resources within Visual Studio.
author: ghogen
manager: jmartens
ms.technology: vs-azure
ms.workload: azure-vs
ms.topic: conceptual
ms.date: 03/25/2017
ms.author: ghogen
---

# Manage the resources associated with your Azure accounts in Visual Studio Cloud Explorer

::: moniker range=">=vs-2022"
> [!Important]
> Cloud Explorer has been retired in Visual Studio 2022. Instead, you can use the following alternatives:
> - Use [Microsoft Azure Storage Explorer](/azure/vs-azure-tools-storage-manage-with-storage-explorer) is a free, standalone app from Microsoft. You can use it to work visually with Azure Storage data on Windows, macOS, and Linux.
> - In order to debug an Azure App Service or Azure Function app, you will be able to use the Connected Services or the Publish feature available on all projects. If you rely on Visual Studio for publishing, this option is available under the additional options in the hosting section. If you don’t use the publishing feature, you will be able to connect to any Azure App Service or Azure Function app from the Connected Service tab and invoke various operations like remote debug, remote profile, start/stop the site, view streaming logs etc. 
> - The [Kudu console](https://github.com/projectkudu/kudu/wiki/Kudu-console) gives you direct, elevated command-line access to the App Service server and its file system. This is both a valuable debugging tool and allows for CLI operations such as installing packages.
>
> If needed, you can use the Azure Portal or continue to use the Azure node of Server Explorer in previous versions of Visual Studio.
>
> For more information about Visual Studio 2022, see our [release notes](/visualstudio/releases/2022/release-notes/).

::: moniker-end

::: moniker range="<=vs-2019"

Cloud Explorer enables you to view your Azure resources and resource groups, inspect their properties, and perform key developer diagnostics actions from within Visual Studio.

Like the [Azure portal](https://portal.azure.com), Cloud Explorer is built on the Azure Resource Manager stack. Therefore, Cloud Explorer understands resources such as Azure resource groups and Azure services such as Logic apps and API apps, and it supports [role-based access control](/azure/role-based-access-control/role-assignments-portal) (RBAC).

## Prerequisites

* Visual Studio 2017 or later (see [Visual Studio downloads](https://visualstudio.microsoft.com/downloads)) with the **Azure workload** selected. You can also use an earlier version of Visual Studio with the Microsoft Azure SDK for .NET 2.9.
* Microsoft Azure account - If you don't have an account, you can [sign up for a free trial](https://azure.microsoft.com/pricing/member-offers/credit-for-visual-studio-subscribers/) or [activate your Visual Studio subscriber benefits](https://azure.microsoft.com/pricing/member-offers/credit-for-visual-studio-subscribers/).

> [!NOTE]
> To view Cloud Explorer, press **Ctrl**+**Q** to activate the search box, and then enter **Cloud Explorer**.

## Add an Azure account to Cloud Explorer

To view the resources associated with an Azure account, you must first add the account to **Cloud Explorer**.

1. In **Cloud Explorer**, select the **Account Management** button.

   ![Cloud Explorer Azure account settings icon](./media/vs-azure-tools-resources-managing-with-cloud-explorer/azure-account-settings.png)

1. Select **Manage accounts**.

   ![Cloud Explorer add-account link](./media/vs-azure-tools-resources-managing-with-cloud-explorer/manage-accounts-link.png)

1. Log in to the Azure account whose resources you want to browse.

1. Once logged in to an Azure account, the subscriptions associated with that account display. Select the check boxes for the account subscriptions you want to browse and then select **Apply**.

   ![Cloud Explorer: select Azure subscriptions to display](./media/vs-azure-tools-resources-managing-with-cloud-explorer/select-subscriptions.png)

1. After selecting the subscriptions whose resources you want to browse, those subscriptions and resources display in the **Cloud Explorer**.

   ![Cloud Explorer resource listing for an Azure account](./media/vs-azure-tools-resources-managing-with-cloud-explorer/resources-listed.png)

## Remove an Azure account from Cloud Explorer

1. In **Cloud Explorer**, select **Account Management**.

   ![Azure account settings](./media/vs-azure-tools-resources-managing-with-cloud-explorer/azure-account-settings.png)

1. Next to the account you want to remove, select **Manage Accounts**.

   ![Remove account](./media/vs-azure-tools-resources-managing-with-cloud-explorer/remove-account.png)

1. Choose **Remove** to remove an account.

    ![Cloud Explorer Manage accounts dialog box](./media/vs-azure-tools-resources-managing-with-cloud-explorer/accountmanage.PNG)

## View resource types or resource groups

To view your Azure resources, you can choose either **Resource Types** or **Resource Groups** view.

1. In **Cloud Explorer**, select the resource view dropdown.

   ![Cloud Explorer dropdown list to select the desired resources view](./media/vs-azure-tools-resources-managing-with-cloud-explorer/resources-view-dropdown.png)

1. From the context menu, select the desired view:

   * **Resource Types** view - The common view used on the [Azure portal](https://portal.azure.com), shows your Azure resources categorized by their type, such as web apps, storage accounts, and virtual machines.
   * **Resource Groups** view - Categorizes Azure resources by the Azure resource group with which they're associated. A resource group is a bundle of Azure resources, typically used by a specific application. To learn more about Azure resource groups, see [Azure Resource Manager Overview](/azure/azure-resource-manager/resource-group-overview).

   The following image shows a comparison of the two resource views:

   ![Cloud Explorer resource views comparison](./media/vs-azure-tools-resources-managing-with-cloud-explorer/resource-views-comparison.png)

## View and navigate resources in Cloud Explorer

To navigate to an Azure resource and view its information in Cloud Explorer, expand the item's type or associated resource group and then select the resource. When you select a resource, information appears in the two tabs - **Actions** and **Properties** - at the bottom of Cloud Explorer.

* **Actions** tab - Lists the actions you can take in Cloud Explorer for the selected resource. You can also view these options by right-clicking the resource to view its context menu.

* **Properties** tab - Shows the properties of the resource, such as its type, locale, and resource group with which it is associated.

The following image shows an example comparison of what you see on each tab for an App Service:

  ![Screenshot of Cloud Explorer](./media/vs-azure-tools-resources-managing-with-cloud-explorer/actions-and-properties.png)

Every resource has the action **Open in portal**. When you choose this action, Cloud Explorer displays the selected resource in the [Azure portal](https://portal.azure.com). The **Open in portal** feature is handy for navigating to deeply nested resources.

Additional actions and property values may also appear based on the Azure resource. For example, web apps and logic apps also have the actions **Open in browser** and **Attach debugger** in addition to **Open in portal**. Actions to open editors appear when you choose a storage account blob, queue, or table. Azure apps have **URL** and **Status** properties, while storage resources have key and connection string properties.

## Find resources in Cloud Explorer

To locate resources with a specific name in your Azure account subscriptions, enter the name in the **Search** box in **Cloud Explorer**.

  ![Finding resources in Cloud Explorer](./media/vs-azure-tools-resources-managing-with-cloud-explorer/search-for-resources.png)

As you enter characters in the **Search** box, only resources that match those characters appear in the resource tree.

::: moniker-end
