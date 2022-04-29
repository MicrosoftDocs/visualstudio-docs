---
title: "How to: Build multiple configurations"
description: Learn how you can build most types of projects with multiple, or even all, of their build configurations with one IDE action.
ms.custom: SEO-VS-2020
ms.date: 05/13/2020
ms.technology: vs-ide-compile
ms.topic: how-to
ms.assetid: ba830937-3317-4674-8cc2-c0cd565603c5
author: ghogen
ms.author: ghogen
manager: jmartens
ms.workload:
  - "multiple"
---
# How to: Build multiple configurations in a single build request

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can build most types of projects with multiple, or even all, of their build configurations with one IDE action by using the **Batch Build** dialog box. However, you can't build the following types of projects in multiple build configurations at the same time:

1. [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)] apps built for Windows using JavaScript.

2. All Visual Basic projects.

3. CMake projects.

If a solution contains any project of those two project types, then **Batch Build** is not available for that solution. In that case, the command doesn't appear on the **Build** menu.

   For more information about build configurations, see [Understand build configurations](../ide/understanding-build-configurations.md).

## To build a project in multiple build configurations

1. On the menu bar, choose **Build** > **Batch Build**. Or, press **Ctrl**+**Q** to open the search box, and search for `Batch Build`.

2. In the **Build** column, select the check boxes for the configurations in which you want to build a project.

    > [!TIP]
    > To edit or create a build configuration for a solution, choose **Build** > **Configuration Manager** on the menu bar to open the **Configuration Manager** dialog box. After you have edited a build configuration for a solution, choose the **Rebuild** button in the **Batch Build** dialog box to update all build configurations for the projects in the solution.

3. Choose the **Build** or **Rebuild** buttons to build the project with the configurations that you specified.

## See also

- [How to: Create and edit configurations](../ide/how-to-create-and-edit-configurations.md)
- [Understand build configurations](../ide/understanding-build-configurations.md)
- [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)