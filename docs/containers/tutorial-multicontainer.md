---
title: Visual Studio Container Tools multicontainer tutorial with ASP.NET Core
author: ghogen
description: Learn how to use multiple containers with Docker for Windows
ms.author: ghogen
ms.date: 02/01/2019
ms.prod: visual-studio-dev15
ms.technology: vs-azure
ms.topic: include
monikerRange: ">= vs-2017"
---
# Tutorial: Developing with multiple Docker containers

In this tutorial, you'll learn how to manage more than one container and communicate between them when using Container Tools in Visual Studio.  Managing multiple containers requires *container orchestration* and requires an orchestrator such as Docker Compose, Kubernetes, or Service Fabric. Here, we'll use Docker Compose.

## Prerequisites

## Step 1: Create a web site project

1. In Visual Studio, create an **ASP.NET Core Web Application** project, named *WebFrontEnd*. Select **Web Application** to create a web application with Razor pages. Be sure that Enable Docker Support is selected, and that the container OS matches the OS selected in Docker Desktop.
  
   ![Screenshot of creating the web front end project](./media/tutorial-multicontainer/docker-tutorial-enable-docker-support.png)

## Step 2: Create a web api project

1. Add a project to the same solution and call it MyWebAPI. Select *API* as the project type.

   ![Screenshot of creating the Web API project](./media/tutorial-multicontainer/docker-tutorial-mywebapi.png)

## Step 3: Add code to call the web api

1. In the WebFrontEnd project, open the *Index.cshtml.cs* file, and replace the `OnGet` method with the following code.

   ```csharp
    public async Task OnGet()
    {
       ViewData["Message"] = "Hello from webfrontend";

       using (var client = new System.Net.Http.HttpClient())
             {
                 // Call *mywebapi*, and display its response in the page
                 var request = new System.Net.Http.HttpRequestMessage();
                 request.RequestUri = new Uri("http://mywebapi/api/values/1");
                 var response = await client.SendAsync(request);
                 ViewData["Message"] += " and " + await response.Content.ReadAsStringAsync();
             }
    }
   ```

1. In the *Index.cshtml* file, add a line to display `ViewData["Message"]` so that the file looks like the following code:
    
      ```cshtml
      @page
      @model IndexModel
      @{
          ViewData["Title"] = "Home page";
      }
    
      <div class="text-center">
          <h1 class="display-4">Welcome</h1>
          <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
          <p>@ViewData["Message"]</p>
      </div>
      ```

1. Now in the Web API project, add code to the Values controller to customize the message returned by the API for the call you added from webfrontend.
    
      ```csharp
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "webapi (with value " + id + ")";
        }
      ```

1. Choose **Add > Container Orchestrator Support**. The Docker Support Options dialog appears.

1. Choose **Docker**.

