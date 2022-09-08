---
title: "Getting Started with ASP.NET Core"
description: "This article describes how to get started with ASP.NET in Visual Studio for Mac, including installation and creating a new project."
author: jmatthiesen
ms.author: jomatthi
manager: dominicn
ms.date: 08/26/2022
ms.assetid: 6E8B0C90-33D6-4546-8207-CE0787584565
ms.custom: video, devdivchpfy22
no-loc: [Blazor, "Blazor WebAssembly"]
ms.topic: how-to
monikerRange: ">=vsmac-2019"
---
# Getting Started with ASP.NET Core

 [!INCLUDE [Visual Studio for Mac](~/includes/applies-to-version/vs-mac-only.md)]

Visual Studio for Mac makes it easy to develop your app's service with its support for the latest ASP.NET Core Web development platform. ASP.NET Core runs on the latest evolution of the .NET platform and runtime. It's been tuned for fast performance, factored for small install sizes, and reimagined to run on Linux and macOS, as well as Windows.

::: moniker range="vsmac-2019"

## Installing .NET Core

.NET Core 3.1 is automatically installed when you install Visual Studio for Mac. For more information about versions of .NET Core supported in Visual Studio for Mac, see [Supported versions of .NET](./supported-versions-net.md).

::: moniker-end

::: moniker range="vsmac-2022"

## Installing .NET 6

.NET 6 is automatically installed when you install Visual Studio for Mac. For more information about versions of .NET supported in Visual Studio for Mac, see [Supported versions of .NET](./supported-versions-net.md).

::: moniker-end

## Creating an ASP.NET Core app in Visual Studio for Mac

::: moniker range="vsmac-2019"

Open Visual Studio for Mac. On the Start Screen, select **New Project...**

:::image type="content" source="media/asp-net-core-2019-new-asp-core.png" alt-text="This screenshot shows the New Project Dialog while creating an ASP.NET Core app in Visual Studio for Mac.":::

The **New Project** dialog is shown. It lets you select a template to create your application.

There are many projects that will provide you with a pre-built template to start building your ASP.NET Core Application. They are:

- **.NET Core > Empty**
- **.NET Core > API**
- **.NET Core > Web Application**
- **.NET Core > Web Application (Model-View-Controller)**
- **.NET Core > Blazor Server App**
- **.NET Core > Blazor WebAssembly App**

:::image type="content" source="media/asp-net-core-2019-new-asp-core.png" alt-text="Screenshot shows the ASP.NET Project Options while creating an ASP.NET Core app in Visual Studio for Mac.":::

Select the **ASP.NET Core Empty Web Application** and select **Next**. Give the Project a name and select **Create**. These steps create a new ASP.NET Core app. In the **Solution** window's left pane, expand the second arrow and then select **Startup.cs**. It should look similar to the following image:

:::image type="content" source="media/asp-net-core-2019-empty-project.png" alt-text="Screenshot shows new ASP.NET Core Empty Project view while creating an ASP.NET Core app.":::

The ASP.NET Core Empty template creates a web application with two default files: **Program.cs** and **Startup.cs** that are explained here. It also creates a **Dependencies** folder, which contains your project's NuGet package dependencies such as ASP.NET Core, the .NET Core framework, and the MSBuild targets that build the project:

:::image type="content" source="media/asp-net-core-2019-solution-dependencies.png" alt-text="Screenshot of Solution window displaying dependencies.":::
::: moniker-end

::: moniker range="vsmac-2022"

Open Visual Studio for Mac. On the Start Screen, select **New**

:::image type="content" source="media/vsmac-2022/ide-start-new-project.png" alt-text="Screenshot shows the New Project Dialog while creating an ASP.NET Core app in Visual Studio for Mac.":::

The **New Project** dialog is shown. It lets you select a template to create your application.

There are many projects that'll provide you with a pre-built template to start building your ASP.NET Core Application. They are:

- **.NET Core > Empty**
- **.NET Core > API**
- **.NET Core > Web Application**
- **.NET Core > Web Application (Model-View-Controller)**
- **gRPC Service**
- **.NET Core > Blazor Server App**
- **.NET Core > Blazor WebAssembly App**
- **Razor Class Library**
- **Angular**
- **React.js**
- **React.js and Redux**

:::image type="content" source="media/vsmac-2022/asp-net-core-2022-new-asp-core.png" alt-text="Screenshot shows new Project on Visual Studio start window.":::

Select the **ASP.NET Core Empty Web Application** and select **Continue**. Give the Project a name and select **Continue**. These steps create a new ASP.NET Core app. In the **Solution** window's left pane, expand the second arrow and then select **Program.cs**. It should look similar to the following image:

