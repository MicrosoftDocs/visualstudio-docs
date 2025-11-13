---
title: CreateProperty Task
description: Use the MSBuild CreateProperty task to populate properties with the values passed in, allowing values to be copied from one property or string to another.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#CreateProperty
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- CreateProperty task [MSBuild]
- MSBuild, CreateProperty task
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# CreateProperty task

Populates properties with the values passed in. This allows values to be copied from one property or string to another.

## Attributes

The following table describes the parameters of the `CreateProperty` task.

| Parameter | Description |
|------------------| - |
| `Value` | Optional `String` output parameter.<br /><br /> Specifies the value to copy to the new property. |
| `ValueSetByTask` | Optional `String` output parameter.<br /><br /> Contains the same value as the `Value` parameter. Use this parameter only when you want to avoid having the output property set by MSBuild when it skips the enclosing target because the outputs are up-to-date. |

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

The following example uses the `CreateProperty` task to create the `NewFile` property using the combination of the values of the `SourceFilename` and `SourceFileExtension` property.

```xml
<Project>

    <PropertyGroup>
        <SourceFilename>Module1</SourceFilename>
        <SourceFileExtension>vb</SourceFileExtension>
    </PropertyGroup>

    <Target Name="CreateProperties">

        <CreateProperty
            Value="$(SourceFilename).$(SourceFileExtension)">
            <Output
                TaskParameter="Value"
                PropertyName="NewFile" />
        </CreateProperty>

    </Target>

</Project>
```

After running the project, the value of the `NewFile` property is *Module1.vb*.

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)
