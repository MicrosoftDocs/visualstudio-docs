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

Learn how to download a Unreal Engine (UE) game sample and use the Visual Studio Tools for Unreal Engine to do the following from within Visual Studio:
- view Blueprints
- view UE logging
- view expanded UE macros.
 
See [Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md) for an overview.

## Prerequisites

The following must be installed:

- Visual Studio version 17.7 or higher
- UnReal Engine version 5 or higher.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for instructions on how to install it.

## Download and build the Lyra game sample in Visual Studio

Download the Unreal Engine (UE) Lyra starter game. Lyra is a sample 3D game project for learning about the frameworks in Unreal Engine. For instructions about how to download it, see the **Downloading the Lyra Starter Game** section at [Lyra Sample Game](https://docs.unrealengine.com/5.0/lyra-sample-game-in-unreal-engine/).

## Configure the Lyra game sample to use Visual Studio Tools for Unreal Engine

Once you have downloaded the game sample, update `LyraStarterGame.uproject` to use the Visual Studio Tools plugin by following these steps:
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
    ```

1. Open the Lyra project in Unreal Engine.
1. From the Unreal Engine editor main menu, choose **Tools** > **Refresh Visual Studio Project**. This creates/refreshes the solution file for Visual Studio.
1. From the Unreal Engine editor main menu, choose **File** > **Open Visual Studio**. This opens the game in Visual Studio. If you have multiple versions of Visual Studio on your machine, ensure that the right version opened. From the Visual Studio main menu, choose **Help** > **About Microsoft Visual Studio**. You need to use Visual Studio 2022 version 17.7 or higher. If the right version didn't open, manually open `LyraStarterGame.sln` in the correct version of Visual Studio.
1. From the Visual Studio main menu, choose **Build** > **Build Solution** to build the game solution.
1. Change the **Solutions Configurations** dropdown to **Development editor**. This enables the Blueprints Visual Studio Tools for Unreal Engine.

:::image type="content" source="../media/ue-config-dropdown.png" alt-text="Screenshot of Visual Studio with the Solutions Configurations dropdown expanded and Development Editor selected.":::

1. In Visual Studio, open `LyraCharacter.h`. Search for that file in the Search pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **AbilitySystem** > **Abilities** > **LyraGameplayAbility.h**

## View Blueprints

In `LyraCharacter.h`, go to line 96. You should see the following code:

```cpp
class LYRAGAME_API ALyraCharacter : public AModularCharacter, public IAbilitySystemInterface, public IGameplayCueInterface, public IGameplayTagAssetInterface, public ILyraTeamAgentInterface
```

There are four Blueprint classes that extend this class. You should see a link just above the `ALyraCharacter` class definition that says: `4 derived Blueprint classes` link . Click that link to view the four Blueprint classes that extend this class.

:::image type="content" source="../media/vs-blueprints-link.png" alt-text="Screenshot of the ALyra Character class, which has a link above it that says 4 derived blueprint classes. It has been selected, showing Blueprints such as B_ShootingTarget_C, Character_Default_C, and so on, along with their Asset Paths.":::

To view the properties of the `Character_Default_C` Blueprint, double-click it. This opens the Blueprint asset viewer. You can view the various properties of the Blueprint, but you can't change them.

:::image type="content" source="../media/vs-blueprints-asset-viewer.png" alt-text="Screenshot of the Character_Default_C Blueprint asset viewer. It shows properties such as Actor, Camera, Character, Collision, and so on. ":::

