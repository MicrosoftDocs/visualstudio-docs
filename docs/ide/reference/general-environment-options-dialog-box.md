---
title: General, Environment, Options Dialog Box
description: Learn how to use the General page in the Environment section to change color themes, status bar settings, file extension associations, and more for the IDE.
ms.date: 01/10/2023
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

Use this page to change color themes, status bar settings, and file extension associations, among other options, for the integrated development environment (IDE). You can access the **Options** dialog box by opening the **Tools** menu, choosing **Options**, opening the **Environment** folder and then choosing the **General** page.

## Visual Experience

**Color Theme**

Choose the **Blue**, **Blue (Extra Contrast)**, **Dark**, or **Light** color theme for the IDE.

::: moniker range=">=vs-2022"

You can also choose to use the theme that Windows uses by selecting **Use system setting**.

::: moniker-end

You can install additional predefined themes and create custom themes by downloading and installing the **Visual Studio Color Theme Designer** for the version that you're currently using, as follows:

- [Color Theme Designer for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=idex.colorthemedesigner2022)
- [Color Theme Designer for Visual Studio 2019](https://marketplace.visualstudio.com/items?itemName=ms-madsk.ColorThemeDesigner).
- [Color Theme Editor for Visual Studio 2017](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.VisualStudio2017ColorThemeEditor)

After you install this tool, additional color themes appear in the **Color Theme** list box.

::: moniker range=">=vs-2022"

> [!NOTE]
> Want even more themes to choose from? Check out the wide range of custom themes on the [**Visual Studio Marketplace**](https://marketplace.visualstudio.com/search?target=VS&category=Tools&vsVersion=&subCategory=Themes&sortBy=Installs). And to see examples of new Visual Studio 2022 custom themes based on VS Code, take a look at the [**Introducing a collection of new Visual Studio themes**](https://devblogs.microsoft.com/visualstudio/custom-themes/) blog post.

**Use Windows High Contrast settings**

By default, Visual Studio uses the [Windows High Contrast](/windows/compatibility/high-contrast-mode/) settings. You can toggle this off but you must then restart your computer.

::: moniker-end

**Apply title case styling to menu bar**

Menus use title case styling by default. Uncheck this option to use all uppercase styling instead.

**Optimize rendering for screens with different pixel densities (requires restart)**

This option enables or disables per-monitor dots per inch (DPI) awareness (or *PMA*). When PMA is enabled, the Visual Studio user interface appears crisp in any monitor display scale factor and DPI configuration, including across multiple monitors. To enable PMA, you need Windows 10 April 2018 Update or later and .NET Framework 4.8 or later. (This option appears greyed out if those two prerequisites are not met.)

> [!TIP]
> - Windows 10 has a setting that says **Let Windows try to fix apps so they're not blurry**. Turning that Windows setting **on** has negligible effect if you have the **Optimize rendering for screens with different pixel densities** option checked. (This setting is not available in Windows 11. For more information about Windows 11, see [Windows 11 overview](/windows/whats-new/windows-11-overview).)
> - Windows 10 also includes a **Program Compatibility Troubleshooter**. We don't recommend trying to fix the appearance of Visual Studio by using that troubleshooter. (This feature is not available in Windows 11. For more information about Windows 11, see [Windows 11 overview](/windows/whats-new/windows-11-overview).)

**Automatically adjust visual experience based on client performance**

Specifies whether Visual Studio sets the adjustment to the visual experience automatically or you set the adjustment explicitly. This adjustment may change the display of colors from gradients to flat colors, or it may restrict the use of animations in menus or popup windows.

**Enable rich client experience**

Enables the full visual experience of Visual Studio, including gradients and animations. Clear this option when using Remote Desktop connections or older graphics adapters, because these features may have poor performance in those cases. This option is available only when you clear the **Automatically adjust visual experience based on client** option.

**Use hardware graphics acceleration if available**

Uses hardware graphics acceleration if it is available, rather than software acceleration.

## Other

**Items to show in Window menu**

Customizes the number of windows that appear in the Windows list of the **Window** menu. Enter a number between 1 and 24. The default value is 10.

**Items shown in recently used lists**

Customizes the number of most recently used projects and files that appear on the **File** menu. Enter a number between 1 and 24. The default value is 10. This is an easy way to retrieve recently used projects and files.

**Show status bar**

Displays the status bar. The status bar is located at the bottom of the IDE window and displays information about the progress of ongoing operations.

**Close button affects active tool window only**

Specifies that when the **Close** button is clicked, only the tool window that has focus is closed and not all of the tool windows in the docked set. By default, this option is selected.

**Auto Hide button affects active tool window only**

Specifies that when the **Auto Hide** button is clicked, only the tool window that has focus is hidden automatically and not all of the tool windows in the docked set. By default, this option is not selected.

::: moniker range=">=vs-2022"

**On startup, open**

Customizes a different default action when Visual Studio starts up. In the **On startup, open** list, choose from **Start window** (which lets you open a new or existing project), **Most recent solution**, or **Empty environment**.

::: moniker-end

## See also

- [Customize window layouts and personalize tabs](../../ide/customizing-window-layouts-in-visual-studio.md)
