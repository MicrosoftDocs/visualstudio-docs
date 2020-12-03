---
title: Publish to App Service on Linux
description: Learn about methods to publish ASP.NET Core apps to Azure App Service Linux using containers, including continuous and one-time options.
ms.custom: SEO-VS-2020
ms.date: 01/29/2019
ms.topic: quickstart
helpviewer_keywords:
  - "deployment, website"
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "azure"
---
# Publish an ASP.NET Core app to App Service on Linux using Visual Studio

Starting in Visual Studio 2017 version 15.7, you can publish ASP.NET Core apps to Azure App Service Linux (using containers) using one of the following methods.

* For continuous (or automated) deployment of apps, use Azure DevOps with [Azure Pipelines](/azure/devops/pipelines/get-started-yaml?view=azdevops&preserve-view=true).

* For one-time (or manual) deployment of apps, use the **Publish** tool in Visual Studio to publish ASP.NET Core apps to App Service for Linux (using containers).

This article describes how to use the **Publish** tool for one-time deployment.

[!INCLUDE [quickstart-prereqs-azure-linux](includes/quickstart-prereqs-azure-linux.md)]

## Publish to Azure App Service on Linux

1. In Solution Explorer, right-click the project and choose **Publish** (or use the **Build** > **Publish** menu item).

    ![The Publish command on the project context menu in Solution Explorer](../deployment/media/quickstart-publish.png "Choose Publish")

1. If you have previously configured any publishing profiles, the **Publish** window appears. Select **New**.

1. In the **Publish** window, select **Azure**.

    ![Choose publish target](../deployment/media/quickstart-publish-azure-new.png)

1. Select **Azure App Service (Linux)** and **Next**.

    ![Choose Azure App Service on Linux](../deployment/media/quickstart-publish-linux-select-azure-service.png)

1. Sign in with you Azure account, if necessary. Select **Create a new Azure App Service...**

    ![Link to create new instance of Azure App Service](../deployment/media/quickstart-publish-linux-create-new-link.png)

1. In the **Create Azure App Service (Linux)** dialog, the **App Name**, **Resource Group**, and **App Service Plan** entry fields are populated. You can keep these names or change them. When ready, select **Create**.

    ![Choose Azure App Service](../deployment/media/quickstart-publish-linux-create-new-dialog.png)

1. In the **Publish** dialog, the newly created instance has been automatically selected. When ready, click **Finish**.

    ![Choose Azure App Service](../deployment/media/quickstart-publish-linux-select-instance.png)

1. Select **Publish**. Visual Studio deploys the app to your Azure App Service, and the web app loads in your browser. The project properties **Publish** pane shows the site URL and other details.

    ![Publish property pane showing a profile summary](../deployment/media/quickstart-publish-linux-summary-page.png)

## Clean up resources

In the preceding steps, you created Azure resources in a resource group. If you don't expect to need these resources in the future, you can delete them by deleting the resource group.
From the left menu in the Azure portal, select **Resource groups** and then select **myResourceGroup**.
On the resource group page, make sure that the listed resources are the ones you want to delete.
Select **Delete**, type **myResourceGroup** in the text box, and then select **Delete**.

## Next steps

In this quickstart, you learned how to use Visual Studio to create a publishing profile for deployment to App Service on Linux. You may want more information on publishing to Linux using Azure.

> [!div class="nextstepaction"]
> [Linux App Service](/azure/app-service/containers/app-service-linux-intro)