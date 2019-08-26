---
title: "How to: Create and edit configurations"
ms.date: 06/21/2017
ms.technology: vs-ide-compile
ms.topic: conceptual
helpviewer_keywords:
  - "solution build configurations, editing"
  - "build configurations, creating"
  - "solution build configurations, creating"
  - "build configurations, editing"
  - "builds [Visual Studio], setting up"
  - "property pages"
  - "Configuration Manager"
  - "project build configurations, creating"
  - "project build configurations, editing"
ms.assetid: 19be121c-148e-4ece-bbfc-d20b08cfc3f7
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Create and edit configurations

You can create several build configurations for a solution. For example, you can configure a debug build that your testers can use to find and fix problems, and you can configure different kinds of builds that you can distribute to different customers.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Create and edit configurations in Visual Studio for Mac](/visualstudio/mac/create-and-edit-configurations).

## Create build configurations

You can use the **Configuration Manager** dialog box to select or modify existing build configurations, or to create new ones.

To open the **Configuration Manager** dialog box, in **Solution Explorer**, open the shortcut menu for the solution and then choose **Configuration Manager**.

> [!NOTE]
> If the **Configuration Manager** command doesn't appear on the shortcut menu, look under the **Build** menu on the menu bar. If it doesn't appear there either, on the menu bar, choose **Tools** > **Options**, and then in the left pane of the **Options** dialog box, expand **Projects and Solutions** > **General**, and in the right pane, select the **Show advanced build configurations** check box.

In the **Configuration Manager** dialog box, you can use the **Active solution configuration** drop-down list to select a solution-wide build configuration, modify an existing one, or create a new configuration. You can use the **Active solution platform** drop-down list to select the platform that the configuration targets, modify an existing one, or add a new platform. The **Project contexts** pane lists the projects in the solution. For each project, you can select a project-specific configuration and platform, modify existing ones, or create a new configuration or add a new platform. You can also select check boxes that indicate whether each project is included when you use the solution-wide configuration to build or deploy the solution.

After you set up the configurations you want, you can set project properties that are appropriate for those configurations.

### Set properties based on configurations

To set properties based on configurations, in **Solution Explorer**, open the shortcut menu for a project and then choose **Properties**. You can set properties for your configurations. For example, for a release configuration, you can specify that code is optimized when the solution is built, and for a debug configuration, you can specify that the `DEBUG` conditional compilation symbol is included.

For more information about property page settings, see [Manage project and solution properties](../ide/managing-project-and-solution-properties.md).

## Create a project configuration

1. Open the **Configuration Manager** dialog box.

2. Select a project in the **Project** column.

3. In the **Configuration** drop-down list for that project, choose **New**.

     The **New Project Configuration** dialog box opens.

4. In the **Name** box, enter a name for the new configuration.

5. To use the property settings from an existing project configuration,  in the **Copy settings from** drop-down list, choose a configuration.

6. To create a solution-wide configuration at the same time, select the **Create new solution configuration** check box.

## Rename a project configuration

1. Open the **Configuration Manager** dialog box.

2. In the **Project** column, select the project that has the project configuration you want to rename.

3. In the **Configuration** drop-down list for that project, choose **Edit**.

     The **Edit Project Configurations** dialog box opens.

4. Select the project configuration name you want to change.

5. Select **Rename**, and then enter a new name.

## Create and modify solution-wide build configurations

### To create a solution-wide build configuration

1. Open the **Configuration Manager** dialog box.

2. In the **Active solution configuration** drop-down list, choose **New**.

     The **New Solution Configuration** dialog box opens.

3. In the **Name** text box, enter a name for the new configuration.

4. To use the settings from an existing solution configuration, in the **Copy settings from** drop-down list, choose a configuration.

5. If you want to create project configurations at the same time, select the **Create new project configurations** check box.

### To rename a solution-wide build configuration

1. Open the **Configuration Manager** dialog box.

2. In the **Active solution configuration** drop-down list, choose **Edit**.

     The **Edit Solution Configurations** dialog box opens.

3. Select the solution configuration name you want to change.

4. Select **Rename**, and then enter a new name.

### To modify a solution-wide build configuration

1. Open the **Configuration Manager** dialog box.

2. In the **Active solution configuration** drop-down list, select the configuration you want.

3. In the **Project contexts** pane, for every project, select the **Configuration** and **Platform** you want, and select whether to **Build** it and whether to **Deploy** it.

## See also

- [Understand build configurations](../ide/understanding-build-configurations.md)
- [Build and clean projects and solutions in Visual Studio](../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md)
- [Manage project and solution properties](managing-project-and-solution-properties.md)
- [Create and edit configurations (Visual Studio for Mac)](/visualstudio/mac/create-and-edit-configurations)