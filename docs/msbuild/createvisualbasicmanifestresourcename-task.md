---
title: CreateVisualBasicManifestResourceName Task | Microsoft Docs
description: Use the MSBuild CreateVisualBasicManifestResourceName task to create a Visual Basic-style manifest name from a given .resx file name or other resource.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, CreateVisualBasicManifestResourceName task
- CreateVisualBasicManifestResourceName task [MSBuild]
ms.assetid: 251c47b9-de32-414b-a138-bf45290af12e
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# CreateVisualBasicManifestResourceName task

Creates a Visual Basic-style manifest name from a given *.resx* file name or other resource.

## Parameters

 The following table describes the parameters of the [CreateVisualBasicManifestResourceName task](../msbuild/createvisualbasicmanifestresourcename-task.md).

| Parameter | Description |
| - | - |
| `ManifestResourceNames` | <xref:Microsoft.Build.Framework.ITaskItem> `[]` output read-only parameter.<br /><br /> The resulting manifest names. |
| `ResourceFiles` | Required `String` parameter.<br /><br /> The name of the resource file from which to create the Visual Basic manifest name. |
| `RootNamespace` | Optional `String` parameter.<br /><br /> The root namespace of the resource file, typically taken from the project file. May be `null`. |
| `PrependCultureAsDirectory` | Optional `Boolean` parameter.<br /><br /> If `true`, the culture name is added as a directory name just before the manifest resource name. Default value is `true`. |
| `ResourceFilesWithManifestResourceNames` | Optional read-only `String` output parameter.<br /><br /> Returns the name of the resource file that now includes the manifest resource name. |

## Remarks

 The [CreateVisualBasicManifestResourceName task](../msbuild/createvisualbasicmanifestresourcename-task.md) determines the appropriate manifest resource name to assign to a given *.resx* or other resource file. The task provides a logical name to a resource file, and then attaches it to an output parameter as metadata.

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
