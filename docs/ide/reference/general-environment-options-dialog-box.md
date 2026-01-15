---
title: General, Environment, Options Dialog Box
description: Learn how to use the General page in the Environment section to change color themes, status bar settings, file extension associations, and more for the IDE.
ms.date: 12/16/2025
ms.topic: reference
f1_keywords:
- VS.Environment.General
- VS.Message.0x800a002e
- VS.OptionsDialog.Environment
- VS.ToolsOptionsPages.Environment
- VS.ToolsOptionsPages.Environment.General
helpviewer_keywords:
- recently used file lists
- Windows menu, customizing
- status bar, displaying
- Options dialog box, General Environment
- General Environment Options dialog box
- Environment Options dialog box
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options dialog box: Environment \> General

::: moniker range="visualstudio"

Use this section to configure the integrated development environment (IDE), including the status bar, **Close** and **Auto Hide** actions, and Visual Studio start up behavior. You can access these settings by selecting **Tools** > **Options** from the main menu bar and expanding the **All Settings** > **Environment** > **General** section.

To configure related **Environment** settings, see [Configure Environment > Visual Experience options](../configure-visual-experience-options.md).

::: moniker-end
::: moniker range="<=vs-2022"

Use this page to configure the integrated development environment (IDE), including the color theme, status bar, **Close** and **Auto Hide** actions, and Visual Studio start up behavior. You can access these settings by selecting **Tools** > **Options** from the main menu bar and expanding the **Environment** > **General** section. 

## Visual Experience settings

The following **General** options are available for the **Visual Experience**.

**Color Theme**

Choose the **Blue**, **Blue (Extra Contrast)**, **Dark**, or **Light** color theme for the IDE or select **Use system setting** to use the current Windows theme.

You can install predefined themes and create custom themes by downloading and installing the **Visual Studio Color Theme Designer** for the version you're currently using, as follows:

- [Color Theme Designer for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=idex.colorthemedesigner2022)
- [Color Theme Designer for Visual Studio 2019](https://marketplace.visualstudio.com/items?itemName=ms-madsk.ColorThemeDesigner).
- [Color Theme Editor for Visual Studio 2017](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.VisualStudio2017ColorThemeEditor)

After you install more colors or themes, the extra colors appear in the **Color theme** list.

::: moniker-end
::: moniker range="vs-2022"

> [!NOTE]
> Want even more themes to choose from? Check out the wide range of custom themes on the [**Visual Studio Marketplace**](https://marketplace.visualstudio.com/search?target=VS&category=Tools&vsVersion=&subCategory=Themes&sortBy=Installs). To see examples of new Visual Studio 2022 custom themes based on Visual Studio Code, see the [**Introducing a collection of new Visual Studio themes**](https://devblogs.microsoft.com/visualstudio/custom-themes/) blog post.

**Separate font settings from color theme selection**

When you select this option, your **Color Theme** setting doesn't affect your font settings (**Environment** > **Fonts and Colors**). Your font settings are saved independently.

**Use Windows High Contrast settings**

By default, Visual Studio uses the [Windows High Contrast](/windows/compatibility/high-contrast-mode/) settings. You can toggle this off but you must then restart your computer.

**Apply title case styling to menu bar**

The menu labels in Visual Studio are presented in title case styling by default, such as **File** and **Help**. If you prefer to see the labels in all uppercase (**FILE**), select this option.

**Use compact menu and search bar**

By default, Visual Studio combines the top menu bar and search bar into a single widget, which increases the available vertical space in the IDE. If you prefer separate widgets, select this option. When you change the option, you must restart your computer.

**Hide Copilot menu badge**

By default, Visual Studio includes a badge icon for Microsoft Copilot on the main menu bar. When you select the icon, the Copilot pane opens. If you prefer not to include Copilot on the menu bar, select this option. If you change this option, you must restart your computer.

::: moniker-end
::: moniker range="<=vs-2022"

**Optimize rendering for screens with different pixel densities (requires restart)**

This option enables or disables per-monitor dots per inch (DPI) awareness (or *PMA*). When PMA is enabled, the Visual Studio user interface appears crisp in any monitor display scale factor and DPI configuration, including across multiple monitors. To enable PMA, you need Windows 10 April 2018 Update or later and .NET Framework 4.8 or later. (If the prerequisites aren't satisfied, the options aren't available in the UI.) If you change this option, you must restart your computer.

> [!NOTE]
> - In Windows 10, if the **Let Windows try to fix apps so they're not blurry** setting is enabled, and you select this optimization setting, there's negligible effect. 
> - Windows 10 includes the **Program Compatibility Troubleshooter**. Attempting to fix the appearance of Visual Studio by using the troubleshooter isn't recommended.
> The Windows 10 setting and troubleshooting tool aren't available in [Windows 11](/windows/whats-new/windows-11-overview).

**Automatically adjust visual experience based on client performance**

Specifies whether Visual Studio sets the adjustment to the visual experience automatically or you set the adjustment explicitly. This adjustment can change the display of colors from gradients to flat colors, or restrict the use of animations in menus or popup windows.

**Enable rich client experience**

Enables the full visual experience of Visual Studio, including gradients and animations. Clear this option when you're using Remote Desktop connections or older graphics adapters. These features might yield poor performance when attempting to support the full visual experience. This option is available only when the **Automatically adjust visual experience based on client performance** option isn't selected.

**Use hardware graphics acceleration if available**

Uses hardware graphics acceleration if it's available, rather than software acceleration.

## Other settings

The following options are available for the Visual Studio **Environment**.

::: moniker-end
::: moniker range="visualstudio"

## General settings

The following **General** options are available for the Visual Studio **Environment**.

::: moniker-end

**Items to show in Window menu**

Customizes the number of windows that appear in the Windows list of the **Window** menu. Enter a number between 1 and 24. The default value is 10.

**Items shown in recently used file lists**

Customizes the number of most recently used projects and files that appear on the **File** menu. Enter a number between 1 and 24. The default value is 10. This is an easy way to retrieve recently used projects and files.

**Show status bar**

Displays the status bar. The status bar is located at the bottom of the IDE window and displays information about the progress of ongoing operations. If you change this option, you must restart your computer.

**Close button affects active tool window only**

Specifies that when you select the **Close** button, only the tool window that has focus is closed and not all tool windows in the docked set. By default, this option is selected.

**Auto Hide button affects active tool window only**

Specifies that when you select the **Auto Hide** button, only the tool window that has focus is hidden automatically and not all tool windows in the docked set. By default, this option isn't selected.

::: moniker range=">=vs-2022"

**On startup, open**

Customizes a different default action when Visual Studio launches. In the **On startup, open** list, choose from **Start window** (which lets you open a new or existing project), **Most recent solution**, or **Empty environment**.

::: moniker-end

## Related content

- [Configure related settings for Visual Studio 2026](../configure-visual-experience-options.md)
- [Customize window layouts and personalize tabs](../customizing-window-layouts-in-visual-studio.md)
