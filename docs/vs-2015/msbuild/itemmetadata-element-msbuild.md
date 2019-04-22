---
title: "ItemMetadata Element (MSBuild) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "ItemMetadata Element [MSBuild]"
  - "<ItemMetadata> Element [MSBuild]"
ms.assetid: e3db5122-202d-43a9-b2f4-3e0ec4ed3d08
caps.latest.revision: 20
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# ItemMetadata Element (MSBuild)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Contains a user-defined item metadata key, which contains the item metadata value. An item may have any number of metadata key-value pairs.  
  
 \<Project>  
 \<ItemGroup>  
 \<Item>  
  
## Syntax  
  
```  
<ItemMetadataName> Item Metadata value</ItemMetadataName>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Condition`|Optional attribute.<br /><br /> Condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Item](../msbuild/item-element-msbuild.md)|A user-defined element that defines the inputs for the build process.|  
  
## Text Value  
 A text value is optional.  
  
 This text specifies the item metadata value, which can be either text or XML.  
  
## Remarks  
  
## Example  
 The following code example shows how to add `Culture` metadata with the value `fr` to the item `CSFile`.  
  
```  
<ItemGroup>  
    <CSFile Include="main.cs" >  
        <Culture>fr</Culture>  
    </CSFile>  
</ItemGroup>  
```  
  
## See Also  
 [Project File Schema Reference](../msbuild/msbuild-project-file-schema-reference.md)   
 [Items](../msbuild/msbuild-items.md)
