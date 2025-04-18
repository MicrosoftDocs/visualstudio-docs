---
title: -ResetSettings (devenv.exe)
description: Learn how to use the ResetSettings devenv command-line switch to restore Visual Studio default settings and automatically launch the Visual Studio IDE.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- Devenv, /ResetSettings switch
- ResetSettings switch
- /ResetSettings Devenv switch
- settings [Visual Studio], resetting
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /ResetSettings (devenv.exe)

Restores Visual Studio default settings and automatically launches the Visual Studio IDE. This switch optionally resets the settings to a specified settings file (`*.vssettings`).

The default settings come from the profile that was selected when Visual Studio was first launched.

> [!TIP]
> To learn how to reset settings using the integrated development environment (IDE), see [Reset settings](../personalizing-the-visual-studio-ide.md#reset-all-settings).

## Syntax

```shell
devenv /ResetSettings [SettingsFile|DefaultCollectionSpecifier]
```

## Arguments

- *SettingsFile*

  Optional. The full path and name of the `.vssettings` file to apply to Visual Studio.

- *DefaultCollectionSpecifier*

  Optional. A specifier representing a default collection of settings to restore. Choose one of the default collection specifiers listed in the table.

  | Default collection name | Collection specifier |
  | --- | --- |
  | **General** | `General` |
  | **JavaScript** | `JavaScript` |
  | **Visual Basic** | `VB` |
  | **Visual C#** | `CSharp` |
  | **Visual C++** | `VC` |
  | **Web Development** | `Web` |
  | **Web Development (Code Only)** | `WebCode` |

## Remarks

If no *SettingsFile* is specified, the IDE opens using the existing settings. 

## Example

The first example applies the settings stored in the file `MySettings.vssettings`.

The second example restores the Visual C# default profile.

The third example will also close Visual Studio after apply the settings. You can append `/Command "File.Exit"`.

```shell
devenv /ResetSettings "%USERPROFILE%\MySettings.vssettings"

devenv /ResetSettings CSharp

devenv /NoSplash /ResetSettings General /Command Exit 
```

## See also

- [Environment settings](../personalizing-the-visual-studio-ide.md)
- [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)
- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
