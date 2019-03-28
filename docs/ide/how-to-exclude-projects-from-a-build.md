---
title: "How to: Exclude projects from a build"
ms.date: 11/04/2016
ms.technology: vs-ide-compile
ms.topic: conceptual
ms.assetid: 17a837ca-5db9-46cd-b5a7-b14ad1d2c47d
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Exclude projects from a build

You can build a solution without building all projects that it contains. For example, you might exclude a project that breaks the build. You could then build the project after you investigate and address the issues.

You can exclude a project by taking the following approaches:

-   Removing it temporarily from the active solution configuration.

-   Creating a solution configuration that doesn't include the project.

For more information, see [Understand build configurations](../ide/understanding-build-configurations.md).

## To temporarily remove a project from the active solution configuration

1.  On the menu bar, choose **Build** > **Configuration Manager**.

2.  In the **Project contexts** table, locate the project you want to exclude from the build.

3.  In the **Build** column for the project, clear the check box.

4.  Choose the **Close** button, and then rebuild the solution.

## To create a solution configuration that excludes a project

1.  On the menu bar, choose **Build** > **Configuration Manager**.

2.  In the **Active solution configuration** list, choose **\<New>**.

3.  In the **Name** box, enter a name for the solution configuration.

4.  In the **Copy settings from** list, choose the solution configuration on which you want to base the new configuration (for example, **Debug**), and then choose the **OK** button.

5.  In the **Configuration Manager** dialog box, clear the check box in the **Build** column for the project that you want to exclude, and then choose the **Close** button.

6.  On the **Standard** toolbar, verify that the new solution configuration is the active configuration in the **Solution Configurations** box.

7.  On the menu bar, choose **Build** > **Rebuild Solution**.

## See also

- [Understand build configurations](../ide/understanding-build-configurations.md)
- [How to: Create and edit configurations](../ide/how-to-create-and-edit-configurations.md)
- [How to: Build multiple configurations simultaneously](../ide/how-to-build-multiple-configurations-simultaneously.md)