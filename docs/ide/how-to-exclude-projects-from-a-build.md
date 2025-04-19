---
title: 'Exclude projects from a build'
description: Exclude projects from a build in Visual Studio by building the solution without building all projects contained in the solution.
ms.date: 4/1/2025
ms.subservice: compile-build
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
---
# Exclude projects from a build

You can build a solution without building all projects that it contains. For example, you might exclude a project that breaks the build. You could then build the project after you investigate and address the issues.

You can exclude a project by taking the following approaches:

- Removing it temporarily from the active solution configuration.

- Creating a solution configuration that doesn't include the project.

For more information, see [Understand build configurations](../ide/understanding-build-configurations.md).

## To temporarily remove a project from the active solution configuration

1. On the menu bar, choose **Build** > **Configuration Manager**.

2. In the **Project contexts** table, locate the project you want to exclude from the build.

3. In the **Build** column for the project, clear the check box.

4. Choose the **Close** button, and then rebuild the solution.

## To create a solution configuration that excludes a project

1. On the menu bar, choose **Build** > **Configuration Manager**.

2. In the **Active solution configuration** list, choose **\<New>**.

3. In the **Name** box, enter a name for the solution configuration.

4. In the **Copy settings from** list, choose the solution configuration on which you want to base the new configuration (for example, **Debug**), and then choose the **OK** button.

5. In the **Configuration Manager** dialog box, clear the check box in the **Build** column for the project that you want to exclude, and then choose the **Close** button.

6. On the **Standard** toolbar, verify that the new solution configuration is the active configuration in the **Solution Configurations** box.

7. On the menu bar, choose **Build** > **Rebuild Solution**.

## Skipped projects

Projects can be skipped during the build because they are up-to-date or because they are excluded from the configuration. Visual Studio uses MSBuild to build your projects. MSBuild only builds a target if the output is older than the input, as determined by the file timestamps. To force a rebuild, use the command **Build** > **Rebuild Solution**.

In the **Build** pane of the **Output** window, Visual Studio reports the number of projects that were up to date, the number that built successfully, the number that failed, and the number that were skipped. The skipped count does not include projects that were not built because they were up-to-date. When projects are excluded from the active configuration, they are skipped during the build. In the build output, you see a message indicating that the project is skipped:

```output
2>------ Skipped Build: Project: ConsoleApp2, Configuration: Debug x86 ------
2>Project not selected to build for this solution configuration
```

To find out why a project was skipped, note the active configuration (`Debug x86` in the previous example), and choose **Build** > **Configuration Manager**. You can view or change which projects are skipped for each configuration, as discussed in this article.

## Related content

- [Understand build configurations](../ide/understanding-build-configurations.md)
- [How to: Create and edit configurations](../ide/how-to-create-and-edit-configurations.md)
- [How to: Build multiple configurations simultaneously](../ide/how-to-build-multiple-configurations-simultaneously.md)
