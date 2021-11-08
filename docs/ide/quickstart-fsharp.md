---
title: "Quickstart: Create an ASP.NET Core web service in F#"
description: "Learn how to create an ASP.NET Core web service in Visual Studio with F#, step-by-step."
ms.date: 09/14/2021
ms.topic: quickstart
ms.custom: vs-acquisition
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
dev_langs:
  - FSharp
ms.workload:
  - "aspnet"
  - "dotnetcore"
---
# Quickstart: Use Visual Studio to create your first ASP.NET Core web service in F\#

In this 5-10 minute introduction to F# in Visual Studio, you'll create an F# ASP.NET Core web application.

::: moniker range="vs-2017"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.

::: moniker-end

::: moniker range=">=vs-2019"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.

::: moniker-end

## Create a project

First, you'll create an ASP.NET Core Web API project. The project type comes with template files that constitute a functional web service, before you've even added anything!

::: moniker range="vs-2017"

1. Open Visual Studio.

1. From the top menu bar, choose **File** > **New** > **Project**.

1. In the **New Project** dialog box, in the left pane, expand **Visual F#**, then choose **Web**. In the middle pane, choose **ASP.NET Core Web Application**, then choose **OK**.

   If you don't see the **.NET Core** project template category, choose the **Open Visual Studio Installer** link in the left pane. The Visual Studio Installer launches. Choose the **ASP.NET and web development** workload, then choose **Modify**.

   ![ASP.NET workload in VS Installer](../ide/media/quickstart-aspnet-workload.png)

1. In the **New ASP.NET Core Web Application** dialog box, select **ASP.NET Core 2.1** from the top drop-down menu. (If you don't see **ASP.NET Core 2.1** in the list, install it by following the **Download** link that should appear in a yellow bar near the top of the dialog box.) Choose **OK**.

::: moniker-end

::: moniker range="vs-2019"

1. Open Visual Studio.

1. On the start window, choose **Create a new project**.

1. On the **Create a new project** page, type **f# web** into the search box, and then choose the **ASP.NET Core Web Application** project template. Choose **Next**.

1. On the **Configure your new project** page, enter a name, and then choose **Create**.

1. On the **Create a new ASP.NET Core Web Application** page, select **ASP.NET Core 2.1** from the top drop-down menu, and then choose **Create**.

## Explore the IDE

1. In the **Solution Explorer** toolbar, expand the **Controllers** folder, then choose **ValuesController.fs** to open it in the editor.

   ![Screenshot of the Solution Explorer with the Controllers folder expanded in an F# Web API project.](../ide/media/hello-world-fs-sln-explorer.png)

1. Next, modify the `Get()` member to be the following:

   ```fsharp
   [<HttpGet>]
   member this.Get() =
       let values = [|"Hello"; "World"; "First F#/ASP.NET Core web API!"|]
       ActionResult<string[]>(values)
   ```

The code is straightforward. An F# array of values is bound to the `values` name, and then passed to the ASP.NET Core MVC framework as an `ActionResult`. ASP.NET Core takes care of the rest for you.

It should look like this in the editor:

![Screenshot showing the modified code for the Get member in ValuesController.fs.](../ide/media/hello-world-fs-get-member.png)

## Run the application

1. Press **Ctrl**+**F5** to run the application and open it in a web browser.

1. The page should navigate to the `/api/values` route, but if it does not, enter `https://localhost:44396/api/values` into your browser.

The web browser will now display JSON matching what you typed earlier.

::: moniker-end

::: moniker range=">=vs-2022"

1. Open Visual Studio.

1. On the start window, choose **Create a new project**.

1. In the **Create a new project** window, type **f# web** into the search box, or use the language, platform, and project type filters to refine the list. Select the **ASP.NET Core Web API** project template, and then choose **Next**.

1. In the **Configure your new project** window, enter a **Project name**, and then select **Next**.

1. In the **Additional information** window, verify that **.NET 6.0** appears in the **Framework** field, and then choose **Create**.

## Explore the IDE

1. In the **Solution Explorer** toolbar, expand the **Controllers** folder, then choose **WeatherForecast.fs** to open it in the editor.

   :::image type="content" source="media/vs-2022/hello-world-fs-sln-explorer.png" alt-text="Screenshot showing the Solution Explorer with the Controllers folder expanded in an F# Web API project.":::

1. Next, modify the existing `Get()` member example to match the following code:

   ```fsharp
   [<HttpGet>]
   member this.Get() =
       let values = [|"Hello"; "World"; "First F#/ASP.NET Core web API!"|]
       ActionResult<string[]>(values)
   ```

The code is straightforward. An F# array of values is bound to the `values` name, and then passed to the ASP.NET Core MVC framework as an `ActionResult`. ASP.NET Core takes care of the rest for you.

It should look like this in the editor:

:::image type="content" source="media/vs-2022//hello-world-fs-get-member.png" alt-text="Screenshot showing the modified code for the Get member in WeatherForecast.fs.":::

## Run the application

Press **Ctrl**+**F5** to run the application and open it in a web browser. 

> [!NOTE]
> If you get a message that asks if you want to accept an IIS SSL Express certificate, choose **Yes** to view the code in a web browser, and then choose **Yes** if you receive a follow-up security warning message.

Visual Studio launches a browser window that displays JSON matching the "Hello World" message you added earlier.

::: moniker-end

## Next steps

Congratulations on completing this Quickstart! We hope you learned something about F#, ASP.NET Core, and the Visual Studio IDE. To see the app running on a public server, select the following button.

> [!div class="nextstepaction"]
> [Deploy the app to Azure App Service](../deployment/quickstart-deploy-to-azure.md)

To learn more about F#, check out the official [F# Guide](/dotnet/fsharp/index).
