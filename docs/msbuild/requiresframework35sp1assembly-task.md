---
title: "RequiresFramework35SP1Assembly Task | Microsoft Docs"
description: Learn how MSBuild uses the RequiresFramework35SP1Assembly task to determine whether the application requires .NET Framework 3.5 SP1.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "RequiresFramework35SP1Assembly task [MSBuild]"
  - "MSBuild, RequiresFramework35SP1Assembly task"
ms.assetid: 755c018a-8a8b-4c94-8aee-3f171fc419e5
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# RequiresFramework35SP1Assembly task

Determines whether the application requires the .NET Framework 3.5 SP1.

## Parameters

 The following table describes the parameters of the `RequiresFramework35SP1Assembly` task.

|Parameter|Description|
|---------------|-----------------|
|`Assemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the assemblies that are referenced in the application.|
|`CreateDesktopShortcut`|Optional `Boolean` parameter.<br /><br /> If `true`, creates a shortcut icon on the desktop during installation.|
|`DeploymentManifestEntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the manifest file name for the application.|
|`EntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the assembly that should be executed when the application is run.|
|`ErrorReportUrl`|Optional `String` parameter.<br /><br /> Specifies the Web site that is displayed in dialog boxes that are encountered during ClickOnce installations.|
|`Files`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the list of files that will be deployed when the application is published.|
|`ReferencedAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the assemblies that are referenced in the project.|
|`RequiresMinimumFramework35SP1`|Optional `Boolean` output parameter.<br /><br /> If `true`, the application requires the .NET Framework 3.5 SP1.|
|`SigningManifests`|Optional `Boolean` output parameter.<br /><br /> If `true`, the ClickOnce manifests are signed.|
|`SuiteName`|Optional `String` parameter.<br /><br /> Specifies the name of the folder on the **Start** menu in which the application will be installed.|
|`TargetFrameworkVersion`|Optional `String` parameter.<br /><br /> Specifies the version of the .NET Framework that this application targets.|

## Remarks

 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)