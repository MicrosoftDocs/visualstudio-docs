---
title: -ResetSettings (devenv.exe)
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /ResetSettings switch"
  - "ResetSettings switch"
  - "/ResetSettings Devenv switch"
  - "settings [Visual Studio], resetting"
ms.assetid: 1d41021c-6f58-4bd5-b122-d1c995812192
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /ResetSettings (devenv.exe)

Restores Visual Studio default settings and automatically launches the Visual Studio IDE. Optionally resets the settings to a specified *vssettings* file.

The default settings are determined by the profile that was selected when Visual Studio was first launched.

> [!TIP]
> To learn how to reset settings using the integrated development environment (IDE), see [Reset settings](../environment-settings.md#reset-settings).

## Syntax

```shell
devenv /ResetSettings [SettingsFile]
```

## Arguments

*SettingsFile*<br/>
The full path and name of the *vssettings* file to apply to Visual Studio. To restore the General Development Settings profile, use `General`.

## Remarks

If no *SettingsFile* is specified, you're prompted to select a default collection of settings the next time you start Visual Studio.

## Example

The following command line applies the settings stored in the file `MySettings.vssettings`.

```shell
devenv /resetsettings "C:\My Files\MySettings.vssettings"
```

## See also

- [Environment settings](../environment-settings.md)
- [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)
- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)