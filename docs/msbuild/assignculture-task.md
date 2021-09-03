---
title: "AssignCulture Task | Microsoft Docs"
description: Use the MSBuild AssignCulture task to produce item that have a metadata named Culture containing the corresponding culture identifier.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#AssignCulture"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "MSBuild, AssignCulture task"
  - "AssignCulture task [MSBuild]"
ms.assetid: 8f8314cc-82a6-4f16-a62d-b9f0d1d5e274
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# AssignCulture task

This task accepts a list of items that may contain a valid .NET culture identifier string as part of the file name, and produces items that have a metadata named `Culture` containing the corresponding culture identifier. For example, the file name *Form1.fr-fr.resx* has an embedded culture identifier "fr-fr", so this task will produce an item that has the same filename with the metadata `Culture` equal to `fr-fr`. The task also produces a list of filenames with the culture removed from the filename.

## Task parameters

The following table describes the parameters of the `AssignCulture` task.

|Parameter|Description|
|---------------|-----------------|
|`AssignedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the list of items received in the `Files` parameter, with a `Culture` metadata entry added to each item.<br /><br /> If the incoming item from the `Files` parameter already contains a `Culture` metadata entry, the original metadata entry is used.<br /><br /> The task only assigns a `Culture` metadata entry if the file name contains a valid culture identifier. The culture identifier must be between the last two dots in the filename.|
|`AssignedFilesWithCulture`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the subset of the items from the `AssignedFiles` parameter that have a `Culture` metadata entry.|
|`AssignedFilesWithNoCulture`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the subset of the items from the `AssignedFiles` parameter that do not have a `Culture` metadata entry.|
|`CultureNeutralAssignedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the same list of items that is produced in the `AssignedFiles` parameter, except with the culture removed from the file name.<br /><br /> The task only removes the culture from the file name if it is a valid culture identifier.|
|`Files`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the list of files with embedded culture names to assign a culture to.|

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following example executes the `AssignCulture` task with the `ResourceFiles` item collection.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <ItemGroup>
        <ResourceFiles Include="MyResource1.fr.resx"/>
        <ResourceFiles Include="MyResource2.XX.resx"/>
    </ItemGroup>

    <Target Name="Culture">
        <AssignCulture
            Files="@(ResourceFiles)"
            <Output TaskParameter="AssignedFiles"
                ItemName="OutAssignedFiles"/>
            <Output TaskParameter="AssignedFilesWithCulture"
                ItemName="OutAssignedFilesWithCulture"/>
            <Output TaskParameter="AssignedFilesWithNoCulture"
                ItemName="OutAssignedFilesWithNoCulture"/>
            <Output TaskParameter="CultureNeutralAssignedFiles"
                ItemName="OutCultureNeutralAssignedFiles"/>
        </AssignCulture>
    </Target>
</Project>
```

The following table describes the value of the output items after task execution. Item metadata is shown in parenthesis after the item.

|Item collection|Contents|
|---------------------|--------------|
|`OutAssignedFiles`|*MyResource1.fr.resx* (Culture="fr")<br /><br /> *MyResource2.XX.resx* (no additional metadata)|
|`OutAssignedFilesWithCulture`|*MyResource1.fr.resx* (Culture="fr")|
|`OutAssignedFilesWithNoCulture`|*MyResource2.XX.resx* (no additional metadata)|
|`OutCultureNeutralAssignedFiles`|*MyResource1.resx* (Culture="fr")<br /><br /> *MyResource2.XX.resx* (no additional metadata)|

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
