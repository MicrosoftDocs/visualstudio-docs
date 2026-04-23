---
title: Configure Visual Experience Options
description: Configure Visual Experience settings in the Environment section of the Tools Options pane. Change color themes, configure menu appearance, and acceleration options for the Visual Studio IDE.
ms.date: 02/04/2026
ms.topic: how-to
ai-usage: ai-assisted
f1_keywords:
- VS.Environment.VisualExperience
# - VS.Message.0x800a002e
- VS.OptionsPages.AllSettings.Environment
- VS.ToolsOptionsPages.AllSettings.Environment
- VS.ToolsOptionsPages.AllSettings.Environment.VisualExperience
helpviewer_keywords:
- recently used file lists
- Windows menu, customizing
- status bar, displaying
- Options pane, Visual Experience, Environment
- Visual Experience Environment Options pane
- Visual Experience Options pane
ms.custom: "awp, ide-ref"
author: GitHubber17
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
monikerRange: 'visualstudio'
---

# Configure Environment \> Visual Experience options

This article describes how to set the color theme, menu appearance, acceleration options, and more for the integrated development environment (IDE). You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **All Settings** > **Environment** > **Visual Experience** section. 

To configure general **Environment** settings, see [Options dialog box: Environment > General](./reference/general-environment-options-dialog-box.md)

## Visual Experience settings

The **Visual Experience** section provides the following general configuration options.

**Color theme**

Change the color theme between Dark, Light, and other colors, or select **Use system setting** to use the current Windows theme. Visual Studio includes color themes such as Cool Breeze, Spicy Red, Bubblegum, and more. For a visual preview of all available themes, see [Visual Studio color themes](visual-studio-color-themes.md). 

You can download and install predefined themes and custom themes on the [**Visual Studio Marketplace**](https://marketplace.visualstudio.com/search?target=VS&category=Tools&vsVersion=&subCategory=Themes&sortBy=Installs), such as:

- [Color Themes for Visual Studio](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.ColorThemesforVisualStudio)
- [Visual Studio Theme Pack](https://marketplace.visualstudio.com/items?itemName=idex.vsthemepack)

To see examples of custom themes based on Visual Studio Code, see the [**Introducing a collection of new Visual Studio themes**](https://devblogs.microsoft.com/visualstudio/custom-themes/) blog post.

After you install more colors or themes, the extra colors appear in the **Color theme** list.

**Editor Appearance**

Specify which theme to use in the Visual Studio Code editor. 

If you want to use the same theme as the **Color theme** option, select **Match Theme**. You can also choose between **Light**, **Dark**, and high contrast versions of those settings.

**Separate font settings from color theme selection**

When you select this option, your **Color theme** and **Editor Appearance** settings don't affect your font settings (**All Settings** > **Environment** > **Fonts and Colors**). Your font settings are saved independently.

**Use Windows High Contrast settings**

By default, Visual Studio uses the [Windows High Contrast](/windows/compatibility/high-contrast-mode/) settings. If you change this option, you must restart your computer.

**Apply title case styling to menu bar**

The menu labels in Visual Studio are presented in title case styling by default, such as **File** and **Help**. If you prefer to see the labels in all uppercase (**FILE**), select this option.

**Use compact menu and search bar**

By default, Visual Studio combines the top menu bar and search bar into a single widget, which increases the available vertical space in the IDE. If you prefer separate widgets, select this option. When you change the option, you must restart your computer.

**Use compact spacing in Solution Explorer**

By default, Visual Studio uses wider spacing between items in Solution Explorer to enhance accessibility and reduce the chance of misclicks when using a mouse. If you prefer a more compact view to see more items at once, select this option to reduce the item spacing. Changes take effect immediately without restarting Visual Studio.

**Optimize rendering for screens with different pixel densities**

This option enables or disables per-monitor dots per inch (DPI) awareness (or *PMA*). When PMA is enabled, the Visual Studio user interface appears crisp in any monitor display scale factor and DPI configuration, including across multiple monitors. To enable PMA, you need Windows 10 April 2018 Update or later and .NET Framework 4.8 or later. (If the prerequisites aren't satisfied, the options aren't available in the UI.) If you change this option, you must restart your computer.

> [!NOTE]
> - In Windows 10, if the **Let Windows try to fix apps so they're not blurry** setting is enabled, and you select this optimization setting, there's negligible effect. 
> - Windows 10 includes the **Program Compatibility Troubleshooter**. Attempting to fix the appearance of Visual Studio by using the troubleshooter isn't recommended.
> The Windows 10 setting and troubleshooting tool aren't available in [Windows 11](/windows/whats-new/windows-11-overview).

**Hide Copilot Badge**

By default, Visual Studio includes a badge icon for Microsoft Copilot on the main menu bar. When you select the icon, the Copilot pane opens. If you prefer not to include Copilot on the menu bar, select this option. If you change this option, you must restart your computer.

## Effects settings

The **Effects** section provides the following options for configuring the visual experience.

**Use hardware graphics acceleration**

This option lets you choose to use hardware graphics acceleration (when available) rather than software acceleration. There are three settings:

- **Automatic** (Enable only when recommended)
- **Prefer** (Enable when possible)
- **Never**

**Enable rich client visual experience**

Enables the full visual experience of Visual Studio, including gradients and animations. Clear this option when you're using Remote Desktop connections or older graphics adapters. These features might yield poor performance when attempting to support the full visual experience. 

- **Automatic** (Enable only when recommended)
- **Always**
- **Never**

## Related content

- [Configure related settings for earlier versions of Visual Studio](./reference/general-environment-options-dialog-box.md)
- [Customize window layouts and personalize tabs](customizing-window-layouts-in-visual-studio.md)
