---
title: "Quickstart: Visual Studio Tools for Unreal Engine | Microsoft Docs"
description: Read an overview about Visual Studio Tools for Unreal Engine, which is a free Visual Studio extension that helps you develop games with Unreal Engine.
ms.date: "08/01/2023"
ms.topic: quickstart
ms.prod: visual-studio
author: TylerMSFT
ms.author: TWhitney
manager: MarkL
---

# Quickstart: Visual Studio Tools for Unreal Engine

Download a Unreal Engine (UE) game sample and use Visual Studio Tools for Unreal Engine to:
- [View UE Blueprints in Visual Studio](#view-ue-blueprints-in-visual-studio)
- [View UE logging in Visual Studio](#view-ue-logging-within-visual-studio)
- [View UE macros in Visual Studio](#view-ue-macros-in-visual-studio)

## Prerequisites

The following must be installed:

- Visual Studio version 17.7 or later
- Unreal Engine version 5 or later because the example used in this quickstart requires UE5 or later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.

## Download and build the Lyra game sample in Visual Studio

Lyra is a sample 3D game project for learning about the frameworks in Unreal Engine. See the **Downloading the Lyra Starter Game** section at [Lyra Sample Game](https://docs.unrealengine.com/5.0/lyra-sample-game-in-unreal-engine/) for download instructions.

## Configure the Lyra game sample to use Visual Studio Tools for Unreal Engine

Once you have downloaded the game sample, update `LyraStarterGame.uproject` to use the Visual Studio Tools plugin. You could also do this in the Unreal Editor from the main menu under **Edit** > **Plugins** and then find the Visual Studio Integration plugin and check the box next to it. But we'll do it by following these steps:
1. Open the `LyraStarterGame.uproject` file in a text editor. It's in the directory where you installed the game sample.
1. Add the following to the end of the `Plugins` section:

    ```json
	,{
		"Name": "VisualStudioTools",
		"Enabled": true
	}
    ```

1. Open the Lyra project in Unreal Engine.
1. From the Unreal Engine editor main menu, choose **Tools** > **Refresh Visual Studio Project**. This creates/refreshes the solution file for Visual Studio.
1. From the Unreal Engine editor main menu, choose **File** > **Open Visual Studio**. This opens the game in Visual Studio. If you have multiple versions of Visual Studio on your machine, ensure that the right version opened. From the Visual Studio main menu, choose **Help** > **About Microsoft Visual Studio**. You need to use Visual Studio 2022 version 17.7 or higher. If the right version didn't open, manually open `LyraStarterGame.sln` in the correct version of Visual Studio.
1. From the Visual Studio main menu, choose **Build** > **Build Solution** to build the game.
1. Change the **Solutions Configurations** dropdown to **Development Editor**. This enables the Blueprints Visual Studio Tools for Unreal Engine.
    :::image type="content" source="../media/ue-config-dropdown.png" alt-text="Screenshot of Visual Studio with the Solutions Configurations dropdown expanded and Development Editor selected.":::

## View UE Blueprints in Visual Studio

You can view, but not edit, UE Blueprints from within Visual Studio. This is useful because you can see UE Blueprints without having to switch between the Unreal Editor and Visual Studio. To try it out, follow these steps:

1. In Visual Studio, open `LyraCharacter.h`. Search for that file in the Search pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **AbilitySystem** > **Abilities** > **LyraGameplayAbility.h**
1. In `LyraCharacter.h`, go to line 96. You should see the following code: `class LYRAGAME_API ALyraCharacter : public AModularCharacter, public IAbilitySystemInterface, public IGameplayCueInterface, public IGameplayTagAssetInterface, public ILyraTeamAgentInterface`
1. There are four Blueprint classes that extend this class. You should see a link just above the `ALyraCharacter` class definition that says: `4 derived Blueprint classes`. Click that link to view the four Blueprint classes that extend this class:
    :::image type="content" source="../media/vs-blueprints-link.png" alt-text="Screenshot of the ALyra Character class, which has a link above it that says 4 derived blueprint classes. It has been selected, showing Blueprints such as B_ShootingTarget_C, Character_Default_C, and so on, along with their Asset Paths.":::
1. To view the properties of the `Character_Default_C` Blueprint, double-click it to open the Blueprint asset viewer. You can view the various properties of the Blueprint, but you can't change them.
    :::image type="content" source="../media/vs-blueprints-asset-viewer.png" alt-text="Screenshot of the Character_Default_C Blueprint asset viewer. It shows properties such as Actor, Camera, Character, Collision, and so on. ":::

## View UE logging within Visual Studio

You can now view UE logging within Visual Studio. This is useful because you can see UE logging without having to switch between the Unreal Editor and Visual Studio. To try it out, follow these steps:

1. In Visual Studio, open `LyraGameplayAbility_RangedWeapon.cpp`. Search for that file in the Search pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Weapons** > **LyraGameplayAbility_RangedWeapon.cpp**
1. In `LyraGameplayAbility_RangedWeapon.cpp`, go to line 477. You should see the following function: `void ULyraGameplayAbility_RangedWeapon::OnTargetDataReadyCallback`
1. Create a new line at the beginning of the function and insert `UE_LOG(LogLyra, Log, TEXT("shot fired"));` This creates a log entry, associated with the category `LogLyra`, that says `shot fired` when this function is called.
1. Run the sample game in Visual Studio by choosing **Debug** > **Start Debugging**. The Unreal Editor will open with the Lyra game. Give it a few moments to load.
1. In Visual Studio, open the UE logging window by choosing **View** > **Other Windows** > **Unreal Engine Log** from the Visual Studio main menu.
1. Reduce log noise by filtering to only show the `LogLyra` category events as follows: in the UE logging window, choose the **Categories** dropdown. Clear all of the log sources by choosing **(Select All)** at the top of the list. Then select **LogLyra**.
1. In the Unreal Editor, choose the Play button on the toolbar (or `Alt+p`) to start the game.
1. In the Lyra game, use the `w`, `a`, `s`, `d` keys to navigate the player to the left to the **Elimination** portal. When you hover over that entry portal, the game will load.
1. In the Lyra game, click your mouse button to fire. In the UE logging window, you should see the following log message: `shot fired`:

    :::image type="content" source="../media/vs-ue-log.png" alt-text="A screenshot of the Unreal Engine Log in Visual Studio. It shows several 'shot fired' events that are prefaced by a timestamp and the text 'LogLyra' since that's that category the events were logged as.":::

The events will be at the bottom of the log so you may have to scroll down to see them. You could also choose the **Clear** button to clear the log and then fire again to see the log message.

If you find the font color hard to read, you can adjust it under **Tools** > **Options** > **Environment** > **Fonts and Colors**. Change the dropdown **Show settings for:** to **Unreal Engine Log**. In **Display items:** select **Log** and change the **Item foreground** color to something easier to see for you.

Having the UE logging window open while you're debugging is very convenient because you don't have to switch to the Unreal Editor to see them.

## View UE macros in Visual Studio

Long UE macros can be difficult to read. Visual Studio Tools for Unreal Engine expands UE macros so that you can read them more easily. You can copy the expanded macro if you want to use it somewhere else. You can also search for it or compare with another macro. To experiment with these features, follow these steps:

1. In Visual Studio, open `LyraGameplayAbility_RangedWeapon.cpp`. Search for that file in the Search pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Weapons** > **LyraGameplayAbility_RangedWeapon.cpp**
1. In `LyraGameplayAbility_RangedWeapon.cpp`, go to line 41. You should see the following macro: `UE_DEFINE_GAMEPLAY_TAG_STATIC(TAG_WeaponFireBlocked, "Ability.Weapon.NoFiring");`
1. Hover the mouse pointer over `UE_DEFINE_GAMEPLAY_TAG_STATIC` to see the macro definition window appear:
    :::image type="content" source="../media/vs-ue-macro-tooltip.png" alt-text="A screenshot in Visual Studio of the UE macro tooltip. It shows the UE_DEFINE_GAMEPLAY_TAG_STATIC macro and has options at the bottom to copy, expand inline, visualize expansion, and search online":::
    The options at the bottom allow you to copy the macro to the clipboard, expand the macro inline, visualize the expansion, and search online.
1. Choose **Expand inline**, to expand the macro, and all nested macros, in the code window.
    :::image type="content" source="../media/vs-ue-macro-expanded-inline.png" alt-text="A screenshot in Visual Studio of the code window. It shows the expanded contents of the UE_DEFINE_GAMEPLAY_TAG_STATIC macro, which has replaced the macro on that line in the code windows.":::
    You can press `Ctrl+z` to undo the expansion.
1. Choose **Search online** to open your browser. It will open with a search populated to find the macro. In the previous example, this opens the browser to search for `C++ #define UE_DEFINE_GAMEPLAY_TAG_STATIC(TagName, Tag) static FNativeGameplayTag TagName(UE_PLUGIN_NAME, UE_MODULE_NAME,  …`
1. Choose **Visualize the expansion** to open the **Macro Expansion** window. You can expand the nested macros that are part of the larger macro one step at a time. Scroll to the end of the expansion to see the macro expansion arrows in the upper-right corner of the window. Choose the right arrow to expand the next nested macro. Choose the left arrow to collapse the last nested macro that was expanded:
    :::image type="content" source="../media/vs-ue-macro-expansion.png" alt-text="A screenshot in Visual Studio of the macro expansion window. It displays the expanded contents of the UE_DEFINE_GAMEPLAY_TAG_STATIC macro and has two arrows in the upper right, which are highlighted, that allow you to expand or unexpand the macros embedded in the larger macro one step at a time":::

This quickstart gave you the opportunity to see how Visual Studio Tools for Unreal Engine makes it easier to understand UE macros, view UE logging, and view UE Blueprints.

## Next Steps

See [Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md) for an overview of Visual Studio Tools for Unreal Engine features.
