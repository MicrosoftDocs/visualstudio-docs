---
title: "How to: Create and Edit Configurations | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
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
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create and Edit Configurations
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can create several build configurations for a solution. For example, you can configure a debug build that your testers can use to find and fix problems, and you can configure different kinds of builds that you can distribute to different customers.

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

## Creating Build Configurations
 You can use the **Configuration Manager** dialog box to select or modify existing build configurations, or you can create new ones.

#### To open the Configuration Manager dialog box

- In **Solution Explorer**, open the shortcut menu for the solution and then choose **Configuration Manager**.

  > [!NOTE]
  > If the **Configuration Manager** command doesn't appear on the shortcut menu, look under the **Build** menu on the menu bar. If it doesn't appear there either, on the menu bar, choose **Tools**, **Options**, and then in the left pane of the **Options** dialog box, expand **Projects and Solutions**, **General**, and in the right pane, select the **Show advanced build configurations** check box.

   In the **Configuration Manager** dialog box, you can use the **Active solution configuration** drop-down list to select a solution-wide build configuration, modify an existing one, or create a new configuration. You can use the **Active solution platform** drop-down list to select the platform that the configuration targets, modify an existing one, or add a new platform. The **Project contexts** pane lists the projects in the solution. For each project, you can select a project-specific configuration and platform, modify existing ones, or create a new configuration or add a new platform. You can also select check boxes that indicate whether each project is included when you use the solution-wide configuration to build or deploy the solution.

  After you set up the configurations you want, you can set project properties that are appropriate for those configurations.

#### To set properties based on configurations

- In **Solution Explorer**, open the shortcut menu for a project and then choose **Properties**.

     The  **Property Pages** window opens.

     You can set properties for your configurations. For example, for a Release configuration, you can specify that code is optimized when the solution is built, and for a Debug configuration, you can specify that the `DEBUG` conditional compilation symbol is included. For more information about property page settings, see [Introduction to the Project Designer](https://msdn.microsoft.com/898dd854-c98d-430c-ba1b-a913ce3c73d7).

## Creating and Modifying Project Configurations

#### To create a project configuration

1. Open the **Configuration Manager** dialog box.

2. Select a project in the **Project** column.

3. In the **Configuration** drop-down list for that project, choose **New**.

     The **New Project Configuration** dialog box opens.

4. In the **Name** box, enter a name for the new configuration.

5. To use the property settings from an existing project configuration,  in the **Copy settings from** drop-down list, choose a configuration.

6. To create a solution-wide configuration at the same time, select the **Create new solution configuration** check box.

#### To rename a project configuration

1. Open the **Configuration Manager** dialog box.

2. In the **Project** column, select the project that has the project configuration you want to rename.

3. In the **Configuration** drop-down list for that project, choose **Edit**.

     The **Edit Project Configurations** dialog box opens.

4. Select the project configuration name you want to change.

5. Select **Rename**, and then enter a new name.

## Creating and Modifying Solution-wide Build Configurations

#### To create a solution-wide build configuration

1. Open the **Configuration Manager** dialog box.

2. In the **Active solution configuration** drop-down list, choose **New**.

     The **New Solution Configuration** dialog box opens.

3. In the **Name** text box, enter a name for the new configuration.

4. To use the settings from an existing solution configuration, in the **Copy settings from** drop-down list, choose a configuration.

5. If you want to create project configurations at the same time, select the **Create new project configurations** check box.

#### To rename a solution-wide build configuration

1. Open the **Configuration Manager** dialog box.

2. In the **Active solution configuration** drop-down list, choose **Edit**.

     The **Edit Solution Configurations** dialog box opens.

3. Select the solution configuration name you want to change.

4. Select **Rename**, and then enter a new name.

#### To modify a solution-wide build configuration

1. Open the **Configuration Manager** dialog box.

2. In the **Active solution configuration** drop-down list, select the configuration you want.

3. In the **Project contexts** pane, for every project, select the **Configuration** and **Platform** you want, and select whether to **Build** it and whether to **Deploy** it..

## See Also
 [Understanding Build Configurations](../ide/understanding-build-configurations.md)
 [Building and Cleaning Projects and Solutions in Visual Studio](../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md)
 [NIB How to: Modify Project Properties and Configuration Settings](https://msdn.microsoft.com/e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)
