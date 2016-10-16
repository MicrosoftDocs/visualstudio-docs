---
title: "Property Element (MSBuild)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<Property> Element [MSBuild]"
  - "Property Element [MSBuild]"
ms.assetid: 69ab08ab-3e76-41dd-a01b-49aa1d2e0cac
caps.latest.revision: 16
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Property Element (MSBuild)
Contains a user defined property name and value. Every property used in an [!INCLUDE[vstecmsbuild](../extensibility/includes/vstecmsbuild_md.md)] project must be specified as a child of a `PropertyGroup` element.  
  
 \<Project>  
 \<PropertyGroup>  
  
## Syntax  
  
```  
<Property Condition="'String A' == 'String B'">  
    Property Value  
</Property>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Condition`|Optional attribute.<br /><br /> Condition to be evaluated. For more information, see [Conditions](../reference/msbuild-conditions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[PropertyGroup](../reference/propertygroup-element--msbuild-.md)|Grouping element for properties.|  
  
## Text Value  
 A text value is optional.  
  
 This text specifies the property value and may contain XML.  
  
## Remarks  
 Property names are limited to ASCII chars only. Property values are referenced in the project by placing the property name between "`$(`" and "`)`". For example, `$(builddir)\classes` would resolve to "build\classes", if the `builddir` property had the value `build`. For more information on properties, see MSBuild Properties.  
  
## Example  
 The following code sets the `Optimization` property to `false` and the `DefaultVersion` property to `1.0` if the `Version` property is empty.  
  
```  
<PropertyGroup>  
    <Optimization>false</Optimization>  
    <DefaultVersion Condition="'$(Version)' == ''" >1.0</DefaultVersion>  
</PropertyGroup>  
```  
  
## See Also  
 [Project File Schema Reference](../reference/msbuild-project-file-schema-reference.md)