---
title: General, Environment, Options Dialog Box
ms.date: 07/26/2019
ms.topic: reference
f1_keywords:
  - "VS.Environment.General"
  - "VS.Message.0x800a002e"
  - "VS.OptionsDialog.Environment"
  - "VS.ToolsOptionsPages.Environment"
  - "VS.ToolsOptionsPages.Environment.General"
helpviewer_keywords:
  - "recently used file lists"
  - "Windows menu, customizing"
  - "status bar, displaying"
  - "Options dialog box, General Environment"
  - "General Environment Options dialog box"
  - "Environment Options dialog box"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Options dialog box: Environment \> General

Use this page to change color themes, status bar settings, and file extension associations, among other options, for the integrated development environment (IDE). You can access the **Options** dialog box by opening the **Tools** menu, choosing **Options**, opening the **Environment** folder and then choosing the **General** page. If this page does not appear in the list, select the **Show all settings** check box in the **Options** dialog box.

## Visual Experience

**Color Theme**

Choose the **Blue**, **Light**, **Dark**, or **Blue (Extra Contrast)** color theme for the IDE.

You can install additional predefined themes and create custom themes by downloading and installing the **Visual Studio Color Theme Editor** from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.VisualStudio2017ColorThemeEditor). After you install this tool, additional color themes appear in the **Color Theme** list box.

**Apply title case styling to menu bar**

Menus use title case styling by default. Uncheck this option to use all uppercase styling instead.

::: moniker range=">=vs-2019"

**Optimize rendering for screens with different pixel densities (requires restart)**

This option enables or disables per-monitor dots per inch (DPI) awareness (or *PMA*). When PMA is enabled, the Visual Studio user interface appears crisp in any monitor display scale factor and DPI configuration, including across multiple monitors. To enable PMA, you need Windows 10 April 2018 Update or later and .NET Framework 4.8 or later. (This option appears greyed out if those two prerequisites are not met.)

> [!TIP]
> - Windows 10 has a setting that says **Let Windows try to fix apps so they're not blurry**. Turning that Windows setting **on** has negligible effect if you have the **Optimize rendering for screens with different pixel densities** option checked.
> - Windows 10 also includes a **Program Compatibility Troubleshooter**. We don't recommend trying to fix the appearance of Visual Studio by using that troubleshooter.

::: moniker-end

**Automatically adjust visual experience based on client performance**

Specifies whether Visual Studio sets the adjustment to the visual experience automatically or you set the adjustment explicitly. This adjustment may change the display of colors from gradients to flat colors, or it may restrict the use of animations in menus or popup windows.

::: moniker range="vs-2017"

> [!TIP]
> Windows 10 has a setting that says **Let Windows try to fix apps so they're not blurry**. Turning that setting **on** is recommended if Visual Studio appears blurry on your monitor. Consider upgrading to [Visual Studio 2019](https://visualstudio.microsoft.com/downloads), which has significantly improved display clarity because it is a per-monitor dots per inch aware application.

::: moniker-end

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

## See also

- [Customize window layouts](../../ide/customizing-window-layouts-in-visual-studio.md)