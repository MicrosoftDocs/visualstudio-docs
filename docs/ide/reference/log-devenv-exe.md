---
title: -Log (devenv.exe)
description: Learn how to use the Log devenv command-line switch to log all activity to the log file for troubleshooting.
ms.custom: SEO-VS-2020
ms.date: 12/12/2018
ms.topic: reference
helpviewer_keywords:
- Devenv, /Log switch
- Log switch [devenv.exe]
- /Log Devenv switch
ms.assetid: ae23c4ae-2376-4fe3-b8d2-81d34e61c8ba
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# /Log (devenv.exe)

Logs all activity to the log file for troubleshooting. This file appears after you've called `devenv /log` at least once. By default, the log file is located here:

**%APPDATA%\\Microsoft\\VisualStudio\\**\<Version\>**\\ActivityLog.xml**

where \<Version\> is the Visual Studio version. However, you may specify a different path and file name.

## Syntax

```shell
devenv /Log NameOfLogFile
```

## Arguments

- *NameOfLogFile*

  Required. The full path and name of the log file to save to.

## Remarks

This switch must appear at the end of the command line, after all other switches.

The log is written only for all instances of Visual Studio that you've opened with the `/Log` switch.

## Example

This example directs logging to the `MyVSLog.xml` file in the user's home directory.

```shell
devenv /log "%USERPROFILE%\MyVSLog.xml"
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
