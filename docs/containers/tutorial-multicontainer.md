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

In this tutorial, you'll learn how to manage more than one container and communicate between them when using Container Tools in Visual Studio, and then deploy it to Azure App Service.

## Prerequisities

## Step 1: Create a web site project

1. In Visual Studio, create an **ASP.NET Core Web Application** project, named *WebFrontEnd*. Select **Web Application** to create a web application with Razor pages. Be sure that Enable Docker Support is selected, and that the container OS matches the OS selected in Docker Desktop.
   
   ![Screenshot of creating the web front end project](./media/docker-tutorial-enable-docker-support.png)

## Step 2: Create a web api project

1. Add a project to the same solution and call it MyWebAPI. Select *API* as the project type.
   
   ![Screenshot of creating the Web API project](./media/docker-tutorial-mywebapi.png)

## Step 3: Add code to call the web api

1. In the WebFrontEnd project, open the About controller and replace the About method with the following code.
   
   ```csharp
    public async Task<IActionResult> About()
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
    
       return View();
    }
   ```

1. Choose **Add > Container Orchestrator Support**. The Docker Support Options dialog appears.

1. Choose **Docker**.

1. your Target OS, for example, Linux.

A *docker-compose.yml* file and a *.dockerignore* file are created in the docker-compose node in the solution.

The docker-compose.yml appears as follows:

```yaml
version: '3.4'

services:
  webfrontend1:
    image: ${DOCKER_REGISTRY-}webfrontend1
    build:
      context: .
      dockerfile: WebFrontEnd1/Dockerfile
```

The .dockerignore file contains file types and extensions that you don't want Docker to include in the container. These are generally files associated with the development environment and source control, not part of the app or service you're developing.


```output
========== Checking for Container Prerequisites ==========
Verifying that Docker for Windows is installed...
Docker for Windows is installed.
========== Verifying that Docker for Windows is running... ==========
Verifying that Docker for Windows is running...
Docker for Windows is running.
========== Verifying Docker OS ==========
Verifying that Docker for Windows' operating system mode matches the project's target operating system...
Docker for Windows' operating system mode matches the project's target operating system.
========== Pulling Required Images ==========
Checking for missing Docker images...
Docker images are ready.
Starting up container(s)...
docker run -dt -v "C:\Users\ghogen\vsdbg\vs2017u5:/remote_debugger:rw" -v "C:\Users\ghogen\Source\Repos\HelloDockerTools\HelloDockerTools:/app" -v "C:\Users\ghogen\AppData\Roaming\ASP.NET\Https:/root/.aspnet/https:ro" -v "C:\Users\ghogen\AppData\Roaming\Microsoft\UserSecrets:/root/.microsoft/usersecrets:ro" -v "C:\Users\ghogen\.nuget\packages\:/root/.nuget/fallbackpackages2" -v "C:\Program Files\dotnet\sdk\NuGetFallbackFolder:/root/.nuget/fallbackpackages" -e "DOTNET_USE_POLLING_FILE_WATCHER=1" -e "ASPNETCORE_ENVIRONMENT=Development" -e "ASPNETCORE_URLS=https://+:443;http://+:80" -e "ASPNETCORE_HTTPS_PORT=44342" -e "NUGET_PACKAGES=/root/.nuget/fallbackpackages2" -e "NUGET_FALLBACK_PACKAGES=/root/.nuget/fallbackpackages;/root/.nuget/fallbackpackages2" -p 52036:80 -p 44342:443 --entrypoint tail hellodockertools:dev -f /dev/null 
cf5d2ef5f19a188b36fd626fc57a9da6d780da64b86e3ecc6708b62ac1bbe4f1
Container started successfully.
========== Finished ==========

========== Closing Solution ==========
Shutting down running containers.
========== Checking for Container Prerequisites ==========
Verifying that Docker for Windows is installed...
Docker for Windows is installed.
========== Verifying that Docker for Windows is running... ==========
Verifying that Docker for Windows is running...
Docker for Windows is running.
========== Verifying Docker OS ==========
Verifying that Docker for Windows' operating system mode matches the project's target operating system...
Docker for Windows' operating system mode matches the project's target operating system.
========== Pulling Required Images ==========
Checking for missing Docker images...
Docker images are ready.
Starting up container(s)...
docker build -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\WebFrontEnd1\Dockerfile" -t webfrontend1:dev --target base  --label "com.microsoft.created-by=visual-studio" "C:\Users\ghogen\Source\Repos\WebFrontEnd1" 
Sending build context to Docker daemon  3.927MB

Step 1/5 : FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
 ---> 1546a743482d
Step 2/5 : WORKDIR /app
 ---> Using cache
 ---> e253ced0bf5a
Step 3/5 : EXPOSE 80
 ---> Using cache
 ---> 657e4ee51594
Step 4/5 : EXPOSE 443
 ---> Using cache
 ---> cfc72ff38d00
Step 5/5 : LABEL com.microsoft.created-by=visual-studio
 ---> Using cache
 ---> 327819f37584
Successfully built 327819f37584
Successfully tagged webfrontend1:dev
SECURITY WARNING: You are building a Docker image from Windows against a non-Windows Docker host. All files and directories added to build context will have '-rwxr-xr-x' permissions. It is recommended to double check and reset permissions for sensitive files and directories.
C:\WINDOWS\System32\WindowsPowerShell\v1.0\powershell.exe -NonInteractive -NoProfile -WindowStyle Hidden -ExecutionPolicy RemoteSigned -File "C:\Users\ghogen\AppData\Local\Temp\GetVsDbg.ps1" -Version vs2017u5 -RuntimeID linux-x64 -InstallPath "C:\Users\ghogen\vsdbg\vs2017u5"
Info: Using vsdbg version '16.0.11220.2'
Info: Using Runtime ID 'linux-x64'
Info: Latest version of VsDbg is present. Skipping downloads
C:\WINDOWS\System32\WindowsPowerShell\v1.0\powershell.exe -NonInteractive -NoProfile -WindowStyle Hidden -ExecutionPolicy RemoteSigned -File "C:\Users\ghogen\AppData\Local\Temp\GetVsDbg.ps1" -Version vs2017u5 -RuntimeID linux-musl-x64 -InstallPath "C:\Users\ghogen\vsdbg\vs2017u5\linux-musl-x64"
Info: Using vsdbg version '16.0.11220.2'
Info: Using Runtime ID 'linux-musl-x64'
Info: Latest version of VsDbg is present. Skipping downloads
docker run -dt -v "C:\Users\ghogen\vsdbg\vs2017u5:/remote_debugger:rw" -v "C:\Users\ghogen\Source\Repos\WebFrontEnd1\WebFrontEnd1:/app" -v "C:\Users\ghogen\AppData\Roaming\ASP.NET\Https:/root/.aspnet/https:ro" -v "C:\Users\ghogen\AppData\Roaming\Microsoft\UserSecrets:/root/.microsoft/usersecrets:ro" -v "C:\Users\ghogen\.nuget\packages\:/root/.nuget/fallbackpackages2" -v "C:\Program Files\dotnet\sdk\NuGetFallbackFolder:/root/.nuget/fallbackpackages" -e "DOTNET_USE_POLLING_FILE_WATCHER=1" -e "ASPNETCORE_ENVIRONMENT=Development" -e "ASPNETCORE_URLS=https://+:443;http://+:80" -e "ASPNETCORE_HTTPS_PORT=44364" -e "NUGET_PACKAGES=/root/.nuget/fallbackpackages2" -e "NUGET_FALLBACK_PACKAGES=/root/.nuget/fallbackpackages;/root/.nuget/fallbackpackages2" -p 65024:80 -p 44364:443 --entrypoint tail webfrontend1:dev -f /dev/null 
df87688bed8110c78137a324e8a395e74c64485631ca57bf7de6abc69021b651
Container started successfully.
========== Finished ==========
```

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

