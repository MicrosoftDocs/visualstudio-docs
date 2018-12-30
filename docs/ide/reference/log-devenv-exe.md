---
title: -Log (devenv.exe)
ms.date: 12/12/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /Log switch"
  - "Log switch [devenv.exe]"
  - "/Log Devenv switch"
ms.assetid: ae23c4ae-2376-4fe3-b8d2-81d34e61c8ba
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Log (devenv.exe)

Logs all activity to the log file for troubleshooting. This file appears after you've called `devenv /log` at least once. By default, the log file is located here:

**%APPDATA%\\Microsoft\\VisualStudio\\**\<Version\>**\\ActivityLog.Setup.xml**

where \<Version\> is the Visual Studio version. However, you may specify a different path and file name.

## Syntax

```shell
devenv /Log NameOfLogFile
```

## Arguments

*NameOfLogFile*<br/>
Required. The full path and name of the log file to save to.

## Remarks

This switch must appear at the end of the command line, after all other switches.

The log is written for all instances of Visual Studio that you've invoked with the `/Log` switch. It doesn't log instances of Visual Studio that you've invoked without the switch.

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)