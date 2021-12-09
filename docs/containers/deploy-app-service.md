---
title: Deploy an ASP.NET Core container to Azure App Service
description: Learn how to use Visual Studio Container Tools to deploy an ASP.NET Core web app in a Docker container to Azure App Service
ms.custom: SEO-VS-2020
author: ghogen
manager: jmartens
ms.technology: vs-container-tools
ms.devlang: dotnet
ms.topic: how-to
ms.date: 10/28/2021
ms.author: ghogen
---
# Deploy an ASP.NET Core container to Azure App Service using Visual Studio

This tutorial walks you through using Visual Studio to publish your containerized ASP.NET Core web application to an [Azure App Service](/azure/app-service). Azure App Service is an appropriate service for a single-container web app hosted in Azure.

If you don't have an Azure subscription, create a [free account](https://azure.microsoft.com/free/dotnet/?utm_source=acr-publish-doc&utm_medium=docs&utm_campaign=docs) before you begin.

## Prerequisites

To complete this tutorial:

::: moniker range="vs-2017"
- Install the latest version of [Visual Studio 2017](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) with the "ASP.NET and web development" workload
::: moniker-end
::: moniker range="vs-2019"
- [Visual Studio 2019](https://visualstudio.microsoft.com/downloads) with the *ASP.NET and web development* workload.
::: moniker-end
::: moniker range=">=vs-2022"
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads) with the *ASP.NET and web development* workload.
::: moniker-end

