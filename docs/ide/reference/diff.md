---
title: -Diff (devenv.exe)
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.topic: reference
ms.assetid: 5377fedb-632a-4e86-a947-7c11c86451e7
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Diff (devenv.exe)

Compares two files. The differences are displayed in a special Visual Studio window.

## Syntax

```shell
devenv /Diff SourceFile TargetFile [SourceDisplayName [TargetDisplayName]]
```

## Arguments

*SourceFile*<br/>
Required. The full path and name of the first file to be compared.

*TargetFile*<br/>
Required. The full path and name of the second file to be compared

*SourceDisplayName*<br/>
Optional. The display name of the first file.

*TargetDisplayName*<br/>
Optional. The display name of the second file.

## Remarks

If an instance of the IDE is already open, the file comparison appears in a tab in the current IDE.

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
