---
title: Synchronize settings
ms.date: 12/10/2018
ms.topic: conceptual
ms.assetid: a3d2ea29-be5d-4012-9820-44b06adbb7dd
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Synchronize Visual Studio settings across multiple computers

When you sign in to Visual Studio on multiple computers using the same personalization account, your settings can be synchronized across the computers.

## Synchronized settings

By default, the following settings are synchronized:

- Development settings. You select a collection of settings the first time you open Visual Studio, but you can change the selection anytime. For more information, see [Environment settings](../ide/environment-settings.md).

- User-defined command aliases. For more information about how to define command aliases, see [Visual Studio command aliases](../ide/reference/visual-studio-command-aliases.md).

- User-defined window layouts in **Window** > **Manage Window Layouts** page.

- The following options in the **Tools** > **Options** pages:

  - Theme and menu bar casing settings on the **Environment** > **General** options page.

  - All settings on the **Environment** > **Fonts and Colors** options page.

  - All keyboard shortcuts on the **Environment** > **Keyboard** options page.

  - All settings on the **Environment** > **Tabs and Windows** options page.

  - All settings on the **Environment** > **StartUp** options page.

  - All settings on the **Text Editor** options pages, for example, [code style preferences](code-styles-and-code-cleanup.md).

  - All settings on the **XAML Designer** options pages.

## Turn off synchronized settings on a particular computer

Synchronized settings for Visual Studio are turned on by default. You can turn off synchronized settings on a computer by going to the **Tools** > **Options** > **Environment** > **Accounts** page and unchecking **Synchronize settings across devices when signed into Visual Studio**.

As an example, if you decide not to synchronize Visual Studio's settings on computer "A", any setting changes made on computer "A" do not appear on computer "B" or computer "C". Computers "B" and "C" will continue to synchronize with each other, but not with computer "A".

> [!NOTE]
> If you choose not to synchronize settings by deselecting the option on the **Tools** > **Options** > **Environment** > **Accounts** page, other versions or editions of Visual Studio that you have on the same computer aren't affected. Those side-by-side installations of Visual Studio will continue to synchronize their settings (unless you uncheck the option there, too).

## Synchronize settings across Visual Studio family products and editions

Settings are synchronized across versions and editions of Visual Studio installed *side-by-side*. Settings are also synchronized across Visual Studio family products, including Blend for Visual Studio. However, an individual family product may have its own settings that aren't shared with Visual Studio. For example, settings specific to Blend for Visual Studio on computer "A" are not shared with Visual Studio on computers "A" or "B".

## Side-by-side synchronized settings

::: moniker range="vs-2017"

Certain settings like tool window layout aren't shared between different side-by-side installations of Visual Studio. The *CurrentSettings.vssettings* file in *%userprofile%\Documents\Visual Studio 2017\Settings* is in an installation-specific folder that is similar to *%localappdata%\Microsoft\VisualStudio\15.0_xxxxxxxx\Settings*.

> [!NOTE]
> To use the new installation-specific settings, do a fresh installation. When you upgrade an existing Visual Studio installation, it uses the existing shared location.

If you currently have side-by-side installations of Visual Studio and want to use the new installation-specific settings file location, follow these steps:

1. Upgrade to Visual Studio 2017 version 15.3 or later.

2. Use the **Import and Export Settings Wizard** to export all your existing settings to some location outside of the *%localappdata%\Microsoft\VisualStudio\15.0_xxxxxxxx* folder.

3. Open the **Developer Command Prompt for VS 2017** and run `devenv /resetuserdata`.

1. Open Visual Studio and import the saved settings from the exported settings file.

::: moniker-end

::: moniker range=">=vs-2019"

Certain settings like tool window layout aren't shared between different side-by-side installations of Visual Studio. The *CurrentSettings.vssettings* file in *%userprofile%\Documents\Visual Studio 2019\Settings* is in an installation-specific folder that is similar to *%localappdata%\Microsoft\VisualStudio\16.0_xxxxxxxx\Settings*.

::: moniker-end

## Reset synchronized settings

To reset all settings to their defaults, sign in to Visual Studio, and then select **Tools** > **Import and Export Settings** to open the **Import and Export Settings Wizard**. Select **Reset all settings** and then follow the remaining steps of the wizard.

## See also

- [Personalize the IDE](../ide/personalizing-the-visual-studio-ide.md)
- [Environment settings](../ide/environment-settings.md)
- [Environment > Accounts Options dialog box](reference/accounts-environment-options-dialog-box.md)
