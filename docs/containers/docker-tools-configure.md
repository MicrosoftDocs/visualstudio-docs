---
title: Configure Visual Studio Container Tools
description: Configure the Docker tools available in Visual Studio
author: ghogen
ms.author: ghogen
ms.date: 03/20/2019
ms.technology: vs-azure
---
# How to configure Docker tools

Using Visual Studio settings, you can control some aspects of how Visual Studio works with Docker containers.

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

Read more about working with containers in Visual Studio in this [overview](visual-studio-tools-for-docker.md).