- Install [Docker Desktop](https://docs.docker.com/docker-for-windows/install/)

## Create an ASP.NET Core web app

The following steps guide you through creating a basic ASP.NET Core app that will be used in this tutorial.

::: moniker range="vs-2017"
1. From the Visual Studio menu, select **File > New > Project**.
2. Under the **Templates** section of the **New Project** dialog box, select **Visual C# > Web**.
3. Select **ASP.NET Core Web Application**.
4. Give your new application a name (or take the default) and select **OK**.
5. Select **Web Application**.
6. Check the **Enable Docker Support** checkbox.
7. Select the **Linux** container type and click **OK**. 
::: moniker-end
::: moniker range=">= vs-2019"
1. From the Visual Studio start window, choose **Create a new project**.
1. Choose **ASP.NET Core Web App**, and choose **Next**.
1. Give your new application a name (or take the default) and choose **Next**.
1. Choose the .NET version you want to target. If you're not sure, choose the long-term support (LTS) version.
1. Choose whether or not you want SSL support by using the **Configure for HTTPS** checkbox.
1. Check the **Enable Docker Support** checkbox.
1. Select the container type, and click **Create**.
::: moniker-end

## Deploy the container to Azure

::: moniker range="vs-2017"

1. Right-click your project in **Solution Explorer** and choose **Publish**.
1. On the publish target dialog, choose **App Service Linux** or **App Service**. This is the operating system that will host the web server.
1. You can publish only to App Service, or you can publish to both App Service and Azure Container Registry (ACR). To publish the container in an Azure Container Registry (ACR), choose **Create new App Service for containers**, and click **Publish**.

   ![Screenshot of publish dialog.](media/deploy-app-service/publish-app-service-linux-1.png)

   To publish only to an Azure App Service without using Azure Container Registry, choose **Create new**, and click **Publish**.

1. Check that you're signed in with the account that's associated with your Azure subscription, and choose a unique name, subscription, resource group, hosting plan, and container registry (if applicable), or accept the defaults.

   ![Screenshot of publish settings.](media/deploy-app-service/publish-app-service-linux-2.png)

1. Choose **Create**. Your container is deployed to Azure in the resource group and container registry you selected. This process takes a bit of time. When it's completed, the **Publish** tab shows information about what was published, including the site URL.

   ![Screenshot of publish tab.](media/deploy-app-service/publish-succeeded.PNG)

1. Click on the site link to verify your app works as expected in Azure.

   ![Screenshot of web application.](media/deploy-app-service/web-application-running.png)

1. The publishing profile is saved with all the details you selected, such as the resource group and container registry.

1. To deploy again with the same publishing profile, use the **Publish** button, the **Publish** button on the **Web Publish Activity** window, or right-click on the project in **Solution Explorer** and choose the **Publish** item on the context-menu.
:::moniker-end

:::moniker range="vs-2019"

1. Right-click your project in **Solution Explorer** and choose **Publish**.
1. On the **Publish** dialog, choose the **Azure** target.

   ![Screenshot of Publish wizard.](media/deploy-app-service/publish-choices.png)

1. On the **Specific target** tab, choose the appropriate deployment target, such as **App Service (Windows)** or **App Service (Linux)**, depending on your container type.

   ![Screenshot of Specific target tab of Publish wizard.](media/deploy-app-service/publish-app-service-windows.png)

1. If you are not signed in to the right Azure account with the subscription you want to use, sign in by using the button at the top left of the **Publish** window.

1. You can use an existing app service or create a new one by clicking on the **Create new Azure App Service** link. Find your existing app service in the treeview by expanding its resource group, or change the **View** setting to **Resource type** to sort by type.

   ![Screenshot showing choosing an App Service.](media/deploy-app-service/publish-app-service-windows2.png)

1. If you create a new one, a resource group and app service will be generated in Azure. You can change the names if desired, as long as they are unique.

   ![Screenshot showing creating an App Service.](media/deploy-app-service/publish-app-service-windows3.png)

1. You can accept the default hosting plan or change the hosting plan now, or later in the Azure portal. The default is `S1` (small) in one of the supported regions. To create a hosting plan, choose **New** next to the **Hosting Plan** dropdown. The **Hosting Plan** window appears.

   ![Screenshot showing hosting plan options.](media/deploy-app-service/hosting-plan.png)

   You can view the details about these options at [Azure App Service plan overview](/azure/app-service/overview-hosting-plans).

1. Once you're done selecting or creating these resources, choose **Finish**. Your container is deployed to Azure in the resource group and app service you selected. This process takes a bit of time. When it's completed, the **Publish** tab shows information about what was published, including the site URL.

   :::image type="content" source="media/deploy-app-service/publish-succeeded-windows.png" alt-text="Screenshot of publish tab." lightbox="media/deploy-app-service/publish-succeeded-windows.png":::

1. Click on the site link to verify your app works as expected in Azure.

   ![Screenshot of web application.](media/deploy-app-service/web-application-running2.png)

1. The publishing profile is saved with all the details you selected, such as the resource group and app service.

1. To deploy again with the same publishing profile, use the **Publish** button, the **Publish** button on the **Web Publish Activity** window, or right-click on the project in **Solution Explorer** and choose the **Publish** item on the context-menu.

:::moniker-end

:::moniker range=">=vs-2022"

1. Right-click your project in **Solution Explorer** and choose **Publish**.
1. On the **Publish** dialog, choose the **Azure** target.

   ![Screenshot of Publish wizard.](media/deploy-app-service/vs-2022/publish-choices.png)

1. On the **Specific target** tab, choose the appropriate deployment target, such as **App Service (Windows)** or **App Service (Linux)**, depending on your container type.

   ![Screenshot of Specific target tab of Publish wizard.](media/deploy-app-service/vs-2022/publish-app-service-linux.png)
   
1. If you are not signed in to the right Azure account with the subscription you want to use, sign in by using the button at the top left of the **Publish** window.

1. You can use an existing app service or create a new one by clicking on the **Create new Azure App Service** link. Find your existing app service in the treeview by expanding its resource group, or change the **View** setting to **Resource type** to sort by type.

   ![Screenshot showing choosing an App Service.](media/deploy-app-service/vs-2022/publish-app-service-linux-2.png)

1. If you create a new one, a resource group and app service will be generated in Azure. You can change the names if desired, as long as they are unique.

   ![Screenshot showing creating an App Service.](media/deploy-app-service/vs-2022/publish-app-service-linux-3.png)

1. You can accept the default hosting plan or change the hosting plan now, or later in the Azure portal. The default is `S1` (small) in one of the supported regions. To create a hosting plan, choose **New** next to the **Hosting Plan** dropdown. The **Hosting Plan** window appears.

   ![Screenshot showing hosting plan options.](media/deploy-app-service/vs-2022/hosting-plan.png)

   You can view the details about these options at [Azure App Service plan overview](/azure/app-service/overview-hosting-plans).

1. Once you're done selecting or creating these resources, choose **Finish**. Your container is deployed to Azure in the resource group and app service you selected. This process takes a bit of time. When it's completed, the **Publish** tab shows information about what was published, including the site URL.

   :::image type="content" source="media/deploy-app-service/vs-2022/publish-succeeded-linux.png" alt-text="Screenshot of publish tab." lightbox="media/deploy-app-service/vs-2022/publish-succeeded-linux.png":::

1. Click on the site link to verify your app works as expected in Azure.

   ![Screenshot of web application.](media/deploy-app-service/web-application-running2.png)

1. The publishing profile is saved with all the details you selected, such as the resource group and app service.

1. To deploy again with the same publishing profile, use the **Publish** button, the **Publish** button on the **Web Publish Activity** window, or right-click on the project in **Solution Explorer** and choose the **Publish** item on the context-menu.

:::moniker-end

## View container settings

In the [Azure portal](https://portal.azure.com), you can open your deployed App Service.

You can view settings for your deployed App Service by opening the **Container settings** menu (when you are using Visual Studio 2019 version 16.4 or later).

![Screenshot of Container Settings menu in the Azure portal.](media/deploy-app-service/container-settings-menu.png)

From there, you can view the container information, view or download logs, or set up continuous deployment. See [Azure App Service Continuous Deployment CI/CD](/azure/app-service/containers/app-service-linux-ci-cd).

## Clean up resources

To remove all Azure resources associated with this tutorial, delete the resource group using the [Azure portal](https://portal.azure.com). To find the resource group associated with a published web application, choose **View** > **Other Windows** > **Web Publish Activity**, and then choose the gear icon. The **Publish** tab opens, which contains the resource group.

In the Azure portal, choose **Resource groups**, select the resource group to open its details page. Verify that this is the correct resource group, then choose **Remove resource group**, type the name, and choose **Delete**.

## Next steps

Learn more about [Azure App Service](/azure/app-service/overview).

## See also

[Deploy to Azure Container Registry](hosting-web-apps-in-docker.md)
