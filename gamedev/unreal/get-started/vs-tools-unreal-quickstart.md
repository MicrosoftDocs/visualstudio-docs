---
title: "Quickstart: Visual Studio Tools for Unreal Engine"
description: "Learn about Visual Studio Tools for Unreal Engine, a free Visual Studio extension that helps you develop games with Unreal Engine"
ms.date: 08/23/2024
ms.topic: quickstart
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: Coxford
---

# Quickstart: Visual Studio Tools for Unreal Engine

In this article, download an Unreal Engine (UE) game sample and configure Visual Studio Tools for Unreal Engine. Visual Studio Tools for Unreal Engine is a free Visual Studio extension that helps you develop games with Unreal Engine. It provides a set of features that improve the Unreal Engine development experience in Visual Studio.

## Prerequisites

The following must be installed:

- Visual Studio version 17.10 or later.
- Unreal Engine version 5 or later because the example used in this article requires Unreal Engine 5 or later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.

## Download and build the Lyra game sample in Visual Studio

Lyra is a sample game project for learning about Unreal Engine. See the **Downloading the Lyra Starter Game** section at [Lyra Sample Game](https://docs.unrealengine.com/5.0/lyra-sample-game-in-unreal-engine/) for download instructions.

## Configure the Lyra game sample to use Visual Studio Tools for Unreal Engine

After you download the game sample, update `LyraStarterGame.uproject` to use the Visual Studio Tools plugin. You could also do this in the Unreal Editor after loading the Lyra project from the main menu under **Edit** > **Plugins** and then find the *Visual Studio Integration Tools* plugin and check the box next to it.

As of Visual Studio 2022 version 17.7, the Visual Studio Tools for Unreal Engine plugin is included with the Unreal Engine installation. It's no longer required to view Unreal Engine Blueprints. If you have an earlier version of Visual Studio, see [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) to install the plugin manually.

1. Open the `LyraStarterGame.uproject` file in a text editor. It's in the directory where you installed the game sample.
1. Add the following to the end of the `Plugins` section:

    ```json
    ,{
        "Name": "VisualStudioTools",
        "Enabled": true
    }
    ```

1. Open the Lyra project in Unreal Engine.
1. From the Unreal Engine editor main menu, choose **Tools** > **Generate Visual Studio Project**. This creates the solution file for Visual Studio.
1. From the Unreal Engine editor main menu, choose **Tools** > **Open Visual Studio** to open the game in Visual Studio. If you have multiple versions of Visual Studio on your machine, ensure that the right version opened: from the Visual Studio main menu, choose **Help** > **About Microsoft Visual Studio**. You need to use Visual Studio 2022 version 17.7 or higher. If the right version didn't open, manually open `LyraStarterGame.sln` in the correct version of Visual Studio.
1. Change the **Solutions Configurations** dropdown to **Development Editor**. This enables the Blueprints Visual Studio Tools for Unreal Engine:
    :::image type="content" source="../media/unreal-engine-configuration-dropdown.png" alt-text="Screenshot of Visual Studio with the Solutions Configurations dropdown expanded and Development Editor selected.":::
1. From the Visual Studio main menu, choose **Build** > **Build Solution** to build the game.

## Build output window

The build output window in Visual Studio is where you can see the progress of the build and any errors or warnings that occur. You can open the build output window from the Visual Studio main menu via **View** > **Output**.

Starting in Visual Studio 2022 17.12, you can double-click on an absolute path to a file in the output window to open that file in Visual Studio. The source code must be part of the Visual Studio solution and the path in the output window must be an absolute path.

The following screenshot shows the output windows for a build of the LyraStarterGame sample. The user has double-clicked on the warning from `LyraCharacter.generated.h`. Because the absolute path to that file is provided, double-clicking it opened the file in the editor.

:::image type="content" source="../media/vs-unreal-engine-output-window.png" alt-text="A screenshot of the Visual Studio output window. The LyraCharacter.generated.h file is highlighted because the absolute path is specified and the user double-clicked it to open the LyrCharacter.generated.h file." lightbox="../media/vs-unreal-engine-output-window.png":::

## Unreal Engine toolbar

Visual Studio provides a toolbar that improves the Unreal Engine development integration experience in Visual Studio. The toolbar provides quick access to common UE tasks.

Activate the Unreal Engine toolbar in Visual Studio from the main menu via **View** > **Toolbars** > **Unreal Engine**. The toolbar looks like:

:::image type="content" source="../media/unreal-engine-toolbar.png" alt-text="A screenshot of the Unreal Engine toolbar in Visual Studio.":::

The toolbar buttons, left to right, do the following:

- The play icon is a quick attach button that attaches to processes listed in the dropdown to the right. The dropdown lists Unreal Engine related processes, which makes it easier to attach to the Unreal Engine Editor more easily. You can also use this to attach to any processes.
- Buttons to start and stop the Unreal Engine integration server. The integration server improves the performance of Unreal Engine integration with Visual Studio. It runs as a background process and automatically updates test information as you work on your project. You can turn it off to reclaim machine resources, and start it when you want the integration improvements. The server is started automatically when you open a UE project in Visual Studio.
- A button to rescan Unreal Engine Blueprint assets. This updates the Visual Studio solution with the latest Blueprint assets from the Unreal Engine project.
- A button that opens the Unreal Engine log window.
- A button to open the **Unreal Engine Integration Configuration** window where you can refresh and see the overall configuration status and Visual Studio Integration Tool status, check for Blueprint support, see whether get Unreal Engine naming convention checker status, and so on.

## Next steps

[Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md)\
[View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)\
[View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)\
[View Unreal Engine macros in Visual Studio](vs-tools-unreal-view-macros.md)
