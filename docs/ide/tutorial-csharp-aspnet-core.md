---
title: "Get started with C# and ASP.NET Core in Visual Studio"
description: "Learn how to create an ASP.NET Core web app in Visual Studio with C#, step-by-step."
ms.custom: ""
ms.date: 08/08/2018
ms.prod: visual-studio-dev15
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: tutorial
ms.devlang: CSharp
author: TerryGLee
ms.author: tglee
manager: douge
dev_langs:
  - CSharp
ms.workload:
  - "aspnet"
  - "dotnetcore"
---
# Tutorial: Get started with C# and ASP.NET Core in Visual Studio

In this tutorial for C# development with ASP.NET Core using Visual Studio, you'll create a C# ASP.NET Core web app, add code to it, explore some features of the IDE, and run the app.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=button+cta&utm_content=download+vs2017) page to install it for free.

## Start developing

Ready to start developing? Let's go!

### Create a project

First, you'll create a ASP.NET Core project. The project type comes with all the template files you'll need, before you've even added anything.

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project**. This project template contains all the files you need for a website, before you've even added anything!

3. In the **New Project** dialog box in the left pane, expand **Visual C#**, expand **Web**, and then choose **.NET Core**. In the middle pane, choose **ASP.NET Core Web Application**. Then, name the file *MyCoreApp* and choose **OK**.

   ![ASP.NET Core Web Application project template in the New Project dialog box in the Visual Studio IDE](../ide/media/new-project-csharp-aspnet-mycoreapp.png)

#### Add a workload (optional)

If you don't see the **ASP.NET Core Web Application** project template, you can get it by adding the **ASP.NET and web development** workload. You can add this workload in one of the two following ways, depending on which Visual Studio 2017 updates are installed on your machine.

##### Option 1: Use the New Project dialog box

1. Select the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.

   ![Select the Open Visual Studio Installer link from the New Project dialog box](../ide/media/open-visual-studio-installer.png)

2. The Visual Studio Installer launches. Choose the **ASP.NET and web development** workload, and then choose **Modify**.

   ![.NET Core cross-platform development workload in the Visual Studio Installer](../ide/media/quickstart-aspnet-workload.png)

   (You might have to close Visual Studio before you can continue installing the new workload.)

##### Option 2: Use the Tools menu bar

1. Cancel out of the **New Project** dialog box. Then, from the top menu bar, choose **Tools** > **Get Tools and Features**.

2. The Visual Studio Installer launches. Choose the **ASP.NET and web development** workload, and then choose **Modify**.

   (You might have to close Visual Studio before you can continue installing the new workload.)

#### Add a project template

1. In the **New ASP.NET Core Web Application** dialog box, choose the **Web Application (Model-View-Controller)** project template.

