---
title: Visual Studio Tools for Docker on Windows
description: Get to know the Docker tools available in Visual Studio
author: ghogen
ms.author: ghogen
ms.date: 03/20/2019
ms.technology: vs-azure
---
# Docker in Visual Studio on Windows

::: moniker range="vs-2017"
The tools included in Visual Studio for developing with containers are easy to use, and greatly simplify the build, run, and compose tasks. You can also run and debug your containers by using the usual **F5** and **Ctrl**+**F5** keys from Visual Studio. You can even debug a whole solution if its containers are defined in the same *docker-compose.yml* file at the solution level.
::: moniker-end
::: moniker range=">=vs-2019"
The tools included in Visual Studio 2019 for developing with containers are easy to use, and greatly simplify the build, run, and compose tasks. You can also run and debug your containers by using the usual **F5** and **Ctrl**+**F5** keys from Visual Studio. You can even debug a whole solution if its containers are defined in the same *docker-compose.yml* file at the solution level.
::: moniker-end

> [!NOTE]
> This article applies to Visual Studio on Windows, and not Visual Studio for Mac.

> [!TIP]
> To learn more about installing Docker for Windows, see [Docker Desktop for Windows](https://docs.docker.com/docker-for-windows/).

## Docker support in Visual Studio

::: moniker range="vs-2017"
There are two levels of Docker support you can add to a project. In ASP.NET Core projects, you can just add a *Dockerfile* file to the project by enabling Docker support. The next level is container orchestration support, which adds a *Dockerfile* to the project (if it doesn't already exist) and a *docker-compose.yml* file at the solution level. Container orchestration support, via Docker Compose, is added by default in Visual Studio 2017 versions 15.0 to 15.7. Container orchestration support is an opt-in feature Visual Studio 2017 versions 15.8 or later. Version 15.8 and later support Docker Compose and Service Fabric.
::: moniker-end
::: moniker range=">=vs-2019"
There are two levels of Docker support you can add to a project. In ASP.NET Core projects, you can just add a *Dockerfile* file to the project by enabling Docker support. The next level is container orchestration support, which adds a *Dockerfile* to the project (if it doesn't already exist) and a *docker-compose.yml* file at the solution level.  Container orchestration support is an optional feature in Visual Studio 2019, which supports Docker Compose, Kubernetes, and Service Fabric.
::: moniker-end

The **Add > Docker Support** and **Add > Container Orchestrator Support** commands are located on the right-click menu (or context menu) of the project node for an ASP.NET Core project in **Solution Explorer**, as shown in the following screenshot:

![Add Docker Support menu option in Visual Studio](./media/visual-studio-tools-for-docker/add-docker-support-menu.png)

### Add Docker support

You can add Docker support to an existing ASP.NET Core project by selecting **Add** > **Docker Support** in **Solution Explorer**. You can also enable Docker support during project creation by selecting **Enable Docker Support** in the **New ASP.NET Core Web Application** dialog box that opens after you click **OK** in the **New Project** dialog box, as shown in the following screenshot.

::: moniker range="vs-2017"
![Enable Docker Support for new ASP.NET Core web app in Visual Studio](./media/visual-studio-tools-for-docker/enable-docker-support-visual-studio.png)
::: moniker-end
::: moniker range=">=vs-2019"
![Enable Docker Support for new ASP.NET Core web app in Visual Studio](./media/visual-studio-tools-for-docker/vs-2019/enable-docker-support-visual-studio.png)
::: moniker-end

When you add or enable Docker support, Visual Studio adds a *Dockerfile* file to the project.

::: moniker range="vs-2017"
> [!NOTE]
> When you enable Docker Compose support during project creation for a ASP.NET project (.NET Framework, not a .NET Core project) as shown in the following screenshot, container orchestration support is also added.

![Enable Docker compose support for an ASP.NET project](media/visual-studio-tools-for-docker/enable-docker-compose-support.png)
::: moniker-end

### Add container orchestration support

When you want to compose a multi-container solution, add container orchestration support to your projects. This lets you run and debug a group of containers (a whole solution) at the same time if they're defined in the same *docker-compose.yml* file.

To add container orchestration support, right-click on the solution or project node in **Solution Explorer**, and choose **Add > Container Orchestration Support**. Then choose **Docker Compose**, **Kubernetes/Helm**, or **Service Fabric** to manage the containers.

After you add container orchestration support to your project, you see a *Dockerfile* added to the project and a **docker-compose** folder added to the solution in **Solution Explorer**, as shown here:

![Docker files in Solution Explorer in Visual Studio](media/visual-studio-tools-for-docker/docker-support-solution-explorer.png)

If *docker-compose.yml* already exists, Visual Studio just adds the required lines of configuration code to it.

## Configure Docker tools

From the main menu, choose **Tools > Options**, and expand **Container Tools > Settings**. The container tools settings appear.

![Visual Studio Docker tools options, showing: Automatically pull required Docker images on project load, Automatically start containers in background, Automatically kill containers on solution close, and Do not prompt for trusting SSL certificate.](./media/visual-studio-tools-for-docker/visual-studio-docker-tools-options.png)

The following table might help you decide how to set these options.

| Name | Default Setting | Applies To | Description |
| -----|:---------------:|:----------:| ----------- |
| Automatically pull required Docker images on project load | On | Docker Compose | For increased performance when loading projects, Visual Studio will start a Docker pull operation in the background so that when you're ready to run your code, the image is already downloaded or in the process of downloading. If you're just loading projects and browsing code, you can turn this off to avoid downloading container images you don't need. |
| Automatically start containers in background | On | Docker Compose | Again for increased performance, Visual Studio creates a container with volume mounts ready for when you build and run your container. If you want to control when your container is created, turn this off. |
| Automatically kill containers on solution close | On | Docker Compose | Turn this off if you would like containers for your solution to continue to run after closing the solution or closing Visual Studio. |
| Do not prompt for trusting localhost SSL certificate | Off | ASP.NET Core 2.1 projects | If the localhost SSL certificate is not trusted, Visual Studio will prompt every time you run your project, unless this checkbox is checked. |

> [!WARNING]
> If the localhost SSL certificate is not trusted, and you check the box to suppress prompting, then HTTPS web requests might fail at runtime in your app or service. In that case, uncheck the **Do not prompt** checkbox, run your project, and indicate trust at the prompt.

## Next steps

For further details on the services implementation and use of Visual Studio tools for working with containers, read the following articles:

[Debugging apps in a local Docker container](vs-azure-tools-docker-edit-and-refresh.md)

[Deploy an ASP.NET container to a container registry using Visual Studio](vs-azure-tools-docker-hosting-web-apps-in-docker.md)
