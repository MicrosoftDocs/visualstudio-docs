---
title: "AssignProjectConfiguration Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
ms.assetid: 09633a0b-8f6f-4aba-8058-7cb4d13ce2c0
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# AssignProjectConfiguration task
This task accepts a list configuration strings and assigns them to specified projects.

## Task parameters
 The following table describes the parameters of the `AssignProjectConfiguration` task.

|Parameter|Description|
|---------------|-----------------|
|`SolutionConfigurationContents`|Optional `string` output parameter.<br /><br /> Contains an XML string containing a project configuration for each project. The configurations are assigned to the named projects.|
|`DefaultToVcxPlatformMapping`|Optional `string` output parameter.<br /><br /> Contains a semicolon-delimited list of mappings from the platform names used by most types to those used by *.vcxproj* files.<br /><br /> For example:<br /><br /> `"AnyCPU=Win32;X86=Win32;X64=X64"`|
|`VcxToDefaultPlatformMapping`|Optional<br /><br /> `string` output parameter.<br /><br /> Contains a semicolon-delimited list of mappings from *.vcxproj* platform names to the platform names use by most types.<br /><br /> For example:<br /><br /> `"Win32=AnyCPU;X64=X64"`|
|`CurrentProjectConfiguration`|Optional `string` output parameter.<br /><br /> Contains the configuration for the current project.|
|`CurrentProjectPlatform`|Optional `string` output parameter.<br /><br /> Contains the platform for the current project.|
|`OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration`|Optional `bool` output parameter.<br /><br /> Contains a flag indicating that references should be built even if they were disabled in the project configuration.|
|`ShouldUnsetParentConfigurationAndPlatform`|Optional `bool` output parameter.<br /><br /> Contains a flag indicating if the parent configuration and platform should be unset.|
|`OutputType`|Optional `string` output parameter.<br /><br /> Contains the output type for the project.|
|`ResolveConfigurationPlatformUsingMappings`|Optional `bool` output parameter.<br /><br /> Contains a flag indicating if the build should use the default mappings to resolve the configuration and platform of the passed in project references.|
|`AssignedProjects`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the list of resolved reference paths.|
|`UnassignedProjects`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the list of project reference items that could not be resolved using the pre-resolved list of outputs.|

## Remarks
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)