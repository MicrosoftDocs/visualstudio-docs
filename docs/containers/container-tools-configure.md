---
title: Configure Visual Studio Container Tools
description: Configure the tools available in Visual Studio for working with Docker containers.
author: ghogen
ms.author: ghogen
ms.topic: how-to
ms.date: 09/17/2021
ms.technology: vs-container-tools
---
# How to configure Visual Studio Container Tools

Using Visual Studio settings, you can control some aspects of how Visual Studio works with Docker containers, including settings that affect performance and resource usage when working with Docker containers.

## Container Tools settings

From the main menu, choose **Tools > Options**, and expand **Container Tools > Settings**. The container tools settings appear.

::: moniker range="vs-2017"

![Visual Studio Container Tools options, showing: Automatically pull required Docker images on project load, Automatically start containers in background, Automatically kill containers on solution close, and Do not prompt for trusting SSL certificate.](./media/overview/visual-studio-docker-tools-options.png)
::: moniker-end

::: moniker range=">=vs-2019"

Container Tools **General** settings:

![Visual Studio Container Tools options, showing: Install Docker Desktop if needed, and Trust ASP.NET Core SSL certificate.](./media/configure-container-tools/tools-options-1.png)

Container Tools **Single Project** and **Docker Compose** settings:

![Visual Studio Container Tools options, showing: Kill containers on project close, Pull required Docker images on project open, and Run containers on project open.](./media/configure-container-tools/tools-options-2.png)
::: moniker-end

The following table might help you decide how to set these options.

::: moniker range="vs-2017"
| Name | Default Setting | Applies To | Description |
| -----|:---------------:|:----------:| ----------- |
| Automatically pull required Docker images on project load | On | Docker Compose | For increased performance when loading projects, Visual Studio will start a Docker pull operation in the background so that when you're ready to run your code, the image is already downloaded or in the process of downloading. If you're just loading projects and browsing code, you can turn this off to avoid downloading container images you don't need. |
| Automatically start containers in background | On | Docker Compose | Again for increased performance, Visual Studio creates a container with volume mounts ready for when you build and run your container. If you want to control when your container is created, turn this off. |
| Automatically kill containers on solution close | On | Docker Compose | Turn this off if you would like containers for your solution to continue to run after closing the solution or closing Visual Studio. |
| Do not prompt for trusting localhost SSL certificate | Off | ASP.NET Core 2.1 projects | If the localhost SSL certificate is not trusted, Visual Studio will prompt when you run an ASP.NET Core 2.x project, unless this checkbox is checked or the certificate was already trusted. |
::: moniker-end

::: moniker range=">=vs-2019"

The following table describes **General** settings:

| Name | Default Setting | Applies To | Description |
| -----|:---------------:|:----------:| ----------- |
| Install Docker Desktop if needed | Prompt Me | Single Project, Docker Compose | Choose whether you want to be prompted if Docker Desktop is not installed. |
| Trust ASP.NET Core SSL certificate | Prompt Me | ASP.NET Core 2.x projects | When set to **Prompt Me**, if the localhost SSL certificate is not trusted, Visual Studio will prompt every time you run an ASP.NET Core 2.x project. |

The following table describes **Single Project** and **Docker Compose** settings:

| Name | Default Setting | Applies To | Description |
| -----|:---------------:|:----------:| ----------- |
| Pull required Docker images on project open | True | Single Project, Docker Compose | For increased performance when loading projects, Visual Studio will start a Docker pull operation in the background so that when you're ready to run your code, the image is already downloaded or in the process of downloading. If you're just loading projects and browsing code, you can set to **False** to avoid downloading container images you don't need. |
| Pull updated Docker images on project open | .NET Core projects | Single Project, Docker Compose | When you open a project, check for updates to images and download if available. |
| Run containers on project open | True | Single Project, Docker Compose | Again for increased performance, Visual Studio creates a container ahead of time so that it's ready for when you build and run your container. If you want to control when your container is created, set to **False**. |
| Remove containers on project close | True | Single Project, Docker Compose | Set to **False** if you would like containers for your solution to be retained after closing the solution or closing Visual Studio. |

The **Containers Tool Window** settings control the settings that apply to the **Containers** tool window, which shows information about Docker containers and images. See [Use the Containers window](view-and-diagnose-containers.md)

![Visual Studio Container Tools Options, showing the settings available for the Containers tool window](media/configure-container-tools/tools-options-3.png)

The following table describes the **Containers** window settings:


| Name | Default Setting | Description |
| -----|:---------------:| ----------- |
| Confirm before pruning containers | Always | Controls whether you are prompted when pruning unused containers. |
| Confirm before pruning images | Always | Controls whether you are prompted when pruning unused images. |
| Confirm before removing a container | Always | Controls whether you are prompted when removing a container. |
| Confirm before removing an image | Always | Controls whether you are prompted when removing an image. |
| Confirm before running large number of images | Always | Controls whether you are prompted before starting containers from more than 10 images at a time. |

::: moniker-end
> [!WARNING]
> If the localhost SSL certificate is not trusted, and you check the box to suppress prompting, then HTTPS web requests might fail at run time in your app or service. In that case, uncheck the **Do not prompt** checkbox, run your project, and indicate trust at the prompt.

## Next steps

Read more about working with containers in Visual Studio in this [overview](overview.md).