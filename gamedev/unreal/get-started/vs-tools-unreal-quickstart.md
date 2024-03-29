---
title: "Quickstart: Visual Studio Tools for Unreal Engine"
description: Read an overview about Visual Studio Tools for Unreal Engine, which is a free Visual Studio extension that helps you develop games with Unreal Engine.
ms.date: 10/19/2023
ms.topic: quickstart
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: MarkL
---

# Quickstart: Visual Studio Tools for Unreal Engine

In this article, download an Unreal Engine (UE) game sample and use Visual Studio Tools for Unreal Engine to:
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
1. From the Unreal Engine editor main menu, choose **Tools** > **Open Visual Studio**. This opens the game in Visual Studio. If you have multiple versions of Visual Studio on your machine, ensure that the right version opened: from the Visual Studio main menu, choose **Help** > **About Microsoft Visual Studio**. You need to use Visual Studio 2022 version 17.7 or higher. If the right version didn't open, manually open `LyraStarterGame.sln` in the correct version of Visual Studio.
1. From the Visual Studio main menu, choose **Build** > **Build Solution** to build the game.
1. Change the **Solutions Configurations** dropdown to **Development Editor**. This enables the Blueprints Visual Studio Tools for Unreal Engine:
    :::image type="content" source="../media/unreal-engine-configuration-dropdown.png" alt-text="Screenshot of Visual Studio with the Solutions Configurations dropdown expanded and Development Editor selected.":::

## View UE Blueprints in Visual Studio

You can view, but not edit, UE Blueprints from within Visual Studio. This is useful because you can see UE Blueprints without having to switch between the Unreal Editor and Visual Studio. To try it out, follow these steps:

1. In Visual Studio, open `LyraCharacter.h`. Either search for that file in the Search pane of the **Solution Explorer** or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Character** > **LyraCharacter.h**
1. In `LyraCharacter.h`, go to line 96. You should see the following class: `class LYRAGAME_API ALyraCharacter : public AModularCharacter ...`
1. There are four Blueprint classes that extend this class. You should see a link just above the `ALyraCharacter` class definition that says: `4 derived Blueprint classes`. Click that link to view the four Blueprint classes that extend this class:
    :::image type="content" source="../media/vs-blueprints-link.png" alt-text="Screenshot of the blueprints link above the Alyra Character class. It lists related blueprints." lightbox="../media/vs-blueprints-link.png":::
1. To view the properties of the `Character_Default_C` Blueprint, double-click it to open the Blueprint asset viewer. You can view the various properties of the Blueprint, but you can't change them:
    :::image type="content" source="../media/vs-blueprints-asset-viewer.png" alt-text="Screenshot of the Character_Default_C Blueprint asset viewer. It shows properties such as Actor, Camera, Character, Collision, and so on.":::

## View UE logging within Visual Studio

You can use the Visual Studio Tools for Unreal Engine to view UE logging within Visual Studio. This is useful because you can see UE logging without having to switch between the Unreal Editor and Visual Studio. To try it out, follow these steps:

1. In Visual Studio, open `LyraGameplayAbility_RangedWeapon.cpp`. Either search for that file in the Search pane of the **Solution Explorer** or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Weapons** > **LyraGameplayAbility_RangedWeapon.cpp**
1. In `LyraGameplayAbility_RangedWeapon.cpp`, go to line 477. You should see this function: `void ULyraGameplayAbility_RangedWeapon::OnTargetDataReadyCallback`
1. Insert the following code at the beginning of the function: `UE_LOG(LogLyra, Log, TEXT("shot fired"));` This creates a log entry, associated with the category `LogLyra`, that logs `shot fired` when this function is called.
1. Run the sample game in Visual Studio by choosing **Debug** > **Start Debugging**. The Unreal Editor will open with the Lyra game. Give it a few moments to load.
1. In Visual Studio, open the UE logging window by choosing **View** > **Other Windows** > **Unreal Engine Log** from the Visual Studio main menu.
1. In the Unreal Editor, choose the Play button on the toolbar (or `Alt+p`) to start the game.
1. In the Lyra game, use the `w`, `a`, `s`, `d` keys to navigate the player left to the **Elimination** portal. Position the player over the entry portal to load the game.
1. Once the game is running, click the mouse button to fire. This creates some log entries in the `LogLyra` category. Now `LogLyra` will appear in the Categories filter for the next step.
1. Reduce log noise by filtering all but the `LogLyra` category events in the UE logging window as follows: choose the **Categories** dropdown. Choose **(Select All)** at the top of the list to clear all of the log sources. Then select **LogLyra**. In the UE logging window, you should see the log message: `shot fired`:

    :::image type="content" source="../media/vs-unreal-engine-log.png" alt-text="A screenshot of the Unreal Engine Log window showing 'shot fired' events and the Categories dropdown with LogLyra selected.":::

    The events are at the bottom of the log so you might have to scroll down to see them. You could also choose the **Clear** button to clear the log and then fire again to see the log message.

If you find the font color hard to read, you can adjust it under **Tools** > **Options** > **Environment** > **Fonts and Colors**. Change the dropdown **Show settings for:** to **Unreal Engine Log**. In **Display items:** select **Log** and change the **Item foreground** color to something easier to see for you.

Having the UE logging window open while you're debugging is convenient because you don't have to switch to the Unreal Editor to see them.

## View UE macros in Visual Studio

Long UE macros can be difficult to read. Visual Studio Tools for Unreal Engine expands UE macros so that you can read them more easily. You can copy the expanded macro if you want. You can also search for it online or compare it with another macro. To experiment with these features, follow these steps:

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

For more information about expanding macros in Visual Studio, see [Visualize C/C++ macro expansion](/cpp/ide/visualize-macro-expansion).

This quickstart showed how Visual Studio Tools for Unreal Engine makes it easier to understand UE macros, view UE logging, and view UE Blueprints. May your UE development work be more productive and enjoyable!

## Next steps

See [Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md) for an overview of Visual Studio Tools for Unreal Engine features.
