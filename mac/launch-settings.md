---
title: "launchSettings.json support"
description: This document covers the support for launchSettings.json in Visual Studio for Mac
author: sayedihashimi
ms.author: sayedha
ms.date: 09/18/2019
ms.assetid: a556f9d7-86a8-408e-aa54-392584845889
---

# launchSettings.json

When you're developing ASP.NET Core projects, you can configure how your project should be started in development scenarios by customizing the contents of the launchSettings.json file. In Visual Studio for Mac, you can update this file by using the project options UI or by directly editing it. This file is the same configuration file that you can use when running Visual Studio on Windows or from the command line through `dotnet`. This file is stored in your project under the Properties folder.

For more detailed info, see [Use multiple environments in ASP.NET Core](/aspnet/core/fundamentals/environments). In this article, we'll cover how to update this file in Visual Studio for Mac.

## Update the start configuration by using Visual Studio for Mac

You can directly edit the launchSettings.json file in Visual Studio for Mac, or you can use project options to edit it. To get to the project options, right-click your project and select **Options**.

![Project shortcut menu with "Options" selected](media/vsmac-ctx-proj-options.png)

Select **Run** > **Configurations** > **Default**.

!["Run," "Configurations," and "Default" in project options](media/vsmac-run-config-default.png)

Primarily, you'll configure two things here:

 - Environment variables
 - App URL for the project

## Configure environment variables

You can use the grid to specify values for environment variables. These environment variables will be set when you start your application in Visual Studio for Mac. When you're developing ASP.NET Core applications, you should be aware of the special `ASPNETCORE_ENVIRONMENT` environment variable. To learn more, see [Use multiple environments in ASP.NET Core](/aspnet/core/fundamentals/environments).


## Configure the start URL

To configure the URL that the application will be started with, go to the **ASP.NET Core** tab.

![Application URL in project options](media/vsmac-run-config-default-aspnetcore.png)

Here you can specify the URL that the application will listen on when it's started.