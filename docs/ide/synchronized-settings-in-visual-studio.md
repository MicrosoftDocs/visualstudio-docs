---
title: "Synchronize your settings in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/23/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.ToolsOptionsPages.Environment.RoamingSettings"
ms.assetid: a3d2ea29-be5d-4012-9820-44b06adbb7dd
caps.latest.revision: 10
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Synchronize your settings in Visual Studio

When you sign in to Visual Studio on multiple computers using the same personalization account, by default your settings are synchronized on all computers.

## Synchronized settings

By default, the following settings are synchronized.

- Development settings (You have to select a set of settings the first time you run Visual Studio, but you can change the selection anytime. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).)

- The following options in the **Tools &#124; Options** pages:

    - **Theme** and menu bar casing settings, on the **Environment**, **General** options page

    - All settings on the **Environment**, **Fonts and Colors** options page

    - All keyboard shortcuts, on the **Environment**, **Keyboard** options page

    - All settings on the **Environment, Tabs and Windows** options page

    - All settings on the **Environment**, **StartUp** options page

    - All settings on the **Text Editor** options pages

    - All settings on the **XAML Designer** options pages

- User-defined command aliases. For more information about how to define command aliases, see [Visual Studio Command Aliases](../ide/reference/visual-studio-command-aliases.md).

- User-defined window layouts in **Window &#124; Manage Window Layouts** page

## Turn off synchronized settings on a particular computer

Synchronized settings for Visual Studio are turned on by default. You can turn off synchronized settings on a computer by going to the **Tools &#124; Options &#124; Environment &#124; Accounts** page and unchecking the checkbox.  For example, if you decide not to synchronize Visual Studio's settings on Computer A, any setting changes made on Computer A do not appear on Computer B or Computer C. Computer B and C will continue to synchronize with each other, but not with Computer A.

## Synchronize settings across Visual Studio family products and editions

Settings can be synchronized across any edition of Visual Studio, including the Community edition. Settings are also synchronized across Visual Studio family products. However, each of these family products may have its own settings that are not shared with Visual Studio. For example, settings specific to one product on Computer A will be shared with another on Computer B, but not with Visual Studio on Computer A or B.

## Side-by-side synchronized settings

In Visual Studio 15.3 and later, we've stopped sharing certain settings, like tool window layout, between different side-by-side installations of Visual Studio 2017 by changing the location of `CurrentSettings.vssettings` file in `%userprofile%\Documents\Visual Studio 2017\Settings` to an installation specific folder that is similar to `%localappdata%\Microsoft\VisualStudio\15.0_xxxxxxxx\Settings`.

**NOTE**: To use the new installation specific settings, you must complete a fresh installation. When you perform an upgrade of an existing Visual Studio 2017 installation to the most current update, it will use the existing shared location. If you currently have side-by-side installations of Visual Studio 2017 and decide to upgrade, and want to use the new installation specific settings file location, follow these steps:

1. After the upgrade, use the Import\Export settings wizard to export all our existing settings to some location outside of       `%localappdata%\Microsoft\VisualStudio\15.0_xxxxxxxx` folder.
2. Open the **Developer Command Prompt for VS 2017** of the upgraded Visual Studio installation and run `devenv /resetuserdata` from it.
3. Launch Visual Studio and import the saved settings from the exported settings file.

## See also

[Personalizing the  IDE](../ide/personalizing-the-visual-studio-ide.md)
