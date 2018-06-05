---
title: "DownloadFile Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: msbuild
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#DownloadFile"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "DownloadFile task [MSBuild]"
  - "MSBuild, DownloadFile task"
ms.assetid: 916bb2e3-3017-4828-ae27-c0b5c99bbb48
caps.latest.revision: 16
author: Mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: 
  - "multiple"
---
# DownloadFile Task
Downloads the specified files using the Hyper-Text Transfer Protocol (HTTP).

**Note:** The `DownloadFile` task is available in MSBuild 15.7 and above only.
  
## Parameters  
 The following table describes the parameters of the `DownloadFile` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`DestinationFileName`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter<br /><br /> The name to use for the downloaded file.  By default, the file name is derived from the `SourceUrl` or the remote server.|
|`DestinationFolder`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the destination folder to download the file to.  If folder is created if it does not exist.|
|`DownloadedFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the file that was downloaded.|
|`Retries`|Optional `Int32` parameter.<br /><br /> Specifies how many times to attempt to download, if all previous attempts have failed. Defaults to zero.|  
|`RetryDelayMilliseconds`|Optional `Int32` parameter.<br /><br /> Specifies the delay in milliseconds between any necessary retries. Defaults to 5000.|  
|`SkipUnchangedFiles`|Optional `Boolean` parameter.<br /><br /> If `true`, skips the downloading of files that are unchanged. Defaults to `true`. The `DownloadFile` task considers files to be unchanged if they have the same size and the same last modified time according to the remote server. **Note:**  Not all HTTP servers indicate the last modified date of files will cause the file to be downloaded again.|
|`SourceUrl`|Required `String` parameter.<br /><br /> Specifies the URL to download.|
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## Example  
 The following example downloads a file and includes it in the `Content` items prior to building the project.
  
```xml  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

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
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
