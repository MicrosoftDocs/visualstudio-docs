---
title: Build Multiple Configurations With One Request
description: Build multiple or all configurations of a project in Visual Studio by making a single request with the Batch Build option.
ms.date: 06/25/2025
ms.subservice: compile-build
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
#customer intent: As a developer, I want to build multiple or all configurations of my project in Visual Studio, so I can use a single request to complete the task.
---

# Build multiple configurations in a single build request

Most project types in Visual Studio support building multiple or all configurations of the project with a single action (**Build** > **Batch Build**). However, three project types have restrictions that don't permit building multiple configurations simultaneously:

- Windows 8.x Store apps built for Windows with JavaScript
- All Visual Basic projects
- CMake projects

If your solution includes a project type that has build restrictions, the **Build** > **Batch Build** option isn't available. For more information, see [Understand build configurations](../ide/understanding-build-configurations.md).

## Build multiple configurations for a project

The following steps show how to build multiple configurations of a project at the same time:

1. In Visual Studio, select **Build** > **Batch Build**, or enter the **Ctrl**+**Q** keyboard shortcut, and search for _Batch Build_.

1. In the **Batch Build** dialog, select the check box in the **Build** column for each configuration you want to build for the project.

   You can also [edit the build configurations for all projects in a solution](#edit-build-configurations-for-a-solution) and build them from the **Batch Build** dialog. 

1. Select **Build** or **Rebuild**. Visual Studio builds all selected configurations of your project.

## Edit build configurations for a solution

The following steps show how to edit or create build configurations for a solution:

1. Select **Build** > **Configuration Manager**.

1. In the **Configuration Manager** dialog, edit the configurations for the solution.

1. In the **Batch Build** dialog, select **Rebuild**.

Visual Studio builds all configurations for the projects in the solution.

## Related content

- [How to: Create and edit configurations](../ide/how-to-create-and-edit-configurations.md)
- [Understand build configurations](../ide/understanding-build-configurations.md)
- [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)