1. In the webapi project, again right-click on the project node, and choose Add > Container Orchestrator Support. Choose Docker Compose, and then select the same TargetOS.  When prompted whether you want to overwrite the existing Dockerfile, choose yes.

```output
========== Preparing Containers ==========
Getting Docker containers ready...
docker-compose  -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.override.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose10243089518349574417 --no-ansi config
services:
  mywebapi:
    build:
      context: C:\Users\ghogen\Source\Repos\WebFrontEnd1
      dockerfile: MyWebAPI/Dockerfile
      target: base
    entrypoint: tail -f /dev/null
    environment:
      ASPNETCORE_ENVIRONMENT: Development
      ASPNETCORE_HTTPS_PORT: '44361'
      ASPNETCORE_URLS: https://+:443;http://+:80
      DOTNET_USE_POLLING_FILE_WATCHER: '1'
      NUGET_FALLBACK_PACKAGES: /root/.nuget/fallbackpackages
    image: mywebapi:dev
    labels:
      com.microsoft.visualstudio.debuggee.arguments: ' --additionalProbingPath /root/.nuget/packages
        --additionalProbingPath /root/.nuget/fallbackpackages  bin/Debug/netcoreapp2.2/MyWebAPI.dll'
      com.microsoft.visualstudio.debuggee.killprogram: /bin/sh -c "if PID=$$(pidof
        dotnet); then kill $$PID; fi"
      com.microsoft.visualstudio.debuggee.program: dotnet
      com.microsoft.visualstudio.debuggee.workingdirectory: /app
    ports:
    - published: 65119
      target: 80
    - published: 44361
      target: 443
    volumes:
    - C:\Users\ghogen\Source\Repos\WebFrontEnd1\MyWebAPI:/app:rw
    - C:\Users\ghogen\vsdbg\vs2017u5:/remote_debugger:ro
    - C:\Users\ghogen\AppData\Roaming\ASP.NET\Https:/root/.aspnet/https:ro
    - C:\Users\ghogen\AppData\Roaming\Microsoft\UserSecrets:/root/.microsoft/usersecrets:ro
    - C:\Program Files\dotnet\sdk\NuGetFallbackFolder:/root/.nuget/fallbackpackages:ro
    - C:\Users\ghogen\.nuget\packages:/root/.nuget/packages:ro
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
docker ps --filter "status=running" --filter "name=dockercompose10243089518349574417_mywebapi_" --format {{.ID}} -n 1
docker ps --filter "status=running" --filter "name=dockercompose10243089518349574417_webfrontend1_" --format {{.ID}} -n 1
0ad9b304b3ca
docker exec -i 0ad9b304b3ca /bin/sh -c "if PID=$(pidof dotnet); then kill $PID; fi"
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
Building mywebapi
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
Successfully tagged mywebapi:dev
docker-compose  -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\docker-compose.override.yml" -f "C:\Users\ghogen\Source\Repos\WebFrontEnd1\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose10243089518349574417 --no-ansi up -d --no-build --force-recreate --remove-orphans
Recreating dockercompose10243089518349574417_webfrontend1_1 ... 
Creating dockercompose10243089518349574417_mywebapi_1       ... 
Creating dockercompose10243089518349574417_mywebapi_1       ... done
Recreating dockercompose10243089518349574417_webfrontend1_1 ... done
Done!  Docker containers are ready.
```

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

## Deploy to Azure App Service