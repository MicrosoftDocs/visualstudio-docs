---
title: Debugging apps in a local Docker container | Microsoft Docs
description: Learn how to modify an app that is running in a local Docker container, refresh the container via Edit and Refresh and set debugging breakpoints
services: container-service
author: ghogen
manager: jillfra
ms.assetid: 480e3062-aae7-48ef-9701-e4f9ea041382
ms.topic: conceptual
ms.workload: multiple
ms.date: 03/01/2019
ms.author: ghogen
---
# Debugging apps in a local Docker container

## Overview

Visual Studio 2017 provides a consistent way to develop in a Docker container and validate your application locally.
You don't have to restart the container each time you make a code change.
This article illustrates how to use the "Edit and Refresh" feature to start an ASP.NET Core Web app in a local Docker container,
make any necessary changes, and then refresh the browser to see those changes.
This article also shows you how to set breakpoints for debugging.

## Prerequisites

The following tools must be installed.

::: moniker range="vs-2017"

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2017) with the Web Development workload installed.

::: moniker-end

::: moniker range="vs-2019"

* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019+rc) with the Web Development workload installed.

::: moniker-end

To run Docker containers locally, you'll need a local docker client.
You can use the [Docker Toolbox](https://www.docker.com/products/docker-toolbox), which requires Hyper-V to be disabled,
or you can use [Docker for Windows](https://www.docker.com/get-docker), which uses Hyper-V, and requires Windows 10.

If using Docker Toolbox, you'll need to [configure the Docker client](vs-azure-tools-docker-setup.md)

## 1. Create a web app

[!INCLUDE [create-aspnet5-app](../azure/includes/create-aspnet5-app.md)]

## 2. Edit your code and refresh

To quickly iterate changes, you can start your application within a container, and continue to make changes, viewing them as you would with IIS Express.

1. Set the Solution Configuration to `Debug` and press **&lt;CTRL + F5>** to build your docker image and run it locally.

    Once the container image has been built and is running in a Docker container, Visual Studio launches the Web app in your default browser.
    If you are using the Microsoft Edge browser or otherwise have errors, see [Troubleshooting](vs-azure-tools-docker-troubleshooting-docker-errors.md) section.
2. Go to the About page, which is where we're going to make our changes.
3. Return to Visual Studio and open `Views\Home\About.cshtml`.
4. Add the following HTML content to the end of the file and save the changes.

    ```html
    <h1>Hello from a Docker Container!</h1>
    ```

5. Viewing the output window, when the .NET build is completed and you see these lines, switch back to your browser and refresh the About page.

   ```output
   Now listening on: http://*:80
   Application started. Press Ctrl+C to shut down
   ```

6. Your changes have been applied!

## 3. Debug with breakpoints

Often, changes will need further inspection, leveraging the debugging features of Visual Studio.

1. Return to Visual Studio and open `About.cshtml.cs`
2. Replace the contents of the `OnGet` method with the following:

   ```cs
       Message = "Your application description page from within a Container";
   ```

3. Set a breakpoint to the left of the code line.
4. Hit F5 to start debugging.
5. Navigate to the About page to hit your breakpoint.
6. Switch to Visual Studio to view the breakpoint, and inspect the value of message.

   ![Breakpoint](media/vs-azure-tools-docker-edit-and-refresh/breakpoint.png)

## Summary

With Docker support in Visual Studio 2017, you can get the productivity of working locally,
with the production realism of developing within a Docker container.

## Troubleshooting

[Troubleshooting Visual Studio Docker Development](vs-azure-tools-docker-troubleshooting-docker-errors.md)

## More about Docker with Visual Studio, Windows, and Azure

* [Container development with Visual Studio](/visualstudio/containers) - a container development hub page
* [Docker Integration for Azure Pipelines](https://aka.ms/dockertoolsforvsts) - Build and Deploy docker containers
* [Docker Tools for Visual Studio Code](https://aka.ms/dockertoolsforvscode) - Language services for editing docker files, with more e2e scenarios coming
* [Windows Container Information](https://aka.ms/containers)- Windows Server and Nano Server information
* [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - [Azure Kubernetes Service Documentation](/azure/aks)
