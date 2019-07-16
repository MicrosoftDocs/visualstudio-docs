---
title: "Item Definitions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "msbuild, item definitions"
ms.assetid: 8e3dc223-f9e5-4974-aa0e-5dc7967419cb
caps.latest.revision: 24
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Item Definitions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] 2.0 enables the static declaration of items in project files by using the [ItemGroup](../msbuild/itemgroup-element-msbuild.md) element. However, metadata may be added only at the item level, even if the metadata is identical for all items. Starting in [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] 3.5, a project element named [ItemDefinitionGroup](../msbuild/itemdefinitiongroup-element-msbuild.md) overcomes this limitation. *ItemDefinitionGroup* lets you define a set of item definitions, which add default metadata values to all items in the named item type.  
  
 The *ItemDefinitionGroup* element appears immediately after the [Project](../msbuild/project-element-msbuild.md) element of the project file. Item definitions provide the following functionality:  
  
- You can define global default metadata for items outside a target. That is, the same metadata applies to all items of the specified type.  
  
- Item types can have multiple definitions. When additional metadata specifications are added to the type, the last specification takes precedence. \(The metadata follows the same import order as properties follow.\)  
  
- Metadata can be additive. For example, CDefines values are accumulated conditionally, depending on the properties that are being set. For example, `MT;STD_CALL;DEBUG;UNICODE`.  
  
- Metadata can be removed.  
  
- Conditions can be used to control the inclusion of metadata.  
  
## Item Metadata Default Values  
 Item metadata that is defined in an ItemDefinitionGroup is just a declaration of default metadata. The metadata does not apply unless you define an Item that uses an ItemGroup to contain the metadata values.  
  
> [!NOTE]
> In many of the examples in this topic, an ItemDefinitionGroup element is shown but its corresponding ItemGroup definition is omitted for clarity.  
  
 Metadata explicitly defined in an ItemGroup takes precedence over metadata in ItemDefinitionGroup. Metadata in ItemDefinitionGroup is applied only for undefined metadata in an ItemGroup. For example:  
  
```  
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
```  
  
 In this example, the default metadata "m" is applied to Item "i" because metadata "m" is not explicitly defined by Item "i". However, default metadata "n" is not applied to Item "i" because metadata "n" is already defined by Item "i".  
  
> [!NOTE]
> XML Element and Parameter names are case\-sensitive. Item metadata and Item\/Property names are not case\-sensitive. Therefore, ItemDefinitionGroup items that have names that differ only by case should be treated as the same ItemGroup.  
  
## Value Sources  
 The values for metadata that is defined in an ItemDefinitionGroup can come from many different sources, as follows:  
  
- PropertyGroup Property  
  
- Item from an ItemDefinitionGroup  
  
- Item transform on an ItemDefinitionGroup Item  
  
- Environment variable  
  
- Global property \(from the MSBuild.exe command line\)  
  
- Reserved property  
  
- Well\-known metadata on an Item from an ItemDefinitionGroup  
  
- CDATA section \<\!\[CDATA\[anything here is not parsed\]\]\>  
  
> [!NOTE]
> Item metadata from an ItemGroup is not useful in an ItemDefinitionGroup metadata declaration because ItemDefinitionGroup elements are processed before ItemGroup elements.  
  
## Additive and Multiple Definitions  
 When you add definitions or use multiple ItemDefinitionGroups, remember the following:  
  
- Additional metadata specification is added to the type.  
  
- The last specification takes precedence.  
  
  When you have multiple ItemDefinitionGroups, each subsequent specification adds its metadata to the previous definition. For example:  
  
```  
<ItemDefinitionGroup>  
    <i>  
        <m>m1</m>  
        <n>n1</n>  
    </i>  
</ItemDefinitionGroup>  
<ItemDefinitionGroup>  
    <i>  
        <o>o1</o>  
    </i>  
</ItemDefinitionGroup>  
```  
  
 In this example, the metadata "o" is added to "m" and "n".  
  
 In addition, previously defined metadata values can also be added. For example:  
  
