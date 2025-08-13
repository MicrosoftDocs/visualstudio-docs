---
title: "AssignCulture Task"
description: Use the MSBuild AssignCulture task to produce items that have a metadata named Culture containing the corresponding culture identifier.
ms.date: 08/23/2023
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#AssignCulture"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild, AssignCulture task"
  - "AssignCulture task [MSBuild]"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# AssignCulture task

This task accepts a list of items that may contain a valid .NET culture identifier string as part of the file name, and produces items that have a metadata named `Culture` containing the corresponding culture identifier. For example, the file name *Form1.fr-fr.resx* has an embedded culture identifier "fr-fr," so this task produces an item that has the same filename with the metadata `Culture` equal to `fr-fr`. The task also produces a list of filenames with the culture removed from the filename.

## Task parameters

The following table describes the parameters of the `AssignCulture` task.

|Parameter|Description|
|---------------|-----------------|
|`AssignedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the list of items received in the `Files` parameter, with a `Culture` metadata entry added to each item.<br /><br /> If the incoming item from the `Files` parameter already contains a `Culture` metadata entry, the original metadata entry is used.<br /><br /> The task only assigns a `Culture` metadata entry if the file name contains a valid culture identifier. The culture identifier must be between the last two dots in the filename.|
|`AssignedFilesWithCulture`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the subset of the items from the `AssignedFiles` parameter that have a `Culture` metadata entry.|
|`AssignedFilesWithNoCulture`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the subset of the items from the `AssignedFiles` parameter that don't have a `Culture` metadata entry.|
|`CultureNeutralAssignedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the same list of items that is produced in the `AssignedFiles` parameter, except with the culture removed from the file name.<br /><br /> The task only removes the culture from the file name if it's a valid culture identifier.|
|`Files`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the list of files with embedded culture names to assign a culture to. The task tries to figure out if each file is a culture-specific resource, and if so, what culture. To skip this detection process and force a file to be culture-neutral, set the metadata entry `WithCulture` to `false`.|
|`RespectAlreadyAssignedItemCulture`|Optional `bool` parameter.<br /><br /> If set to `true` - the already set Culture metadata on the `Files` item parameter is respected and the `CultureNeutralAssignedFiles` will be populated with unchanged filename from `Files`.|

## Remarks

In addition to the parameters listed in this article, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following example executes the `AssignCulture` task with the `ResourceFiles` item collection.

```xml
<Project>
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

The following table describes the value of the output items after task execution. Item metadata is shown in parentheses after the item.

|Item collection|Contents|
|---------------------|--------------|
|`OutAssignedFiles`|*MyResource1.fr.resx* (Culture="fr")<br /><br /> *MyResource2.XX.resx* (no additional metadata)|
|`OutAssignedFilesWithCulture`|*MyResource1.fr.resx* (Culture="fr")|
|`OutAssignedFilesWithNoCulture`|*MyResource2.XX.resx* (no additional metadata)|
|`OutCultureNeutralAssignedFiles`|*MyResource1.resx* (Culture="fr")<br /><br /> *MyResource2.XX.resx* (no additional metadata)|

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
