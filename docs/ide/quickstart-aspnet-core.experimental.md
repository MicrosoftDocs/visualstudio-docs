---
title: "Use Visual Studio to create an ASP.NET Core web app in C#"
description: "Learn how to create an ASP.NET Core web app in Visual Studio with C#, step-by-step."
ms.custom: mvc
ms.date: 07/30/2018
ms.prod: visual-studio-dev15
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: quickstart
author: TerryGLee
ms.author: tglee
manager: douge
dev_langs:
  - CSharp
ms.workload:
  - "aspnet"
  - "dotnetcore"
experimental: false
experiment_id: eb51ee6c-71a8-45
---
# Quickstart: Use Visual Studio to create your first ASP.NET Core web app

In this 5-10 minute introduction to how to use Visual Studio, you'll create a simple "Hello World" web app by using an ASP.NET project template and the C# programming language.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=button+cta&utm_content=download+vs2017) page to install it for free.

## Create a project

First, you'll create an ASP.NET Core web application project. Here's how.

1. Open Visual Studio 2017.

1. From the top menu bar, choose **File** > **New** > **Project**.

1. In the left pane of the **New Project** dialog box, expand **Visual C#**, and then choose **.NET Core**. In the middle pane, choose **ASP.NET Core Web Application**. Then, name your file `HelloWorld` and choose **OK**.

1. In the **New ASP.NET Core Web Application** dialog box, verify that **ASP.NET Core 2.0** appears in the top drop-down menu. Then, choose **Web Application** and choose **OK**.

  ![View the animated .gif file that shows how to create a C# ASP.NET Core project in Visual Studio](../ide/media/csharp-aspnet-animated-create-project.gif)

  Soon after, Visual Studio opens your project file.

   > [!NOTE]
   > If you don't see the **.NET Core** project template category, choose the **Open Visual Studio Installer** link in the left pane.
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

1. In the **Solution Explorer**, expand the **Pages** folder, and then choose **About.cshtml**.

   This file corresponds to a page that's named **About** in the web app.

   ![The About page in the web app](../ide/media/csharp-aspnet-about-page.png)

1. Change the "additional information" text to read "**Hello World!**".

1. In the **Solution Explorer**, expand **About.cshtml**, and then choose **About.cshtml.cs**.

1. Change the "application description" message text to read "**What's my message?**".

1. Choose **IIS Express** or press **Ctrl**+**F5** to run the app and open it in a web browser.

  ![View the animated .gif file that shows how to create and run a C# ASP.NET Core web app in Visual Studio](../ide/media/csharp-aspnet-animated-hello-world.gif)

   > [!NOTE]
   > If you get an error message that says, **Unable to connect to web server 'IIS Express'**, close Visual Studio and then open it by using the **Run as administrator** option from the right-click or context menu. Then, run the application again.

1. Verify that the **About** page includes your updated text.

Congratulations on completing this Quickstart! We hope you learned a little bit about C#, ASP.NET Core, and the Visual Studio IDE (integrated development environment).

## Next steps

To learn more, continue with the following tutorials:

> [!div class="nextstepaction"]
> [Get started with C# and ASP.NET in Visual Studio](tutorial-csharp-aspnet-core.md)
>
> [!div class="nextstepaction"]
> [Get started with ASP.NET Core MVC and Visual Studio](/aspnet/core/tutorials/first-mvc-app/start-mvc?tabs=aspnetcore2x)

## See also

[Publish your web app to Azure App Service by using Visual Studio](..//deployment/quickstart-deploy-to-azure.md)
