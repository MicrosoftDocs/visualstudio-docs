---
title: DownloadFile Task
description: Learn about the parameters of the MSBuild DownloadFile task, which downloads specified files using HTTP.
ms.date: 11/04/2016
ms.reviewer: ''
ms.suite: ''
ms.tgt_pltfrm: ''
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#DownloadFile
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- DownloadFile task [MSBuild]
- MSBuild, DownloadFile task
caps.latest.revision: 16
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# DownloadFile task

Downloads the specified files using the Hyper-Text Transfer Protocol (HTTP).

>[!NOTE]
>The DownloadFile task is available in MSBuild 15.8 and above only.

## Parameters

The following table describes the parameters of the `DownloadFile` task.

|Parameter|Description|
|---------------|-----------------|
|`DestinationFileName`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter<br /><br /> The name to use for the downloaded file.  By default, the file name is derived from the `SourceUrl` or the remote server.|
|`DestinationFolder`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the destination folder to download the file to.  If folder is created if it does not exist.|
|`DownloadedFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the file that was downloaded.|
|`Retries`|Optional `Int32` parameter.<br /><br /> Specifies how many times to attempt to download, if all previous attempts have failed. Defaults to zero.|
|`RetryDelayMilliseconds`|Optional `Int32` parameter.<br /><br /> Specifies the delay in milliseconds between any necessary retries. Defaults to 5000.|
|`SkipUnchangedFiles`|Optional `Boolean` parameter.<br /><br /> If `true`, skips the downloading of files that are unchanged. Defaults to `true`. The `DownloadFile` task considers files to be unchanged if they have the same size and the same last modified time according to the remote server. <br /><br />**Note:**  Not all HTTP servers indicate the last modified date of files will cause the file to be downloaded again.|
|`SourceUrl`|Required `String` parameter.<br /><br /> Specifies the URL to download.|

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

The following example downloads a file and includes it in the `Content` items prior to building the project.

```xml
<Project>

    <PropertyGroup>
      <MyUrl>https://raw.githubusercontent.com/Microsoft/msbuild/master/LICENSE</MyUrl>
    </PropertyGroup>

    <Target Name="DownloadContentFiles" BeforeTargets="Build">
        <DownloadFile
            SourceUrl="$(MyUrl)"
            DestinationFolder="$(MSBuildProjectDirectory)">
        <Output TaskParameter="DownloadedFile" ItemName="Content" />
      </DownloadFile>
    </Target>

</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
