---
title: "Install Visual Studio Tools for Unreal Engine"
description: "Learn how to connect Unreal Engine and Visual Studio. Visual Studio Tools for Unreal Engine offers support for writing and debugging C++ Unreal Engine games."
ms.date: 06/18/2025
ms.service: visual-studio
ms.subservice: unreal-engine-tools
ms.topic: get-started
author: "TylerMSFT"
ms.author: "twhitney"
manager: Coxford
---

# Install Visual Studio Tools for Unreal Engine

This article helps you install tools that allow you to do the following from within Visual Studio:

- View UE logging
- View and expand UE macros
- Add UE classes, modules, and plugins
- Discover, run, manage, and debug Unreal Engine tests
- Debug C++ code called by Unreal Engine Blueprints and see Blueprint information in the Visual Studio debugger
- View and find references to UE Blueprints



## Prerequisites

Install the following before you install Visual Studio Tools for Unreal Engine:

- Visual Studio version 17.7 or later. To install, see [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta)
- Unreal Engine version 4.27 or 5.0 or later. To install, see [Download instructions](https://www.unrealengine.com/download)

## Installation

This article covers installing tools to enhance writing and debugging Unreal Engine (UE) code in Visual Studio. Here's an overview of the tools that you can install:

| Tool | Installs into | Notes |
|--|--|--|
| Visual Studio Tools for Unreal Engine | Visual Studio | Add UE classes, modules, view UE logging, see UE macro expansions, find blueprint references, open UE .uprojects directly, and so on from within Visual Studio. *As of Visual Studio 2022 version 17.7, you no longer need the Unreal Engine Visual Studio Integration Tool plugin to view UE Blueprints in Visual Studio.* |
| Visual Studio debugger tools for Unreal Engine Blueprints | Visual Studio | Supports debugging C++ code called by Blueprints. Requires the UE plugin for Visual Studio to show Blueprint node pin values in the debugger. |
| Unreal Engine Test Adapter | Visual Studio | Discover, run, manage, and debug your Unreal Engine tests from within Visual Studio. Requires the UE plugin for Visual Studio. |
| Unreal Engine plugin for Visual Studio | Unreal Engine | Provides the integration between Unreal Engine and Visual Studio run UE tests in Visual Studio and viewing Blueprint node pin values in the Visual Studio Local Variables window. |

Follow these steps to install the tools:

1. In the Windows search box, type "Visual Studio Installer".
1. Look for the installer under the Apps results and double-click it.
1. When the installer appears, select the version of Visual Studio you're using and then select **Modify**.
1. Select the **Workloads** tab, then select the **Game development with C++** workload.
1. In the **Installations details** pane, ensure that under **Game development with C++** > **Optional** that the following are selected:
    - **Visual Studio Tools for Unreal Engine**
    - **Visual Studio debugger tools for Unreal Engine Blueprints**
    - **Unreal Engine Test Adapter**
    - If you work with High-Level Shader Language (HLSL) files, ensure that **HLSL Tools** is also selected.
1. Select the **Individual components** tab at the top of the dialog.
1. Under **Installation details** on the right, expand **Game development with C++**.
1. Ensure that under **Optional** that **Windows 10 SDK 10.0.18362.0**, or higher, is selected.
1. Select **Modify** to complete the installation.

   :::image type="content" source="../media/vs-installer-unreal-engine-workload.png" alt-text="Screenshot of the Visual Studio installer. The Game development with C++ workload is selected. In the installation details pane, Visual Studio Tools for Unreal Engine, Visual Studio debugger tools for Unreal Engine Blueprints, HSL Tools, And Windows 11 SDK are selected." lightbox="../media/vs-installer-unreal-engine-workload.png":::

To install the Unreal Engine plugin for Visual Studio, follow these steps:

- For manual installation instructions, see [vc-ue-extensions](https://github.com/microsoft/vc-ue-extensions).
- If you have an Unreal Engine project that you can open in Visual Studio, another way to install the plugin is in Visual Studio via the Unreal Engine Configuration window. With an Unreal Engine project opened in Visual Studio, choose **Project** > **Configure Tools for Unreal Engine** to open the **Unreal Engine Integration Configuration** window. Then in the Visual Studio Integration Tool Status section, select **Install to Project** or **Install to Engine** as meets your needs. If you don't see the install buttons, choose the refresh icon in the top right corner of the window to refresh the status.  There is also a **Manual installation instructions** link that opens the [vc-ue-extensions](https://github.com/microsoft/vc-ue-extensions/blob/main/README.md) page, if you need to install the plugin manually.

    :::image type="content" source="../media/unreal-engine-configuration-page-plugin.png" alt-text="Screenshot of the Unreal Engine Integration Configuration window. In the Visual Studio Integration Tool Status section, the refresh, Install to Project, Install to Engine buttons are highlighted. The Manual installation instructions link is also highlighted.":::

## Check for updates

We recommend that you keep Visual Studio updated for the latest bug fixes, features, and Unreal Engine support. Updating Visual Studio doesn't require an update of Unreal Engine.

1. From the Visual Studio main menu, select **Help** > **Check for Updates**.

   :::image type="content" source="../../unity/media/vs/check-for-updates.png" alt-text="Screenshot of the Check for Updates menu in Visual Studio Help menu.":::

1. If an update is available, the Visual Studio Installer shows a new version. Select **Update**.

   :::image type="content" source="../../unity/media/vs/click-to-update.png" alt-text="Screenshot of Visual Studio Installer with the Updates.":::

## Next steps

Try out some of the features of the Visual Studio Tools for Unreal Engine:

[Quickstart: Use Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md)\
[Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md)\
[View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)\
[View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)\
[View Unreal Engine macros in Visual Studio](vs-tools-unreal-view-macros.md)
