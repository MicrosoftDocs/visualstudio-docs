---
title: "How to: Set IDE accessibility options"
description: "Learn how to set accessibility options in Visual Studio that will make its integrated development environment (IDE) easier for everyone to use, including for people who have low vision to read and for people who have limited dexterity to write."
ms.date: 08/23/2019
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.topic: conceptual
helpviewer_keywords:
  - "accessibility [Visual Studio]"
ms.assetid: ddc96c4c-0600-46c1-8267-7dce4c44ad24
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Set IDE accessibility options

Visual Studio includes features that make it easier for people who have low vision to read and for people who have limited dexterity to write. For example, you can change the size and color of text in editors, change the size of text and buttons on toolbars, and change settings to help you complete a function or statement.

In addition, Visual Studio supports Dvorak keyboard layouts, which make the most frequently typed characters more accessible. You can also customize the default keyboard shortcuts available with Visual Studio. For more information, see [Identify and customize keyboard shortcuts](../../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md).

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described here, which can vary depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../environment-settings.md#reset-settings).

::: moniker range="vs-2017"

> [!TIP]
> To learn more about recent accessibility updates, see the [Accessibility improvements in Visual Studio 2017 version 15.3](https://devblogs.microsoft.com/visualstudio/accessibility-improvements-in-visual-studio-2017-version-15-3/) blog post.

::: moniker-end

## Editors, dialogs, and tool windows

By default, dialog boxes and tool windows in Visual Studio use the same font size and colors as the operating system. The color settings for the frame of the IDE, dialog boxes, toolbars, and tool windows are based a color scheme: light or dark. You can change the current color theme in the [Options dialog box: Environment > General](../../ide/reference/general-environment-options-dialog-box.md).

You can also display pop-up windows in the Code view of the editor. These windows can prompt you with available members on the current object and the parameters to complete a function or statement. These windows can be helpful if you have difficulty typing. However, they interfere with focus in the code editor, which can be problematic for some users.

Here's how to turn off the pop-up windows:

1. From the **Tools** menu, choose **Options**.

1. Choose **Text Editor** > **All Languages** > **General**.

1. Clear the **Auto list members** and **Parameter information** checkboxes.

You can rearrange the windows in the integrated development environment (IDE) to best suit the way you work. You can dock, float, hide, or automatically hide each tool window. For more information about how to change window layouts, see [Customize window layouts](../../ide/customizing-window-layouts-in-visual-studio.md).

### Change the size of text

You can change the settings for text-based tool windows, such as the **Command** window, **Immediate** window, and **Output** window by using **Tools** > **Options** > **Environment** > **Fonts and Colors**.

When you select **[All Text Tool Windows]** in the **Show settings for** drop-down list, the default setting is listed as **Default** in the **Item foreground** and **Item background** drop-down lists. Choose the **Custom** button to change these settings.

You can also change the settings for how text is displayed in the editor. Here's how.

1. From the **Tools** menu, choose **Options**.

1. Choose **Environment** > **Fonts and Colors**.

1. Select an option on the **Show settings for** drop-down menu.

    To change the font size for text in an editor, choose **Text Editor**.

    To change the font size for text in text-based tool windows, choose **[All Text Tool Windows]**.

    To change the font size for ToolTip text in an editor, choose **Editor Tooltip**.

    To change the font size for text in statement completion pop-ups, choose **Statement Completion**.

1. From **Display items**, select **Plain Text**.

1. In **Font**, select a new font type.

1. In **Size**, select a new font size.

    > [!TIP]
    > To reset the text size for text-based tool windows and editors, choose **Use Defaults**.

7. Choose **OK**.

### Change the colors that are used in the IDE

You can choose to change the default colors for text, margin indicators, white space, and code elements in the editor. Here's how.

1. From the **Tools** menu, choose **Options**.

1. In the **Environment** folder, choose **Fonts and Colors**.

1. In **Show settings for**, choose **Text Editor**.

1. From **Display items**, select an item whose display you need to change, such as **Plain Text**, **Indicator Margin**, **Visible White Space**, **HTML Attribute Name**, or **XML Attribute**.

1. Select display settings from the following options: **Item foreground**, **Item background**, and **Bold**.

1. Choose **OK**.

> [!TIP]
> To use high contrast colors for all application windows on your operating system, press **Left Alt**+**Left Shift**+**PrtScn**. If Visual Studio is open, close and then reopen it to fully implement high contrast colors.

## Toolbars

To improve toolbar usability and accessibility, you can add text to toolbar buttons.

### To assign text to toolbar buttons

1. From the **Tools** menu, choose **Customize**.

1. In the **Customize** dialog box, select the **Commands** tab.

1. Select **Toolbar**, and then choose the toolbar name that contains the button you intend to display text for.

1. In the list, select the command you intend to change.

1. Choose **Modify Selection**.

1. Choose **Image and Text**.

### To modify the displayed text in a button

1. Re-select **Modify Selection**.

1. Adjacent to In **Name**, insert provide a new caption for the selected button.

## See also

* [Accessibility features of Visual Studio](../../ide/reference/accessibility-features-of-visual-studio.md)
* [Accessibility for Visual Studio for Mac](/visualstudio/mac/accessibility/)
* [Resources for designing accessible applications](../../ide/reference/resources-for-designing-accessible-applications.md)
