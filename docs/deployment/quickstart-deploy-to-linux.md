---
title: Publish to App Service on Linux
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

* For continuous (or automated) deployment of apps, use Azure DevOps with [Azure Pipelines](/azure/devops/pipelines/get-started-yaml?view=azdevops).

* For one-time (or manual) deployment of apps, use the **Publish** tool in Visual Studio to publish ASP.NET Core apps to App Service for Linux (using containers).

This article describes how to use the **Publish** tool for one-time deployment.

[!INCLUDE [quickstart-prereqs-azure-linux](includes/quickstart-prereqs-azure-linux.md)]

## Publish to App Service on Linux

1. In Solution Explorer, right-click the project and choose **Publish** (or use the **Build** > **Publish** menu item).

    ![The Publish command on the project context menu in Solution Explorer](../deployment/media/quickstart-publish.png "Choose Publish")

1. If you have previously configured any publishing profiles, the **Publish** pane appears, in which case select **Create new profile**.

1. In the **Pick a publish target** dialog box, choose **App Service Linux**.

    ![Choose Azure App Service](../deployment/media/quickstart-publish-linux.png "Choose Azure App Service")

1. Select **Publish**. The **Create App Service** dialog box appears. Sign in with you Azure account, if necessary, then the default app service settings populate the fields.

    ![Create App Service](../deployment/media/quickstart-publish-settings-app-service-linux.png "Create Azure App Service")

1. Select **Create**. Visual Studio deploys the app to your Azure App Service, and the web app loads in your browser. The project properties **Publish** pane shows the site URL and other details.

    ![Publish property pane showing a profile summary](../deployment/media/quickstart-publish-app-service-summary.png)

## Clean up resources

In the preceding steps, you created Azure resources in a resource group. If you don't expect to need these resources in the future, you can delete them by deleting the resource group.
From the left menu in the Azure portal, select **Resource groups** and then select **myResourceGroup**.
On the resource group page, make sure that the listed resources are the ones you want to delete.
Select **Delete**, type **myResourceGroup** in the text box, and then select **Delete**.

## Next steps

In this quickstart, you learned how to use Visual Studio to create a publishing profile for deployment to App Service on Linux. You may want more information on publishing to Linux using Azure.

> [!div class="nextstepaction"]
> [Linux App Service](/azure/app-service/containers/app-service-linux-intro)
