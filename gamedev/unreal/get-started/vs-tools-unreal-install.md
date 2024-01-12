---
title: "Install Visual Studio Tools for Unreal Engine"
description: "Learn how to connect Unreal Engine and Visual Studio. Visual Studio Tools for Unreal Engine offers support for writing and debugging C++ Unreal Engine games."
ms.date: 08/02/2023
ms.service: visual-studio
ms.subservice: unreal-engine-tools
ms.topic: get-started
author: "TylerMSFT"
ms.author: "twhitney"
manager: Markl
---

# Install Visual Studio Tools for Unreal Engine

This article helps you install Visual Studio Tools for Unreal Engine. These tools allow you to do the following from within Visual Studio:
- view Unreal Engine (UE) Blueprints
- add UE classes
- view UE logging
- view and expand UE macros

## Prerequisites

You should have the following installed before you install Visual Studio Tools for Unreal Engine:

- Visual Studio version 17.7 or later. To install, see [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta)
- Unreal Engine version 4.27 or 5.0 or later. To install, see [Download instructions](https://www.unrealengine.com/download)

## Install Visual Studio Tools for Unreal Engine

This article covers installing two tools for connecting Visual Studio and Unreal Engine:

- **Visual Studio Tools for Unreal Engine** are installed with the Visual Studio installer. They enable you to add UE classes, view UE logging, and more, all from within Visual Studio.
- **Unreal Engine Visual Studio Integration Tool plugin** is installed in Unreal Engine and works with Visual Studio to display information about Blueprint assets in C++ code.

To install Visual Studio Tools for Unreal Engine, follow these steps:

1. Type "Visual Studio Installer" in the Windows search box.
1. Look for the installer under the Apps results and double-click it.
1. When the installer appears, select the version of Visual Studio you are using (if you have multiple versions installed) and then select **Modify**.
1. Select the **Workloads** tab, then select the **Game development with C++** workload.
1. In the **Installations details** pane, ensure that under **Game development with C++** > **Optional** that **IDE support for Unreal Engine** is selected. This installs what this article refers to as the Visual Studio Tools for Unreal Engine. If you work with the High-Level Shader Language, ensure that **HLSL Tools** is also selected.
1. Select the **Individual components** tab at the top of the dialog.
1. Under **Installation details**, expand **Desktop development with C++**.
1. Ensure that under **Optional** that **Windows 10 SDK 10.0.18362.0**, or higher, is selected.
1. Select **Modify** to complete the installation.

   :::image type="content" source="../media/unreal-workload.png" alt-text="Screenshot of the game development with C++ workload selected in the installer. In the installation details pane, IDE support for Unreal Engine and HLSL Tools are checked." lightbox="../media/unreal-workload.png":::

## Configure Unreal Engine to use Visual Studio

Epic Games provides the UnrealVS extension for Visual Studio. The extension makes it easier to build UE projects, set command line arguments, batch build projects, and so on. You don't need to install this plugin to use Visual Studio Tools for Unreal Engine, but it does provide some convenience features. For more information, see [UnrealVS Extension](https://docs.unrealengine.com/using-the-unrealvs-extension-for-unreal-engine-cplusplus-projects/).

Install the Unreal Engine Visual Studio Integration Tool plugin via the [Unreal Engine Marketplace](https://aka.ms/vsituemarketplace) website. It allows you to see Blueprints assets in Visual Studio. The Unreal Engine Marketplace provides instructions for installing the plugin.

   :::image type="content" source="../media/unreal-engine-marketplace.png" alt-text="Screenshot of the Unreal Engine Marketplace with the Visual Studio Integration Tool plugin." lightbox="../media/unreal-engine-marketplace.png":::

If your engine code is built from source or if your project isn't compatible with Unreal Engine Marketplace plugins, install the plugin manually by cloning and installing the plugin from the [GitHub vc-ue-extensions repo](https://aka.ms/vc-ue-extensions). See the [README](https://github.com/microsoft/vc-ue-extensions#unreal-engine-plugin-for-visual-studio) in the repo for instructions to install the plugin. If you have difficulty with the UE plugin, see the [Troubleshooting guide](https://github.com/microsoft/vc-ue-extensions/blob/main/Docs/Troubleshooting.md)

For more information about customizations you can make to the Visual Studio IDE to work well with Unreal Engine, see the **Recommended Settings** section at [Setting Up Visual Studio for Unreal Engine](https://docs.unrealengine.com/en-US/setting-up-visual-studio-development-environment-for-cplusplus-projects-in-unreal-engine/).

## Check for updates

We recommend that you keep Visual Studio updated for the latest bug fixes, features, and Unreal Engine support. Updating Visual Studio doesn't require an update of Unreal Engine.

1. From the Visual Studio main menu, select **Help** > **Check for Updates**.

   :::image type="content" source="../../unity/media/vs/check-for-updates.png" alt-text="Screenshot of the Check for Updates menu in Visual Studio Help menu.":::

1. If an update is available, the Visual Studio Installer shows a new version. Select **Update**.

   :::image type="content" source="../../unity/media/vs/click-to-update.png" alt-text="Screenshot of Visual Studio Installer with the Updates.":::

## Next steps

Try out some of the features of the Visual Studio Tools for Unreal Engine: [Quickstart: Use Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md)
