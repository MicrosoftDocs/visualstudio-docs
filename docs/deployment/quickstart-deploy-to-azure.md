---
title: Publish to Azure App Service
ms.custom: ""
ms.date: "06/20/2018"
ms.technology: vs-ide-deployment
ms.topic: "quickstart"
helpviewer_keywords:
  - "deployment, website"
ms.assetid: fc82b1f1-d342-4b82-9a44-590479f0a895
author: mikejo5000
ms.author: mikejo
manager: douge
ms.workload:
  - "azure"
---
# Publish a web app to Azure App Service using Visual Studio

You can use the **Publish** tool to publish ASP.NET, ASP.NET Core, Node.js, and .NET Core apps to Azure App Service. For Python apps, follow the steps on [Python - Publishing to Azure App Service](../python/publishing-python-web-applications-to-azure-from-visual-studio.md).

[!INCLUDE [quickstart-prereqs-azure](includes/quickstart-prereqs-azure.md)]

## Publish to Azure App Service

1. In Solution Explorer, right-click the project and choose **Publish** (or use the **Build** > **Publish** menu item).

    ![Choose Publish](../deployment/media/quickstart-publish-aspnet.png "Choose Publish")

1. If you have previously configured any publishing profiles, the **Publish** pane appears. Click **Create new profile**.

1. In the **Pick a publish target** dialog box, choose **App Service**.

    ![Choose Azure App Service](../deployment/media/quickstart-publish-azure.png "Choose Azure App Service")

1. Select **Publish**. The **Create App Service** dialog box appears.

    ![Create App Service](../deployment/media/quickstart-publish-settings-app-service.png "Create Azure App Service")

1. If you are not signed into Visual Studio, sign in, and then the default app service settings populate the fields. The profile publish settings dialog box opens.

    ![Choose Folder](../deployment/media/quickstart-publish-settings-web.png "Choose Folder")

    In this dialog box, you can select the subscription you are using, select or create an Azure resource group, etc.

1. Select **Create**. Visual Studio deploys the app to your Azure App Service, and the web app loads in your browser. In the Summary of the **Publish** pane, you see the Site URL for the new Azure App Service. You can navigate to the URL with **Ctrl**+click.

## Next steps

In this quickstart, you learned how to use Visual Studio to create a publishing profile for deployment to Azure. You can also configure a publishing profile by importing publish settings from Azure App Service.

> [!div class="nextstepaction"]
> [Import publish settings and deploy to Azure](tutorial-import-publish-settings-azure.md)
