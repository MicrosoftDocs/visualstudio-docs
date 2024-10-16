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
#customer intent: As a C++ game developer using Unreal Engine and Visual Studio, I want to work in Visual Studio with native Unreal Engine projects so that I can use Visual Studio's features and tools to develop my game without having to switch back-and-forth between the Unreal Editor and Visual Studio.
---

# Open native Unreal Engine projects in Visual Studio

Visual Studio 2022 version 17.12 provides direct support for Unreal Engine projects.

Previously, before you could work with an Unreal Engine project in Microsoft Visual Studio you generated a Visual Studio solution from within the Unreal Editor, or by using the Unreal Build Tool (UBT). That process was cumbersome. And whenever a new asset was added from within the Unreal Editor, or by another team member, the Visual Studio solution had to be regenerated to reflect the changes.

Now, with direct support for Unreal Engine projects (`.uproject` files) in Visual Studio, you can work directly with the Unreal Engine project from within Visual Studio. This integration enables seamless editing, debugging, and project file management without the repetitive and time-consuming process of generating and regenerating a project file between Visual Studio and Unreal Engine.

## Prerequisites

The following must be installed:

- Visual Studio version 17.12 Preview 2 or later.
- Unreal Engine version 4.27 or version 5 and later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.
- Complete the [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download the Lyra game sample, which is used in this article.

## Open a native Unreal Engine project in Visual Studio

There are two ways to open a native Unreal Engine project in Visual Studio:
- **File** > **Open** > **Folder...** which is the best choice assuming that there is only one project (`.uproject`) in the folder.
- **File** > **Open** > **Unreal Engine Project...** to pick a specific `.uproject` file to open when there are multiple Unreal Engine project files in a folder.

1. In Visual Studio, open the **File** menu, and then select **Open** > **Open Folder**.
1. Navigate to the directory where your Unreal Engine project is located and choose **Select Folder**. We'll use the Lyra game project (`LyraStarterGame.uproject`), for this example.
1. Once the folder is selected, you'll see the project files in the Solution Explorer and messages in the **Output** window regarding the steps of setting up the workspace. After a moment, you can work with the Unreal Engine project in Visual Studio.

    :::image type="complex" source="../media/vs-open-folder.png" alt-text="A screenshot of Visual Studio following opening the folder for the Lyra game sample.":::
    There is a message at the top of the editor indicating that other build systems have been disabled because an Unreal Engine project has been opened. The output window shows some last messages about the project workspace being setup. To the right is the solution explorer and it shows the folders and files in the Lyra game sample such as Platforms, Plugins, Source, and so on.
    :::image-end:::

A message appears at the top indicating the Unreal Engine project support has been activated and that the other build systems like CMake and MSBUILD are disabled. You can dismiss this message by clicking the **X** in the corner of the message.

## Solution Explorer window

The Solution Explorer window shows many of the folders and files that are part of the Unreal Engine project, such as the `Platforms`, `Plugins`, and `Source` folders. You can also see the Unreal Engine project file. The Solution Explorer is filtered to focus on source code. By default, the `Content` folders are filtered out, which contain binary assets like textures, models, and so on. You can still open these assets in the Unreal Editor. In general, binary files aren't displayed in the Visual Studio solution explorer.

## Editing and debugging in Visual Studio

You can edit, build, and debug your Unreal Engine project in Visual Studio. To learn how to add Unreal Engine modules, classes, and plugins in Visual Studio, see [Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md). You can also debug into your code. You can set breakpoints in your code and then run the game in the Unreal Engine Editor. When the breakpoint is hit, you can debug the code in Visual Studio.

If you've opened the folder for the Lyra game sample project, you can follow these steps to try out debugging.

1. In Visual Studio, open `LyraGameplayAbility_RangedWeapon.cpp`. Either search for that file in the Search pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Weapons** > **LyraGameplayAbility_RangedWeapon.cpp**.
1. In `LyraGameplayAbility_RangedWeapon.cpp`, go to line 477. You should see this function: `void ULyraGameplayAbility_RangedWeapon::OnTargetDataReadyCallback`
1. Place a breakpoint on the function by pressing F9.
1. Run the sample game in Visual Studio by choosing **Debug** > **Start Debugging**. Give the Unreal Editor some time to load the Lyra game.
1. In the Unreal Editor, choose the Play button on the toolbar (or `Alt+p`) to start the game.
1. In the Lyra game, use the `w`, `a`, `s`, `d` keys to navigate the player left to the **Elimination** portal. Position the player over the entry portal to load the game.
1. Once the game is running, click the mouse button to fire, and you should see the breakpoint be hit in Visual Studio:
    :::image type="content" source="../media/vs-unreal-engine-debugging.png" alt-text="A screenshot of debugging in Visual Studio. A breakpoint is hit in the OnTargetDataReadyCallback function.":::

## Edit target properties

To edit the Unreal Engine target properties, right-click on the bolded target file in the Solution Explorer and choose **Edit Unreal Engine target properties**. For example, if LyraEditor.Target.cs is the startup project (bolded in the Solution Explorer), right-click on it to get the **Edit this Unreal Engine target properties** menu item. You can then change target properties such as command-line arguments.

 This opens the `UETargetProperties.json` file in the editor. You can then change target properties such as command-line arguments, and so on.

:::image type="complex" source="../media/vs-unreal-engine-target-properties.png" alt-text="A screenshot of a right click on the LyraEditor.Target.cs solution explorer item.":::
    A menu appears and at the bottom is the option to edit this Unreal Engine target. Selecting this option opens the UETargetProperties.json file in the editor.
    :::image-end:::

## Edit project settings

To edit the Unreal Engine project settings, right-click on the `.uproject` file in the Solution Explorer and choose **Edit Unreal Engine project settings**. This opens the `ProjectSettings.json` file in the editor. You can then change project settings such as which project files and engine files to exclude from the Solution explorer view, what shared include paths to exclude from IntelliSense, and so on.

    :::image type="complex" source="../media/vs-unreal-engine-project-properties.png" alt-text="A screenshot of a right click on the LyraStarterGame.uproject solution explorer item.":::
    A menu appears and at the bottom is the option to edit the Unreal Engine project settings. Selecting this options opens the .uproject file in the editor.
    :::image-end:::

## Common issues and solutions

Currently, your engine and game code must be on the same drive. Please send us feedback if your particular use case requires engine and game code to be on different drives.

Folders with multiple `.uproject` files in the same folder are not supported. To open a specific `.uproject` file when there are multiple project files in the same folder, use **File** > **Open** > **Unreal Engine project**.

If you open an Unreal Engine project via **File** > **Open** > **Unreal Engine project**, the project won't appear in Visual Studio's **File** > **Recent Projects and Solutions** list. If you open the Unreal Engine project via **File** > **Open Folder**, then the opened Unreal Engine project appears in the recently opened projects list.

The property window is empty for source files. This is currently by design.
There is a solution file in the folder view. This is generated by Unreal Engine and is not used by Visual Studio. You can ignore it.

## Related content

[Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md)\
[Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md)\
[Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md)\
[View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)\
[View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)\
[View Unreal Engine macros in Visual Studio](vs-tools-unreal-view-macros.md)