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

Now, with direct support for Unreal Engine projects (`.uproject` files) in Visual Studio, you can work directly with the Unreal Engine project from within Visual Studio. This integration enables seamless editing, debugging, and project file management without the repetitive and time-consuming process of generating and regenerating a project file between Visual Studio and Unreal Engine.

## Prerequisites

The following must be installed to work with Unreal Engine projects in Visual Studio:

- Visual Studio version 17.12 Preview 2 or later.
- Unreal Engine version 4.27 or version 5 and later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.
- Download the Lyra sample game. See the **Downloading the Lyra Starter Game** section at [Lyra Sample Game](https://docs.unrealengine.com/5.0/lyra-sample-game-in-unreal-engine/) for download instructions. If you acquired it via the source code installation of Unreal Engine, that version doesn't contain the assets required to build and run the game. Use the download instructions to get everything you need via the Epic installer.

## Open a native Unreal Engine project in Visual Studio

There are two ways to open a native Unreal Engine project in Visual Studio:
- **File** > **Open** > **Folder...** which is the used when there is only one project (`.uproject`) in the folder.
- **File** > **Open** > **Unreal Engine Project...** to pick a specific `.uproject` file to open when there are multiple Unreal Engine project files in a folder.

In this example, we'll use the Lyra game project to demonstrate opening a native Unreal Engine project in Visual Studio.

1. In Visual Studio, open the **File** menu, and then select **Open** > **Open Folder**.
1. Navigate to the directory where the Lyra game project (`LyraStarterGame.uproject`) is installed and choose **Select Folder**.
1. Once the folder is selected, you'll see the project files in the **Solution Explorer** and messages in the **Output** window regarding the steps of setting up the workspace.

    :::image type="complex" source="../media/vs-open-folder.png" alt-text="A screenshot of Visual Studio following opening the folder for the Lyra game sample." lightbox="./media/vs-open-folder.png":::
    There is a message at the top of the editor indicating that other build systems have been disabled because an Unreal Engine project has been opened. The **Output** window shows some last messages about the project workspace being setup. To the right is the solution explorer and it shows the folders and files in the Lyra game sample such as Platforms, Plugins, Source, and so on.
    :::image-end:::

A message appears at the top indicating the Unreal Engine project support has been activated and that other build systems like CMake and MSBUILD are disabled. Dismiss this message by clicking the **X** in the corner of the message.

## View the project in the Solution Explorer

The Solution Explorer window shows many of the folders and files that are part of the Unreal Engine project, such as the `Platforms`, `Plugins`, and `Source` folders. You can also see the Unreal Engine project file. One folder contains your project’s source code, while the one named **Engine** contains the sources directory from Unreal Engine.

The Solution Explorer is filtered to focus on source code. By default, the `Content` folders are filtered out, which contain binary assets like textures, models, and so on. You can open these assets in the Unreal Engine Editor. In general, binary files aren't displayed in the Visual Studio solution explorer.

You don't need to regenerate anything to view or edit new assets added outside of Visual Studio.

## Editing and debugging in Visual Studio

You can edit, build, and debug your Unreal Engine project in Visual Studio. To learn how to add Unreal Engine modules, classes, and plugins in Visual Studio, see [Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md). You can set breakpoints in your code and then run the game in the Unreal Engine Editor. When a breakpoint is hit, you can debug the code in Visual Studio.

If you've opened the folder for the Lyra game sample project in Visual Studio, you can follow these steps to try debugging.

1. In Visual Studio, open `LyraGameplayAbility_RangedWeapon.cpp`. Either search for that file in the Search pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Weapons** > **LyraGameplayAbility_RangedWeapon.cpp**.
1. In `LyraGameplayAbility_RangedWeapon.cpp`, go to line 477. You should see this function: `void ULyraGameplayAbility_RangedWeapon::OnTargetDataReadyCallback`
1. Place a breakpoint on the function by pressing F9.
1. Run the sample game in Visual Studio by choosing **Debug** > **Start Debugging**. Give the Unreal Engine Editor some time to load the Lyra game.
1. In the Unreal Engine Editor, choose the Play button on the toolbar (or press `Alt+p`) to start the game.
1. In the Lyra game, use the `w`, `a`, `s`, `d` keys to navigate the player left to the **Elimination** portal. Position the player over the entry portal to load the game.
1. Once the game is running, click the mouse button to fire, and you should see the breakpoint be hit in Visual Studio:
    :::image type="content" source="../media/vs-unreal-engine-debugging.png" alt-text="A screenshot of debugging in Visual Studio. A breakpoint is hit in the OnTargetDataReadyCallback function.":::

## Edit target properties

To edit Unreal Engine target properties, right-click on the bolded target file in the Solution Explorer and choose **Edit Unreal Engine target properties**. For example, if `LyraEditor.Target.cs` is the startup project (in which case it is bolded in the Solution Explorer), right-click on it and choose **Edit this Unreal Engine target properties**. This opens the `UETargetProperties.json` file in the editor. You can then change target properties such as command-line arguments, and so on.

:::image type="complex" source="../media/vs-unreal-engine-target-properties.png" alt-text="A screenshot of a right click on the LyraEditor.Target.cs solution explorer item.":::
A menu appears and at the bottom is the option to edit this Unreal Engine target. Selecting this option opens the UETargetProperties.json file in the editor.
:::image-end:::

## Edit project settings

To edit the Unreal Engine project settings, right-click on the `.uproject` file in the Solution Explorer and choose **Edit Unreal Engine project settings**. This opens the `ProjectSettings.json` file in the editor. You can then change project settings such as which project files and engine files to exclude from the Solution explorer view, what shared include paths to exclude from IntelliSense, and so on.

:::image type="complex" source="../media/vs-unreal-engine-project-properties.png" alt-text="A screenshot of a right click on the LyraStarterGame.uproject solution explorer item.":::
A menu appears and at the bottom is the option to edit the Unreal Engine project settings. Selecting this options opens the .uproject file in the editor.
:::image-end:::

## Common issues and solutions

- Your engine and game code must be on the same drive.
- Folders with multiple `.uproject` files in the same folder are not supported. To open a specific `.uproject` file when there are multiple project files in the same folder, use **File** > **Open** > **Unreal Engine project**.
- If you open an Unreal Engine project via **File** > **Open** > **Unreal Engine project**, the project won't appear in Visual Studio's **File** > **Recent Projects and Solutions** list. If you open the Unreal Engine project via **File** > **Open Folder**, then the opened Unreal Engine project appears in the recently opened projects list.
- Some extensions may not work with a project that has been opened as an Unreal Engine project.
- The property window is empty for source files. This is currently by design.
- There is a solution file in the folder view. This is generated by Unreal Engine and is not used by Visual Studio. You can ignore it.

## Related content

[Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md)\
[Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md)\
[Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md)\
[View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)\
[View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)\
[View Unreal Engine macros in Visual Studio](vs-tools-unreal-view-macros.md)