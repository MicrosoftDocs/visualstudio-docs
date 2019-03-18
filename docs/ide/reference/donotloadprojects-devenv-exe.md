---
title: -DoNotLoadProjects (devenv.exe)
ms.date: 03/11/2019
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /DoNotLoadProjects switch"
  - "/DoNotLoadProjects Devenv switch"
  - "DoNotLoadProjects Devenv switch"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# /DoNotLoadProjects (devenv.exe)

Opens the specified solution without loading any projects.

## Syntax

```shell
devenv /DoNotLoadProjects SolutionName
```

## Arguments

- *SolutionName*

  Required. The full path and name of the solution to be opened.

## Example

The example opens ths solution MySln.sln without loading any projects.

```shell
devenv /donotloadprojects MySln.sln

```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
