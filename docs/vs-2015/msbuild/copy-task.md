---
title: "Copy Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Copy"
  - "MSBuild.Copy.SourceFileNotFound"
  - "MSBuild.Copy.Retrying"
  - "MSBuild.Copy.ExceededRetries"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, Copy task"
  - "Copy task [MSBuild]"
ms.assetid: a46ba9da-3e4e-4890-b4ea-09a099b6bc40
caps.latest.revision: 26
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Copy Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Copies files to a new location in the file system.  
  
## Parameters  
 The following table describes the parameters of the `Copy` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`CopiedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the items that were successfully copied.|  
|`DestinationFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the list of files to copy the source files to. This list is expected to be a one-to-one mapping with the list specified in the `SourceFiles` parameter. That is, the first file specified in `SourceFiles` will be copied to the first location specified in `DestinationFiles`, and so forth.|  
|`DestinationFolder`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the directory to which you want to copy the files. This must be a directory, not a file. If the directory does not exist, it is created automatically.|  
|`OverwriteReadOnlyFiles`|Optional `Boolean` parameter.<br /><br /> Overwrite files even if they are marked as read only files|  
|`Retries`|Optional `Int32` parameter.<br /><br /> Specifies how many times to attempt to copy, if all previous attempts have failed. Defaults to zero.<br /><br /> **Note:** The use of retries can mask a synchronization problem in your build process.|  
|`RetryDelayMilliseconds`|Optional `Int32` parameter.<br /><br /> Specifies the delay between any necessary retries. Defaults to the RetryDelayMillisecondsDefault argument, which is passed to the CopyTask constructor.|  
|`SkipUnchangedFiles`|Optional `Boolean` parameter.<br /><br /> If `true`, skips the copying of files that are unchanged between the source and destination. The `Copy` task considers files to be unchanged if they have the same size and the same last modified time. **Note:**  If you set this parameter to `true`, you should not use dependency analysis on the containing target, because that only runs the task if the last-modified times of the source files are newer than the last-modified times of the destination files.|  
|`SourceFiles`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the files to copy.|  
|`UseHardlinksIfPossible`|Optional `Boolean` parameter.<br /><br /> If `true`, creates Hard Links for the copied files instead of copying the files.|  
  
## Warnings  
 Warnings are logged, including:  
  
- `Copy.DestinationIsDirectory`  
  
- `Copy.SourceIsDirectory`  
  
- `Copy.SourceFileNotFound`  
  
- `Copy.CreatesDirectory`  
  
- `Copy.HardLinkComment`  
  
- `Copy.RetryingAsFileCopy`  
  
- `Copy.FileComment`  
  
- `Copy.RemovingReadOnlyAttribute`  
  
## Remarks  
 Either the `DestinationFolder` or the `DestinationFiles` parameter must be specified, but not both. If both are specified, the task fails and an error is logged.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## Example  
 The following example copies the items in the `MySourceFiles` item collection into the folder c:\MyProject\Destination.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <MySourceFiles Include="a.cs;b.cs;c.cs"/>  
    </ItemGroup>  
  
    <Target Name="CopyFiles">  
        <Copy  
            SourceFiles="@(MySourceFiles)"  
            DestinationFolder="c:\MyProject\Destination"  
        />  
    </Target>  
  
</Project>  
```  
  
## Example  
 The following example demonstrates how to do a recursive copy. This project copies all of the files recursively from c:\MySourceTree into c:\MyDestinationTree, while maintaining the directory structure.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <MySourceFiles Include="c:\MySourceTree\**\*.*"/>  
    </ItemGroup>  
  
    <Target Name="CopyFiles">  
        <Copy  
            SourceFiles="@(MySourceFiles)"  
            DestinationFiles="@(MySourceFiles->'c:\MyDestinationTree\%(RecursiveDir)%(Filename)%(Extension)')"  
        />  
    </Target>  
  
</Project>  
```  
  
## See also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