:::image type="content" source="media/vsmac-2022/asp-net-core-2022-empty-project.png" alt-text="Screenshot shows new ASP.NET Core Empty Project view while creating an ASP.NET Core app.":::

The ASP.NET Core Empty template creates a web application with default files like **Program.cs** that is explained here.  It also creates a **Dependencies** folder, which contains your project's NuGet package dependencies such as ASP.NET Core, the .NET Core framework, and the MSBuild targets that build the project:

:::image type="content" source="media/vsmac-2022/asp-net-core-2022-solution-dependencies.png" alt-text="Screenshot of Solution window displaying dependencies.":::
::: moniker-end

### Program.cs

::: moniker range="vsmac-2019"

Open and inspect the **Program.cs** file in your project. Notice that several things are happening in the `Main` method – the entry into your app:

```csharp
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
```

An ASP.NET Core app creates a web server in its main method by configuring and launching a host via an instance of [`WebHostBuilder`](/aspnet/core/fundamentals/hosting). This builder provides methods to configure the host. In the template app, the following configurations are used:

- `.UseStartup<Startup>()`: Specifies the Startup class.

However, you can also add more configurations, such as:

- `UseKestrel`: Specifies the Kestrel server will be used by the app
- `UseContentRoot(Directory.GetCurrentDirectory())`: Uses the web project's root folder as the app's content root when the app is started from this folder
- `.UseIISIntegration()`: Specifies that the app should work with IIS. To use IIS with ASP.NET Core both `UseKestrel` and `UseIISIntegration` need to be specified.

### Startup.cs

The Startup class for your app is specified in the `UseStartup()` method on the `CreateWebHostBuilder`. It is in this class that you'll specify the request handling pipeline, and where you configure any services.

Open and inspect the **Startup.cs** file in your project:

```csharp
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
```

This Startup class must always adhere to the following rules:

- It must always be public
- It must contain the two public methods: `ConfigureServices` and `Configure`

The `ConfigureServices` method defines the services that will be used by your app.

The `Configure` lets you compose your request pipeline using [Middleware](/aspnet/core/fundamentals/middleware). These components are used within an ASP.NET application pipeline to handle requests and responses. The HTTP pipeline consists of many request delegates, called in sequence. Each delegate can choose to either handle the request itself, or pass it to the next delegate.

You can configure delegates by using the `Run`,`Map`, and `Use` methods on `IApplicationBuilder`, but the `Run` method will never call a next delegate and should always be used at the end of your pipeline.

The `Configure` method of the pre-built template is built to do a few things. First, it configures an exception handling page for use during development. Then, it sends a response to the requesting web page with a simple "Hello World".

This simple Hello, World project can run now without any extra code being added. To run the app, you can either select which browser you want to run app the app in using the dropdown right of the Play button, or simply hit the **Play** (triangular) button to use your default browser:

:::image type="content" source="media/asp-net-web-picker.png" alt-text="Screenshot showing the Run from browser menu.":::

::: moniker-end

::: moniker range="vsmac-2022"

Open and inspect the **Program.cs** file in your project. Notice that several things are happening. The first is that there's no `Main` method. By default the Empty template is configured to use the minimal Web API type projects introduced in .NET 6.

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
```

The following code creates a [WebApplicationBuilder](/dotnet/api/microsoft.aspnetcore.builder.webapplicationbuilder) and a [WebApplication](/dotnet/api/microsoft.aspnetcore.builder.webapplication) with pre-configured defaults:

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
```

The following code creates an HTTP GET endpoint `/` that returns `Hello World!`:

```csharp
app.MapGet("/", () => "Hello World!");
```

`app.Run();` runs the app.

This simple Hello, World project can run now without any extra code being added. To run the app, you can either select which browser you want to run app in using the dropdown right of the **Play** button. Or, you can hit the **Play** (triangular) button to use your default browser:

:::image type="content" source="media/vsmac-2022/asp-net-web-picker.png" alt-text="Screenshot showing the select the browser to run your code.":::

::: moniker-end

Visual Studio for Mac uses a random port to launch your web project. To find out what port it is, open the Application Output, which is listed under the **View > Other Windows** menu. You should find output similar as the following sample:

:::image type="content" source="media/asp-net-core-image6.png" alt-text="Screenshot showing the Application Output displaying listening port.":::

Once the project is running, your default web browser should launch and connect to the URL listed in the Application Output. Alternatively, you can open any browser of your choice, and enter `http://localhost:5000/`, replacing the `5000` with the port that Visual Studio output in the Application Output. You should see the text `Hello World!`:

