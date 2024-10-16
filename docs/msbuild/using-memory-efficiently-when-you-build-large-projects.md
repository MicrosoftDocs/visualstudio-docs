---
title: Using Memory Efficiently When You Build Large Projects
description: Learn how MSBuild manages memory automatically, such as unloading older versions and retrieving caches, when building large projects.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- memory use (MSBuild)
- msbuild, efficient memory use building large trees
- caching (MSBuild)
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Use memory efficiently when you build large projects

Large projects often contain many subprojects and other dependencies, which may consume lots of system memory at build time. When available system memory is decreased, system performance may also be decreased. Older versions of MSBuild projects remained in memory. Version 3.5 removed older versions of projects, but retained build results in a cache for later retrieval.

 Version 4.0 handles this memory management automatically, saving projects from having to use properties such as  `UnloadProjectsOnCompletion` and `UseResultsCache`.

### Related content

- [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)
