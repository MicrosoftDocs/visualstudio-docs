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

   The following example shows a solution WebFrontEndA with three projects, set to start the project WebFrontEndA with debugging enabled, and also start WebAPI, but without attaching the debugger. In this case, the front-end project makes calls into the Web API project, so having it started is necessary to debug the front end. The Docker Compose project is not started in this configuration. Using these options, the WebFrontEndA project can make calls to the WebAPI project successfully (using a localhost address and port).

   ![Screenshot of the Solution Property Pages.](media/vs-2022/startup-projects.png)

   > [!NOTE]
   > This example shows a case where you want to test and debug a number of services without running them in Docker, such as when you want to make sure everything works before trying to run in the Docker environment. When you're working with containerized apps, you typically use Docker Compose to start multiple projects. In that case, you can just choose `docker-compose` as the single startup project, Visual Studio uses a Docker Compose launch profile to determine what projects to start, and whether or not to attach the debugger. See [Start a subset of services](../containers/launch-profiles.md).

## See also

- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)
- [Work with solutions and projects](../ide/creating-solutions-and-projects.md)
- [Manage project and solution properties](../ide/managing-project-and-solution-properties.md)