2. Select **ASP.NET Core 2.0** from the top drop-down menu. (If you don't see **ASP.NET Core 2.0** in the list, install it by following the **Download** link that should appear in a yellow bar near the top of the dialog box.) Choose **OK**.

   ![New ASP.NET Core Web Application dialog box](../ide/media/new-project-csharp-aspnet-web-app-mvc.png)

### Tour your solution

 1. The project template creates a solution with a single ASP.NET Core project that is named **MyCoreApp**. Expand the project node to expose its contents.

    ![ASP.NET Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-explorer-mycoreapp.png)

 2. Open the *HomeController.cs* file from the **Controllers** folder.

     ![HomeController.cs file in the Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-explorer-home-controller.png)

 3. View the *HomeController.cs*

     ![HomeController.cs in the Visual Studio code window](../ide/media/csharp-aspnet-home-controller-code.png)

 4. The project also has a **Views** folder that contains other folders that map to each controller (as well as one for **Shared** views). For example, the view CSHTML file (an extension of HTML) for the */Home/About* path would be at *Views/Home/About.cshtml*. Open that file.

     ![About.cshtml file in the Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-explorer-view-about.png)

 5. This CSHTML file uses the Razor syntax to render HTML based on a combination of standard tags and inline C#.

     ![About.cshtml in the Visual Studio code window](../ide/media/csharp-aspnet-about-cshtml-code.png)

   >[!NOTE]
   > To learn more about this, see the [Get started with C# and ASP.NET using the Razor syntax](/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c) page.

 6. The solution also contains a *wwwroot* folder that is the root for your website. You can put static site content, such as CSS, images, and JavaScript libraries, directly at the paths you'd want them to be at when the site is deployed.

     ![wwwroot folder in the Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-wwwroot.png)

 7. There are also a variety of configuration files that serve to manage the project, its packages, and the application at runtime. For example, the default application [configuration](/aspnet/core/fundamentals/configuration) is stored in *appsettings.json*. However, you can override some/all of these settings on a per-environment basis, such as by providing an *appsettings.Development.json* file for the **Development** environment.

     ![Configuration files in the Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-explorer-config-files.png)

## Run and debug the application

1. Choose the **IIS Express** button in the IDE to build and run the app in Debug mode. (Alternatively, press **F5**, or choose **Debug > Start Debugging** from the menu bar.)

   ![Select the IIS Express button in Visual Studio](../ide/media/csharp-aspnet-iis-express-button.png)

  > [!NOTE]
  > If you get an error message that says **Unable to connect to web server 'IIS Express'**, close Visual Studio and then open it by using the **Run as administrator** option from the right-click or context menu. Then, run the application again.

2. Visual Studio launches a browser window. Select **About**.

   ![Select About in the browser window for your app](../ide/media/csharp-aspnet-browser-page.png)

  Among other things, the **About** page in the browser renders the text that is set in the *HomeController.cs* file.

   ![View the text on the About page](../ide/media/csharp-aspnet-browser-page-about.png)

3. Keep the browser window open and return to Visual Studio. Open *Controllers/HomeController.cs* if it's not already open.

   ![Open the HomeController.cs file from the Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-explorer-home-controller.png)

4. Set a breakpoint in the first line of the **About** method. To do this, click in the margin or set the cursor on the line and press **F9**.

  This line sets some data in the **ViewData** collection that is rendered in the CSHTML page at *Views/Home/About.cshtml*.

   ![Set a breakpoint in the first line of the About method in About.cshtml.  ](../ide/media/csharp-aspnet-home-controller-code-set-breakpoint.png)

5. Return to the browser and refresh the **About** page. This will trigger the breakpoint in Visual Studio.

6. In Visual Studio, mouse over the **ViewData** member to view its data.

   ![View the ViewData member of the About method to see more info](../ide/media/csharp-aspnet-home-controller-view-breakpoint-info.png)

7. Remove the application breakpoint using the same method you used to add it.

8. Open *Views/Home/About.cshtml*.

   ![Select About.cshtml in the Solution Explorer](../ide/media/csharp-aspnet-solution-explorer-view-about.png)

9. Change the text **"additional"** to **"changed"** and save the file.

   ![Change the text that reads "additional" to text that reads "changed"](../ide/media/csharp-aspnet-about-cshtml-code-change.png)

10. Return to the browser window to see the updated text. (Refresh the browser if you don't see the text that you changed.)

    ![Refresh the browser window to see your changed text](../ide/media/csharp-aspnet-browser-page-about-changed.png)

11. Choose the **Stop Debugging** button from the toolbar to stop debugging. (Alternatively, press **Shift**+**F5**, or choose **Debug** > **Stop Debugging** from the menu bar.)

   ![Select the Stop Debugging button on the toolbar](../ide/media/csharp-aspnet-stop-debugging.png)

## Quick answers FAQ

Here's a quick FAQ to introduce you to some key concepts.

### What is C#?

[C#](/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework) is a type-safe and object-oriented programming language that's designed to be both robust and easy to learn.

### What is ASP.NET Core?

ASP.NET Core is an open-source and cross-platform framework for building internet-connected applications, such as web apps and services. ASP.NET Core apps can run on either .NET Core or the .NET Framework. You can develop and run your ASP.NET Core apps cross-platform on Windows, Mac, and Linux. ASP.NET Core is open source at [GitHub](https://github.com/aspnet/home).

### What is Visual Studio?

Visual Studio is an integrated development suite of productivity tools for developers. Think of it as a program you can use to create programs and applications.

## Next steps

Congratulations on completing this tutorial! We hope you learned a little bit about C#, ASP.NET Core, and the Visual Studio IDE. To learn more about creating a web app or website with C# and ASP.NET, see the following content:

> [!div class="nextstepaction"]
> [Create a Razor Pages web app with ASP.NET Core](/aspnet/core/tutorials/razor-pages/?view=aspnetcore-2.1)

## See also

[Publish your web app to Azure App Service by using Visual Studio](..//deployment/quickstart-deploy-to-azure.md)