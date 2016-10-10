---
title: "ItemDefinitionGroup Element (MSBuild)"
ms.custom: na
ms.date: 10/03/2016
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
ms.assetid: 4e9fb04b-5148-4ae5-a394-42861dd62371
caps.latest.revision: 5
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
# ItemDefinitionGroup Element (MSBuild)
The `ItemDefinitionGroup` element lets you define a set of Item Definitions, which are metadata values that are applied to all items in the project, by default. ItemDefinitionGroup supersedes the need to use the [CreateItem Task](../VS_IDE/CreateItem-Task.md) and the [CreateProperty Task](../VS_IDE/CreateProperty-Task.md). For more information, see [Item Definitions](../VS_IDE/Item-Definitions.md).  
  
 <Project\>  
 <ItemDefinitionGroup\>  
  
## Syntax  
  
```  
<ItemGroup Condition="'String A' == 'String B'">  
    <Item1>... </Item1>  
    <Item2>... </Item2>  
</ItemGroup>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Condition`|Optional attribute. Condition to be evaluated. For more information, see [Conditions](../VS_IDE/MSBuild-Conditions.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Item](../VS_IDE/Item-Element--MSBuild-.md)|Defines the inputs for the build process. There may be zero or more `Item` elements in an `ItemDefinitionGroup`.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../VS_IDE/Project-Element--MSBuild-.md)|Required root element of an MSBuild project file.|  
  
## Example  
 The following code example defines two metadata items, m and n, in an ItemDefinitionGroup. In this example, the default metadata "m" is applied to Item "i" because metadata "m" is not explicitly defined by Item "i". However, default metadata "n" is not applied to Item "i" because metadata "n" is already defined by Item "i".  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <ItemDefinitionGroup>  
        <i>  
            <m>m1</m>  
            <n>n1</n>  
        </i>        
    </ItemDefinitionGroup>  
    <ItemGroup>  
        <i Include="a">  
            <o>o1</o>  
            <n>n2</n>  
        </i>  
    </ItemGroup>  
    ...  
</Project>  
```  
  
## See Also  
 [Project File Schema Reference](../VS_IDE/MSBuild-Project-File-Schema-Reference.md)   
 [Items](../VS_IDE/MSBuild-Items.md)