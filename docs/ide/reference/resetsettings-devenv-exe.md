---
title: -ResetSettings (devenv.exe)
description: Learn how to use the ResetSettings devenv command-line switch to restore Visual Studio default settings and automatically launch the Visual Studio IDE.
ms.custom: SEO-VS-2020
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- Devenv, /ResetSettings switch
- ResetSettings switch
- /ResetSettings Devenv switch
- settings [Visual Studio], resetting
ms.assetid: 1d41021c-6f58-4bd5-b122-d1c995812192
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# /ResetSettings (devenv.exe)

Restores Visual Studio default settings and automatically launches the Visual Studio IDE. This switch optionally resets the settings to a specified settings file (`*.vssettings`).

The default settings come from the profile that was selected when Visual Studio was first launched.

> [!TIP]
> To learn how to reset settings using the integrated development environment (IDE), see [Reset settings](../environment-settings.md#reset-settings).

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

- [Environment settings](../environment-settings.md)
- [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)
- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
