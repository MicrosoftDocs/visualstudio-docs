---
title: Publish to Azure App Service
ms.date: 01/17/2019
helpviewer_keywords:
  - "deployment, website"
ms.assetid: 8524a4c5-97a9-41ac-a2a0-034efb9bfc57
author: sayedihashimi
ms.author: sayedha
manager: unniravindranathan
ms.prod: visual-studio-mac
ms.custom: video
ms.workload:
  - "azure"
---
# Publish a Web app to Azure App Service using Visual Studio for Mac

You can use the Publish tool to publish ASP.NET Core apps to Azure App Service.

## Prerequisites

- [Visual Studio 2017 for Mac](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs4mac2017) installed with ASP.NET Core enabled.
- An Azure Subscription. If you do not already have a subscription, [sign up for free](https://azure.microsoft.com/free/dotnet/), which includes $200 in credit for 30 days and 12 months of popular free services.
- An ASP.NET Core project. If you don’t already have a project, you can [create a new one](/visualstudio/mac/create-new-projects?view=vsmac-2017).

## Publish to Azure App Service

 1. In the Solution Pad, right-click the project and choose **Publish**.

    ![Publish context menu](media/publish-context-menu.png)

 2. If you have previously published this project to Azure App Service, you'll see the publish profile in the menu. Select that publish profile to start the publish process.

 3. To publish this project to App Service for the first time, select **Publish to Azure**

    ![Publish to App Service context menu](media/publish-to-azure-context-menu.png)

 4. The **Publish to Azure App Service** dialog appears, and any existing App Services are shown. To publish to an existing App Service, select the App Service in the list and then click **Publish**.

    ![Publish to Azure App Service dialog](media/publish-to-app-service-dialog.png)

 5. To create a new App Service, click the **New** button.

    ![Publish to App Service Dialog](media/publish-to-app-service-dialog-new-selected.png)

 6. The **New App Service** dialog appears. In this dialog you can configure the settings for your new App Service.

    ![New App Service dialog](media/publish-new-app-service.png)

    There are a few options to consider customizing here. The name of the App Service will default to the project name. If the name is not available a warning sign will appear on the right hand side of the input field. The name of the App Service will be used in the URL of your website, so the name must be valid to be used in a URL.

    You can change the subscription that the App Service will be associated with using the **Subscription** dropdown.

    You can select an existing **Resource Group** using the dropdown or you can create a new one with the **+** button.

    For the App Service plan, select an existing one, or create a new one by selecting the **Custom** radio button.

    To create your new App Service, and publish your project to it, click **Create**.

    After clicking **Create** the **New App Service** dialog will be dismissed, and you should see the following message indicating that creating the App Service has started.

      ![Create App Service Message](media/publish-create-app-service-message.png)

    After clicking **OK** the message is dismissed, and you can continue working on your project. You can watch the status of the publish process with the status bar at the top of the IDE. Once your web app is successfully published, the site is opened with your default browser.

## Related Video

> [!Video https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Visual-Studio-for-Mac-Publish-to-Azure/player]
