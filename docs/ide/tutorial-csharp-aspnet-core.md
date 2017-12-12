---
title: "Getting started with C# and ASP.NET Core in Visual Studio| Microsoft Docs"
ms.custom: ""
ms.date: "12/15/2017"
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

>[!IMPORTANT]
>This tutorial is not yet complete; it needs screenshots.

# Getting started with C# and ASP.NET in Visual Studio
In this tutorial for C# development for ASP.NET Core using Visual Studio, you'll create a C# ASP.NET Core web app, add code to it, explore some features of the IDE, and run the app.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free.

## Before you begin
Here's a quick FAQ to introduce you to some key concepts.
### What is C#?
[C#](/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework) is a type-safe and object-oriented programming language that's designed to be both robust and easy to learn.
### What is ASP.NET Core?
ASP.NET Core is an open-source and cross-platform framework for building internet-connected applications, such as web apps and services. ASP.NET Core apps can run on [.NET Core](/net/core/platform) or the .NET Framework runtimes. You can develop and run your ASP.NET Core apps cross-platform on Windows, Mac, and Linux. ASP.NET Core is open source at [GitHub](https://github.com/aspnet/home).
### What is Visual Studio?
Visual Studio is an integrated development suite of productivity tools for developers. You can think of it as a program that you use to create programs and applications.  

## Start developing
Ready to start developing? Let's get started!

### Create a project
First, you'll create a ASP.NET Core project. The project type comes with all the template files you'll need, before you've even added anything!

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project...**.

3. In the **New Project** dialog box in the left pane, expand **Visual C#**, expand **Web**, and then choose **.NET Core**. In the middle pane, choose **ASP.NET Core Web Application** and choose **OK**. Then name the file *MyCoreApp*.  

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
1. In the **New ASP.NET Core Web Application** dialog box, choose the **Web Application (Model View Controller** project template.  

2. Select **ASP.NET Core 2.0** from the top drop-down menu. (If you don't see **ASP.NET Core 2.0** in the list, install it by following the **Download** link that should appear in a yellow bar near the top of the dialog box.) Choose **OK**.

   ![New ASP.NET Core Web Application dialogbox](../ide/media/new-project-csharp-aspnet-web-app-mvc.png)

## Take a tour of the solution

1. The project template creates a solution with a single ASP.NET Core project that is named **MyCoreApp**. Expand the project node to expose its contents.

    ![ASP.NET Solution Explorer in Visual Studio](csharp-aspnet-solution-explorer-mycoreapp.png)

2. This project follows the model-view-controller (MVC) paradigm to provide a clear division of responsibilities between data (models), presentation (views), and functionality (controllers). Open the **HomeController.cs** file from the **Controllers** folder.

       ![HomeController.cs file in the Solution Explorer in Visual Studio](csharp-aspnet-solution-explorer-HomeController.png)

3. The **HomeController** class-by convention-handles all incoming requests that start with **/Home**. The **Index** method handles requests to the root of the directory (like http://site.com/Home) and other methods handle requests to their named path based on convention, such as **About()** handling requests to **http://site.com/Home/About**. Of course, this is all configurable. One special item of note is that the **HomeController** is the default controller in a new project, so requests to the root of the site (**http://site.com**) would go through **Index()** of the **HomeController** just like requests to **http://site.com/Home** or **http://site.com/Home/Index**.

 ![])

4. The project also has a **Views** folder that contains other folders that map to each controller (as well as one for **Shared** views. For example, the view CSHTML file (an extension of HTML) for the **/Home/About** path would be at **Views/Home/About.cshtml**. Open that file.

       ![]()

5. This CSHTML file uses the Razor syntax to render HTML based on a combination of standard tags and inline C#. You can learn more about this in the [online documentation](https://docs.microsoft.com/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c).

       ![]()

6. The solution also contains a **wwwroot** folder that will be the root for your web site. You can put static site content, such as CSS, images, and JavaScript libraries, directly at the paths you'd want them to be at when the site is deployed.

       ![]()

7. There are also a variety of configuration files that serve to manage the project, its packages, and the application at runtime. For example, the default application [configuration](/aspnet/core/fundamentals/configuration) is stored in **appsettings.json**. However, you can override some/all of these settings on a per-environment basis, such as by providing an **appsettings.Development.json** file for the **Development** environment.

       ![]()

## Learn how the application is hosted

1. From **Solution Explorer**, open **Program.cs**. This is the bootstrapper that will run your application.

       ![]()

2. While there are only two lines of code here, they're pretty substantial. Let's break them down. First, a new **WebHostBuilder** is created. ASP.NET Core apps require a host in which to execute. A host must implement the **IWebHost** interface, which exposes collections of features and services, and a **Start** method. The host is typically created using an instance of a **WebHostBuilder**, which builds and returns a **WebHost** instance. The **WebHost** references the server that will handle requests.

       ![]()

3. While the **WebHostBuilder** is responsible for creating the host that will bootstrap the server for the app, it requires you provide a server that implements **IServer**. By default, this is **[Kestrel](/aspnet/core/fundamentals/servers/kestrel)**, a cross-platform web server for ASP.NET Core based on **libuv**, which is a cross-platform asynchronous I/O library.

       ![]()

4. Next, the server's content root is set. This determines where it searches for content files, like MVC View files. The default content root is the folder from which the application is run.

       ![]()

5. If the app must work with the Internet Information Services (IIS) web server, the **UseIISIntegration** method should be called as part of building the host. Note that this does not configure a server, like **UseKestrel** does. To use IIS with ASP.NET Core, you must specify both **UseKestrel** and **UseIISIntegration**. **Kestrel** is designed to be run behind a proxy and should not be deployed directly facing the internet. **UseIISIntegration** specifies IIS as the reverse proxy server, but it's only relevant when running on machines that have IIS. If you deploy your application to Windows, leave it in. It doesn't hurt otherwise.

       ![]()

6. It's a cleaner practice to separate the loading of settings from the application bootstrapping. To easily do this, **UseStartup** is called to specify that the **Startup** class is to be called for the loading of settings and other startup tasks, such as inserting middleware into the HTTP pipeline. You may have multiple **UseStartup** calls with the expectation that each one overwrites previous settings as needed.

       ![]()

7. The last step in creating the **IWebHost** is to call **Build**.

       ![]()

8. While **IWebHost** classes are required to implement the non-blocking **Start**, ASP.NET Core projects have an extension method called **Run** that wraps **Start** with blocking code so you don't need to manually prevent the method from exiting immediately.

       ![]()

## Run and debug the application

1. In **Solution Explorer**, right-click the **MyCoreApp** project node and select **Options**.

       ![]()

2. The **Project Options** dialog includes everything you need to adjust how the application is built and run. Select the **Run > Configurations > Default** node from the left panel.

3. Check **Run on external console** and uncheck **Pause console output**. Ordinarily the self-hosted application would not have its console visible, but would instead log its results to the **Output** pad. For the purposes of this lab we'll show it in a separate window as well, although you don't need to do that during normal development.

4. Click **OK**.

       ![]()

5. Press **F5** to build and run the application. Alternatively, you can select **Debug > Start Debugging**.

6. Visual Studio will launch two windows. The first is a console window that provides you a view into the self-hosted server application.

       ![]()

7. The second is a typical browser window to test the site. As far as the browser knows, this application could be hosted anywhere. Click **About** to navigate to that page.

       ![]()

8. Among other things, the about page renders some text set in the controller.

       ![]()

9. Keep both windows open and return to Visual Studio. Open **Controllers/HomeController.cs** if it's not already open.

       ![]()

10. Set a breakpoint in the first line of the **About** method. You can do this by clicking in the margin or setting the cursor on the line and pressing **F9**. This line sets some data in the **ViewData** collection that is rendered in the CSHTML page at **Views/Home/About.cshtml**.

       ![]()

11. Return to the browser and refresh the about page. This will trigger the breakpoint in Visual Studio.

12. Mouse over the **ViewData** member to view its data. You can also expand its child members to see nested data.

       ![]()

13. Remove the application breakpoint using the same method you used to add it.

14. Open **Views/Home/About.cshtml**.

15. Change the text **"additional"** to **"changed"** and save the file.

       ![]()

16. Press the **Continue** button to continue execution.

       ![]()

17. Return to the browser window to see the updated text. Note that this change could be done at any time and didn't necessarily require a debugger breakpoint. Refresh the browser if you don't see the change reflected immediately.

       ![]()

18. Close the test browser window and application console. This will stop debugging as well.

## Review application startup configuration ##

1. From **Solution Explorer**, open **Startup.cs**. You may notice some red squiggles initially as NuGet packages are being restored in the background and the Roslyn compiler is building a complete picture of the project dependencies.

       ![]()

1. Locate the **Startup** method. This section defines the initial configuration for the application and is very densely packed. Let's break it down.

       ![]()

1. The method starts off by initializing a **ConfigurationBuilder** and setting its base path.

       ![]()

1. Next, it loads a required **appsettings.json** file.

       ![]()

1. After that, it attempts to load an environment-specific **appsettings.json** file, which would override existing settings. For example, this is a provided **appsettings.Development.json** file used for that specific environment. To read more about configuration in ASP.NET Core, check out [the docs](/aspnet/core/fundamentals/configuration).

       ![]()

1. Finally, the environment variables are added to the configuration builder and the configuration is built and set for usage.

       ![]()

## Insert application middleware ##

1. Locate the **Configure** method in the **Startup** class. This is where all the middleware is configured so that it can be inserted into the HTTP pipeline and used to process every request to the server. Note that while this method is called only once, the contents of the methods (such as **UseStaticFiles**) may be executed on every request.

       ![]()

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