:::image type="content" source="media/asp-net-core-image7.png" alt-text="Screenshot of a web browser showing text.":::

::: moniker range="vsmac-2019"

### Adding a Controller

ASP.NET Core Apps use the Model-View-Controller (MVC) design pattern to provide a logical separation of responsibilities for each part of the app. The MVC design pattern consists of:

- **Model**: A class that represents the data of the app.
- **View**: Displays the app's user interface (which is often the model data).
- **Controller**: A class that handles browser requests, responds to user input, and interaction.

For more information on using MVC, see the [Overview of ASP.NET Core MVC](/aspnet/core/mvc/overview) guide.

To add a controller, follow these steps:

1. Right-click on the **Project** name and select **Add > New Files**. Select **General > Empty Class**, and enter a controller name:

    :::image type="content" source="media/asp-net-core-image8.png" alt-text="Screenshot of a New File dialog while adding a controller.":::

1. Add the following code to the new controller:

    ```csharp
    using System;
    using Microsoft.AspNetCore.Mvc;
    using System.Text.Encodings.Web;

    namespace Hello_ASP
    {
        public class HelloWorldController : Controller
        {
            //
            // GET: /HelloWorld/

            public string Index()
            {
                return "This is my default action...";
            }

        }
    }
    ```

1. Add the `Microsoft.AspNetCore.Mvc` dependency to the project by right-clicking the **Dependency** folder, and selecting **Add Package...**.

1. Use the Search box to browse the NuGet library for `Microsoft.AspNetCore.Mvc`, and select **Add Package**. It may take a few minutes to install and you may be prompted to accept various licenses for the required dependencies:

    :::image type="content" source="media/asp-net-core-image9.png" alt-text="Screenshot of Add NuGet while adding a controller.":::

1. If you're using the Startup class, remove the `app.Run` lambda from the class, and set the URL routing logic used by MVC to determine which code it should invoke to the following code sample:

    ```csharp
    app.UseMvc(routes =>
    {
        routes.MapRoute(
        name: "default",
        template: "{controller=HelloWorld}/{action=Index}/{id?}");
    });
    ```

    Make sure to remove the `app.Run` lambda, as it will override the routing logic.

    MVC uses the following format, to determine which code to run:

    `/[Controller]/[ActionName]/[Parameters]`

    When you add the code snippet above, you're telling the app to default to the `HelloWorld` Controller, and the `Index` action method.

1. Add the `services.AddMvc();` call to the `ConfigureServices` method, as illustrated in the following code:

    ```csharp
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
    }
    ```

    You can also pass parameter information from the URL to the controller.

1. Add another method to your HelloWorldController, as illustrated in the following code:

    ```csharp
    public string Xamarin(string name)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, welcome to Visual Studio for Mac");
    }
    ```

1. If you run the app now, it should automatically open your browser:

    :::image type="content" source="media/asp-net-core-image13.png" alt-text="Screenshot of running app in browser while adding a controller.":::

1. Try to browse to `http://localhost:xxxx/HelloWorld/Xamarin?name=Amy` (replacing `xxxx` with the correct port), you should see the following page:

    :::image type="content" source="media/asp-net-core-image10.png" alt-text="Screenshot of running app in browser with arguments while adding a controller.":::

::: moniker-end

## Troubleshooting

If you need to install .NET Core manually on macOS 10.15 (Catalina) and higher, follow these steps:

1. Before you start installing .NET Core, ensure that you've updated all OS updates to the latest stable version. You can check by going to the App Store application, and selecting the **Updates** tab.

1. Follow the steps listed on the [.NET Core site](https://www.microsoft.com/net/core#macos).

Make sure to complete all steps successfully to ensure that .NET Core is installed successfully.

## Summary

This guide gave an introduction to ASP.NET Core. It describes what it is, when to use it, and provided information on using it in Visual Studio for Mac.
For more information on the next steps from here, see the following guides:

- [ASP.NET Core](/aspnet/core/) docs.
- [Create Backend Services for Native Mobile Applications](/aspnet/core/mobile/native-mobile-backend), which shows how to build a REST service using ASP.NET Core for a Xamarin.Forms app.
- [ASP.NET Core hands-on lab](https://github.com/Microsoft/vs4mac-labs/tree/master/Web/Getting-Started).

## Related Video

> [!Video https://docs.microsoft.com/shows/Visual-Studio-Toolbox/Visual-Studio-for-Mac-Build-Your-First-App/player]
