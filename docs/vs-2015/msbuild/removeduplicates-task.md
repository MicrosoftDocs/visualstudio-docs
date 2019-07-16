---
title: "RemoveDuplicates Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#RemoveDuplicates"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, RemoveDuplicates task"
  - "RemoveDuplicates task [MSBuild]"
ms.assetid: 481cbab6-73ff-488c-aba5-2c09f9eb1e04
caps.latest.revision: 13
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# RemoveDuplicates Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Removes duplicate items from the specified item collection.  
  
## Parameters  
 The following table describes the parameters of the `RemoveDuplicates` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Filtered`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains an item collection with all duplicate items removed.|  
|`Inputs`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> The item collection to remove duplicate items from.|  
  
## Remarks  
 This task is case insensitive and does not compare item metadata when determining duplicates.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## Example  
 The following example uses the `RemoveDuplicates` task to remove duplicate items from the `MyItems` item collection. When the task is complete, the `FilteredItems` item collection contains one item.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <MyItems Include="MyFile.cs"/>  
        <MyItems Include="MyFile.cs">  
            <Culture>fr</Culture>  
        </MyItems>  
        <MyItems Include="myfile.cs"/>  
    </ItemGroup>  
  
    <Target Name="RemoveDuplicateItems">  
        <RemoveDuplicates  
            Inputs="@(MyItems)">  
            <Output  
                TaskParameter="Filtered"  
                ItemName="FilteredItems"/>  
        </RemoveDuplicates>  
    </Target>  
</Project>  
```  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)   
 [Tasks](../msbuild/msbuild-tasks.md)
