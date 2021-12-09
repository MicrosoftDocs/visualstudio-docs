---
title: 'How to: Set multiple startup projects'
description: Learn how Visual Studio allows you to specify how more than one project is run when you start the debugger.
ms.custom: SEO-VS-2020
ms.date: 06/21/2017
ms.topic: how-to
helpviewer_keywords:
- startup projects, setting multiple startup projects
ms.assetid: 6131eb80-8745-4eb9-bdab-433e69b41651
ms.technology: vs-ide-compile
author: ghogen
ms.author: ghogen
manager: jmartens
ms.workload:
- multiple
---
# How to: Set multiple startup projects

Visual Studio allows you to specify how more than one project is run when you press **F5** (Start with Debugging), or **Ctrl**+**F5** (Start without debugging), or use the toolbar button to launch your application. In this way, you could start multiple sites, apps, or services that depend on each other to work correctly during a debug session or just running and testing locally.

## To set multiple startup projects

1. In **Solution Explorer**, select the solution (the top node).

2. Choose the solution node's context (right-click) menu and then choose **Properties**. The **Solution Property Pages** dialog box appears.

3. Expand the **Common Properties** node, and choose **Startup Project**.

4. Choose the **Multiple Startup Projects** option and set the appropriate actions.

:::moniker range=">=vs-2019"
## Example

The following example shows a solution WebFrontEndA with three projects, a front-end web site, a Web API project, and a Docker Compose project. Suppose your goal is to start the project WebFrontEndA with debugging enabled, and also start WebAPI, but without attaching the debugger (and without using Docker or Docker Compose). This example shows a case where you want to test and debug the services without running them in Docker, such as when you want to make sure everything works before trying to run in the Docker environment. In this case, the front-end project makes web requests to the Web API project, so having it started is necessary to debug the front end. The `docker-compose` project is not started. Using these options, the WebFrontEndA project can send web requests to the WebAPI project successfully (using a localhost address and port).

![Screenshot of the Solution Property Pages.](media/vs-2022/startup-projects.png)

When you run, the services (the web site and the web service) are started in IIS Express, and the two browser tabs open, one for each of the projects that were selected for startup. The debugger attached only to the web site, WebFrontEndA.

In this example, when you're done running without the Docker containers and you do want to run Docker Compose to to start multiple projects, you can just choose `docker-compose` as the single startup project, but then you'll use a different way of specifying which projects or services to start. You'll use a Docker Compose launch profile to determine what services to start, and whether or not to attach the debugger, and there's a different dialog in Visual Studio for configuring it. See [Start a subset of services](../containers/launch-profiles.md). The **Solution Property Pages** dialog is only used for non-containerized solutions or when you are *not* using Docker Compose to manage startup.
:::moniker-end

## See also

- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)
- [Work with solutions and projects](../ide/creating-solutions-and-projects.md)
- [Manage project and solution properties](../ide/managing-project-and-solution-properties.md)
