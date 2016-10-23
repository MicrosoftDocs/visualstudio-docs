---
title: "MSBuild Well-known Item Metadata"
ms.custom: na
ms.date: 10/07/2016
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
ms.assetid: b5e791b5-c68f-4978-ad8a-9247d03bb6c0
caps.latest.revision: 12
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
# MSBuild Well-known Item Metadata
The following table describes the metadata assigned to every item upon creation. In each example, the following item declaration was used to include the file `C:\MyProject\Source\Program.cs` in the project.  
  
```  
<ItemGroup>  
    <MyItem Include="Source\Program.cs" />  
</ItemGroup>  
```  
  
|Item Metadata|Description|  
|-------------------|-----------------|  
|%(FullPath)|Contains the full path of the item. For example:<br /><br /> `C:\MyProject\Source\Program.cs`|  
|%(RootDir)|Contains the root directory of the item. For example:<br /><br /> `C:\`|  
|%(Filename)|Contains the file name of the item, without the extension. For example:<br /><br /> `Program`|  
|%(Extension)|Contains the file name extension of the item. For example:<br /><br /> `.cs`|  
|%(RelativeDir)|Contains the path specified in the `Include` attribute, up to the final backslash (\\). For example:<br /><br /> `Source\`|  
|%(Directory)|Contains the directory of the item, without the root directory. For example:<br /><br /> `MyProject\Source\`|  
|%(RecursiveDir)|If the `Include` attribute contains the wildcard \*\*, this metadata specifies the part of the path that replaces the wildcard. For more information on wildcards, see [How to: Select the Files to Build](../VS_IDE/How-to--Select-the-Files-to-Build.md).<br /><br /> If the folder *C:\MySolution\MyProject\Source\\* contains the file Program.cs, and if the project file contains this item:<br /><br /> `<ItemGroup>`<br /><br /> `<MyItem Include="C:\**\Program.cs" />`<br /><br /> `</ItemGroup>`<br /><br /> then the value of `%(MyItem.RecursiveDir)` would be *MySolution\MyProject\Source\\*.|  
|%(Identity)|The item specified in the `Include` attribute.. For example:<br /><br /> `Source\Program.cs`|  
|%(ModifiedTime)|Contains the timestamp from the last time the item was modified. For example:<br /><br /> `2004-07-01 00:21:31.5073316`|  
|%(CreatedTime)|Contains the timestamp from when the item was created. For example:<br /><br /> `2004-06-25 09:26:45.8237425`|  
|%(AccessedTime)|Contains the timestamp from the last time the item was accessed.<br /><br /> `2004-08-14 16:52:36.3168743`|  
  
## See Also  
 [Items](../VS_IDE/MSBuild-Items.md)   
 [Batching](../VS_IDE/MSBuild-Batching.md)   
 [MSBuild Reference](../VS_IDE/MSBuild-Reference.md)