---
title: "Publish to IIS by importing publish settings"
description: Create and import a publishing profile (.pubxml file) to deploy ASP.NET and ASP.NET Core web applications from Visual Studio to IIS.
ms.date: 10/3/2025
ms.topic: tutorial
helpviewer_keywords:
  - "deployment, publish settings"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: deployment
---
# Get publish settings from IIS and import into Visual Studio

You can use the **Publish** tool to import publish settings and then deploy your app. In this article, we use publish settings for IIS.

These steps apply to ASP.NET and ASP.NET Core web applications.

> [!NOTE]
> A publish settings file (*\*.publishsettings*) is different than a publishing profile (*\*.pubxml*). A publish settings file is created in IIS, and then it can be imported into Visual Studio. Visual Studio creates the publishing profile.

## Prerequisites

* [Visual Studio](https://www.visualstudio.com/downloads) installed with the ASP.NET and web development workload. If you've already installed Visual Studio:

  * Install the latest updates in Visual Studio by selecting **Help** > **Check for Updates**.
  * Add the workload by selecting **Tools** > **Get Tools and Features**.

* On your server, you must be running Windows Server 2012 or greater, and you must have the [IIS Web Server role](/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45#solution) correctly installed (required to generate the publish settings file (`.publishsettings`). ASP.NET 4.5 or the correct version of ASP.NET Core must also be installed on the server. The steps in this tutorial were tested in Windows Server 2022 and IIS 10.

  * To set up ASP.NET Core, see [Host ASP.NET Core on Windows with IIS](/aspnet/core/publishing/iis?tabs=aspnetcore2x#iis-configuration). For ASP.NET Core, make sure you configure the Application Pool to use **No Managed Code**, as described in the article.

  * To set up ASP.NET 4.5, see [IIS 8.0 Using ASP.NET 3.5 and ASP.NET 4.5](/iis/get-started/whats-new-in-iis-8/iis-80-using-aspnet-35-and-aspnet-45).

  > [!NOTE]
  > IIS on Windows does not support generating the publish settings. You can, however, still publish to IIS using the Publish tool in Visual Studio.

## Install and configure Web Deploy on Windows Server

[!INCLUDE [install-web-deploy-with-hosting-server](../deployment/includes/install-web-deploy-with-hosting-server.md)]

## Create the publish settings file in IIS on Windows Server

[!INCLUDE [create-publish-settings-iis](../deployment/includes/create-publish-settings-iis.md)]

## Import the publish settings in Visual Studio and deploy

[!INCLUDE [import-publish-settings](../deployment/includes/import-publish-settings-vs.md)]

After the app deploys successfully, it should start automatically.

## Common issues

First, check the Output window in Visual Studio for status information, and check your error messages. In addition:

- If you can't connect to the host using the host name, try the IP address instead.
- Make sure the required ports are open on the remote server.
- For ASP.NET Core, in IIS you need to make sure that the Application pool field (.NET CLR Version on IIS 10) for the **DefaultAppPool** is set to **No Managed Code**.
- Verify that the version of ASP.NET used in your app is the same as the version you installed on the server. For your app, you can view and set the version in the **Properties** page. To set the app to a different version, that version must be installed.
- If the app tried to open, but you see a certificate warning, choose to trust the site. If you already closed the warning, you can edit the *.pubxml file in your project and add the following element: `<AllowUntrustedCertificate>true</AllowUntrustedCertificate>`. This setting is for testing only!
- If the app does not start from Visual Studio, start the app in IIS to test that it deployed correctly.

## Related content

[Host ASP.NET Core on Windows with IIS](/aspnet/core/host-and-deploy/iis)
