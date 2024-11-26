---
title: "Install Visual Studio Tools for Unreal Engine"
description: "Learn how to connect Unreal Engine and Visual Studio. Visual Studio Tools for Unreal Engine offers support for writing and debugging C++ Unreal Engine games."
ms.date: 10/30/2024
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

<sup>*</sup>As of Visual Studio 2022 version 17.7, you no longer need the Unreal Engine Visual Studio Integration Tool plugin to view UE Blueprints in Visual Studio. However, you do need the plugin to use the Unreal Engine test adapter in Visual Studio.

## Prerequisites

You should have the following installed before you install Visual Studio Tools for Unreal Engine:

- Visual Studio version 17.7 or later. To install, see [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta)
- Unreal Engine version 4.27 or 5.0 or later. To install, see [Download instructions](https://www.unrealengine.com/download)

## Installation

This article covers installing two tools that connect Visual Studio and Unreal Engine:

- **Visual Studio Tools for Unreal Engine** are installed into Visual Studio with the Visual Studio installer. It lets you add UE classes, view UE logging, and more--all from within Visual Studio.
- **Unreal Engine Visual Studio Integration Tool plugin** is installed into Unreal Engine via the Unreal Engine Marketplace (now called FAB) or from source. It supports the Unreal Engine test adapter in Visual Studio, which lets you discover, run, manage, and debug your Unreal Engine tests from within Visual Studio. As of Visual Studio 2022 17.10, you no longer need the plugin to view UE Blueprints in Visual Studio. But you do need it to use the Unreal Engine test adapter in Visual Studio.

To install Visual Studio Tools for Unreal Engine:

1. In the Windows search box, type "Visual Studio Installer".
1. Look for the installer under the Apps results and double-click it.
1. When the installer appears, select the version of Visual Studio you're using and then select **Modify**.
1. Select the **Workloads** tab, then select the **Game development with C++** workload.
1. In the **Installations details** pane, ensure that under **Game development with C++** > **Optional** that **Visual Studio Tools for Unreal Engine** is selected. If you work with High-Level Shader Language (HLSL) files, ensure that **HLSL Tools** is also selected.
1. Select the **Individual components** tab at the top of the dialog.
1. Under **Installation details** on the right, expand **Game development with C++**.
1. Ensure that under **Optional** that **Windows 10 SDK 10.0.18362.0**, or higher, is selected.
1. Select **Modify** to complete the installation.

   :::image type="content" source="../media/unreal-workload.png" alt-text="Screenshot of the game development with C++ workload selected in the installer. In the installation details pane, IDE support for Unreal Engine and HLSL Tools are checked." lightbox="../media/unreal-workload.png":::

## Configure Unreal Engine to use Visual Studio

The UnrealVS extension provides convenience features in Visual Studio such as making it easier to build UE projects, switching between startup projects, set command-line arguments, batch build projects, and so on. The UnrealVS extension isn't required to use Visual Studio Tools for Unreal Engine. For more information, see [UnrealVS Extension](https://docs.unrealengine.com/using-the-unrealvs-extension-for-unreal-engine-cplusplus-projects/).

You can install the Unreal Engine Visual Studio Integration Tool plugin via the [Unreal Engine Marketplace (now called FAB)](https://aka.ms/vsituemarketplace) website. Search for "Visual Studio Integration Tool". The website provides instructions for installing the plugin.

If you build Unreal Engine from source, or if your project isn't compatible with Unreal Engine Marketplace plugins, install the plugin manually by cloning and installing the plugin from the [GitHub vc-ue-extensions repo](https://aka.ms/vc-ue-extensions). See the [README](https://github.com/microsoft/vc-ue-extensions#unreal-engine-plugin-for-visual-studio) in the repo for installation instructions. If you have difficulty with the UE plugin, see the [Troubleshooting guide](https://github.com/microsoft/vc-ue-extensions/blob/main/Docs/Troubleshooting.md).

For more information about customizations you can make to the Visual Studio IDE to work well with Unreal Engine, see the **Recommended Settings** section at [Setting Up Visual Studio for Unreal Engine](https://docs.unrealengine.com/en-US/setting-up-visual-studio-development-environment-for-cplusplus-projects-in-unreal-engine/).

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
