---
title: "Deploy to Azure App Service - Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/22/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
helpviewer_keywords: 
  - "deployment, website"
ms.assetid: fc82b1f1-d342-4b82-9a44-590479f0a895
caps.latest.revision: 1
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Deploy an ASP.NET, ASP.NET Core, or .NET Core app to Azure App Service using Visual Studio

You can use the **Publish** dialog box to publish ASP.NET, ASP.NET Core, and .NET Core apps to Azure App Service.

## Create a new project 

1. In Visual Studio, choose **File > New Project**.

1. Under **Visual C#** or **Visual Basic**, choose **Web**, and then in the middle pane choose either **ASP.NET Web Application (.NET Framework)** or (C# only) **ASP.NET Core Web Application (.NET Core)**, and then click **OK**.

1. Choose **MVC**, make sure that **No Authentication** is selected, and then click **OK**.

1. Type a name like **MyWebApp** and click **OK**.

    Visual Studio creates the project.

1. Choose **Build > Build Solution** to build the project.

## Deploy to Azure App Service

1. In Solution Explorer, right-click the project and choose **Publish**.

    ![Choose Publish](../deployment/media/quickstart-publish-aspnet.png "Choose Publish")

1. In the **Publish** pane, choose **Microsoft Azure App Service**.

    ![Choose Azure App Service](../deployment/media/quickstart-publish-azure.png "Choose Azure App Service")

1. Click **Publish**.

    The **Create App Service** dialog box appears.

    ![Create App Service](../deployment/media/quickstart-publish-settings-app-service.png "Create Azure App Service")
    
1. If you are not signed into Visual Studio, sign in and the default app service settings populate the fields.

    The profile publish settings dialog box opens.

    ![Choose Folder](../deployment/media/quickstart-publish-settings-web.png "Choose Folder")

    In this dialog box, you can select the subscription you are using, select or create an Azure resource group, etc.

1. Click **Create**.

    Visual Studio deploys the app to your Azure App Service, and the web app loads in your browser.

    In the Summary of the **Publish** pane, you see the Site URL for the new Azure App Service.

## Next steps

- [Deploy a .NET Core Application with the Publish tool](https://docs.microsoft.com/en-us/dotnet/core/deploying/deploy-with-vs)
- [Deploy an ASP.NET Core app to Azure](https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs)
- [Deploy ASP.NET to IIS](https://docs.microsoft.com/en-us/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45)
