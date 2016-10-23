---
title: "CreateItem Task"
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
ms.assetid: c4311f38-979e-4324-b524-9e8c1cbdc41a
caps.latest.revision: 15
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
# CreateItem Task
Populates item collections with the input items. This allows items to be copied from one list to another.  
  
> [!NOTE]
>  This task is deprecated. Starting with .NET Framework 3.5, item groups may be placed within [Target](../VS_IDE/Target-Element--MSBuild-.md) elements. For more information, see [Items](../VS_IDE/MSBuild-Items.md).  
  
## Attributes  
 The following table describes the parameters of the `CreateItem` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AdditionalMetadata`|Optional `String` array parameter.<br /><br /> Specifies additional metadata to attach to the output items.  Specify the metadata name and value for the item with the following syntax:<br /><br /> *MetadataName* `=` *MetadataValue*<br /><br /> Multiple metadata name/value pairs should be separated with a semicolon. If either the name or the value contains a semicolon or any other special characters, they must be escaped. For more information, see [How to: Escape Special Characters in MSBuild](../VS_IDE/How-to--Escape-Special-Characters-in-MSBuild.md).|  
|`Exclude`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Specifies the items to exclude from the output item collection. This parameter can contain wildcard specifications. For more information, see [Items](../VS_IDE/MSBuild-Items.md) and [How to: Exclude Files from the Build](../VS_IDE/How-to--Exclude-Files-from-the-Build.md).|  
|`Include`|Required <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]`parameter.<br /><br /> Specifies the items to include in the output item collection. This parameter can contain wildcard specifications.|  
|`PreserveExistingMetadata`|Optional `Boolean` parameter.<br /><br /> If `True`, only apply the additional metadata if they do not already exist.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## Example  
 The following code example creates a new item collection named `MySourceItemsWithMetadata` from the item collection `MySourceItems`. The `CreateItem` task populates the new item collection with the items in the `MySourceItems` item. It then adds an additional metadata entry named `MyMetadata` with a value of `Hello` to each item in the new collection.  
  
 After the task is executed, the `MySourceItemsWithMetadata` item collection contains the items `file1.resx` and `file2.resx`, both with metadata entries for `MyMetadata`. The `MySourceItems` item collection is unchanged.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <MySourceItems Include="file1.resx;file2.resx" />  
    </ItemGroup>  
  
    <Target Name="NewItems">  
        <CreateItem  
            Include="@(MySourceItems)"  
            AdditionalMetadata="MyMetadata=Hello">  
           <Output  
               TaskParameter="Include"  
               ItemName="MySourceItemsWithMetadata"/>  
        </CreateItem>  
  
    </Target>  
  
</Project>  
```  
  
 The following table describes the value of the output item after task execution. Item metadata is shown in parenthesis after the item.  
  
|Item collection|Contents|  
|---------------------|--------------|  
|`MySourceItemsWithMetadata`|`file1.resx` (`MyMetadata="Hello"`)<br /><br /> `file2.resx` (`MyMetadata="Hello"`)|  
  
## See Also  
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)   
 [Tasks](../VS_IDE/MSBuild-Tasks.md)