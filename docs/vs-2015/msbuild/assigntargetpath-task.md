---
title: "AssignTargetPath Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
ms.assetid: 0e830e31-3bcf-4259-b2a8-a5df49b92d51
caps.latest.revision: 8
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# AssignTargetPath Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This task accepts a list files and adds `<TargetPath>` attributes if they are not already specified.  
  
## Task Parameters  
 The following table describes the parameters of the `AssignTargetPath` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`RootFolder`|Optional `string` input parameter.<br /><br /> Contains the path to the folder that contains the target links.|  
|`Files`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` input parameter.<br /><br /> Contains the incoming list of files.|  
|`AssignedFiles`|Optional<br /><br /> <xref:Microsoft.Build.Framework.ITaskItem> `[]` output parameter.<br /><br /> Contains the resulting list of files.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## Example  
 The following example executes the `AssignTargetPath` task to configure a project.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
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
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
