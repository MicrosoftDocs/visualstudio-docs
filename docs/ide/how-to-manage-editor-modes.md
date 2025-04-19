---
title: Full screen and virtual space mode
description: Learn how to manage the Visual Studio editor modes to display all of the tools and windows in a way that works best for you.
ms.date: 10/03/2024
ms.topic: how-to
helpviewer_keywords:
- word wrap
- views, virtual space
- line numbers, displaying
- virtual space mode
- line numbers
- Code Editor, view and display options
- full screen mode
- Code Editor, modes
- views, splitting
- views, word wrapping
- fonts and size
- views, creating new windows
- views, line numbers
- views, changing mode
- views, outlining
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Manage editor modes

With Visual Studio, you can view the code editor in various display modes.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in this article depending on your active settings or edition. To change your settings, for example to **General** or **Visual C++** settings, select **Tools** > **Import and Export Settings**, and then select **Reset all settings**.

The keyboard shortcuts in Visual Studio may vary depending on your keyboard layout and language settings. You can [identify the keyboard shortcut for a command](identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md#identify-a-keyboard-shortcut) or [customize your keyboard shortcut](identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md#customize-a-keyboard-shortcut). See the [Dev Community ticket](https://developercommunity.visualstudio.com/t/Issue-with-New-Ctrl---Comment-Shortc/10725157?q=keyboard+language&ftype=idea&stateGroup=active) related to this issue for more information.

## Enable full screen mode

You can choose to hide all tool windows and view only document windows by enabling **Full Screen** mode.

- Press **Shift**+**Alt**+**Enter** to enter or exit **Full Screen** mode.

     -- or --

- Issue the command `View.Fullscreen` in the **Command** window.

To view or change this option, go to **Tools** > **Options** > **Environment** > **Keyboard** and then enter 'View.FullScreen' in the **Show commands containing** section.

:::image type="content" source="media/tools-options-environment-keyboard-view-fullscreen.png" alt-text="Screenshot of the View.FullScreen command from the keyboard mapping scheme available from the Options dialog.":::

To learn more about keyboard shortcuts and their associated commands, see [Keyboard shortcuts in Visual Studio](default-keyboard-shortcuts-in-visual-studio.md).

## Enable virtual space mode

In **Virtual Space** mode, spaces are inserted at the end of each line of code. Select this option to position comments at a consistent point next to your code.

1. Select **Options** from the **Tools** menu.

2. Expand the **Text Editor** folder, and select **All Languages** to set this option globally, or select a specific language folder. For example, to turn on line numbers only in Visual Basic, select the **Basic** > **Text Editor** node.

3. Select **General** options, and under **Settings**, select **Enable Virtual Space**.

    > [!NOTE]
    > **Virtual Space** is enabled in **Column Selection** mode. When **Virtual Space** mode is not enabled, the insertion point moves from the end of one line directly to the first character of the next.

## Related content

- [Customize window layouts and personalize tabs](../ide/customizing-window-layouts-in-visual-studio.md)
- [Fonts and Colors, Environment, Options dialog box](../ide/reference/fonts-and-colors-environment-options-dialog-box.md)
