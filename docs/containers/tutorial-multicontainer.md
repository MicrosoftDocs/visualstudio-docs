---
title: Work with multiple containers using Docker Compose
author: ghogen
description: Learn how to use multiple containers with Docker Compose
ms.custom: SEO-VS-2020
ms.author: ghogen
ms.date: 03/15/2021
ms.technology: vs-azure
ms.topic: tutorial
---
# Tutorial: Create a multi-container app with Docker Compose

In this tutorial, you'll learn how to manage more than one container and communicate between them when using Container Tools in Visual Studio.  Managing multiple containers requires *container orchestration* and requires an orchestrator such as Docker Compose, Kubernetes, or Service Fabric. Here, we'll use Docker Compose. Docker Compose is great for local debugging and testing in the course of the development cycle.

## Prerequisites

::: moniker range="vs-2017"

* [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
* [Visual Studio 2017](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) with the **Web Development**, **Azure Tools** workload, or **.NET Core cross-platform development** workload installed
::: moniker-end

::: moniker range="vs-2019"

* [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads) with the **Web Development**, **Azure Tools** workload, and/or **.NET Core cross-platform development** workload installed
* [.NET Core 2.2 Development Tools](https://dotnet.microsoft.com/download/dotnet-core/2.2) for development with .NET Core 2.2
* [.NET Core 3 Development Tools](https://dotnet.microsoft.com/download/dotnet-core/3.1) for development with .NET Core 3.1.
::: moniker-end

::: moniker range=">=vs-2022"

* [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
* [Visual Studio 2022 Preview](https://visualstudio.microsoft.com/vs/preview/vs2022) with the **Web Development**, **Azure Tools** workload, and/or **.NET Core cross-platform development** workload installed
* [.NET Core 3 Development Tools](https://dotnet.microsoft.com/download/dotnet-core/3.1) for development with .NET Core 3.1.
* [.NET 5 Development Toos](https://dotnet.microsoft.com/download/dotnet-core/5.0) for development with .NET 5.
::: moniker-end

## Create a Web Application project

In Visual Studio, create an **ASP.NET Core Web App** project, named `WebFrontEnd`, to create a web application with Razor pages.
  
::: moniker range="vs-2017"

Do not select **Enable Docker Support**. You'll add Docker support later.

![Screenshot of creating the web project](./media/tutorial-multicontainer/docker-tutorial-enable-docker-support.png)

::: moniker-end

::: moniker range=">=vs-2019"

![Create ASP.NET Core Web App project](./media/tutorial-multicontainer/vs-2019/create-web-project1.png)

Do not select **Enable Docker Support**. You'll add Docker support later.

![Screenshot of the Additional information screen when creating a web project. The option to Enable Docker Support is not selected.](./media/tutorial-multicontainer/vs-2019/create-web-project-additional-information.png)

::: moniker-end

## Create a Web API project

Add a project to the same solution and call it *MyWebAPI*. Select **API** as the project type, and clear the checkbox for **Configure for HTTPS**. In this design, we're only using SSL for communication with the client, not for communication from between containers in the same web application. Only `WebFrontEnd` needs HTTPS and the code in the examples assumes that you have cleared that checkbox. In general, the .NET developer certificates used by Visual Studio are only supported for external-to-container requests, not for container-to-container requests.

::: moniker range="vs-2017"
   ![Screenshot of creating the Web API project](./media/tutorial-multicontainer/docker-tutorial-mywebapi.png)
::: moniker-end
::: moniker range=">=vs-2019"
   ![Screenshot of creating the Web API project](./media/tutorial-multicontainer/vs-2019/create-webapi-project.png)
::: moniker-end

## Add code to call the Web API

1. In the `WebFrontEnd` project, open the *Index.cshtml.cs* file, and replace the `OnGet` method with the following code.

   ```csharp
    public async Task OnGet()
    {
       ViewData["Message"] = "Hello from webfrontend";

       using (var client = new System.Net.Http.HttpClient())
       {
          // Call *mywebapi*, and display its response in the page
          var request = new System.Net.Http.HttpRequestMessage();
          // request.RequestUri = new Uri("http://mywebapi/WeatherForecast"); // ASP.NET 3 (VS 2019 only)
          request.RequestUri = new Uri("http://mywebapi/api/values/1"); // ASP.NET 2.x
          var response = await client.SendAsync(request);
          ViewData["Message"] += " and " + await response.Content.ReadAsStringAsync();
       }
    }
   ```
   
    > [!NOTE]
    > In real-world code, you shouldn't dispose `HttpClient` after every request. For best practices, see [Use HttpClientFactory to implement resilient HTTP requests](/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests).

   For .NET Core 3.1 in Visual Studio 2019 or later, the Web API template uses a WeatherForecast API, so uncomment that line and comment out the line for ASP.NET 2.x.

1. In the *Index.cshtml* file, add a line to display `ViewData["Message"]` so that the file looks like the following code:
    
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

    With .NET Core 3.1, you don't need this, because you can use the WeatherForecast API that is already there. However, you need to comment out the call to <xref:Microsoft.AspNetCore.Builder.HttpsPolicyBuilderExtensions.UseHttpsRedirection*>  in the `Configure` method in *Startup.cs*, because this code uses HTTP, not HTTPS, to call the Web API.

    ```csharp
                //app.UseHttpsRedirection();
    ```

1. In the `WebFrontEnd` project, choose **Add > Container Orchestrator Support**. The **Docker Support Options** dialog appears.

1. Choose **Docker Compose**.

1. Choose your Target OS, for example, Linux.

   ![Screenshot of choosing the Target OS](media/tutorial-multicontainer/docker-tutorial-docker-support-options.PNG)

   Visual Studio creates a *docker-compose.yml* file and a *.dockerignore* file in the **docker-compose** node in the solution, and that project shows in boldface font, which shows that it's the startup project.

   ![Screenshot of Solution Explorer with docker-compose project added](media/tutorial-multicontainer/multicontainer-solution-explorer.png)

   The *docker-compose.yml* appears as follows:

   ```yaml
   version: '3.4'

    services:
      webfrontend:
        image: ${DOCKER_REGISTRY-}webfrontend
        build:
          context: .
          dockerfile: WebFrontEnd/Dockerfile
   ```

   The *.dockerignore* file contains file types and extensions that you don't want Docker to include in the container. These files are generally associated with the development environment and source control, not part of the app or service you're developing.

   Look at the **Container Tools** section of the output pane for details of the commands being run.  You can see the command-line tool docker-compose is used to configure and create the runtime containers.

1. In the Web API project, again right-click on the project node, and choose **Add** > **Container Orchestrator Support**. Choose **Docker Compose**, and then select the same target OS.  

    > [!NOTE]
    > In this step, Visual Studio will offer to create a Dockerfile. If you do this on a project that already has Docker support, you are prompted whether you want to overwrite the existing Dockerfile. If you've made changes in your Dockerfile that you want to keep, choose no.

    Visual Studio makes some changes to your docker compose YML file. Now both services are included.

    ```yaml
    version: '3.4'
    
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

1. Run the site locally now (F5 or Ctrl+F5) to verify that it works as expected. If everything is configured correctly with the .NET Core 2.x version, you see the message "Hello from webfrontend and webapi (with value 1)."  With .NET Core 3, you see weather forecast data.

   The first project that you use when you add container orchestration is set up to be launched when you run or debug. You can configure the launch action in the **Project Properties** for the docker-compose project.  On the docker-compose project node, right-click to open the context menu, and then choose **Properties**, or use Alt+Enter.  The following screenshot shows the properties you would want for the solution used here.  For example, you can change the page that is loaded by customizing the **Service URL** property.

   ![Screenshot of docker-compose project properties](media/tutorial-multicontainer/launch-action.png)

   Here's what you see when launched (the .NET Core 2.x version):

   ![Screenshot of running web app](media/tutorial-multicontainer/webfrontend.png)

   The web app for .NET 3.1 shows the weather data in JSON format.

## Next steps

Look at the options for deploying your [containers to Azure](/azure/containers).

For greater control over which services are started during a debug session, learn how to use Docker Compose launch profiles to configure which services run when debugging. See [Manage launch profiles for Docker Compose](launch-profiles.md)

## See also
  
[Docker Compose](https://docs.docker.com/compose/)  
[Container Tools](./index.yml)