---
title: -ResetSettings (devenv.exe)
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /ResetSettings switch"
  - "ResetSettings switch"
  - "/ResetSettings Devenv switch"
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

## Syntax

```cmd
Devenv /ResetSettings SettingsFile
```

## Arguments

`SettingsFile`

The full path and name of the *vssettings* file to apply to Visual Studio.

To restore the General Development Settings profile, use `General`.

## Remarks

If no `SettingsFile` is specified, you are prompted to select a default collection of settings the next time you start Visual Studio.

## Example

The following command line applies the settings stored in the file `MySettings.vssettings`.

```cmd
Devenv.exe /ResetSettings "C:\My Files\MySettings.vssettings"
```

## See Also

- [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)
- [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)