1. Choose your Target OS, for example, Linux.

   ![Screenshot of choosing the Target OS](media/tutorial-multicontainer/docker-tutorial-docker-support-options.PNG)

   Visual Studio creates a *docker-compose.yml* file and a *.dockerignore* file in the **docker-compose** node in the solution, and that project shows in boldface font, which shows that it's the startup project.

   ![Screenshot of Solution Explorer with docker-compose project added](media/tutorial-multicontainer/multicontainer-solution-explorer.png)

   The *docker-compose.yml* appears as follows:

   ```yaml
   version: '3.4'

    services:
      webfrontend1:
        image: ${DOCKER_REGISTRY-}webfrontend1
        build:
          context: .
          dockerfile: WebFrontEnd1/Dockerfile
   ```

   The *.dockerignore* file contains file types and extensions that you don't want Docker to include in the container. These files are generally associated with the development environment and source control, not part of the app or service you're developing.

   Look at the **Container Tools** section of the output pane for details of the commands being run.  You can see the command-line tool docker-compose is used to configure and create the runtime containers.

    ```
    ========== Preparing Containers ==========
    Getting Docker containers ready...
    docker-compose  -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.override.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose10243089518349574417 --no-ansi config
    services:
      webfrontend1:
        build:
          context: C:\Users\ghogen\Source\Repos\WebFrontEnd1
          dockerfile: WebFrontEnd1/Dockerfile
          target: base
        entrypoint: tail -f /dev/null
        environment:
          ASPNETCORE_ENVIRONMENT: Development
          ASPNETCORE_HTTPS_PORT: '44363'
          ASPNETCORE_URLS: https://+:443;http://+:80
          DOTNET_USE_POLLING_FILE_WATCHER: '1'
          NUGET_FALLBACK_PACKAGES: /root/.nuget/fallbackpackages
        image: webfrontend1:dev
        labels:
          com.microsoft.visualstudio.debuggee.arguments: ' --additionalProbingPath /root/.nuget/packages
            --additionalProbingPath /root/.nuget/fallbackpackages  bin/Debug/netcoreapp2.2/WebFrontEnd1.dll'
          com.microsoft.visualstudio.debuggee.killprogram: /bin/sh -c "if PID=$$(pidof
            dotnet); then kill $$PID; fi"
          com.microsoft.visualstudio.debuggee.program: dotnet
          com.microsoft.visualstudio.debuggee.workingdirectory: /app
        ports:
        - published: 65023
          target: 80
        - published: 44363
          target: 443
        volumes:
        - C:\Users\ghogen\Source\Repos\WebFrontEnd1\WebFrontEnd1:/app:rw
        - C:\Users\ghogen\vsdbg\vs2017u5:/remote_debugger:ro
        - C:\Users\ghogen\AppData\Roaming\ASP.NET\Https:/root/.aspnet/https:ro
        - C:\Users\ghogen\AppData\Roaming\Microsoft\UserSecrets:/root/.microsoft/usersecrets:ro
        - C:\Program Files\dotnet\sdk\NuGetFallbackFolder:/root/.nuget/fallbackpackages:ro
        - C:\Users\ghogen\.nuget\packages:/root/.nuget/packages:ro
    version: '3.4'
    docker ps --filter "status=running" --filter "name=dockercompose10243089518349574417_webfrontend1_" --format {{.ID}} -n 1
    docker-compose  -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.override.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose10243089518349574417 --no-ansi build 
    Building webfrontend1
    Step 1/4 : FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
     ---> 1546a743482d
    Step 2/4 : WORKDIR /app
     ---> Using cache
     ---> e253ced0bf5a
    Step 3/4 : EXPOSE 80
     ---> Using cache
     ---> 657e4ee51594
    Step 4/4 : EXPOSE 443
     ---> Using cache
     ---> cfc72ff38d00
    Successfully built cfc72ff38d00
    Successfully tagged webfrontend1:dev
    docker-compose  -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.override.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose10243089518349574417 --no-ansi up -d --no-build --force-recreate --remove-orphans
    Creating network "dockercompose10243089518349574417_default" with the default driver
    Creating dockercompose10243089518349574417_webfrontend1_1 ... 
    Creating dockercompose10243089518349574417_webfrontend1_1 ... done
    Done!  Docker containers are ready.
    ```

1. In the Web API project, again right-click on the project node, and choose **Add** > **Container Orchestrator Support**. Choose **Docker Compose**, and then select the same target OS.  When prompted whether you want to overwrite the existing Dockerfile, choose yes.

    Visual Studio makes some changes to your docker compose YML file. Now both containers are included.

    ```yaml
    version: '3.4'
    
    services:
      webfrontend1:
        image: ${DOCKER_REGISTRY-}webfrontend1
        build:
          context: .
          dockerfile: WebFrontEnd1/Dockerfile
    
      mywebapi:
        image: ${DOCKER_REGISTRY-}mywebapi
        build:
          context: .
          dockerfile: MyWebAPI/Dockerfile
    ```

1. Run the site locally now (F5 or CTRL+F5) to verify that it works as expected. If everything works as expected, you see the message "Hello from webfrontend and webapi (with value 1)."

## Next steps

When you're ready to deploy the multicontainer app, you'll need to decide what container orchestrator to use. You can use [Service Fabric](/azure/service-fabric/service-fabric-host-app-in-a-container) or [Azure Kubernetes Service (AKS)](/azure/aks).

## See Also

[Docker Compose](https://docs.docker.com/compose/)

[Service Fabric Overview](/azure/service-fabric/service-fabric-overview)

[Azure Kubernetes Service](/azure/aks)
