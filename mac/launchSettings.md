---
title: "launchSettings.json support"
description: This document covers the support for launchSettings.json in Visual Studio for Mac
author: sayedihashimi
ms.author: sayedha
ms.date: 09/18/2019
ms.assetid: a556f9d7-86a8-408e-aa54-392584845889
---

# launchSettings.json

When developing ASP.NET Core projects you can configure how your project should be started in development scenarios by customizing the contents of the `launchSettings.json` file. In Visual Studio for Mac you can update this file by using the Project Options UI or by directly editing the `launchSettings.json` file. This is the same configuration file that can be used when running Visual Studio on Windows or from the command line using `dotnet`. This file is stored in your project under the `Properties` folder.

For more detailed info on this file go to [Use multiple environments in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments). In this doc we will cover how to update this file in Visual Studio for Mac.

## Updating start configuration using Visual Studio for Mac

You can directly edit the `launchSettings.json` in Visual Studio for Mac or you can use Project Options to edit it. To get to the Project Options, right-click your project and select Options. See the image below.

![project context menu options selected](media/vsmac-ctx-proj-options.png)

Once you get to this dialog go to Run > Configurations > Default.

![run configurations default](media/vsmac-run-config-default.png)

There are primarily two things that you'll configure here.

 - Environment variables that are set on start
 - Start URL for the project

## Configure environment variables

To configure environment variables use the grid on this dialog to manage environment variables that are set when the application is launched. When developing ASP.NET Core applications, you should be aware of the special `ASPNETCORE_ENVIRONMENT` value. To learn more about that see [Use multiple environments in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments). This should typically be set to 'Development'.


## Configure start URL

To configure the URL that the application will be launched with go to the ASP.NET Core tab.

![proj options start url](media/vsmac-run-config-default-aspnetcore.png)

Here you can specify the URL(s) that the application will listen on when it is started.