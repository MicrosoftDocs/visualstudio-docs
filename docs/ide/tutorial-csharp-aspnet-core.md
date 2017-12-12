---
title: "Getting started with C# and ASP.NET Core in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "12/11/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "tutorial"
ms.devlang: "CSharp"
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
dev_langs:
  - CSharp
---

# Getting started with C# and ASP.NET in Visual Studio
In this tutorial for C# development for ASP.NET Core using Visual Studio, you'll create a C# ASP.NET Core web app, add code to it, explore some features of the IDE, and run the app.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free.

## Before you begin
Here's a quick FAQ to introduce you to some key concepts.
### What is C#?
[C#](/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework) is a type-safe and object-oriented programming language that's designed to be both robust and easy to learn.
### What is ASP.NET Core?
ASP.NET Core is an open-source and cross-platform framework for building internet-connected applications, such as web apps and services. ASP.NET Core apps can run on either [.NET Core](/net/core/platform) or the .NET Framework. You can develop and run your ASP.NET Core apps cross-platform on Windows, Mac, and Linux. ASP.NET Core is open source at [GitHub](https://github.com/aspnet/home).
### What is Visual Studio?
Visual Studio is an integrated development suite of productivity tools for developers. Think of it as a program you can use to create programs and applications.  

## Start developing
Ready to start developing? Let's go!

### Create a project
First, you'll create a ASP.NET Core project. The project type comes with all the template files you'll need, before you've even added anything.

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project...**.

3. In the **New Project** dialog box in the left pane, expand **Visual C#**, expand **Web**, and then choose **.NET Core**. In the middle pane, choose **ASP.NET Core Web Application**, name the file *MyCoreApp*, and then choose **OK**.   

   ![ASP.NET Core Web Application project template in the New Project dialog box in the Visual Studio IDE](../ide/media/new-project-csharp-aspnet-mycoreapp.png)

#### Add a workgroup (optional)
If you don't see the **ASP.NET Core Web Application** project template, you can get it by adding the **ASP.NET Core and web development** workload. You can add this workload in one of the two following ways, depending on which Visual Studio 2017 updates are installed on your machine.

##### Option 1: Use the New Project dialog box
1. Click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.

  ![Click the Open Visual Studio Installer link from the New Project dialog box](../ide/media/vs-open-visual-studio-installer-generic.png)

2. The Visual Studio Installer launches. Choose the **ASP.NET Core and web development** workload, and then choose **Modify**.

   ![.NET Core cross-platform development workload in the Visual Studio Installer](../ide/media/asp-dot-net-web-dev-workload.png)

##### Option 2: Use the Tools menu bar
1. Cancel out of the **New Project** dialog box and from the top menu bar, choose **Tools** > **Get Tools and Features...**.

2. The Visual Studio Installer launches. Choose the **ASP.NET Core and web development** workload, and then choose **Modify**.   

#### Add a project template
1. In the **New ASP.NET Core Web Application** dialog box, choose the **Web Application (Model-View-Controller** project template.  

2. Select **ASP.NET Core 2.0** from the top drop-down menu. (If you don't see **ASP.NET Core 2.0** in the list, install it by following the **Download** link that should appear in a yellow bar near the top of the dialog box.) Choose **OK**.

   ![New ASP.NET Core Web Application dialogbox](../ide/media/new-project-csharp-aspnet-web-app-mvc.png)

### Take a tour of your solution

1. The project template creates a solution with a single ASP.NET Core project that is named **MyCoreApp**. Expand the project node to expose its contents.

    ![ASP.NET Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-explorer-mycoreapp.png)

2. This project follows the model-view-controller (MVC) paradigm to provide a clear division of responsibilities between data (models), presentation (views), and functionality (controllers). Open the **HomeController.cs** file from the **Controllers** folder.

      ![HomeController.cs file in the Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-explorer-home-controller.png)

3. The **HomeController** class&mdash;by convention&mdash;handles all incoming requests that start with **/Home**. The **Index** method handles requests to the root of the directory (like http://site.com/Home) and other methods handle requests to their named path based on convention, such as **About()** handling requests to **http://site.com/Home/About**. Of course, this is all configurable. One special item of note is that the **HomeController** is the default controller in a new project, so requests to the root of the site (**http://site.com**) would go through **Index()** of the **HomeController** just like requests to **http://site.com/Home** or **http://site.com/Home/Index**.

  ![HomeController.cs in the Visual Studio code window](../ide/media/csharp-aspnet-home-controller-code.png)

4. The project also has a **Views** folder that contains other folders that map to each controller (as well as one for **Shared** views. For example, the view CSHTML file (an extension of HTML) for the **/Home/About** path would be at **Views/Home/About.cshtml**. Open that file.

 ![About.cshtml file in the Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-explorer-view-about.png)

5. This CSHTML file uses the Razor syntax to render HTML based on a combination of standard tags and inline C#.

 ![About.cshtml in the Visual Studio code window](../ide/media/csharp-aspnet-home-controller-code.png)

 >[!NOTE]
 > To learn more about this, see the [Getting started with C# and ASP.NET using the Razor syntax](/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c) page.

6. The solution also contains a **wwwroot** folder that will be the root for your web site. You can put static site content, such as CSS, images, and JavaScript libraries, directly at the paths you'd want them to be at when the site is deployed.

 ![wwwroot folder in the Solution Explorer in Visual Studio](../ide/media/csharp-aspnet-solution-wwwroot.png)

7. There are also a variety of configuration files that serve to manage the project, its packages, and the application at runtime. For example, the default application [configuration](/aspnet/core/fundamentals/configuration) is stored in **appsettings.json**. However, you can override some/all of these settings on a per-environment basis, such as by providing an **appsettings.Development.json** file for the **Development** environment.

 ![](../ide/media/name.png)

## Run and debug the application

1. In **Solution Explorer**, right-click the **MyCoreApp** project node and select **Options**.

 ![](../ide/media/name.png)

2. The **Project Options** dialog includes everything you need to adjust how the application is built and run. Select the **Run > Configurations > Default** node from the left panel.

3. Check **Run on external console** and uncheck **Pause console output**. Ordinarily the self-hosted application would not have its console visible, but would instead log its results to the **Output** pad. For the purposes of this lab we'll show it in a separate window as well, although you don't need to do that during normal development.

4. Click **OK**.

 ![](../ide/media/name.png)

5. Press **F5** to build and run the application. Alternatively, you can select **Debug > Start Debugging**.

6. Visual Studio will launch two windows. The first is a console window that provides you a view into the self-hosted server application.

 ![](../ide/media/name.png)

7. The second is a typical browser window to test the site. As far as the browser knows, this application could be hosted anywhere. Click **About** to navigate to that page.

 ![](../ide/media/name.png)

8. Among other things, the about page renders some text set in the controller.

 ![](../ide/media/name.png)

9. Keep both windows open and return to Visual Studio. Open **Controllers/HomeController.cs** if it's not already open.

 ![](../ide/media/name.png)

10. Set a breakpoint in the first line of the **About** method. You can do this by clicking in the margin or setting the cursor on the line and pressing **F9**. This line sets some data in the **ViewData** collection that is rendered in the CSHTML page at **Views/Home/About.cshtml**.

 ![](../ide/media/name.png)

11. Return to the browser and refresh the about page. This will trigger the breakpoint in Visual Studio.

12. Mouse over the **ViewData** member to view its data. You can also expand its child members to see nested data.

 ![](../ide/media/name.png)

13. Remove the application breakpoint using the same method you used to add it.

14. Open **Views/Home/About.cshtml**.

15. Change the text **"additional"** to **"changed"** and save the file.

 ![](../ide/media/name.png)

16. Press the **Continue** button to continue execution.

 ![](../ide/media/name.png)

17. Return to the browser window to see the updated text. Note that this change could be done at any time and didn't necessarily require a debugger breakpoint. Refresh the browser if you don't see the change reflected immediately.

 ![](../ide/media/name.png)

18. Close the test browser window and application console. This will stop debugging as well.

### Review application startup configuration

1. From **Solution Explorer**, open **Startup.cs**. You may notice some red squiggles initially as NuGet packages are being restored in the background and the Roslyn compiler is building a complete picture of the project dependencies.

 ![](../ide/media/name.png)

1. Locate the **Startup** method. This section defines the initial configuration for the application and is very densely packed. Let's break it down.

 ![](../ide/media/name.png)

1. The method starts off by initializing a **ConfigurationBuilder** and setting its base path.

 ![](../ide/media/name.png)

1. Next, it loads a required **appsettings.json** file.

 ![](../ide/media/name.png)

1. After that, it attempts to load an environment-specific **appsettings.json** file, which would override existing settings. For example, this is a provided **appsettings.Development.json** file used for that specific environment. To read more about configuration in ASP.NET Core, check out [the docs](/aspnet/core/fundamentals/configuration).

 ![](../ide/media/name.png)

1. Finally, the environment variables are added to the configuration builder and the configuration is built and set for usage.

 ![](../ide/media/name.png)

### Add application middleware

1. Locate the **Configure** method in the **Startup** class. This is where all the middleware is configured so that it can be inserted into the HTTP pipeline and used to process every request to the server. Note that while this method is called only once, the contents of the methods (such as **UseStaticFiles**) may be executed on every request.

 ![](../ide/media/name.png)

1. You can also add additional middleware to be executed as part of the pipeline. Add the code below after **app.UseStaticFiles** to automatically add an **X-Test** header to every outgoing response. Note that IntelliSense will help complete the code as you type.

       ```csharp
       app.Use(async (context, next) =>
       {
           context.Response.Headers.Add("X-Test", new[] { "Test value" });
           await next();
       });
       ```
1. Press **F5** to build and run the project.

Congratulations on completing this tutorial!

## See also   
[Getting started with Razor Pages in ASP.NET Core](/aspnet/core/tutorials/razor-pages/razor-pages-start)
