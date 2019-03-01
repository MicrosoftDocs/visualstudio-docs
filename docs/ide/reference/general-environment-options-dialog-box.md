---
title: General, Environment, Options Dialog Box
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "VS.Message.0x800a002e"
  - "VS.ToolsOptionsPages.Environment.General"
  - "VS.Environment.General"
helpviewer_keywords:
  - "MRU lists"
  - "windows, customizing"
  - "MDI, environment options"
  - "speed, environment animation"
  - "File menu"
  - "menus, customizing"
  - "Windows menu customizing"
  - "status bars, displaying"
  - "IDE, startup options"
  - "editors, autocompletion"
  - "Options dialog box, General Environment"
  - "General Environment Options dialog box"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# General, Environment, Options Dialog Box

Use this page to change color themes, status bar settings, and file extension associations, among other options, for the integrated development environment (IDE). You can access the **Options** dialog box by opening the **Tools** menu, choosing **Options**, opening the **Environment** folder and then choosing the **General** page. If this page does not appear in the list, select the **Show all settings** check box in the **Options** dialog box.

## Visual Experience

**Color theme**

Choose the **Blue**, **Light** or **Dark** color theme for the IDE.

You can install additional predefined themes, and create custom themes, by downloading and installing the **Visual Studio Color Theme Editor** from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.VisualStudio2017ColorThemeEditor). After you install this tool, additional color themes appear in the Color theme list box.

**Apply title casing in menu bar**

Menus are in **Title Casing** by default. Un-check this option to set them to **ALL CAPS**.

**Automatically adjust visual experience based on client performance**

Specifies whether Visual Studio sets the adjustment to the visual experience automatically or you set the adjustment explicitly. This adjustment may change the display of colors from gradients to flat colors, or it may restrict the use of animations in menus or popup windows.

**Enable rich client experience**

Enables the full visual experience of Visual Studio, including gradients and animations. Clear this option when using Remote Desktop connections or older graphics adapters, because these features may have poor performance in those cases. This option is available only when you clear the **Automatically adjust visual experience based on client** option.

**Use hardware graphics acceleration if available**

Uses hardware graphics acceleration if it is available, rather than software acceleration.

## Other

**Items shown in Window menu**

Customizes the number of windows that appear in the Windows list of the **Window** menu. Type a number between 1 and 24. By default, the number is 10.

**Items shown in recently used lists**

Customizes the number of most recently used projects and files that appear on the **File** menu. Type a number between 1 and 24. By default, the number is 10. This is an easy way to retrieve recently used projects and files.

**Show status bar**

Displays the status bar. The status bar is located at the bottom of the IDE window and displays information about the progress of ongoing operations.

**Close button affects active tool window only**

Specifies that when the **Close** button is clicked, only the tool window that has focus is closed and not all of the tool windows in the docked set. By default, this option is selected.

**Auto Hide button affects active tool window only**

Specifies that when the **Auto Hide** button is clicked, only the tool window that has focus is hidden automatically and not all of the tool windows in the docked set. By default, this option is not selected.

## See also

- [Environment Options Dialog Box](../../ide/reference/environment-options-dialog-box.md)
- [Customizing window layouts](../../ide/customizing-window-layouts-in-visual-studio.md)