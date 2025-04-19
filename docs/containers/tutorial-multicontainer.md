---
title: Work with multiple containers using Docker Compose
author: ghogen
description: Create and manage multi-container applications with Docker Compose and Container Tools in Visual Studio, including custom launch profiles.
ms.author: ghogen
ms.date: 2/27/2025
ms.subservice: container-tools
ms.topic: tutorial
---

# Tutorial: Create a multi-container app with Docker Compose

In this tutorial, you learn how to manage more than one container and communicate between them when using Container Tools in Visual Studio. Managing multiple containers requires *container orchestration* and requires an orchestrator such as Docker Compose or Service Fabric. For these procedures, you use Docker Compose. Docker Compose is great for local debugging and testing in the course of the development cycle.

:::moniker range=">=vs-2022"
The completed sample that you create in this tutorial can be found on GitHub at [`https://github.com/MicrosoftDocs/vs-tutorial-samples`](https://github.com/MicrosoftDocs/vs-tutorial-samples) in the folder *docker/ComposeSample*.
:::moniker-end

## Prerequisites

::: moniker range="vs-2019"

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
- [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **Web Development**, **Azure Tools** workload, and/or **.NET cross-platform development** workload installed
::: moniker-end

::: moniker range=">=vs-2022"

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **Web Development**, **Azure Tools** workload, and/or **.NET cross-platform development** workload installed. This installation includes the .NET 8 development tools.
::: moniker-end

## Create a Web Application project

In Visual Studio, create an **ASP.NET Core Web App** project, named `WebFrontEnd`, to create a web application with Razor pages.

::: moniker range="vs-2019"

![Screenshot showing Create ASP.NET Core Web App project.](./media/tutorial-multicontainer/vs-2019/create-web-project1.png)

Don't select **Enable container support**. You add support for Docker Compose later in the process.

![Screenshot of the Additional information screen when creating a web project. The option to Enable Docker Support is not selected.](./media/tutorial-multicontainer/vs-2019/create-web-project-additional-information.png)

::: moniker-end
::: moniker range=">=vs-2022"

Don't select **Enable Docker Support**. You add Docker support later in the process.

![Screenshot of the Additional information screen when creating a web project. The option to Enable Docker Support is not selected.](./media/tutorial-multicontainer/vs-2022/create-web-project.png)
::: moniker-end

## Create a Web API project

::: moniker range="vs-2019"

Add a project to the same solution and call it *MyWebAPI*. Select **API** as the project type, and clear the checkbox for **Configure for HTTPS**. In this design, we're only using SSL for communication with the client, not for communication from between containers in the same web application. Only `WebFrontEnd` needs HTTPS and the code in the examples assumes that you have cleared that checkbox. In general, the .NET developer certificates used by Visual Studio are only supported for external-to-container requests, not for container-to-container requests.

   ![Screenshot of creating the Web API project.](./media/tutorial-multicontainer/vs-2019/create-webapi-project.png)
::: moniker-end

:::moniker range=">=vs-2022"
1. Add a project to the same solution and call it *MyWebAPI*. Select **API** as the project type, and clear the checkbox for **Configure for HTTPS**.

   > [!NOTE]
   > In this design, we're only using HTTPS for communication with the client, not for communication from between containers in the same web application. Only `WebFrontEnd` needs HTTPS and the code in the examples assumes that you have cleared that checkbox. In general, the .NET developer certificates used by Visual Studio are only supported for external-to-container requests, not for container-to-container requests.

   ![Screenshot of creating the Web API project.](media/tutorial-multicontainer/vs-2022/create-web-api-project.png)

1. Add support for Azure Cache for Redis. Add the NuGet package `Microsoft.Extensions.Caching.StackExchangeRedis` (not `StackExchange.Redis`). In *Program.cs*, add the following lines, just before `var app = builder.Build()`:

   ```csharp
   builder.Services.AddStackExchangeRedisCache(options =>
      {
         options.Configuration = "redis:6379"; // redis is the container name of the redis service. 6379 is the default port
         options.InstanceName = "SampleInstance";
      });
   ```

1. Add using directives in `Program.cs` for `Microsoft.Extensions.Caching.Distributed` and `Microsoft.Extensions.Caching.StackExchangeRedis`.

   ```csharp
   using Microsoft.Extensions.Caching.Distributed;
   using Microsoft.Extensions.Caching.StackExchangeRedis;
   ```

1. In the Web API project, delete the existing `WeatherForecast.cs` and *Controllers/WeatherForecastController.cs*, and add a file under Controllers, *CounterController.cs*, with the following contents:

   ```csharp
   using Microsoft.AspNetCore.Mvc;
   using Microsoft.Extensions.Caching.Distributed;
   using StackExchange.Redis;

   namespace WebApi.Controllers
   {
       [ApiController]
       [Route("[controller]")]
       public class CounterController : ControllerBase
       {
           private readonly ILogger<CounterController> _logger;
           private readonly IDistributedCache _cache;

           public CounterController(ILogger<CounterController> logger, IDistributedCache cache)
           {
               _logger = logger;
               _cache = cache;
           }

           [HttpGet(Name = "GetCounter")]
           public string Get()
           {
               string key = "Counter";
               string? result = null;
               try
               {
                   var counterStr = _cache.GetString(key);
                   if (int.TryParse(counterStr, out int counter))
                   {
                       counter++;
                   }
                   else
                   {
                       counter = 0;
                   }
                   result = counter.ToString();
                   _cache.SetString(key, result);
               }
               catch(RedisConnectionException)
               {
                   result = "Redis cache is not found.";
               }
               return result;
           }
       }
   }
   ```

   The service increments a counter every time the page is accessed and stores the counter in the cache.
:::moniker-end

## Add code to call the Web API

::: moniker range="vs-2019"

1. In the `WebFrontEnd` project, open the *Index.cshtml.cs* file, and replace the `OnGet` method with the following code.

   ```csharp
    public async Task OnGet()
    {
       ViewData["Message"] = "Hello from webfrontend";

       using (var client = new System.Net.Http.HttpClient())
       {
          // Call *mywebapi*, and display its response in the page
          var request = new System.Net.Http.HttpRequestMessage();
          request.RequestUri = new Uri("http://mywebapi/WeatherForecast");
          // request.RequestUri = new Uri("http://mywebapi/api/values/1"); // For ASP.NET 2.x, comment out previous line and uncomment this line.
          var response = await client.SendAsync(request);
          ViewData["Message"] += " and " + await response.Content.ReadAsStringAsync();
       }
    }
   ```

   > [!NOTE]
   > In real-world code, you shouldn't dispose `HttpClient` after every request. For best practices, see [Use HttpClientFactory to implement resilient HTTP requests](/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests).

1. In the `Index.cshtml` file, add a line to display `ViewData["Message"]` so that the file looks like the following code:

   ```cshtml
   @page
   @model IndexModel
   @{
      ViewData["Title"] = "Home page";
   }

   <div class="text-center">
      <h1 class="display-4">Welcome</h1>
      <p>Learn about <a href="/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
      <p>@ViewData["Message"]</p>
   </div>
   ```

1. (ASP.NET 2.x only) Now in the Web API project, add code to the Values controller to customize the message returned by the API for the call you added from *webfrontend*.

   ```csharp
   // GET api/values/5
   [HttpGet("{id}")]
   public ActionResult<string> Get(int id)
   {
      return "webapi (with value " + id + ")";
   }
   ```

   > [!NOTE]
   > In .NET Core 3.1 and later, you can use the provided WeatherForecast API rather than this extra code. However, you need to comment out the call to <xref:Microsoft.AspNetCore.Builder.HttpsPolicyBuilderExtensions.UseHttpsRedirection*> in the Web API project because the code uses HTTP to make the call rather than HTTPS.

   ```csharp
         //app.UseHttpsRedirection();
   ```

## Add Docker Compose support

1. In the `WebFrontEnd` project, choose **Add > Container Orchestrator Support**. The **Docker Support Options** dialog appears.

1. Choose **Docker Compose**.

1. Choose your Target OS, for example, Linux.

   ![Screenshot of choosing the Target OS.](media/tutorial-multicontainer/docker-tutorial-docker-support-options.PNG)

   Visual Studio creates a *docker-compose.yml* file and a `.dockerignore` file in the **docker-compose** node in the solution, and that project shows in boldface font, which shows that it's the startup project.

   ![Screenshot of Solution Explorer with Docker Compose project added.](media/tutorial-multicontainer/multicontainer-solution-explorer.png)

   The *docker-compose.yml* appears as follows:

   ```yaml
    services:
      webfrontend:
        image: ${DOCKER_REGISTRY-}webfrontend
        build:
          context: .
          dockerfile: WebFrontEnd/Dockerfile
   ```

   The `version` specified in the first line is the [Docker Compose file version](https://docs.docker.com/compose/compose-file/#version-top-level-element). You normally shouldn't change it, since it's used by the tools to understand how to interpret the file.

   The `.dockerignore` file contains file types and extensions that you don't want Docker to include in the container. These files are generally associated with the development environment and source control, not part of the app or service you're developing.

   Look at the **Container Tools** section of the output pane for details of the commands being run. You can see the command-line tool `docker-compose` is used to configure and create the runtime containers.

1. In the Web API project, again right-click on the project node, and choose **Add** > **Container Orchestrator Support**. Choose **Docker Compose**, and then select the same target OS.

    > [!NOTE]
    > In this step, Visual Studio will offer to create a Dockerfile. If you do this on a project that already has Docker support, you are prompted whether you want to overwrite the existing Dockerfile. If you've made changes in your Dockerfile that you want to keep, choose no.

    Visual Studio makes some changes to your Docker Compose YML file. Now both services are included.

    ```yaml
    services:
      webfrontend:
        image: ${DOCKER_REGISTRY-}webfrontend
        build:
          context: .
          dockerfile: WebFrontEnd/Dockerfile

      mywebapi:
        image: ${DOCKER_REGISTRY-}mywebapi
        build:
          context: .
          dockerfile: MyWebAPI/Dockerfile
    ```

1. The first project that you add container orchestration to is set up to be launched when you run or debug. You can configure the launch action in the **Project Properties** for the Docker Compose project. On the Docker Compose project node, right-click to open the context menu, and then choose **Properties**, or use Alt+Enter. The following screenshot shows the properties you would want for the solution used here. For example, you can change the page that is loaded by customizing the **Service URL** property.

   ![Screenshot of Docker Compose project properties.](media/tutorial-multicontainer/launch-action.png)

   Here's what you see when launched (the .NET Core 2.x version):

   ![Screenshot of running web app.](media/tutorial-multicontainer/webfrontend.png)

   The web app for .NET 3.1 shows the weather data in JSON format.

1. Now suppose you're only interested in having the debugger attached to WebFrontEnd, not the Web API project. From the menu bar, you can use the dropdown list next to the start button to bring up a menu of debug options; choose **Manage Docker Compose Launch Settings**.

   ![Screenshot of Debug Manage Compose Settings menu item.](media/launch-settings/debug-dropdown-manage-compose.png)

   The **Manage Docker Compose Launch Settings** dialog comes up. With this dialog, you can control which subset of services is launched during a debugging session, which are launched with or without the debugger attached, and the launch service and URL. See [Start a subset of Compose services](launch-profiles.md).

   ![Screenshot of Manage Docker Compose Launch Settings dialog box.](media/tutorial-multicontainer/vs-2019/launch-profile-1.png)

   Choose **New** to create a new profile, and name it `Debug WebFrontEnd only`. Then, set the Web API project to **Start without debugging**, leave the WebFrontEnd project set to start with debugging, and choose **Save**.

   The new configuration is chosen as the default for the next **F5**.

1. Press **F5** to confirm it works as you expect.

Congratulations, you're running a Docker Compose application with a custom Docker Compose profile.

::: moniker-end

:::moniker range=">=vs-2022"

1. In the `WebFrontEnd` project, open the *Index.cshtml.cs* file, and replace the `OnGet` method with the following code.

   ```csharp
   public async Task OnGet()
   {
      // Call *mywebapi*, and display its response in the page
      using (var client = new System.Net.Http.HttpClient())
      {
         var request = new System.Net.Http.HttpRequestMessage();

         // A delay is a quick and dirty way to work around the fact that
         // the mywebapi service might not be immediately ready on startup.
         // See the text for some ideas on how you can improve this.
         // Uncomment if not using healthcheck (Visual Studio 17.13 or later)
         // await System.Threading.Tasks.Task.Delay(10000);

         // mywebapi is the service name, as listed in docker-compose.yml.
         // Docker Compose creates a default network with the services
         // listed in docker-compose.yml exposed as host names.
         // The port 8080 is exposed in the WebAPI Dockerfile.
         // If your WebAPI is exposed on port 80 (the default for HTTP, used
         // with earlier versions of the generated Dockerfile), change
         // or delete the port number here.
         request.RequestUri = new Uri("http://mywebapi:8080/Counter");
         var response = await client.SendAsync(request);
         string counter = await response.Content.ReadAsStringAsync();
         ViewData["Message"] = $"Counter value from cache :{counter}";
      }
   }
   ```

   > [!NOTE]
   > In real-world code, you shouldn't dispose `HttpClient` after every request. For best practices, see [Use HttpClientFactory to implement resilient HTTP requests](/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests).

   The URI given references a service name defined in the *docker-compose.yml* file. Docker Compose sets up a default network for communication between containers using the listed service names as hosts.

   The code shown here works with .NET 8 and later, which sets up a user account in the Dockerfile without administrator privileges, and exposes port 8080 because the HTTP default port 80 is not accessible without elevated privilege.

1. In the `Index.cshtml` file, add a line to display `ViewData["Message"]` so that the file looks like the following code:

      ```cshtml
      @page
      @model IndexModel
      @{
          ViewData["Title"] = "Home page";
      }

      <div class="text-center">
          <h1 class="display-4">Welcome</h1>
          <p>Learn about <a href="/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
          <p>@ViewData["Message"]</p>
      </div>
      ```

      This code displays the value of the counter returned from the Web API project. It increments every time the user accesses or refreshes the page.

## Add Docker Compose support

1. In the `WebFrontEnd` project, choose **Add > Container Orchestrator Support**. The **Docker Support Options** dialog appears.

1. Choose **Docker Compose**.

1. **Visual Studio 17.12 and later** Choose the scaffolding options for the WebFrontEnd project.

   ![Screenshot showing Container Scaffolding Options dialog for the WebFrontEnd project.](media/tutorial-multicontainer/vs-2022/webfrontend-container-options.png)

   **Visual Studio 17.11 and earlier** Choose your Target OS, for example, Linux.

   ![Screenshot of choosing the Target OS.](media/tutorial-multicontainer/docker-tutorial-docker-support-options.PNG)

   Visual Studio creates a *docker-compose.yml* file and a `.dockerignore` file in the **docker-compose** node in the solution, and that project shows in boldface font, which shows that it's the startup project.

   ![Screenshot of Solution Explorer with Docker Compose project added.](media/tutorial-multicontainer/vs-2022/multicontainer-solution-explorer.png)

   The *docker-compose.yml* appears as follows:

   ```yaml
    services:
      webfrontend:
        image: ${DOCKER_REGISTRY-}webfrontend
        build:
          context: .
          dockerfile: WebFrontEnd/Dockerfile
   ```

   The `.dockerignore` file contains file types and extensions that you don't want Docker to include in the container. These files are generally associated with the development environment and source control, not part of the app or service you're developing.

   Look at the **Container Tools** section of the output pane for details of the commands being run. You can see the command-line tool `docker-compose` is used to configure and create the runtime containers.

1. In the Web API project, again right-click on the project node, and choose **Add** > **Container Orchestrator Support**. Choose **Docker Compose**, and then select the same target OS.

    > [!NOTE]
    > In this step, Visual Studio will offer to create a Dockerfile. If you do this on a project that already has Docker support, you are prompted whether you want to overwrite the existing Dockerfile. If you've made changes in your Dockerfile that you want to keep, choose no.

    Visual Studio makes some changes to your `docker-compose` YML file. Now both services are included.

    ```yaml
    services:
      webfrontend:
        image: ${DOCKER_REGISTRY-}webfrontend
        build:
          context: .
          dockerfile: WebFrontEnd/Dockerfile

      mywebapi:
        image: ${DOCKER_REGISTRY-}mywebapi
        build:
          context: .
          dockerfile: MyWebAPI/Dockerfile
    ```

1. Add the cache to the `docker-compose.yml` file:

   ```yml
   redis:
      image: redis
   ```

   Make sure the indentation is at the same level as the other two services.

1. (Visual Studio 17.13 or later) The dependent services demonstrate a common problem. The HTTP request in the front end's main page could run immediately on application launch, before the `mywebapi` service is ready to receive web requests. If you're using Visual Studio 17.13 or later, you can use the Docker Compose features `depends_on` and `healthcheck` in *docker-compose.yml* to make the projects start in the right sequence, and have them be ready to serve requests when required. See [Docker Compose - Startup order](https://docs.docker.com/compose/how-tos/startup-order/).

    ```yml
   services:
      webfrontend:
         image: ${DOCKER_REGISTRY-}webfrontend
         depends_on:
            mywebapi:
              condition: service_healthy
         build:
            context: .
            dockerfile: WebFrontEnd/Dockerfile

      mywebapi:
         image: ${DOCKER_REGISTRY-}mywebapi
         depends_on:
            redis:
              condition: service_started
         healthcheck:
            test: curl --fail http://mywebapi:8080/Counter || exit 1
            interval: 20s
            timeout: 20s
            retries: 5
         build:
            context: .
            dockerfile: MyWebAPI/Dockerfile

      redis:
         image: redis
   ```

   In this example, the health check uses `curl` to verify that the service is ready to process requests. If the image you're using doesn't have `curl` installed, add lines to the `base` stage of the MyWebAPI Dockerfile to install it. This step requires elevated privileges, but you can restore the normal user privileges after installing it as shown here (for the Debian images used in this example):

   ```dockerfile
   USER root
   RUN apt-get update && apt-get install -y curl
   USER $APP_UID
   ```

   > [!NOTE]
   > If you're using a Linux distro, like Alpine, that doesn't support `apt-get`, try `RUN apk --no-cache add curl` instead.

   These Docker Compose features require a property setting in the Docker Compose project file (`.dcproj`). Set the property `DependencyAwareStart` to true:

   ```xml
   <PropertyGroup>
      <!-- existing properties -->
      <DependencyAwareStart>true</DependencyAwareStart>
   </PropertyGroup>
   ```

   This property activates a different way of starting the containers for debugging that supports the service dependency features.

   With these changes, the `webfrontend` service will not start until `mywebapi` starts and successfully handles a web request.

1. The first project that you add container orchestration to is set up to be launched when you run or debug. You can configure the launch action in the **Project Properties** for the Docker Compose project. On the Docker Compose project node, right-click to open the context menu, and then choose **Properties**, or use **Alt**+**Enter**. For example, you can change the page that is loaded by customizing the **Service URL** property.

   ![Screenshot of Docker Compose project properties.](media/tutorial-multicontainer/launch-action.png)

1. Press **F5**. Here's what you see when launched:

   ![Screenshot of running web app.](media/tutorial-multicontainer/vs-2022/webfrontend-counter.png)

1. You can monitor the containers using the **Containers** window. If you don't see the window, use the search box, press **Ctrl**+**K**, **Ctrl**+**O**, or press **Ctrl**+**Q**. Under **Feature search**, search for `containers`, and choose **View** > **Other Windows** > **Containers** from the list.

1. Expand the **Solution Containers** node, and choose the node for your Docker Compose project to view combined logs in the **Logs** tab of this window.

   :::image type="content" alt-text="Screenshot showing viewing the Logs tab in the Containers window." source="./media/tutorial-multicontainer/vs-2022/containers-window-logs.png" lightbox="./media/tutorial-multicontainer/vs-2022/containers-window-logs.png":::

   You can also select the node for an individual container to view logs, environment variables, the filesystem, and other details.

## Set up launch profiles

1. This solution has an Azure Cache for Redis, but it's not efficient to rebuild the cache container every time you start a debugging session. To avoid that situation, you can set up a couple of launch profiles. Create one profile to start the Azure Cache for Redis. Create a second profile to start the other services. The second profile can use the cache container that's already running. From the menu bar, you can use the dropdown list next to the start button to open a menu with debugging options. Select **Manage Docker Compose Launch Settings**.

   ![Screenshot of Debug Manage Compose Settings menu item.](media/tutorial-multicontainer/vs-2022/debug-dropdown-manage-compose.png)

   The **Manage Docker Compose Launch Settings** dialog comes up. With this dialog, you can control which subset of services is launched during a debugging session, which are launched with or without the debugger attached, and the launch service and URL. See [Start a subset of Compose services](launch-profiles.md).

   ![Screenshot of Manage Docker Compose Launch Settings dialog box.](media/tutorial-multicontainer/vs-2022/launch-profile.png)

   Choose **New** to create a new profile, and name it `Start Redis`. Then, set the Redis container to **Start without debugging**, leave the other set to **Do not start**, and choose **Save**.

   ![Screenshot showing creating the Redis profile that starts the Redis service only.](media/tutorial-multicontainer/vs-2022/launch-profile-start-redis-only.png)

   Then create another profile `Start My Services` that doesn't start Redis, but starts the other two services.

   ![Screenshot showing creating the Services profile that starts the other services.](media/tutorial-multicontainer/vs-2022/launch-profile-start-my-services.png)

   (Optional) Create a third profile `Start All` to start everything. You can choose **Start without debugging** for Redis.

1. Choose **Start Redis** from the dropdown list on the main Visual Studio toolbar. The Redis container builds and starts without debugging. You can use the **Containers** window to see that it's running. Next, choose **Start My Services** from the dropdown list and press **F5** to launch them. Now you can keep the cache container running throughout many subsequent debug sessions. Every time you use **Start My Services**, those services use the same cache container.

Congratulations, you're running a Docker Compose application with a custom Docker Compose profile.

::: moniker-end

## Next steps

Look at the options for deploying your [containers to Azure](/azure/containers).

## See also

[Docker Compose](https://docs.docker.com/compose/)

[Container Tools](./index.yml)
