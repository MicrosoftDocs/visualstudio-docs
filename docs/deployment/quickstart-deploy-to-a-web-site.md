---
title: "Publish to a website - Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/22/2017"
ms.technology: vs-ide-deployment
ms.topic: "quickstart"
helpviewer_keywords: 
  - "deployment, website"
ms.assetid: fc82b1f1-d342-4b82-9a44-590479f0a895
author: mikejo5000
ms.author: mikejo
manager: douge
ms.workload: 
  - "multiple"
---
# Publish a web app or a .NET Core app to a web site using the Visual Studio Publish tool

You can use the **Publish** tool to publish ASP.NET apps to a website.

These steps apply to ASP.NET, ASP.NET Core, .NET Core, and Python apps in Visual Studio. For Node.js, the steps are supported but the user interface is different.

## Prerequisites

* You must have Visual Studio 2017 installed and the **ASP.NET** and **.NET Framework** development workload. For a .NET Core app, you also need the **.NET Core** workload.

    If you haven't already installed Visual Studio, install it for free [here](http://www.visualstudio.com).

## Create a new project 

1. In Visual Studio, choose **File > New Project**.

1. Under **Visual C#** or **Visual Basic**, choose **Web**, and then in the middle pane choose either **ASP.NET Web Application (.NET Framework)** or (C# only) **ASP.NET Core Web Application**, and then click **OK**.

1. Choose **MVC** (or choose **Web Application (Model-View-Controller)** for .NET Core), make sure that **No Authentication** is selected, and then click **OK**.

1. Type a name like **MyWebApp** and click **OK**.

    Visual Studio creates the project.

1. Choose **Build > Build Solution** to build the project.

## Publish to a web site

1. In Solution Explorer, right-click the project and choose **Publish**.

    ![Choose Publish](../deployment/media/quickstart-publish-aspnet.png "Choose Publish")

1. If you have previously configured any publishing profiles, the **Publish** pane appears. Click **Create new profile**.

1. In the **Pick a publish target** dialog box, choose **IIS, FTP, etc**.

    ![Choose IIS, FTP, etc.](../deployment/media/quickstart-publish-iis-ftp.png "Choose IIS, FTP, etc.")

1. Click **Publish**.

    The profile publish settings dialog box opens.

    ![Choose Folder](../deployment/media/quickstart-publish-settings-web.png "Choose Folder")

1. In the **Publish method** field, choose a method such as **Web Deploy** or **FTP**.

    The settings that you see next correspond to your publishing method. Web Deploy simplifies deployment of Web applications and Web sites to IIS servers, and must be installed as an application on the server. Use the [Web Platform Installer](https://www.microsoft.com/web/downloads/platform.aspx) to install it.

1. Configure required settings for the publish method and click **Validate Connection**.

    If the server or target is available and your settings are correct, you will see a message that indicates the connection is validated, and you are ready to publish.

    ![Validate your connection](../deployment/media/quickstart-publish-web-deploy.png "Validate your connection")

1. If you want to configure other deployment settings, click **Settings**.

    You can configure options such as whether to deploy a Debug or Release configuration, and then click **Save**. If you are debugging remotely, a Debug configuration is required.

1. To publish, click **Publish**.

    The Output window shows deployment progress and results.

## Next steps

In this quickstart, you learned how to use Visual Studio to create a publishing profile. You can also configure a publishing profile by importing publish settings.

> [!div class="nextstepaction"]
> [Import publish settings and deploy to IIS](tutorial-import-publish-settings-iis.md)
