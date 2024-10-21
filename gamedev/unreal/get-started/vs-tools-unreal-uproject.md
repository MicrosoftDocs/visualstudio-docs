---
title: "Open native Unreal Engine projects in Visual Studio"
description: "Learn how to work with native Unreal Engine projects from within Visual Studio"
ms.date: 10/30/2024
ms.topic: how-to
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: Coxford
#customer intent: As a C++ game developer using Unreal Engine and Visual Studio, I want to work in Visual Studio with native Unreal Engine projects so that I can use Visual Studio's features and tools to develop my game without having to switch back-and-forth between the Unreal Engine Editor and Visual Studio.
---

# Open native Unreal Engine projects in Visual Studio

Visual Studio 2022 version 17.12 provides direct support for Unreal Engine projects.

Previously, you had to generate a Microsoft Visual Studio project before you could work with an Unreal Engine project in Visual Studio. That process was cumbersome. And whenever a new asset was added from within the Unreal Engine Editor, or by another team member, the Visual Studio project had to be regenerated.

Now, with direct support for Unreal Engine projects (`.uproject` files), you can work directly with Unreal Engine projects from within Visual Studio. This integration enables seamless editing, debugging, and project file management without the repetitive and time-consuming process of generating and regenerating a Visual Studio project file.

## Prerequisites

The following must be installed to work with Unreal Engine projects in Visual Studio:

