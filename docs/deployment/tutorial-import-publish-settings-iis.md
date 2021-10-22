---
title: "Publish to IIS by importing publish settings"
description: "Create and import a publishing profile to deploy an application from Visual Studio to IIS"
ms.date: 08/27/2021
ms.topic: tutorial
helpviewer_keywords:
  - "deployment, publish settings"
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# Get a publish profile from IIS and import the profile in Visual Studio

You can use the **Publish** tool to import publish settings and then deploy your app. In this article, we use publish settings for IIS.

These steps apply to ASP.NET, ASP.NET Core, and .NET Core apps in Visual Studio.

## Prerequisites

You need [Visual Studio](https://www.visualstudio.com/downloads) installed with the ASP.NET and web development workload.

If you've already installed Visual Studio:

* Install the latest updates in Visual Studio by selecting **Help** > **Check for Updates**.
* Add the workload by selecting **Tools** > **Get Tools and Features**.

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
- For ASP.NET Core, in IIS you need to make sure that the Application pool field for the **DefaultAppPool** is set to **No Managed Code**.
- Verify that the version of ASP.NET used in your app is the same as the version you installed on the server. For your app, you can view and set the version in the **Properties** page. To set the app to a different version, that version must be installed.
- If the app tried to open, but you see a certificate warning, choose to trust the site. If you already closed the warning, you can edit the *.pubxml file in your project and add the following element: `<AllowUntrustedCertificate>true</AllowUntrustedCertificate>`. This setting is for testing only!
- If the app does not start from Visual Studio, start the app in IIS to test that it deployed correctly.