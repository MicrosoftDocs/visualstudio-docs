---
title: "UpdateManifest Task | Microsoft Docs"
description: Learn how MSBuild uses the UpdateManifest task to update selected properties in a manifest and resign.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "MSBuild, UpdateManifest task"
  - "UpdateManifest task [MSBuild]"
ms.assetid: 1291fd33-b89e-4e15-8fb1-69f9625cf2d2
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# UpdateManifest task

Updates selected properties in a manifest and resigns.

## Parameters

 The following table describes the parameters of the `UpdateManifest` task.

|Parameter|Description|
|---------------|-----------------|
|`ApplicationManifest`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the application manifest.|
|`ApplicationPath`|Required `String` parameter.<br /><br /> Specifies the path of the application manifest.|
|`InputManifest`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the manifest to update.|
|`OutputManifest`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the manifest that contains updated properties.|

## Remarks

 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [Task base class](../msbuild/task-base-class.md).

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)