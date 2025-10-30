---
title: Synchronize settings across multiple computers
description: Learn how to synchronize your Visual Studio settings across multiple computers by signing in to the same personalization account.
ms.date: 05/20/2022
ms.topic: article
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Synchronize Visual Studio settings across multiple computers

When you sign in to Visual Studio on multiple computers using the same personalization account, your settings can be synchronized across the computers.

## Synchronized settings

By default, the following settings are synchronized:

- Development settings. You select a collection of settings the first time you open Visual Studio, but you can change the selection anytime. For more information, see [Environment settings](../ide/personalizing-the-visual-studio-ide.md).

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

::: moniker range=">=vs-2022"

Synchronized settings for Visual Studio are turned on by default. You can turn off synchronized settings on a computer by going to the **Tools** > **Options** > **Environment** > **Accounts** page and clearing the **Synchronize settings across devices and installs on this machine (enabling this may overwrite local settings)** checkbox.

In earlier versions of Visual Studio 2022, this checkbox controlled only the synchronization of settings across devices. When you cleared the checkbox, it prevented the current device from synchronizing with other devices. (Although if the checkbox was selected on other devices, those devices continued to synchronize with each other. Conversely, multiple installations of Visual Studio on the same device continued to synchronize their settings even if the checkbox was cleared.)

Starting with Visual Studio 2022 [**version 17.2**](/visualstudio/releases/2022/release-notes), this checkbox also controls how Visual Studio synchronizes its installations on the same device. Clearing the checkbox prevents the current Visual Studio installation from synchronizing its settings with Visual Studio installations on the same device or on other devices.  Visual Studio installations on other devices that have the checkbox selected continue to synchronize with each other, as will devices with earlier (pre-17.2) versions of Visual Studio 2022 installed.

If you have multiple installations of Visual Studio, the following table describes how your settings are synchronized when you select or clear the **Synchronize Visual Studio settings across devices and installs on this machine** checkbox.

|Checkbox <br>status   |Version of Visual Studio |Current install syncs on the same device?  |Current install syncs across devices? |Other installs on the same device sync across devices? |
|---------|----------------|--------|--------|----------------------------------------------|
|Cleared  | 17.1 & earlier | Yes    | No     | No                                           |
|Selected | 17.1 & earlier | Yes    | Yes    | Yes, except 17.2+ with the checkbox cleared  |
|Cleared  | 17.2 & later   | No     | No     | No change                                    |
|Selected | 17.2 & later   | Yes    | Yes    | Yes, except 17.2+ with the checkbox cleared  |

::: moniker-end

::: moniker range="vs-2019"

Synchronized settings for Visual Studio are turned on by default. You can turn off synchronized settings on a computer by going to the **Tools** > **Options** > **Environment** > **Accounts** page and unselecting the **Synchronize Visual Studio settings across devices** option.

::: moniker-end

::: moniker range="<=vs-2019"

As an example, if you decide not to synchronize the settings in Visual Studio on computer "A", any setting changes made on computer "A" do not appear on computer "B" or computer "C". Computers "B" and "C" will continue to synchronize with each other, but not with computer "A".

> [!NOTE]
> If you choose not to synchronize settings by deselecting the option on the **Tools** > **Options** > **Environment** > **Accounts** page, other versions or editions of Visual Studio that you have on the same computer aren't affected. Those side-by-side installations of Visual Studio will continue to synchronize their settings (unless you uncheck the option there, too).

::: moniker-end

## Synchronize settings across Visual Studio IDE products and editions

Settings are synchronized across versions and editions of Visual Studio installed *side-by-side*. Settings are also synchronized across Visual Studio IDE products, including Blend for Visual Studio. However, an individual Visual Studio IDE product might have its own settings that aren't shared with Visual Studio. For example, settings specific to Blend for Visual Studio on computer "A" are not shared with Visual Studio on computers "A" or "B".

## Side-by-side synchronized settings

Certain settings like tool window layout aren't shared between different side-by-side installations of Visual Studio. For example, the *CurrentSettings.vssettings* file in *%userprofile%\Documents\Visual Studio 2019\Settings* is in an installation-specific folder that is similar to *%localappdata%\Microsoft\VisualStudio\16.0_xxxxxxxx\Settings*.

## Reset synchronized settings

To reset all settings to their defaults, sign in to Visual Studio, and then select **Tools** > **Import and Export Settings** to open the **Import and Export Settings Wizard**. Select **Reset all settings** and then follow the remaining steps of the wizard.

## Related content

- [Personalize the IDE](../ide/personalizing-the-visual-studio-ide.md)
- [Environment settings](../ide/personalizing-the-visual-studio-ide.md)
- [Environment > Accounts Options dialog box](reference/accounts-environment-options-dialog-box.md)
- [Install Visual Studio versions side-by-side](../install/install-visual-studio-versions-side-by-side.md)
