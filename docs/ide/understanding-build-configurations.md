---
title: Understand project and solution configurations
description: Discover how to work with project and solution configurations when you need to build your projects with different settings in Visual Studio.
ms.date: 8/7/2025
ms.subservice: compile-build
ms.topic: concept-article
f1_keywords:
- SolutionProperties.ActiveConfig
- vs.build.newprojectconfiguration
- vc.proj.configurationsctrl.multipleconfigs
- vs.build.editsolutionconfigurations
- vs.build.editprojectconfigurations
- vs.multipleconfigurations
- vs.build.newsolutionconfiguration
- VS.ConfigurationManager
- VS.MultipleConfig
helpviewer_keywords:
- solution build configurations, about build configurations
- build configurations
- project build configurations
- build configurations, advanced
- projects [Visual Studio], build configuration
- solutions [Visual Studio], build configuration
author: ghogen
ms.author: ghogen
manager: mijacobs
---
# Project and solution configurations

You need project configurations when you need to build your projects with different settings, and solution configurations organize project configurations at the solution level. The **Debug** and **Release** configurations are both solution configurations and corresponding project configurations. 

The solution configuration is like a container of project configurations. It really doesn't contain any settings by itself. The project configuration and the target platform (machine architecture) are directly associated with actual settings like compiler options.

One solution configuration is active and is indicated in the command bar at the top of the IDE.

:::moniker range="vs-2022"
![Screenshot showing the active configuration in the main Visual Studio toolbar.](media/vs-2022/build-configurations-active-config.png)
:::moniker-end
:::moniker range="visualstudio"
![Screenshot showing the active configuration in the main Visual Studio toolbar.](media/visualstudio/understanding-build-configurations/active-configuration.png)
:::moniker-end

The project configuration and the platform control where built output files are stored. Normally, when Visual Studio builds your project, the output is placed in a project subfolder named with the active configuration (for example, *bin/Debug/x86*), but if you want to change that, see [Change the build output directory](how-to-change-the-build-output-directory.md).

You can create your own configurations at the solution and project level. The solution configuration determines which projects are included in the build when that configuration is active. Only the projects that are specified in the active solution configuration will be built. If multiple target platforms are selected in Configuration Manager, all projects that apply to that platform are built. The project configuration determines what build settings and compiler options are used when you build the project.

To create, select, modify, or delete a configuration, you can use the **Configuration Manager**. To open it, on the menu bar, choose **Build** > **Configuration Manager**, or just type **Configuration** in the search box. You can also use the **Solution Configurations** list on the **Standard** toolbar to select a configuration or open the **Configuration Manager**.

:::moniker range="<=vs-2022"
![Screenshot of Configuration Manager dialog.](media/understanding-build-configurations/config-manager.png)
:::moniker-end
:::moniker range="visualstudio"
![Screenshot of Configuration Manager dialog.](media/visualstudio/understanding-build-configurations/configuration-manager.png)
:::moniker-end

> [!NOTE]
> If you can't find solution configuration settings on the toolbar and can't access the **Configuration Manager**, it might be because you're using Visual Basic development settings. For more information, see [Manage configurations with Visual Basic developer settings applied](/visualstudio/ide/understanding-build-configurations).

By default, **Debug** and **Release** configurations are included in projects that are created by using Visual Studio templates. A **Debug** configuration supports the debugging of an app, and a **Release** configuration builds a version of the app that can be deployed. For more information, see [Set debug and release configurations](../debugger/how-to-set-debug-and-release-configurations.md). You can also create custom solution configurations and project configurations. For more information, see [Create and edit configurations](../ide/how-to-create-and-edit-configurations.md).

## Why there are both solution configurations and project configurations

For any solution, the projects in that solution are not required to have the same configuration as the solution. For example, a **Debug** solution configuration does not require all the projects to use the **Debug** configuration.

Suppose you are a developer who is part of a large shared solution, but you own one or more closely related projects in that solution. You might want to use a **Debug** configuration for your projects, but a **Release** configuration for all the other projects in that solution. To support this scenario, you would set up the **Debug** solution configuration to use the **Debug** project configuration only for some projects, and use the **Release** project configuration for everything else. This could mean significantly less overhead in terms of performance and file sizes for those projects, and by running in **Release** mode on projects that you're not actively debugging, you could run in a manner closer to the customer experience, and yet still preserve the ability to switch between **Debug** and **Release** builds in a way that is meaningful for your work.

## Solution configurations

A solution configuration specifies how projects in the solution are to be built and deployed. To modify a solution configuration or define a new one, in the **Configuration Manager**, under **Active solution configuration**, choose **Edit** or **New**.

