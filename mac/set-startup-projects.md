---
title: "Set multiple startup projects"
description: "This article describes how to set multiple projects to start on run or debug."
author: jmatthiesen
ms.author: jomatthi
manager: dominicn
ms.date: 11/09/2020
ms.topic: how-to
ms.prod: visual-studio-mac
ms.assetid: fd354fff-ce6b-4505-a815-84a2311e39ba
---
# Set multiple startup projects

 [!INCLUDE [Visual Studio for Mac](~/includes/applies-to-version/vs-mac-only.md)]

Visual Studio for Mac allows you to specify that more than one project should be started when you debug or run your solution.

## To set multiple startup projects

1. In the Solution Window, select the solution (the top node).

2. Right-click the solution node and then select **Set Startup Projects**:

   ![Select Set Startup Projects](media/startup-proj-ctx-menu.png)

3. The **Create Solution Run Configuration** dialog box opens. This dialog box allows you to create a new named Solution Run Configuration for your solution. You can use any name you like. The default name is `Multiple Projects`.

   ![Create Solution Run Configuration dialog box](media/create-sln-run-config.png)

4. Select **Create Run Configuration**. The **Solution Options** dialog box opens with the new Solution Run Configuration selected:

   ![Solution Options dialog box](media/sln-options-run-config-multi-projects.png)

5. Select the projects that you want to start when you debug or run your app from Visual Studio for Mac:

   ![Solution Options dialog box with selected projects](media/sln-options-run-config-multi-projects-configured.png)

6. Select **OK**. The new Solution Run Configuration is set as the active run configuration:

   ![Solution with multiple projects configured to start on debug or run](media/startup-project-configured.png)

   Now the two projects are configured to start, which is represented by both projects appearing **bold** in the Solution Window. In the toolbar, the new run configuration is set as the current Solution Run Configuration.

## Next steps

- [Compiling and building in Visual Studio for Mac](compiling-and-building.md)
- [Understanding build configurations](configurations.md)
