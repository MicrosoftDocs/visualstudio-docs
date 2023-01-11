---
title: Debug apps in a local Docker container | Microsoft Docs
description: Learn how to modify an app that's running in a local Docker container, refresh the container via Edit and Refresh, and then set debugging breakpoints.
ms.author: ghogen
author: ghogen
manager: jmartens
ms.assetid: 480e3062-aae7-48ef-9701-e4f9ea041382
ms.topic: how-to
ms.workload: multiple
ms.date: 10/07/2022
ms.technology: vs-container-tools
---
# Debug apps in a local Docker container

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Visual Studio provides a consistent way to develop Docker containers and validate your application locally.
You can run and debug your apps in Linux or Windows containers running on your local Windows desktop with Docker installed, and you don't have to restart the container each time you make a code change.

This article illustrates how to use Visual Studio to start an app in a local Docker container, make changes, and then refresh the browser to see the changes. This article also shows you how to set breakpoints for debugging for containerized apps. Supported project types include web app, console app, and Azure Function targeting .NET Framework and .NET Core. The examples presented in this article, are a project of type ASP.NET Core Web App and a project of type Console App (.NET Framework).

If you already have a project of a supported type, Visual Studio can create a Dockerfile and configure your project to run in a container. See [Container Tools in Visual Studio](overview.md).

## Prerequisites

To debug apps in a local Docker container, the following tools must be installed:

::: moniker range="vs-2019"

* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads) with the Web Development workload installed

::: moniker-end

::: moniker range="vs-2022"

