---
title: "Unzip Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: msbuild
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Unzip"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Unzip task [MSBuild]"
  - "MSBuild, Unzip task"
ms.assetid: 916bb2e3-3017-4828-ae27-c0b5c99bbb48
caps.latest.revision: 16
author: Mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: 
  - "multiple"
---
# Unzip Task
Unzips a `.zip` archive to the specified location.

**Note:** The `Unzip` task is available in MSBuild 15.7 and above only.
  
## Parameters  
 The following table describes the parameters of the `Unzip` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`DestinationFolder`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter<br /><br /> Specifies the destination folder to unzip the file to.|
|`OverwriteReadOnlyFiles`|Optional `Boolean` parameter.<br /><br /> If `true`, overwrites read-only files. Defaults to `false`.|
|`SkipUnchangedFiles`|Optional `Boolean` parameter.<br /><br /> If `true`, skips unzipping files that are unchanged. Defaults to `true`. The `Unzip` task considers files to be unchanged if they have the same size and the same last modified time.|
|`SourceFiles`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies one or more the files to unzip. When specifying multiple files they are unzipped in order to the same folder.|
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## Example  
 The following example unzips an archive and overwrites any read-only files.
  
```xml  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <Target Name="UnzipArchive" BeforeTargets="Build">
        <Unzip
            SourceFiles="MyArchive.zip"
            DestinationFolder="$(OutputPath)\unzipped"
            OverwriteReadOnlyFiles="true"
        />
    </Target>

</Project>
```
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
