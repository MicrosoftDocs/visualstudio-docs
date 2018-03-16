---
title: "Publish to Azure App Service - Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/22/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: ""
ms.topic: "quickstart"
helpviewer_keywords: 
  - "deployment, website"
ms.assetid: fc82b1f1-d342-4b82-9a44-590479f0a895
caps.latest.revision: 1
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
ms.workload: 
  - "azure"
---
# Publish an ASP.NET or ASP.NET Core app to Azure App Service using Visual Studio

You can use the **Publish** tool to publish ASP.NET, ASP.NET Core, Python, Node.js, and .NET Core apps to Azure App Service.

If you do not already have an Azure account, you can [sign up here](https://azure.microsoft.com/free/?ref=microsoft.com&utm_source=microsoft.com&utm_medium=doc&utm_campaign=visualstudio).

## Create a new project 

1. In Visual Studio, choose **File > New Project**.

1. Under **Visual C#** or **Visual Basic**, choose **Web**, and then in the middle pane choose either **ASP.NET Web Application (.NET Framework)** or (C# only) **ASP.NET Core Web Application**, and then click **OK**.

1. Choose **MVC**, make sure that **No Authentication** is selected, and then click **OK**.

1. Type a name like **MyWebApp** and click **OK**.

    Visual Studio creates the project.

1. Choose **Build > Build Solution** to build the project.

## Publish to Azure App Service

1. In Solution Explorer, right-click the project and choose **Publish**.

    ![Choose Publish](../deployment/media/quickstart-publish-aspnet.png "Choose Publish")

1. In the **Publish** pane, choose **Microsoft Azure App Service**.

    ![Choose Azure App Service](../deployment/media/quickstart-publish-azure.png "Choose Azure App Service")

1. Click **Publish**.

    The **Create App Service** dialog box appears.

    ![Create App Service](../deployment/media/quickstart-publish-settings-app-service.png "Create Azure App Service")
    
1. If you are not signed into Visual Studio, sign in, and then the default app service settings populate the fields.

    The profile publish settings dialog box opens.

    ![Choose Folder](../deployment/media/quickstart-publish-settings-web.png "Choose Folder")

    In this dialog box, you can select the subscription you are using, select or create an Azure resource group, etc.

1. Click **Create**.

    Visual Studio deploys the app to your Azure App Service, and the web app loads in your browser.

    In the Summary of the **Publish** pane, you see the Site URL for the new Azure App Service.

## Next steps

- [Deploy an ASP.NET Core app to Azure](/aspnet/core/tutorials/publish-to-azure-webapp-using-vs)
- [Continuous deployment of ASP.NET Core to Azure with Git](/aspnet/core/publishing/azure-continuous-deployment)
