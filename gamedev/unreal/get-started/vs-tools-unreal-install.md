---
title: "Install Visual Studio Tools for Unreal Engine"
description: "Learn how to connect Unreal Engine and Visual Studio. Visual Studio Tools for Unreal Engine offers support for writing and debugging C++ Unreal Engine games."
ms.date: 06/13/2025
ms.service: visual-studio
ms.subservice: unreal-engine-tools
ms.topic: get-started
author: "TylerMSFT"
ms.author: "twhitney"
manager: Coxford
---

# Install Visual Studio Tools for Unreal Engine

This article helps you install Visual Studio Tools for Unreal Engine (UE). These tools allow you to do the following from within Visual Studio:

- Add UE classes
- View UE logging
- View and expand UE macros
- View and find references to UE Blueprints<sup>*</sup>

<sup>*</sup>As of Visual Studio 2022 version 17.7, you no longer need the Unreal Engine Visual Studio Integration Tool plugin to view UE Blueprints in Visual Studio.

## Prerequisites

Install the following before you install Visual Studio Tools for Unreal Engine:

- Visual Studio version 17.7 or later. To install, see [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta)
- Unreal Engine version 4.27 or 5.0 or later. To install, see [Download instructions](https://www.unrealengine.com/download)

## Installation

This article covers installing tools to enhance writing and debugging Unreal Engine code in Visual Studio:

- **Visual Studio Tools for Unreal Engine**: Add Unreal Engine (UE) classes, modules, view UE logging, see UE macro expansions, find blueprint references, and so on in Visual Studio.
- **Unreal Engine Test Adapter**: Discover, run, manage, and debug your Unreal Engine tests from within Visual Studio.
- **Visual Studio debugger tools for Unreal Engine Blueprints**: See information about Unreal Engine Blueprints while debugging.

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

   :::image type="content" source="../media/vs-unreal-workload.png" alt-text="Screenshot of the Visual Studio installer. The Game development with C++ workload is selected. In the installation details pane, Visual Studio Tools for Unreal Engine, Visual Studio debugger tools for Unreal Engine Blueprints, HSL Tools, And Windows 11 SDK are selected." lightbox="../media/unreal-workload.png":::

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
