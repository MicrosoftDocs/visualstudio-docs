---
title: "Quickstart: Install & configure Visual Studio Tools for Unreal Engine"
description: "Quickstart: Learn how to connect Unreal Engine and Visual Studio. Visual Studio Tools for Unreal Engine offers support for writing and debugging C++ games."
ms.date: 07/24/2023
ms.custom: 
ms.technology: vs-unreal-tools
ms.prod: visual-studio
ms.topic: quickstart
author: "TylerMSFT"
ms.author: "twhitney"
manager: Markl
ms.workload: "unreal"
---

# Quickstart: Configure Visual Studio for development with Unreal Engine

In this quickstart, you learn how to install the Visual Studio Tools for Unreal Engine (UE) for developing C++ games and apps. The Visual Studio Tools for Unreal Engine are free and provide support for adding UE classes in Visual Studio, expanding UE macros, finding and viewing Blueprint references, and more. See [Visual Studio Tools for Unreal Engine](./visual-studio-tools-for-unreadl.md) for a complete list of what the these tools include.

## Install Visual Studio Tools for Unreal Engine

This quickstart assumes that you have already installed Visual Studio version 17.7 or higher.

1. Type "Visual Studio Installer" in the Windows search box.
1. Look for the installer under the Apps results and double-click it.
1. Select **Modify**.
1. Select the **Workloads** tab, then select the **Game development with C++** workload.
1. In the Installations details pane on the right, ensure that IDE support for Unreal Engine is selected.
1. In the Installations details pane on the right, ensure that HLSL Tools is selected.
1. Select **Close** to complete the installation.

   :::image type="content" source="../media/unreal-workload.png" alt-text="Screenshot of the game development with CC++ workload selected in the installer. In the installation details pane, IDE support for Unreal Engine and HLSL Tools are checked.":::

When Visual Studio completes the installation process, you're ready to set up the Unreal Engine.

## Configure Unreal Engine to use Visual Studio

## Check for updates

We recommend that you keep Visual Studio updated for the latest bug fixes, features, and Unreal Engine support. Updating Visual Studio doesn't require an update of Unreal Engine.

1. Select the **Help** > **Check for Updates** menu.

   :::image type="content" source="../media/vs/check-for-updates.png" alt-text="Screenshot of the Check for Updates menu in Visual Studio Help menu.":::

1. If an update is available, the Visual Studio Installer shows a new version. Select **Update**.

   :::image type="content" source="../media/vs/click-to-update.png" alt-text="Screenshot of Visual Studio Installer with the Updates.":::

## Next steps

Learn about ...