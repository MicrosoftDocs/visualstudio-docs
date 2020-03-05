---
title: "Publish to IIS by importing publish settings"
description: "Create and import a publishing profile to deploy an application from Visual Studio to IIS"
ms.date: 01/31/2019
ms.topic: tutorial
helpviewer_keywords:
  - "deployment, publish settings"
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Publish an application to IIS by importing publish settings in Visual Studio

You can use the **Publish** tool to import publish settings and then deploy your app. In this article, we use publish settings for IIS, but you can use similar steps to import publish settings for [Azure App Service](../deployment/tutorial-import-publish-settings-azure.md). In some scenarios, use of a publish settings profile can be faster than manually configuring deployment to IIS for each installation of Visual Studio.

These steps apply to ASP.NET, ASP.NET Core, and .NET Core apps in Visual Studio.

In this tutorial, you will:

> [!div class="checklist"]
> * Configure IIS so that you can generate a publish settings file
> * Create a publish settings file
> * Import the publish settings file into Visual Studio
> * Deploy the app to IIS

A publish settings file (*\*.publishsettings*) is different than a publishing profile (*\*.pubxml*) created in Visual Studio. A publish settings file is created by IIS or Azure App Service, or it can be manually created, and then it can be imported into Visual Studio.

> [!NOTE]
> If you just need to copy a Visual Studio publishing profile (\*.pubxml file) from one installation of Visual Studio to another, you can find the publishing profile, *\<profilename\>.pubxml*, in the *\\<projectname\>\Properties\PublishProfiles* folder for managed project types. For websites, look under the *\App_Data* folder. The publishing profiles are MSBuild XML files.

## Prerequisites

::: moniker range=">=vs-2019"

* You must have Visual Studio 2019 installed and the **ASP.NET and web development** workload.

    If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
::: moniker-end

::: moniker range="vs-2017"

* You must have Visual Studio 2017 installed and the **ASP.NET and web development** workload.

    If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
::: moniker-end

* On your server, you must be running Windows Server 2012 or Windows Server 2016, and you must have the [IIS Web Server role](/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45) correctly installed (required to generate the publish settings file (*\*.publishsettings*)). Either ASP.NET 4.5 or ASP.NET Core must also be installed on the server. To set up ASP.NET 4.5, see [IIS 8.0 Using ASP.NET 3.5 and ASP.NET 4.5](/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45). To set up ASP.NET Core, see [Host ASP.NET Core on Windows with IIS](/aspnet/core/publishing/iis?tabs=aspnetcore2x#iis-configuration).

## Create a new ASP.NET project in Visual Studio

1. On the computer running Visual Studio, create a new project.

    Choose the correct template. In this example, choose either **ASP.NET Web Application (.NET Framework)** or (for C# only) **ASP.NET Core Web Application**, and then click **OK**.

    If you don't see the specified project templates, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box. The Visual Studio Installer launches. Install the **ASP.NET and web development** workload.

    The project template you choose (ASP.NET or ASP.NET Core) must correspond to the version of ASP.NET installed on the web server.

1. Choose either **MVC** (.NET Framework) or **Web Application (Model-View-Controller)** (for .NET Core), and make sure that **No Authentication** is selected, and then click **OK**.

1. Type a name like **MyWebApp** and click **OK**.

    Visual Studio creates the project.

1. Choose **Build** > **Build Solution** to build the project.

## Install and configure Web Deploy on Windows Server

[!INCLUDE [install-web-deploy-with-hosting-server](../deployment/includes/install-web-deploy-with-hosting-server.md)]

## Create the publish settings file in IIS on Windows Server

[!INCLUDE [create-publish-settings-iis](../deployment/includes/create-publish-settings-iis.md)]

## Import the publish settings in Visual Studio and deploy

[!INCLUDE [import-publish-settings](../deployment/includes/import-publish-settings-vs.md)]

After the app deploys successfully, it should start automatically. If it does not start from Visual Studio, start the app in IIS. For ASP.NET Core, you need to make sure that the Application pool field for the **DefaultAppPool** is set to **No Managed Code**.

## Next steps

In this tutorial, you created a publish settings file, imported it into Visual Studio, and deployed an ASP.NET app to IIS. You may want an overview of other publishing options in Visual Studio.

> [!div class="nextstepaction"]
> [First look at deployment](../deployment/deploying-applications-services-and-components.md)
