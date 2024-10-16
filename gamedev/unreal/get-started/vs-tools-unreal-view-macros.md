---
title: "View Unreal Engine macros in Visual Studio"
description: "Learn how to expand Unreal Engine macros from within Visual Studio"
ms.date: 07/24/2024
ms.topic: how-to
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: Coxford
#customer intent: As a C++ game developer using Unreal Engine and Visual Studio, I want to learn how to view Unreal Engine macros in Visual Studio so that I can read them more easily.
---

# View Unreal Engine macros in Visual Studio

You can use the Visual Studio Tools for Unreal Engine (UE) to view UE logging within Visual Studio. This is useful because you can see UE logging without having to switch between the Unreal Editor and Visual Studio.

## Prerequisites

Install the following:

- Visual Studio version 17.10 or later.
- Unreal Engine version 5 or later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.
- Complete the [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game and configure it to use Visual Studio Tools for Unreal Engine.

## View Unreal Engine macros in Visual Studio

Long UE macros can be difficult to read. Visual Studio Tools for Unreal Engine expands UE macros so that you can read them more easily. You can copy the expanded macro if you want. You can also search for it online or compare it with another macro. To experiment with these features, follow these steps after completing the [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game.

1. In Visual Studio, open `LyraGameplayAbility_RangedWeapon.cpp`. Either search for that file in the Search pane of the **Solution Explorer** or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Weapons** > **LyraGameplayAbility_RangedWeapon.cpp**
1. In `LyraGameplayAbility_RangedWeapon.cpp`, go to line 41. You should see the following macro: `UE_DEFINE_GAMEPLAY_TAG_STATIC(TAG_WeaponFireBlocked, "Ability.Weapon.NoFiring");`
1. Hover the mouse pointer over `UE_DEFINE_GAMEPLAY_TAG_STATIC` to see the macro definition window:
    :::image type="content" source="../media/vs-unreal-engine-macro-tooltip.png" alt-text="A screenshot in Visual Studio of the UE macro tooltip. There are options at the bottom to copy, expand inline, visualize expansion, and search online." lightbox="../media/vs-unreal-engine-macro-tooltip.png":::
    The options at the bottom copy the macro to the clipboard, expand the macro inline, visualize the macro's expansion, and search online for the macro.
1. Choose **Expand Inline**, to expand the macro, and all nested macros, in the code window.
    :::image type="content" source="../media/vs-unreal-engine-macro-expanded-inline.png" alt-text="A screenshot of the expanded contents of the UE_DEFINE_GAMEPLAY_TAG_STATIC macro." lightbox="../media/vs-unreal-engine-macro-expanded-inline.png":::
    You can press `Ctrl+z` to undo the expansion.
1. Choose **Search online** to open your browser. It opens with a search populated to find the macro. In the previous example, this opens the browser to search for `C++ #define UE_DEFINE_GAMEPLAY_TAG_STATIC(TagName, Tag) static FNativeGameplayTag TagName(UE_PLUGIN_NAME, UE_MODULE_NAME,  …`
1. Choose **Visualize the expansion** to open the **Macro Expansion** window. You can expand the nested macros that are part of the larger macro one step at a time. Scroll to the end of the expansion to see the macro expansion arrows in the upper-right corner of the window. Choose the right arrow to expand the next nested macro. Choose the left arrow to collapse the last nested macro that was expanded:

    :::image type="content" source="../media/vs-unreal-engine-macro-expansion.png" alt-text="A screenshot of the macro expansion window showing the expanded contents of the UE_DEFINE_GAMEPLAY_TAG_STATIC macro.":::

## Related content

[Visualize C/C++ macro expansion](/cpp/ide/visualize-macro-expansion)\
[Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md)\
[Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md)\
[View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)\
[View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)