---
title: "View Unreal Engine Blueprints in Visual Studio"
description: "Learn how to view, but not edit, UE Blueprints from within Visual Studio"
ms.date: 07/24/2024
ms.topic: how-to
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: MarkL
#customer intent: As a C++ game developer using Unreal Engine and Visual Studio, I want to view Unreal Engine Blueprints in Visual Studio so that I can see them without switching between the Unreal Editor and Visual Studio.
---

# View Unreal Engine Blueprints in Visual Studio

You can view, but not edit, UE Blueprints from within Visual Studio. This is useful because you can see UE Blueprints without having to switch between the Unreal Editor and Visual Studio. To try it out, follow these steps:

## Prerequisites

The following must be installed:

- Visual Studio version 17.10 or later.
- Unreal Engine version 5 or later because the example used in this article requires Unreal Engine 5 or later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.
- Complete the [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game and configure it to use Visual Studio Tools for Unreal Engine.

## View Blueprints in the Lyra game sample

After completing the [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game, follow these steps to view Blueprints in the Lyra game sample from Visual Studio:

1. In Visual Studio, open `LyraCharacter.h`. Either search for that file in the Search pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Character** > **LyraCharacter.h**.
1. In `LyraCharacter.h`, go to line 96. You should see the following class: `class LYRAGAME_API ALyraCharacter : public AModularCharacter ...`
1. There are four Blueprint classes that extend this class. You should see a link just above the `ALyraCharacter` class definition that says: `4 derived Blueprint classes`. Click that link to view the four Blueprint classes that extend this class:
    :::image type="content" source="../media/vs-blueprints-link.png" alt-text="Screenshot of the Blueprints link above the Alyra Character class. It lists related Blueprints." lightbox="../media/vs-blueprints-link.png":::
1. To view the properties of the `Character_Default_C` Blueprint, double-click it to open the Blueprint asset viewer. You can view the various properties of the Blueprint, but you can't change them:
    :::image type="content" source="../media/vs-blueprints-asset-viewer.png" alt-text="Screenshot of the Character_Default_C Blueprint asset viewer. It shows properties such as Actor, Camera, Character, Collision, and so on.":::

## Related content

- [Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md) for an overview of Visual Studio Tools for Unreal Engine features.
