---
title: Visual Studio Container Tools with ASP.NET Core and React.js
titleSuffix: ""
ms.custom: SEO-VS-2020
author: ghogen
description: Learn how to create a containerized React SPA app with Visual Studio Container Tools and Docker 
ms.author: ghogen
ms.date: 08/25/2022
ms.technology: vs-container-tools
ms.topic: quickstart
---
# Quickstart: Use Docker with a React Single-page App in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

With Visual Studio, you can easily build, debug, and run containerized ASP.NET Core apps, including those with client-side JavaScript such as React.js single-page app, and publish them to Azure Container Registry, Docker Hub, Azure App Service, or your own container registry. In this article, we'll publish to Azure Container Registry.

## Prerequisites

::: moniker range="vs-2019"
* [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads) with the **Web Development**, **Azure Tools** workload, and/or **.NET Core cross-platform development** workload installed
* [.NET Core 3.1 Development Tools](https://dotnet.microsoft.com/download/dotnet-core/3.1) for development with .NET Core 3.1.
* To publish to Azure Container Registry, an Azure subscription. [Sign up for a free trial](https://azure.microsoft.com/offers/ms-azr-0044p/).
* [Node.js](https://nodejs.org/en/download/)
* For Windows containers, Windows 10 version 1809 or later, to use the Docker images referenced in this article.
::: moniker-end
::: moniker range=">=vs-2022"
* [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
* [Visual Studio 2022](https://visualstudio.microsoft.com/downloads) with the **Web Development**, **Azure Tools** workload, and/or **.NET Core cross-platform development** workload installed
* To publish to Azure Container Registry, an Azure subscription. [Sign up for a free trial](https://azure.microsoft.com/offers/ms-azr-0044p/).
* [Node.js](https://nodejs.org/en/download/)
* For Windows containers, Windows 10 version 1809 or later, to use the Docker images referenced in this article.

::: moniker-end

## Installation and setup

For Docker installation, first review the information at [Docker Desktop for Windows: What to know before you install](https://docs.docker.com/docker-for-windows/install/#what-to-know-before-you-install). Next, install [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows).

## Create a project and add Docker support

::: moniker range="vs-2019"

1. Create a new project using the **ASP.NET Core with React.js** template.

   ![Screenshot of creating a new React.js project.](media/container-tools-react/vs-2019/create-reactjs-project.png)

1. On the **Additional information** screen, you can't select **Enable Docker Support**, but don't worry, you can add that support later.

   ![Screenshot of creating a new React.js project - Additional information screen.](media/container-tools-react/vs-2019/new-react-project-additional-information.png)

1. Right-click on the project node, and choose **Add** > **Docker Support** to add a Dockerfile to your project.

   ![Screenshot of Add Docker support menu item.](media/container-tools-react/vs-2017/add-docker-support.png)

1. Select the container type.
::: moniker-end
::: moniker range=">=vs-2022"

1. Create a new project using the **ASP.NET Core with React.js** template.

   ![Screenshot of creating a new React.js project.](media/container-tools-react/vs-2022/create-reactjs-project.png)

1. On the **Additional information** screen, you can't select **Enable Docker Support**, but don't worry, you can add that support later.

   ![Screenshot of creating a new React.js project - Additional information screen.](media/container-tools-react/vs-2022/react-project-additional-information.png)

1. Right-click on the project node, and choose **Add** > **Docker Support** to add a Dockerfile to your project.

   ![Screenshot of Add Docker support menu item.](media/container-tools-react/vs-2022/add-docker-support.png)

1. Select the container type.
:::moniker-end

The next step is different depending on whether you're using Linux containers or Windows containers.

## Modify the Dockerfile (Linux containers)

A *Dockerfile*, the recipe for creating a final Docker image, is created in the project. Refer to [Dockerfile reference](https://docs.docker.com/engine/reference/builder/) for an understanding of the commands within it.

Open the *Dockerfile* in the project, and add the following lines to install curl, Node.js 14.x, and certain required Node libraries in the container. Be sure to add these lines both in the first section, to add the installation of the Node package manager *npm.exe* to the base image, as well as in the `build` section.

```Dockerfile
RUN apt-get update
RUN apt-get install -y curl
RUN apt-get install -y libpng-dev libjpeg-dev curl libxi6 build-essential libgl1-mesa-glx
RUN curl -sL https://deb.nodesource.com/setup_lts.x | bash -
RUN apt-get install -y nodejs
```

The *Dockerfile* should now look something like this:

:::moniker range="<=vs-2019"

```Dockerfile
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
RUN apt-get update
RUN apt-get install -y curl
RUN apt-get install -y libpng-dev libjpeg-dev curl libxi6 build-essential libgl1-mesa-glx
RUN curl -sL https://deb.nodesource.com/setup_lts.x | bash -
RUN apt-get install -y nodejs

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
RUN apt-get update
RUN apt-get install -y curl
RUN apt-get install -y libpng-dev libjpeg-dev curl libxi6 build-essential libgl1-mesa-glx
RUN curl -sL https://deb.nodesource.com/setup_lts.x | bash -
RUN apt-get install -y nodejs
WORKDIR /src
COPY ["ProjectSPA1/ProjectSPA1.csproj", "ProjectSPA1/"]
RUN dotnet restore "ProjectSPA1/ProjectSPA1.csproj"
COPY . .
WORKDIR "/src/ProjectSPA1"
RUN dotnet build "ProjectSPA1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectSPA1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectSPA1.dll"]
```

:::moniker-end
:::moniker range=">=vs-2022"

```Dockerfile
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
RUN apt-get update
RUN apt-get install -y curl
RUN apt-get install -y libpng-dev libjpeg-dev curl libxi6 build-essential libgl1-mesa-glx
RUN curl -sL https://deb.nodesource.com/setup_lts.x | bash -
RUN apt-get install -y nodejs

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
RUN apt-get update
RUN apt-get install -y curl
RUN apt-get install -y libpng-dev libjpeg-dev curl libxi6 build-essential libgl1-mesa-glx
RUN curl -sL https://deb.nodesource.com/setup_lts.x | bash -
RUN apt-get install -y nodejs
WORKDIR /src
COPY ["ProjectSPA1/ProjectSPA1.csproj", "ProjectSPA1/"]
RUN dotnet restore "ProjectSPA1/ProjectSPA1.csproj"
COPY . .
WORKDIR "/src/ProjectSPA1"
RUN dotnet build "ProjectSPA1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectSPA1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectSPA1.dll"]
```

:::moniker-end

The preceding *Dockerfile* is based on the [mcr.microsoft.com/dotnet/core/aspnet](https://hub.docker.com/_/microsoft-dotnet-core-aspnet/) image, and includes instructions for modifying the base image by building your project and adding it to the container.

When the new project dialog's **Configure for HTTPS** check box is checked, the *Dockerfile* exposes two ports. One port is used for HTTP traffic; the other port is used for HTTPS. If the check box isn't checked, a single port (80) is exposed for HTTP traffic.

## Modify the Dockerfile (Windows containers)

Open the project file by double-clicking on the project node, and update the project file (*.csproj) by adding the following property as a child of the `<PropertyGroup>` element:

   ```xml
    <DockerfileFastModeStage>base</DockerfileFastModeStage>
   ```

Update the Dockerfile by adding the following lines. This will copy node and npm to the container.

   1. Add ``# escape=` `` to the first line of the Dockerfile
   1. Add the following lines before `FROM … base`

      ```Dockerfile
      FROM mcr.microsoft.com/powershell AS downloadnodejs
      ENV NODE_VERSION=14.16.0
      SHELL ["pwsh", "-Command", "$ErrorActionPreference = 'Stop';$ProgressPreference='silentlyContinue';"]
      RUN Invoke-WebRequest -OutFile nodejs.zip -UseBasicParsing "https://nodejs.org/dist/v$($env:NODE_VERSION)/node-v$($env:NODE_VERSION)-win-x64.zip"; `
          Expand-Archive nodejs.zip -DestinationPath C:\; `
          Rename-Item "C:\node-v$($env:NODE_VERSION)-win-x64" c:\nodejs
      ```

   1. Add the following line before and after `FROM … build`

      ```Dockerfile
      COPY --from=downloadnodejs C:\nodejs\ C:\Windows\system32\
      ```

   1. The complete Dockerfile should now look something like this:

      :::moniker range="<=vs-2019"

      ```Dockerfile
      # escape=`
      #Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
      #For more information, please see https://aka.ms/containercompat
      FROM mcr.microsoft.com/powershell AS downloadnodejs
      ENV NODE_VERSION=14.16.0
      SHELL ["pwsh", "-Command", "$ErrorActionPreference = 'Stop';$ProgressPreference='silentlyContinue';"]
      RUN Invoke-WebRequest -OutFile nodejs.zip -UseBasicParsing "https://nodejs.org/dist/v$($env:NODE_VERSION)/node-v$($env:NODE_VERSION)-win-x64.zip"; \
          Expand-Archive nodejs.zip -DestinationPath C:\; \
          Rename-Item "C:\node-v$($env:NODE_VERSION)-win-x64" c:\nodejs

      FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
      WORKDIR /app
      EXPOSE 80
      EXPOSE 443
      COPY --from=downloadnodejs C:\nodejs\ C:\Windows\system32\

      FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
      COPY --from=downloadnodejs C:\nodejs\ C:\Windows\system32\
      WORKDIR /src
      COPY ["ProjectSPA1/ProjectSPA1.csproj", "ProjectSPA1/"]
      RUN dotnet restore "ProjectSPA1/ProjectSPA1.csproj"
      COPY . .
      WORKDIR "/src/ProjectSPA1"
      RUN dotnet build "ProjectSPA1.csproj" -c Release -o /app/build

      FROM build AS publish
      RUN dotnet publish "ProjectSPA1.csproj" -c Release -o /app/publish

      FROM base AS final
      WORKDIR /app
      COPY --from=publish /app/publish .
      ENTRYPOINT ["dotnet", "ProjectSPA1.dll"]
      ```

      :::moniker-end
      :::moniker range=">=vs-2022"
      ```Dockerfile
      #See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images   for faster debugging.

      #Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
      #For more information, please see https://aka.ms/containercompat
      # escape=`
      FROM mcr.microsoft.com/powershell:nanoserver-1809 AS downloadnodejs
      ENV NODE_VERSION=14.16.0
      SHELL ["pwsh", "-Command", "$ErrorActionPreference = 'Stop';$ProgressPreference='silentlyContinue';"]
      RUN Invoke-WebRequest -OutFile nodejs.zip -UseBasicParsing "https://nodejs.org/dist/v$($env:NODE_VERSION)/node-v$($env:NODE_VERSION)-win-x64.zip"; Expand-Archive nodejs.zip -DestinationPath C:\; Rename-Item "C:\node-v$($env:NODE_VERSION)-win-x64" c:\nodejs

      FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
      WORKDIR /app
      EXPOSE 80
      EXPOSE 443
      COPY --from=downloadnodejs C:\\nodejs\\ C:\\Windows\\system32\\

      FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
      COPY --from=downloadnodejs C:\\nodejs\\ C:\\Windows\\system32\\
      WORKDIR /src
      COPY ["Project1-SPA-Windows/Project1-SPA-Windows.csproj", "Project1-SPA-Windows/"]
      RUN dotnet restore "Project1-SPA-Windows/Project1-SPA-Windows.csproj"
      COPY . .
      WORKDIR "/src/Project1-SPA-Windows"
      RUN dotnet build "Project1-SPA-Windows.csproj" -c Release -o /app/build

      FROM build AS publish
      RUN dotnet publish "Project1-SPA-Windows.csproj" -c Release -o /app/publish /p:UseAppHost=false

      FROM base AS final
      WORKDIR /app
      COPY --from=publish /app/publish .
      ENTRYPOINT ["dotnet", "Project1-SPA-Windows.dll"]
      ```

      ::: moniker-end

   1. Update the .dockerignore file by removing the `**/bin`.

## Debug

:::moniker range=">=vs-2022"
The project uses the SPA Proxy during debugging. See [Improved single-age app (SPA) templates](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-net-6-preview-4/#improved-single-page-app-spa-templates). When debugging, the JavaScript client runs on the host machine, but the ASP.NET Core server code runs in the container. When published, the proxy is not run, and the client code runs on the same server as the ASP.NET Core code.  You already have a Debug profile **Docker* that you can use to debug the server code. To debug the JavaScript client code, you can create an additional debug profile for debugging the JavaScript client code. You'll also need to start the proxy manually from a command prompt when debugging JavaScript. You can leave it running through many debug sessions.

1. Build the project, if not already built.

1. Open a Visual Studio dev command prompt, go to the ClientApp folder in your project, and then give the command, `npm run start`. You should see something like this:

   ```output
   Compiled successfully!

   You can now view project3_spa in the browser.

     Local:            https://localhost:44407
     On Your Network:  https://192.168.1.5:44407

   Note that the development build is not optimized.
   To create a production build, use npm run build.
   
   webpack compiled successfully
   ```

   Note the local URL. You'll need to provide this in a debug launch profile, which is stored in your *launchSettings.json* file.

1. Open the dropdown that contains debug profiles (next to the green triangle icon or **Start** button), and choose **{ProjectName} Debug Properties**, and choose the **Docker** profile.
1. Check the **Environment variables** section and add the following environment variables if not already present:

   ```
   ASPNETCORE_ENVIRONMENT=Development,ASPNETCORE_HOSTINGSTARTUPASSEMBLIES=Microsoft.AspNetCore.SpaProxy
   ```


1. Set the **URL** to `https://localhost:{proxy-port}` where `{proxy-port}` is the port from the proxy server (from step 1).

   ![Screenshot of Debug Launch Profile settings for client debugging.](./media/container-tools-react/vs-2022/launch-profiles-debugging.png)

   This action changes the Docker entry in the *launchSettings.json* file and launches the correct URL for the local proxy running on the host. Find the *launchSettings.json* file in **Solution Explorer** under **Properties**.

1. You should see something like the following code:

   ```json
   "profiles": {
      "Docker": {
         "commandName": "Docker",
         "launchBrowser": true,
         "environmentVariables": {
           "ASPNETCORE_ENVIRONMENT": "Development",
           "ASPNETCORE_HOSTINGSTARTUPASSEMBLIES": "Microsoft.AspNetCore.SpaProxy"
         },
         "launchUrl": "https://localhost:44407",
         "useSSL": true
      }
   }
   ```

   > [!IMPORTANT]
   > Do not set the launch settings option `publishAllPorts` to `true` if you are using a proxy. That option publishes all exposed ports to a random port, which won't work when you set a specific port in the SPA proxy.

1. Open the file *ClientApp/src/setupProxy.js* and change the line that sets the target to use the localhost address and port on the container. You can find the port on the **Ports** tab of the **Containers** window.

   ```JavaScript
   const target =  'https://localhost:{container-port}';
   ```

   If you're using HTTPS, be sure to choose the right port for HTTPS.

1. Launch the app with debugging (**F5**).

   ![Screenshot of running app.](media/container-tools-react/vs-2022/client-app-page.png)

   If you get a build error trying to write the output assemblies, you might have to stop a previously running container to unlock the files.

1. Verify that you can hit a breakpoint in client-side JavaScript code by setting a breakpoint in **ClientApp/src/components/Counter.js** in the **incrementCounter** function, and then try hitting the breakpoint by clicking the **Increment** button on the Counters page.

   ![Screenshot showing ebugging client-side JavaScript.](./media/container-tools-react/vs-2022/debugging-client-javascript.png)

1. Next, try hitting a breakpoint in the server-side ASP.NET Core code. Set a breakpoint in *WeatherController.cs* in the `Get` method and try appending `/weatherforecast` to the base localhost and port URL to activate that code.

   ![Screenshot showing debugging server-side ASP.NET Core code.](./media/container-tools-react/vs-2022/debugging-aspnet-core.png)

1. If the container port changes, which can happen if you make a significant change, such as updating *launchSettings.json* or updating the debug launch profile in the IDE, you'll need to update the port in *setupProxy.js* and also restart the proxy. Terminate the current proxy (**Ctrl**+**C** in the command window where it's running), and then restart it using the same command `npm run start`.

:::moniker-end

:::moniker range="vs-2019"

Select **Docker** from the debug drop-down in the toolbar, and start debugging the app. You might see a message with a prompt about trusting a certificate; choose to trust the certificate to continue.  The first time you build, Docker downloads the base images, so it might take a bit longer.

The **Container Tools** option in the **Output** window shows what actions are taking place. You should see the installation steps associated with *npm.exe*.

The browser shows the app's home page.

![Screenshot of running app.](media/container-tools-react/vs-2019/running-app.png)
:::moniker-end

:::moniker range=">=vs-2019"

## Containers window

Open the **Containers** tool window. You can find it on the menu under **View** > **Other Windows** > **Containers**, or press **Ctrl**+**Q** and start typing `containers` in the search box, then choose **Containers** window from the results. When the window comes up, dock it on the bottom under the editor pane.

The **Containers** window shows the running containers and lets you view information about them. You can view the environment variables, labels, ports, volumes, the file system, and logs. The toolbar buttons let you create a terminal (shell prompt) inside the container, attach the debugger, or prune unused containers. See [Use the Containers window](view-and-diagnose-containers.md).

![Screenshot of Containers window.](media/container-tools-react/vs-2022/container-tools-window.png)

Click on the **Files** tab, and expand the `app` folder to see your published application files.

You can also view the images and inspect information about them. Choose the **Images** tab, locate the one for your project, and then choose the **Details** tab to view a json file that contains information about an image.

![Screenshot of Containers window showing images and details.](media/container-tools-react/vs-2022/container-tools-window-images-details.png)

> [!NOTE]
> The **dev** image does not contain the app binaries and other content, as **Debug** configurations use volume mounting to provide the iterative edit and debug experience. To create a production image containing all contents, use the **Release** configuration.

:::moniker-end

## Publish Docker images

Once the develop and debug cycle of the app is completed, you can create a production image of the app.

:::moniker range="vs-2019"

1. Change the configuration drop-down to **Release** and build the app.
1. Right-click your project in **Solution Explorer** and choose **Publish**.
1. On the publish target dialog, select **Docker Container Registry**.

   ![Choose Docker Container Registry.](media/container-tools-react/vs-2019/publish-dialog1.png)

1. Next, choose **Azure Container Registry**.

   ![Choose Azure Container Registry.](media/container-tools-react/vs-2019/publish-dialog-azure-container-registry.png)

1. Choose **Create a new Azure Container Registry**.
1. Fill in your desired values in the **Create new Azure Container Registry** screen.

    | Setting      | Suggested value  | Description                                |
    | ------------ |  ------- | -------------------------------------------------- |
    | **DNS Prefix** | Globally unique name | Name that uniquely identifies your container registry. |
    | **Subscription** | Choose your subscription | The Azure subscription to use. |
    | **[Resource Group](/azure/azure-resource-manager/resource-group-overview)** | myResourceGroup |  Name of the resource group in which to create your container registry. Choose **New** to create a new resource group.|
    | **[SKU](/azure/container-registry/container-registry-skus)** | Standard | Service tier of the container registry  |
    | **Registry Location** | A location close to you | Choose a Location in a [region](https://azure.microsoft.com/regions/) near you or near other services that will use your container registry. |

    ![Screenshot of Visual Studio's create Azure Container Registry dialog.](media/container-tools-react/vs-2019/azure-container-registry-details.png)

1. Select **Create**, and then select **Finish**.

   ![Screenshot showing Select or create a new Azure Container Registry.](media/container-tools-react/vs-2019/publish-dialog2.png)

   When the publish process ends, you can review the publish settings, and edit them, when needed, or publish the image again using the **Publish** button.

   ![Screenshot showing successful publish.](media/container-tools-react/vs-2019/publish-finished.png)

   To start again using the **Publish** dialog, delete the publish profile by using the **Delete** link on this page, and then choose **Publish** again.
:::moniker-end

:::moniker range=">=vs-2022"

1. Change the configuration drop-down to **Release** and build the app.
1. Right-click your project in **Solution Explorer** and choose **Publish**.
1. On the publish target dialog, select **Docker Container Registry**.

   ![Screenshot showing Choose Docker Container Registry.](media/container-tools-react/vs-2022/publish-dialog-1.png)

1. Next, choose **Azure Container Registry**.

   ![Screenshot showing Choose Azure Container Registry.](media/container-tools-react/vs-2022/publish-dialog-azure-container-registry.png)

1. Choose **Create a new Azure Container Registry**.
1. Fill in your desired values in the **Create new Azure Container Registry** screen.

    | Setting      | Suggested value  | Description                                |
    | ------------ |  ------- | -------------------------------------------------- |
    | **DNS Prefix** | Globally unique name | Name that uniquely identifies your container registry. |
    | **Subscription** | Choose your subscription | The Azure subscription to use. |
    | **[Resource Group](/azure/azure-resource-manager/resource-group-overview)** | myResourceGroup |  Name of the resource group in which to create your container registry. Choose **New** to create a new resource group.|
    | **[SKU](/azure/container-registry/container-registry-skus)** | Standard | Service tier of the container registry  |
    | **Registry Location** | A location close to you | Choose a Location in a [region](https://azure.microsoft.com/regions/) near you or near other services that will use your container registry. |

    ![Screenshot of Visual Studio's create Azure Container Registry dialog.](media/container-tools-react/vs-2022/azure-container-registry-details.png)

1. Select **Create**, and then select **Finish**.

   ![Screenshot showing Select or create a new Azure Container Registry.](media/container-tools-react/vs-2022/publish-dialog-2.png)

   When the publish process ends, you can review the publish settings, and edit them, when needed, or publish the image again using the **Publish** button.

   :::image type="content" alt-text="Screenshot showing successful publish" source="media/container-tools-react/vs-2022/publish-succeeded.png" lightbox="media/container-tools-react/vs-2022/publish-succeeded.png":::

   To start again using the **Publish** dialog, delete the publish profile by using the **Delete** link on this page, and then choose **Publish** again.
:::moniker-end

## Next steps

You can now pull the container from the registry to any host capable of running Docker images, for example [Azure Container Instances](/azure/container-instances/container-instances-tutorial-deploy-app).

## Additional resources

* [Container development with Visual Studio](./index.yml)
* [Troubleshoot Visual Studio development with Docker](troubleshooting-docker-errors.md)
* [Visual Studio Container Tools GitHub repository](https://github.com/Microsoft/DockerTools)

