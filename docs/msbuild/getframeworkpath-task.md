---
title: "GetFrameworkPath Task"
description: Learn how to use the MSBuild GetFrameworkPath task to retrieve the path to the .NET Framework assemblies.
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#GetFrameworkPath"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "GetFrameworkPath task [MSBuild]"
  - "MSBuild, GetFrameworkPath task"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# GetFrameworkPath task

Retrieves the path to the .NET Framework assemblies.
Retrieves the path to the .NET Framework assemblies.

## Task parameters

The following table describes the parameters of the `GetFrameworkPath` task.

|Parameter|Description|
|---------------|-----------------|
|`FrameworkVersion11Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 1.1 assemblies, if present. Otherwise returns `null`.|
|`FrameworkVersion20Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 2.0 assemblies, if present. Otherwise returns `null`.|
|`FrameworkVersion30Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 3.0 assemblies, if present. Otherwise returns `null`.|
|`FrameworkVersion35Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 3.5 assemblies, if present. Otherwise returns `null`.|
|`FrameworkVersion40Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 4.0 assemblies, if present. Otherwise returns `null`.|
|`Path`|Optional `String` output parameter.<br /><br /> Contains the path to the latest framework assemblies, if any are available. Otherwise returns `null`.|

## Remarks

If several versions of the .NET Framework are installed, this task returns the version that MSBuild is designed to run on.

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

The following example uses the `GetFrameworkPath` task to store the path to the .NET Framework in the `FrameworkPath` property.

```xml
<Project>
    <Target Name="GetPath">
        <GetFrameworkPath>
            <Output
                TaskParameter="Path"
                PropertyName="FrameworkPath" />
        </GetFrameworkPath>
    </Target>
</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
