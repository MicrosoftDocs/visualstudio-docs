---
title: "Quickstart: Using Visual Studio Tools for Unreal Engine"
description: "Quickstart: Learn how to connect Unreal Engine and Visual Studio. Visual Studio Tools for Unreal Engine offers support for writing and debugging C++ games."
ms.date: 07/24/2023
ms.custom: 
ms.technology: vs-unreal-engine-tools
ms.prod: visual-studio
ms.topic: quickstart
author: "TylerMSFT"
ms.author: "twhitney"
manager: Markl
ms.workload: "unreal"
---

# Quickstart: Using Visual Studio Tools for Unreal Engine

In this quickstart, you learn how to download a Unreal Engine (UE) game sample and then use the Visual Studio Tools for Unreal Engine to view Blueprints in Visual Studio, add UE classes in Visual Studio, view UE logging within Visual Studio, and view expanded UE macros from within Visual Studio. See [Visual Studio Tools for Unreal Engine](./visual-studio-tools-for-unreal.md) for an overview of these tools.

## Prerequisites

This quickstart assumes that you have already installed:

    - Visual Studio version 17.7 or higher
    - UnReal Engine version 5 or higher. [Download instructions](https://www.unrealengine.com/download)

## Install Visual Studio Tools for Unreal Engine

1. Type "Visual Studio Installer" in the Windows search box.
1. Look for the installer under the Apps results and double-click it.
1. Select **Modify**.
1. Select the **Workloads** tab, then select the **Game development with C++** workload.
1. In the **Installations details** pane on the right, ensure that under **Game development with C++** > **Optional** that **IDE support for Unreal Engine** and **HLSL Tools** are selected.
1. Select the **Individual components** tab at the top of the dialog.
1. On the right, under **Installation details**, Expand **Desktop development with C++**.
1. Ensure that under **Optional** that **Windows 10 SDK 10.0.18362.0**, or higher, is selected.
1. Select **Modify** to complete the installation.

   :::image type="content" source="../media/unreal-workload.png" alt-text="Screenshot of the game development with C++ workload selected in the installer. In the installation details pane, IDE support for Unreal Engine and HLSL Tools are checked.":::

When Visual Studio completes the installation process, you're ready to set up Unreal Engine. For more information about customizations you can make to the Visual Studio IDE to work better with Unreal Engine, see the **Recommended Settings** section at [Setting Up Visual Studio for Unreal Engine](https://docs.unrealengine.com/4.27/ProductionPipelines/DevelopmentSetup/VisualStudioSetup/).

## Configure Unreal Engine to use Visual Studio

To use the Visual Studio tools for Unreal Engine, you also must install the free, open-source **Visual Studio Integration Tool** plugin inside of Unreal Engine to see Blueprint references and assets. Install the plugin via the [Unreal Engine Marketplace](https://aka.ms/VSUEMarketplace). In the UE marketplace, a **Free** button will appear to get the plugin. Select it, and then in the UE Games Launcher choose **Install to Engine** and follow the prompt.

Unreal provides a Visual Studio extension that provides a convenient way to build the UE project, set command line arguments, batch build projects, and so on. It is not necessary to use the Visual Studio tools for UE, but does provide some convenience features. For more information about the optional extension, see [UnrealVS Extension](https://docs.unrealengine.com/5.2/using-the-unrealvs-extension-for-unreal-engine-cplusplus-projects/). If you have difficulty with the installation, see the [Troubleshooting guide](https://github.com/microsoft/vc-ue-extensions/blob/main/Docs/Troubleshooting.md)

## Check for updates

We recommend that you keep Visual Studio updated for the latest bug fixes, features, and Unreal Engine support. Updating Visual Studio doesn't require an update of Unreal Engine.

1. From the Visual Studio main menu, select **Help** > **Check for Updates**.

   :::image type="content" source="../media/vs/check-for-updates.png" alt-text="Screenshot of the Check for Updates menu in Visual Studio Help menu.":::

1. If an update is available, the Visual Studio Installer shows a new version. Select **Update**.

   :::image type="content" source="../media/vs/click-to-update.png" alt-text="Screenshot of Visual Studio Installer with the Updates.":::

## Next steps

[Learn about and install the UnrealVS extension](https://docs.unrealengine.com/5.0/using-the-unrealvs-extension-for-unreal-engine-cplusplus-projects)