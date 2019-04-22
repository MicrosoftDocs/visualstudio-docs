---
title: "PropertyGroup Element (MSBuild) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#PropertyGroup"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<PropertyGroup> element [MSBuild]"
  - "PropertyGroup element [MSBuild]"
ms.assetid: ff1e6c68-b9a1-4263-a1ce-dc3b829a64d4
caps.latest.revision: 24
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# PropertyGroup Element (MSBuild)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Contains a set of user-defined [Property](../msbuild/property-element-msbuild.md) elements. Every `Property` element used in an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project must be a child of a `PropertyGroup` element.  
  
 \<Project>  
 \<PropertyGroup>  
  
## Syntax  
  
```  
<PropertyGroup Condition="'String A' == 'String B'">  
    <Property1>...</Property1>  
    <Property2>...</Property2>  
</PropertyGroup>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|Condition|Optional attribute.<br /><br /> Condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Property](../msbuild/property-element-msbuild.md)|Optional element.<br /><br /> A user defined property name, which contains the property value. There may be zero or more *Property* elements in a `PropertyGroup` element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../msbuild/project-element-msbuild.md)|Required root element of an [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] project file.|  
  
## Example  
 The following code example shows how to set properties based on a condition. In this example, if the value of the `CompileConfig` property is `DEBUG`, the `Optimization`, `Obfuscate`, and `OutputPath` properties inside of the `PropertyGroup` element are set.  
  
```  
<PropertyGroup Condition="'$(CompileConfig)' == 'DEBUG'" >  
    <Optimization>false</Optimization>  
    <Obfuscate>false</Obfuscate>  
    <OutputPath>$(OutputPath)\debug</OutputPath>  
</PropertyGroup>  
```  
  
## See Also  
 [Project File Schema Reference](../msbuild/msbuild-project-file-schema-reference.md)  
 [MSBuild Properties](msbuild-properties1.md)
