---
title: "Touch Task"
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
ms.assetid: 8a978645-1393-4904-ae69-42afabd8c109
caps.latest.revision: 17
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
# Touch Task
Sets the access and modification times of files.  
  
## Parameters  
 The following table describes the parameters of the `Touch` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AlwaysCreate`|Optional `Boolean` parameter.<br /><br /> If `true`, creates any files that do not already exist.|  
|`Files`|Required <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the collection of files to touch.|  
|`ForceTouch`|Optional `Boolean` parameter.<br /><br /> If `true`, forces a file touch even if the files are read-only.|  
|`Time`|Optional `String` parameter.<br /><br /> Specifies a time other than the current time. The format must be a format that is acceptable to the <xref:System.DateTime.Parse?qualifyHint=False> method.|  
|`TouchedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Contains the collection of items that were successfully touched.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## Example  
 The following example uses the `Touch` task to change the access and modification times of the files specified in the `Files` item collection, and puts the list of successfully touched files in the `FilesTouched` item collection.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
<ItemGroup>  
    <Files Include="File1.cs;File2.cs;File3.cs" />  
</ItemGroup>  
  
    <Target Name="TouchFiles">  
        <Touch  
            Files="@(Files)">  
            <Output  
                TaskParameter="TouchedFiles"  
                ItemName="FilesTouched"/>  
    </Touch>  
</Target>  
</Project>  
```  
  
## See Also  
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)