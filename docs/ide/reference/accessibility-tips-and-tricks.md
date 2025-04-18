---
title: "Accessibility tips and tricks for Visual Studio"
description: Discover tips and tricks that help make the Visual Studio integrated development environment (IDE) more accessible for everyone, including people with disabilities.
ms.date: 02/13/2025
ms.topic: conceptual
helpviewer_keywords:
  - "accessibility [Visual Studio]"
author:anandmeg
ms.author: meghaanand
ms.subservice: general-ide
---
# Accessibility tips and tricks for Visual Studio

Visual Studio has built-in accessibility features that are compatible with screen readers and other assistive technologies. Whether you want to use keyboard shortcuts to navigate the IDE, or use high-contrast themes to improve visibility, you'll find several tips and tricks in this article to improve accessibility.

You can also learn how to use annotations to reveal useful information about your code, and also how to set audio cues for error, breakpoint, or warning events.

## Screen readers

Visual Studio supports screen readers in the IDE. The following screen readers have been tested:

- [NVDA Screen Reader](https://www.nvaccess.org)
- [Job Access With Speech (JAWS)](https://www.freedomscientific.com/products/software/jaws)
- [Narrator](https://support.microsoft.com/help/22798)

## Save your IDE settings

You can customize your IDE experience by saving your window layout, keyboard mapping scheme, and other preferences. For more information, see [Customize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

## Modify your IDE for high-contrast viewing

For some folks, certain colors are more difficult to see. If you want more contrast as you code but don't want to use the typical *High Contrast* themes, we now offer a *Blue (Extra Contrast)* theme.

:::image type="content" source="media/blue-extra-contrast-theme.png" alt-text="Screenshot that shows a comparison of the Blue theme and the Blue Extra Contrast theme.":::

::: moniker range="vs-2022"

> [!TIP]
> To learn about the color contrast ratio adjustments and the new [Cascadia Code](../how-to-change-fonts-and-colors-in-visual-studio.md#use-the-cascadia-code-font) font we've added to make Visual Studio more accessible, see [We've upgraded the UI in Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/weve-upgraded-the-ui-in-visual-studio-2022/).

::: moniker-end

## Use annotations to reveal useful information about your code

The Visual Studio editor includes many text *adornments* that let you know about characteristics and features at particular points on a line of code, such as screwdriver and light bulb icons, error and warning *squiggles*, bookmarks, and so on. You can use the **Show Line Annotations** command set to help you discover and then navigate between these adornments.

:::image type="content" source="media/show-line-annotations-command-set.png" alt-text="Screenshot of the Show Line Annotations menu item.":::

## Access toolbars by using keyboard shortcuts

The Visual Studio IDE has toolbars. The following keyboard shortcuts help you access them.

|Feature|Description|Keyboard shortcut|
|-------------|-----------------| - |
|IDE toolbars|Select the first button on the Standard toolbar.|**Alt**, **Ctrl**+**Tab**|
|Tool window toolbars|Move focus to the toolbars in a tool window. <br> <br> **NOTE:** This works for most tool windows, but only when the focus is in a tool window. Also, you must choose the **SHIFT** key before the **ALT** key. In some tool windows, such as Team Explorer, you must hold the **SHIFT** key for a moment before choosing the **ALT** key.|**Shift**+**Alt**|
|Toolbars|Go to the first item in the next toolbar (when a toolbar has focus).|**Ctrl**+**Tab**|

## Git keyboard shortcuts

The Visual Studio status bar shows popup controls for quick access to various Git features. The following keyboard shortcuts help you access them.

|Feature|Description|Keyboard shortcut|
|-------------|-----------------| - |
|Branch picker|View, manage, and checkout branches in an active Git repository.|**Ctrl**+**Alt**+**F3**|
|Repository picker|View, manage, and open Git repositories known to Visual Studio.|**Ctrl**+**Alt**+**F4**|

## Other useful keyboard shortcuts

Some other useful keyboard shortcuts include the following.

|Feature|Description|Keyboard shortcut|
|-------------|-----------------| - |
|IDE|Switch *High Contrast* on and off. <br> <br> **NOTE:** Standard Windows keyboard shortcut|**Left Alt**+**Left Shift**+**PrtScn**|
|Dialog box|Select or clear the check box option in a dialog box. <br> <br> **NOTE:** Standard Windows keyboard shortcut|**Spacebar**|
|Context menus|Open a context (right-click) menu. <br> <br> **NOTE:** Standard Windows keyboard shortcut|**Shift**+**F10**|
|Menus|Quickly access a menu item by using its accelerator keys. Choose the **Alt** key followed by the underlined letters in a menu to activate the command. For example, to view the **Open Project** dialog box in Visual Studio, you would choose **Alt**+**F**+**O**+**P**.  <br><br> **NOTE:** Standard Windows keyboard shortcut|**Alt** + **[letter]**|
|Search box|Use the search feature in Visual Studio.|**Ctrl**+**Q**|
|Toolbox window|Move between Toolbox tabs.|**Ctrl**+**Up arrow**<br><br> and<br><br> **Ctrl**+**Down arrow**|
|Toolbox window|Add a control from the Toolbox to a form or designer.|**Enter**|
|Options dialog box: Environment > Keyboard|Delete a key combination entered in the **Press shortcut keys** option.|**Backspace**|
|Notifications tool window|Open the Notifications tool window by using two keyboard shortcut key combinations, one followed by the other. Then, view a  notification by using the arrow keys to select it.| **Ctrl**+**&#92;**, **Ctrl**+**N**|
|Data grids|Open filters in data grid column headers, such as in the references tool window.|**Ctrl**+**[arrow keys]**|

For a complete list, see [Keyboard shortcuts in Visual Studio](../default-keyboard-shortcuts-in-visual-studio.md).

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help, depending on your active settings or edition.

## Access notifications by using keyboard shortcuts

When a notification appears in the IDE, here's how you can access the Notifications window by using keyboard shortcuts:

1. From anywhere in the IDE, press the following two keyboard shortcuts in sequence, one after the other: **Ctrl**+**&#92;** and then **Ctrl**+**N**.

   The **Notifications** window opens.

   :::image type="content" source="media/toast-notification.png" alt-text="Screenshot of the Notifications window in the Visual Studio IDE.":::

1. Use either the **Tab** key or the arrow keys to select a notification.

## Assign audio cues to Visual Studio program events

::: moniker range="vs-2022"

Starting with [version 17.3](/visualstudio/releases/2022/release-notes-v17.3) and continuing in [version 17.4](/visualstudio/releases/2022/release-notes-v17.4) & later, you can add audio cues for program events directly within Visual Studio. Specifically, you can toggle a setting so that Visual Studio plays an audio cue when the caret in the editor arrives on a line with an error, breakpoint, or warning. When you view a file in the *Diff* view, Visual Studio can also play an audio cue when the caret arrives on a line that's been added or removed.

To add the audio cue functionality, go to **Tools** > **Options** > **Text Editor** > **General** and select the **Enable audio cues** setting.

> [!TIP]
> To learn more about the journey to add audio cues within Visual Studio, see [Listen Up, Visual Studio has a new feature you need to hear about!](https://devblogs.microsoft.com/visualstudio/audio-cues-in-visual-studio-2022-17-3-preview-2/).

::: moniker-end

In Visual Studio 2022 version 17.2 and earlier, you can use the Sound Control Panel in Windows to assign audio cues to Visual Studio program events. Specifically, you can assign audio cues to the following program events:

* Breakpoint hit
* Build canceled
* Build failed
* Build succeeded

Here's how to add audio cues to program events by using either Windows 11 or Windows 10.

### Add audio cues in Windows 11

1. Select the Start button on a computer running Windows 11, and then in the **Search** box, type **Change system sounds**.

    :::image type="content" source="media/change-system-sounds-windows-11.png" alt-text="Screenshot of the Search box in Windows 11.":::

1. From the search results, select the Control Panel option for **Change system sounds**. (Alternatively, select the **Open** icon in the right panel of the search results.)

    :::image type="content" source="media/select-change-system-sounds-windows-11.png" alt-text="Screenshot of the 'Change system sounds' search results in Windows 11.":::

1. In the **Sound** dialog box, select the **Sounds** tab.

1. In **Program Events**, scroll to **Microsoft Visual Studio**, and then select the sounds that you want to apply to the events that you choose.

    :::image type="content" source="media/system-sounds-dialog-windows-11.png" alt-text="Screenshot of the Sounds tab of the Sound dialog box in Windows 11.":::

1. Select **OK**.

### Add audio cues in Windows 10

1. In the **Search** box on a computer running Windows 10, type **Change system sounds**.

   :::image type="content" source="media/type-here-to-search.png" alt-text="Screenshot of the Search box in Windows 10.":::

   Alternatively, if you have Cortana enabled, say "Hey Cortana", and then say "Change system sounds".

1. Double-click **Change system sounds**.

   :::image type="content" source="media/change-system-sounds.png" alt-text="Screenshot of the 'Change system sounds' search results in Windows 10.":::

1. In the **Sound** dialog box, select the **Sounds** tab.

1. In **Program Events**, scroll to **Microsoft Visual Studio**, and then select the sounds that you want to apply to the events that you choose.

   :::image type="content" source="media/sound-applet.png" alt-text="Screenshot of the Sounds tab of the Sound dialog box in Windows 10.":::

1. Select **OK**.

## Related content

* [Set accessibility options](../how-to-change-fonts-and-colors-in-visual-studio.md#set-accessibility-options)
* [Customize menus and toolbars in Visual Studio](../../ide/how-to-customize-menus-and-toolbars-in-visual-studio.md)
* [Customize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)
* [Microsoft Accessibility](https://www.microsoft.com/Accessibility)
