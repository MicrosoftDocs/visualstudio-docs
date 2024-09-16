---
title: Specify build components & processes with MSBuild
description: Explore how to specify build components and processes by using MSBuild properties, items, tasks, and targets in Visual Studio.
ms.date: 9/12/2024
ms.topic: overview
helpviewer_keywords:
- MSBuild, concepts
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild concepts

MSBuild provides a basic XML schema that you can use to control how the build platform builds software. To specify the components in the build and how they are to be built, use these four parts of MSBuild: properties, items, tasks, and targets.

## Related topics

| Title | Description |
| - | - |
| [MSBuild properties](../msbuild/msbuild-properties.md) | Introduces properties and property collections. Properties are key/value pairs that you can use to configure builds. |
| [MSBuild items](../msbuild/msbuild-items.md) | Introduces items and item collections. Items are inputs into the build system and typically represent files. |
| [MSBuild targets](../msbuild/msbuild-targets.md) | Explains how to group tasks together in a particular order and enable sections of the build process to be called on the command line. |
| [MSBuild tasks](../msbuild/msbuild-tasks.md) | Shows how to create a unit of executable code that can be used by MSBuild to perform atomic build operations. |
| [How MSBuild builds projects](build-process-overview.md) | Describes the internal build process used within MSBuild |
| [Comparing properties and items](../msbuild/comparing-properties-and-items.md) | Compares MSBuild properties and items. Both are used to pass information to tasks, evaluate conditions, and store values that can be referenced throughout the project file. |
| [Walkthrough: Creating an MSBuild project file from scratch](../msbuild/walkthrough-creating-an-msbuild-project-file-from-scratch.md) | Shows how to create a basic project file incrementally, by using only a text editor. |
| [Walkthrough: Using MSBuild](../msbuild/walkthrough-using-msbuild.md) | Introduces the building blocks of MSBuild and shows how to write, manipulate, and debug MSBuild projects without closing the Visual Studio integrated development environment (IDE). |
| [MSBuild reference](../msbuild/msbuild-reference.md) | Links to documents that contain reference information. |
| [MSBuild](../msbuild/msbuild.md) | Presents an overview of the XML schema for a project file and shows how it controls processes that builds software. |
