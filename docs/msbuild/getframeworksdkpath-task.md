---
title: GetFrameworkSdkPath Task
description: Learn about how to use the MSBuild GetFrameworkSdkPath task to retrieve the path to the Windows SDK.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#GetFrameworkSdkPath
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- GetFrameworkSdkPath task [MSBuild]
- MSBuild, GetFrameworkSdkPath task
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# GetFrameworkSdkPath task

Retrieves the path to the Windows Software Development Kit (SDK).
## Task parameters

The following table describes the parameters of the `GetFrameworkSdkPath` task.
The following table describes the parameters of the `GetFrameworkSdkPath` task.

|Parameter|Description|
|---------------|-----------------|
|`FrameworkSdkVersion20Path`|Optional `String` read-only output parameter.<br /><br /> Returns the path to the .NET SDK version 2.0, if present. Otherwise returns `String.Empty`.|
|`FrameworkSdkVersion35Path`|Optional `String` read-only output parameter.<br /><br /> Returns the path to the .NET SDK version 3.5, if present. Otherwise returns `String.Empty`.|
|`FrameworkSdkVersion40Path`|Optional `String` read-only output parameter.<br /><br /> Returns the path to the .NET SDK version 4.0, if present. Otherwise returns `String.Empty`.|
|`Path`|Optional `String` output parameter.<br /><br /> Contains the path to the latest .NET SDK, if any version is present. Otherwise returns `String.Empty`.|

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

The following example uses the `GetFrameworkSdkPath` task to store the path to the Windows SDK in the `SdkPath` property.

```xml
<Project>
    <Target Name="GetPath">
        <GetFrameworkSdkPath>
            <Output
                TaskParameter="Path"
                PropertyName="SdkPath" />
        </GetFrameworkSdkPath>
        <Message Text="$(SdkPath)"/>
    </Target>
</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
