---
title: "View Unreal Engine logging in Visual Studio"
description: "Learn how to view Unreal Engine logs from within Visual Studio"
ms.date: 03/13/2025
ms.topic: how-to
ms.service: visual-studio
ms.subservice: unreal-engine-tools
author: TylerMSFT
ms.author: TWhitney
manager: Coxford
#customer intent: As a C++ game developer using Unreal Engine and Visual Studio, I want to view Unreal Engine logging in Visual Studio so that I can see the logs without switching between the Unreal Editor and Visual Studio.
---

# View Unreal Engine logging in Visual Studio

Use the Visual Studio Tools for Unreal Engine (UE) to see UE logging within Visual Studio. This is useful because you can see UE logging without having to switch between the Unreal Editor and Visual Studio.

## Prerequisites

The following must be installed:

- Visual Studio version 17.10 or later.
- Unreal Engine version 5 or later.
- Visual Studio Tools for Unreal Engine. See [Install Visual Studio Tools for Unreal Engine](vs-tools-unreal-install.md) for installation instructions.
- Complete the [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game and configure it to use Visual Studio Tools for Unreal Engine.

## Add Unreal Engine logging to a sample and see the results in Visual Studio

After completing the [Quickstart: Visual Studio Tools for Unreal Engine](vs-tools-unreal-quickstart.md) to download and build the Lyra game, follow these steps to add Unreal Engine logging to the Lyra game sample and see the log messages in Visual Studio:

1. In Visual Studio, open `LyraGameplayAbility_RangedWeapon.cpp`. Either search for that file in the Search pane of the **Solution Explorer**, or find it under **Games** > **LyraStarterGame** > **Source** > **LyraGame** > **Weapons** > **LyraGameplayAbility_RangedWeapon.cpp**.
1. In `LyraGameplayAbility_RangedWeapon.cpp`, go to line 477. You should see this function: `void ULyraGameplayAbility_RangedWeapon::OnTargetDataReadyCallback`
1. Insert the following code at the beginning of the function: `UE_LOG(LogLyra, Log, TEXT("shot fired"));` This creates a log entry, associated with the category `LogLyra`, that logs `shot fired` when this function is called.
1. Run the sample game in Visual Studio by choosing **Debug** > **Start Debugging**. Give the Unreal Editor a few moments to load the Lyra game.
1. In Visual Studio, open the UE logging window by choosing **View** > **Other Windows** > **Unreal Engine Log** from the Visual Studio main menu. Or use the UE toolbar button to show the log. For more information about the toolbar, see [Unreal Engine toolbar](vs-tools-unreal-quickstart.md#unreal-engine-toolbar).
1. In the Unreal Editor, choose the Play button on the toolbar (or `Alt+p`) to start the game.
1. In the Lyra game, use the `w`, `a`, `s`, `d` keys to navigate the player left to the **Elimination** portal. Position the player over the entry portal to load the game.
1. Once the game is running, click the mouse button to fire. This creates some log entries in the `LogLyra` category. Now `LogLyra` will appear in the Categories filter for the next step.
1. Reduce log noise by filtering all but the `LogLyra` category events in the UE logging window as follows: choose the **Categories** dropdown. Choose **(Select All)** at the top of the list to clear all of the log sources. Then select **LogLyra**. In the UE logging window, you should see the log message: `shot fired`:

    :::image type="content" source="../media/vs-unreal-engine-log.png" alt-text="A screenshot of the Unreal Engine Log window showing 'shot fired' events and the Categories dropdown with LogLyra selected.":::

    The events are at the bottom of the log so you might have to scroll down to see them. You could also choose the **Clear** button to clear the log and then fire again to see the log message.

If you find the font color hard to read, you can adjust it under **Tools** > **Options** > **Environment** > **Fonts and Colors**. Change the dropdown **Show settings for:** to **Unreal Engine Log**. In **Display items:** select **Log** and change the **Item foreground** color to something easier to see for you.

Having the UE logging window open while you're debugging is convenient because you don't have to switch to the Unreal Editor to see them.

## Unreal Engine logging options

Starting with Visual Studio 2022 17.12, you can configure the Unreal Engine logging window. Choose **Tools** > **Options** > **Unreal Engine** > **Log Tool Window** to see the following options:

:::image type="content" source="../media/vs-unreal-engine-log-options.png" alt-text="A screenshot of the Unreal Engine Log window options.":::

- **Remember filters**: Remember the filters you set in the log window when you close Visual Studio.
- **Clear on Launch**: Clear the log window when the game is launched.
- **Request JSON messages**: Request that log entries in JSON format. JSON provides a structured format that is easy to parse and process programmatically. This makes it simpler to extract specific information from log messages, such as error details, timestamps, and other metadata.
- **Show automatically**: Show the log window automatically when the game is launched in Visual Studio.

## Related content

[Visual Studio Tools for Unreal Engine](./vs-tools-unreal-overview.md)\
[Add Unreal Engine classes, modules, and plugins in Visual Studio](vs-tools-unreal-add-class-module-plugin.md)\
[View Unreal Engine Blueprints in Visual Studio](vs-tools-unreal-view-blueprints.md)\
[View Unreal Engine logging in Visual Studio](vs-tools-unreal-logging.md)\
[View Unreal Engine macros in Visual Studio](vs-tools-unreal-view-macros.md)