- Visual Studio version 17.12 Preview 2 or later.
- Unreal Engine version 4.27 or version 5 and later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.
- Download the Lyra sample game. See the **Downloading the Lyra Starter Game** section at [Lyra Sample Game](https://docs.unrealengine.com/5.0/lyra-sample-game-in-unreal-engine/) for download instructions. If you acquired it via the source code installation of Unreal Engine, that version doesn't contain the assets required to build and run the game. Use the download instructions to get everything you need via the Epic installer.

### Configuration for Unreal Engine 5.3 or earlier

For versions of Unreal Engine before 5.4, follow these steps to enable `.uproject` integration with Visual Studio. These steps work whether you installed Unreal Engine from the Epic Games Launcher or built it from source code.

1. Download the patch specific to your version of Unreal Engine from [Unreal Engine GitHub repository](https://github.com/EpicGames/UnrealEngine/tree/ue5-main/Engine/Extras/VisualStudioWorkspace)
1. Open either a PowerShell or command prompt window and navigate to the root directory where Unreal Engine is installed. You'll need admin elevation to apply the patch if Unreal Engine is installed in a protected directory like `C:\Program Files\Epic Games\UE_5.3`.
1. Apply the patch with the command `git apply <path to the downloaded patch file>`. For example `git apply C:\Users\someuser\Downloads\UnrealBuiltTool-5.3.patch`.
  If that fails, try `git apply -v --ignore-whitespace --ignore-space-change <path to the downloaded patch file>`.

## Open a native Unreal Engine project in Visual Studio

There are two ways to open a native Unreal Engine project in Visual Studio:
- **File** > **Open** > **Folder...** which is the used when there's only one project (`.uproject`) in the folder.
- **File** > **Open** > **Unreal Engine Project...** to pick a specific `.uproject` file to open when there are multiple Unreal Engine project files in a folder.

In this example, we use the Lyra game project to demonstrate opening a native Unreal Engine project in Visual Studio.

1. In Visual Studio, open the **File** menu, and then select **Open** > **Open Folder**.
1. Navigate to the directory where the Lyra game project (`LyraStarterGame.uproject`) is installed and choose **Select Folder**.
1. Once the folder is selected, you see the project files in the **Solution Explorer** and messages in the **Output** window regarding the steps of setting up the workspace.

    :::image type="complex" source="../media/vs-open-folder.png" alt-text="A screenshot of Visual Studio following opening the folder for the Lyra game sample." lightbox="../media/vs-open-folder.png":::
    There's a message at the top of the editor that other build systems are disabled because an Unreal Engine project is open. The **Output** window shows some last messages about the project workspace being set up. To the right is the solution explorer and it shows the folders and files in the Lyra game sample such as Platforms, Plugins, Source, and so on.
    :::image-end:::

A message appears at the top that the Unreal Engine project support is activated and that other build systems like CMake and MSBUILD are disabled. Dismiss this message by clicking the **X** in the corner of the message.

## View the project in the Solution Explorer

The Solution Explorer window shows many of the folders and files that are part of the Unreal Engine project, such as the `Platforms`, `Plugins`, and `Source` folders. You can also see the Unreal Engine project file. One folder contains your project’s source code, while the one named **Engine** contains the sources directory from Unreal Engine.

The Solution Explorer is filtered to focus on source code. By default, the `Content` folders are filtered out, which contain binary assets like textures, models, and so on. You can open these assets in the Unreal Engine Editor. In general, binary files aren't displayed in the Visual Studio solution explorer.

You don't need to regenerate anything to view or edit new assets added outside of Visual Studio.

## Editing and debugging in Visual Studio

You can edit, build, and debug your Unreal Engine project in Visual Studio. To learn how to add Unreal Engine modules, classes, and plugins in Visual Studio, see [Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md). You can set breakpoints in your code and then run the game in the Unreal Engine Editor. When a breakpoint is hit, you can debug the code in Visual Studio.

By default, Visual Studio generates only one target-configuration-platform combination: **Development - Win64**. This configuration allows you to build and launch the Unreal Editor with the project loaded.

If you opened the folder for the Lyra game sample project in Visual Studio, you can follow these steps to try debugging.

1. In Visual Studio, open `LyraGameplayAbility_RangedWeapon.cpp`. Either search for that file in the Search pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Weapons** > **LyraGameplayAbility_RangedWeapon.cpp**.
1. In `LyraGameplayAbility_RangedWeapon.cpp`, go to line 477. You should see this function: `void ULyraGameplayAbility_RangedWeapon::OnTargetDataReadyCallback`
1. Place a breakpoint on the function by pressing F9.
1. Run the sample game in Visual Studio by choosing **Debug** > **Start Debugging**. Give the Unreal Engine Editor some time to load the Lyra game.
1. In the Unreal Engine Editor, choose the Play button on the toolbar (or press `Alt+p`) to start the game.
1. In the Lyra game, use the `w`, `a`, `s`, `d` keys to navigate the player left to the **Elimination** portal. Position the player over the entry portal to load the game.
1. Once the game is running, click the mouse button to fire, and you should see the breakpoint be hit in Visual Studio:
    :::image type="content" source="../media/vs-unreal-engine-debugging.png" alt-text="A screenshot of debugging in Visual Studio. A breakpoint is hit in the OnTargetDataReadyCallback function.":::

## Unreal Engine configuration page

Visual Studio provides an Unreal Engine project configuration page. This page shows you the status of various Unreal Engine features and allows you to access more features.

To access this page from the Visual Studio main menu, choose **Project** > **Configure Tools for Unreal Engine**:

:::image type="complex" source="../media/vs-unreal-engine-configuration-page.png" alt-text="A screenshot of the Unreal Engine project configuration page.":::
The configuration page has a red/green status indicator and a refresh button for options such as Overall Configuration Status, Unreal Build Tool Status, Unreal Engine Targets, Blueprint Support, Visual Studio Integration Tool Status, and so on.
:::image-end:::

### Unreal Built Tool Status

To ensure that you have the latest Unreal Build Tool (UBT), select the refresh icon for **Unreal Build Tool Status**.

In this example, a message appears that Unreal Build Tool isn't using the latest available version for the Workspace Generator. Choose **Update** to update the Unreal Build Tool to the latest version:

:::image type="complex" source="../media/vs-unreal-engine-build-tool-status.png" alt-text="A screenshot of the Unreal Engine Build Tool Status option in the configuration page.":::
The Unreal Build Tool Status has the message "Your current installation of Unreal Build Tool is not using the latest available version for the Workspace Generator. You can update it now to use all the available features that Visual Studio has to offer." There's a refresh button above the message.
:::image-end:::

In the **Output** window, messages appear related to building the Unreal Engine Build Tool. A message that the Workspace is ready will appear, after which you can start adding and editing files.

### Unreal Engine Targets

When you build an Unreal Engine project, there are different build configurations, called *targets*, you can choose. The **Unreal Engine Targets** option is where you generate those targets. Choose the refresh icon to load all available Unreal Engine targets:

:::image type="complex" source="../media/vs-unreal-engine-targets.png" alt-text="A screenshot of the Unreal Engine Build Targets option in the configuration page.":::
The Unreal Build Targets option displays the message: Need to run status check. There's a refresh button above the message.
:::image-end:::

Choose refresh to open a window where you can select the target configurations you want to create:

:::image type="complex" source="../media/vs-unreal-engine-targets-configuration.png" alt-text="A screenshot of the Unreal Engine Build Targets combinations window." lightbox="../media/vs-unreal-engine-targets-configuration.png":::
There are three configuration option dropdowns and an **Add** button. Below are the configuration combinations you choose and a **Generate Targets** button.
:::image-end:::

For more information about the target combinations that you can choose, see Unreal Engine's documentation for [Build Configuration Descriptions](https://dev.epicgames.com/documentation/en-us/unreal-engine/build-configurations-reference-for-unreal-engine?application_version=5.4).

In this example, **LyraClient**, **DebugGame**, and **Win64** are selected in the dropdowns. Choose **Add** to add them to the list of configurations to generate. Then choose **Generate Targets** to create the selected configurations for each configuration that has its checkbox selected.

Once the targets are generated, you can select them as described in [Choose the build configuration](#choose-the-build-configuration).

You can remove targets by unchecking the targets you don't want and selecting the **Generate Targets** button. When you select **Generate Targets**, all targets targets that aren't selected are removed immediately. The unchecked targets will disappear from the list the next time you reload the project. Watch for errors in the output window when you generate targets because some combinations you choose may not be supported.

## Edit target properties

To edit Unreal Engine target properties, right-click on the bolded target file in the Solution Explorer and choose **Edit Unreal Engine target properties**. For example, if `LyraEditor.Target.cs` is the startup project (in which case it's bolded in the Solution Explorer), right-click on it and choose **Edit this Unreal Engine target properties**. This opens the `UETargetProperties.json` file in the editor. You can then change target properties such as command-line arguments, and so on.

:::image type="complex" source="../media/vs-unreal-engine-target-properties.png" alt-text="A screenshot of a right click on the LyraEditor.Target.cs solution explorer item.":::
A menu appears and at the bottom is the option to edit this Unreal Engine target. Selecting this option opens UETargetProperties.json in the editor.
:::image-end:::

## Edit project settings

To edit the Unreal Engine project settings, right-click on the `.uproject` file in the Solution Explorer and choose **Edit Unreal Engine project settings**. This opens the `ProjectSettings.json` file in the editor. You can then change project settings such as which project files and engine files to exclude from the Solution explorer view, what shared include paths to exclude from IntelliSense, and so on.

:::image type="complex" source="../media/vs-unreal-engine-project-properties.png" alt-text="A screenshot of a right click on the LyraStarterGame.uproject solution explorer item.":::
A menu appears and at the bottom is the option to edit the Unreal Engine project settings. Selecting this option opens the `.uproject` file in the editor.
:::image-end:::

## Choose the build configuration

To change the build configuration, choose the configuration you want to build from the Configuration drop-down:

:::image type="complex" source="../media/vs-unreal-engine-configuration-dropdown.png" alt-text="A screenshot of the configuration dropdown.":::
The configuration dropdown menu contains the items: DebugGame - Win64 and Development - Win64.
:::image-end:::

If the target you want to build isn't in the list, you can add it as described in [Unreal Engine Targets](#unreal-engine-targets).

## Common issues and solutions

- Your engine and game code must be on the same drive. If they aren't, see [Game source and engine source are on different drives](#game-source-and-engine-source-are-on-different-drives).
- Folders with multiple `.uproject` files in the same folder aren't supported. To open a specific `.uproject` file when there are multiple project files in the same folder, use **File** > **Open** > **Unreal Engine project**.
- If you open an Unreal Engine project via **File** > **Open** > **Unreal Engine project**, the project doesn't appear in Visual Studio's **File** > **Recent Projects and Solutions** list. If you open the Unreal Engine project via **File** > **Open Folder**, then the opened Unreal Engine project appears in the recently opened projects list.
- Some extensions may not work with a project opened as an Unreal Engine project.
- The property window is empty for source files. This is currently by design.
- There's a solution file in the folder view. Unreal Engine generates this file. It isn't used by Visual Studio and you can ignore it.

### Game source and engine source are on different drives

If your Unreal Engine source code and game source code are on different drives, an error appears when you open your game code project. For example: if you have a game project located at `C:\Users\MyUser\MyGame` then the Unreal Engine must be located somewhere on the `C:\` drive; otherwise `.uproject` support in Visual Studio isn't available:

:::image type="content" source="../media/vs-same-drive-error.png" alt-text="A screenshot of the multi-drive error window.":::

We recommend one of the following solutions.

### Move the game source and engine source to the same drive

The most straight-forward solution is to move the game project to the same logical drive where the Unreal Engine resides using the `Windows File Explorer`.

If you're moving the Unreal Engine source and you installed it via the `Epic Games Launcher`, uninstall and reinstall the engine to the same drive as the game. This has the advantage of updating the engine configuration files to point to the new location.

After you move them to same drive, you can open the `.uproject` in Visual Studio.

### Create a symbolic link to the Unreal Engine and changing the `EngineAssociation` in `.uproject`

If moving the engine source and game source to the same drive isn't feasible, you can create a symbolic link to the Unreal Engine and change the `EngineAssociation` property in the `.uproject` file.

For this example, assume that the Unreal Engine is located at `C:\UE_5.4` and your game is at `Q:\src\Game`.

1. Open a command prompt (not a PowerShell) window.
1. Navigate to the drive your game source is on. For example, `cd /d Q:\`.
1. Create a symlink for the Unreal Engine. The `mklink` command takes a link parameter that specifies the symbolic link name which is how the location for your directory appears to the file system. The target parameter is what you're linking to. For example, `mklink /d "Q:\UE-Link" "C:\UE_5.4"` creates a symbolic link named `q:\UE-Link` that points to the Unreal Engine directory.
1. Open your game's `.uproject` file and set the `EngineAssociation` property to the symlink folder that you created. For example, `"EngineAssociation": "Q:\\UE-Link"`.

Now you can open the `.uproject` in Visual Studio.

### Create a symbolic link to Unreal Engine and change configuration files

This solution is more fragile because it changes configuration files that may be reverted when you update Unreal Engine.

For this example, assume that the Unreal Engine is located at `C:\UE_5.4` and your game is at `Q:\src\Game`

1. Open a command prompt (not a PowerShell) window.
1. Navigate to the drive your game source is on. For example, `cd /d Q:\`.
1. Create a symlink for the Unreal Engine. The `mklink` command takes a link parameter that specifies the symbolic link name which is how the location for your directory appears to the file system. The target parameter is what you're linking to. For example, `mklink /d "Q:\UE-Link" "C:\UE_5.4"` creates a symbolic link named `q:\UE-Link` that points to the Unreal Engine directory.

## Related content

[Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md)\
[Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md)\
[Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md)\
[View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)\
[View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)\
[View Unreal Engine macros in Visual Studio](vs-tools-unreal-view-macros.md)