---
title: "Add Unreal Engine classes, modules, and plugins in Visual Studio"
description: "Learn how to add Unreal Engine classes, modules, and plugins to your Unreal Engine project from within Visual Studio"
ms.date: 03/17/2025
ms.topic: how-to
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: Coxford

#customer intent: As a C++ game developer using Unreal Engine and Visual Studio, I want to add classes, modules, and plugins to my Unreal Engine project from within Visual Studio so that I can stay in my development environment and not have to switch between the Unreal Engine Editor and Visual Studio.
---

# Add Unreal Engine classes, modules, and plugins in Visual Studio

In this article, learn how to use Visual Studio Tools for Unreal Engine to:

- [Add Unreal Engine modules in Visual Studio](#add-unreal-engine-modules-in-visual-studio)
- [Add Unreal Engine classes in Visual Studio](#add-unreal-engine-classes-in-visual-studio)
- [Add Unreal Engine plugins in Visual Studio](#add-unreal-engine-plugins-in-visual-studio)

## Prerequisites

The following must be installed:

- Visual Studio version 17.11 or later.
- Unreal Engine version 5 or later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.
- Complete the [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game and configure it to use Visual Studio Tools for Unreal Engine.

## Add Unreal Engine modules in Visual Studio

You can now add Unreal Engine [modules](https://dev.epicgames.com/documentation/en-us/unreal-engine/unreal-engine-modules) to your Unreal Engine project from within Visual Studio. You no longer have to switch between the Unreal Engine Editor and Visual Studio to add a module, or need to synchronize the Visual Studio solution with your Unreal Engine project file afterwards.

Modules are a way to organize your code in Unreal Engine. They help you group related classes and assets together and organize your code into self-contained units that can be loaded and unloaded at runtime. Creating modules can be tedious and error-prone if you do it manually because it requires editing configuration files and adding boilerplate code. Visual Studio makes it easier to create modules by providing a dialog that guides you through the process and doing the configuration and adding the boilerplate for you.

To add an Unreal Engine module in Visual Studio, follow these steps after completing [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game. These steps assume that you have the `LyraStarterGame.sln` solution open in Visual Studio:

1. In **Solution Explorer**, choose a project, such as **LyraStarterGame**, where you want the new module to go.
1. Right-click the project (be sure a project is selected and not a folder) and choose **Add** > **Unreal Engine item...** to open the **Add New Item** dialog for Unreal Engine items:
     :::image type="content" source="../media/vs-add-new-unreal-engine-item-dialog-module.png" alt-text="A screenshot of the Add New Item menu. Empty Unreal Engine Module is selected.":::
1. Choose **Unreal Engine Module**, provide a module name in the **Name** field, and then choose **Add** to open the **Add Unreal Engine Module** dialog:
    :::image type="complex" source="../media/vs-add-unreal-engine-module-dialog.png" alt-text="A screenshot of the Add Unreal Engine Module dialog.":::
    The Add Unreal Engine Module dialog has a field for the Module name, dropdowns for the Module type (Runtime is selected) and module loading phase (Default is selected). The module path, header, source, and build file paths are listed. The checkbox for Refresh IntelliSense information using Unreal Editor tools is checked.
    :::image-end:::
1. Use the drop-downs to select the **Module type** and **Module loading phase**.
1. Choose **OK** to add the module to the project and update the Visual Studio solution file.

Modules can only be created in the **Source** folder or as a module of a plugin inside the **Plugins** folder.\
The **Build** path shows where the `Build.cs` file is created. The `Build.cs` file contains configuration information for the module.

## Build a single Unreal Engine module

After adding the module, build it to make it available in the Unreal Engine Editor. Rather than build the entire project, you can build just the module.

In **Solution Explorer**, right-click on the module folder and select **Build**. This builds the plugin and makes it available in the Unreal Engine Editor.

:::image type="complex" source="../media/vs-build-module-menu.png" alt-text="A screenshot of the menu to build the module.":::
    The menu options after right-clicking the module folder MyModule are visible. The entry Build this Unreal Engine module is highlighted.
:::image-end:::

Build output is displayed in the **Output** window. If the build is successful, the module is available in the Unreal Engine Editor. If the build fails, the **Output** window displays the error messages.

## Add Unreal Engine classes in Visual Studio

You can now add Unreal Engine classes to your Unreal Engine project from within Visual Studio. You no longer have to switch between the Unreal Editor and Visual Studio to add a class, or need to synchronize the Visual Studio solution with your Unreal Engine project file afterwards.

To add an Unreal Engine class in Visual Studio, follow these steps after completing [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game. The steps assume that you have the `LyraStarterGame.sln` solution open in Visual Studio:

1. In **Solution Explorer**, select a folder where you want the new class to go. In the LyraStarterGame project, you could add a new class to the **LyraStarterGame** > **Source** folder, for example.
1. Right-click the folder and select **Add** > **Unreal Engine item...** to open the **Add New Item** dialog:
    :::image type="complex" source="../media/vs-add-new-unreal-engine-item-dialog-class.png" alt-text="A screenshot of the Add New Item dialog, with Unreal Engine Common Classes selected.":::
    It has options for adding an Unreal Engine Common Classes (which is selected), Empty Unreal Engine Module, and Unreal Engine Plugins.
    :::image-end:::
1. Select **Unreal Engine Common Classes** and then select **Add** to open the **Add Unreal Engine Class** dialog:
    :::image type="complex" source="../media/vs-add-unreal-engine-class-dialog.png" alt-text="A screenshot of the Add New Unreal Engine class dialog.":::
    Options for selecting a base such as Actor, Character, and so on, are visible. There's a field for the class name and a dropdown for the module to add the class to. The paths to the header file and source file are listed. A checkbox is selected to refresh IntelliSense information using Unreal Editor tools.
    :::image-end:::
1. Select a **Class name**. Visual Studio warns you if the name conflicts with an existing class or file.
1. Select a **Base class**. Selecting a base class ensures that the right headers and macros are included for that class type.
1. Select a module to add to your class to using the **Select a module to add the class** dropdown. The module name is the name of the folder that contains the module.
1. Select the **Refresh IntelliSense information using Unreal Editor tools** checkbox to choose whether Visual Studio uses Unreal Editor tools to update the IntelliSense information. Choose this to cause the Unreal Build Tool to regenerate the Visual Studio solution file.
1. Select **OK** to generate the header and source files for the new class and add them to the Visual Studio solution file. Select **Reload** in the prompt that appears to reload the project.

## Add Unreal Engine plugins in Visual Studio

You can now add Unreal Engine plugins to your Unreal Engine project from within Visual Studio. You no longer have to switch between the Unreal Editor and Visual Studio to add a plugin, or need to synchronize the Visual Studio solution with your Unreal Engine project file afterwards.

To add an Unreal Engine plugin in Visual Studio, follow these steps after completing [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game. The steps assume that you have the `LyraStarterGame.sln` solution open in Visual Studio:

1. In **Solution Explorer**, choose a folder where you want the new plugin to go. In the LyraStarterGame project, you could add a new plugin to the **LyraStarterGame** > **Source** folder, for example.
1. Right-click the folder and select **Add** > **Unreal Engine item...** to open the **Add New Item** dialog:
    :::image type="complex" source="../media/vs-add-new-unreal-engine-item-dialog-plugin.png" alt-text="A screenshot of the Add New Item dialog, with Unreal Engine Plugins selected.":::
     It has options for adding an Unreal Engine Common Classes, Empty Unreal Engine Module, and Unreal Engine Plugins (which is selected).
    :::image-end:::
1. Select **Unreal Engine Plugins** and then select **Add** to open the **Add Unreal Engine Plugin** dialog:
    :::image type="complex" source="../media/vs-add-unreal-engine-plugin-dialog.png" alt-text="A screenshot of the Add New Unreal Engine plugin dialog.":::
    There's a list of Plugin types (Advanced is selected), and fields for the plugin name, path, author, description, and URL. There's an Is plugin in beta checkbox (unchecked) and a Refresh IntelliSense information using Unreal Editor Tools checkbox (checked).
    :::image-end:::
1. Select the type of your plugin from the **Plugin type** list.
1. Provide the **Plugin name**, **Plugin author**, **Plugin Description**, and **Plugin url**.
1. Check the **Is plugin in beta** box as needed.
1. Select the **Refresh IntelliSense information using Unreal Editor tools** checkbox to choose whether Visual Studio uses the Unreal Editor tools to update the IntelliSense information. This causes the Unreal Build Tool to regenerate the Visual Studio solution file.
1. Select **Add** to create the plugin header and source files for the new plugin and add them to the Visual Studio solution file. This results in a prompt to reload the project. Choose **Reload** to reload the project.

## Build a single Unreal Engine plugin

After adding the plugin, build it to make it available in the Unreal Engine Editor. Rather than build the entire project, you can build just the plugin.

In **Solution Explorer**, right-click on the plugin folder and choose **Build this Unreal Engine plugin**. This builds the plugin and makes it available in the Unreal Engine Editor.

:::image type="complex" source="../media/vs-build-plugin-menu.png" alt-text="A screenshot of the menu to build the plugin.":::
    The menu options after right-clicking the plugin folder MyPlugin are visible. The entry Build this Unreal Engine plugin is highlighted.
:::image-end:::

If the build is successful, the plugin is available in the Unreal Engine Editor. If the build fails, the **Output** window displays the error messages.

## Related content

[Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md)\
[View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)\
[View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)\
[View Unreal Engine macros in Visual Studio](vs-tools-unreal-view-macros.md)