Each entry in the **Project contexts** box in a solution configuration represents a project in the solution. For every combination of **Active solution configuration** and **Active solution platform**, you can set how each project is used.

When you define a new solution configuration and select the **Create new project configurations** check box, Visual Studio creates a new project configuration in all of the projects. Likewise, when you define a new solution platform and select the **Create new project platforms** check box, Visual Studio creates the new platform option in all of the projects. Also, if you add a project that targets a new platform, Visual Studio adds that platform to the list of solution platforms and makes the platform available as an option in all of the projects. You can modify the settings for each project, for cases where platforms are not needed or supported by some projects.

The active solution configuration also provides context to the IDE. For example, if you're working on a project and the configuration specifies that it will be built for a mobile device, the **Toolbox** displays only items that can be used in a mobile device project.

## Project configurations

The configuration and platform that a project targets are used together to specify the build settings and compiler options to use when it's built. A project can have different settings for each combination of configuration and platform. To modify the properties of a project, open the shortcut menu for the project in **Solution Explorer**, and then choose **Properties**.  At the top of the **Build** tab of the project designer, choose an active configuration to edit its build settings.

:::moniker range=">=vs-2022"
![Screenshot of project designer configurations.](media/vs-2022/understanding-build-configurations/project-designer-build-configurations.png)
:::moniker-end

The predefined constants for each configuration are shown underneath the textbox where you can enter your own. These predefined constants are defined by the SDK your project uses. To see where these properties are defined, you can look for how the MSBuild property `DefineConstants` is defined and modified in the .NET SDK installation folder where `.props` and `.targets` files are located. The SDKs provide MSBuild properties that you can set in the project file to disable the predefined definitions; for example, see [DisableImplicitFrameworkDefines](/dotnet/core/project-sdk/msbuild-props#disableimplicitframeworkdefines).

You can customize some project settings by configuration, some must have the same value across configuration, and some provide the option to choose. Click on the gear icon to see the available options and, if supported, you can set whether to use the same value across configurations, or vary by configuration. You can also reset to the default value.

![Screenshot showing how to control whether a build setting varies by configuration or not.](./media/visualstudio/understanding-build-configurations/vary-value-by-configuration.png)

## How Visual Studio associates project configurations with solution configurations

When you define a new solution configuration and don't copy settings from an existing one, Visual Studio uses the following criteria to associate the existing project configurations with the new solution configuration. The criteria are evaluated in the order shown.

1. If a project has a configuration name (*\<configuration name> \<platform name>*) that matches the name of the new solution configuration, that configuration is used. Configuration names are not case-sensitive.

1. If the project has a configuration name in which the configuration-name part matches the new solution configuration, that configuration is used, whether the platform portion matches or not.

1. If there is still no match, the first configuration that's listed in the project is used.

## How Visual Studio associates solution configurations with new project configurations

When you create a project configuration (in the **Configuration Manager**, by choosing **New** on the drop-down menu in the **Configuration** column for that project) and select the **Create new solution configurations** check box, Visual Studio looks for a like-named solution configuration to build the project on each platform it supports. In some cases, Visual Studio renames existing solution configurations or defines new ones.

Visual Studio uses the following criteria to associate solution configurations with project configurations:

- If a project configuration doesn't specify a platform or specifies just one platform, then a solution configuration whose name matches that of the new project configuration is either found or added. The default name of this solution configuration does not include a platform name; it takes the form *\<project configuration name>*.

- If a project supports multiple platforms, a solution configuration is either found or added for each supported platform. The name of each solution configuration includes both the project configuration name and the platform name, and has the form *\<project configuration name> \<platform name>*.

## How configurations affect the build

When you build a solution using the **Build** > **Build Solution** command, Visual Studio only builds the active configuration. All projects that are specified in that solution configuration are built, and the only project configuration that's built is that one specified in the active solution configuration and active solution platform, which is shown in the toolbar in Visual Studio. For example, **Debug** and **x86**. Other defined configurations and platforms are not built.

If you want to build multiple configurations and platforms in one action, you can use the **Build** > **Batch Build** option in Visual Studio. To access this feature, press **Ctrl**+**Q** to open the search box, and enter `Batch build`. Batch build is not available for all project types. See [Build multiple configurations simultaneously](how-to-build-multiple-configurations-simultaneously.md).

## Related content

- [Walkthrough: Build an application](../ide/walkthrough-building-an-application.md)
- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)
- [Solutions and projects](../ide/solutions-and-projects-in-visual-studio.md)
- [C/C++ build reference](/cpp/build/reference/c-cpp-building-reference)
- [Configure projects to target platforms](how-to-configure-projects-to-target-platforms.md)
