---
title: "MakeDir Task"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bc951577-1bfb-4100-b1f1-bc8278c45bf7
caps.latest.revision: 14
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# MakeDir Task
Creates directories and, if necessary, any parent directories.  
  
## Parameters  
 The following table describes the parameters of the `MakeDir` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Directories`|Required <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> The set of directories to create.|  
|`DirectoriesCreated`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> The directories that are created by this task. If some directories could not be created, this may not contain all of the items that were passed into the `Directories` parameter.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## Example  
 The following code example uses the `MakeDir` task to create the directory specified by the `OutputDirectory` property.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <PropertyGroup>  
        <OutputDirectory>\Output\</OutputDirectory>  
    </PropertyGroup>  
  
    <Target Name="CreateDirectories">  
        <MakeDir  
            Directories="$(OutputDirectory)"/>  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)