* [Visual Studio 2022](https://visualstudio.microsoft.com/downloads) with the Web Development workload installed

::: moniker-end

To run Docker containers locally, you must have a local Docker client. You can use [Docker Desktop](https://www.docker.com/get-docker), which requires Windows 10 or later.

## Create a web app

If you have a project and you've added Docker support as described in the [overview](overview.md), skip this section.

::: moniker range="vs-2019"
[!INCLUDE [create-aspnet5-app-2019](../azure/includes/vs-2019/create-aspnet5-app-2019.md)]
::: moniker-end
::: moniker range=">=vs-2022"
[!INCLUDE [create-aspnet5-app-2022](../azure/includes/vs-2022/create-aspnet5-app-2022.md)]
::: moniker-end

### Edit your Razor pages and refresh

To quickly iterate changes in your Razor pages, you can start your application in a container. Then, continue to make changes, viewing them as you would with IIS Express. 

1. Make sure that Docker is set up to use the container type (Linux or Windows) that you are using. Right-click on the Docker icon on the Taskbar, and choose **Switch to Linux containers** or **Switch to Windows containers** as appropriate.

1. (.NET Core 3 and later only) Editing your code and refreshing the running site as described in this section is not enabled in the default templates in .NET Core >= 3.0. To enable it, add the NuGet package [Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation/). In *Startup.cs*, add a call to the extension method `IMvcBuilder.AddRazorRuntimeCompilation` to the code in the `ConfigureServices` method. You only need this enabled in DEBUG mode, so code it as follows:

    ```csharp
    public IWebHostEnvironment Env { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
        IMvcBuilder builder = services.AddRazorPages();

    #if DEBUG
        if (Env.IsDevelopment())
        {
            builder.AddRazorRuntimeCompilation();
        }
    #endif

        // code omitted for brevity
    }
    ```

    Modify the `Startup` method as follows:

    ```csharp
    public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
    {
        Configuration = configuration;
        Env = webHostEnvironment;
    }
    ```

   For more information, see [Razor file compilation in ASP.NET Core](/aspnet/core/mvc/views/view-compilation?view=aspnetcore-3.1&preserve-view=true).

1. Set **Solution Configuration** to **Debug**. Then, press **Ctrl**+**F5** to build your Docker image and run it locally.

    When the container image is built and running in a Docker container, Visual Studio launches the web app in your default browser.

1. Go to the *Index* page. We'll make changes on this page.
1. Return to Visual Studio and open *Index.cshtml*.
1. Add the following HTML content to the end of the file, and then save the changes.

    ```html
    <h1>Hello from a Docker container!</h1>
    ```

1. In the output window, when the .NET build is finished and you see the following lines, switch back to your browser and refresh the page:

   ```output
   Now listening on: http://*:80
   Application started. Press Ctrl+C to shut down.
   ```

Your changes have been applied!

### Debug with breakpoints

Often, changes require further inspection. You can use the debugging features of Visual Studio for this task.

1. In Visual Studio, open *Index.cshtml.cs*.
2. Replace the contents of the `OnGet` method with the following code:

   ```csharp
       ViewData["Message"] = "Your application description page from within a container";
   ```

3. To the left of the code line, set a breakpoint.
4. To start debugging and hit the breakpoint, press F5.
5. Switch to Visual Studio to view the breakpoint. Inspect values.

   :::moniker range="vs-2019"
   ![Screenshot showing part of the code for Index.cshtml.cs in Visual Studio with a breakpoint set to the left of a code line that is highlighted in yellow.](media/edit-and-refresh/breakpoint.png)
   :::moniker-end
   :::moniker range=">=vs-2022"
   ![Screenshot showing part of the code for Index.cshtml.cs in Visual Studio with a breakpoint set to the left of a code line that is highlighted in yellow.](media/edit-and-refresh/vs-2022/breakpoint.png)
   :::moniker-end

## Create a .NET Framework console app

This section presents how to debug a .NET Framework console app project in a local Docker container by first showing how to add Docker support to the project. It's important to recognize that different project types have different levels of Docker support. There are even different levels of Docker support for .NET Core (including .NET 5 and later) console app projects versus .NET Framework console app projects. 

When a .NET Framework console app project is created, there's no option to enable Docker support. After creating such a project, there's no way to explicitly add Docker support to the project. For a .NET Framework console app project, it's possible to add support for container orchestration. A side effect of adding orchestration support to the .NET Framework console app project is that it adds Docker support to the project, 

The following procedure demonstrates how to add orchestration support to a .NET Framework console app project, which subsequently adds Docker support to the project and allows the project to be debugged in a local Docker container.

1. Create a new .NET Framework Console app project.
1. In Solution Explorer, right-click the project node, and then select **Add** > **Container Orchestration Support**.  In the dialog box that appears, select **Docker Compose**. A Dockerfile is added to your project and a Docker Compose project with associated support files is added.

### Debug with breakpoints

1. In Solution Explorer, open *Program.cs*.
2. Replace the contents of the `Main` method with the following code:

   ```csharp
       System.Console.WriteLine("Hello, world!");
   ```

3. Set a breakpoint to the left of the code line.
4. Press **F5** to start debugging and hit the breakpoint.
5. Switch to Visual Studio to view the breakpoint and inspect values.

   :::moniker range="<=vs-2019"
   ![Screenshot of the code window for Program.cs in Visual Studio with a breakpoint set to the left of a code line that is highlighted in yellow.](media/edit-and-refresh/breakpoint-console.png)
   ::: moniker-end

## Container reuse

During the development cycle, Visual Studio rebuilds only your container images and the container itself when you change the Dockerfile. If you don't change the Dockerfile, Visual Studio reuses the container from an earlier run.

If you manually modified your container and want to restart with a clean container image, use the **Build** > **Clean** command in Visual Studio, and then build as normal.

## Troubleshoot

Learn how to [troubleshoot Visual Studio Docker development](troubleshooting-docker-errors.md).

## Next steps

Get more details by reading [How Visual Studio builds containerized apps](container-build.md).

## More about Docker with Visual Studio, Windows, and Azure

* Learn more about [container development with Visual Studio](./index.yml).
* To build and deploy a Docker container, see [Docker integration for Azure Pipelines](https://marketplace.visualstudio.com/items?itemName=ms-vscs-rm.docker).
* For an index of Windows Server and Nano Server articles, see [Windows container information](/virtualization/windowscontainers/).
* Learn about [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) and review the [Azure Kubernetes Service documentation](/azure/aks).
