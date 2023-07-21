---
title: "Visual Studio Tools for Unreal Engine | Microsoft Docs"
description: Read an overview about Visual Studio Tools for Unreal Engine, which is a free Visual Studio extension that helps you develop games with Unreal Engine.
ms.date: "07/24/2023"
ms.technology: vs-unreal-engine-tools
ms.prod: visual-studio
ms.topic: overview
author: TylerMSFT
ms.author: TWhitney
manager: MarkL
ms.workload: "unreal"
---

# Quickstart: Use Visual Studio Tools for Unreal Engine

In this quickstart, you learn how to download a Unreal Engine (UE) game sample and then use the Visual Studio Tools for Unreal Engine to do the following fronm within Visual Studio: view Blueprints, view UE logging, and view expanded UE macros. See [Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md) for an overview.

## Prerequisites

This quickstart assumes that you have already installed:

    - Visual Studio version 17.7 or higher
    - UnReal Engine version 5 or higher.

## Download and build the Lyra game sample in Visual Studio

Download the Unreal Engine (UE) Lyra starter game to have a project to demonstrate the various Visual Studio Tools for Unreal Engine on. Lyra is a sample 3D game project for learning about the frameworks in Unreal Engine. See the **Downloading the Lyra Starter Game** section at [Lyra Sample Game](https://docs.unrealengine.com/5.0/lyra-sample-game-in-unreal-engine/) for instructions on how to download the game assets.

Once you have downloaded the game sample, update `LyraStarterGame.uproject` to use the Visual Studio Tools plugin. To do so, follow these steps:
1. Open the `LyraStarterGame.uproject` file in a text editor
1. Add the following to the end of the `Plugins` section:

```json
        ,{
			"Name": "VisualStudioTools",
			"Enabled": true,
			"MarketplaceURL": "com.epicgames.launcher://ue/marketplace/product/362651520df94e4fa65492dbcba44ae2",
			"SupportedTargetPlatforms": [
				"Win64"
			]
		}
``````

1. Open the Lyra project in Unreal Engine.
1. In the Unreal Engine editor, from the main menu choose **Tools** > **Refresh Visual Studio Project**. This creates/refreshes the solution file for Visual Studio.
1. In the Unreal Engine editor, from the main menu choose **File** > **Open Visual Studio**. This opens the game solution file in Visual Studio. If you have multiple versions of Visual Studio on your machine, ensure that the right version of Visual Studio open. From the Visual Studio main menu, choose **Help** > **About Microsoft Visual Studio**. You need to use Visual Studio 2022 version 17.7 or higher. If the right version didn't open, manually open `LyraStarterGame.sln` in the correct version of Visual Studio.
1. Build the game solution in Visual Studio. From the main menu choose **Build** > **Build Solution**.
1. Change the Solutions Configurations dropdown to **Development editor**. This step is necessary to enable the Blueprints Visual Studio Tools for Unreal Engine.

:::image type="content" source="../media/ue-config.png" alt-text="Screenshot of Visual Studio with the Solutions Configurations dropdown expanded and Development Editor selected.":::

1. In Visual Studio, open `LyraCharacter.h`. You can either search for that file in the Search Solution Explorer (Ctrl+;) pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **AbilitySystem** > **Abilities** > **LyraGameplayAbility.h**

## View Blueprints



