---
title: AssignTargetPath Task
description: Use the MSBuild AssignTargetPath task to accept a list of files and add TargetPath attributes if they are not already specified.
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# AssignTargetPath task

This task accepts a list of files and adds `<TargetPath>` attributes if they are not already specified.

## Task parameters

The following table describes the parameters of the `AssignTargetPath` task.

|Parameter|Description|
|---------------|-----------------|
|`RootFolder`|Optional `string` input parameter.<br /><br /> Contains the path to the folder that contains the target links.|
|`Files`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` input parameter.<br /><br /> Contains the incoming list of files.|
|`AssignedFiles`|Optional<br /><br /> <xref:Microsoft.Build.Framework.ITaskItem> `[]` output parameter.<br /><br /> Contains the resulting list of files.|

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

The following example executes the `AssignTargetPath` task to configure a project.

```xml
<Project>
    <Target Name="MyProject">
        <AssignTargetPath
RootFolder="Resources"
            Files="@(ResourceFiles)"
            <Output TaskParameter="AssignedFiles"
                ItemName="OutAssignedFiles"/>
        </AssignTargetPath>
    </Target>
</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
