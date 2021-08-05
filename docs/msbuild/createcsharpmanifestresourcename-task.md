---
title: CreateCSharpManifestResourceName Task | Microsoft Docs
description: Use the MSBuild CreateCSharpManifestResourceName task to create a C#-style manifest name from a given .resx file name or other resource.
ms.custom: SEO-VS-2020
ms.date: 11/15/2020
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, CreateCSharpManifestResourceName task
- CreateCSharpManifestResourceName task [MSBuild]
ms.assetid: 2ace88c1-d757-40a7-8158-c1d3f5ff0511
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# CreateCSharpManifestResourceName task

Creates a C#-style manifest name from a given *.resx* file name or other resource.

## Parameters

 The following table describes the parameters of the [CreateCSharpManifestResourceName task](../msbuild/createcsharpmanifestresourcename-task.md).

| Parameter | Description |
| - | - |
| `ManifestResourceNames` | <xref:Microsoft.Build.Framework.ITaskItem> `[]` output read-only parameter.<br /><br /> The resulting manifest names. |
| `ResourceFiles` | Required `String` parameter.<br /><br /> The name of the resource file from which to create the C# manifest name. |
| `RootNamespace` | Optional `String` parameter.<br /><br /> The root namespace of the resource file, typically taken from the project file. May be `null`. |
| `PrependCultureAsDirectory` | Optional `Boolean` parameter.<br /><br /> If `true`, the culture name is added as a directory name just before the manifest resource name. Default value is `true`. |
| `ResourceFilesWithManifestResourceNames` | Optional read-only `String` output parameter.<br /><br /> Returns the name of the resource file that now includes the manifest resource name. |

## Remarks

 The [CreateCSharpManifestResourceName task](../msbuild/createcsharpmanifestresourcename-task.md) determines the appropriate manifest resource name to assign to a given *.resx* or other resource file. The task provides a logical name to a resource file, and then attaches it to an output parameter as metadata.

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
