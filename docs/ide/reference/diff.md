---
title: -Diff
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
ms.assetid: 5377fedb-632a-4e86-a947-7c11c86451e7
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Diff
Compares two files. The differences are displayed in a special Visual Studio window.

## Syntax

```cmd
devenv /Diff SourceFile, TargetFile, [SourceDisplayName],[TargetDisplayName]
```

## Arguments
 `SourceFile`

 Required. The full path and name of the first file to be compared.

 `TargetFile`

 Required. The full path and name of the second file to be compared

 `SourceDisplayName`

 Optional. The display name of the first file.

 `TargetDisplayName`

 Optional. The display name of the second file.