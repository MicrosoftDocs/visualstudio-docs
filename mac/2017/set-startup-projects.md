---
title: "Set multiple startup projects in Visual Studio for Mac"
description: "This article describes how to set multiple projects to start on run or debug."
author: sayedihashimi
ms.author: sayedha
ms.date: 02/21/2019
ms.topic: conceptual
ms.prod: visual-studio-mac
ms.assetid: fd354fff-ce6b-4505-a815-84a2311e39ba
---
# How to: Set multiple startup projects

Visual Studio for Mac allows you to specify how more than one project is started when you debug, or run, your solution.

## To set multiple startup projects

1. In **Solution Pad**, select the solution (the top node).

2. Choose the solution node's context (right-click) menu and then choose **Set Startup Projects...**.

   ![Set startup projects context menu](media/startup-proj-ctx-menu.png)

3. The **Create Solution Run Configuration** dialog appears. This dialog will create a new named Solution Run Configuration for your solution. You can give any name you like, the default name is `Multiple Projects`.

   ![Create Solution Run Configuration dialog](media/create-sln-run-config.png)

4. Click **Create Run Configuration**. The **Solution Options** dialog opens with the new Solution Run Configuration selected.

   ![Solution Options dialog](media/sln-options-run-config-multi-projects.png)

5. Select the projects that you want to start when you debug, or run, your application from Visual Studio for Mac.

   ![Solution options dialog with configured run configuration](media/sln-options-run-config-multi-projects-configured.png)

6. Click **OK**. The dialog will be dismissed, and the new Solution Run Configuration is set as the active run configuration.

   ![Solution with multiple projects configured to start on debug or run](media/startup-project-configured.png)
   You can see that two projects are configured to start because both projects are in **bold** in the **Solution Pad**. In the toolbar, the new run configuration is configured as the current Solution Run Configuration.

## Next steps

- [Compiling and building in Visual Studio for Mac](compiling-and-building.md)
- [Understanding build configurations](configurations.md)