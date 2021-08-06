---
title: Using Memory Efficiently When You Build Large Projects | Microsoft Docs
description: Learn how MSBuild manages memory automatically, such as unloading older versions and retrieving caches, when building large projects.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- memory use (MSBuild)
- msbuild, efficient memory use building large trees
- caching (MSBuild)
ms.assetid: 853a21ed-69f7-4817-af00-57f73e2c74b5
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Use memory efficiently when you build large projects

Large projects often contain many subprojects and other dependencies, which may consume lots of system memory at build time. When available system memory is decreased, system performance may also be decreased. Older versions of MSBuild projects remained in memory. Version 3.5 removed older versions of projects, but retained build results in a cache for later retrieval.

 Version 4.0 handles this memory management automatically, saving projects from having to use properties such as  `UnloadProjectsOnCompletion` and `UseResultsCache`.

### See also

- [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)
