---
title: "Use Visual Studio to create an ASP.NET Core web app in C#"
description: "Learn how to create a simple Hello World web app in Visual Studio with C# and ASP.NET Core, step-by-step."
ms.custom: mvc
ms.date: 10/29/2018
ms.prod: visual-studio-dev15
ms.prod: visual-studio-dev15
ms.topic: quickstart
author: TerryGLee
ms.author: tglee
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "aspnet"
  - "dotnetcore"
experimental: false
experiment_id: "bef9e21b-00d0-4b"
---
# Quickstart: Use Visual Studio to create your first ASP.NET Core web app

In this 5-10 minute introduction to how to use Visual Studio, you'll create a simple "Hello World" web app by using an ASP.NET project template and the C# programming language.

## Before you begin

### Install Visual Studio

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=button+cta&utm_content=download+vs2017) page to install it for free.

### Update Visual Studio

If you've already installed Visual Studio, make sure that you are running the most recent release. For more information about how to update your installation, see the [Update Visual Studio 2017 to the most recent release](../install/update-visual-studio.md) page.

### Choose your theme (optional)

This quickstart tutorial includes screenshots that use the dark theme. If you aren't using the dark theme but would like to, see the [Personalize the Visual Studio IDE and Editor](quickstart-personalize-the-ide.md) page to learn how.

## Create a project

To start, you'll create an ASP.NET Core web application project. Here's how.

1. Open Visual Studio 2017.

1. From the top menu bar, choose **File** > **New** > **Project**.

1. In the left pane of the **New Project** dialog box, expand **Visual C#**, and then choose **.NET Core**. In the middle pane, choose **ASP.NET Core Web Application**. Then, name your file `HelloWorld` and choose **OK**.

1. In the **New ASP.NET Core Web Application** dialog box, select **ASP.NET Core 2.0** or later from the top drop-down menu, and then select **Web Application**.

   > [!NOTE]
   > If you don't see **ASP.NET Core 2.0** or later from the top drop-down menu, make sure that you are running the most recent release of Visual Studio. For more information about how to update your installation, see the [Update Visual Studio 2017 to the most recent release](../install/update-visual-studio.md) page.

   ![View the animated .gif file that shows how to create a C# ASP.NET Core project in Visual Studio](../ide/media/csharp-aspnet-animated-create-project.gif)

   Soon after, Visual Studio opens your project file.

   > [!NOTE]
   > If you don't see the **.NET Core** project template category, choose the **Open Visual Studio Installer** link in the left pane. (Depending on your display settings, you might have to scroll to see it.)
   >
   > ![Open Visual Studio Installer from the new project dialog box](../ide/media/open-visual-studio-installer.png)
   >
   > The Visual Studio Installer launches. Choose the **ASP.NET and web development** workload, and then choose **Modify**.
   >
   > ![ASP.NET workload in VS Installer](../ide/media/quickstart-aspnet-workload.png)
   >
   > (You might have to close Visual Studio before you can continue installing the new workload.)

## Create and run the app

Next, you'll create and run your "Hello World" web app. Here's how.

1. In Visual Studio, in the **Solution Explorer**, expand the **Pages** folder. Then, choose **About.cshtml**.

   ![Choose the About.cshtml file from the Solution Explorer](../ide/media/csharp-aspnet-about-page-html-file.png)

   This file corresponds to a page that's named **About** in the web app, which runs in a web browser.

   ![The About page in the web app](../ide/media/csharp-aspnet-about-page.png)

1. In the Visual Studio code editor, change the "additional information" text to read "**Hello World!**".

1. In the **Solution Explorer**, expand **About.cshtml**, and then choose **About.cshtml.cs**.

1. Change the "application description" message text to read "**What's my message?**".

1. Choose **IIS Express** or press **Ctrl**+**F5** to run the app and open it in a web browser.

   ![View the animated .gif file that shows how to create and run a C# ASP.NET Core web app in Visual Studio](../ide/media/csharp-aspnet-animated-hello-world.gif)

   > [!NOTE]
   > If you get an error message that says, **Unable to connect to web server 'IIS Express'**, or an error message that mentions an SSL certificate, close Visual Studio. Next, open Visual Studio by using the **Run as administrator** option from the right-click or context menu. Then, run the application again.

1. In the web browser, verify that the **About** page includes your updated text.

1. Close the web browser.

Congratulations on completing this Quickstart! We hope you learned a little bit about C#, ASP.NET Core, and the Visual Studio IDE (integrated development environment).

## Next steps

To learn more, continue with the following tutorial:

> [!div class="nextstepaction"]
> [Get started with C# and ASP.NET in Visual Studio](../get-started/csharp/tutorial-aspnet-core.md)

## See also

[Publish your web app to Azure App Service by using Visual Studio](../deployment/quickstart-deploy-to-azure.md)