```  
<ItemDefinitionGroup>  
    <i>  
        <m>m1</m>  
    </i>  
</ItemDefinitionGroup>  
<ItemDefinitionGroup>  
    <i>  
        <m>%(m);m2</m>  
    </i>  
</ItemDefinitionGroup>    
```  
  
 In this example, the previously defined value for metadata "m" \(m1\) is added to the new value \(m2\), so that the final value is "m1;m2".  
  
> [!NOTE]
> This can also occur in the same ItemDefinitionGroup.  
  
 When you override the previously defined metadata, the last specification takes precedence. In the following example, the final value of metadata "m" goes from "m1" to "m1a".  
  
```  
<ItemDefinitionGroup>  
    <i>  
        <m>m1</m>  
    </i>  
</ItemDefinitionGroup>  
<ItemDefinitionGroup>  
    <i>  
        <m>m1a</m>  
    </i>  
</ItemDefinitionGroup>    
```  
  
## Using Conditions in an ItemDefinitionGroup  
 You can use conditions in an ItemDefinitionGroup to control the inclusion of metadata. For example:  
  
```  
<ItemDefinitionGroup Condition="'$(Configuration)'=='Debug'">  
    <i>  
        <m>m1</m>  
    </i>  
</ItemDefinitionGroup>  
```  
  
 In this case, the default metadata "m1" on item "i" is included only if the value of the "Configuration" property is "Debug".  
  
> [!NOTE]
> Only local metadata references are supported in conditions.  
  
 References to metadata defined in an earlier ItemDefinitionGroup are local to the item, not the definition group. That is, the scope of the references are item\-specific. For example:  
  
```  
<ItemDefinitionGroup>  
    <test>  
        <yes>1</yes>  
    </test>  
    <i>  
        <m Condition="'%(test.yes)'=='1'">m1</m>  
    </i>  
</ItemDefinitionGroup>  
```  
  
 In this example, item "i" references item "test" in the Condition.  
  
## Overriding and Deleting Metadata  
 Metadata defined in an ItemDefinitionGroup element can be overridden in a later ItemDefinitionGroup element by setting the metadata value to blank. You can also effectively delete a metadata item by setting it to an empty value. For example:  
  
```  
<ItemDefinitionGroup>  
    <i>  
        <m>m1</m>  
    </i>  
</ItemDefinitionGroup>  
<ItemDefinitionGroup>  
    <i>  
        <m></m>  
    </i>  
</ItemDefinitionGroup>  
```  
  
 The item "i" still contains metadata "m", but its value is now empty.  
  
## Scope of Metadata  
 ItemDefinitionGroups have global scope on defined and global properties wherever they are defined. Default metadata definitions in an ItemDefinitionGroup can be self\-referential. For example, the following uses a simple metadata reference:  
  
```  
<ItemDefinitionGroup>  
    <i>  
        <m>m1</m>  
        <m>%(m);m2</m>  
    </i>  
</ItemDefinitionGroup>  
```  
  
 A qualified metadata reference can also be used:  
  
```  
<ItemDefinitionGroup>  
    <i>  
      <m>m1</m>  
      <m>%(i.m);m2</m>  
    </i>  
</ItemDefinitionGroup>  
```  
  
 However, the following is not valid:  
  
```  
<ItemDefinitionGroup>  
    <i>  
        <m>m1</m>  
        <m>@(x)</m>  
    </i>  
</ItemDefinitionGroup>  
```  
  
 Beginning in [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] 3.5, ItemGroups can also be self\-referential. For example:  
  
```  
<ItemGroup>  
    <item Include="a">  
        <m>m1</m>  
        <m>%(m);m2</m>  
    </item>  
</ItemGroup>  
```  
  
## See Also  
 [Batching](../msbuild/msbuild-batching.md)
